namespace ntp_projekt
{
    partial class BrisanjeZadatka
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
            System.Windows.Forms.Label BriasnjeZadatkaNaslovLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrisanjeZadatka));
            System.Windows.Forms.TextBox BrisanjeZadatkaLozinkaTextBox;
            System.Windows.Forms.TextBox BrisanjeZadatkaPonovnoLozinkaTextBox;
            System.Windows.Forms.Label BrisanjeZadatkaPonovnoLozinkaLabel;
            System.Windows.Forms.Label BrisanjeZadatkaLozinkaLabel;
            this.BrisanjeZadatkaIzbrisiZadatakButton = new System.Windows.Forms.Button();
            this.BrisanjeZadatkaNatragButton = new System.Windows.Forms.Button();
            this.BrisanjeZadatkaPanel = new System.Windows.Forms.Panel();
            this.BrisanjeZadatkaProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.BrisanjeZadatkaProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            BriasnjeZadatkaNaslovLabel = new System.Windows.Forms.Label();
            BrisanjeZadatkaLozinkaTextBox = new System.Windows.Forms.TextBox();
            BrisanjeZadatkaPonovnoLozinkaTextBox = new System.Windows.Forms.TextBox();
            BrisanjeZadatkaPonovnoLozinkaLabel = new System.Windows.Forms.Label();
            BrisanjeZadatkaLozinkaLabel = new System.Windows.Forms.Label();
            this.BrisanjeZadatkaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrisanjeZadatkaProfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BriasnjeZadatkaNaslovLabel
            // 
            resources.ApplyResources(BriasnjeZadatkaNaslovLabel, "BriasnjeZadatkaNaslovLabel");
            BriasnjeZadatkaNaslovLabel.Name = "BriasnjeZadatkaNaslovLabel";
            BriasnjeZadatkaNaslovLabel.Click += new System.EventHandler(this.BriasnjeProjektaNaslovLabel_Click);
            // 
            // BrisanjeZadatkaLozinkaTextBox
            // 
            BrisanjeZadatkaLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(BrisanjeZadatkaLozinkaTextBox, "BrisanjeZadatkaLozinkaTextBox");
            BrisanjeZadatkaLozinkaTextBox.Name = "BrisanjeZadatkaLozinkaTextBox";
            // 
            // BrisanjeZadatkaPonovnoLozinkaTextBox
            // 
            BrisanjeZadatkaPonovnoLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(BrisanjeZadatkaPonovnoLozinkaTextBox, "BrisanjeZadatkaPonovnoLozinkaTextBox");
            BrisanjeZadatkaPonovnoLozinkaTextBox.Name = "BrisanjeZadatkaPonovnoLozinkaTextBox";
            // 
            // BrisanjeZadatkaPonovnoLozinkaLabel
            // 
            BrisanjeZadatkaPonovnoLozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(BrisanjeZadatkaPonovnoLozinkaLabel, "BrisanjeZadatkaPonovnoLozinkaLabel");
            BrisanjeZadatkaPonovnoLozinkaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            BrisanjeZadatkaPonovnoLozinkaLabel.Name = "BrisanjeZadatkaPonovnoLozinkaLabel";
            BrisanjeZadatkaPonovnoLozinkaLabel.UseWaitCursor = true;
            // 
            // BrisanjeZadatkaLozinkaLabel
            // 
            BrisanjeZadatkaLozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(BrisanjeZadatkaLozinkaLabel, "BrisanjeZadatkaLozinkaLabel");
            BrisanjeZadatkaLozinkaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            BrisanjeZadatkaLozinkaLabel.Name = "BrisanjeZadatkaLozinkaLabel";
            BrisanjeZadatkaLozinkaLabel.UseWaitCursor = true;
            // 
            // BrisanjeZadatkaIzbrisiZadatakButton
            // 
            resources.ApplyResources(this.BrisanjeZadatkaIzbrisiZadatakButton, "BrisanjeZadatkaIzbrisiZadatakButton");
            this.BrisanjeZadatkaIzbrisiZadatakButton.BackColor = System.Drawing.Color.Red;
            this.BrisanjeZadatkaIzbrisiZadatakButton.ForeColor = System.Drawing.Color.White;
            this.BrisanjeZadatkaIzbrisiZadatakButton.Name = "BrisanjeZadatkaIzbrisiZadatakButton";
            this.BrisanjeZadatkaIzbrisiZadatakButton.UseVisualStyleBackColor = false;
            this.BrisanjeZadatkaIzbrisiZadatakButton.Click += new System.EventHandler(this.BrisanjeZadatkaIzbrisiZadatakButton_Click);
            // 
            // BrisanjeZadatkaNatragButton
            // 
            this.BrisanjeZadatkaNatragButton.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.BrisanjeZadatkaNatragButton, "BrisanjeZadatkaNatragButton");
            this.BrisanjeZadatkaNatragButton.Name = "BrisanjeZadatkaNatragButton";
            this.BrisanjeZadatkaNatragButton.UseVisualStyleBackColor = false;
            this.BrisanjeZadatkaNatragButton.Click += new System.EventHandler(this.BrisanjeZadatkaNatragButton_Click);
            // 
            // BrisanjeZadatkaPanel
            // 
            this.BrisanjeZadatkaPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BrisanjeZadatkaPanel.Controls.Add(this.BrisanjeZadatkaNatragButton);
            this.BrisanjeZadatkaPanel.Controls.Add(this.BrisanjeZadatkaProfilPictureBox);
            this.BrisanjeZadatkaPanel.Controls.Add(this.BrisanjeZadatkaProfilLinkLabel);
            resources.ApplyResources(this.BrisanjeZadatkaPanel, "BrisanjeZadatkaPanel");
            this.BrisanjeZadatkaPanel.Name = "BrisanjeZadatkaPanel";
            // 
            // BrisanjeZadatkaProfilPictureBox
            // 
            resources.ApplyResources(this.BrisanjeZadatkaProfilPictureBox, "BrisanjeZadatkaProfilPictureBox");
            this.BrisanjeZadatkaProfilPictureBox.Name = "BrisanjeZadatkaProfilPictureBox";
            this.BrisanjeZadatkaProfilPictureBox.TabStop = false;
            this.BrisanjeZadatkaProfilPictureBox.Click += new System.EventHandler(this.DeaktivacijaProfilPictureBox_Click);
            // 
            // BrisanjeZadatkaProfilLinkLabel
            // 
            resources.ApplyResources(this.BrisanjeZadatkaProfilLinkLabel, "BrisanjeZadatkaProfilLinkLabel");
            this.BrisanjeZadatkaProfilLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BrisanjeZadatkaProfilLinkLabel.Name = "BrisanjeZadatkaProfilLinkLabel";
            this.BrisanjeZadatkaProfilLinkLabel.TabStop = true;
            this.BrisanjeZadatkaProfilLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BrisanjeZadatkaProfilLinkLabel_LinkClicked);
            // 
            // PanelLogo
            // 
            resources.ApplyResources(this.PanelLogo, "PanelLogo");
            this.PanelLogo.Name = "PanelLogo";
            // 
            // BrisanjeZadatka
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelLogo);
            this.Controls.Add(BrisanjeZadatkaLozinkaTextBox);
            this.Controls.Add(this.BrisanjeZadatkaPanel);
            this.Controls.Add(BrisanjeZadatkaPonovnoLozinkaTextBox);
            this.Controls.Add(this.BrisanjeZadatkaIzbrisiZadatakButton);
            this.Controls.Add(BrisanjeZadatkaPonovnoLozinkaLabel);
            this.Controls.Add(BrisanjeZadatkaLozinkaLabel);
            this.Controls.Add(BriasnjeZadatkaNaslovLabel);
            this.Name = "BrisanjeZadatka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BrisanjeZadatka_Load);
            this.BrisanjeZadatkaPanel.ResumeLayout(false);
            this.BrisanjeZadatkaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrisanjeZadatkaProfilPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BrisanjeZadatkaIzbrisiZadatakButton;
        private System.Windows.Forms.Button BrisanjeZadatkaNatragButton;
        private System.Windows.Forms.Panel BrisanjeZadatkaPanel;
        private System.Windows.Forms.PictureBox BrisanjeZadatkaProfilPictureBox;
        private System.Windows.Forms.LinkLabel BrisanjeZadatkaProfilLinkLabel;
        private System.Windows.Forms.Panel PanelLogo;
    }
}