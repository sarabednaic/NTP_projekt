namespace ntp_projekt
{
    partial class BrisanjeProjekta
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
            System.Windows.Forms.Label BrisanjeProjektaNaslovLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrisanjeProjekta));
            System.Windows.Forms.Label BrisanjeProjektaLozinkaNazivLabel;
            System.Windows.Forms.Label BrisanjeProjektaPonovnoLozinkaLabel;
            this.BrisanjeProjektaPonovnoLozinkaTextBox = new System.Windows.Forms.TextBox();
            this.BrisanjeProjektaLozinkaTextBox = new System.Windows.Forms.TextBox();
            this.BrisanjeProjektaIzbrisiProjektButton = new System.Windows.Forms.Button();
            this.BrisanjeProjektaPanel = new System.Windows.Forms.Panel();
            this.BrisanjeProjektaProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.BrisanjeProjektaNatragButton = new System.Windows.Forms.Button();
            this.BrisanjeProjektaProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            BrisanjeProjektaNaslovLabel = new System.Windows.Forms.Label();
            BrisanjeProjektaLozinkaNazivLabel = new System.Windows.Forms.Label();
            BrisanjeProjektaPonovnoLozinkaLabel = new System.Windows.Forms.Label();
            this.BrisanjeProjektaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrisanjeProjektaProfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BrisanjeProjektaNaslovLabel
            // 
            resources.ApplyResources(BrisanjeProjektaNaslovLabel, "BrisanjeProjektaNaslovLabel");
            BrisanjeProjektaNaslovLabel.Name = "BrisanjeProjektaNaslovLabel";
            // 
            // BrisanjeProjektaLozinkaNazivLabel
            // 
            resources.ApplyResources(BrisanjeProjektaLozinkaNazivLabel, "BrisanjeProjektaLozinkaNazivLabel");
            BrisanjeProjektaLozinkaNazivLabel.BackColor = System.Drawing.Color.Transparent;
            BrisanjeProjektaLozinkaNazivLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            BrisanjeProjektaLozinkaNazivLabel.Name = "BrisanjeProjektaLozinkaNazivLabel";
            BrisanjeProjektaLozinkaNazivLabel.UseWaitCursor = true;
            // 
            // BrisanjeProjektaPonovnoLozinkaLabel
            // 
            resources.ApplyResources(BrisanjeProjektaPonovnoLozinkaLabel, "BrisanjeProjektaPonovnoLozinkaLabel");
            BrisanjeProjektaPonovnoLozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            BrisanjeProjektaPonovnoLozinkaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            BrisanjeProjektaPonovnoLozinkaLabel.Name = "BrisanjeProjektaPonovnoLozinkaLabel";
            BrisanjeProjektaPonovnoLozinkaLabel.UseWaitCursor = true;
            // 
            // BrisanjeProjektaPonovnoLozinkaTextBox
            // 
            resources.ApplyResources(this.BrisanjeProjektaPonovnoLozinkaTextBox, "BrisanjeProjektaPonovnoLozinkaTextBox");
            this.BrisanjeProjektaPonovnoLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BrisanjeProjektaPonovnoLozinkaTextBox.Name = "BrisanjeProjektaPonovnoLozinkaTextBox";
            // 
            // BrisanjeProjektaLozinkaTextBox
            // 
            resources.ApplyResources(this.BrisanjeProjektaLozinkaTextBox, "BrisanjeProjektaLozinkaTextBox");
            this.BrisanjeProjektaLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BrisanjeProjektaLozinkaTextBox.Name = "BrisanjeProjektaLozinkaTextBox";
            // 
            // BrisanjeProjektaIzbrisiProjektButton
            // 
            resources.ApplyResources(this.BrisanjeProjektaIzbrisiProjektButton, "BrisanjeProjektaIzbrisiProjektButton");
            this.BrisanjeProjektaIzbrisiProjektButton.BackColor = System.Drawing.Color.Red;
            this.BrisanjeProjektaIzbrisiProjektButton.ForeColor = System.Drawing.Color.White;
            this.BrisanjeProjektaIzbrisiProjektButton.Name = "BrisanjeProjektaIzbrisiProjektButton";
            this.BrisanjeProjektaIzbrisiProjektButton.UseVisualStyleBackColor = false;
            this.BrisanjeProjektaIzbrisiProjektButton.Click += new System.EventHandler(this.BrisanjeProjektaIzbrisiProjektButton_Click);
            // 
            // BrisanjeProjektaPanel
            // 
            resources.ApplyResources(this.BrisanjeProjektaPanel, "BrisanjeProjektaPanel");
            this.BrisanjeProjektaPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BrisanjeProjektaPanel.Controls.Add(this.BrisanjeProjektaProfilPictureBox);
            this.BrisanjeProjektaPanel.Controls.Add(this.BrisanjeProjektaNatragButton);
            this.BrisanjeProjektaPanel.Controls.Add(this.BrisanjeProjektaProfilLinkLabel);
            this.BrisanjeProjektaPanel.Name = "BrisanjeProjektaPanel";
            this.BrisanjeProjektaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DodajProjektProfilPanel_Paint);
            // 
            // BrisanjeProjektaProfilPictureBox
            // 
            resources.ApplyResources(this.BrisanjeProjektaProfilPictureBox, "BrisanjeProjektaProfilPictureBox");
            this.BrisanjeProjektaProfilPictureBox.Name = "BrisanjeProjektaProfilPictureBox";
            this.BrisanjeProjektaProfilPictureBox.TabStop = false;
            this.BrisanjeProjektaProfilPictureBox.Click += new System.EventHandler(this.BrisanjeProjektaProfilPictureBox_Click);
            // 
            // BrisanjeProjektaNatragButton
            // 
            resources.ApplyResources(this.BrisanjeProjektaNatragButton, "BrisanjeProjektaNatragButton");
            this.BrisanjeProjektaNatragButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BrisanjeProjektaNatragButton.Name = "BrisanjeProjektaNatragButton";
            this.BrisanjeProjektaNatragButton.UseVisualStyleBackColor = false;
            this.BrisanjeProjektaNatragButton.Click += new System.EventHandler(this.BrisanjeProjektaNatragButton_Click);
            // 
            // BrisanjeProjektaProfilLinkLabel
            // 
            resources.ApplyResources(this.BrisanjeProjektaProfilLinkLabel, "BrisanjeProjektaProfilLinkLabel");
            this.BrisanjeProjektaProfilLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.BrisanjeProjektaProfilLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BrisanjeProjektaProfilLinkLabel.Name = "BrisanjeProjektaProfilLinkLabel";
            this.BrisanjeProjektaProfilLinkLabel.TabStop = true;
            this.BrisanjeProjektaProfilLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BrisanjeProjektaProfilLinkLabel_LinkClicked);
            // 
            // PanelLogo
            // 
            resources.ApplyResources(this.PanelLogo, "PanelLogo");
            this.PanelLogo.Name = "PanelLogo";
            // 
            // BrisanjeProjekta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelLogo);
            this.Controls.Add(this.BrisanjeProjektaLozinkaTextBox);
            this.Controls.Add(this.BrisanjeProjektaPonovnoLozinkaTextBox);
            this.Controls.Add(this.BrisanjeProjektaPanel);
            this.Controls.Add(BrisanjeProjektaNaslovLabel);
            this.Controls.Add(this.BrisanjeProjektaIzbrisiProjektButton);
            this.Controls.Add(BrisanjeProjektaPonovnoLozinkaLabel);
            this.Controls.Add(BrisanjeProjektaLozinkaNazivLabel);
            this.Name = "BrisanjeProjekta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BrisanjeProjekta_Load);
            this.BrisanjeProjektaPanel.ResumeLayout(false);
            this.BrisanjeProjektaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrisanjeProjektaProfilPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrisanjeProjektaIzbrisiProjektButton;
        private System.Windows.Forms.Panel BrisanjeProjektaPanel;
        private System.Windows.Forms.PictureBox BrisanjeProjektaProfilPictureBox;
        private System.Windows.Forms.Button BrisanjeProjektaNatragButton;
        private System.Windows.Forms.LinkLabel BrisanjeProjektaProfilLinkLabel;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.TextBox BrisanjeProjektaPonovnoLozinkaTextBox;
        private System.Windows.Forms.TextBox BrisanjeProjektaLozinkaTextBox;
    }
}