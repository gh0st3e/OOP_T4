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
    /// Логика взаимодействия для SecondUserControl.xaml
    /// </summary>
    public partial class SecondUserControl : UserControl
    {
        public bool redActive = false;
        public bool greenActive = false;
        public bool blueActive = false;
        public SecondUserControl()
        {
            InitializeComponent();
        }

        public void ChangeColor()
        {
            ColorField.Background = null;
            if(redActive)
            {
                ColorField.Background = new SolidColorBrush(Colors.Red);
                if(greenActive)
                {
                    ColorField.Background = new SolidColorBrush(Colors.Brown);
                    if (blueActive)
                    {
                        ColorField.Background = new SolidColorBrush(Colors.Gray);
                    }
                }
                if (blueActive)
                {
                    ColorField.Background = new SolidColorBrush(Colors.Violet);
                    if (greenActive)
                    {
                        ColorField.Background = new SolidColorBrush(Colors.Gray);
                    }
                }
                return;


            }
            if (greenActive)
            {
                ColorField.Background = new SolidColorBrush(Colors.Green);
                if (redActive)
                {
                    ColorField.Background = new SolidColorBrush(Colors.Brown);
                    if (blueActive)
                    {
                        ColorField.Background = new SolidColorBrush(Colors.Gray);
                    }
                }
                if (blueActive)
                {
                    ColorField.Background = new SolidColorBrush(Colors.LightBlue);
                    if (redActive)
                    {
                        ColorField.Background = new SolidColorBrush(Colors.Gray);
                    }
                }
                return;
            }
            if (blueActive)
            {
                ColorField.Background = new SolidColorBrush(Colors.Blue);
                if (redActive)
                {
                    ColorField.Background = new SolidColorBrush(Colors.Violet);
                    if (blueActive)
                    {
                        ColorField.Background = new SolidColorBrush(Colors.Gray);
                    }
                }
                if (greenActive)
                {
                    ColorField.Background = new SolidColorBrush(Colors.LightBlue);
                    if (redActive)
                    {
                        ColorField.Background = new SolidColorBrush(Colors.Gray);
                    }
                }
                return;
            }     
        }

        private void RedC(object sender, RoutedEventArgs e)
        {
            if (!redActive)
            {
                RedBtn.Background = new SolidColorBrush(Colors.Red);
                redActive = true;
                ChangeColor();
            }
            else
            {
                RedBtn.Background = new SolidColorBrush(Colors.Gray);
                redActive = false;
                ChangeColor();
            }
            
        }

        private void GreenC(object sender, RoutedEventArgs e)
        {
            if (!greenActive)
            {
                GreenBtn.Background = new SolidColorBrush(Colors.Green);
                greenActive = true;
                ChangeColor();
            }
            else
            {
                GreenBtn.Background = new SolidColorBrush(Colors.Gray);
                greenActive = false;
                ChangeColor();
            }
        }

        private void BlueC(object sender, RoutedEventArgs e)
        {
            if (!blueActive)
            {
                BlueBtn.Background = new SolidColorBrush(Colors.Blue);
                blueActive = true;
                ChangeColor();
            }
            else
            {
                BlueBtn.Background = new SolidColorBrush(Colors.Gray);
                blueActive = false;
                ChangeColor();
            }
        }
    }
}
