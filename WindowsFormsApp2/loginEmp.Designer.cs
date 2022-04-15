namespace WindowsFormsApp2
{
    partial class loginEmp
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
            this.Emprunteur = new System.Windows.Forms.TabControl();
            this.Etudiant = new System.Windows.Forms.TabPage();
            this.Enseignant = new System.Windows.Forms.TabPage();
            this.EnsPseudo = new System.Windows.Forms.TextBox();
            this.EnsPassword = new System.Windows.Forms.TextBox();
            this.authentifierEns = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authentifierEtud = new System.Windows.Forms.Button();
            this.EtudPseudo = new System.Windows.Forms.TextBox();
            this.EtudPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showpassword = new System.Windows.Forms.CheckBox();
            this.showpasswordEns = new System.Windows.Forms.CheckBox();
            this.Emprunteur.SuspendLayout();
            this.Etudiant.SuspendLayout();
            this.Enseignant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Emprunteur
            // 
            this.Emprunteur.Controls.Add(this.Etudiant);
            this.Emprunteur.Controls.Add(this.Enseignant);
            this.Emprunteur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Emprunteur.Location = new System.Drawing.Point(0, 0);
            this.Emprunteur.Name = "Emprunteur";
            this.Emprunteur.SelectedIndex = 0;
            this.Emprunteur.Size = new System.Drawing.Size(511, 252);
            this.Emprunteur.TabIndex = 0;
            // 
            // Etudiant
            // 
            this.Etudiant.BackColor = System.Drawing.Color.Lavender;
            this.Etudiant.Controls.Add(this.showpassword);
            this.Etudiant.Controls.Add(this.label4);
            this.Etudiant.Controls.Add(this.label3);
            this.Etudiant.Controls.Add(this.pictureBox2);
            this.Etudiant.Controls.Add(this.EtudPassword);
            this.Etudiant.Controls.Add(this.EtudPseudo);
            this.Etudiant.Controls.Add(this.authentifierEtud);
            this.Etudiant.Location = new System.Drawing.Point(4, 22);
            this.Etudiant.Name = "Etudiant";
            this.Etudiant.Padding = new System.Windows.Forms.Padding(3);
            this.Etudiant.Size = new System.Drawing.Size(502, 226);
            this.Etudiant.TabIndex = 0;
            this.Etudiant.Text = "Etudiant";
            // 
            // Enseignant
            // 
            this.Enseignant.BackColor = System.Drawing.Color.Azure;
            this.Enseignant.Controls.Add(this.showpasswordEns);
            this.Enseignant.Controls.Add(this.label2);
            this.Enseignant.Controls.Add(this.label1);
            this.Enseignant.Controls.Add(this.authentifierEns);
            this.Enseignant.Controls.Add(this.EnsPassword);
            this.Enseignant.Controls.Add(this.EnsPseudo);
            this.Enseignant.Controls.Add(this.pictureBox1);
            this.Enseignant.Location = new System.Drawing.Point(4, 22);
            this.Enseignant.Name = "Enseignant";
            this.Enseignant.Padding = new System.Windows.Forms.Padding(3);
            this.Enseignant.Size = new System.Drawing.Size(503, 226);
            this.Enseignant.TabIndex = 1;
            this.Enseignant.Text = "Enseignant";
            // 
            // EnsPseudo
            // 
            this.EnsPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnsPseudo.Location = new System.Drawing.Point(261, 46);
            this.EnsPseudo.Name = "EnsPseudo";
            this.EnsPseudo.Size = new System.Drawing.Size(232, 24);
            this.EnsPseudo.TabIndex = 0;
            this.EnsPseudo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EnsPassword
            // 
            this.EnsPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnsPassword.Location = new System.Drawing.Point(302, 108);
            this.EnsPassword.Name = "EnsPassword";
            this.EnsPassword.Size = new System.Drawing.Size(191, 24);
            this.EnsPassword.TabIndex = 1;
            // 
            // authentifierEns
            // 
            this.authentifierEns.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authentifierEns.Location = new System.Drawing.Point(334, 169);
            this.authentifierEns.Name = "authentifierEns";
            this.authentifierEns.Size = new System.Drawing.Size(159, 35);
            this.authentifierEns.TabIndex = 2;
            this.authentifierEns.Text = "authentifier";
            this.authentifierEns.UseVisualStyleBackColor = true;
            this.authentifierEns.Click += new System.EventHandler(this.authentifierEns_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pseudo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "mot de passe:";
            // 
            // authentifierEtud
            // 
            this.authentifierEtud.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authentifierEtud.Location = new System.Drawing.Point(345, 174);
            this.authentifierEtud.Name = "authentifierEtud";
            this.authentifierEtud.Size = new System.Drawing.Size(148, 34);
            this.authentifierEtud.TabIndex = 0;
            this.authentifierEtud.Text = "authentifier";
            this.authentifierEtud.UseVisualStyleBackColor = true;
            this.authentifierEtud.Click += new System.EventHandler(this.authentifierEtud_Click);
            // 
            // EtudPseudo
            // 
            this.EtudPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtudPseudo.Location = new System.Drawing.Point(284, 46);
            this.EtudPseudo.Name = "EtudPseudo";
            this.EtudPseudo.Size = new System.Drawing.Size(212, 24);
            this.EtudPseudo.TabIndex = 1;
            // 
            // EtudPassword
            // 
            this.EtudPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtudPassword.Location = new System.Drawing.Point(322, 113);
            this.EtudPassword.Name = "EtudPassword";
            this.EtudPassword.Size = new System.Drawing.Size(171, 24);
            this.EtudPassword.TabIndex = 2;
            this.EtudPassword.TextChanged += new System.EventHandler(this.EtudPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pseudo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "mot de passe:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.etud1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 224);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.ens;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // showpassword
            // 
            this.showpassword.AutoSize = true;
            this.showpassword.Location = new System.Drawing.Point(322, 143);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(138, 17);
            this.showpassword.TabIndex = 6;
            this.showpassword.Text = "afficher le mot de passe";
            this.showpassword.UseVisualStyleBackColor = true;
            this.showpassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // showpasswordEns
            // 
            this.showpasswordEns.AutoSize = true;
            this.showpasswordEns.Location = new System.Drawing.Point(302, 146);
            this.showpasswordEns.Name = "showpasswordEns";
            this.showpasswordEns.Size = new System.Drawing.Size(138, 17);
            this.showpasswordEns.TabIndex = 6;
            this.showpasswordEns.Text = "afficher le mot de passe";
            this.showpasswordEns.UseVisualStyleBackColor = true;
            this.showpasswordEns.CheckedChanged += new System.EventHandler(this.showpasswordEns_CheckedChanged);
            // 
            // loginEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 252);
            this.Controls.Add(this.Emprunteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "loginEmp";
            this.Text = "loginEmp";
            this.Emprunteur.ResumeLayout(false);
            this.Etudiant.ResumeLayout(false);
            this.Etudiant.PerformLayout();
            this.Enseignant.ResumeLayout(false);
            this.Enseignant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Emprunteur;
        private System.Windows.Forms.TabPage Etudiant;
        private System.Windows.Forms.TabPage Enseignant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button authentifierEns;
        private System.Windows.Forms.TextBox EnsPassword;
        private System.Windows.Forms.TextBox EnsPseudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox EtudPassword;
        private System.Windows.Forms.TextBox EtudPseudo;
        private System.Windows.Forms.Button authentifierEtud;
        private System.Windows.Forms.CheckBox showpassword;
        private System.Windows.Forms.CheckBox showpasswordEns;
    }
}