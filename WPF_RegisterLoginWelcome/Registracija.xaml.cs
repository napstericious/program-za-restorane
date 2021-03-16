using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
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
    /// Interaction logic for Registracija.xaml
    /// </summary>
    public partial class Registracija : Page
    {
        public Registracija()
        {
            InitializeComponent();
            

        }
        //************************************
        //eksplicitna i implicitna konverzija
        //implicitna konverzija se sama odvija, npr kada hocemo da int kastujemo u float, tu nista ne pisem, vec samo dodeljujemo vrednost
        //eksplicitna konverzija se mora "rucno" odraditi kastovanjem (tip)
        //Kreiramo objekat klase u ovom slucaju MainWindow, klasa Application ima property current koji ima property Windows, za sve prozore 
        //Current.Windows.Cast<Window>() - kreira kolekciju svih prozora u nasem projektu, FirstOrDefault uz lambda izraz vraca jedan prozor koji je tipa MainWindow u ovom slucaju, 
        //taj tip, sa desne strane, koji je u ovom slucaju Window, moramo EKSPLICITNOM KONVERZIJOM da kastujemo u tip koji je sa leve strane, u ovom slucaju MainWindow
        //private readonly MainWindow mw = (MainWindow) Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow);
        /*************************************/
        private readonly MainWindow mw = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;

        private void TxtBoxIme_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxIme.Text == "Ime")
            {
                TxtBoxIme.Text = "";
                TxtBoxIme.Opacity = 1;
            }

        }
        
        private void TxtBoxIme_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxIme.Text == "")
            {
                TxtBoxIme.Text = "Ime";
                TxtBoxIme.Opacity = .6;
            }
        }

        private void TxtBoxPrezime_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxPrezime.Text == "Prezime")
            {
                TxtBoxPrezime.Text = "";
                TxtBoxPrezime.Opacity = 1;
            }
        }

        private void TxtBoxPrezime_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxPrezime.Text == "")
            {
                TxtBoxPrezime.Text = "Prezime";
                TxtBoxPrezime.Opacity = .6;
            }
        }

        private void TxtBoxMail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxMail.Text == "E-mail")
            {
                TxtBoxMail.Text = "";
                TxtBoxMail.Opacity = 1;
            }
        }

        private void TxtBoxMail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxMail.Text == "")
            {
                TxtBoxMail.Text = "E-mail";
                TxtBoxMail.Opacity = .6;
            }
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
            if (PasswordBox.Password == "Password")
            {
                PasswordBox.Password = "";
                PasswordBox.Opacity = 1;
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "")
            {
                PasswordBox.Password = "Password";
                PasswordBox.Opacity = .6;
            }
        }

        private void PasswordConfirmBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordConfirmBox.Password == "Password")
            {
                PasswordConfirmBox.Password = "";
                PasswordConfirmBox.Opacity = 1;
            }
        }

        private void PasswordConfirmBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordConfirmBox.Password == "")
            {
                PasswordConfirmBox.Password = "Password";
                PasswordConfirmBox.Opacity = 0.6;
            }
        }

        private void BrisiOpomene()
        {
            TxtOpomenaIme.Visibility = Visibility.Hidden;
            TxtOpomenaPrezime.Visibility = Visibility.Hidden;
            TxtOpomenaEMAIL.Visibility = Visibility.Hidden;
            TxtOpomenaUsername.Visibility = Visibility.Hidden;
            TxtOpomenaPassword.Visibility = Visibility.Hidden;
            TxtOpomenaPasswordPodudaranje.Visibility = Visibility.Hidden;
        }
        private bool Validacija()
        {
            BrisiOpomene();
            if (string.IsNullOrWhiteSpace(TxtBoxIme.Text) || !TxtBoxIme.Text.All(c => char.IsLetter(c)) || !(TxtBoxIme.Text.Length > 3) || !(TxtBoxIme.Text.Length <= 20))
            {
                TxtOpomenaIme.Visibility = Visibility.Visible;
                TxtBoxIme.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtBoxPrezime.Text) || !TxtBoxPrezime.Text.All(c => char.IsLetter(c)) || !(TxtBoxPrezime.Text.Length > 3) || !(TxtBoxPrezime.Text.Length <= 20))
            {
                TxtOpomenaPrezime.Visibility = Visibility.Visible;
                TxtBoxPrezime.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtBoxMail.Text) || !ProveraMail(TxtBoxMail.Text))
            {
                TxtOpomenaEMAIL.Visibility = Visibility.Visible;
                TxtBoxMail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtBoxUsername.Text) || !TxtBoxUsername.Text.All(c => char.IsLetterOrDigit(c)) || !(TxtBoxUsername.Text.Length >= 3) || !(TxtBoxUsername.Text.Length <= 20))
            {
                TxtOpomenaUsername.Visibility = Visibility.Visible;
                TxtBoxUsername.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(PasswordBox.Password) || !PasswordBox.Password.Any(c => char.IsUpper(c)) || !PasswordBox.Password.Any(c => char.IsDigit(c)) || !(PasswordBox.Password.Length >= 5) || !(PasswordBox.Password.Length <= 20))
            {
                TxtOpomenaPassword.Visibility = Visibility.Visible;
                PasswordBox.Focus();
                return false;
            }
            if (PasswordConfirmBox.Password != PasswordBox.Password)
            {
                TxtOpomenaPasswordPodudaranje.Visibility = Visibility.Visible;
                PasswordConfirmBox.Focus();
                return false;
            }
            if (PostojiIliNe(TxtBoxUsername.Text, TxtBoxMail.Text))
            {
                return false;
            }
            return true;
        }

        private static bool ProveraMail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                if (Validacija())
                {                    
                    int id;
                    if (mw.ListaKorisnika.Count > 0)
                    {
                        //
                        // napisi opis ovoga
                        // Lista korisnika je polje u samom Main-u
                        //Liste imaju svoje metode, u ovom slucaju "Last()"
                        //Metoda Last(), vraca poslednji objekat iz liste
                        //svaki objekat ima svoje property iliti atribute, tackom invokujemo iliti pozivamo atribute tih objekata, u ovom slucaju IDKorisnika
                        id = mw.ListaKorisnika.Last().IDKorisnika + 1;
                    }
                    else
                    {
                        id = 1;  
                    }
                    // ****redosled parametara koji se prosledjuje konstruktoru mora biti isti kao i gde je konstruktor napravljen****
                    // u ovom slucaju u klasi Korisnik
                    Korisnik K = new Korisnik(id, TxtBoxIme.Text, TxtBoxPrezime.Text, TxtBoxUsername.Text, TxtBoxMail.Text, PasswordBox.Password);
                    mw.ListaKorisnika.Add(K);
                    Sacuvaj();
                    MessageBox.Show("Uspesno ste se registrovali!");

                    //NavigationService je property klase "Page", koji ima svoju metodu "Navigate"
                    //Navigate zahteva da se prosledi objekat neke stranice u ovom slucaju "Login"
                    NavigationService.Navigate(new Login());

                }
                else
                {
                    MessageBox.Show("Uneti podaci su neispravni. Proverite unete podatke!");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show($"Izuzetak je: {E.Message}");
            }
        }


        private bool PostojiIliNe(string username, string mail)
        {
            //Obrati paznju na sam uslov i na lambda izraze
            //Kada proveravas vise uslova da ne izadjes iz lambda izraz tj zagrade
            if (mw.ListaKorisnika.Any(x => x.UsernameKorisnika == username || x.MailKorisnika == mail) )
            {
                MessageBox.Show("Postoji nalog sa tim username-om ili istom mail adresom.");
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void Sacuvaj()
        {
            if (mw.ListaKorisnika.Count > 0)
            {
                string jsonString = JsonConvert.SerializeObject(mw.ListaKorisnika);
                File.WriteAllText(mw.Putanja, jsonString);
            }
            /*
            else
            {
                File.Delete(mw.Putanja);
            }
            */
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (mw.ListaKorisnika.Any(x => x.UsernameKorisnika == TxtBoxUsername.Text && x.PasswordKorisnika == PasswordBox.Password))
            {
                NavigationService.Navigate(new Welcome());
            }
            else
            {
                MessageBox.Show("Ne postoji korisnik sa tim username-om");
            }
        }
    }
}
