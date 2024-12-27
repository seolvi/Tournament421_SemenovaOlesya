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
            string login = PhoneAuthTB.Text;
            if (PasswordAuthTB.Password == "")
            {
                MessageBox.Show("Вы не ввели пароль");
                return;
            }
            var loginUser = App.db.LoginUser.FirstOrDefault(x => x.Login == login && x.Password == PasswordAuthTB.Password);

            if (loginUser != null)
            {
                App.currentUser = loginUser.User;
                if (RememberCb.IsChecked == true)
                    File.WriteAllText(@"RememberMe.txt", loginUser.Login);
                MessageBox.Show($"Добро пожаловать, {loginUser.User.Name}!");
                if (App.currentUser.IdRole == 1)
                    App.mainWindow.SetElements(false, true, true, true, true, false, true);
                else if (App.currentUser.IdRole == 2)
                    App.mainWindow.SetElements(false, true, true, true, false, true, true);
                else if (App.currentUser.IdRole == 3)
                    App.mainWindow.SetElements(false, true, true, true, false, false, true);

                NavigationService.Navigate(new ListPage());

            }
            else
                MessageBox.Show("Пользователь не найден. Попробуйте ещё раз!");
        }
    }
    }
}
