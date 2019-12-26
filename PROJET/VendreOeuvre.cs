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

namespace PROJET
{
    public partial class VendreOeuvre : Form
    {
        Galerie g;
		//Oeuvre oeuv;
        public VendreOeuvre(Galerie gal)
        {
            InitializeComponent();
            g = gal;

        }

        private void btnVendre_Click(object sender, EventArgs e)
        {

            String ido = txtIdVente.Text;
            double prix = Convert.ToDouble(txtPrixVente.Text);
			double valeurEstime = g.EstimaPrix(ido);
            if (valeurEstime==-1)
            {
                MessageBox.Show("ID # " + ido + " n'existe pas!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
				if (prix > valeurEstime)
				{
					if (g.vendreOeuvre(ido, prix)&& prix!=0)
					{
						//g.vendreOeuvre(ido, prix);
						MessageBox.Show("Vente reussie!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Oeuvre dejà vendu!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				

				}else
				{
					MessageBox.Show("Prix inferieur à l'estimation", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
                   

            }

            txtIdVente.Text = "";
            txtPrixVente.Text = null;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
