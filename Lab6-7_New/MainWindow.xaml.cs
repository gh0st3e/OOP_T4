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

            //this.MaxHeight = 900;
            //this.MaxWidth = 1600;
            this.MinHeight = 450;
            this.MinWidth = 800;

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

           

            DataContext = new Patterns.ApplicationsViewModel();
            ShowLibrary();
        }

        public void ShowLibrary()
        {
            BooksList.ItemsSource = null;
            BooksList.ItemsSource = books;
        }

        public void ShowSelectedBooks()
        {
            foreach(Book_Model.Book book in ChoosedBooks)
            {
                foreach(Book_Model.Book nativeBook in books)
                {
                    
                }
            }
            BooksListChoosed.ItemsSource = null;
            BooksListChoosed.ItemsSource = ChoosedBooks;
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
            MenuAddBook.Command = ApplicationCommands.New;
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

            

            int index = int.Parse(e.Source.ToString().Last().ToString());
            books.RemoveAt(index);
            
            for (int i = books.Count-1; i >= index; i--)
            {
                books[i].ID--;
                
            }
            ShowLibrary();
            BooksListChoosed.ItemsSource = null;
        }

        private void BookEdit(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(e.Source.ToString().Last().ToString());
            EditBook.EditBook editBook = new EditBook.EditBook(books[index],languagePath);
            editBook.Show();
            BooksListChoosed.ItemsSource = null;
        }
        public void SaveInXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book_Model.Book>));
            using (FileStream stream = new FileStream("Library.xml", FileMode.Create))
            {
                serializer.Serialize(stream, books);
            }
        }

        public void LoadFromXml()
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

        public void Seacrh()
        {
            SeachBook.Search search = new SeachBook.Search(languagePath);
            search.Show();
        }

        public void ChangeLanguageToRu()
        {
            languagePath = "Dictionaries/Ru.Xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        public void ChangeLanguageToEn()
        {
            languagePath = "Dictionaries/En.Xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        public void ChooseByPrice()
        {
            Selection.SelectByPrice selectByPrice = new Selection.SelectByPrice(books,languagePath);
            selectByPrice.Show();
        }

        public void ChooseByType()
        {
            Selection.SelectByType selectByType = new Selection.SelectByType(books,languagePath);
            selectByType.Show();
        }
    }
}
