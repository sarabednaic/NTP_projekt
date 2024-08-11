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
            System.Windows.Forms.Label BriasnjeProjektaNaslovLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrisanjeProjekta));
            this.BrisanjeProjektaIzbrisiProjektButton = new System.Windows.Forms.Button();
            this.BrisanjeProjektaLozinkaTextBox = new System.Windows.Forms.RichTextBox();
            this.BrisanjeProjektaPonovnoLozinkaTextBox = new System.Windows.Forms.RichTextBox();
            this.DodajProjektProfilPanel = new System.Windows.Forms.Panel();
            this.DodajProjektProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.DodajProjektNatragButton = new System.Windows.Forms.Button();
            this.DodajProjektProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            BriasnjeProjektaNaslovLabel = new System.Windows.Forms.Label();
            this.DodajProjektProfilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DodajProjektProfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BriasnjeProjektaNaslovLabel
            // 
            BriasnjeProjektaNaslovLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            BriasnjeProjektaNaslovLabel.AutoSize = true;
            BriasnjeProjektaNaslovLabel.Font = new System.Drawing.Font("Leelawadee UI", 40F, System.Drawing.FontStyle.Bold);
            BriasnjeProjektaNaslovLabel.Location = new System.Drawing.Point(607, 248);
            BriasnjeProjektaNaslovLabel.Name = "BriasnjeProjektaNaslovLabel";
            BriasnjeProjektaNaslovLabel.Size = new System.Drawing.Size(681, 106);
            BriasnjeProjektaNaslovLabel.TabIndex = 3;
            BriasnjeProjektaNaslovLabel.Text = "Brisanje projekta";
            BriasnjeProjektaNaslovLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // BrisanjeProjektaIzbrisiProjektButton
            // 
            this.BrisanjeProjektaIzbrisiProjektButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrisanjeProjektaIzbrisiProjektButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrisanjeProjektaIzbrisiProjektButton.BackColor = System.Drawing.Color.Red;
            this.BrisanjeProjektaIzbrisiProjektButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BrisanjeProjektaIzbrisiProjektButton.ForeColor = System.Drawing.Color.White;
            this.BrisanjeProjektaIzbrisiProjektButton.Location = new System.Drawing.Point(849, 640);
            this.BrisanjeProjektaIzbrisiProjektButton.Name = "BrisanjeProjektaIzbrisiProjektButton";
            this.BrisanjeProjektaIzbrisiProjektButton.Size = new System.Drawing.Size(229, 56);
            this.BrisanjeProjektaIzbrisiProjektButton.TabIndex = 0;
            this.BrisanjeProjektaIzbrisiProjektButton.Text = "Izbriši projekt";
            this.BrisanjeProjektaIzbrisiProjektButton.UseVisualStyleBackColor = false;
            this.BrisanjeProjektaIzbrisiProjektButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrisanjeProjektaLozinkaTextBox
            // 
            this.BrisanjeProjektaLozinkaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrisanjeProjektaLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BrisanjeProjektaLozinkaTextBox.Location = new System.Drawing.Point(721, 466);
            this.BrisanjeProjektaLozinkaTextBox.Name = "BrisanjeProjektaLozinkaTextBox";
            this.BrisanjeProjektaLozinkaTextBox.Size = new System.Drawing.Size(459, 37);
            this.BrisanjeProjektaLozinkaTextBox.TabIndex = 1;
            this.BrisanjeProjektaLozinkaTextBox.Text = "Upišite trenutnu lozinku";
            // 
            // BrisanjeProjektaPonovnoLozinkaTextBox
            // 
            this.BrisanjeProjektaPonovnoLozinkaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrisanjeProjektaPonovnoLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BrisanjeProjektaPonovnoLozinkaTextBox.Location = new System.Drawing.Point(721, 540);
            this.BrisanjeProjektaPonovnoLozinkaTextBox.Name = "BrisanjeProjektaPonovnoLozinkaTextBox";
            this.BrisanjeProjektaPonovnoLozinkaTextBox.Size = new System.Drawing.Size(459, 35);
            this.BrisanjeProjektaPonovnoLozinkaTextBox.TabIndex = 2;
            this.BrisanjeProjektaPonovnoLozinkaTextBox.Text = "Ponovite trenutnu lozinku";
            // 
            // DodajProjektProfilPanel
            // 
            this.DodajProjektProfilPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DodajProjektProfilPanel.Controls.Add(this.DodajProjektProfilPictureBox);
            this.DodajProjektProfilPanel.Controls.Add(this.DodajProjektNatragButton);
            this.DodajProjektProfilPanel.Controls.Add(this.DodajProjektProfilLinkLabel);
            this.DodajProjektProfilPanel.Location = new System.Drawing.Point(0, 0);
            this.DodajProjektProfilPanel.Name = "DodajProjektProfilPanel";
            this.DodajProjektProfilPanel.Size = new System.Drawing.Size(1920, 90);
            this.DodajProjektProfilPanel.TabIndex = 11;
            this.DodajProjektProfilPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DodajProjektProfilPanel_Paint);
            // 
            // DodajProjektProfilPictureBox
            // 
            this.DodajProjektProfilPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DodajProjektProfilPictureBox.BackgroundImage")));
            this.DodajProjektProfilPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DodajProjektProfilPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DodajProjektProfilPictureBox.Image")));
            this.DodajProjektProfilPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("DodajProjektProfilPictureBox.InitialImage")));
            this.DodajProjektProfilPictureBox.Location = new System.Drawing.Point(1823, 13);
            this.DodajProjektProfilPictureBox.Name = "DodajProjektProfilPictureBox";
            this.DodajProjektProfilPictureBox.Size = new System.Drawing.Size(65, 65);
            this.DodajProjektProfilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DodajProjektProfilPictureBox.TabIndex = 27;
            this.DodajProjektProfilPictureBox.TabStop = false;
            // 
            // DodajProjektNatragButton
            // 
            this.DodajProjektNatragButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DodajProjektNatragButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DodajProjektNatragButton.BackgroundImage")));
            this.DodajProjektNatragButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DodajProjektNatragButton.Location = new System.Drawing.Point(12, 12);
            this.DodajProjektNatragButton.Name = "DodajProjektNatragButton";
            this.DodajProjektNatragButton.Size = new System.Drawing.Size(64, 64);
            this.DodajProjektNatragButton.TabIndex = 26;
            this.DodajProjektNatragButton.UseVisualStyleBackColor = false;
            // 
            // DodajProjektProfilLinkLabel
            // 
            this.DodajProjektProfilLinkLabel.AutoSize = true;
            this.DodajProjektProfilLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.DodajProjektProfilLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DodajProjektProfilLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DodajProjektProfilLinkLabel.Location = new System.Drawing.Point(1651, 31);
            this.DodajProjektProfilLinkLabel.Name = "DodajProjektProfilLinkLabel";
            this.DodajProjektProfilLinkLabel.Size = new System.Drawing.Size(157, 29);
            this.DodajProjektProfilLinkLabel.TabIndex = 26;
            this.DodajProjektProfilLinkLabel.TabStop = true;
            this.DodajProjektProfilLinkLabel.Text = "Sara Bednaić";
            // 
            // BrisanjeProjekta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.DodajProjektProfilPanel);
            this.Controls.Add(BriasnjeProjektaNaslovLabel);
            this.Controls.Add(this.BrisanjeProjektaPonovnoLozinkaTextBox);
            this.Controls.Add(this.BrisanjeProjektaLozinkaTextBox);
            this.Controls.Add(this.BrisanjeProjektaIzbrisiProjektButton);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1440, 1018);
            this.Name = "BrisanjeProjekta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DodajProjektProfilPanel.ResumeLayout(false);
            this.DodajProjektProfilPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DodajProjektProfilPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrisanjeProjektaIzbrisiProjektButton;
        private System.Windows.Forms.RichTextBox BrisanjeProjektaLozinkaTextBox;
        private System.Windows.Forms.RichTextBox BrisanjeProjektaPonovnoLozinkaTextBox;
        private System.Windows.Forms.Panel DodajProjektProfilPanel;
        private System.Windows.Forms.PictureBox DodajProjektProfilPictureBox;
        private System.Windows.Forms.Button DodajProjektNatragButton;
        private System.Windows.Forms.LinkLabel DodajProjektProfilLinkLabel;
    }
}