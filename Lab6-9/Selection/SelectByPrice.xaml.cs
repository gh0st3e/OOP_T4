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

namespace Lab6_7_New.Selection
{
    /// <summary>
    /// Логика взаимодействия для SelectByPrice.xaml
    /// </summary>
    public partial class SelectByPrice : Window
    {
        public List<Book_Model.Book> CurrentBooks;
        public SelectByPrice(List<Book_Model.Book> Books, string languagePath)
        {
            InitializeComponent();

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);

            CurrentBooks = Books;
        }

        private void Find(object sender, RoutedEventArgs e)
        {
            MainWindow.MainForm.ChoosedBooks.Clear();
            foreach (Book_Model.Book book in CurrentBooks)
            {
                if(book.Price>=int.Parse(lowPrice.Text) && book.Price<=int.Parse(highPrice.Text))
                {
                    MainWindow.MainForm.ChoosedBooks.Add(book);
                }
            }
            MainWindow.MainForm.ShowSelectedBooks();
            this.Close();
        }
    }
}
