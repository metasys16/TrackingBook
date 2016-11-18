﻿using Modele;
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
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
