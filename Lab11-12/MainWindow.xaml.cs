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

namespace Lab11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int CurrentID;
        public int IDForUpdate;

        public MainWindow()
        {
            InitializeComponent();
            LoadDorm();
        }

        public void GetID()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.user.ToList();
                
                foreach (User u in users)
                {
                    CurrentID = u.ID+1;
                }
            }
        }
        public async void LoadDorm()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var dormitories = db.dormitory.ToList();
                DataPlaceDorm.ItemsSource = null;
                DataPlaceDorm.ItemsSource = dormitories;
                var users = db.user.ToList();
                
                DataPlaceUser.ItemsSource = users;
                UsDorm.Items.Clear();
                foreach (Dormitory u in dormitories)
                {
                    UsDorm.Items.Add(u.Name);
                }
                await db.SaveChangesAsync();
            }
        }
        

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            
            GetID();
            try
            {
                if (int.Parse(UsAge.Text) < 1)
                {
                    MessageBox.Show("Введите правильные данные");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введите правильные данные");
                return;
            }



            Patterns.UnitOfWork context = new Patterns.UnitOfWork();
            User user1 = new User { ID = CurrentID, Name = UsName.Text, Surname = UsSurname.Text, Age = int.Parse(UsAge.Text), DormID = UsDorm.SelectedIndex+1 };
            context.Users.Create(user1);
            context.Users.Save();



            using (ApplicationContext db = new ApplicationContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        if (DormId.Text != "" && DormName.Text != "")
                        {
                            Dormitory dorm1 = new Dormitory { ID = int.Parse(DormId.Text), Name = DormName.Text };
                            db.dormitory.Add(dorm1);
                        }
                        var users = db.user.ToList();
                        DataPlaceUser.ItemsSource = users;
                        transaction.Commit();
                        LoadDorm();
                    }
                    catch
                    {
                        MessageBox.Show("transaction rollback");
                        transaction.Rollback();
                    }
                }
            }
        }

        private void UpdateUser_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                try
                {
                    var users = db.user.ToList();

                    UsName.Text = users[IDForUpdate - 1].Name;
                    UsSurname.Text = users[IDForUpdate - 1].Surname;
                    UsAge.Text = users[IDForUpdate - 1].Age.ToString();
                    UsDorm.SelectedIndex = users[IDForUpdate - 1].DormID - 1;
                }
                catch
                {

                }
                
            }
            UpdateUserConfirm.Visibility = Visibility.Visible;
        }

        private void DataPlaceUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (DataPlaceUser.SelectedItem is User)
            {
                
                try
                {
                    var a = DataPlaceUser.SelectedItem as User;
                    IDForUpdate = a.ID;
                }
                catch
                {
                    return;
                }
            }
        }

        private void UpdateUserConfirm_Click(object sender, RoutedEventArgs e)
        {
            Patterns.UnitOfWork context = new Patterns.UnitOfWork();
            try
            {
                if (int.Parse(UsAge.Text) < 1)
                {
                    MessageBox.Show("Введите правильные данные");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введите правильные данные");
                return;
            }
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var result = context.Users.GetItem(IDForUpdate);
                    result.Name = UsName.Text;
                    result.Surname = UsSurname.Text;
                    result.Age = int.Parse(UsAge.Text);
                    result.DormID = UsDorm.SelectedIndex + 1;
                    User UpdateUser = new User { ID = result.ID, Name = UsName.Text, Surname = UsSurname.Text, Age = int.Parse(UsAge.Text), DormID = UsDorm.SelectedIndex + 1 };
                    context.Users.Update(UpdateUser);
                    context.Users.Save();
                    DataPlaceUser.ItemsSource = context.Users.GetItemList();
                }
                catch
                {

                }
            }
            UpdateUserConfirm.Visibility = Visibility.Hidden;
        }

        private void LoadUser_Click(object sender, RoutedEventArgs e)
        {
            Patterns.UnitOfWork context = new Patterns.UnitOfWork();
            
                
                DataPlaceUser.ItemsSource = context.Users.GetItemList();
            
        }

        private void DelUser_Click(object sender, RoutedEventArgs e)
        {
            Patterns.UnitOfWork context = new Patterns.UnitOfWork();
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    context.Users.Delete(IDForUpdate);
                    context.Users.Save();
                    
                    var users = db.user.ToList();
                    DataPlaceUser.ItemsSource = users;
                }
                catch
                {

                }
                
            }
        }
    }
}
