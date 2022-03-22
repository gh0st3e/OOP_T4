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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Xml.Serialization;


namespace Lab6_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public static MainWindow Form1;
        public int[] arr = new int[5] { 0, 0, 0, 0, 0};
        public List<Book> books = new List<Book>();
        public int[] Places = new int[5] { 0, 0, 0, 0, 0 };
        public bool lang = true;
        public string local = @"..\Dictionary.ru-RU.xaml";
        
        public MainWindow()
        {
            InitializeComponent();
            FillContent();
            Form1 = this;
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri(@"..\RuLang.xaml", UriKind.Relative);
            local = @"..\RuLang.xaml";
            Resources.MergedDictionaries.Add(dict);
        }
        

        public void FillContent()
        {
            //Book book1 = new Book("test", "test", 999999999,999999999, "test");
            //books.Add(book1);
            //books.Add(book1);
            //books.Add(book1);
            //books.Add(book1);
            //books.Add(book1);
        }
        public void CreateNew(object sender, RoutedEventArgs e)
        {
            CreateNewBook.NewBook NewBook = new CreateNewBook.NewBook(local);
            NewBook.Show();
        }
        public void Book1Description(object sender, RoutedEventArgs e)
        {
            Descriptions.Book1 Book1 = new Descriptions.Book1(books[0]);
            Book1.book = books[0];
            Book1.Show();
           
        }
        private void Book2Description(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i >= 0; i--)
            {
                try
                {
                    Descriptions.Book1 Book1 = new Descriptions.Book1(books[i]);
                    Book1.Show();
                    Book1.book = books[i];
                    return;
                }
                catch
                {

                }
            }
            
            
        }
        private void Book3Desription(object sender, RoutedEventArgs e)
        {
            for (int i = 2; i >= 0; i--)
            {
                try
                {
                    Descriptions.Book1 Book1 = new Descriptions.Book1(books[i]);
                    Book1.Show();
                    Book1.book = books[i];
                    return;
                }
                catch
                {

                }
            }
        }
        private void Book4Desription(object sender, RoutedEventArgs e)
        {
            for (int i=3; i >= 0; i--)
            {
                try
                {
                    Descriptions.Book1 Book1 = new Descriptions.Book1(books[i]);
                    Book1.Show();
                    Book1.book = books[i];
                    return;
                }
                catch
                {

                }
            }
        }
        private void Book5Description(object sender, RoutedEventArgs e)
        {
            for (int i = 4; i >= 0; i--)
            {
                try
                {
                    Descriptions.Book1 Book1 = new Descriptions.Book1(books[i]);
                    Book1.Show();
                    Book1.book = books[i];
                    return;
                }
                catch
                {

                }
            }
        }
        private void Book1Delete(object sender, RoutedEventArgs e)
        {
            Book1.Visibility = System.Windows.Visibility.Hidden;
            arr[0] = 0;
            Book1Image.Source = null;
            SortPrice();
        }
        private void Book2Delete(object sender, RoutedEventArgs e)
        {
            Book2.Visibility = System.Windows.Visibility.Hidden;
            arr[1] = 0;
            Book2Image.Source = null;
            SortPrice();
        }
        private void Book3Delete(object sender, RoutedEventArgs e)
        {
            Book3.Visibility = System.Windows.Visibility.Hidden;
            arr[2] = 0;
            Book3Image.Source = null;
            SortPrice();
        }
        private void Book4Delete(object sender, RoutedEventArgs e)
        {
            Book4.Visibility = System.Windows.Visibility.Hidden;
            arr[3] = 0;
            Book4Image.Source = null;
            SortPrice();
        }
        private void Book5Delete(object sender, RoutedEventArgs e)
        {
            Book5.Visibility = System.Windows.Visibility.Hidden;
            arr[4] = 0;
            Book5Image.Source = null;
            SortPrice();
        }

        public void SortPrice()
        {
            int place = 0;
            int[] Prices = new int[5] { int.Parse(BookPrice1.Text), int.Parse(BookPrice2.Text), int.Parse(BookPrice3.Text), int.Parse(BookPrice4.Text), int.Parse(BookPrice5.Text) };
            for (int i = 0; i < 5; i++)
            {
                Places[i] = 0;
            }
            Prices.OrderBy(x => x);
            Array.Sort(Prices);

            for (int i = 0; i < 5; i++)
            {
                if (int.Parse(BookPrice1.Text) == Prices[i] && Places[0] == 0 && Book1.Visibility == System.Windows.Visibility.Visible)
                {
                    Places[0] = 1;
                    Grid.SetColumn(Book1, place);
                    place++;
                    continue;
                }
                if (int.Parse(BookPrice2.Text) == Prices[i] && Places[1] == 0 && Book2.Visibility == System.Windows.Visibility.Visible)
                {
                    Places[1] = 1;
                    Grid.SetColumn(Book2, place);
                    place++;
                    continue;
                }
                if (int.Parse(BookPrice3.Text) == Prices[i] && Places[2] == 0 && Book3.Visibility == System.Windows.Visibility.Visible)
                {
                    Places[2] = 1;
                    Grid.SetColumn(Book3, place);
                    place++;
                    continue;
                }
                if (int.Parse(BookPrice4.Text) == Prices[i] && Places[3] == 0 && Book4.Visibility == System.Windows.Visibility.Visible)
                {
                    Places[3] = 1;
                    Grid.SetColumn(Book4, place);
                    place++;
                    continue;
                }
                if (int.Parse(BookPrice5.Text) == Prices[i] && Places[4] == 0 && Book5.Visibility == System.Windows.Visibility.Visible)
                {
                    Places[4] = 1;
                    Grid.SetColumn(Book5, place);
                    place++;
                    continue;
                }
            }
        }
        
        public void SortCount()
        {
            int place = 0;
            int[] Counts = new int[5] { books[0].Count, books[1].Count, books[2].Count, books[3].Count, books[4].Count };
            for (int i = 0; i < 5; i++)
            {
                Places[i] = 0;
            }
            Counts.OrderBy(x => x);
            Array.Sort(Counts);

            for (int i = 0; i < 5; i++)
            {
                if (books[0].Count == Counts[i] && Places[0] == 0 && Book1.Visibility == System.Windows.Visibility.Visible)
                {
                    Places[0] = 1;
                    Grid.SetColumn(Book1, place);
                    place++;
                    continue;
                }
                if (books[1].Count == Counts[i] && Places[1] == 0 && Book2.Visibility == System.Windows.Visibility.Visible)
                {
                    Places[1] = 1;
                    Grid.SetColumn(Book2, place);
                    place++;
                    continue;
                }
                if (books[2].Count == Counts[i] && Places[2] == 0 && Book3.Visibility == System.Windows.Visibility.Visible)
                {
                    Places[2] = 1;
                    Grid.SetColumn(Book3, place);
                    place++;
                    continue;
                }
                if (books[3].Count == Counts[i] && Places[3] == 0 && Book4.Visibility == System.Windows.Visibility.Visible)
                {
                    Places[3] = 1;
                    Grid.SetColumn(Book4, place);
                    place++;
                    continue;
                }
                if (books[4].Count == Counts[i] && Places[4] == 0 && Book5.Visibility == System.Windows.Visibility.Visible)
                {
                    Places[4] = 1;
                    Grid.SetColumn(Book5, place);
                    place++;
                    continue;
                }
            }
        }

        public void SortBooksPrice(object sender, RoutedEventArgs e)
        {
            SortPrice();
        }

        private void SortBooksCount(object sender, RoutedEventArgs e)
        {
            SortCount();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            
            Book[] XMLBooks = new Book[5] { books[0], books[0], books[0], books[0], books[0]};
            for(int i = 0; i < books.Count; i++)
            {
                XMLBooks.Append(new Book("a","a",1,1,"a"));
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Book[]));
            using (FileStream fs = new FileStream("books.xml", FileMode.Create))
            {
                XmlRootAttribute xRoot = new XmlRootAttribute();
                xRoot.ElementName = "book";
                
                

                XmlSerializer xs = new XmlSerializer(typeof(Book[]), xRoot);
                xs.Serialize(fs, XMLBooks);
            }
                
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Book));

            // десериализуем объект
            using (FileStream fs = new FileStream("books.xml", FileMode.OpenOrCreate))
            {
                
                Book[] SavedBooks = xmlSerializer.Deserialize(fs) as Book[];
                if (SavedBooks != null)
                {
                    foreach (Book book in SavedBooks)
                    {
                        MessageBox.Show(book.Name);
                    }
                }
                    
                
            }
        }

        private void ChangeLanguage(object sender, RoutedEventArgs e)
        {
            if(lang)
            {
                lang = false;
                
                ResourceDictionary dict = new ResourceDictionary();
                dict.Source = new Uri(@"..\EngLang.xaml", UriKind.Relative);
                local = @"..\EngLang.xaml";
                Resources.MergedDictionaries.Add(dict);
            }
            else
            {
                lang = true;
                ResourceDictionary dict = new ResourceDictionary();
                dict.Source = new Uri(@"..\RuLang.xaml", UriKind.Relative);
                local = @"..\RuLang.xaml";
                Resources.MergedDictionaries.Add(dict);
            }
        }

        private void ShowAllBooks(object sender, RoutedEventArgs e)
        {
            List<Book> Library = books;
            AllBooks.AllBooks allBooks = new AllBooks.AllBooks(Library);
            
            allBooks.Show();
        }
    }
}
