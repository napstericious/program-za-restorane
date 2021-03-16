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
using WPF_RegisterLoginWelcome.Models;

namespace WPF_RegisterLoginWelcome
{
    /// <summary>
    /// Interaction logic for Artikli.xaml
    /// </summary>
    public partial class Artikli : Page
    {
        /*
        private List<KategorijeArtikala> Pitja = new List<KategorijeArtikala>();

        private List<KategorijeArtikala> Hrana = new List<KategorijeArtikala>();

        private List<KategorijeArtikala> Dezert = new List<KategorijeArtikala>();
        */

        string PutanjaArtikla = @"Artikli.json";

        string PutanjaKategorijePodmenijaArtikala = @"KategorijePodmenijaArtikala.json";

        private readonly MainWindow mw = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
        public Artikli()
        {
            InitializeComponent();
            ImgHrana.MouseDown += ImgHrana_MouseDown;
            ImgHrana.MouseEnter += ImgHrana_MouseEnter;
            ImgHrana.MouseLeave += ImgHrana_MouseLeave;

            ImgPitje.MouseDown += ImgPitje_MouseDown;
            ImgPitje.MouseEnter += ImgPitje_MouseEnter;
            ImgPitje.MouseLeave += ImgPitje_MouseLeave;

            ImgDezert.MouseDown += ImgDezert_MouseDown;
            ImgDezert.MouseEnter += ImgDezert_MouseEnter;
            ImgDezert.MouseLeave += ImgDezert_MouseLeave;

            CitajArtikle();
            /*
            double suma = 0;

            ListaArtikla.ForEach(x =>
            {
                suma += x.CenaArtikla;
            });
            double prosek = suma / ListaArtikla.Count;
           */




            #region
            /*
            KategorijeArtikala PA1 = new KategorijeArtikala
            {
                IDPodartikla = 1,
                ImePodartikla = "Kafe",
                PutanjaPodartikla = "Kafa.png"
            };

            KategorijeArtikala PA2 = new KategorijeArtikala
            {
                IDPodartikla = 2,
                ImePodartikla = "Čajevi",
                PutanjaPodartikla = "Cajevi.png"

            };

            KategorijeArtikala PA3 = new KategorijeArtikala
            {
                IDPodartikla = 3,
                ImePodartikla = "Sokovi",
                PutanjaPodartikla = "Sokovi.png"
            };

            KategorijeArtikala PA4 = new KategorijeArtikala
            {
                IDPodartikla = 4,
                ImePodartikla = "Piva",
                PutanjaPodartikla = "Piva.png"
            };

            KategorijeArtikala PA5 = new KategorijeArtikala
            {
                IDPodartikla = 5,
                ImePodartikla = "Vina",
                PutanjaPodartikla = "Vina.png"
            };

            KategorijeArtikala PA6 = new KategorijeArtikala
            {
                IDPodartikla = 6,
                ImePodartikla = "Žestina",
                PutanjaPodartikla = "Zestina.png"
            };

            KategorijeArtikala PA10 = new KategorijeArtikala
            {
                IDPodartikla = 10,
                ImePodartikla = "Pice",
                PutanjaPodartikla = "Pice.png"
            };

            KategorijeArtikala PA11 = new KategorijeArtikala
            {
                IDPodartikla = 11,
                ImePodartikla = "Paste",
                PutanjaPodartikla = "Paste.png"
            };

            KategorijeArtikala PA12 = new KategorijeArtikala
            {
                IDPodartikla = 12,
                ImePodartikla = "Palačinke",
                PutanjaPodartikla = "Palacinke.png"
            };

            KategorijeArtikala PA13 = new KategorijeArtikala
            {
                IDPodartikla = 13,
                ImePodartikla = "Burgeri",
                PutanjaPodartikla = "Burgeri.png"
            };

            KategorijeArtikala PA14 = new KategorijeArtikala
            {
                IDPodartikla = 14,
                ImePodartikla = "Salate",
                PutanjaPodartikla = "Salate.png"
            };

            KategorijeArtikala PA15 = new KategorijeArtikala
            {
                IDPodartikla = 15,
                ImePodartikla = "Sendviči",
                PutanjaPodartikla = "Sendvici.png"
            };

            KategorijeArtikala PA20 = new KategorijeArtikala
            {
                IDPodartikla = 20,
                ImePodartikla = "Sladoled",
                PutanjaPodartikla = "Sladoled.png"
            };

            KategorijeArtikala PA21 = new KategorijeArtikala
            {
                IDPodartikla = 21,
                ImePodartikla = "Kolači",
                PutanjaPodartikla = "Kolaci.png"
            };

            KategorijeArtikala PA22 = new KategorijeArtikala
            {
                IDPodartikla = 22,
                ImePodartikla = "Mafini",
                PutanjaPodartikla = "Mafini.png"
            };

            KategorijeArtikala PA23 = new KategorijeArtikala
            {
                IDPodartikla = 23,
                ImePodartikla = "Torte",
                PutanjaPodartikla = "Torte.png"
            };

            KategorijeArtikala PA24 = new KategorijeArtikala
            {
                IDPodartikla = 24,
                ImePodartikla = "Slatka Peciva",
                PutanjaPodartikla = "SlatkaPeciva.png"
            };

            KategorijeArtikala PA25 = new KategorijeArtikala
            {
                IDPodartikla = 25,
                ImePodartikla = "Voćne Salate",
                PutanjaPodartikla = "VocneSalate.png"
            };


            Pitja.Add(PA1);
            Pitja.Add(PA2);
            Pitja.Add(PA3);
            Pitja.Add(PA4);
            Pitja.Add(PA5);
            Pitja.Add(PA6);

            Hrana.Add(PA10);
            Hrana.Add(PA11);
            Hrana.Add(PA12);
            Hrana.Add(PA13);
            Hrana.Add(PA14);
            Hrana.Add(PA15);

            Dezert.Add(PA20);
            Dezert.Add(PA21);
            Dezert.Add(PA22);
            Dezert.Add(PA23);
            Dezert.Add(PA24);
            Dezert.Add(PA25);
            */
            #endregion
        }

        //private List<KategorijeArtikala> ListaPodmenijaArtikala = new List<KategorijeArtikala>();
        private List<ArtikliPodmenija> KategorijePodmenijaArtikala()
        {


            try
            {
                if (File.Exists(PutanjaKategorijePodmenijaArtikala))
                {
                    string jsonString = File.ReadAllText(PutanjaKategorijePodmenijaArtikala);
                    return JsonConvert.DeserializeObject<List<ArtikliPodmenija>>(jsonString);
                }
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);

            }
            return new List<ArtikliPodmenija>();
        }

        private List<Artikl> ListaArtikla = new List<Artikl>();

        private List<Artikl> CitajArtikle()
        {

            ListaArtikla.Clear();
            try
            {
                if (File.Exists(PutanjaArtikla))
                {
                    string jsonString = File.ReadAllText(PutanjaArtikla);
                    ListaArtikla = JsonConvert.DeserializeObject<List<Artikl>>(jsonString);
                    return ListaArtikla;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            //finally nije neophodan ovde ali se preporucuje 
            /*
            finally
            {
                MessageBox.Show("Sta god hoces.");
            }
            */
            return new List<Models.Artikl>();
        }
        private void ImgDezert_MouseLeave(object sender, MouseEventArgs e)
        {
            Image img = sender as Image;
            img.Opacity = .6;
            TBDezert.Opacity = .6;
        }

        private void ImgDezert_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = sender as Image;
            img.Opacity = 1;
            TBDezert.Opacity = 1;
        }

        private void ImgDezert_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImgDezert.MouseLeave -= ImgDezert_MouseLeave;
            ImgHrana.MouseLeave += ImgHrana_MouseLeave;
            ImgPitje.MouseLeave += ImgPitje_MouseLeave;
            PodMeni.Children.Clear();
            ImgDezert.Opacity = 1;
            ImgPitje.Opacity = .6;
            ImgHrana.Opacity = .6;

            List<ArtikliPodmenija> ListaKategorijaArtikala = KategorijePodmenijaArtikala().Where(y => y.IDKategorije == 3).ToList();
            ListaKategorijaArtikala.ForEach(x =>
            {
                BitmapImage bitmapDezert = new BitmapImage(new Uri($"pack://application:,,,/Slike/ikonice/BeleIkonice/{x.PutanjaSlikeArtiklaPodmenija}", UriKind.Absolute));
                Image imgDezert = new Image
                {
                    Source = bitmapDezert,
                    Width = 55,
                    Height = 55,
                    Opacity = 1,
                    //ToDo: Kako namestiti da ima margina ili border izmedju svakog elementa podartikla???
                    //Done: Ovo smo namestili tako sto smo atribut margin uneli u samo telo konstruktora stackpanel sp ispod textblock tb
                };
                TextBlock TB = new TextBlock
                {
                    Text = x.ImeArtiklaPodmenija,
                    FontWeight = FontWeights.Bold,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Foreground = Brushes.White,
                };
                StackPanel SP = new StackPanel
                {
                    Orientation = Orientation.Vertical,
                    Margin = new Thickness(0.0, 0.0, 30.0, 0.0)
                };
                SP.Children.Add(imgDezert);
                SP.Children.Add(TB);

                imgDezert.MouseDown += ImgDezert_MouseDown;
                PodMeni.Children.Add(SP);
            });

        }

        private void ImgPitje_MouseLeave(object sender, MouseEventArgs e)
        {
            Image img = sender as Image;
            img.Opacity = .6;
            TBPitja.Opacity = .6;
        }

        private void ImgPitje_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = sender as Image;
            img.Opacity = 1;
            TBPitja.Opacity = 1;
        }

        private void ImgPitje_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImgPitje.MouseLeave -= ImgPitje_MouseLeave;
            ImgHrana.MouseLeave += ImgHrana_MouseLeave;
            ImgDezert.MouseLeave += ImgDezert_MouseLeave;
            PodMeni.Children.Clear();
            ImgPitje.Opacity = 1;
            ImgHrana.Opacity = .6;
            ImgDezert.Opacity = .6;
            /*KategorijeArtikala().Where(y => y.IDKategorije == 2).ToList().ForEach(x => {
                BitmapImage carBitmap = new BitmapImage(new Uri($"pack://application:,,,/Slike/ikonice/BeleIkonice/{x.PutanjaPodartikla}", UriKind.Absolute));
                */
            List<ArtikliPodmenija> ListaKategorijaArtikala = KategorijePodmenijaArtikala().Where(y => y.IDKategorije == 2).ToList();
            ListaKategorijaArtikala.ForEach(x =>
            {
                BitmapImage bitmapPitja = new BitmapImage(new Uri($"pack://application:,,,/Slike/ikonice/BeleIkonice/{x.PutanjaSlikeArtiklaPodmenija}", UriKind.Absolute));
                ArtikliPodmenija KA = new ArtikliPodmenija
                {
                    IDKategorije = x.IDKategorije,
                    IDArtiklaPodmenija = x.IDArtiklaPodmenija,
                    ImeArtiklaPodmenija = x.ImeArtiklaPodmenija,
                    PutanjaSlikeArtiklaPodmenija = x.PutanjaSlikeArtiklaPodmenija
                };

                Image imgPitja = new Image
                {
                    Source = bitmapPitja,
                    Width = 55,
                    Height = 55,
                    Opacity = 1,
                    Tag = KA
                };
                TextBlock TB = new TextBlock
                {
                    Text = x.ImeArtiklaPodmenija,
                    FontWeight = FontWeights.Bold,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Foreground = Brushes.White,
                };
                StackPanel SP = new StackPanel
                {
                    Orientation = Orientation.Vertical,
                    Margin = new Thickness(0.0, 0.0, 30.0, 0.0)
                };
                SP.Children.Add(imgPitja);
                SP.Children.Add(TB);

                imgPitja.MouseDown += ImgPitja_MouseDown;
                PodMeni.Children.Add(SP);
            });

        }

        //Ova metoda je za svaki specifican artikl, njegovu sliku, ime i cenu. 
        //ToDo: Kad zavrsis testiranje i povezes sa bazom, odradi istu metodu za hranu i dezert. 
        //SideNote: Zbog ove metode ispod se ponistava dogadjaj MouseEnter i opacity = 1 jer je opacity podesen na .6 za sve children "x.opacity = .6"
        private void ImgPitja_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WrapArtikli.Children.Clear();
            List<StackPanel> stack = PodMeni.Children.OfType<StackPanel>().ToList();
            stack.ForEach(x =>
            {
                x.Opacity = .6;
            });


            Image img = sender as Image;
            StackPanel sp = img.Parent as StackPanel;
            TextBlock tb = sp.Children.OfType<TextBlock>().First();
            sp.Cursor = Cursors.Hand;
            sp.Opacity = 1;
            /*
            Border BeliBorder = new Border
            {
                BorderThickness = new Thickness(5),
                BorderBrush = Brushes.White
            };
            */

            ArtikliPodmenija KA = img.Tag as ArtikliPodmenija;

            CitajArtikle().Where(y => y.IDArtiklaPodmenija == KA.IDArtiklaPodmenija).ToList().ForEach(x =>
            {
                StackPanel sp2 = new StackPanel
                {
                    Orientation = Orientation.Vertical
                };
                BitmapImage carBitmap = new BitmapImage(new Uri($"pack://application:,,,/Slike/{x.KategorijaArtikla}/{x.PutanjaSlikeArtikla}", UriKind.Absolute));
                Models.Artikl AM = new Models.Artikl
                {
                    IDArtikla = x.IDArtikla,
                    IDArtiklaPodmenija = x.IDArtiklaPodmenija,
                    ImeArtikla = x.ImeArtikla,
                    CenaArtikla = x.CenaArtikla,
                    PutanjaSlikeArtikla = x.PutanjaSlikeArtikla,
                    KategorijaArtikla = x.KategorijaArtikla
                };
                Image imgArtikli = new Image
                {
                    Source = carBitmap,
                    Width = 70,
                    Height = 70,
                    Opacity = 1,
                    Tag = AM
                };
                TextBlock TBIme = new TextBlock
                {
                    Text = x.ImeArtikla,
                    FontWeight = FontWeights.Bold,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Foreground = Brushes.White,
                };
                TextBlock TBCena = new TextBlock
                {
                    Text = $"{x.CenaArtikla.ToString()} RSD",
                    FontWeight = FontWeights.Bold,
                    HorizontalAlignment = HorizontalAlignment.Right,
                    Foreground = Brushes.White,
                };

                sp2.Children.Add(imgArtikli);
                sp2.Children.Add(TBIme);
                sp2.Children.Add(TBCena);
                WrapArtikli.Children.Add(sp2);

                imgArtikli.MouseDown += ImgArtikli_MouseDown;
            });
        }


        private void ImgArtikli_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image img3 = sender as Image;
            Models.Artikl AM = img3.Tag as Models.Artikl;

            StackPanel SP = new StackPanel
            {
                Orientation = Orientation.Horizontal,
            };
            TextBlock TBImeArtikla = new TextBlock
            {
                Text = AM.ImeArtikla,
                FontWeight = FontWeights.Bold,
                Foreground = Brushes.White
            };
            TextBlock TBCenaArtikla = new TextBlock
            {
                Text = AM.CenaArtikla.ToString(),
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(10, 0, 0, 0),
                Foreground = Brushes.White
            };
            TextBlock TBKolicinaArtikla = new TextBlock
            {

            };
            BitmapImage bitmapPitja = new BitmapImage(new Uri($"pack://application:,,,/Slike/DeleteDugme.png", UriKind.Absolute));
            Image imgObrisi = new Image
            {
                Source = bitmapPitja,
                Width = 30,
                Height = 30,
                Opacity = 1,
                Margin = new Thickness(10, 0, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Right
            };
            SP.Children.Add(TBImeArtikla);
            SP.Children.Add(TBCenaArtikla);
            SP.Children.Add(imgObrisi);
            //ToDo
            //Ovde ide uslov da proveri da li vec ima jedan porucen artikl, ako ima da samo poveca cifru u novom textblock-u, ako nema da onda doda child u SP
            //Da li da ubacim atribut tj properti u klasi ArtikliMenija, koji ce biti za brojanje kolicine istih artikala
            mw.SPPorudzbine.Children.Add(SP);

        }

        private void ImgHrana_MouseLeave(object sender, MouseEventArgs e)
        {
            Image img = sender as Image;
            img.Opacity = .6;
            TBHrana.Opacity = .6;
        }

        private void ImgHrana_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = sender as Image;
            img.Opacity = 1;
            TBHrana.Opacity = 1;
        }

        private void ImgHrana_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ImgHrana.MouseLeave -= ImgHrana_MouseLeave;
            ImgDezert.MouseLeave += ImgDezert_MouseLeave;
            ImgPitje.MouseLeave += ImgPitje_MouseLeave;
            PodMeni.Children.Clear();
            ImgPitje.Opacity = .6;
            ImgHrana.Opacity = 1;
            ImgDezert.Opacity = .6;
            List<ArtikliPodmenija> ListaKategorijaArtikala = KategorijePodmenijaArtikala().Where(y => y.IDKategorije == 1).ToList();
            ListaKategorijaArtikala.ForEach(x =>
            {
                BitmapImage bitmapHrana = new BitmapImage(new Uri($"pack://application:,,,/Slike/ikonice/BeleIkonice/{x.PutanjaSlikeArtiklaPodmenija}", UriKind.Absolute));
                Image imgHrana = new Image
                {
                    Source = bitmapHrana,
                    Width = 55,
                    Height = 55,
                    Opacity = 1,
                };
                TextBlock TB = new TextBlock
                {
                    Text = x.ImeArtiklaPodmenija,
                    FontWeight = FontWeights.Bold,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Foreground = Brushes.White,
                };
                StackPanel SP = new StackPanel
                {
                    Orientation = Orientation.Vertical,
                    Margin = new Thickness(0.0, 0.0, 30.0, 0.0)
                };
                SP.Children.Add(imgHrana);
                SP.Children.Add(TB);

                imgHrana.MouseDown += ImgHrana_MouseDown;
                PodMeni.Children.Add(SP);
            });
        }
    }
}
