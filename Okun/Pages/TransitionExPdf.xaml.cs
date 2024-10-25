using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;
using Okun.AppData;
using System.Drawing;
using System.Net;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Okun.Pages
{
    /// <summary>
    /// Логика взаимодействия для TransitionExPdf.xaml
    /// </summary>
    public partial class TransitionExPdf : Page
    {
        public TransitionExPdf()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var acc = Connect.context.Accounting.ToList();
            var inf = Connect.context.Information.ToList();
            Excel.Application app = new Excel.Application();
            app.Visible = true;
            Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet ws = (Excel.Worksheet)app.Worksheets.get_Item(1);
            ws.Name = "Учётная  таблица";
            Excel.Range r = ws.Range["A1", "E2"];
            r.Merge();
            r.Value = "Ведомость поставки товаров";
            r.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            r.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            ws.Cells.Font.Name = "Times New Roman";
            ws.Cells[3,1].Value = "Наименование товара";
            ws.Cells[3,2].Value = "Тип";
            ws.Cells[3,3].Value = "Цена";
            ws.Cells[3,4].Value = "Кол-во прихода";
            ws.Cells[3,5].Value = "Стоимость";
            var curRow = 4;
            int sum = 0;
            foreach (var item in acc)
            {
                ws.Cells[curRow, 1].Value = item.Information.Name;
                ws.Cells[curRow, 2].Value = item.Information.Type;
                ws.Cells[curRow, 3].Value = item.Information.Prise;
                ws.Cells[curRow, 4].Value = item.QuantityProduct;
                ws.Cells[curRow, 5].Value = item.QuantityProduct * item.Information.Prise;
                sum += item.QuantityProduct * item.Information.Prise;

                curRow++;
            }

            ws.Cells[curRow, 1].Value = "Итого: ";
            ws.Cells[curRow, 5].Value = sum;
            Excel.Range range = ws.Range[ws.Cells[curRow, 1],ws.Cells[curRow , 4]];
            range.Merge();

            Excel.Range ran = ws.Range[ws.Cells[3, 1], ws.Cells[curRow, 5]];
            ran.Borders.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);


            ws.Columns.AutoFit();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "Ведомость поставки товаров");
            wb.SaveAs(filePath);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream("Ведомость.pdf", FileMode.Create));
                doc.Open();
                BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                PdfPTable table = new PdfPTable(5);
                PdfPCell cell = new PdfPCell(new Phrase("Ведомость поставки товаров",font));
                cell.Colspan = 5;
                cell.HorizontalAlignment= 1;
                cell.Border = 0;
                table.AddCell(cell);
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Наименование товара", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Тип", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Цена", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Кол-во прихода", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Стоимость", font))));
                int sum = 0;
                foreach(var item in Connect.context.Accounting.ToList())
                {
                    table.AddCell(new Phrase(item.Information.Name.ToString(), font));
                    table.AddCell(new Phrase(item.Information.Type.ToString(), font));
                    table.AddCell(new Phrase(item.Information.Prise.ToString(), font));
                    table.AddCell(new Phrase(item.QuantityProduct.ToString(), font));
                    table.AddCell(new Phrase((item.QuantityProduct * item.Information.Prise).ToString(), font));
                    sum += item.QuantityProduct * item.Information.Prise;
                }
                
                table.AddCell(new Phrase("Итого: " , font));
                table.AddCell(new Phrase("" , font));
                table.AddCell(new Phrase("" , font));
                table.AddCell(new Phrase("" , font));
                table.AddCell(new Phrase(sum.ToString(), font));             

                doc.Add(table);
                doc.Close();
                MessageBox.Show("PDF-документ сохранён");
            }
            catch
            {
                MessageBox.Show("PDF-документ не сохранён", "Ошибка");
            }
        }

        private void RefrBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
    }
}
