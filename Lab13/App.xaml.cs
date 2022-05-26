using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Lab13_2.Models;
using Lab13_2.ViewModels;
using MySql.Data.MySqlClient;

namespace Lab13_2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainWindow view = new MainWindow();

        
        List<Course> courses = new List<Course>();
        public string connectionString = "server = 127.0.0.1;" +
                "port=8597;" +
                "username=mysql;" +
                "password=mysql;" +
                "database=educenter";
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                  connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT id,name,hours,teacher,countofpeople FROM courses", connection);
                MySqlDataReader reader = (MySqlDataReader)command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    

                    while (reader.Read()) // построчно считываем данные
                    {
                        int id = int.Parse(reader.GetValue(0).ToString());
                        string name = reader.GetValue(1).ToString();
                        int hours = int.Parse(reader.GetValue(2).ToString());
                        string teacher = reader.GetValue(3).ToString();
                        int countofpeople = int.Parse(reader.GetValue(4).ToString());

                        Course course = new Course(id,name, hours, teacher, countofpeople);
                        courses.Add(course);

                        

                    }
                }
            }

            //using (EduCenter db = new EduCenter())
            //{
            //    courses = db.courses.ToList();
            //}

            // создали View
            
            MainViewModel viewModel = new ViewModels.MainViewModel(courses); // Создали ViewModel
            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Visibility = Visibility.Visible;
            
        }
    }
}
