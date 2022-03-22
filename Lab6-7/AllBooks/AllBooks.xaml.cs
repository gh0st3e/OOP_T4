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
using System.Collections.ObjectModel;

namespace Lab6_7.AllBooks
{
    /// <summary>
    /// Логика взаимодействия для AllBooks.xaml
    /// </summary>
    /// 
    
    public partial class AllBooks : Window
    {
        public List<Book> allbooks;
        public AllBooks(List<Book> books)
        {
            InitializeComponent();

            
            allbooks = books;
            int count = 0;
            var orderedList = from i in allbooks
                                 orderby i.Count
                                 select i;
            foreach(Book book in orderedList)
            {
                allbooks[count] = book;
                count++;
            }

            ShowAllBookkk();
            
        }
        public void ShowAllBookkk()
        {
            BooksList.ItemsSource = allbooks;

        }

        private void Descr(object sender, RoutedEventArgs e)
        {
            
            int index = int.Parse(e.Source.ToString().Last().ToString());
            
            Descriptions.Book1 BookDescr = new Descriptions.Book1(allbooks[index]);
            BookDescr.Show();
        }

        private void Del(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(e.Source.ToString().Last().ToString());
            
            
                allbooks.RemoveAt(index);


            for (int i = index; i > MainWindow.Form1.books.Count; i--) 
            {
                MainWindow.Form1.books[i].ID--;
            }
            if (index == 0)
            {
                MainWindow.Form1.Places[0] = 0;
                MainWindow.Form1.Book1.Visibility = System.Windows.Visibility.Hidden;
                MainWindow.Form1.SortPrice();
            }
            if (index == 1)
            {
                MainWindow.Form1.Places[1] = 0;
                MainWindow.Form1.Book2.Visibility = System.Windows.Visibility.Hidden;
                MainWindow.Form1.SortPrice();
            }
            if (index == 2)
            {
                MainWindow.Form1.Places[2] = 0;
                MainWindow.Form1.Book3.Visibility = System.Windows.Visibility.Hidden;
                MainWindow.Form1.SortPrice();
            }
            if (index == 3)
            {
                MainWindow.Form1.Places[3] = 0;
                MainWindow.Form1.Book4.Visibility = System.Windows.Visibility.Hidden;
                MainWindow.Form1.SortPrice();
            }
            if (index == 4)
            {
                MainWindow.Form1.Places[4] = 0;
                MainWindow.Form1.Book5.Visibility = System.Windows.Visibility.Hidden;
                MainWindow.Form1.SortPrice();
            }
            this.Close();
            
        }

        private void Edit(object sender, RoutedEventArgs e)
        {

        }
    }

}
