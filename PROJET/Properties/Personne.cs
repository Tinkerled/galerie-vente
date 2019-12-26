using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembreGalerie
{
  public   class Personne
    {
      
        private string nom;
        private string prenom;

        public Personne()
        {
        }

        public Personne( string _nom, string _prenom)
        {    
            this.Nom = _nom;
            this.Prenom = _prenom;
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

       
        public virtual   string ToString()
        {
           // string personne = "Nom" + nom + " Prenom :" + prenom ;
            return nom + " " + prenom;  

        }
    }
}
