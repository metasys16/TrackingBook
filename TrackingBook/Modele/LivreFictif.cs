using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingBook.Modele
{
    class LivreFictif
    {

        private String titre;
        private String auteur;
        private String genre;
        private DateTime dateajout;
        private Boolean disponibilite;

        public LivreFictif(String titre, String auteur, String genre, DateTime dateajout, Boolean disponibilite)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.genre = genre;
            this.dateajout = dateajout;
            this.disponibilite = disponibilite;

        }

       
    }
}
