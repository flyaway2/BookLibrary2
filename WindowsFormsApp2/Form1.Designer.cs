namespace WindowsFormsApp2
{
    partial class Form1
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.profile = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.empNconfirme = new System.Windows.Forms.Label();
            this.listAtt = new System.Windows.Forms.Label();
            this.attConf = new System.Windows.Forms.Label();
            this.Nemp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modifierCompte = new System.Windows.Forms.Button();
            this.gradelabel = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.niv = new System.Windows.Forms.Label();
            this.passwordEnable = new System.Windows.Forms.CheckBox();
            this.nivlabel = new System.Windows.Forms.Label();
            this.spec = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.speclabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.pseudo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ouvrage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.image = new System.Windows.Forms.PictureBox();
            this.reserver = new System.Windows.Forms.Button();
            this.annulerRecherche = new System.Windows.Forms.Button();
            this.chercher = new System.Windows.Forms.Button();
            this.radioAuteur = new System.Windows.Forms.RadioButton();
            this.radioTheme = new System.Windows.Forms.RadioButton();
            this.radioTitre = new System.Windows.Forms.RadioButton();
            this.typeOvrg = new System.Windows.Forms.ComboBox();
            this.textChercher = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emprunt = new System.Windows.Forms.TabPage();
            this.empruntlist = new System.Windows.Forms.DataGridView();
            this.Tablisteattente = new System.Windows.Forms.TabPage();
            this.listeattente = new System.Windows.Forms.DataGridView();
            this.déconnexion = new System.Windows.Forms.Button();
            this.codeB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEmpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeBarre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeovr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabs.SuspendLayout();
            this.profile.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ouvrage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.emprunt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empruntlist)).BeginInit();
            this.Tablisteattente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeattente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.profile);
            this.tabs.Controls.Add(this.ouvrage);
            this.tabs.Controls.Add(this.emprunt);
            this.tabs.Controls.Add(this.Tablisteattente);
            this.tabs.Location = new System.Drawing.Point(3, 6);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(701, 440);
            this.tabs.TabIndex = 0;
            this.tabs.Click += new System.EventHandler(this.toustab);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.Lavender;
            this.profile.Controls.Add(this.déconnexion);
            this.profile.Controls.Add(this.groupBox2);
            this.profile.Controls.Add(this.groupBox1);
            this.profile.Location = new System.Drawing.Point(4, 22);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(3);
            this.profile.Size = new System.Drawing.Size(693, 414);
            this.profile.TabIndex = 0;
            this.profile.Text = "profile";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.empNconfirme);
            this.groupBox2.Controls.Add(this.listAtt);
            this.groupBox2.Controls.Add(this.attConf);
            this.groupBox2.Controls.Add(this.Nemp);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(362, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 275);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "emprunt";
            // 
            // empNconfirme
            // 
            this.empNconfirme.AutoSize = true;
            this.empNconfirme.Location = new System.Drawing.Point(176, 218);
            this.empNconfirme.Name = "empNconfirme";
            this.empNconfirme.Size = new System.Drawing.Size(16, 17);
            this.empNconfirme.TabIndex = 7;
            this.empNconfirme.Text = "0";
            // 
            // listAtt
            // 
            this.listAtt.AutoSize = true;
            this.listAtt.Location = new System.Drawing.Point(145, 166);
            this.listAtt.Name = "listAtt";
            this.listAtt.Size = new System.Drawing.Size(16, 17);
            this.listAtt.TabIndex = 6;
            this.listAtt.Text = "2";
            // 
            // attConf
            // 
            this.attConf.AutoSize = true;
            this.attConf.Location = new System.Drawing.Point(189, 100);
            this.attConf.Name = "attConf";
            this.attConf.Size = new System.Drawing.Size(16, 17);
            this.attConf.TabIndex = 5;
            this.attConf.Text = "1";
            // 
            // Nemp
            // 
            this.Nemp.AutoSize = true;
            this.Nemp.Location = new System.Drawing.Point(211, 53);
            this.Nemp.Name = "Nemp";
            this.Nemp.Size = new System.Drawing.Size(16, 17);
            this.Nemp.TabIndex = 4;
            this.Nemp.Text = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "attendre la confirmation :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "emprunt non confirmé :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "en liste d\'attente :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "nombre d\'ouvrages emprunter :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modifierCompte);
            this.groupBox1.Controls.Add(this.gradelabel);
            this.groupBox1.Controls.Add(this.grade);
            this.groupBox1.Controls.Add(this.niv);
            this.groupBox1.Controls.Add(this.passwordEnable);
            this.groupBox1.Controls.Add(this.nivlabel);
            this.groupBox1.Controls.Add(this.spec);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.Nom);
            this.groupBox1.Controls.Add(this.speclabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.prenom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.pseudo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 359);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "informations personnelles";
            // 
            // modifierCompte
            // 
            this.modifierCompte.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierCompte.Location = new System.Drawing.Point(165, 321);
            this.modifierCompte.Name = "modifierCompte";
            this.modifierCompte.Size = new System.Drawing.Size(100, 31);
            this.modifierCompte.TabIndex = 5;
            this.modifierCompte.Text = "modifier";
            this.modifierCompte.UseVisualStyleBackColor = true;
            this.modifierCompte.Click += new System.EventHandler(this.modifierCompte_Click);
            // 
            // gradelabel
            // 
            this.gradelabel.AutoSize = true;
            this.gradelabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradelabel.Location = new System.Drawing.Point(19, 271);
            this.gradelabel.Name = "gradelabel";
            this.gradelabel.Size = new System.Drawing.Size(55, 17);
            this.gradelabel.TabIndex = 12;
            this.gradelabel.Text = "grade :";
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade.Location = new System.Drawing.Point(90, 271);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(79, 17);
            this.grade.TabIndex = 21;
            this.grade.Text = "professeur";
            // 
            // niv
            // 
            this.niv.AutoSize = true;
            this.niv.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niv.Location = new System.Drawing.Point(94, 299);
            this.niv.Name = "niv";
            this.niv.Size = new System.Drawing.Size(30, 17);
            this.niv.TabIndex = 20;
            this.niv.Text = "M1";
            // 
            // passwordEnable
            // 
            this.passwordEnable.AutoSize = true;
            this.passwordEnable.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordEnable.Location = new System.Drawing.Point(251, 224);
            this.passwordEnable.Name = "passwordEnable";
            this.passwordEnable.Size = new System.Drawing.Size(15, 14);
            this.passwordEnable.TabIndex = 24;
            this.passwordEnable.UseVisualStyleBackColor = true;
            this.passwordEnable.CheckedChanged += new System.EventHandler(this.passwordEnable_CheckedChanged);
            // 
            // nivlabel
            // 
            this.nivlabel.AutoSize = true;
            this.nivlabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivlabel.Location = new System.Drawing.Point(23, 299);
            this.nivlabel.Name = "nivlabel";
            this.nivlabel.Size = new System.Drawing.Size(65, 17);
            this.nivlabel.TabIndex = 10;
            this.nivlabel.Text = "Niveau :";
            // 
            // spec
            // 
            this.spec.AutoSize = true;
            this.spec.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spec.Location = new System.Drawing.Point(109, 254);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(30, 17);
            this.spec.TabIndex = 19;
            this.spec.Text = "GL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.user4;
            this.pictureBox1.Location = new System.Drawing.Point(75, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Lavender;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(93, 224);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(149, 17);
            this.password.TabIndex = 23;
            this.password.UseSystemPasswordChar = true;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(90, 98);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(72, 17);
            this.Nom.TabIndex = 14;
            this.Nom.Text = "habbaina";
            // 
            // speclabel
            // 
            this.speclabel.AutoSize = true;
            this.speclabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speclabel.Location = new System.Drawing.Point(19, 254);
            this.speclabel.Name = "speclabel";
            this.speclabel.Size = new System.Drawing.Size(84, 17);
            this.speclabel.TabIndex = 11;
            this.speclabel.Text = "spécialité :";
            this.speclabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prénom :";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(90, 124);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(50, 17);
            this.prenom.TabIndex = 15;
            this.prenom.Text = "amine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pseudo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(90, 188);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(168, 17);
            this.email.TabIndex = 17;
            this.email.Text = "h.amine.dz@hotmail.fr";
            // 
            // pseudo
            // 
            this.pseudo.AutoSize = true;
            this.pseudo.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudo.Location = new System.Drawing.Point(90, 157);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(50, 17);
            this.pseudo.TabIndex = 16;
            this.pseudo.Text = "amine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "email :";
            // 
            // ouvrage
            // 
            this.ouvrage.Controls.Add(this.panel1);
            this.ouvrage.Controls.Add(this.reserver);
            this.ouvrage.Controls.Add(this.annulerRecherche);
            this.ouvrage.Controls.Add(this.chercher);
            this.ouvrage.Controls.Add(this.radioAuteur);
            this.ouvrage.Controls.Add(this.radioTheme);
            this.ouvrage.Controls.Add(this.radioTitre);
            this.ouvrage.Controls.Add(this.typeOvrg);
            this.ouvrage.Controls.Add(this.textChercher);
            this.ouvrage.Controls.Add(this.dataGridView1);
            this.ouvrage.Location = new System.Drawing.Point(4, 22);
            this.ouvrage.Name = "ouvrage";
            this.ouvrage.Padding = new System.Windows.Forms.Padding(3);
            this.ouvrage.Size = new System.Drawing.Size(693, 414);
            this.ouvrage.TabIndex = 1;
            this.ouvrage.Text = "ouvrage";
            this.ouvrage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.image);
            this.panel1.Location = new System.Drawing.Point(504, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 326);
            this.panel1.TabIndex = 8;
            // 
            // image
            // 
            this.image.Image = global::WindowsFormsApp2.Properties.Resources.img2;
            this.image.Location = new System.Drawing.Point(1, 3);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(187, 320);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // reserver
            // 
            this.reserver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reserver.Location = new System.Drawing.Point(602, 49);
            this.reserver.Name = "reserver";
            this.reserver.Size = new System.Drawing.Size(75, 23);
            this.reserver.TabIndex = 1;
            this.reserver.Text = "reserver";
            this.reserver.UseVisualStyleBackColor = true;
            this.reserver.Click += new System.EventHandler(this.button1_Click);
            // 
            // annulerRecherche
            // 
            this.annulerRecherche.Location = new System.Drawing.Point(410, 23);
            this.annulerRecherche.Name = "annulerRecherche";
            this.annulerRecherche.Size = new System.Drawing.Size(75, 23);
            this.annulerRecherche.TabIndex = 7;
            this.annulerRecherche.Text = "annuler";
            this.annulerRecherche.UseVisualStyleBackColor = true;
            this.annulerRecherche.Click += new System.EventHandler(this.annulerRecherche_Click);
            // 
            // chercher
            // 
            this.chercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chercher.Location = new System.Drawing.Point(602, 23);
            this.chercher.Name = "chercher";
            this.chercher.Size = new System.Drawing.Size(75, 23);
            this.chercher.TabIndex = 6;
            this.chercher.Text = "chercher";
            this.chercher.UseVisualStyleBackColor = true;
            this.chercher.Click += new System.EventHandler(this.chercher_Click);
            // 
            // radioAuteur
            // 
            this.radioAuteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAuteur.AutoSize = true;
            this.radioAuteur.Location = new System.Drawing.Point(324, 49);
            this.radioAuteur.Name = "radioAuteur";
            this.radioAuteur.Size = new System.Drawing.Size(55, 17);
            this.radioAuteur.TabIndex = 5;
            this.radioAuteur.TabStop = true;
            this.radioAuteur.Text = "auteur";
            this.radioAuteur.UseVisualStyleBackColor = true;
            // 
            // radioTheme
            // 
            this.radioTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioTheme.AutoSize = true;
            this.radioTheme.Location = new System.Drawing.Point(198, 49);
            this.radioTheme.Name = "radioTheme";
            this.radioTheme.Size = new System.Drawing.Size(54, 17);
            this.radioTheme.TabIndex = 4;
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
            this.radioTitre.Location = new System.Drawing.Point(20, 49);
            this.radioTitre.Name = "radioTitre";
            this.radioTitre.Size = new System.Drawing.Size(42, 17);
            this.radioTitre.TabIndex = 3;
            this.radioTitre.TabStop = true;
            this.radioTitre.Text = "titre";
            this.radioTitre.UseVisualStyleBackColor = true;
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
            this.typeOvrg.Location = new System.Drawing.Point(409, 51);
            this.typeOvrg.Name = "typeOvrg";
            this.typeOvrg.Size = new System.Drawing.Size(76, 21);
            this.typeOvrg.TabIndex = 2;
            this.typeOvrg.Text = "tous";
            this.typeOvrg.SelectedIndexChanged += new System.EventHandler(this.typeOvrg_SelectedIndexChanged);
            // 
            // textChercher
            // 
            this.textChercher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textChercher.Location = new System.Drawing.Point(20, 23);
            this.textChercher.Name = "textChercher";
            this.textChercher.Size = new System.Drawing.Size(359, 20);
            this.textChercher.TabIndex = 1;
            this.textChercher.TextChanged += new System.EventHandler(this.textChercher_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeBarre,
            this.titre,
            this.typeovr,
            this.auteur,
            this.img,
            this.theme});
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // emprunt
            // 
            this.emprunt.Controls.Add(this.empruntlist);
            this.emprunt.Location = new System.Drawing.Point(4, 22);
            this.emprunt.Name = "emprunt";
            this.emprunt.Padding = new System.Windows.Forms.Padding(3);
            this.emprunt.Size = new System.Drawing.Size(693, 414);
            this.emprunt.TabIndex = 2;
            this.emprunt.Text = "emprunt";
            this.emprunt.UseVisualStyleBackColor = true;
            // 
            // empruntlist
            // 
            this.empruntlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empruntlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEmpr,
            this.code,
            this.dateEmp,
            this.dateFinEmp,
            this.confirmer});
            this.empruntlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empruntlist.Location = new System.Drawing.Point(3, 3);
            this.empruntlist.Name = "empruntlist";
            this.empruntlist.Size = new System.Drawing.Size(687, 408);
            this.empruntlist.TabIndex = 0;
            this.empruntlist.Click += new System.EventHandler(this.toustab);
            // 
            // Tablisteattente
            // 
            this.Tablisteattente.Controls.Add(this.listeattente);
            this.Tablisteattente.Location = new System.Drawing.Point(4, 22);
            this.Tablisteattente.Name = "Tablisteattente";
            this.Tablisteattente.Padding = new System.Windows.Forms.Padding(3);
            this.Tablisteattente.Size = new System.Drawing.Size(693, 414);
            this.Tablisteattente.TabIndex = 3;
            this.Tablisteattente.Text = "listattente";
            this.Tablisteattente.UseVisualStyleBackColor = true;
            // 
            // listeattente
            // 
            this.listeattente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeattente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeB,
            this.idEm,
            this.priorite});
            this.listeattente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeattente.Location = new System.Drawing.Point(3, 3);
            this.listeattente.Name = "listeattente";
            this.listeattente.Size = new System.Drawing.Size(687, 408);
            this.listeattente.TabIndex = 0;
            // 
            // déconnexion
            // 
            this.déconnexion.Location = new System.Drawing.Point(550, 17);
            this.déconnexion.Name = "déconnexion";
            this.déconnexion.Size = new System.Drawing.Size(95, 23);
            this.déconnexion.TabIndex = 25;
            this.déconnexion.Text = "Déconnexion";
            this.déconnexion.UseVisualStyleBackColor = true;
            this.déconnexion.Click += new System.EventHandler(this.déconnexion_Click);
            // 
            // codeB
            // 
            this.codeB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeB.DataPropertyName = "codeBarre";
            this.codeB.HeaderText = "codeBarre";
            this.codeB.Name = "codeB";
            // 
            // idEm
            // 
            this.idEm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEm.DataPropertyName = "IDEmpr1";
            this.idEm.HeaderText = "IDEmpr";
            this.idEm.Name = "idEm";
            // 
            // priorite
            // 
            this.priorite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priorite.DataPropertyName = "priorite";
            this.priorite.HeaderText = "priorite";
            this.priorite.Name = "priorite";
            // 
            // IDEmpr
            // 
            this.IDEmpr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDEmpr.DataPropertyName = "IDEmpr1";
            this.IDEmpr.HeaderText = "ID";
            this.IDEmpr.Name = "IDEmpr";
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.code.DataPropertyName = "codeBarre";
            this.code.HeaderText = "code Barre";
            this.code.Name = "code";
            // 
            // dateEmp
            // 
            this.dateEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateEmp.DataPropertyName = "dateEmp";
            this.dateEmp.HeaderText = "date de début";
            this.dateEmp.Name = "dateEmp";
            // 
            // dateFinEmp
            // 
            this.dateFinEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateFinEmp.DataPropertyName = "dateFinEmp";
            this.dateFinEmp.HeaderText = "date de fin";
            this.dateFinEmp.Name = "dateFinEmp";
            // 
            // confirmer
            // 
            this.confirmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.confirmer.DataPropertyName = "confirmer";
            this.confirmer.HeaderText = "confirmer";
            this.confirmer.Name = "confirmer";
            // 
            // codeBarre
            // 
            this.codeBarre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeBarre.DataPropertyName = "codeBarre";
            this.codeBarre.HeaderText = "codeBarre";
            this.codeBarre.Name = "codeBarre";
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
            this.typeovr.HeaderText = "type Ouvrage";
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
            this.img.DataPropertyName = "image";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 458);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "gestion des emprunts de la bibliothèque";
            this.tabs.ResumeLayout(false);
            this.profile.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ouvrage.ResumeLayout(false);
            this.ouvrage.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.emprunt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empruntlist)).EndInit();
            this.Tablisteattente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeattente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage profile;
        private System.Windows.Forms.TabPage ouvrage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button reserver;
        private System.Windows.Forms.Button chercher;
        private System.Windows.Forms.RadioButton radioAuteur;
        private System.Windows.Forms.RadioButton radioTheme;
        private System.Windows.Forms.RadioButton radioTitre;
        private System.Windows.Forms.ComboBox typeOvrg;
        private System.Windows.Forms.TextBox textChercher;
        private System.Windows.Forms.Button annulerRecherche;
        private System.Windows.Forms.TabPage emprunt;
        private System.Windows.Forms.TabPage Tablisteattente;
        private System.Windows.Forms.Label gradelabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button modifierCompte;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label niv;
        private System.Windows.Forms.CheckBox passwordEnable;
        private System.Windows.Forms.Label nivlabel;
        private System.Windows.Forms.Label spec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label speclabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label pseudo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label empNconfirme;
        private System.Windows.Forms.Label listAtt;
        private System.Windows.Forms.Label attConf;
        private System.Windows.Forms.Label Nemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView empruntlist;
        private System.Windows.Forms.DataGridView listeattente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button déconnexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeB;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorite;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarre;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeovr;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn theme;
    }
}

