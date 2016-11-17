using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingBook
{
    class Oeuvre
    {
        private String titre;
        private String resume;
        private int isbn10;
        private int isbn13;

        public String Titre
        {
            get { return titre; }
            set { titre = value; }
        }

      

        public String Resume
        {
            get { return resume; }
            set { resume = value; }
        }

        

        public int ISBN10
        {
            get { return isbn10; }
            set { isbn10 = value; }
        }

       

        public int ISBN13
        {
            get { return isbn13; }
            set { isbn13 = value; }
        }


    }
}
