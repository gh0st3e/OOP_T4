using Microsoft.Win32;
using MySql.Data.MySqlClient;
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

namespace Lab10_WPF.Insert
{
    /// <summary>
    /// Логика взаимодействия для InsertBook.xaml
    /// </summary>
    public partial class InsertBook : Window
    {
        ConnectionToDB con = new ConnectionToDB();
        MySqlCommand command;

        public int CurrentID;
        public string ImagePath;
        public InsertBook()
        {
            InitializeComponent();
            con.Connect();
            
        }

        private void AddNewBook_Click(object sender, RoutedEventArgs e)
        {
            GetID();
            
            con.SqlConnet.Open();
            MySqlTransaction transaction = con.SqlConnet.BeginTransaction();
            MySqlCommand commandTrans = con.SqlConnet.CreateCommand();
            commandTrans.Transaction = transaction; 

            try
            {
                string name = BookName.Text;
                string author = BookAuthor.Text;
                int price = int.Parse(BookPrice.Text);
                if (price < 0) throw new Exception();
                int count = int.Parse(BookCount.Text);
                if (count < 0) throw new Exception();
                string bookimage = BookImage.Text;
                command = new MySqlCommand($"INSERT INTO books (ID,image,name,author,price,count) VALUES ({++CurrentID},'{bookimage}','{name}','{author}',{price},{count})", con.SqlConnet);
                command.ExecuteNonQuery();
                command = new MySqlCommand($"INSERT INTO sales (ID,Selled) VALUES ('{CurrentID}')", con.SqlConnet);
                command.ExecuteNonQuery();
                transaction.Commit();
                con.SqlConnet.Close();
                MainWindow.MyForm.TestConnect();
                this.Close();
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("ошибка");
            }
        }
        public void GetID()
        {
            string connectionString = "server = 127.0.0.1;" +
                "port=8597;" +
                "username=mysql;" +
                "password=mysql;" +
                "database=oop";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT id FROM oop.books", connection);
                MySqlDataReader reader = (MySqlDataReader) command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {


                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = int.Parse(reader.GetValue(0).ToString());
                        CurrentID = id;
                    }
                }

                connection.Close();
            }
            
        }
    }
}
