using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingBook
{
    class Exemplaire
    {
        private string photo;
        private DateTime dateAjout;
        private String etat;
        private bool disponibilite;

        private Editeur editeur;
        private Auteur auteur;
        private Oeuvre oeuvre;

        public Oeuvre Oeuvre
        {
            get { return oeuvre; }
            set { oeuvre = value; }
        }

        public Auteur Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }
        public Editeur Editeur
        {
            get { return editeur; }
            set { editeur = value; }
        }

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public DateTime DateAjout
        {
            get { return dateAjout; }
            set { dateAjout = value; }
        }
    

        public string Etat
        {
            get { return etat; }
            set { etat = value; }
        }

        

        public bool Disponibilite
        {
            get { return disponibilite; }
            set { disponibilite = value; }
        }

    }
}
