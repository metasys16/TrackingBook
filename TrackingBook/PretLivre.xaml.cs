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
    public partial class PretLivre : Page
    {
        public PretLivre()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BoutonAnnuler_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Window).Close();
            
        }

        private void BoutonValider_Click(object sender, RoutedEventArgs e)
        {
            PopUpPret popUp = new PopUpPret();
            Window winpop = new Window();
            winpop.Content = popUp;
            winpop.SizeToContent = SizeToContent.WidthAndHeight;
            winpop.ResizeMode = System.Windows.ResizeMode.NoResize;
            winpop.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            winpop.ShowDialog();

        }
    }
}
