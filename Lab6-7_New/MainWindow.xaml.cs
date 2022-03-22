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
using System.IO;
using System.Xml.Serialization;
using System.Windows.Resources;


namespace Lab6_7_New
{
    public partial class MainWindow : Window
    {
        public static MainWindow MainForm;
        public List<Book_Model.Book> books = new List<Book_Model.Book>();
        public List<Book_Model.Book> ChoosedBooks = new List<Book_Model.Book>();
        public string languagePath;
        public MainWindow()
        {
            InitializeComponent();
            MainForm = this;

            this.MaxHeight = 900;
            this.MaxWidth = 1600;
            this.MinHeight = 900;
            this.MinWidth = 1600;

            StreamResourceInfo sri = Application.GetResourceStream(
            new Uri("../mycursor.ani", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;

            ResourceDictionary language = new ResourceDictionary();
            languagePath = "Dictionaries/Ru.Xaml";
            language.Source = new Uri(languagePath,UriKind.Relative);

            //Подключение динамического ресурса
            this.Resources = new ResourceDictionary()
            {
                Source = new Uri("C:/Study/OOP/Lab6-7_New/Resources/DynamicDictionary.xaml")
            };

            ShowLibrary();
        }

        public void ShowLibrary()
        {
            BooksList.ItemsSource = null;
            BooksList.ItemsSource = books;
        }

        public void ShowSelectedBooks()
        {
            BooksListChoosed.ItemsSource = null;
            BooksListChoosed.ItemsSource = ChoosedBooks;
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
            CreateBook.CreateBook AddBook = new CreateBook.CreateBook(languagePath);
            AddBook.Show();
        }

        

        private void BookDescription(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(e.Source.ToString().Last().ToString());
            Lab6_7_New.BookDescription.BookDescription bookDescription = new Lab6_7_New.BookDescription.BookDescription(books[index],languagePath);
            bookDescription.Show();
        }

        private void BookDelete(object sender, RoutedEventArgs e)
        {

            Patterns.Pult pult = new Patterns.Pult();
            Patterns.ShopDelItems shop_del_items = new Patterns.ShopDelItems();
            pult.SetCommand(new Patterns.ShoopDelItemsCommand(shop_del_items));
            pult.DelItem();

            int index = int.Parse(e.Source.ToString().Last().ToString());
            books.RemoveAt(index);
            
            for (int i = books.Count-1; i >= index; i--)
            {
                books[i].ID--;
                
            }
            ShowLibrary();
            ShowSelectedBooks();
        }

        private void BookEdit(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(e.Source.ToString().Last().ToString());
            EditBook.EditBook editBook = new EditBook.EditBook(books[index],languagePath);
            editBook.Show();
        }

        private void SortByPrice(object sender, RoutedEventArgs e)
        {
            int index = 0;
            var SortedByPrice = from i in books
                                orderby i.Price
                                select i;
            foreach(Book_Model.Book book in SortedByPrice)
            {
                books[index] = book;
                index++;
            }
            ShowLibrary();
        }

        private void SortByCount(object sender, RoutedEventArgs e)
        {
            int index = 0;
            var SortedByPrice = from i in books
                                orderby i.Count
                                select i;
            foreach (Book_Model.Book book in SortedByPrice)
            {
                books[index] = book;
                index++;
            }
            ShowLibrary();
        }

        private void SaveInXml(object sender, RoutedEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book_Model.Book>));
            using (FileStream stream = new FileStream("Library.xml", FileMode.Create))
            {
                serializer.Serialize(stream, books);
            }
        }

        private void LoadFromXml(object sender, RoutedEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book_Model.Book>));
            using (FileStream stream = new FileStream("Library.xml", FileMode.Open))
            {
                List<Book_Model.Book> NewBooks = serializer.Deserialize(stream) as List<Book_Model.Book>;
                books.Clear();
                foreach(Book_Model.Book book in NewBooks)
                {
                    books.Add(book);
                }
            }
            ShowLibrary();
        }

        private void Seacrh(object sender, RoutedEventArgs e)
        {
            SeachBook.Search search = new SeachBook.Search(languagePath);
            search.Show();
        }

        private void ChangeLanguageToRu(object sender, RoutedEventArgs e)
        {
            languagePath = "Dictionaries/Ru.Xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        private void ChangeLanguageToEn(object sender, RoutedEventArgs e)
        {
            languagePath = "Dictionaries/En.Xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        private void ChooseByPrice(object sender, RoutedEventArgs e)
        {
            Selection.SelectByPrice selectByPrice = new Selection.SelectByPrice(books,languagePath);
            selectByPrice.Show();
        }

        private void ChooseByType(object sender, RoutedEventArgs e)
        {
            Selection.SelectByType selectByType = new Selection.SelectByType(books,languagePath);
            selectByType.Show();
        }
    }
}
