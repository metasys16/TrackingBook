using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingBook.Modele
{
    public class Auteur
    {
        private String nom;
        private String prenom;

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }


        public String PrenomAuteur
        {
            get { return prenom; }
            set { prenom = value; }
        }


    }
}
