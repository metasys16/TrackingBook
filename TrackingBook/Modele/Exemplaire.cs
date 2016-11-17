using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingBook.Modele
{
    public class Exemplaire
    {
        private Oeuvre oeuvre;
        private Editeur editeur;
        private string photo;
        public DateTime dateAjout;
        private Char etat;
        public bool disponibilite;

        public Oeuvre Oeuvre
        {
            get { return oeuvre; }
            set { oeuvre = value; }
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


        public Char Etat
        {
            get { return etat; }
            set { etat = value; }
        }

        
  
        public bool Disponibilite
        {
            get { return disponibilite; }

            set
            {

                disponibilite = value;

            }
        }



    }
}
