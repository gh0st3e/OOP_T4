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

namespace Lab6_7_New.EditBook
{
    /// <summary>
    /// Логика взаимодействия для EditBook.xaml
    /// </summary>
    public partial class EditBook : Window
    {
        public Book_Model.Book CurrentBook;
        public EditBook(Book_Model.Book book,string languagePath)
        {
            InitializeComponent();

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);

            CurrentBook = book;
            EditBookName.Text = book.Name;
            EditBookAuthor.Text = book.Author;
            EditBookPrice.Text = book.Price.ToString();
            EditBookCount.Text = book.Count.ToString();
            EditBookRate.Text = book.Rate.ToString();
            EditBookSale.Text = book.Sale;
            EditBookDescr.Text = book.Description;

            if(book.Type=="Book")
            {
                TypeBook.IsChecked = true;
            }
            if (book.Type == "Magazine")
            {
                TypeMagazine.IsChecked = true;
            }
            if (book.Type == "StudentBook")
            {
                TypeStudentBook.IsChecked = true;
            }
        

    }


        private void EditCurrentBook(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EditBookName.Text != "")
                {
                    CurrentBook.Name = EditBookName.Text;
                }
                if (EditBookAuthor.Text != "")
                {
                    CurrentBook.Author = EditBookAuthor.Text;
                }
                if (EditBookPrice.Text != "")
                {
                    CurrentBook.Price = int.Parse(EditBookPrice.Text);
                }
                if (EditBookCount.Text != "")
                {
                    CurrentBook.Count = int.Parse(EditBookCount.Text);
                }
                if (EditBookDescr.Text != "")
                {
                    CurrentBook.Description = EditBookDescr.Text;
                }
                if (EditBookRate.Text != "") 
                {
                    CurrentBook.Rate = int.Parse(EditBookRate.Text);
                }
                if(EditBookSale.Text != "")
                {
                    CurrentBook.Sale = EditBookSale.Text;
                }
                MainWindow.MainForm.ShowLibrary();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введите данные корректно");
            }
        }

        private void EditCurrentImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openDialog.ShowDialog() == true)
            {
                CurrentBook.ImagePath = openDialog.FileName;
                EditBookImage.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }
    }
}
