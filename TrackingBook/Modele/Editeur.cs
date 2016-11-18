using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingBook
{
    class Editeur : INotifyPropertyChanged
    {

        private String nom;

        public String Nom
        {
            get { return nom; }
            set
            {
                if (nom != value)
                {
                    nom = value;
                    this.NotifyPropertyChanged("Editeur");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string editeur)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(editeur));
            }
        }

    }
}
