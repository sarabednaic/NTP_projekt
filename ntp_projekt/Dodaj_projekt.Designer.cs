namespace ntp_projekt
{
    partial class DodajProjekt
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
            System.Windows.Forms.Label DodajProjektNaslovLabel;
            System.Windows.Forms.TextBox DodajProjektNazivTextBox;
            System.Windows.Forms.Button DodajProjektButton;
            System.Windows.Forms.Label DodajProjektClanoviLabel;
            System.Windows.Forms.Label DodajProjektOvlastiLabel;
            System.Windows.Forms.Label DodajProjektOpisLabel;
            System.Windows.Forms.Label DodajProjektNazivLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajProjekt));
            this.DodajProjektClanoviListBox = new System.Windows.Forms.CheckedListBox();
            this.DodajProjektOvlastiListBox = new System.Windows.Forms.CheckedListBox();
            this.DodajProjektProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DodajProjektNatragButton = new System.Windows.Forms.Button();
            this.DodajProjektProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.DodajProjektProfilPanel = new System.Windows.Forms.Panel();
            this.DodajProjektOpisRichTextBox = new System.Windows.Forms.RichTextBox();
            DodajProjektNaslovLabel = new System.Windows.Forms.Label();
            DodajProjektNazivTextBox = new System.Windows.Forms.TextBox();
            DodajProjektButton = new System.Windows.Forms.Button();
            DodajProjektClanoviLabel = new System.Windows.Forms.Label();
            DodajProjektOvlastiLabel = new System.Windows.Forms.Label();
            DodajProjektOpisLabel = new System.Windows.Forms.Label();
            DodajProjektNazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DodajProjektProfilPictureBox)).BeginInit();
            this.DodajProjektProfilPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DodajProjektNaslovLabel
            // 
            DodajProjektNaslovLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektNaslovLabel.Location = new System.Drawing.Point(955, 208);
            DodajProjektNaslovLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajProjektNaslovLabel.Name = "DodajProjektNaslovLabel";
            DodajProjektNaslovLabel.Size = new System.Drawing.Size(808, 104);
            DodajProjektNaslovLabel.TabIndex = 11;
            DodajProjektNaslovLabel.Text = "Dodaj novi projekt";
            // 
            // DodajProjektNazivTextBox
            // 
            DodajProjektNazivTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            DodajProjektNazivTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            DodajProjektNazivTextBox.Location = new System.Drawing.Point(840, 376);
            DodajProjektNazivTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            DodajProjektNazivTextBox.Name = "DodajProjektNazivTextBox";
            DodajProjektNazivTextBox.Size = new System.Drawing.Size(952, 31);
            DodajProjektNazivTextBox.TabIndex = 12;
            // 
            // DodajProjektButton
            // 
            DodajProjektButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            DodajProjektButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            DodajProjektButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            DodajProjektButton.Location = new System.Drawing.Point(1191, 1118);
            DodajProjektButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            DodajProjektButton.Name = "DodajProjektButton";
            DodajProjektButton.Size = new System.Drawing.Size(293, 75);
            DodajProjektButton.TabIndex = 16;
            DodajProjektButton.Text = "Dodaj projekt";
            DodajProjektButton.UseVisualStyleBackColor = false;
            DodajProjektButton.Click += new System.EventHandler(this.DodajProjektButton_Click);
            // 
            // DodajProjektClanoviLabel
            // 
            DodajProjektClanoviLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektClanoviLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektClanoviLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektClanoviLabel.Location = new System.Drawing.Point(835, 618);
            DodajProjektClanoviLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajProjektClanoviLabel.Name = "DodajProjektClanoviLabel";
            DodajProjektClanoviLabel.Size = new System.Drawing.Size(383, 54);
            DodajProjektClanoviLabel.TabIndex = 24;
            DodajProjektClanoviLabel.Text = "Dodijeli članove";
            DodajProjektClanoviLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajProjektClanoviLabel.UseWaitCursor = true;
            // 
            // DodajProjektOvlastiLabel
            // 
            DodajProjektOvlastiLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektOvlastiLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektOvlastiLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektOvlastiLabel.Location = new System.Drawing.Point(835, 852);
            DodajProjektOvlastiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajProjektOvlastiLabel.Name = "DodajProjektOvlastiLabel";
            DodajProjektOvlastiLabel.Size = new System.Drawing.Size(604, 54);
            DodajProjektOvlastiLabel.TabIndex = 25;
            DodajProjektOvlastiLabel.Text = "Dodijeli administratorske ovlasti";
            DodajProjektOvlastiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajProjektOvlastiLabel.UseWaitCursor = true;
            // 
            // DodajProjektOpisLabel
            // 
            DodajProjektOpisLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektOpisLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektOpisLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektOpisLabel.Location = new System.Drawing.Point(835, 420);
            DodajProjektOpisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajProjektOpisLabel.Name = "DodajProjektOpisLabel";
            DodajProjektOpisLabel.Size = new System.Drawing.Size(383, 54);
            DodajProjektOpisLabel.TabIndex = 26;
            DodajProjektOpisLabel.Text = "Opis projekta";
            DodajProjektOpisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajProjektOpisLabel.UseWaitCursor = true;
            // 
            // DodajProjektNazivLabel
            // 
            DodajProjektNazivLabel.BackColor = System.Drawing.Color.Transparent;
            DodajProjektNazivLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajProjektNazivLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajProjektNazivLabel.Location = new System.Drawing.Point(835, 320);
            DodajProjektNazivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajProjektNazivLabel.Name = "DodajProjektNazivLabel";
            DodajProjektNazivLabel.Size = new System.Drawing.Size(383, 54);
            DodajProjektNazivLabel.TabIndex = 27;
            DodajProjektNazivLabel.Text = "Naziv projekta";
            DodajProjektNazivLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajProjektNazivLabel.UseWaitCursor = true;
            // 
            // DodajProjektClanoviListBox
            // 
            this.DodajProjektClanoviListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DodajProjektClanoviListBox.FormattingEnabled = true;
            this.DodajProjektClanoviListBox.Location = new System.Drawing.Point(840, 670);
            this.DodajProjektClanoviListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajProjektClanoviListBox.Name = "DodajProjektClanoviListBox";
            this.DodajProjektClanoviListBox.Size = new System.Drawing.Size(952, 172);
            this.DodajProjektClanoviListBox.TabIndex = 14;
            this.DodajProjektClanoviListBox.SelectedIndexChanged += new System.EventHandler(this.DodajProjektClanoviListBox_SelectedIndexChanged);
            // 
            // DodajProjektOvlastiListBox
            // 
            this.DodajProjektOvlastiListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DodajProjektOvlastiListBox.FormattingEnabled = true;
            this.DodajProjektOvlastiListBox.Location = new System.Drawing.Point(840, 902);
            this.DodajProjektOvlastiListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajProjektOvlastiListBox.Name = "DodajProjektOvlastiListBox";
            this.DodajProjektOvlastiListBox.Size = new System.Drawing.Size(952, 144);
            this.DodajProjektOvlastiListBox.TabIndex = 15;
            this.DodajProjektOvlastiListBox.SelectedIndexChanged += new System.EventHandler(this.DodajProjektOvlastiListBox_SelectedIndexChanged);
            // 
            // DodajProjektProfilLinkLabel
            // 
            this.DodajProjektProfilLinkLabel.AutoSize = true;
            this.DodajProjektProfilLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.DodajProjektProfilLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DodajProjektProfilLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DodajProjektProfilLinkLabel.Location = new System.Drawing.Point(2201, 39);
            this.DodajProjektProfilLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DodajProjektProfilLinkLabel.Name = "DodajProjektProfilLinkLabel";
            this.DodajProjektProfilLinkLabel.Size = new System.Drawing.Size(209, 37);
            this.DodajProjektProfilLinkLabel.TabIndex = 26;
            this.DodajProjektProfilLinkLabel.TabStop = true;
            this.DodajProjektProfilLinkLabel.Text = "Sara Bednaić";
            this.DodajProjektProfilLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DodajProjektProfilLinkLabel_LinkClicked);
            // 
            // DodajProjektNatragButton
            // 
            this.DodajProjektNatragButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DodajProjektNatragButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DodajProjektNatragButton.BackgroundImage")));
            this.DodajProjektNatragButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DodajProjektNatragButton.Location = new System.Drawing.Point(16, 15);
            this.DodajProjektNatragButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajProjektNatragButton.Name = "DodajProjektNatragButton";
            this.DodajProjektNatragButton.Size = new System.Drawing.Size(85, 80);
            this.DodajProjektNatragButton.TabIndex = 26;
            this.DodajProjektNatragButton.UseVisualStyleBackColor = false;
            this.DodajProjektNatragButton.Click += new System.EventHandler(this.DodajProjektNatragButton_Click);
            // 
            // DodajProjektProfilPictureBox
            // 
            this.DodajProjektProfilPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DodajProjektProfilPictureBox.BackgroundImage")));
            this.DodajProjektProfilPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DodajProjektProfilPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DodajProjektProfilPictureBox.Image")));
            this.DodajProjektProfilPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("DodajProjektProfilPictureBox.InitialImage")));
            this.DodajProjektProfilPictureBox.Location = new System.Drawing.Point(2431, 16);
            this.DodajProjektProfilPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajProjektProfilPictureBox.Name = "DodajProjektProfilPictureBox";
            this.DodajProjektProfilPictureBox.Size = new System.Drawing.Size(87, 81);
            this.DodajProjektProfilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DodajProjektProfilPictureBox.TabIndex = 27;
            this.DodajProjektProfilPictureBox.TabStop = false;
            this.DodajProjektProfilPictureBox.Click += new System.EventHandler(this.DodajProjektProfilPictureBox_Click);
            // 
            // DodajProjektProfilPanel
            // 
            this.DodajProjektProfilPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DodajProjektProfilPanel.Controls.Add(this.DodajProjektProfilPictureBox);
            this.DodajProjektProfilPanel.Controls.Add(this.DodajProjektNatragButton);
            this.DodajProjektProfilPanel.Controls.Add(this.DodajProjektProfilLinkLabel);
            this.DodajProjektProfilPanel.Location = new System.Drawing.Point(0, 0);
            this.DodajProjektProfilPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajProjektProfilPanel.Name = "DodajProjektProfilPanel";
            this.DodajProjektProfilPanel.Size = new System.Drawing.Size(2560, 112);
            this.DodajProjektProfilPanel.TabIndex = 10;
            // 
            // DodajProjektOpisRichTextBox
            // 
            this.DodajProjektOpisRichTextBox.Location = new System.Drawing.Point(840, 466);
            this.DodajProjektOpisRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajProjektOpisRichTextBox.Name = "DodajProjektOpisRichTextBox";
            this.DodajProjektOpisRichTextBox.Size = new System.Drawing.Size(952, 150);
            this.DodajProjektOpisRichTextBox.TabIndex = 49;
            this.DodajProjektOpisRichTextBox.Text = "";
            // 
            // DodajProjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2525, 1261);
            this.Controls.Add(this.DodajProjektOpisRichTextBox);
            this.Controls.Add(this.DodajProjektOvlastiListBox);
            this.Controls.Add(this.DodajProjektClanoviListBox);
            this.Controls.Add(DodajProjektNazivLabel);
            this.Controls.Add(DodajProjektOvlastiLabel);
            this.Controls.Add(DodajProjektClanoviLabel);
            this.Controls.Add(DodajProjektButton);
            this.Controls.Add(DodajProjektNazivTextBox);
            this.Controls.Add(DodajProjektNaslovLabel);
            this.Controls.Add(this.DodajProjektProfilPanel);
            this.Controls.Add(DodajProjektOpisLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(2551, 1332);
            this.MinimumSize = new System.Drawing.Size(1911, 1255);
            this.Name = "DodajProjekt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DodajProjekt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DodajProjektProfilPictureBox)).EndInit();
            this.DodajProjektProfilPanel.ResumeLayout(false);
            this.DodajProjektProfilPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox DodajProjektClanoviListBox;
        private System.Windows.Forms.CheckedListBox DodajProjektOvlastiListBox;
        private System.Windows.Forms.LinkLabel DodajProjektProfilLinkLabel;
        private System.Windows.Forms.Button DodajProjektNatragButton;
        private System.Windows.Forms.PictureBox DodajProjektProfilPictureBox;
        private System.Windows.Forms.Panel DodajProjektProfilPanel;
        private System.Windows.Forms.RichTextBox DodajProjektOpisRichTextBox;
    }
}