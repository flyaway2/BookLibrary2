namespace Bibliothècaire
{
    partial class AjouterOuvrage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterOuvrage));
            this.ajouter = new System.Windows.Forms.Button();
            this.codeO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.auteur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.theme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.typeO = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(46, 347);
            this.ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(240, 35);
            this.ajouter.TabIndex = 26;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // codeO
            // 
            this.codeO.Location = new System.Drawing.Point(160, 145);
            this.codeO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeO.Name = "codeO";
            this.codeO.Size = new System.Drawing.Size(127, 20);
            this.codeO.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Code Ouvrage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // titre
            // 
            this.titre.Location = new System.Drawing.Point(160, 181);
            this.titre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(127, 20);
            this.titre.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Type Ouvrage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Titre";
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(160, 284);
            this.img.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(127, 20);
            this.img.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Auteur";
            // 
            // auteur
            // 
            this.auteur.Location = new System.Drawing.Point(160, 249);
            this.auteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.auteur.Name = "auteur";
            this.auteur.Size = new System.Drawing.Size(127, 20);
            this.auteur.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Le chemin de l\'image";
            // 
            // theme
            // 
            this.theme.Location = new System.Drawing.Point(160, 313);
            this.theme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(127, 20);
            this.theme.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Théme";
            // 
            // typeO
            // 
            this.typeO.FormattingEnabled = true;
            this.typeO.Items.AddRange(new object[] {
            "livre",
            "mémoire",
            "thèse"});
            this.typeO.Location = new System.Drawing.Point(160, 214);
            this.typeO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeO.Name = "typeO";
            this.typeO.Size = new System.Drawing.Size(127, 21);
            this.typeO.TabIndex = 37;
            // 
            // AjouterOuvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 393);
            this.Controls.Add(this.typeO);
            this.Controls.Add(this.theme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.auteur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.img);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.codeO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AjouterOuvrage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AouterOuvrage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.TextBox codeO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox img;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox auteur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox theme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox typeO;
    }
}