using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingBook
{
    class MoyenContact
    {
        private string type;
        private string valeur;
        private int ordre;


        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        
        public string Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }

        
        public int Ordre
        {
            get { return ordre; }
            set { ordre = value; }
        }


    }
}
