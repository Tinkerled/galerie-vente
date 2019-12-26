using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembreGalerie;

namespace MembreGalerie
{
    public class Oeuvre
    {
        private string idOeuvre;
        private string titre;
        private string annee;
        private double prix;
        private double estimation;
        private char etat;
        private string idArtiste;
        private string idConservateur;

        public string IdOeuvre
        {
            get
            {
                return idOeuvre;
            }

            set
            {
                idOeuvre = value;
            }
        }

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public string Annee
        {
            get
            {
                return annee;
            }

            set
            {
                annee = value;
            }
        }

        public double Prix
        {
            get
            {
                return prix;
            }

            set
            {
                prix = value;
            }
        }

        public double Estimation
        {
            get
            {
                return estimation;
            }

            set
            {
                estimation = value;
            }
        }

        public char Etat
        {
            get
            {
                return etat;
            }

            set
            {
                etat = value;
            }
        }

        public string IdArtiste
        {
            get
            {
                return idArtiste;
            }

            set
            {
                idArtiste = value;
            }
        }

        public string IdConservateur
        {
            get
            {
                return idConservateur;
            }

            set
            {
                idConservateur = value;
            }
        }
        //Constructeur
        public Oeuvre(string idOeuvre, string titre, string annee, double prix, double estimation, char etat, string idArtiste, string idConservateur)
        {
            this.IdOeuvre = idOeuvre;
            this.Titre = titre;
            this.Annee = annee;
            this.Prix = 0;
            this.Estimation = estimation;
            this.Etat = etat;
            this.IdArtiste = idArtiste;
            this.IdConservateur = idConservateur;
        }
        public Oeuvre(string id, string titre, string annee,  double estimation, string idArtist, string idCon, char etat )
        {
            this.IdOeuvre = id;
            this.Titre = titre;
            this.Annee = annee;            
            this.Estimation = estimation;           
            this.IdArtiste = idArtist;
            this.IdConservateur = idCon;
            this.Etat = etat;
			this.prix = 0;
        }
        //Methode ToString
        public override string ToString()
        {
            return "ID # " + IdOeuvre + ",Titre  " + Titre + "  acquis en  " + Annee + " et présentement " + Etat + "  ID de l'artiste # " +
                IdArtiste + "  ID  du conservateur #  " + IdConservateur+ " . Valeur extimée = " + Estimation + "$ .Prix de vente + " + Prix + "$\n";


        }
        public void changerEtat(char statut)
        {
            if (statut == 'E' || statut == 'I' || statut == 'V')
            {
                etat = statut;
            }
        }


        public void prixPaye(double prixpayer)
        {

            prix = prixpayer;
        }

        public double calculerCommission(double prixVentdu)
        {
           
            this.prixPaye(prixVentdu);
           
                return ((prix - this.Estimation) * 0.25);
          
             

        }
    }
}
