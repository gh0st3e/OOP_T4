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
using System.Text.RegularExpressions;

namespace Lab6_7_New.SeachBook
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public string LanguagePath;
        public Search(string languagePath)
        {
            InitializeComponent();

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
            LanguagePath = languagePath;
        }

        private void FindBook(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(FindName.Text);
            foreach(Book_Model.Book book in MainWindow.MainForm.books)
            {
                if(regex.IsMatch(book.Name))
                {
                    BookDescription.BookDescription bookDescription = new BookDescription.BookDescription(book,LanguagePath);
                    bookDescription.Show();
                }
            }
        }
    }
}
