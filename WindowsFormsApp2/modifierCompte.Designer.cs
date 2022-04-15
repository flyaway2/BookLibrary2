namespace WindowsFormsApp2
{
    partial class modifierCompte
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
            this.enablePassword2 = new System.Windows.Forms.CheckBox();
            this.gradeEns = new System.Windows.Forms.TextBox();
            this.EmailEns = new System.Windows.Forms.TextBox();
            this.passwordEns = new System.Windows.Forms.TextBox();
            this.nomEns = new System.Windows.Forms.TextBox();
            this.pseudoEns = new System.Windows.Forms.TextBox();
            this.prenomEns = new System.Windows.Forms.TextBox();
            this.enregistrer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enablePassword2
            // 
            this.enablePassword2.AutoSize = true;
            this.enablePassword2.Location = new System.Drawing.Point(332, 163);
            this.enablePassword2.Name = "enablePassword2";
            this.enablePassword2.Size = new System.Drawing.Size(15, 14);
            this.enablePassword2.TabIndex = 38;
            this.enablePassword2.UseVisualStyleBackColor = true;
            this.enablePassword2.CheckedChanged += new System.EventHandler(this.enablePassword2_CheckedChanged);
            // 
            // gradeEns
            // 
            this.gradeEns.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeEns.Location = new System.Drawing.Point(113, 244);
            this.gradeEns.Name = "gradeEns";
            this.gradeEns.Size = new System.Drawing.Size(206, 24);
            this.gradeEns.TabIndex = 36;
            // 
            // EmailEns
            // 
            this.EmailEns.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailEns.Location = new System.Drawing.Point(108, 201);
            this.EmailEns.Name = "EmailEns";
            this.EmailEns.Size = new System.Drawing.Size(211, 24);
            this.EmailEns.TabIndex = 35;
            // 
            // passwordEns
            // 
            this.passwordEns.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordEns.Location = new System.Drawing.Point(108, 159);
            this.passwordEns.Name = "passwordEns";
            this.passwordEns.Size = new System.Drawing.Size(211, 24);
            this.passwordEns.TabIndex = 34;
            this.passwordEns.UseSystemPasswordChar = true;
            // 
            // nomEns
            // 
            this.nomEns.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEns.Location = new System.Drawing.Point(98, 66);
            this.nomEns.Name = "nomEns";
            this.nomEns.Size = new System.Drawing.Size(221, 24);
            this.nomEns.TabIndex = 33;
            // 
            // pseudoEns
            // 
            this.pseudoEns.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudoEns.Location = new System.Drawing.Point(98, 109);
            this.pseudoEns.Name = "pseudoEns";
            this.pseudoEns.Size = new System.Drawing.Size(221, 24);
            this.pseudoEns.TabIndex = 32;
            // 
            // prenomEns
            // 
            this.prenomEns.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomEns.Location = new System.Drawing.Point(98, 22);
            this.prenomEns.Name = "prenomEns";
            this.prenomEns.Size = new System.Drawing.Size(221, 24);
            this.prenomEns.TabIndex = 31;
            // 
            // enregistrer
            // 
            this.enregistrer.Location = new System.Drawing.Point(113, 310);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(160, 23);
            this.enregistrer.TabIndex = 30;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "grade :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Pseudo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Prénom :";
            // 
            // modifierCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 357);
            this.Controls.Add(this.enablePassword2);
            this.Controls.Add(this.gradeEns);
            this.Controls.Add(this.EmailEns);
            this.Controls.Add(this.passwordEns);
            this.Controls.Add(this.nomEns);
            this.Controls.Add(this.pseudoEns);
            this.Controls.Add(this.prenomEns);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modifierCompte";
            this.Text = "modifierCompte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enablePassword2;
        private System.Windows.Forms.TextBox gradeEns;
        private System.Windows.Forms.TextBox EmailEns;
        private System.Windows.Forms.TextBox passwordEns;
        private System.Windows.Forms.TextBox nomEns;
        private System.Windows.Forms.TextBox pseudoEns;
        private System.Windows.Forms.TextBox prenomEns;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}