using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembreGalerie
{
    public class Conservateur : Personne
    {
        private string IDConservateur;
        private double Commission;

        public string IDConservateur1
        {
            get
            {
                return IDConservateur;
            }

            set
            {
                IDConservateur = value;
            }
        }

        public double Commission1
        {
            get
            {
                return Commission;
            }

            set
            {
                Commission = value;
            }
        }

        public Conservateur(string _IDConservateur, string _nom, string _prenom,double commission ) : base(_nom, _prenom)
        {
            IDConservateur = _IDConservateur;
             Commission = commission;
             Nom = _nom ;
             Prenom = _prenom;
        }


        public override string ToString()
        {
            
            return "ID #" + IDConservateur + " , "+base.ToString()+ " Commission :" + Commission1 +"\r\n";
            

        }
        public void setComm(double commis)
        {
            Commission += commis;
        }

        
 
}
}
