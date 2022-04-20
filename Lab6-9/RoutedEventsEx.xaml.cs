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
using System.Windows.Shapes;

namespace Lab6_7_New
{
    /// <summary>
    /// Логика взаимодействия для RoutedEventsEx.xaml
    /// </summary>
    public partial class RoutedEventsEx : Window
    {
        public RoutedEventsEx()
        {
            InitializeComponent();
        }

        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            textBlock1.Text = textBlock1.Text + "sender: " + sender.ToString() + "\n";
            textBlock1.Text = textBlock1.Text + "source: " + e.Source.ToString() + "\n\n";
        }


    }
    public abstract class ButtonBase : ContentControl
{
        // определение событие
        public static readonly RoutedEvent ClickEvent;

        static ButtonBase()
        {
            // регистрация маршрутизированного события
            ButtonBase.ClickEvent = EventManager.RegisterRoutedEvent("Click",
                RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ButtonBase));
            //................................
        }
        // обертка над событием
        public event RoutedEventHandler Click
        {
            add
            {
                // добавление обработчика
                base.AddHandler(ButtonBase.ClickEvent, value);
            }
            remove
            {
                // удаление обработчика
                base.RemoveHandler(ButtonBase.ClickEvent, value);
            }
        }
        // остальное содержимое класса
    }
}
