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
using System.Windows.Shapes;

namespace WPF_RegisterLoginWelcome
{
    /// <summary>
    /// Interaction logic for KesKartica.xaml
    /// </summary>
    public partial class KesKartica : Window
    {
        public KesKartica()
        {
            InitializeComponent();
        }

        private readonly MainWindow mw = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            mw.KesKartica = (bool)RadioKes.IsChecked ? "Kes" : "Kartica";
            Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
