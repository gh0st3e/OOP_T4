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
    /// Логика взаимодействия для SelectByType.xaml
    /// </summary>
    public partial class SelectByType : Window
    {
        public List<Book_Model.Book> CurrentBooks;
        public SelectByType(List<Book_Model.Book> books,string languagePath)
        {
            InitializeComponent();

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);

            CurrentBooks = books;
        }

        private void Find(object sender, RoutedEventArgs e)
        {
            MainWindow.MainForm.ChoosedBooks.Clear();
            if (TypeBook.IsChecked == true)
            {
                foreach(Book_Model.Book book in CurrentBooks)
                {
                    if(book.Type == "Book")
                    {
                        MainWindow.MainForm.ChoosedBooks.Add(book);
                    }
                }
            }
            if (TypeMagazine.IsChecked == true)
            {
                foreach (Book_Model.Book book in CurrentBooks)
                {
                    if (book.Type == "Magazine")
                    {
                        MainWindow.MainForm.ChoosedBooks.Add(book);
                    }
                }
            }
            if (TypeStudentBook.IsChecked == true)
            {
                foreach (Book_Model.Book book in CurrentBooks)
                {
                    if (book.Type == "StudentBook")
                    {
                        MainWindow.MainForm.ChoosedBooks.Add(book);
                    }
                }
            }
            MainWindow.MainForm.ShowSelectedBooks();
            this.Close();
        }
    }
}
