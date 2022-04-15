namespace Bibliothècaire
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.utilisateur = new System.Windows.Forms.Label();
            this.motdepasse = new System.Windows.Forms.Label();
            this.pseudoo = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Connexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // utilisateur
            // 
            this.utilisateur.BackColor = System.Drawing.SystemColors.Control;
            this.utilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.utilisateur.Location = new System.Drawing.Point(201, 125);
            this.utilisateur.MinimumSize = new System.Drawing.Size(0, 10);
            this.utilisateur.Name = "utilisateur";
            this.utilisateur.Size = new System.Drawing.Size(206, 35);
            this.utilisateur.TabIndex = 1;
            this.utilisateur.Text = "Nom d\'utilisateur";
            this.utilisateur.Click += new System.EventHandler(this.label1_Click);
            // 
            // motdepasse
            // 
            this.motdepasse.BackColor = System.Drawing.SystemColors.Control;
            this.motdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.motdepasse.Location = new System.Drawing.Point(201, 175);
            this.motdepasse.MinimumSize = new System.Drawing.Size(0, 10);
            this.motdepasse.Name = "motdepasse";
            this.motdepasse.Size = new System.Drawing.Size(114, 35);
            this.motdepasse.TabIndex = 2;
            this.motdepasse.Text = "Mot de passe";
            // 
            // pseudoo
            // 
            this.pseudoo.Location = new System.Drawing.Point(349, 125);
            this.pseudoo.MinimumSize = new System.Drawing.Size(4, 20);
            this.pseudoo.Name = "pseudoo";
            this.pseudoo.Size = new System.Drawing.Size(198, 22);
            this.pseudoo.TabIndex = 3;
            this.pseudoo.TextChanged += new System.EventHandler(this.pseudoo_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(349, 175);
            this.password.MinimumSize = new System.Drawing.Size(4, 20);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(198, 22);
            this.password.TabIndex = 4;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Connexion
            // 
            this.Connexion.Location = new System.Drawing.Point(387, 232);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(160, 34);
            this.Connexion.TabIndex = 5;
            this.Connexion.Text = "Connexion";
            this.Connexion.UseVisualStyleBackColor = true;
            this.Connexion.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(205, 232);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(160, 34);
            this.Exit.TabIndex = 26;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 342);
            this.panel1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 236);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "connexion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 206);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "de";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "authentification ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(552, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pseudoo);
            this.Controls.Add(this.motdepasse);
            this.Controls.Add(this.utilisateur);
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label utilisateur;
        private System.Windows.Forms.Label motdepasse;
        private System.Windows.Forms.TextBox pseudoo;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}