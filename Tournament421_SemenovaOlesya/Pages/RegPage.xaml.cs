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
using Tournament421_SemenovaOlesya.Bases;

namespace Tournament421_SemenovaOlesya.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NameTb.Text == string.Empty || SurnameTb.Text == string.Empty
                || LoginTb.Text == string.Empty || PasswordPb.Password == string.Empty
                || ContactInfoTb.Text == string.Empty)
            {
                Methods.TakeWarning("Заполните все поля!");
                return;
            }

            if (App.db.UserLogin.Any(x => x.Login == LoginTb.Text))
            {
                Methods.TakeWarning("Такой логин уже зарегистрирован!");
                return;
            }

            UserLogin log = App.db.UserLogin.Add(new UserLogin()
            {
                Login = LoginTb.Text,
                Password = PasswordPb.Password,
            });

            App.db.Player.Add(new Player()
            {
                Surname = SurnameTb.Text,
                Name = NameTb.Text,
                Id = log.Id,
                ContactInfo = ContactInfoTb.Text,
            });
            App.db.SaveChanges();
            App.CurrentUser = log;
            Navigations.Next(new TournirsPage());
            Methods.TakeInformation("Вы успешно зарегистрировались!");
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.Back();
        }
    }
    }
}
