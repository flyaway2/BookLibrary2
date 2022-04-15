namespace Serveur
{
    partial class ServeurConfiguration
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
            this.label1 = new System.Windows.Forms.Label();
            this.ServerType = new System.Windows.Forms.ComboBox();
            this.PortTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StopServer = new System.Windows.Forms.Button();
            this.StartServer = new System.Windows.Forms.Button();
            this.MsgTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Services";
            // 
            // ServerType
            // 
            this.ServerType.FormattingEnabled = true;
            this.ServerType.Items.AddRange(new object[] {
            ".NET Remoting",
            "Sockets",
            "WCF"});
            this.ServerType.Location = new System.Drawing.Point(146, 39);
            this.ServerType.Name = "ServerType";
            this.ServerType.Size = new System.Drawing.Size(173, 21);
            this.ServerType.TabIndex = 1;
            this.ServerType.SelectedIndexChanged += new System.EventHandler(this.ServerType_SelectedIndexChanged);
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(146, 113);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(85, 20);
            this.PortTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port:";
            // 
            // StopServer
            // 
            this.StopServer.Image = global::Serveur.Properties.Resources.power_off;
            this.StopServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StopServer.Location = new System.Drawing.Point(26, 166);
            this.StopServer.Name = "StopServer";
            this.StopServer.Size = new System.Drawing.Size(56, 25);
            this.StopServer.TabIndex = 5;
            this.StopServer.Text = "Stop";
            this.StopServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StopServer.UseVisualStyleBackColor = true;
            this.StopServer.Click += new System.EventHandler(this.StopServer_Click);
            // 
            // StartServer
            // 
            this.StartServer.Image = global::Serveur.Properties.Resources.power1;
            this.StartServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartServer.Location = new System.Drawing.Point(216, 165);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(61, 25);
            this.StartServer.TabIndex = 4;
            this.StartServer.Text = "Start";
            this.StartServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartServer.UseVisualStyleBackColor = true;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // MsgTxt
            // 
            this.MsgTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgTxt.Location = new System.Drawing.Point(1, 0);
            this.MsgTxt.Name = "MsgTxt";
            this.MsgTxt.Size = new System.Drawing.Size(333, 22);
            this.MsgTxt.TabIndex = 8;
            this.MsgTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address:";
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(146, 78);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(173, 20);
            this.AddressTxt.TabIndex = 2;
            // 
            // ServeurConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 210);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MsgTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PortTxt);
            this.Controls.Add(this.ServerType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopServer);
            this.Controls.Add(this.StartServer);
            this.Name = "ServeurConfiguration";
            this.Text = "ServeurConfiguration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.Button StopServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ServerType;
        private System.Windows.Forms.TextBox PortTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MsgTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressTxt;
    }
}