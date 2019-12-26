using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MembreGalerie
{
   public  class Artiste:Personne
    {
        private string IDArtiste;

        public Artiste(string _IDArtiste,string _nom, string _prenom) : base(_nom, _prenom)
        {
            IDArtiste= _IDArtiste ;
            Nom = _nom ;
            Prenom = _prenom  ;
        }

        public string IDArtiste1
        {
            get
            {
                return IDArtiste;
            }

            set
            {
                IDArtiste = value;
            }
        }

        public override string ToString()
        {
            string Artiste= "ID #"+IDArtiste1+", "+base.ToString()+"\r\n";
            return Artiste;

        }
    }
}
