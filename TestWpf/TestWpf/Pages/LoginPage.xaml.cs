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

namespace TestWpf.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private StringContener stringConten = new StringContener();

        public LoginPage()
        {
            InitializeComponent();
            tbUsername.Focus();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            checkLogin();
        }

        private void checkLogin()
        {
            string user = "mps";
            string password = "1234";

            if (tbUsername.Text == "" && pwdBox.Password == "")
            {
                labelCheckLogin.Content = stringConten.loginInputUserPwd;
                labelCheckLogin.Foreground = Brushes.Black;
                tbUsername.Focus();
                labelCheckLogin.Visibility = Visibility;
            }
            else if (tbUsername.Text == "")
            {
                labelCheckLogin.Content = stringConten.loginInputUser;
                labelCheckLogin.Foreground = Brushes.Black;
                tbUsername.Focus();
                labelCheckLogin.Visibility = Visibility;
            }
            else if (pwdBox.Password == "")
            {
                labelCheckLogin.Content = stringConten.loginInputPassword;
                labelCheckLogin.Foreground = Brushes.Black;
                pwdBox.Focus();
                labelCheckLogin.Visibility = Visibility;
            }
            else if (tbUsername.Text == user && pwdBox.Password == password)
            {
                labelCheckLogin.Content = stringConten.loginSuccess;
                labelCheckLogin.Foreground = Brushes.Green;
                labelCheckLogin.Visibility = Visibility;
            }
            else
            {
                labelCheckLogin.Content = stringConten.loginNotSuccess;
                labelCheckLogin.Foreground = Brushes.Red;
                labelCheckLogin.Visibility = Visibility;
            }
        }
    }
}
