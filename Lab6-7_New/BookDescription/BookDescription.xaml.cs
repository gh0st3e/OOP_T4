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
using Microsoft.Win32;

namespace Lab6_7_New.BookDescription
{
    /// <summary>
    /// Логика взаимодействия для BookDescription.xaml
    /// </summary>
    public partial class BookDescription : Window
    {
        public Book_Model.Book CurrentBook;
        public BookDescription(Book_Model.Book book,string languagePath)
        {
            InitializeComponent();
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
            CurrentBook = book;
            ShowInfo();

        }

        public void ShowInfo()
        {
            BookName.Text = CurrentBook.Name;
            BookAuthor.Text = CurrentBook.Author;
            BookPrice.Text = CurrentBook.Price.ToString();
            BookCount.Text = CurrentBook.Count.ToString();
            BookDescr.Text = CurrentBook.Description.ToString();
            BookRate.Text = CurrentBook.Rate.ToString();
            if(CurrentBook.ImagePath!=null)
            {
                BookImage.Source = new BitmapImage(new Uri(CurrentBook.ImagePath));
            }
            
            MainWindow.MainForm.ShowLibrary();
        }

        private void BuyBook(object sender, RoutedEventArgs e)
        {
            if(CurrentBook.Count>0)
            {
                CurrentBook.Count--;
                ShowInfo();
                MainWindow.MainForm.ShowSelectedBooks();
            }
            
            
        }
    }
}
