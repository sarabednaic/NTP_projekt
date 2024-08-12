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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrediProjekt));
            System.Windows.Forms.Label UrediZadatakNaslovLabel;
            this.UrediProjektHeaderButton = new System.Windows.Forms.Button();
            this.UrediProjektArrowButton = new System.Windows.Forms.Button();
            this.UrediProjektUserButton = new System.Windows.Forms.Button();
            this.UrediProjektPFPButton = new System.Windows.Forms.Button();
            this.UrediProjektImeTextBox = new System.Windows.Forms.TextBox();
            this.UrediProjektOpisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.UrediProjektClanoviTextBox = new System.Windows.Forms.TextBox();
            this.UrediProjektAdminiTextBox = new System.Windows.Forms.TextBox();
            this.UrediZadatakSubmitButton = new System.Windows.Forms.Button();
            UrediZadatakNaslovLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UrediProjektHeaderButton
            // 
            this.UrediProjektHeaderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UrediProjektHeaderButton.Enabled = false;
            this.UrediProjektHeaderButton.Location = new System.Drawing.Point(0, 0);
            this.UrediProjektHeaderButton.MaximumSize = new System.Drawing.Size(0, 117);
            this.UrediProjektHeaderButton.MinimumSize = new System.Drawing.Size(0, 117);
            this.UrediProjektHeaderButton.Name = "UrediProjektHeaderButton";
            this.UrediProjektHeaderButton.Size = new System.Drawing.Size(1414, 117);
            this.UrediProjektHeaderButton.TabIndex = 6;
            this.UrediProjektHeaderButton.UseVisualStyleBackColor = true;
            // 
            // UrediProjektArrowButton
            // 
            this.UrediProjektArrowButton.Image = ((System.Drawing.Image)(resources.GetObject("UrediProjektArrowButton.Image")));
            this.UrediProjektArrowButton.Location = new System.Drawing.Point(32, 9);
            this.UrediProjektArrowButton.Name = "UrediProjektArrowButton";
            this.UrediProjektArrowButton.Size = new System.Drawing.Size(118, 95);
            this.UrediProjektArrowButton.TabIndex = 7;
            this.UrediProjektArrowButton.UseVisualStyleBackColor = true;
            this.UrediProjektArrowButton.Click += new System.EventHandler(this.UrediProjektArrowButton_Click);
            // 
            // UrediProjektUserButton
            // 
            this.UrediProjektUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UrediProjektUserButton.Location = new System.Drawing.Point(1097, 33);
            this.UrediProjektUserButton.Name = "UrediProjektUserButton";
            this.UrediProjektUserButton.Size = new System.Drawing.Size(188, 47);
            this.UrediProjektUserButton.TabIndex = 9;
            this.UrediProjektUserButton.Text = "Korisničko ime";
            this.UrediProjektUserButton.UseVisualStyleBackColor = true;
            // 
            // UrediProjektPFPButton
            // 
            this.UrediProjektPFPButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UrediProjektPFPButton.Image = ((System.Drawing.Image)(resources.GetObject("UrediProjektPFPButton.Image")));
            this.UrediProjektPFPButton.Location = new System.Drawing.Point(1291, 14);
            this.UrediProjektPFPButton.Name = "UrediProjektPFPButton";
            this.UrediProjektPFPButton.Size = new System.Drawing.Size(88, 88);
            this.UrediProjektPFPButton.TabIndex = 10;
            this.UrediProjektPFPButton.UseVisualStyleBackColor = true;
            // 
            // UrediZadatakNaslovLabel
            // 
            UrediZadatakNaslovLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            UrediZadatakNaslovLabel.AutoSize = true;
            UrediZadatakNaslovLabel.Font = new System.Drawing.Font("Leelawadee UI", 35F, System.Drawing.FontStyle.Bold);
            UrediZadatakNaslovLabel.Location = new System.Drawing.Point(996, 235);
            UrediZadatakNaslovLabel.Name = "UrediZadatakNaslovLabel";
            UrediZadatakNaslovLabel.Size = new System.Drawing.Size(640, 125);
            UrediZadatakNaslovLabel.TabIndex = 13;
            UrediZadatakNaslovLabel.Text = "Uredi projekt";
            UrediZadatakNaslovLabel.Click += new System.EventHandler(this.UrediZadatakNaslovLabel_Click);
            // 
            // DodajProjektNazivLabel
            // 
            DodajProjektNazivLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektNazivLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektNazivLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektNazivLabel.Location = new System.Drawing.Point(811, 362);
            DodajProjektNazivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajProjektNazivLabel.Name = "DodajProjektNazivLabel";
            DodajProjektNazivLabel.Size = new System.Drawing.Size(383, 54);
            DodajProjektNazivLabel.TabIndex = 56;
            DodajProjektNazivLabel.Text = "Naziv projekta";
            DodajProjektNazivLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajProjektNazivLabel.UseWaitCursor = true;
            // 
            this.UrediProjektImeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UrediProjektImeTextBox.Location = new System.Drawing.Point(294, 280);
            this.UrediProjektImeTextBox.Name = "UrediProjektImeTextBox";
            this.UrediProjektImeTextBox.Size = new System.Drawing.Size(827, 31);
            this.UrediProjektImeTextBox.TabIndex = 14;
            // 
            DodajProjektOvlastiLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektOvlastiLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektOvlastiLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektOvlastiLabel.Location = new System.Drawing.Point(811, 895);
            DodajProjektOvlastiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajProjektOvlastiLabel.Name = "DodajProjektOvlastiLabel";
            DodajProjektOvlastiLabel.Size = new System.Drawing.Size(604, 54);
            DodajProjektOvlastiLabel.TabIndex = 54;
            DodajProjektOvlastiLabel.Text = "Dodijeli administratorske ovlasti";
            DodajProjektOvlastiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajProjektOvlastiLabel.UseWaitCursor = true;
            // 
            this.UrediProjektOpisRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UrediProjektOpisRichTextBox.Location = new System.Drawing.Point(294, 344);
            this.UrediProjektOpisRichTextBox.Name = "UrediProjektOpisRichTextBox";
            this.UrediProjektOpisRichTextBox.Size = new System.Drawing.Size(827, 223);
            this.UrediProjektOpisRichTextBox.TabIndex = 25;
            this.UrediProjektOpisRichTextBox.Text = "";
            // 
            DodajProjektClanoviLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektClanoviLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektClanoviLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektClanoviLabel.Location = new System.Drawing.Point(811, 660);
            DodajProjektClanoviLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajProjektClanoviLabel.Name = "DodajProjektClanoviLabel";
            DodajProjektClanoviLabel.Size = new System.Drawing.Size(383, 54);
            DodajProjektClanoviLabel.TabIndex = 53;
            DodajProjektClanoviLabel.Text = "Dodijeli članove";
            DodajProjektClanoviLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajProjektClanoviLabel.UseWaitCursor = true;
            // 
            this.UrediProjektClanoviTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UrediProjektClanoviTextBox.Location = new System.Drawing.Point(294, 601);
            this.UrediProjektClanoviTextBox.Name = "UrediProjektClanoviTextBox";
            this.UrediProjektClanoviTextBox.Size = new System.Drawing.Size(827, 31);
            this.UrediProjektClanoviTextBox.TabIndex = 26;
            // 
            DodajProjektNazivTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            DodajProjektNazivTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            DodajProjektNazivTextBox.Location = new System.Drawing.Point(816, 419);
            DodajProjektNazivTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            DodajProjektNazivTextBox.Name = "DodajProjektNazivTextBox";
            DodajProjektNazivTextBox.Size = new System.Drawing.Size(952, 31);
            DodajProjektNazivTextBox.TabIndex = 50;
            // 
            this.UrediProjektAdminiTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UrediProjektAdminiTextBox.Location = new System.Drawing.Point(294, 669);
            this.UrediProjektAdminiTextBox.Name = "UrediProjektAdminiTextBox";
            this.UrediProjektAdminiTextBox.Size = new System.Drawing.Size(827, 31);
            this.UrediProjektAdminiTextBox.TabIndex = 27;
            // 
            DodajProjektOpisLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektOpisLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektOpisLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektOpisLabel.Location = new System.Drawing.Point(811, 462);
            DodajProjektOpisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajProjektOpisLabel.Name = "DodajProjektOpisLabel";
            DodajProjektOpisLabel.Size = new System.Drawing.Size(383, 54);
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
            DodajProjektButton.Location = new System.Drawing.Point(1143, 1142);
            DodajProjektButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            DodajProjektButton.Name = "DodajProjektButton";
            DodajProjektButton.Size = new System.Drawing.Size(293, 75);
            DodajProjektButton.TabIndex = 58;
            DodajProjektButton.Text = "Uredi projekt";
            DodajProjektButton.UseVisualStyleBackColor = false;
            DodajProjektButton.Click += new System.EventHandler(this.DodajProjektButton_Click);
            // 
            // UrediZadatakSubmitButton
            // 
            this.UrediZadatakSubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UrediZadatakSubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UrediZadatakSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UrediZadatakSubmitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UrediZadatakSubmitButton.Location = new System.Drawing.Point(1173, 948);
            this.UrediZadatakSubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UrediZadatakSubmitButton.Name = "UrediZadatakSubmitButton";
            this.UrediZadatakSubmitButton.Size = new System.Drawing.Size(285, 78);
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
            this.DeaktivacijaProfilPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeaktivacijaProfilPanel.Name = "DeaktivacijaProfilPanel";
            this.DeaktivacijaProfilPanel.Size = new System.Drawing.Size(2560, 112);
            this.DeaktivacijaProfilPanel.TabIndex = 29;
            // 
            // DeaktivacijaNatragButton
            // 
            this.DeaktivacijaNatragButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeaktivacijaNatragButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeaktivacijaNatragButton.BackgroundImage")));
            this.DeaktivacijaNatragButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeaktivacijaNatragButton.Location = new System.Drawing.Point(16, 15);
            this.DeaktivacijaNatragButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeaktivacijaNatragButton.Name = "DeaktivacijaNatragButton";
            this.DeaktivacijaNatragButton.Size = new System.Drawing.Size(85, 80);
            this.DeaktivacijaNatragButton.TabIndex = 23;
            this.DeaktivacijaNatragButton.UseVisualStyleBackColor = false;
            this.DeaktivacijaNatragButton.Click += new System.EventHandler(this.DeaktivacijaNatragButton_Click);
            // 
            // DeaktivacijaProfilPictureBox
            // 
            this.DeaktivacijaProfilPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeaktivacijaProfilPictureBox.BackgroundImage")));
            this.DeaktivacijaProfilPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeaktivacijaProfilPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DeaktivacijaProfilPictureBox.Image")));
            this.DeaktivacijaProfilPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("DeaktivacijaProfilPictureBox.InitialImage")));
            this.DeaktivacijaProfilPictureBox.Location = new System.Drawing.Point(2429, 16);
            this.DeaktivacijaProfilPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeaktivacijaProfilPictureBox.Name = "DeaktivacijaProfilPictureBox";
            this.DeaktivacijaProfilPictureBox.Size = new System.Drawing.Size(87, 81);
            this.DeaktivacijaProfilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeaktivacijaProfilPictureBox.TabIndex = 22;
            this.DeaktivacijaProfilPictureBox.TabStop = false;
            this.DeaktivacijaProfilPictureBox.Click += new System.EventHandler(this.DeaktivacijaProfilPictureBox_Click);
            // 
            // DeaktivacijaProfilLinkLabel
            // 
            this.DeaktivacijaProfilLinkLabel.AutoSize = true;
            this.DeaktivacijaProfilLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeaktivacijaProfilLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeaktivacijaProfilLinkLabel.Location = new System.Drawing.Point(2200, 39);
            this.DeaktivacijaProfilLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeaktivacijaProfilLinkLabel.Name = "DeaktivacijaProfilLinkLabel";
            this.DeaktivacijaProfilLinkLabel.Size = new System.Drawing.Size(209, 37);
            this.DeaktivacijaProfilLinkLabel.TabIndex = 0;
            this.DeaktivacijaProfilLinkLabel.TabStop = true;
            this.DeaktivacijaProfilLinkLabel.Text = "Sara Bednaić";
            this.DeaktivacijaProfilLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeaktivacijaProfilLinkLabel_LinkClicked);
            // 
            // DodajProjektOpisRichTextBox
            // 
            this.DodajProjektOpisRichTextBox.Location = new System.Drawing.Point(816, 509);
            this.DodajProjektOpisRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajProjektOpisRichTextBox.Name = "DodajProjektOpisRichTextBox";
            this.DodajProjektOpisRichTextBox.Size = new System.Drawing.Size(952, 150);
            this.DodajProjektOpisRichTextBox.TabIndex = 57;
            this.DodajProjektOpisRichTextBox.Text = "";
            // 
            // DodajProjektOvlastiListBox
            // 
            this.DodajProjektOvlastiListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DodajProjektOvlastiListBox.FormattingEnabled = true;
            this.DodajProjektOvlastiListBox.Location = new System.Drawing.Point(816, 945);
            this.DodajProjektOvlastiListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajProjektOvlastiListBox.Name = "DodajProjektOvlastiListBox";
            this.DodajProjektOvlastiListBox.Size = new System.Drawing.Size(952, 144);
            this.DodajProjektOvlastiListBox.TabIndex = 52;
            // 
            // DodajProjektClanoviListBox
            // 
            this.DodajProjektClanoviListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DodajProjektClanoviListBox.FormattingEnabled = true;
            this.DodajProjektClanoviListBox.Location = new System.Drawing.Point(816, 712);
            this.DodajProjektClanoviListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajProjektClanoviListBox.Name = "DodajProjektClanoviListBox";
            this.DodajProjektClanoviListBox.Size = new System.Drawing.Size(952, 172);
            this.DodajProjektClanoviListBox.TabIndex = 51;
            // 
            // UrediProjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2525, 1261);
            this.Controls.Add(DodajProjektButton);
            this.Controls.Add(this.DodajProjektOpisRichTextBox);
            this.Controls.Add(this.DeaktivacijaProfilPanel);
            this.Controls.Add(this.DodajProjektOvlastiListBox);
            this.Controls.Add(this.UrediZadatakSubmitButton);
            this.Controls.Add(this.UrediProjektAdminiTextBox);
            this.Controls.Add(this.UrediProjektClanoviTextBox);
            this.Controls.Add(this.UrediProjektOpisRichTextBox);
            this.Controls.Add(this.UrediProjektImeTextBox);
            this.Controls.Add(UrediZadatakNaslovLabel);
            this.Controls.Add(DodajProjektOvlastiLabel);
            this.Controls.Add(DodajProjektOpisLabel);
            this.Controls.Add(DodajProjektClanoviLabel);
            this.Controls.Add(DodajProjektNazivTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2551, 1332);
            this.MinimumSize = new System.Drawing.Size(1439, 1015);
            this.Name = "UrediProjekt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UrediProjektHeaderButton;
        private System.Windows.Forms.Button UrediProjektArrowButton;
        private System.Windows.Forms.Button UrediProjektUserButton;
        private System.Windows.Forms.Button UrediProjektPFPButton;
        private System.Windows.Forms.TextBox UrediProjektImeTextBox;
        private System.Windows.Forms.RichTextBox UrediProjektOpisRichTextBox;
        private System.Windows.Forms.TextBox UrediProjektClanoviTextBox;
        private System.Windows.Forms.TextBox UrediProjektAdminiTextBox;
        private System.Windows.Forms.Button UrediZadatakSubmitButton;
    }
}