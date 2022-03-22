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
using System.Text.RegularExpressions;

namespace Lab6_7.CreateNewBook
{
    /// <summary>
    /// Логика взаимодействия для NewBook.xaml
    /// </summary>
    public partial class NewBook : Window
    {
        public Book newbook;
        public NewBook(string local)
        {
            InitializeComponent();
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri(local, UriKind.Relative);
            Resources.MergedDictionaries.Add(dict);
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            newbook = new Book(Name.Text, Author.Text, int.Parse(Price.Text),int.Parse(Count.Text), Desription.Text);
            CreateBook(newbook);
        }
        public void CreateBook(Book newbook)
        {
            if(MainWindow.Form1.arr[0]==0)
            {
                
                MainWindow.Form1.books.Insert(0,newbook);
                if(MainWindow.Form1.books.Count>1)
                {
                    MainWindow.Form1.books.RemoveAt(1);
                }
                
                MainWindow.Form1.Book1.Visibility = System.Windows.Visibility.Visible;
                MainWindow.Form1.BookName1.Text = newbook.Name;
                MainWindow.Form1.BookAuthor1.Text = newbook.Author;
                MainWindow.Form1.BookPrice1.Text = newbook.Price.ToString();
                MainWindow.Form1.arr[0] = 1;
                MainWindow.Form1.SortPrice();
                return;
            }
            if (MainWindow.Form1.arr[1] == 0)
            {
                MainWindow.Form1.books.Insert(1, newbook);
                if (MainWindow.Form1.books.Count > 2)
                {
                    MainWindow.Form1.books.RemoveAt(2);
                }
                    
                MainWindow.Form1.Book2.Visibility = System.Windows.Visibility.Visible;
                MainWindow.Form1.BookName2.Text = newbook.Name;
                MainWindow.Form1.BookAuthor2.Text = newbook.Author;
                MainWindow.Form1.BookPrice2.Text = newbook.Price.ToString();
                MainWindow.Form1.arr[1] = 1;
                MainWindow.Form1.SortPrice();
                return;
            }
            if (MainWindow.Form1.arr[2] == 0)
            {
                MainWindow.Form1.books.Insert(2, newbook);
                if (MainWindow.Form1.books.Count > 3)
                {
                    MainWindow.Form1.books.RemoveAt(3);
                }
                    
                MainWindow.Form1.Book3.Visibility = System.Windows.Visibility.Visible;
                MainWindow.Form1.BookName3.Text = newbook.Name;
                MainWindow.Form1.BookAuthor3.Text = newbook.Author;
                MainWindow.Form1.BookPrice3.Text = newbook.Price.ToString();
                MainWindow.Form1.arr[2] = 1;
                MainWindow.Form1.SortPrice();
                return;
            }
            if (MainWindow.Form1.arr[3] == 0)
            {
                MainWindow.Form1.books.Insert(3, newbook);
                if (MainWindow.Form1.books.Count > 4)
                {
                    MainWindow.Form1.books.RemoveAt(4);
                }
                MainWindow.Form1.Book4.Visibility = System.Windows.Visibility.Visible;
                MainWindow.Form1.BookName4.Text = newbook.Name;
                MainWindow.Form1.BookAuthor4.Text = newbook.Author;
                MainWindow.Form1.BookPrice4.Text =  newbook.Price.ToString();
                MainWindow.Form1.arr[3] = 1;
                MainWindow.Form1.SortPrice();
                return;
            }
            if (MainWindow.Form1.arr[4] == 0)
            {
                MainWindow.Form1.books.Insert(4, newbook);
                if (MainWindow.Form1.books.Count > 5)
                {
                    MainWindow.Form1.books.RemoveAt(5);
                }
                MainWindow.Form1.Book5.Visibility = System.Windows.Visibility.Visible;
                MainWindow.Form1.BookName5.Text = newbook.Name;
                MainWindow.Form1.BookAuthor5.Text = newbook.Author;
                MainWindow.Form1.BookPrice5.Text = newbook.Price.ToString();
                MainWindow.Form1.arr[4] = 1;
                MainWindow.Form1.SortPrice();
                return;
            }
            else
            {
                MainWindow.Form1.books.Insert(MainWindow.Form1.books.Count, newbook);
            }
        
            
            
        }

        private void AddImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            
            if (openDialog.ShowDialog() == true)
            {
                
                if (MainWindow.Form1.Places[0] == 0)
                {
                    MainWindow.Form1.Book1Image.Source = new BitmapImage(new Uri(openDialog.FileName));
                    CreateImage.Source = new BitmapImage(new Uri(openDialog.FileName));
                }
                if (MainWindow.Form1.Places[1] == 0)
                {
                    MainWindow.Form1.Book2Image.Source = new BitmapImage(new Uri(openDialog.FileName));
                    CreateImage.Source = new BitmapImage(new Uri(openDialog.FileName));
                }
                if (MainWindow.Form1.Places[2] == 0)
                {
                    MainWindow.Form1.Book3Image.Source = new BitmapImage(new Uri(openDialog.FileName));
                    CreateImage.Source = new BitmapImage(new Uri(openDialog.FileName));
                }
                if (MainWindow.Form1.Places[3] == 0)
                {
                    MainWindow.Form1.Book4Image.Source = new BitmapImage(new Uri(openDialog.FileName));
                    CreateImage.Source = new BitmapImage(new Uri(openDialog.FileName));
                }
                if (MainWindow.Form1.Places[4] == 0)
                {
                    MainWindow.Form1.Book5Image.Source = new BitmapImage(new Uri(openDialog.FileName));
                    CreateImage.Source = new BitmapImage(new Uri(openDialog.FileName));
                }


            }
        }
    }
}
