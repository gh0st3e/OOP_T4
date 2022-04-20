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

namespace Lab6_7_New
{
    /// <summary>
    /// Логика взаимодействия для FirstUserControl.xaml
    /// </summary>
    /// 
    
    public partial class FirstUserControl : UserControl
    {
        public FirstUserControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Magazine mag = (Magazine)this.Resources["ModernMagazine"]; // получаем ресурс по ключу
            MessageBox.Show("Цена журнала " + mag.Title + " равна " + mag.Price.ToString());
        }
    }
}
