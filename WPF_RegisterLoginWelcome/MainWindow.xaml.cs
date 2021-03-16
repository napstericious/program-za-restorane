using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CitajOsobe();
            Container.Content = new Registracija();
        }

        public string KesKartica { get; set; }

        public string UlogovanKorisnik = "";

        public string Putanja = "Korisnici.json";
        public List<Korisnik> ListaKorisnika = new List<Korisnik>();

        

        private void CitajOsobe()
        {
            ListaKorisnika.Clear();
            try
            {
                if (File.Exists(Putanja))
                {
                    string jsonString = File.ReadAllText(Putanja);
                    ListaKorisnika = JsonConvert.DeserializeObject<List<Korisnik>>(jsonString);
                }
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
        }
        
        private void BtnMainLogin_Click(object sender, RoutedEventArgs e)
        {
            Container.Content = new Login();
            BtnMainLogin.Visibility = Visibility.Collapsed;
        }

        private void BtnPorudzbina_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRacun_Click(object sender, RoutedEventArgs e)
        {
            KesKartica KK = new KesKartica();
            KK.ShowDialog();
        }        

        private void BtnArtikli_Click(object sender, RoutedEventArgs e)
        {
            Container.Content = new Artikli();
        }

        private void BtnMainLogout_Click(object sender, RoutedEventArgs e)
        {
            Container.Content = new Login();
            BtnMainLogout.Visibility = Visibility.Collapsed;
            BtnMainLogin.Visibility = Visibility.Visible;
            BtnPorudzbina.Visibility = Visibility.Collapsed;
            BtnRacun.Visibility = Visibility.Collapsed;
            BtnArtikli.Visibility = Visibility.Collapsed;
            TBUlogovanKorisnik.FontSize = 16;
            TBUlogovanKorisnik.Text = "Za pristup aplikaciji se morate ulogovati";
        }
    }
}
