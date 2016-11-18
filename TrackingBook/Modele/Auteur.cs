using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingBook.Modele
{

    public class Auteur : INotifyPropertyChanged

    {
        private String nom;
        private String prenom;

        public event PropertyChangedEventHandler PropertyChanged;
        private void FirePropertyChanged(string nomAuteur)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(nomAuteur));
            }
        }

        public String Nom
        {
            get { return nom; }
            set {
                if (this.nom != value)
                {
                    this.nom = value;
                    this.FirePropertyChanged("Nom");
                }
            }
        }

        public String Prenom
        {
            get { return prenom; }
            set
            {
                if (this.prenom != value)
                {
                    this.prenom = value;
                    this.FirePropertyChanged("Prenom");
                }
            }
        }
    }
}
