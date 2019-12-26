using System;
using System.Collections.Generic;
using System.IO;

namespace MembreGalerie
{
    public class Galerie
    {

        public List<Artiste> lesartiste;
        public List<Conservateur> lesConvservateurs;
        public List<Oeuvre> loeuvre;
		 


        public Galerie()
        {
            lesartiste = new List<Artiste>();
            lesConvservateurs = new List<Conservateur>();
            loeuvre = new List<Oeuvre>();
        }


        /******************************************ARTISTES*********************************************/


        //Ajout d'un artiste

        public void ajouterArtiste(string _IDArtististe, string _nom, string _prenom)
        {
            this.lesartiste.Add(new Artiste(_IDArtististe, _nom, _prenom));


        }

        //Afficahage des artistes
        public string afficherArtistes()
        {
            string affiche = "Artistes : \r\n";
            foreach (Artiste c in lesartiste)
                affiche += c.ToString() + " \r\n";
            return affiche;
        }


        //Lecture de l'artiste
        public bool LireArtistes()
        {
            string[] strArray;
            string path = Directory.GetCurrentDirectory();
            path += "\\Artistes.txt";
            if (!File.Exists(path))
            {
                return false;
            }
            else
            {
                StreamReader sr = new StreamReader("Artistes.txt");
                string strLine = sr.ReadLine();
                lesartiste.Clear();
                while (strLine != null)
                {
                    strArray = strLine.Split(',');
                    lesartiste.Add(new Artiste(strArray[0], strArray[1], strArray[2]));
                    strLine = sr.ReadLine();
                }
                sr.Close();
                return true;
            }
        }

        //Ecriture artiste
        public bool EcrireArtistes()
        {
            string path;
            path = Directory.GetCurrentDirectory();
            path += "\\Artistes.txt";
            if (!File.Exists(path))
            {
                return false;
            }
            else
            {
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < lesartiste.Count; i++)
                {
                    sw.WriteLine("{0},{1},{2}", lesartiste[i].IDArtiste1,
                    lesartiste[i].Nom, lesartiste[i].Prenom);

                }
                sw.Close();
                return true;
            }
        }

        //Verifie si l'artiste existe dejà
        public bool trouverArtiste(string id)
        {
            foreach (Artiste var in lesartiste)
            {
                if (var.IDArtiste1.Equals(id))
                    return true;
            }


            return false;
        }


        /*****************************CONSERVATEURS*********************************************/

        //Ajout d'un conservateur

        public void ajouterConservateur(string _IDConservateur, string _nom, string _prenom)
        {
            this.lesConvservateurs.Add(new Conservateur(_IDConservateur, _nom, _prenom, 0));

        }

        //Afficahage des conservateurs
        public string afficherConservateurs()
        {
            string affiche = "Conservateurs : \r\n";
            foreach (Conservateur c in lesConvservateurs)
                affiche += c.ToString() + " \r\n";
            return affiche;
        }
        //Lecture du conservateur
        public bool LireConservateurs()
        {
            string[] strArray;
            string path = Directory.GetCurrentDirectory();
            path += "\\Conservateurs.txt";
            if (!File.Exists(path))
            {
                return false;
            }
            else
            {
                StreamReader sr = new StreamReader("Conservateurs.txt");
                string strLine = sr.ReadLine();
                lesConvservateurs.Clear();
                while (strLine != null)
                {
                    strArray = strLine.Split(',');
                    lesConvservateurs.Add(new Conservateur(strArray[0], strArray[1], strArray[2], Convert.ToDouble(strArray[3])));
                    strLine = sr.ReadLine();
                }
                sr.Close();
                return true;
            }
        }

		public double EstimaPrix(string id)
		{
			double valeurEstimee=-1;
			foreach(Oeuvre ov in loeuvre)
			{

				if (ov.IdOeuvre.Equals(id))
				{

					valeurEstimee = ov.Estimation;
				}
			}
			return valeurEstimee;

		}
        //Ecriture de conservateur
        public bool EcrireConservateurs()
        {
            string path;
            path = Directory.GetCurrentDirectory();
            path += "\\Conservateurs.txt";
            if (!File.Exists(path))
            {
                return false;
            }
            else
            {
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < lesConvservateurs.Count; i++)
                {
                    sw.WriteLine("{0},{1},{2},{3}", lesConvservateurs[i].IDConservateur1,
                    lesConvservateurs[i].Nom, lesConvservateurs[i].Prenom, Convert.ToDouble(lesConvservateurs[i].Commission1));
                }
                sw.Close();
                return true;
            }
        }

        //Verifie si le conservateur existe dejà
        public bool trouverConservateur(string id)
        {
            foreach (Conservateur var in lesConvservateurs)
            {
                if (var.IDConservateur1.Equals(id))
                    return true;
            }


            return false;
        }


        /*****************************OEUVRES*********************************************/

        //Ájouter Oeuvre

        public void ajouterOuevre(string _idOeuvre, string _titre, string _annee, double _estimation, string _idArtiste, string _idConservateur, char _etat)
        {
            this.loeuvre.Add(new Oeuvre(_idOeuvre, _titre, _annee, _estimation, _idArtiste, _idConservateur, _etat));


        }

        //Trouver Oeuvre

        public bool trouverOeuvre(string id)
        {
            foreach (Oeuvre oeuv in loeuvre)
                if (oeuv.IdOeuvre.Equals(id))
                {
                    return true;
                }

            return false;


        }
        //Rapport oeuvre

        public string rapportOeuvres()
        {
            string rapport = "Oeuvres :\r\n";

            foreach (Oeuvre o in loeuvre)
            {
                rapport += o.ToString() + "\r\n";
            }
            return rapport;
        }


        // vente d'oeuvre
        public bool vendreOeuvre(String idO, double prix)

        {
      //  bool OeuvreVendu=false;
            foreach (Oeuvre varo in loeuvre)
            {
                if (varo.IdOeuvre.Equals(idO))
                {                    
                    foreach (Conservateur var in lesConvservateurs)
					{
						if (var.IDConservateur1.Equals(varo.IdConservateur))
						{		
								if (varo.Etat != 'V')
								{
								 
								var.setComm(varo.calculerCommission(prix));
								varo.changerEtat('V');
								return true;
							}								
													
								
							 
						}
					}
                   
               }
            }
            return false;
        }

    }
}

