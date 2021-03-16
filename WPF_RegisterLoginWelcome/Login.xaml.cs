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

namespace WPF_RegisterLoginWelcome
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }
                
        private void TxtBoxUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxUsername.Text == "Username")
            {
                TxtBoxUsername.Text = "";
                TxtBoxUsername.Opacity = 1;
            }
        }

        private void TxtBoxUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxUsername.Text == "")
            {
                TxtBoxUsername.Text = "Username";
                TxtBoxUsername.Opacity = .6;
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "Password1")
            {
                PasswordBox.Password = "";
                PasswordBox.Opacity = 1;
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "")
            {
                PasswordBox.Password = "Password1";
                PasswordBox.Opacity = .6;
            }
        }

        private bool Validacija()
        {
            if (string.IsNullOrWhiteSpace(TxtBoxUsername.Text) || !TxtBoxUsername.Text.All(c => char.IsLetterOrDigit(c)) || !(TxtBoxUsername.Text.Length >= 3) || !(TxtBoxUsername.Text.Length <= 20))
            {
                TxtOpomenaUsername.Visibility = Visibility.Visible;
                TxtBoxUsername.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(PasswordBox.Password) || !PasswordBox.Password.Any(c => char.IsUpper(c)) || !PasswordBox.Password.Any(c => char.IsDigit(c)) || !(TxtBoxUsername.Text.Length >= 5) || !(TxtBoxUsername.Text.Length <= 20))
            {
                TxtOpomenaPassword.Visibility = Visibility.Visible;
                PasswordBox.Focus();
                return false;
            }
            return true;
        }

        private readonly MainWindow mw = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

            if (mw.ListaKorisnika.Any(x => x.UsernameKorisnika == TxtBoxUsername.Text && x.PasswordKorisnika == PasswordBox.Password))
            {
                
                NavigationService.Navigate(new Welcome());
                mw.BtnMainLogin.Visibility = Visibility.Collapsed;
                mw.BtnPorudzbina.Visibility = Visibility.Visible;
                mw.BtnRacun.Visibility = Visibility.Visible;
                mw.BtnArtikli.Visibility = Visibility.Visible;
                mw.BtnMainLogout.Visibility = Visibility.Visible;
                mw.TBUlogovanKorisnik.Text = TxtBoxUsername.Text;
                mw.TBUlogovanKorisnik.FontSize = 24;
            }
            else
            {
                MessageBox.Show("Ne postoji korisnik sa tim username-om");
            }
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registracija());
            mw.BtnMainLogin.Visibility = Visibility.Visible;
        }        
    }
}
