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

namespace Tournament421_SemenovaOlesya.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void AuthBTN_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LogTB.Text) || string.IsNullOrEmpty(PassTB.Password))
            {
                MessageBox.Show("Заполните все данные");
                return;
            }
            var user = App.db.Player.FirstOrDefault(x => x.Login == LogTB.Text || x.Password == PassTB.Password);

            if (user != null)
            {
                MessageBox.Show("Добро пожаловать, " + user.Nickname);
                App.totalPlayer = user;
                App.totalOrganizer = null;
                NavigationService.Navigate(new PlayerNavigPage());

            }
            else MessageBox.Show("Пользователь не найден, проверь данные");
        }

    }
}

