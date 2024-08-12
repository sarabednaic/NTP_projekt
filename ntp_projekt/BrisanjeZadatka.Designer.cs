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
            System.Windows.Forms.TextBox BrisanjeZadatkaLozinkaTextBox;
            System.Windows.Forms.TextBox BrisanjeZadatkaPonovnoLozinkaTextBox;
            System.Windows.Forms.Label BrisanjeZadatkaPonovnoLozinkaLabel;
            System.Windows.Forms.Label BrisanjeZadatkaLozinkaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrisanjeZadatka));
            this.BrisanjeZadatkaIzbrisiZadatakButton = new System.Windows.Forms.Button();
            this.BrisanjeZadatkaNatragButton = new System.Windows.Forms.Button();
            this.BrisanjeZadatkaPanel = new System.Windows.Forms.Panel();
            this.DeaktivacijaProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.BrisanjeZadatkaProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            BriasnjeZadatkaNaslovLabel = new System.Windows.Forms.Label();
            BrisanjeZadatkaLozinkaTextBox = new System.Windows.Forms.TextBox();
            BrisanjeZadatkaPonovnoLozinkaTextBox = new System.Windows.Forms.TextBox();
            BrisanjeZadatkaPonovnoLozinkaLabel = new System.Windows.Forms.Label();
            BrisanjeZadatkaLozinkaLabel = new System.Windows.Forms.Label();
            this.BrisanjeZadatkaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeaktivacijaProfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BriasnjeZadatkaNaslovLabel
            // 
            BriasnjeZadatkaNaslovLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            BriasnjeZadatkaNaslovLabel.Font = new System.Drawing.Font("Leelawadee UI", 40F, System.Drawing.FontStyle.Bold);
            BriasnjeZadatkaNaslovLabel.Location = new System.Drawing.Point(633, 230);
            BriasnjeZadatkaNaslovLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            BriasnjeZadatkaNaslovLabel.MaximumSize = new System.Drawing.Size(683, 114);
            BriasnjeZadatkaNaslovLabel.Name = "BriasnjeZadatkaNaslovLabel";
            BriasnjeZadatkaNaslovLabel.Size = new System.Drawing.Size(683, 114);
            BriasnjeZadatkaNaslovLabel.TabIndex = 10;
            BriasnjeZadatkaNaslovLabel.Text = "Brisanje zadatka";
            BriasnjeZadatkaNaslovLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            BriasnjeZadatkaNaslovLabel.Click += new System.EventHandler(this.BriasnjeProjektaNaslovLabel_Click);
            // 
            // BrisanjeZadatkaLozinkaTextBox
            // 
            BrisanjeZadatkaLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            BrisanjeZadatkaLozinkaTextBox.Location = new System.Drawing.Point(741, 423);
            BrisanjeZadatkaLozinkaTextBox.Name = "BrisanjeZadatkaLozinkaTextBox";
            BrisanjeZadatkaLozinkaTextBox.PasswordChar = '*';
            BrisanjeZadatkaLozinkaTextBox.Size = new System.Drawing.Size(459, 26);
            BrisanjeZadatkaLozinkaTextBox.TabIndex = 64;
            // 
            // BrisanjeZadatkaPonovnoLozinkaTextBox
            // 
            BrisanjeZadatkaPonovnoLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            BrisanjeZadatkaPonovnoLozinkaTextBox.Location = new System.Drawing.Point(741, 500);
            BrisanjeZadatkaPonovnoLozinkaTextBox.Name = "BrisanjeZadatkaPonovnoLozinkaTextBox";
            BrisanjeZadatkaPonovnoLozinkaTextBox.PasswordChar = '*';
            BrisanjeZadatkaPonovnoLozinkaTextBox.Size = new System.Drawing.Size(459, 26);
            BrisanjeZadatkaPonovnoLozinkaTextBox.TabIndex = 63;
            // 
            // BrisanjeZadatkaPonovnoLozinkaLabel
            // 
            BrisanjeZadatkaPonovnoLozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            BrisanjeZadatkaPonovnoLozinkaLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BrisanjeZadatkaPonovnoLozinkaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            BrisanjeZadatkaPonovnoLozinkaLabel.Location = new System.Drawing.Point(737, 468);
            BrisanjeZadatkaPonovnoLozinkaLabel.Name = "BrisanjeZadatkaPonovnoLozinkaLabel";
            BrisanjeZadatkaPonovnoLozinkaLabel.Size = new System.Drawing.Size(287, 43);
            BrisanjeZadatkaPonovnoLozinkaLabel.TabIndex = 62;
            BrisanjeZadatkaPonovnoLozinkaLabel.Text = "Ponovite lozinku za potvrdu brisanja zadatka";
            BrisanjeZadatkaPonovnoLozinkaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BrisanjeZadatkaPonovnoLozinkaLabel.UseWaitCursor = true;
            // 
            // BrisanjeZadatkaLozinkaLabel
            // 
            BrisanjeZadatkaLozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            BrisanjeZadatkaLozinkaLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BrisanjeZadatkaLozinkaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            BrisanjeZadatkaLozinkaLabel.Location = new System.Drawing.Point(737, 387);
            BrisanjeZadatkaLozinkaLabel.Name = "BrisanjeZadatkaLozinkaLabel";
            BrisanjeZadatkaLozinkaLabel.Size = new System.Drawing.Size(287, 43);
            BrisanjeZadatkaLozinkaLabel.TabIndex = 61;
            BrisanjeZadatkaLozinkaLabel.Text = "Upišite lozinku za potvrdu brisanja zadatka";
            BrisanjeZadatkaLozinkaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BrisanjeZadatkaLozinkaLabel.UseWaitCursor = true;
            // 
            // BrisanjeZadatkaIzbrisiZadatakButton
            // 
            this.BrisanjeZadatkaIzbrisiZadatakButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrisanjeZadatkaIzbrisiZadatakButton.BackColor = System.Drawing.Color.Red;
            this.BrisanjeZadatkaIzbrisiZadatakButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BrisanjeZadatkaIzbrisiZadatakButton.ForeColor = System.Drawing.Color.White;
            this.BrisanjeZadatkaIzbrisiZadatakButton.Location = new System.Drawing.Point(860, 602);
            this.BrisanjeZadatkaIzbrisiZadatakButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrisanjeZadatkaIzbrisiZadatakButton.MaximumSize = new System.Drawing.Size(228, 62);
            this.BrisanjeZadatkaIzbrisiZadatakButton.Name = "BrisanjeZadatkaIzbrisiZadatakButton";
            this.BrisanjeZadatkaIzbrisiZadatakButton.Size = new System.Drawing.Size(228, 62);
            this.BrisanjeZadatkaIzbrisiZadatakButton.TabIndex = 13;
            this.BrisanjeZadatkaIzbrisiZadatakButton.Text = "Izbriši zadatak";
            this.BrisanjeZadatkaIzbrisiZadatakButton.UseVisualStyleBackColor = false;
            // 
            // BrisanjeZadatkaNatragButton
            // 
            this.BrisanjeZadatkaNatragButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BrisanjeZadatkaNatragButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrisanjeZadatkaNatragButton.BackgroundImage")));
            this.BrisanjeZadatkaNatragButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrisanjeZadatkaNatragButton.Location = new System.Drawing.Point(12, 12);
            this.BrisanjeZadatkaNatragButton.Name = "BrisanjeZadatkaNatragButton";
            this.BrisanjeZadatkaNatragButton.Size = new System.Drawing.Size(64, 64);
            this.BrisanjeZadatkaNatragButton.TabIndex = 23;
            this.BrisanjeZadatkaNatragButton.UseVisualStyleBackColor = false;
            // 
            // BrisanjeZadatkaPanel
            // 
            this.BrisanjeZadatkaPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BrisanjeZadatkaPanel.Controls.Add(this.BrisanjeZadatkaNatragButton);
            this.BrisanjeZadatkaPanel.Controls.Add(this.DeaktivacijaProfilPictureBox);
            this.BrisanjeZadatkaPanel.Controls.Add(this.BrisanjeZadatkaProfilLinkLabel);
            this.BrisanjeZadatkaPanel.Location = new System.Drawing.Point(0, 0);
            this.BrisanjeZadatkaPanel.Name = "BrisanjeZadatkaPanel";
            this.BrisanjeZadatkaPanel.Size = new System.Drawing.Size(1920, 90);
            this.BrisanjeZadatkaPanel.TabIndex = 14;
            // 
            // DeaktivacijaProfilPictureBox
            // 
            this.DeaktivacijaProfilPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeaktivacijaProfilPictureBox.BackgroundImage")));
            this.DeaktivacijaProfilPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeaktivacijaProfilPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DeaktivacijaProfilPictureBox.Image")));
            this.DeaktivacijaProfilPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("DeaktivacijaProfilPictureBox.InitialImage")));
            this.DeaktivacijaProfilPictureBox.Location = new System.Drawing.Point(1822, 13);
            this.DeaktivacijaProfilPictureBox.Name = "DeaktivacijaProfilPictureBox";
            this.DeaktivacijaProfilPictureBox.Size = new System.Drawing.Size(65, 65);
            this.DeaktivacijaProfilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeaktivacijaProfilPictureBox.TabIndex = 22;
            this.DeaktivacijaProfilPictureBox.TabStop = false;
            // 
            // BrisanjeZadatkaProfilLinkLabel
            // 
            this.BrisanjeZadatkaProfilLinkLabel.AutoSize = true;
            this.BrisanjeZadatkaProfilLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BrisanjeZadatkaProfilLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BrisanjeZadatkaProfilLinkLabel.Location = new System.Drawing.Point(1650, 31);
            this.BrisanjeZadatkaProfilLinkLabel.Name = "BrisanjeZadatkaProfilLinkLabel";
            this.BrisanjeZadatkaProfilLinkLabel.Size = new System.Drawing.Size(157, 29);
            this.BrisanjeZadatkaProfilLinkLabel.TabIndex = 0;
            this.BrisanjeZadatkaProfilLinkLabel.TabStop = true;
            this.BrisanjeZadatkaProfilLinkLabel.Text = "Sara Bednaić";
            // 
            // BrisanjeZadatka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(BrisanjeZadatkaLozinkaTextBox);
            this.Controls.Add(this.BrisanjeZadatkaPanel);
            this.Controls.Add(BrisanjeZadatkaPonovnoLozinkaTextBox);
            this.Controls.Add(this.BrisanjeZadatkaIzbrisiZadatakButton);
            this.Controls.Add(BrisanjeZadatkaPonovnoLozinkaLabel);
            this.Controls.Add(BrisanjeZadatkaLozinkaLabel);
            this.Controls.Add(BriasnjeZadatkaNaslovLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1086, 826);
            this.Name = "BrisanjeZadatka";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BrisanjeZadatkaPanel.ResumeLayout(false);
            this.BrisanjeZadatkaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeaktivacijaProfilPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BrisanjeZadatkaIzbrisiZadatakButton;
        private System.Windows.Forms.Button BrisanjeZadatkaNatragButton;
        private System.Windows.Forms.Panel BrisanjeZadatkaPanel;
        private System.Windows.Forms.PictureBox DeaktivacijaProfilPictureBox;
        private System.Windows.Forms.LinkLabel BrisanjeZadatkaProfilLinkLabel;
    }
}