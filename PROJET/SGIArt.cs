using System;
using System.Windows.Forms;
using MembreGalerie;


namespace PROJET
{
	public partial class SGIArt : Form
	{
		public static Galerie g;
		public static Oeuvre o;

		public SGIArt()
		{
			InitializeComponent();
			g = new Galerie();
			g.LireArtistes();
			g.LireConservateurs();



		}
		/**********************************CONSERVATEURS*************************************/
		private void txtFermer_Click(object sender, EventArgs e)
		{
			DialogResult reponse = MessageBox.Show("Désirez-vous quitter cette application ?", "Attenton", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (reponse == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void tbOeuvres_Click(object sender, EventArgs e)
		{

		}

		private void btnSauvegarder_Click(object sender, EventArgs e)
		{

			if (!g.trouverConservateur(txtID.Text))

			{
				g.EcrireConservateurs();
				MessageBox.Show("Enregistrement reussie !", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{

				MessageBox.Show("Enregistrement echoué", "Enregistrement", MessageBoxButtons.OK,
								  MessageBoxIcon.Information);
			}


		}


		private void btnAjouter_Click(object sender, EventArgs e)
		{


			// Création de notre variable.

			// Assignation des valeurs à notre variable.
			if (!string.IsNullOrEmpty(txtID.Text) && !string.IsNullOrEmpty(txtNom.Text) && !string.IsNullOrEmpty(txtPrenom.Text))
			{


				string ID = txtID.Text;
				string Nom = txtNom.Text;
				string Prenom = txtPrenom.Text;
				if (g.trouverConservateur(txtID.Text))
				{
					MessageBox.Show("ID existe deja.", "Enregistrement", MessageBoxButtons.OK,
								  MessageBoxIcon.Information);
					return;

				}


				try
				{
					g.ajouterConservateur(ID, Nom, Prenom);

					MessageBox.Show("L'ajout  a réussi.", "Enregistrement", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
				}
				catch (Exception)
				{
					MessageBox.Show("Echec d'ajout.",
					"Enregistrement", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("Veuillez remplir les champs vides.", "Enregistrement", MessageBoxButtons.OK,
				MessageBoxIcon.Information);

			}

			txtID.Text = "";
			txtPrenom.Text = "";
			txtNom.Text = "";



		}

		private void btnAfficherListeConservateur_Click(object sender, EventArgs e)
		{

			txtDisplay.Clear();
			txtDisplay.AppendText(g.afficherConservateurs());


		}

		/*******************************ARTISTE*******************************************/
		private void btnAjoute_Click(object sender, EventArgs e)
		{

			// Création de notre variable.

			// Assignation des valeurs à notre variable.
			if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtNomArtiste.Text) && !string.IsNullOrEmpty(txtPrenomArtiste.Text))
			{


				string IDA = txtCode.Text;
				string NomA = txtNomArtiste.Text;
				string PrenomA = txtPrenomArtiste.Text;
				if (g.trouverArtiste(txtCode.Text))
				{
					MessageBox.Show("ID existe deja.", "Enregistrement", MessageBoxButtons.OK,
								  MessageBoxIcon.Information);
					return;

				}


				try
				{
					g.ajouterArtiste(IDA, NomA, PrenomA);

					MessageBox.Show("L'ajout  a réussi.", "Enregistrement", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
				}
				catch (Exception)
				{
					MessageBox.Show("Echec d'ajout.",
					"Enregistrement", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("Veuillez remplir les champs vides.", "Enregistrement", MessageBoxButtons.OK,
				MessageBoxIcon.Information);

			}

			txtCode.Text = "";
			txtNomArtiste.Text = "";
			txtPrenomArtiste.Text = "";

		}

		private void btnAfficheList_Click(object sender, EventArgs e)
		{
			txtDisplay.Clear();
			txtDisplay.AppendText(g.afficherArtistes());
		}

		private void btnSauvegarde_Click_1(object sender, EventArgs e)
		{
			if (!g.trouverArtiste(txtCode.Text))

			{
				g.EcrireArtistes();
				MessageBox.Show("Enregistrement reussie !", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{

				MessageBox.Show("Enregistrement echoué", "Enregistrement", MessageBoxButtons.OK,
								  MessageBoxIcon.Information);
			}
		}

		private void btnAjouter1_Click(object sender, EventArgs e)
		{
			// Assignation des valeurs à notre variable.
			if (!string.IsNullOrEmpty(txtIDO.Text)
				&& !string.IsNullOrEmpty(txtTitre.Text)
				&& !string.IsNullOrEmpty(txtAnnee.Text)
				 && !string.IsNullOrEmpty(txtValeurEstimee.Text)
				  && !string.IsNullOrEmpty(txtIDArtiste.Text)
				   && !string.IsNullOrEmpty(txtIDConservateur.Text))
			{


				string IDO = txtIDO.Text;
				string Titre = txtTitre.Text;
				string Annee = txtAnnee.Text;
				double Estimation = Convert.ToDouble(txtValeurEstimee.Text);
				string IDArtiste = txtIDArtiste.Text;
				string IDConservateur = txtIDConservateur.Text;



				if (g.trouverOeuvre(txtIDO.Text))
				{
					MessageBox.Show("ID existe deja.", "Enregistrement", MessageBoxButtons.OK,
								  MessageBoxIcon.Information);
					return;

				}
				if (!g.trouverArtiste(txtIDArtiste.Text))
				{
					MessageBox.Show("ID artiste n'existe pas .", "Enregistrement", MessageBoxButtons.OK,
								  MessageBoxIcon.Information);
					return;

				}
				if (!g.trouverConservateur(txtIDConservateur.Text))
				{
					MessageBox.Show("ID conservateur n'existe pas .", "Enregistrement", MessageBoxButtons.OK,
								  MessageBoxIcon.Information);
					return;

				}

				try
				{


					g.ajouterOuevre(IDO, Titre, Annee, Estimation, IDArtiste, IDConservateur, rdbExposee.Checked ? 'E' : 'I');

					MessageBox.Show("L'ajout  a réussi.", "Enregistrement", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
				}
				catch (Exception)
				{
					MessageBox.Show("Echec d'ajout.",
					"Enregistrement", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("Veuillez remplir les champs vides.", "Enregistrement", MessageBoxButtons.OK,
				MessageBoxIcon.Information);

			}

			txtIDO.Text = "";
			txtTitre.Text = "";
			txtAnnee.Text = "";
			txtValeurEstimee.Text = null;
			txtIDArtiste.Text = "";
			txtIDConservateur.Text = "";
			radioExp.Checked = true;


		}

		private void btnArtistes_Click(object sender, EventArgs e)
		{
			if (g.LireArtistes())
			{
				txtDisplay.Clear();
				txtDisplay.AppendText(g.afficherArtistes());
			}
		}

		private void btnConservateurs_Click(object sender, EventArgs e)
		{

			txtDisplay.Clear();
			txtDisplay.AppendText(g.afficherConservateurs());
			//txtDisplay.Text = (g.afficherArtistes());
		}

		private void btnListeOeuvres_Click(object sender, EventArgs e)
		{
			txtDisplay.Clear();
			txtDisplay.AppendText(g.rapportOeuvres());
		}

		private void btnVendre_Click(object sender, EventArgs e)
		{
			VendreOeuvre venreF = new VendreOeuvre(g);
			venreF.Show();

		}

		private void SGIArt_FormClosing(object sender, FormClosingEventArgs e)
		{
			// On s'assure que c'est bien l'intention de l'utilisateur de    quitter l'application
			DialogResult reponse = MessageBox.Show("Désirez-vous réellement quitter cette application ? ", "Attention",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question);
			// Si tel n’est le cas, on cancel l’événement.
			if (reponse == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void SGIArt_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}


}
