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
    /// Логика взаимодействия для Informarion.xaml
    /// </summary>
    public partial class Informarion : Page
    {
        public Informarion()
        {
            InitializeComponent();
            InformationLV.ItemsSource = Connect.context.Information.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddEditInf(null));
            
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var delObj = InformationLV.SelectedItems.Cast<Information>().ToList();
            foreach (var delOb in delObj)
            {
                if (Connect.context.Accounting.Any(x => x.ElectronicsCode == delOb.ElectronicsCode))
                {
                    MessageBox.Show("Данные используются в таблице продаж", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            if (MessageBox.Show($"Удалить {delObj.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.context.Information.RemoveRange(delObj);
            try
            {
                Connect.context.SaveChanges();
                InformationLV.ItemsSource = Connect.context.Information.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error) ;
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
            InformationLV.ItemsSource = Connect.context.Information.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddEditInf((sender as Button).DataContext as Information));
        }
    }
}
