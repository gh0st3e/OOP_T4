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

namespace Lab10_WPF.Update
{
    /// <summary>
    /// Логика взаимодействия для UpdateBook.xaml
    /// </summary>
    public partial class UpdateBook : Window
    {
        public int CurrentID;
        public UpdateBook(Insert.NewBook newBook)
        {
            InitializeComponent();
            CurrentID = newBook.ID;
            BookName.Text = newBook.Name;
            BookAuthor.Text = newBook.Author;
            BookCount.Text = newBook.Count.ToString();
            BookPrice.Text = newBook.Price.ToString();
            BookImage.Text = newBook.Image;
            try
            {
                BookImageShow.Source = new BitmapImage(new Uri(newBook.Image));
            }
            catch
            {

            }
        }

        private void ChangeBook_Click(object sender, RoutedEventArgs e)
        {
            if (BookName.Text != null || BookAuthor.Text != null)
            {
                try
                {
                    int ccount = int.Parse(BookCount.Text);
                    if (ccount < 0) throw new Exception();
                    int pprice = int.Parse(BookPrice.Text);
                    if (pprice < 0) throw new Exception();
                }
                catch
                {
                    
                    MessageBox.Show("Введены некорректные данные");
                    return;
                }
                MessageBox.Show("Sucsess");
                ChangeData();

            }
            else
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

        public void ChangeData()
        {
            string connectionString = "server = 127.0.0.1;" +
                "port=8597;" +
                "username=mysql;" +
                "password=mysql;" +
                "database=oop";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand($"UPDATE books SET name='{BookName.Text}', author='{BookAuthor.Text}',price={BookPrice.Text},count={BookCount.Text},image='{BookImage.Text}' WHERE id={CurrentID}", connection);
                MySqlDataReader reader = (MySqlDataReader)command.ExecuteReader();
            }
        }
    }
}
