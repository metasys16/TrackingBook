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

namespace TrackingBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AjoutLivre : Page
    {
        
        public AjoutLivre()
        {
            InitializeComponent();
        }


        //MainWindow main = new MainWindow();

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
             
            this.NavigationService.GoBack();
        }

        private void btnConfirmer_Click(object sender, RoutedEventArgs e)
        {
            PopUpAjout popUpA = new PopUpAjout();
            Window winpopA = new Window();
            winpopA.Content = popUpA;
            winpopA.SizeToContent = SizeToContent.WidthAndHeight;
            winpopA.ResizeMode = System.Windows.ResizeMode.NoResize;
            winpopA.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            winpopA.ShowDialog();
        }
    }
}
