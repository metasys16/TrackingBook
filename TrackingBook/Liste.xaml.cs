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
using TrackingBook.Modele;

namespace TrackingBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Liste : Page
    {
        public Liste()
        {
            InitializeComponent();

            List<Livre> items = new List<Livre>();
            items.Add(new Livre() { Titre = "L'étranger", Auteur = "Camus", Genre = "Roman", DateAjout = "2016", Disponibilite = "Dispo" });
            listeLivres.ItemsSource = items;

        }

        private class Livre
        {
            public Livre() { }

            public Livre(Exemplaire exemplaire) {
                // Récupérer le titre de l'exmplaire il y un titre unique pour une oeuvre mais plusieurs exemplaires peuvent exister pour une oeuvre
                this.Titre = exemplaire.Oeuvre.Titre;

                // Il peut y avoir un ou plusieurs auteurs, il faut récuperer ces auteurs via une liste
                List<Auteur> listeauteurs = exemplaire.Oeuvre.Auteurs;
                StringBuilder sb = new StringBuilder();
                foreach (Auteur auteur in listeauteurs)
                {
                    sb.Append(auteur.PrenomAuteur).Append(" ").Append(auteur.Nom);
                }
                this.Auteur = sb.ToString();


                // Récupérer le genre d'une oeuvre, un oeuvre peut être associé à un ou plusieurs genres
                List<Genre> listegenres = exemplaire.Oeuvre.Genres;
                StringBuilder bulder = new StringBuilder();
                foreach (Genre genre in listegenres)
                {
                    bulder.Append(genre.Nom);
                }
                this.Genre = sb.ToString();
            }
            public string Titre { get; set; }

            public string Auteur { get; set; }

            public string Genre { get; set; }
            
            public string DateAjout { get; set; }

            public string Disponibilite { get; set; }

        }
        private void listeLivres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }




        

       
    }
}
