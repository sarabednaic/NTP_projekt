namespace ntp_projekt
{
    partial class UrediProjekt
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
            System.Windows.Forms.Label UrediZadatakNaslovLabel;
            System.Windows.Forms.Label DodajProjektNazivLabel;
            System.Windows.Forms.Label DodajProjektOvlastiLabel;
            System.Windows.Forms.Label DodajProjektClanoviLabel;
            System.Windows.Forms.TextBox DodajProjektNazivTextBox;
            System.Windows.Forms.Label DodajProjektOpisLabel;
            System.Windows.Forms.Button DodajProjektButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrediProjekt));
            this.UrediZadatakSubmitButton = new System.Windows.Forms.Button();
            this.DeaktivacijaProfilPanel = new System.Windows.Forms.Panel();
            this.DeaktivacijaNatragButton = new System.Windows.Forms.Button();
            this.DeaktivacijaProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.DeaktivacijaProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DodajProjektOpisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DodajProjektOvlastiListBox = new System.Windows.Forms.CheckedListBox();
            this.DodajProjektClanoviListBox = new System.Windows.Forms.CheckedListBox();
            UrediZadatakNaslovLabel = new System.Windows.Forms.Label();
            DodajProjektNazivLabel = new System.Windows.Forms.Label();
            DodajProjektOvlastiLabel = new System.Windows.Forms.Label();
            DodajProjektClanoviLabel = new System.Windows.Forms.Label();
            DodajProjektNazivTextBox = new System.Windows.Forms.TextBox();
            DodajProjektOpisLabel = new System.Windows.Forms.Label();
            DodajProjektButton = new System.Windows.Forms.Button();
            this.DeaktivacijaProfilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeaktivacijaProfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UrediZadatakNaslovLabel
            // 
            UrediZadatakNaslovLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            UrediZadatakNaslovLabel.AutoSize = true;
            UrediZadatakNaslovLabel.Font = new System.Drawing.Font("Leelawadee UI", 35F, System.Drawing.FontStyle.Bold);
            UrediZadatakNaslovLabel.Location = new System.Drawing.Point(747, 188);
            UrediZadatakNaslovLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            UrediZadatakNaslovLabel.Name = "UrediZadatakNaslovLabel";
            UrediZadatakNaslovLabel.Size = new System.Drawing.Size(477, 93);
            UrediZadatakNaslovLabel.TabIndex = 13;
            UrediZadatakNaslovLabel.Text = "Uredi projekt";
            UrediZadatakNaslovLabel.Click += new System.EventHandler(this.UrediZadatakNaslovLabel_Click);
            // 
            // DodajProjektNazivLabel
            // 
            DodajProjektNazivLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektNazivLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektNazivLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektNazivLabel.Location = new System.Drawing.Point(608, 290);
            DodajProjektNazivLabel.Name = "DodajProjektNazivLabel";
            DodajProjektNazivLabel.Size = new System.Drawing.Size(287, 43);
            DodajProjektNazivLabel.TabIndex = 56;
            DodajProjektNazivLabel.Text = "Naziv projekta";
            DodajProjektNazivLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajProjektNazivLabel.UseWaitCursor = true;
            // 
            // DodajProjektOvlastiLabel
            // 
            DodajProjektOvlastiLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektOvlastiLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektOvlastiLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektOvlastiLabel.Location = new System.Drawing.Point(608, 716);
            DodajProjektOvlastiLabel.Name = "DodajProjektOvlastiLabel";
            DodajProjektOvlastiLabel.Size = new System.Drawing.Size(453, 43);
            DodajProjektOvlastiLabel.TabIndex = 54;
            DodajProjektOvlastiLabel.Text = "Dodijeli administratorske ovlasti";
            DodajProjektOvlastiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajProjektOvlastiLabel.UseWaitCursor = true;
            // 
            // DodajProjektClanoviLabel
            // 
            DodajProjektClanoviLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektClanoviLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektClanoviLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektClanoviLabel.Location = new System.Drawing.Point(608, 528);
            DodajProjektClanoviLabel.Name = "DodajProjektClanoviLabel";
            DodajProjektClanoviLabel.Size = new System.Drawing.Size(287, 43);
            DodajProjektClanoviLabel.TabIndex = 53;
            DodajProjektClanoviLabel.Text = "Dodijeli članove";
            DodajProjektClanoviLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajProjektClanoviLabel.UseWaitCursor = true;
            // 
            // DodajProjektNazivTextBox
            // 
            DodajProjektNazivTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            DodajProjektNazivTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            DodajProjektNazivTextBox.Location = new System.Drawing.Point(612, 335);
            DodajProjektNazivTextBox.Name = "DodajProjektNazivTextBox";
            DodajProjektNazivTextBox.Size = new System.Drawing.Size(715, 26);
            DodajProjektNazivTextBox.TabIndex = 50;
            // 
            // DodajProjektOpisLabel
            // 
            DodajProjektOpisLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektOpisLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektOpisLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektOpisLabel.Location = new System.Drawing.Point(608, 370);
            DodajProjektOpisLabel.Name = "DodajProjektOpisLabel";
            DodajProjektOpisLabel.Size = new System.Drawing.Size(287, 43);
            DodajProjektOpisLabel.TabIndex = 55;
            DodajProjektOpisLabel.Text = "Opis projekta";
            DodajProjektOpisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajProjektOpisLabel.UseWaitCursor = true;
            // 
            // DodajProjektButton
            // 
            DodajProjektButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            DodajProjektButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            DodajProjektButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            DodajProjektButton.Location = new System.Drawing.Point(857, 914);
            DodajProjektButton.Name = "DodajProjektButton";
            DodajProjektButton.Size = new System.Drawing.Size(220, 60);
            DodajProjektButton.TabIndex = 58;
            DodajProjektButton.Text = "Uredi projekt";
            DodajProjektButton.UseVisualStyleBackColor = false;
            // 
            // UrediZadatakSubmitButton
            // 
            this.UrediZadatakSubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UrediZadatakSubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UrediZadatakSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UrediZadatakSubmitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UrediZadatakSubmitButton.Location = new System.Drawing.Point(880, 758);
            this.UrediZadatakSubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.UrediZadatakSubmitButton.Name = "UrediZadatakSubmitButton";
            this.UrediZadatakSubmitButton.Size = new System.Drawing.Size(214, 62);
            this.UrediZadatakSubmitButton.TabIndex = 28;
            this.UrediZadatakSubmitButton.Text = "Uredi projekt";
            this.UrediZadatakSubmitButton.UseVisualStyleBackColor = false;
            // 
            // DeaktivacijaProfilPanel
            // 
            this.DeaktivacijaProfilPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeaktivacijaProfilPanel.Controls.Add(this.DeaktivacijaNatragButton);
            this.DeaktivacijaProfilPanel.Controls.Add(this.DeaktivacijaProfilPictureBox);
            this.DeaktivacijaProfilPanel.Controls.Add(this.DeaktivacijaProfilLinkLabel);
            this.DeaktivacijaProfilPanel.Location = new System.Drawing.Point(0, 0);
            this.DeaktivacijaProfilPanel.Name = "DeaktivacijaProfilPanel";
            this.DeaktivacijaProfilPanel.Size = new System.Drawing.Size(1920, 90);
            this.DeaktivacijaProfilPanel.TabIndex = 29;
            // 
            // DeaktivacijaNatragButton
            // 
            this.DeaktivacijaNatragButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeaktivacijaNatragButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeaktivacijaNatragButton.BackgroundImage")));
            this.DeaktivacijaNatragButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeaktivacijaNatragButton.Location = new System.Drawing.Point(12, 12);
            this.DeaktivacijaNatragButton.Name = "DeaktivacijaNatragButton";
            this.DeaktivacijaNatragButton.Size = new System.Drawing.Size(64, 64);
            this.DeaktivacijaNatragButton.TabIndex = 23;
            this.DeaktivacijaNatragButton.UseVisualStyleBackColor = false;
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
            // DeaktivacijaProfilLinkLabel
            // 
            this.DeaktivacijaProfilLinkLabel.AutoSize = true;
            this.DeaktivacijaProfilLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeaktivacijaProfilLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeaktivacijaProfilLinkLabel.Location = new System.Drawing.Point(1650, 31);
            this.DeaktivacijaProfilLinkLabel.Name = "DeaktivacijaProfilLinkLabel";
            this.DeaktivacijaProfilLinkLabel.Size = new System.Drawing.Size(157, 29);
            this.DeaktivacijaProfilLinkLabel.TabIndex = 0;
            this.DeaktivacijaProfilLinkLabel.TabStop = true;
            this.DeaktivacijaProfilLinkLabel.Text = "Sara Bednaić";
            // 
            // DodajProjektOpisRichTextBox
            // 
            this.DodajProjektOpisRichTextBox.Location = new System.Drawing.Point(612, 407);
            this.DodajProjektOpisRichTextBox.Name = "DodajProjektOpisRichTextBox";
            this.DodajProjektOpisRichTextBox.Size = new System.Drawing.Size(715, 121);
            this.DodajProjektOpisRichTextBox.TabIndex = 57;
            this.DodajProjektOpisRichTextBox.Text = "";
            // 
            // DodajProjektOvlastiListBox
            // 
            this.DodajProjektOvlastiListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DodajProjektOvlastiListBox.FormattingEnabled = true;
            this.DodajProjektOvlastiListBox.Location = new System.Drawing.Point(612, 756);
            this.DodajProjektOvlastiListBox.Name = "DodajProjektOvlastiListBox";
            this.DodajProjektOvlastiListBox.Size = new System.Drawing.Size(715, 119);
            this.DodajProjektOvlastiListBox.TabIndex = 52;
            // 
            // DodajProjektClanoviListBox
            // 
            this.DodajProjektClanoviListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DodajProjektClanoviListBox.FormattingEnabled = true;
            this.DodajProjektClanoviListBox.Location = new System.Drawing.Point(612, 570);
            this.DodajProjektClanoviListBox.Name = "DodajProjektClanoviListBox";
            this.DodajProjektClanoviListBox.Size = new System.Drawing.Size(715, 142);
            this.DodajProjektClanoviListBox.TabIndex = 51;
            // 
            // UrediProjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(DodajProjektButton);
            this.Controls.Add(this.DodajProjektOpisRichTextBox);
            this.Controls.Add(this.DeaktivacijaProfilPanel);
            this.Controls.Add(this.DodajProjektOvlastiListBox);
            this.Controls.Add(this.UrediZadatakSubmitButton);
            this.Controls.Add(this.DodajProjektClanoviListBox);
            this.Controls.Add(DodajProjektNazivLabel);
            this.Controls.Add(UrediZadatakNaslovLabel);
            this.Controls.Add(DodajProjektOvlastiLabel);
            this.Controls.Add(DodajProjektOpisLabel);
            this.Controls.Add(DodajProjektClanoviLabel);
            this.Controls.Add(DodajProjektNazivTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1086, 826);
            this.Name = "UrediProjekt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DeaktivacijaProfilPanel.ResumeLayout(false);
            this.DeaktivacijaProfilPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeaktivacijaProfilPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UrediZadatakSubmitButton;
        private System.Windows.Forms.Panel DeaktivacijaProfilPanel;
        private System.Windows.Forms.Button DeaktivacijaNatragButton;
        private System.Windows.Forms.PictureBox DeaktivacijaProfilPictureBox;
        private System.Windows.Forms.LinkLabel DeaktivacijaProfilLinkLabel;
        private System.Windows.Forms.RichTextBox DodajProjektOpisRichTextBox;
        private System.Windows.Forms.CheckedListBox DodajProjektOvlastiListBox;
        private System.Windows.Forms.CheckedListBox DodajProjektClanoviListBox;
    }
}