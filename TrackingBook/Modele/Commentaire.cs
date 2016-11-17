using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingBook.Modele
{
    class Commentaire
    {
        private String titre;

        public String Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        private String contenu;

        public String Contenu
        {
            get { return contenu; }
            set { contenu = value; }
        }


    }
}
