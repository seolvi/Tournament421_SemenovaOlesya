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

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = App.db.UserLogin.FirstOrDefault(x =>
                x.Login.Equals(LoginTb.Text) &&
                x.Password.Equals(PasswordPb.Password));
            if (user == null)
            {
                Methods.TakeWarning("Неверный логин или пароль!");
                return;
            }

            App.CurrentUser = user;
            Navigations.Next(new TournirsPage());
            Methods.TakeInformation("Вы успешно вошли в систему!");
        }
    }
}
