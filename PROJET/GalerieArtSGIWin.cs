using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MembreGalerie;
using PROJET;

namespace PROJET
{
    public partial class GalerieArtSGIWin : Form
    {
        public GalerieArtSGIWin()
        {
            InitializeComponent();
        }

        int nbEssaie = 0;
        private void btnOk_Click(object sender, EventArgs e)
        {
            string utilisateur = txtUsername.Text.Trim().ToLower();
            String motDePasse = txtPassword.Text.Trim().ToLower();

            bool okCredentiel = false  ;
           
            do
            {
                nbEssaie++;
                 utilisateur = txtUsername.Text.Trim().ToLower();
                 motDePasse = txtPassword.Text.Trim().ToLower();
                if (!String.IsNullOrEmpty(utilisateur) && !String.IsNullOrEmpty(motDePasse))
                {
                    
                    okCredentiel = (utilisateur == "sgi" && motDePasse == "admin");
                    if (okCredentiel)
                    {
                        MessageBox.Show("Connexion .Reussie!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Application.Exit();
                        this.Hide();
                        SGIArt sgiArt = new SGIArt();
                        sgiArt.Visible = true;
                        sgiArt.Activate();
                        


                    }
                    else
                    {
                        if(nbEssaie==2)
                        {
                            txtUsername.Text = String.Empty;
                            txtUsername.Text = String.Empty;
                            txtUsername.Focus();
                            MessageBox.Show("Les informations saisies ne sont pas valides,il vous reste  :" + (3 - nbEssaie) + " essai(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        else if (nbEssaie == 1)
                        {
                            txtUsername.Text = String.Empty;
                            txtUsername.Text = String.Empty;
                            txtUsername.Focus();
                            MessageBox.Show("Echec de connexion,il vous reste :" + (3 - nbEssaie) + " essai(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        else
                        {
                            txtUsername.Text = String.Empty;
                            txtUsername.Text = String.Empty;
                            txtUsername.Focus();
                            MessageBox.Show("Username et Password requis pour accèder au systeme: " + (3 - nbEssaie) + " essai(s),!Aurevoir", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }

                }
                else
                {
                    Application.Exit();


                }

            } while (!okCredentiel && nbEssaie == 3);




        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

            DialogResult reponse = MessageBox.Show("Désirez-vous réellement quitter cette application ? ",
            "Attention",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
