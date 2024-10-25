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
    /// Логика взаимодействия для Transition.xaml
    /// </summary>
    public partial class Transition : Page
    {
        public Transition()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new LinqAcc());
        }

        private void RefrBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new LinqInf());
        }
    }
}
