using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingBook.Modele
{

    public class Oeuvre : INotifyPropertyChanged

    {
        private List<Auteur> auteurs = new List<Auteur>();
        private List<Genre> genres = new List<Genre>();
        private String titre;
        private String resume;
        private String isbn10;
        private String isbn13;


        public List<Auteur> Auteurs
        {
            get { return auteurs; }
            set { auteurs = value; }
        }

        public List<Genre> Genres
        {
            get { return genres; }
            set { genres = value; }
        }

        public String Titre
        {
            get { return titre; }
            set
            {
                if (titre != value)
                {
                    titre = value;
                    this.NotifyPropertyChanged("Titre");
                }
            }
        }

        public String Resume
        {
            get { return resume; }
            set
            {
                if (resume != value)
                {
                    resume = value;
                    this.NotifyPropertyChanged("Resume");
                }
            }
        }

        public String ISBN10
        {
            get { return isbn10; }
            set { isbn10 = value; }
        }

        public String ISBN13
        {
            get { return isbn13; }
            set { isbn13 = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string titreLivre)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(titreLivre));
            }
        }
    }
}
