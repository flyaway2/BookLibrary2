namespace Bibliothècaire
{
    partial class BiblioEspace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ouvrages = new System.Windows.Forms.TabControl();
            this.emprunt = new System.Windows.Forms.TabPage();
            this.confirmer1 = new System.Windows.Forms.Button();
            this.emprunter = new System.Windows.Forms.Button();
            this.rechargerT = new System.Windows.Forms.Button();
            this.dataGridViewEmprunts = new System.Windows.Forms.DataGridView();
            this.IDEmpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeBarre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emprenteur = new System.Windows.Forms.TabPage();
            this.suppEns = new System.Windows.Forms.Button();
            this.dataGridViewEnseignant = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajouter = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.suppEtud = new System.Windows.Forms.Button();
            this.dataGridViewEmprunteurs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNConfirme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pseudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ouvrage = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.AjouterO = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.typeOvrgO = new System.Windows.Forms.ComboBox();
            this.titreO = new System.Windows.Forms.TextBox();
            this.themeO = new System.Windows.Forms.TextBox();
            this.imgO = new System.Windows.Forms.TextBox();
            this.auteurO = new System.Windows.Forms.TextBox();
            this.codebarreO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.annulerRecherche = new System.Windows.Forms.Button();
            this.chercher = new System.Windows.Forms.Button();
            this.radioAuteur = new System.Windows.Forms.RadioButton();
            this.radioTheme = new System.Windows.Forms.RadioButton();
            this.radioTitre = new System.Windows.Forms.RadioButton();
            this.typeOvrg = new System.Windows.Forms.ComboBox();
            this.textChercher = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeovr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deconnexion = new System.Windows.Forms.Button();
            this.rendre = new System.Windows.Forms.Button();
            this.Ouvrages.SuspendLayout();
            this.emprunt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprunts)).BeginInit();
            this.emprenteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnseignant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprunteurs)).BeginInit();
            this.ouvrage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ouvrages
            // 
            this.Ouvrages.Controls.Add(this.emprunt);
            this.Ouvrages.Controls.Add(this.emprenteur);
            this.Ouvrages.Controls.Add(this.ouvrage);
            this.Ouvrages.Location = new System.Drawing.Point(3, 39);
            this.Ouvrages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ouvrages.Name = "Ouvrages";
            this.Ouvrages.SelectedIndex = 0;
            this.Ouvrages.Size = new System.Drawing.Size(725, 514);
            this.Ouvrages.TabIndex = 0;
            this.Ouvrages.SelectedIndexChanged += new System.EventHandler(this.Ouvrages_SelectedIndexChanged);
            // 
            // emprunt
            // 
            this.emprunt.Controls.Add(this.rendre);
            this.emprunt.Controls.Add(this.confirmer1);
            this.emprunt.Controls.Add(this.emprunter);
            this.emprunt.Controls.Add(this.rechargerT);
            this.emprunt.Controls.Add(this.dataGridViewEmprunts);
            this.emprunt.Location = new System.Drawing.Point(4, 25);
            this.emprunt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emprunt.Name = "emprunt";
            this.emprunt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emprunt.Size = new System.Drawing.Size(717, 485);
            this.emprunt.TabIndex = 0;
            this.emprunt.Text = "Emprunts";
            this.emprunt.UseVisualStyleBackColor = true;
            // 
            // confirmer1
            // 
            this.confirmer1.Location = new System.Drawing.Point(0, 435);
            this.confirmer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmer1.Name = "confirmer1";
            this.confirmer1.Size = new System.Drawing.Size(182, 50);
            this.confirmer1.TabIndex = 5;
            this.confirmer1.Text = "Confirmer";
            this.confirmer1.UseVisualStyleBackColor = true;
            this.confirmer1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // emprunter
            // 
            this.emprunter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.emprunter.Location = new System.Drawing.Point(534, 435);
            this.emprunter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emprunter.Name = "emprunter";
            this.emprunter.Size = new System.Drawing.Size(182, 50);
            this.emprunter.TabIndex = 4;
            this.emprunter.Text = "Emprunter";
            this.emprunter.UseVisualStyleBackColor = true;
            this.emprunter.Click += new System.EventHandler(this.button1_Click);
            // 
            // rechargerT
            // 
            this.rechargerT.Location = new System.Drawing.Point(179, 435);
            this.rechargerT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rechargerT.Name = "rechargerT";
            this.rechargerT.Size = new System.Drawing.Size(181, 50);
            this.rechargerT.TabIndex = 3;
            this.rechargerT.Text = "Recharger";
            this.rechargerT.UseVisualStyleBackColor = true;
            this.rechargerT.Click += new System.EventHandler(this.emprunter_Click);
            // 
            // dataGridViewEmprunts
            // 
            this.dataGridViewEmprunts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmprunts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEmpr,
            this.codeBarre,
            this.dateEmp,
            this.dateFinEmp,
            this.confirmer});
            this.dataGridViewEmprunts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmprunts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEmprunts.Name = "dataGridViewEmprunts";
            this.dataGridViewEmprunts.RowTemplate.Height = 24;
            this.dataGridViewEmprunts.Size = new System.Drawing.Size(728, 436);
            this.dataGridViewEmprunts.TabIndex = 1;
            this.dataGridViewEmprunts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // IDEmpr
            // 
            this.IDEmpr.DataPropertyName = "IDEmpr1";
            this.IDEmpr.HeaderText = "IDEmpr";
            this.IDEmpr.Name = "IDEmpr";
            // 
            // codeBarre
            // 
            this.codeBarre.DataPropertyName = "codeBarre";
            this.codeBarre.HeaderText = "codeBarre";
            this.codeBarre.Name = "codeBarre";
            // 
            // dateEmp
            // 
            this.dateEmp.DataPropertyName = "dateEmp";
            this.dateEmp.HeaderText = "dateEmp";
            this.dateEmp.Name = "dateEmp";
            // 
            // dateFinEmp
            // 
            this.dateFinEmp.DataPropertyName = "dateFinEmp";
            this.dateFinEmp.HeaderText = "dateFinEmp";
            this.dateFinEmp.Name = "dateFinEmp";
            // 
            // confirmer
            // 
            this.confirmer.DataPropertyName = "confirmer";
            this.confirmer.HeaderText = "confirmer";
            this.confirmer.Name = "confirmer";
            // 
            // emprenteur
            // 
            this.emprenteur.Controls.Add(this.suppEns);
            this.emprenteur.Controls.Add(this.dataGridViewEnseignant);
            this.emprenteur.Controls.Add(this.ajouter);
            this.emprenteur.Controls.Add(this.button3);
            this.emprenteur.Controls.Add(this.suppEtud);
            this.emprenteur.Controls.Add(this.dataGridViewEmprunteurs);
            this.emprenteur.Location = new System.Drawing.Point(4, 25);
            this.emprenteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emprenteur.Name = "emprenteur";
            this.emprenteur.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emprenteur.Size = new System.Drawing.Size(717, 485);
            this.emprenteur.TabIndex = 1;
            this.emprenteur.Text = "Emprenteurs";
            this.emprenteur.UseVisualStyleBackColor = true;
            // 
            // suppEns
            // 
            this.suppEns.Location = new System.Drawing.Point(332, 443);
            this.suppEns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suppEns.Name = "suppEns";
            this.suppEns.Size = new System.Drawing.Size(196, 43);
            this.suppEns.TabIndex = 9;
            this.suppEns.Text = "Supp Enseignant";
            this.suppEns.UseVisualStyleBackColor = true;
            this.suppEns.Click += new System.EventHandler(this.suppEns_Click);
            // 
            // dataGridViewEnseignant
            // 
            this.dataGridViewEnseignant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnseignant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataGridViewEnseignant.Location = new System.Drawing.Point(1, 233);
            this.dataGridViewEnseignant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEnseignant.Name = "dataGridViewEnseignant";
            this.dataGridViewEnseignant.RowTemplate.Height = 24;
            this.dataGridViewEnseignant.Size = new System.Drawing.Size(720, 209);
            this.dataGridViewEnseignant.TabIndex = 8;
            this.dataGridViewEnseignant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnseignant_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID1";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 61;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 61;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 61;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "empNConfirme";
            this.dataGridViewTextBoxColumn4.HeaderText = "EmprNConfirmer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 61;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 61;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TypeEmp";
            this.dataGridViewTextBoxColumn6.HeaderText = "TypeEmpr";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 62;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "specialite";
            this.dataGridViewTextBoxColumn7.HeaderText = "Specialite";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 61;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "niveau";
            this.dataGridViewTextBoxColumn8.HeaderText = "niveau";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 61;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "grade";
            this.dataGridViewTextBoxColumn9.HeaderText = "grade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 61;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn10.HeaderText = "password";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 61;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "pseudo";
            this.dataGridViewTextBoxColumn11.HeaderText = "pseudo";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 61;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(0, 439);
            this.ajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(161, 47);
            this.ajouter.TabIndex = 7;
            this.ajouter.Text = "Ajouter Compte";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 439);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "Recharger";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // suppEtud
            // 
            this.suppEtud.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.suppEtud.Location = new System.Drawing.Point(519, 439);
            this.suppEtud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suppEtud.Name = "suppEtud";
            this.suppEtud.Size = new System.Drawing.Size(197, 47);
            this.suppEtud.TabIndex = 5;
            this.suppEtud.Text = "Supp Etudiant";
            this.suppEtud.UseVisualStyleBackColor = true;
            this.suppEtud.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewEmprunteurs
            // 
            this.dataGridViewEmprunteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmprunteurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nom,
            this.prenom,
            this.empNConfirme,
            this.email,
            this.TypeEmp,
            this.specialite,
            this.niveau,
            this.grade,
            this.password,
            this.pseudo});
            this.dataGridViewEmprunteurs.Location = new System.Drawing.Point(1, 2);
            this.dataGridViewEmprunteurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEmprunteurs.Name = "dataGridViewEmprunteurs";
            this.dataGridViewEmprunteurs.RowTemplate.Height = 24;
            this.dataGridViewEmprunteurs.Size = new System.Drawing.Size(715, 233);
            this.dataGridViewEmprunteurs.TabIndex = 0;
            this.dataGridViewEmprunteurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmprunteurs_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID1";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 61;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.Width = 61;
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "prenom";
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            this.prenom.Width = 61;
            // 
            // empNConfirme
            // 
            this.empNConfirme.DataPropertyName = "empNConfirme";
            this.empNConfirme.HeaderText = "EmprNConfirmer";
            this.empNConfirme.Name = "empNConfirme";
            this.empNConfirme.Width = 61;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.Width = 61;
            // 
            // TypeEmp
            // 
            this.TypeEmp.DataPropertyName = "TypeEmp";
            this.TypeEmp.HeaderText = "TypeEmpr";
            this.TypeEmp.Name = "TypeEmp";
            this.TypeEmp.Width = 62;
            // 
            // specialite
            // 
            this.specialite.DataPropertyName = "specialite";
            this.specialite.HeaderText = "Specialite";
            this.specialite.Name = "specialite";
            this.specialite.Width = 61;
            // 
            // niveau
            // 
            this.niveau.DataPropertyName = "niveau";
            this.niveau.HeaderText = "niveau";
            this.niveau.Name = "niveau";
            this.niveau.Width = 61;
            // 
            // grade
            // 
            this.grade.DataPropertyName = "grade";
            this.grade.HeaderText = "grade";
            this.grade.Name = "grade";
            this.grade.Width = 61;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.Width = 61;
            // 
            // pseudo
            // 
            this.pseudo.DataPropertyName = "pseudo";
            this.pseudo.HeaderText = "pseudo";
            this.pseudo.Name = "pseudo";
            this.pseudo.Width = 61;
            // 
            // ouvrage
            // 
            this.ouvrage.Controls.Add(this.button5);
            this.ouvrage.Controls.Add(this.AjouterO);
            this.ouvrage.Controls.Add(this.button2);
            this.ouvrage.Controls.Add(this.modifier);
            this.ouvrage.Controls.Add(this.panel1);
            this.ouvrage.Controls.Add(this.annulerRecherche);
            this.ouvrage.Controls.Add(this.chercher);
            this.ouvrage.Controls.Add(this.radioAuteur);
            this.ouvrage.Controls.Add(this.radioTheme);
            this.ouvrage.Controls.Add(this.radioTitre);
            this.ouvrage.Controls.Add(this.typeOvrg);
            this.ouvrage.Controls.Add(this.textChercher);
            this.ouvrage.Controls.Add(this.dataGridView1);
            this.ouvrage.Cursor = System.Windows.Forms.Cursors.Default;
            this.ouvrage.Location = new System.Drawing.Point(4, 25);
            this.ouvrage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ouvrage.Name = "ouvrage";
            this.ouvrage.Size = new System.Drawing.Size(717, 485);
            this.ouvrage.TabIndex = 2;
            this.ouvrage.Text = "Ouvrages";
            this.ouvrage.UseVisualStyleBackColor = true;
            this.ouvrage.Click += new System.EventHandler(this.reservation_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(376, 447);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 38);
            this.button5.TabIndex = 21;
            this.button5.Text = "Recharger";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AjouterO
            // 
            this.AjouterO.Location = new System.Drawing.Point(190, 447);
            this.AjouterO.Name = "AjouterO";
            this.AjouterO.Size = new System.Drawing.Size(187, 38);
            this.AjouterO.TabIndex = 20;
            this.AjouterO.Text = "Ajouter";
            this.AjouterO.UseVisualStyleBackColor = true;
            this.AjouterO.Click += new System.EventHandler(this.AjouterO_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(0, 447);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(192, 38);
            this.modifier.TabIndex = 13;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.typeOvrgO);
            this.panel1.Controls.Add(this.titreO);
            this.panel1.Controls.Add(this.themeO);
            this.panel1.Controls.Add(this.imgO);
            this.panel1.Controls.Add(this.auteurO);
            this.panel1.Controls.Add(this.codebarreO);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 447);
            this.panel1.TabIndex = 18;
            // 
            // typeOvrgO
            // 
            this.typeOvrgO.FormattingEnabled = true;
            this.typeOvrgO.Items.AddRange(new object[] {
            "livre",
            "mémoire",
            "thèse"});
            this.typeOvrgO.Location = new System.Drawing.Point(5, 221);
            this.typeOvrgO.Name = "typeOvrgO";
            this.typeOvrgO.Size = new System.Drawing.Size(176, 24);
            this.typeOvrgO.TabIndex = 38;
            // 
            // titreO
            // 
            this.titreO.Location = new System.Drawing.Point(5, 161);
            this.titreO.Name = "titreO";
            this.titreO.Size = new System.Drawing.Size(176, 22);
            this.titreO.TabIndex = 12;
            // 
            // themeO
            // 
            this.themeO.Location = new System.Drawing.Point(5, 395);
            this.themeO.Name = "themeO";
            this.themeO.Size = new System.Drawing.Size(176, 22);
            this.themeO.TabIndex = 11;
            // 
            // imgO
            // 
            this.imgO.Location = new System.Drawing.Point(5, 337);
            this.imgO.Name = "imgO";
            this.imgO.Size = new System.Drawing.Size(176, 22);
            this.imgO.TabIndex = 10;
            // 
            // auteurO
            // 
            this.auteurO.Location = new System.Drawing.Point(5, 275);
            this.auteurO.Name = "auteurO";
            this.auteurO.Size = new System.Drawing.Size(176, 22);
            this.auteurO.TabIndex = 9;
            // 
            // codebarreO
            // 
            this.codebarreO.Location = new System.Drawing.Point(5, 100);
            this.codebarreO.Name = "codebarreO";
            this.codebarreO.Size = new System.Drawing.Size(176, 22);
            this.codebarreO.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Titre";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Le chemin de l\'image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Auteur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type d\'ouvrage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Théme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "code Barre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier l\'ouvrage";
            // 
            // annulerRecherche
            // 
            this.annulerRecherche.Location = new System.Drawing.Point(513, 4);
            this.annulerRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.annulerRecherche.Name = "annulerRecherche";
            this.annulerRecherche.Size = new System.Drawing.Size(85, 28);
            this.annulerRecherche.TabIndex = 17;
            this.annulerRecherche.Text = "annuler";
            this.annulerRecherche.UseVisualStyleBackColor = true;
            this.annulerRecherche.Click += new System.EventHandler(this.annulerRecherche_Click);
            // 
            // chercher
            // 
            this.chercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chercher.Location = new System.Drawing.Point(629, 4);
            this.chercher.Margin = new System.Windows.Forms.Padding(4);
            this.chercher.Name = "chercher";
            this.chercher.Size = new System.Drawing.Size(84, 28);
            this.chercher.TabIndex = 16;
            this.chercher.Text = "chercher";
            this.chercher.UseVisualStyleBackColor = true;
            this.chercher.Click += new System.EventHandler(this.chercher_Click);
            // 
            // radioAuteur
            // 
            this.radioAuteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAuteur.AutoSize = true;
            this.radioAuteur.Location = new System.Drawing.Point(450, 68);
            this.radioAuteur.Margin = new System.Windows.Forms.Padding(4);
            this.radioAuteur.Name = "radioAuteur";
            this.radioAuteur.Size = new System.Drawing.Size(70, 21);
            this.radioAuteur.TabIndex = 15;
            this.radioAuteur.TabStop = true;
            this.radioAuteur.Text = "auteur";
            this.radioAuteur.UseVisualStyleBackColor = true;
            this.radioAuteur.CheckedChanged += new System.EventHandler(this.radioAuteur_CheckedChanged);
            // 
            // radioTheme
            // 
            this.radioTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioTheme.AutoSize = true;
            this.radioTheme.Location = new System.Drawing.Point(321, 68);
            this.radioTheme.Margin = new System.Windows.Forms.Padding(4);
            this.radioTheme.Name = "radioTheme";
            this.radioTheme.Size = new System.Drawing.Size(68, 21);
            this.radioTheme.TabIndex = 14;
            this.radioTheme.TabStop = true;
            this.radioTheme.Text = "thème";
            this.radioTheme.UseVisualStyleBackColor = true;
            // 
            // radioTitre
            // 
            this.radioTitre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioTitre.AutoSize = true;
            this.radioTitre.Checked = true;
            this.radioTitre.Location = new System.Drawing.Point(191, 68);
            this.radioTitre.Margin = new System.Windows.Forms.Padding(4);
            this.radioTitre.Name = "radioTitre";
            this.radioTitre.Size = new System.Drawing.Size(53, 21);
            this.radioTitre.TabIndex = 13;
            this.radioTitre.TabStop = true;
            this.radioTitre.Text = "titre";
            this.radioTitre.UseVisualStyleBackColor = true;
            this.radioTitre.CheckedChanged += new System.EventHandler(this.radioTitre_CheckedChanged);
            // 
            // typeOvrg
            // 
            this.typeOvrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeOvrg.FormattingEnabled = true;
            this.typeOvrg.Items.AddRange(new object[] {
            "tous",
            "livre",
            "mémoire",
            "thèse"});
            this.typeOvrg.Location = new System.Drawing.Point(628, 67);
            this.typeOvrg.Margin = new System.Windows.Forms.Padding(4);
            this.typeOvrg.Name = "typeOvrg";
            this.typeOvrg.Size = new System.Drawing.Size(85, 24);
            this.typeOvrg.TabIndex = 12;
            this.typeOvrg.Text = "tous";
            this.typeOvrg.SelectedIndexChanged += new System.EventHandler(this.typeOvrg_SelectedIndexChanged);
            // 
            // textChercher
            // 
            this.textChercher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textChercher.Location = new System.Drawing.Point(191, 10);
            this.textChercher.Margin = new System.Windows.Forms.Padding(4);
            this.textChercher.Name = "textChercher";
            this.textChercher.Size = new System.Drawing.Size(274, 22);
            this.textChercher.TabIndex = 11;
            this.textChercher.TextChanged += new System.EventHandler(this.textChercher_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.titre,
            this.typeovr,
            this.auteur,
            this.img,
            this.theme});
            this.dataGridView1.Location = new System.Drawing.Point(191, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 347);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "codeBarre";
            this.dataGridViewTextBoxColumn12.HeaderText = "codeBarre";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // titre
            // 
            this.titre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titre.DataPropertyName = "titre";
            this.titre.HeaderText = "titre";
            this.titre.Name = "titre";
            // 
            // typeovr
            // 
            this.typeovr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeovr.DataPropertyName = "typeOvrg";
            this.typeovr.HeaderText = "typeOvrg";
            this.typeovr.Name = "typeovr";
            // 
            // auteur
            // 
            this.auteur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.auteur.DataPropertyName = "auteur";
            this.auteur.HeaderText = "auteur";
            this.auteur.Name = "auteur";
            // 
            // img
            // 
            this.img.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.img.DataPropertyName = "img";
            this.img.HeaderText = "img";
            this.img.Name = "img";
            // 
            // theme
            // 
            this.theme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.theme.DataPropertyName = "theme";
            this.theme.HeaderText = "theme";
            this.theme.Name = "theme";
            // 
            // deconnexion
            // 
            this.deconnexion.Location = new System.Drawing.Point(576, 12);
            this.deconnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deconnexion.Name = "deconnexion";
            this.deconnexion.Size = new System.Drawing.Size(147, 46);
            this.deconnexion.TabIndex = 1;
            this.deconnexion.Text = "deconnexion";
            this.deconnexion.UseVisualStyleBackColor = true;
            this.deconnexion.Click += new System.EventHandler(this.deconnexion_Click);
            // 
            // rendre
            // 
            this.rendre.Location = new System.Drawing.Point(359, 435);
            this.rendre.Name = "rendre";
            this.rendre.Size = new System.Drawing.Size(182, 50);
            this.rendre.TabIndex = 6;
            this.rendre.Text = "Rendre";
            this.rendre.UseVisualStyleBackColor = true;
            this.rendre.Click += new System.EventHandler(this.rendre_Click_1);
            // 
            // BiblioEspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(725, 551);
            this.Controls.Add(this.deconnexion);
            this.Controls.Add(this.Ouvrages);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BiblioEspace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiblioEspace";
            this.Ouvrages.ResumeLayout(false);
            this.emprunt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprunts)).EndInit();
            this.emprenteur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnseignant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprunteurs)).EndInit();
            this.ouvrage.ResumeLayout(false);
            this.ouvrage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Ouvrages;
        private System.Windows.Forms.TabPage emprunt;
        private System.Windows.Forms.TabPage emprenteur;
        private System.Windows.Forms.TabPage ouvrage;
        private System.Windows.Forms.DataGridView dataGridViewEmprunts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmer;
        private System.Windows.Forms.Button rechargerT;
        private System.Windows.Forms.DataGridView dataGridViewEmprunteurs;
        private System.Windows.Forms.Button emprunter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button suppEtud;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button deconnexion;
        private System.Windows.Forms.Button confirmer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNConfirme;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialite;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudo;
        private System.Windows.Forms.DataGridView dataGridViewEnseignant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button suppEns;
        private System.Windows.Forms.Button annulerRecherche;
        private System.Windows.Forms.Button chercher;
        private System.Windows.Forms.RadioButton radioAuteur;
        private System.Windows.Forms.RadioButton radioTheme;
        private System.Windows.Forms.RadioButton radioTitre;
        private System.Windows.Forms.ComboBox typeOvrg;
        private System.Windows.Forms.TextBox textChercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeovr;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn theme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button AjouterO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.TextBox titreO;
        private System.Windows.Forms.TextBox themeO;
        private System.Windows.Forms.TextBox imgO;
        private System.Windows.Forms.TextBox auteurO;
        private System.Windows.Forms.TextBox codebarreO;
        private System.Windows.Forms.ComboBox typeOvrgO;
        private System.Windows.Forms.Button rendre;
    }
}