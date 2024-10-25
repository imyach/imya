using Okun.AppData;
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

namespace Okun.Pages
{
    /// <summary>
    /// Логика взаимодействия для LinqAcc.xaml
    /// </summary>
    public partial class LinqAcc : Page
    {
        public LinqAcc()
        {
            InitializeComponent();
            NameSrt.ItemsSource = new[] { "По умолчанию", "По возврастанию", "По убыванию" };
            NameSrt.SelectedIndex = 0; 
        }


        void Update()
        {
            var acc = Connect.context.Accounting.ToList();
            acc = acc.Where(x => x.DateOfReceipt.ToString().Contains(DateTbx.Text)).ToList();
            acc = acc.Where(x => x.QuantityProduct.ToString().Contains(QuanProdTbx.Text)).ToList();

            switch (NameSrt.SelectedIndex)
            {
                case 1:
                    acc = acc.OrderBy(x => x.FIO).ToList();
                    break;
                case 2:
                    acc = acc.OrderByDescending(x => x.FIO).ToList();
                    break;
            }
           if(DateFilt!=null)
            {
                acc = acc.Where(x=> x.DateOfReceipt.ToString().Contains(DateFilt.SelectedDate.ToString())).ToList();
            }
            AccountingLV.ItemsSource = acc;
        }

        private void DateTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void QuqnProdTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void NameSrt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void DateFilt_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
    }
}
