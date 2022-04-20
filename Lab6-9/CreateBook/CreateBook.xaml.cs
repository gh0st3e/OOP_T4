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

namespace Lab6_7_New.CreateBook
{
    /// <summary>
    /// Логика взаимодействия для CreateBook.xaml
    /// </summary>
    public partial class CreateBook : Window
    {
        public Book_Model.Book NewBook = new Book_Model.Book();
        public CreateBook(string languagePath)
        {
            InitializeComponent();
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (NewBookName.Text == "" || NewBookAuthor.Text == "" || NewBookPrice.Text == "" || NewBookCount.Text == "" || NewBookDescr.Text == "") 
                {
                    throw new Exception();
                }
                NewBook.Name = NewBookName.Text;
                NewBook.Author = NewBookAuthor.Text;
                NewBook.Price = int.Parse(NewBookPrice.Text);
                NewBook.Count = int.Parse(NewBookCount.Text);
                NewBook.Rate = int.Parse(NewBookRate.Text);
                NewBook.Sale = NewBookSale.Text;
                NewBook.Description = NewBookDescr.Text;
                if(TypeBook.IsChecked==true)
                {
                    NewBook.Type = "Book";
                }
                if (TypeMagazine.IsChecked == true)
                {
                    NewBook.Type = "Magazine";
                }
                if (TypeStudentBook.IsChecked == true)
                {
                    NewBook.Type = "StudentBook";
                }
                NewBook.ID = MainWindow.MainForm.books.Count;

                MainWindow.MainForm.books.Add(NewBook);

                
                

                MainWindow.MainForm.History.Add(MainWindow.MainForm.books.GetRange(0,MainWindow.MainForm.books.Count));
                MainWindow.MainForm.CurrentPosition++;

                MainWindow.MainForm.ShowLibrary();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введите даныне корректно");
            }
           
        }

        private void AddImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openDialog.ShowDialog() == true)
            {
                NewBook.ImagePath = openDialog.FileName;
                NewBookImage.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }

        private void NewBookName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NewBookName.Text == "")
            {
                TopName.Foreground = Brushes.Red;
            }
            else
            {
                TopName.Foreground = Brushes.Black;
            }
        }
    }
    
}
