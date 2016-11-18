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

namespace TrackingBook
{
    /// <summary>
    /// Logique d'interaction pour Window2.xaml
    /// </summary>
    public partial class PopUpPret : Page
    {
        public PopUpPret()
        {
            InitializeComponent();
        }

        private void btnMessageBoxWithTitle_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Window).Close();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            //enregistrement
            (this.Parent as Window).Close();
        }
    }
}
