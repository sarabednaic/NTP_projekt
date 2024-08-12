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
            System.Windows.Forms.Label BrisanjeProjektaLozinkaNazivLabel;
            System.Windows.Forms.Label BrisanjeProjektaPonovnoLozinkaLabel;
            System.Windows.Forms.TextBox BrisanjeProjektaPonovnoLozinkaTextBox;
            System.Windows.Forms.TextBox BrisanjeProjektaLozinkaTextBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrisanjeProjekta));
            this.BrisanjeProjektaIzbrisiProjektButton = new System.Windows.Forms.Button();
            this.BrisanjeProjektaPanel = new System.Windows.Forms.Panel();
            this.BrisanjeProjektaProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.BrisanjeProjektaNatragButton = new System.Windows.Forms.Button();
            this.BrisanjeProjektaProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            BrisanjeProjektaNaslovLabel = new System.Windows.Forms.Label();
            BrisanjeProjektaLozinkaNazivLabel = new System.Windows.Forms.Label();
            BrisanjeProjektaPonovnoLozinkaLabel = new System.Windows.Forms.Label();
            BrisanjeProjektaPonovnoLozinkaTextBox = new System.Windows.Forms.TextBox();
            BrisanjeProjektaLozinkaTextBox = new System.Windows.Forms.TextBox();
            this.BrisanjeProjektaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrisanjeProjektaProfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BrisanjeProjektaNaslovLabel
            // 
            BrisanjeProjektaNaslovLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            BrisanjeProjektaNaslovLabel.AutoSize = true;
            BrisanjeProjektaNaslovLabel.Font = new System.Drawing.Font("Leelawadee UI", 40F, System.Drawing.FontStyle.Bold);
            BrisanjeProjektaNaslovLabel.Location = new System.Drawing.Point(607, 248);
            BrisanjeProjektaNaslovLabel.Name = "BrisanjeProjektaNaslovLabel";
            BrisanjeProjektaNaslovLabel.Size = new System.Drawing.Size(681, 106);
            BrisanjeProjektaNaslovLabel.TabIndex = 3;
            BrisanjeProjektaNaslovLabel.Text = "Brisanje projekta";
            BrisanjeProjektaNaslovLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // BrisanjeProjektaLozinkaNazivLabel
            // 
            BrisanjeProjektaLozinkaNazivLabel.BackColor = System.Drawing.Color.Transparent;
            BrisanjeProjektaLozinkaNazivLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BrisanjeProjektaLozinkaNazivLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            BrisanjeProjektaLozinkaNazivLabel.Location = new System.Drawing.Point(717, 431);
            BrisanjeProjektaLozinkaNazivLabel.Name = "BrisanjeProjektaLozinkaNazivLabel";
            BrisanjeProjektaLozinkaNazivLabel.Size = new System.Drawing.Size(287, 43);
            BrisanjeProjektaLozinkaNazivLabel.TabIndex = 57;
            BrisanjeProjektaLozinkaNazivLabel.Text = "Upišite lozinku za potvrdu brisanja zadatka";
            BrisanjeProjektaLozinkaNazivLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BrisanjeProjektaLozinkaNazivLabel.UseWaitCursor = true;
            // 
            // BrisanjeProjektaPonovnoLozinkaLabel
            // 
            BrisanjeProjektaPonovnoLozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            BrisanjeProjektaPonovnoLozinkaLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BrisanjeProjektaPonovnoLozinkaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            BrisanjeProjektaPonovnoLozinkaLabel.Location = new System.Drawing.Point(717, 512);
            BrisanjeProjektaPonovnoLozinkaLabel.Name = "BrisanjeProjektaPonovnoLozinkaLabel";
            BrisanjeProjektaPonovnoLozinkaLabel.Size = new System.Drawing.Size(287, 43);
            BrisanjeProjektaPonovnoLozinkaLabel.TabIndex = 58;
            BrisanjeProjektaPonovnoLozinkaLabel.Text = "Ponovite lozinku za potvrdu brisanja zadatka";
            BrisanjeProjektaPonovnoLozinkaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BrisanjeProjektaPonovnoLozinkaLabel.UseWaitCursor = true;
            // 
            // BrisanjeProjektaPonovnoLozinkaTextBox
            // 
            BrisanjeProjektaPonovnoLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            BrisanjeProjektaPonovnoLozinkaTextBox.Location = new System.Drawing.Point(721, 544);
            BrisanjeProjektaPonovnoLozinkaTextBox.Name = "BrisanjeProjektaPonovnoLozinkaTextBox";
            BrisanjeProjektaPonovnoLozinkaTextBox.PasswordChar = '*';
            BrisanjeProjektaPonovnoLozinkaTextBox.Size = new System.Drawing.Size(459, 26);
            BrisanjeProjektaPonovnoLozinkaTextBox.TabIndex = 59;
            // 
            // BrisanjeProjektaLozinkaTextBox
            // 
            BrisanjeProjektaLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            BrisanjeProjektaLozinkaTextBox.Location = new System.Drawing.Point(721, 467);
            BrisanjeProjektaLozinkaTextBox.Name = "BrisanjeProjektaLozinkaTextBox";
            BrisanjeProjektaLozinkaTextBox.PasswordChar = '*';
            BrisanjeProjektaLozinkaTextBox.Size = new System.Drawing.Size(459, 26);
            BrisanjeProjektaLozinkaTextBox.TabIndex = 60;
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
            // BrisanjeProjektaPanel
            // 
            this.BrisanjeProjektaPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BrisanjeProjektaPanel.Controls.Add(this.BrisanjeProjektaProfilPictureBox);
            this.BrisanjeProjektaPanel.Controls.Add(this.BrisanjeProjektaNatragButton);
            this.BrisanjeProjektaPanel.Controls.Add(this.BrisanjeProjektaProfilLinkLabel);
            this.BrisanjeProjektaPanel.Location = new System.Drawing.Point(0, 0);
            this.BrisanjeProjektaPanel.Name = "BrisanjeProjektaPanel";
            this.BrisanjeProjektaPanel.Size = new System.Drawing.Size(1920, 90);
            this.BrisanjeProjektaPanel.TabIndex = 11;
            this.BrisanjeProjektaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DodajProjektProfilPanel_Paint);
            // 
            // BrisanjeProjektaProfilPictureBox
            // 
            this.BrisanjeProjektaProfilPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrisanjeProjektaProfilPictureBox.BackgroundImage")));
            this.BrisanjeProjektaProfilPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrisanjeProjektaProfilPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BrisanjeProjektaProfilPictureBox.Image")));
            this.BrisanjeProjektaProfilPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("BrisanjeProjektaProfilPictureBox.InitialImage")));
            this.BrisanjeProjektaProfilPictureBox.Location = new System.Drawing.Point(1823, 13);
            this.BrisanjeProjektaProfilPictureBox.Name = "BrisanjeProjektaProfilPictureBox";
            this.BrisanjeProjektaProfilPictureBox.Size = new System.Drawing.Size(65, 65);
            this.BrisanjeProjektaProfilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BrisanjeProjektaProfilPictureBox.TabIndex = 27;
            this.BrisanjeProjektaProfilPictureBox.TabStop = false;
            // 
            // BrisanjeProjektaNatragButton
            // 
            this.BrisanjeProjektaNatragButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BrisanjeProjektaNatragButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrisanjeProjektaNatragButton.BackgroundImage")));
            this.BrisanjeProjektaNatragButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrisanjeProjektaNatragButton.Location = new System.Drawing.Point(12, 12);
            this.BrisanjeProjektaNatragButton.Name = "BrisanjeProjektaNatragButton";
            this.BrisanjeProjektaNatragButton.Size = new System.Drawing.Size(64, 64);
            this.BrisanjeProjektaNatragButton.TabIndex = 26;
            this.BrisanjeProjektaNatragButton.UseVisualStyleBackColor = false;
            // 
            // BrisanjeProjektaProfilLinkLabel
            // 
            this.BrisanjeProjektaProfilLinkLabel.AutoSize = true;
            this.BrisanjeProjektaProfilLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.BrisanjeProjektaProfilLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BrisanjeProjektaProfilLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BrisanjeProjektaProfilLinkLabel.Location = new System.Drawing.Point(1651, 31);
            this.BrisanjeProjektaProfilLinkLabel.Name = "BrisanjeProjektaProfilLinkLabel";
            this.BrisanjeProjektaProfilLinkLabel.Size = new System.Drawing.Size(157, 29);
            this.BrisanjeProjektaProfilLinkLabel.TabIndex = 26;
            this.BrisanjeProjektaProfilLinkLabel.TabStop = true;
            this.BrisanjeProjektaProfilLinkLabel.Text = "Sara Bednaić";
            // 
            // BrisanjeProjekta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(BrisanjeProjektaLozinkaTextBox);
            this.Controls.Add(BrisanjeProjektaPonovnoLozinkaTextBox);
            this.Controls.Add(this.BrisanjeProjektaPanel);
            this.Controls.Add(BrisanjeProjektaNaslovLabel);
            this.Controls.Add(this.BrisanjeProjektaIzbrisiProjektButton);
            this.Controls.Add(BrisanjeProjektaPonovnoLozinkaLabel);
            this.Controls.Add(BrisanjeProjektaLozinkaNazivLabel);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1440, 1018);
            this.Name = "BrisanjeProjekta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}