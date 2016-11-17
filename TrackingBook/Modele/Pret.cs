using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingBook.Modele
{
    class Pret
    {
        // ATTRIBUTS //
        private DateTime dateDebut;
        private DateTime dateRetour;
        private DateTime dateRappel;

        // ACCESSEUR / MUTATEUR //
        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }

        public DateTime DateRetour
        {
            get { return dateRetour; }
            set { dateRetour = value; }
        }
       
        public DateTime DateRappel
        {
            get { return dateRappel; }
            set { dateRappel = value; }
        }


    }
}
