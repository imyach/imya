using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ControlzEx.Standard;
using Okun.AppData;

namespace Okun.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditAcc.xaml
    /// </summary>
    /// 
    public partial class AddEditAcc : System.Windows.Controls.Page
    {
        AppData.Accounting acc;
        public AddEditAcc(AppData.Accounting c)
        {
            InitializeComponent();
            InfCmb.ItemsSource = Connect.context.Information.ToList();
            DataContext = acc = c;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (acc.RecordNumber == 0)
                Connect.context.Accounting.Add(acc);
            try
            {
                Connect.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
                Nav.MainFrame.GoBack();

        }

        public static bool CheckAccounting(AppData.Accounting acc)
        {
            if(string.IsNullOrEmpty(acc.FIO)|| !acc.FIO.Replace(" ", "").All(char.IsLetter))
                return false;
            if (acc.DateOfReceipt == null)
                return false;
            if (acc.QuantityProduct < 0)
                return false;
            return true;

        }



        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
        Nav.MainFrame.GoBack();
        }
    }
}
