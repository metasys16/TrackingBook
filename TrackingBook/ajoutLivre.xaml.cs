using Modele;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            this.DataContext = this;
            
        }
        private void btnAjoutLivre_Click(object sender, RoutedEventArgs e)
        {
            Oeuvre oeuvre = new Oeuvre();
            Auteur auteur = new Auteur();
            Editeur editeur = new Editeur();
            

            oeuvre.Titre = titre.Text;
            oeuvre.Resume = resume.Text;
            // VERIFICATION ISBSN unique
            oeuvre.ISBN10 = ISBN.Text;
            auteur.Nom = nomAuteur.Text;
            auteur.Prenom = prenomAuteur.Text;
            editeur.Nom = nomEditeur.Text;
          
            // Enregistrement d'un nouvel exemplaire

            Exemplaire exemplaire = new Exemplaire();

            exemplaire.DateAjout = new DateTime(); // dateCourante

            exemplaire.Disponibilite = true; // Il est disponible au pret

            exemplaire.Editeur = editeur;
            exemplaire.Auteur = auteur;
            exemplaire.Oeuvre = oeuvre;

            //exemplaire.Editeur.Nom;
            this.DataContext = exemplaire;

        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
           
            this.NavigationService.GoBack();
        }


        //MainWindow main = new MainWindow();

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
             
            this.NavigationService.GoBack();
        }

        private void btnAjoutLivre_Click(object sender, RoutedEventArgs e)
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
