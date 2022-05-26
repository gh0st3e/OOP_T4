using Lab13_2.Commands;
using Lab13_2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Lab13_2;

namespace Lab13_2.ViewModels
{
    class CourseViewModel : ViewModelBase
    {
        public Course Course;

        public CourseViewModel(Course course)
        {
            this.Course = course;
        }

        public string ID
        {
            get { return Convert.ToString(Course.ID); }
            set
            {
                Course.ID = Convert.ToInt32(value);
                OnPropertyChanged("ID");
            }
        }
        public string Name
        {
            get { return Course.Name; }
            set
            {
                Course.Name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Hours
        {
            get { return Course.Hours; }
            set
            {
                Course.Hours = value;
                OnPropertyChanged("Hours");
            }
        }
        public string Teacher
        {
            get { return Course.Teacher; }
            set
            {
                Course.Teacher = value;
                OnPropertyChanged("Teacher");
            }
        }
        public int CountOfPeople
        {
            get { return Course.CountOfPeople; }
            set
            {
                Course.CountOfPeople = value;
                OnPropertyChanged("CountOfPeople");
            }
        }


        //Записать на курс
        private DelegateCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new DelegateCommand(GetItem);
                }
                return getItemCommand;
            }
        }
        private void GetItem()
        {
            CountOfPeople++;
            string connectionString = "server = 127.0.0.1;" +
                "port=8597;" +
                "username=mysql;" +
                "password=mysql;" +
                "database=educenter";

            var Course = App.view.MainList.SelectedIndex;
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand($"UPDATE courses SET countofpeople=countofpeople+1 WHERE id={Course+1}", connection);
                command.ExecuteNonQuery();

            }
        }

        //отписать от курса
        private DelegateCommand giveItemCommand;

        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                {
                    giveItemCommand = new DelegateCommand(GiveItem, CanGiveItem);
                }
                return giveItemCommand;
            }
        }

        private void GiveItem()
        {
            CountOfPeople--;
            string connectionString = "server = 127.0.0.1;" +
                "port=8597;" +
                "username=mysql;" +
                "password=mysql;" +
                "database=educenter";

            var Course = App.view.MainList.SelectedIndex;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand($"UPDATE courses SET countofpeople=countofpeople-1 WHERE id={Course + 1}", connection);
                command.ExecuteNonQuery();

            }
        }
        private bool CanGiveItem()
        {
            return CountOfPeople > 0;
        }
    }
}
