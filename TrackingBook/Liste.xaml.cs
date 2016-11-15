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
    public partial class ListeLivres : Window
    {
        public ListeLivres()
        {
            InitializeComponent();
            List<Livre> items = new List<Livre>();
            items.Add(new Livre() { Titre = "Il etait une fois au Portugal", Auteur = "Mickaël Pereira"});
            items.Add(new Livre() { Titre = "Le design pour les nuls", Auteur = "Coline Martin" });
            items.Add(new Livre() { Titre = "Les bouchons c'est mal", Auteur = "Pierre Pussault" });
            listeLivres.ItemsSource = items;
        }
    }

    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string Editeur { get; set; }
        public string Genre { get; set; }
        public DateTime DateAjout { get; set; }

        public bool Disponibilité { get; set; }
    }
}
