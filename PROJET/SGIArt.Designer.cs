namespace PROJET
{
    partial class SGIArt
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbConservateurs = new System.Windows.Forms.TabPage();
            this.btnAfficherListeConservateur = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbArtistes = new System.Windows.Forms.TabPage();
            this.btnAfficheList = new System.Windows.Forms.Button();
            this.btnSauvegarde = new System.Windows.Forms.Button();
            this.btnAjoute = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNomArtiste = new System.Windows.Forms.TextBox();
            this.txtPrenomArtiste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbOeuvres = new System.Windows.Forms.TabPage();
            this.btnVendre = new System.Windows.Forms.Button();
            this.btnAjouter1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListeOeuvres = new System.Windows.Forms.Button();
            this.btnConservateurs = new System.Windows.Forms.Button();
            this.btnArtistes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioExp = new System.Windows.Forms.RadioButton();
            this.rdbExposee = new System.Windows.Forms.RadioButton();
            this.txtIDConservateur = new System.Windows.Forms.TextBox();
            this.txtIDArtiste = new System.Windows.Forms.TextBox();
            this.txtValeurEstimee = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtIDO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFermer = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbConservateurs.SuspendLayout();
            this.tbArtistes.SuspendLayout();
            this.tbOeuvres.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fichier";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbConservateurs);
            this.tabControl1.Controls.Add(this.tbArtistes);
            this.tabControl1.Controls.Add(this.tbOeuvres);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 305);
            this.tabControl1.TabIndex = 1;
            // 
            // tbConservateurs
            // 
            this.tbConservateurs.BackColor = System.Drawing.SystemColors.Control;
            this.tbConservateurs.Controls.Add(this.btnAfficherListeConservateur);
            this.tbConservateurs.Controls.Add(this.btnSauvegarder);
            this.tbConservateurs.Controls.Add(this.btnAjouter);
            this.tbConservateurs.Controls.Add(this.txtID);
            this.tbConservateurs.Controls.Add(this.txtNom);
            this.tbConservateurs.Controls.Add(this.txtPrenom);
            this.tbConservateurs.Controls.Add(this.label5);
            this.tbConservateurs.Controls.Add(this.label4);
            this.tbConservateurs.Controls.Add(this.label3);
            this.tbConservateurs.Controls.Add(this.label2);
            this.tbConservateurs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConservateurs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbConservateurs.Location = new System.Drawing.Point(4, 26);
            this.tbConservateurs.Name = "tbConservateurs";
            this.tbConservateurs.Padding = new System.Windows.Forms.Padding(3);
            this.tbConservateurs.Size = new System.Drawing.Size(392, 275);
            this.tbConservateurs.TabIndex = 0;
            this.tbConservateurs.Text = "Conservateurs";
            // 
            // btnAfficherListeConservateur
            // 
            this.btnAfficherListeConservateur.Location = new System.Drawing.Point(258, 186);
            this.btnAfficherListeConservateur.Name = "btnAfficherListeConservateur";
            this.btnAfficherListeConservateur.Size = new System.Drawing.Size(100, 26);
            this.btnAfficherListeConservateur.TabIndex = 9;
            this.btnAfficherListeConservateur.Text = "Afficher Liste";
            this.btnAfficherListeConservateur.UseVisualStyleBackColor = true;
            this.btnAfficherListeConservateur.Click += new System.EventHandler(this.btnAfficherListeConservateur_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(146, 186);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(100, 26);
            this.btnSauvegarder.TabIndex = 8;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(34, 186);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 26);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(98, 122);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(236, 25);
            this.txtID.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(98, 88);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(236, 25);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(98, 54);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(236, 25);
            this.txtPrenom.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "&ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "&Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "&Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Information des conservateurs";
            // 
            // tbArtistes
            // 
            this.tbArtistes.BackColor = System.Drawing.SystemColors.Control;
            this.tbArtistes.Controls.Add(this.btnAfficheList);
            this.tbArtistes.Controls.Add(this.btnSauvegarde);
            this.tbArtistes.Controls.Add(this.btnAjoute);
            this.tbArtistes.Controls.Add(this.txtCode);
            this.tbArtistes.Controls.Add(this.txtNomArtiste);
            this.tbArtistes.Controls.Add(this.txtPrenomArtiste);
            this.tbArtistes.Controls.Add(this.label6);
            this.tbArtistes.Controls.Add(this.label7);
            this.tbArtistes.Controls.Add(this.label8);
            this.tbArtistes.Controls.Add(this.label9);
            this.tbArtistes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArtistes.Location = new System.Drawing.Point(4, 26);
            this.tbArtistes.Name = "tbArtistes";
            this.tbArtistes.Padding = new System.Windows.Forms.Padding(3);
            this.tbArtistes.Size = new System.Drawing.Size(392, 275);
            this.tbArtistes.TabIndex = 1;
            this.tbArtistes.Text = "Artistes";
            // 
            // btnAfficheList
            // 
            this.btnAfficheList.Location = new System.Drawing.Point(271, 194);
            this.btnAfficheList.Name = "btnAfficheList";
            this.btnAfficheList.Size = new System.Drawing.Size(100, 26);
            this.btnAfficheList.TabIndex = 19;
            this.btnAfficheList.Text = "Afficher Liste";
            this.btnAfficheList.UseVisualStyleBackColor = true;
            this.btnAfficheList.Click += new System.EventHandler(this.btnAfficheList_Click);
            // 
            // btnSauvegarde
            // 
            this.btnSauvegarde.Location = new System.Drawing.Point(159, 194);
            this.btnSauvegarde.Name = "btnSauvegarde";
            this.btnSauvegarde.Size = new System.Drawing.Size(100, 26);
            this.btnSauvegarde.TabIndex = 18;
            this.btnSauvegarde.Text = "Sauvegarder";
            this.btnSauvegarde.UseVisualStyleBackColor = true;
            this.btnSauvegarde.Click += new System.EventHandler(this.btnSauvegarde_Click_1);
            // 
            // btnAjoute
            // 
            this.btnAjoute.Location = new System.Drawing.Point(47, 194);
            this.btnAjoute.Name = "btnAjoute";
            this.btnAjoute.Size = new System.Drawing.Size(100, 26);
            this.btnAjoute.TabIndex = 17;
            this.btnAjoute.Text = "Ajouter";
            this.btnAjoute.UseVisualStyleBackColor = true;
            this.btnAjoute.Click += new System.EventHandler(this.btnAjoute_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(111, 130);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(236, 25);
            this.txtCode.TabIndex = 16;
            // 
            // txtNomArtiste
            // 
            this.txtNomArtiste.Location = new System.Drawing.Point(111, 96);
            this.txtNomArtiste.Name = "txtNomArtiste";
            this.txtNomArtiste.Size = new System.Drawing.Size(236, 25);
            this.txtNomArtiste.TabIndex = 15;
            // 
            // txtPrenomArtiste
            // 
            this.txtPrenomArtiste.Location = new System.Drawing.Point(111, 62);
            this.txtPrenomArtiste.Name = "txtPrenomArtiste";
            this.txtPrenomArtiste.Size = new System.Drawing.Size(236, 25);
            this.txtPrenomArtiste.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "&ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "&Nom :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "&Prénom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(20, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Information des artistes";
            // 
            // tbOeuvres
            // 
            this.tbOeuvres.BackColor = System.Drawing.SystemColors.Control;
            this.tbOeuvres.Controls.Add(this.btnVendre);
            this.tbOeuvres.Controls.Add(this.btnAjouter1);
            this.tbOeuvres.Controls.Add(this.groupBox2);
            this.tbOeuvres.Controls.Add(this.groupBox1);
            this.tbOeuvres.Controls.Add(this.txtIDConservateur);
            this.tbOeuvres.Controls.Add(this.txtIDArtiste);
            this.tbOeuvres.Controls.Add(this.txtValeurEstimee);
            this.tbOeuvres.Controls.Add(this.label16);
            this.tbOeuvres.Controls.Add(this.label15);
            this.tbOeuvres.Controls.Add(this.label14);
            this.tbOeuvres.Controls.Add(this.txtAnnee);
            this.tbOeuvres.Controls.Add(this.txtTitre);
            this.tbOeuvres.Controls.Add(this.txtIDO);
            this.tbOeuvres.Controls.Add(this.label10);
            this.tbOeuvres.Controls.Add(this.label11);
            this.tbOeuvres.Controls.Add(this.label12);
            this.tbOeuvres.Controls.Add(this.label13);
            this.tbOeuvres.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOeuvres.Location = new System.Drawing.Point(4, 26);
            this.tbOeuvres.Name = "tbOeuvres";
            this.tbOeuvres.Size = new System.Drawing.Size(392, 275);
            this.tbOeuvres.TabIndex = 2;
            this.tbOeuvres.Text = "Oeuvres d\'art";
            this.tbOeuvres.Click += new System.EventHandler(this.tbOeuvres_Click);
            // 
            // btnVendre
            // 
            this.btnVendre.Location = new System.Drawing.Point(252, 178);
            this.btnVendre.Name = "btnVendre";
            this.btnVendre.Size = new System.Drawing.Size(128, 30);
            this.btnVendre.TabIndex = 32;
            this.btnVendre.Text = "Vendre";
            this.btnVendre.UseVisualStyleBackColor = true;
            this.btnVendre.Click += new System.EventHandler(this.btnVendre_Click);
            // 
            // btnAjouter1
            // 
            this.btnAjouter1.Location = new System.Drawing.Point(253, 142);
            this.btnAjouter1.Name = "btnAjouter1";
            this.btnAjouter1.Size = new System.Drawing.Size(127, 30);
            this.btnAjouter1.TabIndex = 3;
            this.btnAjouter1.Text = "Ajouter";
            this.btnAjouter1.UseVisualStyleBackColor = true;
            this.btnAjouter1.Click += new System.EventHandler(this.btnAjouter1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListeOeuvres);
            this.groupBox2.Controls.Add(this.btnConservateurs);
            this.groupBox2.Controls.Add(this.btnArtistes);
            this.groupBox2.Location = new System.Drawing.Point(18, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 51);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Afficher";
            // 
            // btnListeOeuvres
            // 
            this.btnListeOeuvres.Location = new System.Drawing.Point(261, 20);
            this.btnListeOeuvres.Name = "btnListeOeuvres";
            this.btnListeOeuvres.Size = new System.Drawing.Size(100, 25);
            this.btnListeOeuvres.TabIndex = 2;
            this.btnListeOeuvres.Tag = "";
            this.btnListeOeuvres.Text = "Liste Oeuvres";
            this.btnListeOeuvres.UseVisualStyleBackColor = true;
            this.btnListeOeuvres.Click += new System.EventHandler(this.btnListeOeuvres_Click);
            // 
            // btnConservateurs
            // 
            this.btnConservateurs.Location = new System.Drawing.Point(139, 20);
            this.btnConservateurs.Name = "btnConservateurs";
            this.btnConservateurs.Size = new System.Drawing.Size(100, 25);
            this.btnConservateurs.TabIndex = 1;
            this.btnConservateurs.Text = "Conservateurs";
            this.btnConservateurs.UseVisualStyleBackColor = true;
            this.btnConservateurs.Click += new System.EventHandler(this.btnConservateurs_Click);
            // 
            // btnArtistes
            // 
            this.btnArtistes.Location = new System.Drawing.Point(17, 20);
            this.btnArtistes.Name = "btnArtistes";
            this.btnArtistes.Size = new System.Drawing.Size(100, 25);
            this.btnArtistes.TabIndex = 0;
            this.btnArtistes.Text = "Artistes";
            this.btnArtistes.UseVisualStyleBackColor = true;
            this.btnArtistes.Click += new System.EventHandler(this.btnArtistes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioExp);
            this.groupBox1.Controls.Add(this.rdbExposee);
            this.groupBox1.Location = new System.Drawing.Point(252, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 84);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etat";
            // 
            // radioExp
            // 
            this.radioExp.AutoSize = true;
            this.radioExp.Location = new System.Drawing.Point(21, 51);
            this.radioExp.Name = "radioExp";
            this.radioExp.Size = new System.Drawing.Size(92, 21);
            this.radioExp.TabIndex = 1;
            this.radioExp.Text = "Entreposée";
            this.radioExp.UseVisualStyleBackColor = true;
            // 
            // rdbExposee
            // 
            this.rdbExposee.AutoSize = true;
            this.rdbExposee.Checked = true;
            this.rdbExposee.Location = new System.Drawing.Point(21, 24);
            this.rdbExposee.Name = "rdbExposee";
            this.rdbExposee.Size = new System.Drawing.Size(76, 21);
            this.rdbExposee.TabIndex = 0;
            this.rdbExposee.TabStop = true;
            this.rdbExposee.Text = "Exposée";
            this.rdbExposee.UseVisualStyleBackColor = true;
            // 
            // txtIDConservateur
            // 
            this.txtIDConservateur.Location = new System.Drawing.Point(131, 183);
            this.txtIDConservateur.Name = "txtIDConservateur";
            this.txtIDConservateur.Size = new System.Drawing.Size(111, 25);
            this.txtIDConservateur.TabIndex = 29;
            // 
            // txtIDArtiste
            // 
            this.txtIDArtiste.Location = new System.Drawing.Point(131, 152);
            this.txtIDArtiste.Name = "txtIDArtiste";
            this.txtIDArtiste.Size = new System.Drawing.Size(111, 25);
            this.txtIDArtiste.TabIndex = 28;
            // 
            // txtValeurEstimee
            // 
            this.txtValeurEstimee.Location = new System.Drawing.Point(131, 121);
            this.txtValeurEstimee.Name = "txtValeurEstimee";
            this.txtValeurEstimee.Size = new System.Drawing.Size(111, 25);
            this.txtValeurEstimee.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "&ID Conservateur :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "&ID Artiste :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "&Valeur estimée :";
            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(131, 90);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(111, 25);
            this.txtAnnee.TabIndex = 23;
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(131, 59);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(111, 25);
            this.txtTitre.TabIndex = 22;
            // 
            // txtIDO
            // 
            this.txtIDO.Location = new System.Drawing.Point(131, 28);
            this.txtIDO.Name = "txtIDO";
            this.txtIDO.Size = new System.Drawing.Size(111, 25);
            this.txtIDO.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "&Année :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "&Titre :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "&ID :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(15, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Information des oruvres d\'art";
            // 
            // txtFermer
            // 
            this.txtFermer.Location = new System.Drawing.Point(418, 308);
            this.txtFermer.Name = "txtFermer";
            this.txtFermer.Size = new System.Drawing.Size(100, 26);
            this.txtFermer.TabIndex = 2;
            this.txtFermer.Text = "Fermer";
            this.txtFermer.UseVisualStyleBackColor = true;
            this.txtFermer.Click += new System.EventHandler(this.txtFermer_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(16, 340);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(502, 145);
            this.txtDisplay.TabIndex = 3;
            // 
            // SGIArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 497);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtFermer);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "SGIArt";
            this.Text = "SGIArt";
            this.tabControl1.ResumeLayout(false);
            this.tbConservateurs.ResumeLayout(false);
            this.tbConservateurs.PerformLayout();
            this.tbArtistes.ResumeLayout(false);
            this.tbArtistes.PerformLayout();
            this.tbOeuvres.ResumeLayout(false);
            this.tbOeuvres.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbConservateurs;
        private System.Windows.Forms.TabPage tbArtistes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbOeuvres;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAfficherListeConservateur;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button txtFermer;
        private System.Windows.Forms.Button btnAfficheList;
        private System.Windows.Forms.Button btnSauvegarde;
        private System.Windows.Forms.Button btnAjoute;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNomArtiste;
        private System.Windows.Forms.TextBox txtPrenomArtiste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtIDO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioExp;
        private System.Windows.Forms.RadioButton rdbExposee;
        private System.Windows.Forms.TextBox txtIDConservateur;
        private System.Windows.Forms.TextBox txtIDArtiste;
        private System.Windows.Forms.TextBox txtValeurEstimee;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnVendre;
        private System.Windows.Forms.Button btnAjouter1;
        private System.Windows.Forms.Button btnListeOeuvres;
        private System.Windows.Forms.Button btnConservateurs;
        private System.Windows.Forms.Button btnArtistes;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

