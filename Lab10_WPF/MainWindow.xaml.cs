using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Lab10_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow MyForm;
        ConnectionToDB con = new ConnectionToDB();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt;

        public List<Insert.NewBook> books = new List<Insert.NewBook>();

        public ObservableCollection<Insert.NewBook> library = new ObservableCollection<Insert.NewBook>();

        public int idForDel;
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                con.Connect();
            }
            catch
            {
                command = new MySqlCommand($"CREATE DATABASE `OOP` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */", con.SqlConnet);
                command.ExecuteNonQuery();
                command = new MySqlCommand($"CREATE TABLE `books` (`ID` int NOT NULL AUTO_INCREMENT,`image` varchar(500) NOT NULL,`name` varchar(50) NOT NULL,`author` varchar(50) NOT NULL,`price` int NOT NULL,`count` int NOT NULL,PRIMARY KEY(`ID`)) ENGINE = InnoDB AUTO_INCREMENT = 8 DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci", con.SqlConnet);
                command.ExecuteNonQuery();
                command = new MySqlCommand($"CREATE TABLE `sales` (`newid` int unsigned NOT NULL AUTO_INCREMENT,`ID` int NOT NULL,`Selled` int NOT NULL,PRIMARY KEY(`newid`),KEY `ID` (`ID`),CONSTRAINT `sales_ibfk_1` FOREIGN KEY(`ID`) REFERENCES `books` (`ID`) ON DELETE RESTRICT ON UPDATE RESTRICT) ENGINE = InnoDB AUTO_INCREMENT = 29 DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci", con.SqlConnet);
                command.ExecuteNonQuery();
            }
            
            this.DataContext = this;
            MyForm = this;
        }

        public void TestConnect()
        {
            string connectionString = "server = 127.0.0.1;" +
                "port=8597;" +
                "username=mysql;" +
                "password=mysql;" +
                "database=oop";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                 connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT books.ID,image,name,author,price,count,selled as sold FROM oop.books INNER JOIN oop.sales ON books.id=sales.id", connection);
                MySqlDataReader reader = (MySqlDataReader) command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    library.Clear();

                    while ( reader.Read()) // построчно считываем данные
                    {
                        int id = int.Parse(reader.GetValue(0).ToString());
                        string image = reader.GetValue(1).ToString();
                        string name = reader.GetValue(2).ToString();
                        string author = reader.GetValue(3).ToString();
                        int price = int.Parse(reader.GetValue(4).ToString());
                        int count = int.Parse(reader.GetValue(5).ToString());
                        int sold = int.Parse(reader.GetValue(6).ToString());

                        Insert.NewBook book = new Insert.NewBook(id,image,name,author,price,count,sold);
                        books.Add(book);
                        library.Add(book);
                        
                    }
                }
                
                
            }

            DataHolder.ItemsSource = null;
            DataHolder.ItemsSource = library;
            

        }

        private void LoadData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TestConnect();

            }
            catch
            {
                System.Windows.MessageBox.Show("ошибка");
            }
        }

        private void AddData_Click(object sender, RoutedEventArgs e)
        {
            Insert.InsertBook AddBookForm = new Insert.InsertBook();
            AddBookForm.Show();
        }

        private void DelData_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.MessageBox.Show(idForDel.ToString());

            string connectionString = "server = 127.0.0.1;" +
                "port=8597;" +
                "username=mysql;" +
                "password=mysql;" +
                "database=oop";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {


                connection.Open();
                
                command = new MySqlCommand($"DELETE FROM sales WHERE ID = '{idForDel}'",connection);
                command.ExecuteNonQuery();
                command = new MySqlCommand($"DELETE FROM books WHERE ID = '{idForDel}'",connection);
                command.ExecuteNonQuery();
                
            }
            if (DataHolder.Items.Count == 1)
            {
                library.Clear();
                DataHolder.ItemsSource = null;
            }
            TestConnect();
            

        }

        private void DataHolder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(DataHolder.SelectedItem != null)
            {
                var a = DataHolder.SelectedItem as Insert.NewBook;
                idForDel = a.ID;
                
            }
            
        }

        private void UpdateData_Click(object sender, RoutedEventArgs e)
        {
            int currentbook = 0;
            foreach(Insert.NewBook book in library)
            {
                if(book.ID==idForDel)
                {
                    Update.UpdateBook updateBook = new Update.UpdateBook(library[currentbook]);
                    updateBook.Show();
                }
                else
                {
                    currentbook++;
                }
            }
            
        }

        private void UpArrow_Click(object sender, RoutedEventArgs e)
        {
            if(DataHolder.SelectedIndex != 0)
            {
                DataHolder.SelectedIndex--;
            }
        }

        private void DownArrow_Click(object sender, RoutedEventArgs e)
        {
            if (DataHolder.SelectedIndex != DataHolder.Items.Count-1)
            {
                DataHolder.SelectedIndex++;
            }
        }

        private void BuyBook_Click(object sender, RoutedEventArgs e)
        {
            int count=0;
            string connectionString = "server = 127.0.0.1;" +
                "port=8597;" +
                "username=mysql;" +
                "password=mysql;" +
                "database=oop";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand($"SELECT count FROM books WHERE id={idForDel}", connection);
                MySqlDataReader reader = (MySqlDataReader)command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {

                    while (reader.Read()) // построчно считываем данные
                    {
                        count = int.Parse(reader.GetValue(0).ToString());

                    }
                }
                connection.Close();
                if(count>0)
                {
                    connection.Open();
                    command = new MySqlCommand($"UPDATE books SET count=count-1 WHERE id={idForDel}", connection);
                    command.ExecuteNonQuery();
                    command = new MySqlCommand($"UPDATE sales SET Selled=Selled+1 WHERE id={idForDel}", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                
            }
        }

        private void NewQuery_Click(object sender, RoutedEventArgs e)
        {
            QueryPopUp.IsOpen = true;
        }

        private void CloseQuery_Click(object sender, RoutedEventArgs e)
        {
            QueryPopUp.IsOpen = false;
        }

        private void OkQuery_Click(object sender, RoutedEventArgs e)
        {
            string sql = QTB.Text;
            try
            {
                string connectionString = "server = 127.0.0.1;" +
                "port=8597;" +
                "username=mysql;" +
                "password=mysql;" +
                "database=oop";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    
                    MySqlDataReader reader = (MySqlDataReader)command.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        library.Clear();

                        while (reader.Read()) // построчно считываем данные
                        {
                            int id = int.Parse(reader.GetValue(0).ToString());
                            string image = reader.GetValue(1).ToString();
                            string name = reader.GetValue(2).ToString();
                            string author = reader.GetValue(3).ToString();
                            int price = int.Parse(reader.GetValue(4).ToString());
                            int count = int.Parse(reader.GetValue(5).ToString());
                            int sold = int.Parse(reader.GetValue(6).ToString());

                            Insert.NewBook book = new Insert.NewBook(id, image, name, author, price, count, sold);
                            books.Add(book);
                            library.Add(book);

                        }
                    }
                    connection.Close();
                }
                DataHolder.ItemsSource = null;
                DataHolder.ItemsSource = library;
            }
            catch
            {
                System.Windows.MessageBox.Show("Запрос неверный");
            }
        }
    }
}
