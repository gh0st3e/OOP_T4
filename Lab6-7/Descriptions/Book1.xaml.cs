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

namespace Lab6_7.Descriptions
{
    /// <summary>
    /// Логика взаимодействия для Book1.xaml
    /// </summary>
    public partial class Book1 : Window
    {
        public Book book;
        public Book1(Book book)
        {
            InitializeComponent();
            this.book = book;
            ShowBook();
        }
        
        public void ShowBook()
        {
            Name.Content = book.Name;
            Author.Content = book.Author;
            Description.Text = book.Description;
            PriceValue.Content = book.Price;
            CountValue.Content = book.Count;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            book.Count--;
            MessageBox.Show("Спасибо за покупку");
            ShowBook();
        }
    }
}
