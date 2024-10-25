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
using ControlzEx.Standard;
using Okun.AppData;

namespace Okun.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditInf.xaml
    /// </summary>
    public partial class AddEditInf : Page
    {
        Information inf;
        bool checkNew;
        public AddEditInf(Information c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new Information();
                checkNew = true;
            }
            else 
                checkNew = false;
            DataContext = inf = c;

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
        public static bool CheckInformation(Information inf)
        {

            if (string.IsNullOrEmpty(inf.Name) || !inf.Name.Replace(" ", "").All(char.IsLetter))
                return false;
            if (inf.Prise < 0)
                return false;
            if (string.IsNullOrEmpty(inf.Type) || !inf.Type.Replace(" ", "").All(char.IsLetter))
                return false;
            if (string.IsNullOrEmpty(inf.Category) || !inf.Category.Replace(" ", "").All(char.IsLetter))
                return false;
            return true;
        }


        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (checkNew)
            {
                Connect.context.Information.Add(inf);
            }
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
    }
}
