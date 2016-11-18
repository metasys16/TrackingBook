using Modele;
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
using System.Windows.Navigation;


namespace TrackingBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {

            InitializeComponent();
        }

        private void btnList_Click(object sender, RoutedEventArgs e)
        {
            AccueilPage.Source = new Uri("AccueilPage.xaml", UriKind.Relative);
        }

        private void btnAjout_Click(object sender, RoutedEventArgs e)
        {
            AccueilPage.Source = new Uri("AjoutPage.xaml", UriKind.Relative);
        }

        private void btnPreter_Click(object sender, RoutedEventArgs e)
        {
            PretLivre pretLivre = new PretLivre();
            Window wind = new Window();
            wind.Content = pretLivre;
            wind.SizeToContent = SizeToContent.WidthAndHeight;
            wind.ResizeMode = System.Windows.ResizeMode.NoResize;
            wind.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wind.ShowDialog();
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            retourLivre retourLivre = new retourLivre();
            Window wind = new Window();
            wind.Content = retourLivre;
            wind.SizeToContent = SizeToContent.WidthAndHeight;
            wind.ResizeMode = System.Windows.ResizeMode.NoResize;
            wind.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wind.ShowDialog();
        }
    }
    
}
