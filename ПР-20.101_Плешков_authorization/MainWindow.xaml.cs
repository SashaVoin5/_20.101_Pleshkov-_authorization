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
using ПР_20._101_Плешков_authorization.Base;
using static System.Net.Mime.MediaTypeNames;

namespace ПР_20._101_Плешков_authorization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int CountUnsuccessful = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = txt_login.Text;
            string pass = txt_pass.Text;

            Users user = new Users();
            var User = EntitiesAutho.GetContext().Users.Where(p => p.Login == login && p.Password == pass).FirstOrDefault();  //Находим пользователя который подходит критериям
            int userCount = EntitiesAutho.GetContext().Users.Where(p => p.Login == login && p.Password == pass).Count(); //Считываем кол-во пользователей
            if (CountUnsuccessful < 1)
            {
                if (userCount > 0)
                {
                    string Role = User.Role.Name.ToString();
                    MessageBox.Show("Добро пожаловать! Ваша роль: " + Role);


                }
                else
                {
                    MessageBox.Show("Неверно введены логин или пароль!");
                }
            }
        }
    }
}
