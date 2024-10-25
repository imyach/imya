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
    /// Логика взаимодействия для LinqInf.xaml
    /// </summary>
    public partial class LinqInf : Page
    {
        public LinqInf()
        {
            InitializeComponent();
            var cmbFil = Connect.context.Information.OrderBy(x=>x.Type).ToList();
            cmbFil.Insert(0, new Information { Type = "По умолчанию" });
            TypeFilt.ItemsSource = cmbFil.Select(x => x.Type).ToList().Distinct(); 
            TypeFilt.SelectedIndex = 0;  
        }

        void Update()
        {
            var inf = Connect.context.Information.ToList();
            inf = inf.Where(x=>x.Category.ToString().ToLower().Contains(CategoryTbx.Text.ToLower())).ToList();
            
            if(TypeFilt.SelectedIndex > 0)
                inf = inf.Where(x => x.Type.ToString().Contains(TypeFilt.SelectedItem.ToString())).ToList();

            InformationLV.ItemsSource = inf;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void DateTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void DateFilt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }
    }
}
