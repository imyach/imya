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
using Okun.AppData;

namespace Okun.Pages
{
    /// <summary>
    /// Логика взаимодействия для Accounting.xaml
    /// </summary>
    public partial class Accounting : Page
    {
        public Accounting()
        {
            InitializeComponent();
            AccountingLV.ItemsSource = Connect.context.Accounting.ToList();

        }


        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddEditAcc(new AppData.Accounting() { Information = Connect.context.Information.FirstOrDefault(), DateOfReceipt = DateTime.Now.Date }));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var delObj = AccountingLV.SelectedItems.Cast<AppData.Accounting>().ToList();
            if (MessageBox.Show($"Удалить {delObj.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.context.Accounting.RemoveRange(delObj);
            try
            {
                Connect.context.SaveChanges();
                AccountingLV.ItemsSource = Connect.context.Accounting.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void RefrBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AccountingLV.ItemsSource = Connect.context.Accounting.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddEditAcc((sender as Button).DataContext as AppData.Accounting));
        }
    }
}
