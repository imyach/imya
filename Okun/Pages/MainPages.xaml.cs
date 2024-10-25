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
    /// Логика взаимодействия для MainPages.xaml
    /// </summary>
    public partial class MainPages : Page
    {
        public MainPages()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Accounting());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Informarion());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Transition());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Transition());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Transition());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new TransitionExPdf());
        }
    }
}
