namespace ntp_projekt
{
    partial class DodajZadatak
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
            System.Windows.Forms.Label DodajZadatakVrijemeLabel;
            System.Windows.Forms.Label DodajZadatakClanoviLabel;
            System.Windows.Forms.TextBox DodajZadatakNazivTextBox;
            System.Windows.Forms.Label DodajZadatakNaslovLabel;
            System.Windows.Forms.Label DodajZadatakOdDoLabel;
            System.Windows.Forms.Button DodajZadatakButton;
            System.Windows.Forms.Label DodajZadatakStatusLabel;
            System.Windows.Forms.Label DodajZadatakProjektLabel;
            System.Windows.Forms.Label DodajZadatakNazivLabel;
            System.Windows.Forms.Label DodajZadatakOpisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajZadatak));
            this.DodajZadatakClanoviListBox = new System.Windows.Forms.CheckedListBox();
            this.DodajZadatakProfilPanel = new System.Windows.Forms.Panel();
            this.DodajZadatakProjektComboBox = new System.Windows.Forms.ComboBox();
            this.DodajZadatakDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DodajZadatakDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DodajZadatakProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.DodajZadatakNatragButton = new System.Windows.Forms.Button();
            this.DodajZadatakProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DodajZadatakOpisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DodajZadatakStatusButton = new System.Windows.Forms.Button();
            this.DodajZadatakStatusComboBox = new System.Windows.Forms.ComboBox();
            DodajZadatakVrijemeLabel = new System.Windows.Forms.Label();
            DodajZadatakClanoviLabel = new System.Windows.Forms.Label();
            DodajZadatakNazivTextBox = new System.Windows.Forms.TextBox();
            DodajZadatakNaslovLabel = new System.Windows.Forms.Label();
            DodajZadatakOdDoLabel = new System.Windows.Forms.Label();
            DodajZadatakButton = new System.Windows.Forms.Button();
            DodajZadatakStatusLabel = new System.Windows.Forms.Label();
            DodajZadatakProjektLabel = new System.Windows.Forms.Label();
            DodajZadatakNazivLabel = new System.Windows.Forms.Label();
            DodajZadatakOpisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DodajZadatakProfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DodajZadatakVrijemeLabel
            // 
            DodajZadatakVrijemeLabel.BackColor = System.Drawing.Color.Transparent;
            DodajZadatakVrijemeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajZadatakVrijemeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajZadatakVrijemeLabel.Location = new System.Drawing.Point(627, 733);
            DodajZadatakVrijemeLabel.Name = "DodajZadatakVrijemeLabel";
            DodajZadatakVrijemeLabel.Size = new System.Drawing.Size(453, 43);
            DodajZadatakVrijemeLabel.TabIndex = 33;
            DodajZadatakVrijemeLabel.Text = "Vrijeme ";
            DodajZadatakVrijemeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajZadatakVrijemeLabel.UseWaitCursor = true;
            // 
            // DodajZadatakClanoviLabel
            // 
            DodajZadatakClanoviLabel.BackColor = System.Drawing.Color.Transparent;
            DodajZadatakClanoviLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajZadatakClanoviLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajZadatakClanoviLabel.Location = new System.Drawing.Point(627, 576);
            DodajZadatakClanoviLabel.Name = "DodajZadatakClanoviLabel";
            DodajZadatakClanoviLabel.Size = new System.Drawing.Size(287, 43);
            DodajZadatakClanoviLabel.TabIndex = 32;
            DodajZadatakClanoviLabel.Text = "Dodijeli zadatak članovima tima";
            DodajZadatakClanoviLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajZadatakClanoviLabel.UseWaitCursor = true;
            // 
            // DodajZadatakNazivTextBox
            // 
            DodajZadatakNazivTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            DodajZadatakNazivTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            DodajZadatakNazivTextBox.Location = new System.Drawing.Point(631, 353);
            DodajZadatakNazivTextBox.Name = "DodajZadatakNazivTextBox";
            DodajZadatakNazivTextBox.Size = new System.Drawing.Size(715, 26);
            DodajZadatakNazivTextBox.TabIndex = 29;
            // 
            // DodajZadatakNaslovLabel
            // 
            DodajZadatakNaslovLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajZadatakNaslovLabel.Location = new System.Drawing.Point(568, 141);
            DodajZadatakNaslovLabel.Name = "DodajZadatakNaslovLabel";
            DodajZadatakNaslovLabel.Size = new System.Drawing.Size(874, 120);
            DodajZadatakNaslovLabel.TabIndex = 27;
            DodajZadatakNaslovLabel.Text = "Dodaj novi projektni zadatak";
            // 
            // DodajZadatakOdDoLabel
            // 
            DodajZadatakOdDoLabel.BackColor = System.Drawing.Color.Transparent;
            DodajZadatakOdDoLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            DodajZadatakOdDoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajZadatakOdDoLabel.Location = new System.Drawing.Point(833, 750);
            DodajZadatakOdDoLabel.Name = "DodajZadatakOdDoLabel";
            DodajZadatakOdDoLabel.Size = new System.Drawing.Size(65, 45);
            DodajZadatakOdDoLabel.TabIndex = 39;
            DodajZadatakOdDoLabel.Text = "_";
            DodajZadatakOdDoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            DodajZadatakOdDoLabel.UseWaitCursor = true;
            DodajZadatakOdDoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DodajZadatakButton
            // 
            DodajZadatakButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            DodajZadatakButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            DodajZadatakButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            DodajZadatakButton.Location = new System.Drawing.Point(874, 917);
            DodajZadatakButton.Name = "DodajZadatakButton";
            DodajZadatakButton.Size = new System.Drawing.Size(220, 60);
            DodajZadatakButton.TabIndex = 40;
            DodajZadatakButton.Text = "Dodaj projektni zadatak";
            DodajZadatakButton.UseVisualStyleBackColor = false;
            // 
            // DodajZadatakStatusLabel
            // 
            DodajZadatakStatusLabel.BackColor = System.Drawing.Color.Transparent;
            DodajZadatakStatusLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajZadatakStatusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajZadatakStatusLabel.Location = new System.Drawing.Point(627, 816);
            DodajZadatakStatusLabel.Name = "DodajZadatakStatusLabel";
            DodajZadatakStatusLabel.Size = new System.Drawing.Size(453, 43);
            DodajZadatakStatusLabel.TabIndex = 44;
            DodajZadatakStatusLabel.Text = "Status";
            DodajZadatakStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajZadatakStatusLabel.UseWaitCursor = true;
            // 
            // DodajZadatakProjektLabel
            // 
            DodajZadatakProjektLabel.BackColor = System.Drawing.Color.Transparent;
            DodajZadatakProjektLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajZadatakProjektLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajZadatakProjektLabel.Location = new System.Drawing.Point(627, 233);
            DodajZadatakProjektLabel.Name = "DodajZadatakProjektLabel";
            DodajZadatakProjektLabel.Size = new System.Drawing.Size(453, 43);
            DodajZadatakProjektLabel.TabIndex = 45;
            DodajZadatakProjektLabel.Text = "Dodijeli zadatak projektu";
            DodajZadatakProjektLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajZadatakProjektLabel.UseWaitCursor = true;
            // 
            // DodajZadatakNazivLabel
            // 
            DodajZadatakNazivLabel.BackColor = System.Drawing.Color.Transparent;
            DodajZadatakNazivLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajZadatakNazivLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajZadatakNazivLabel.Location = new System.Drawing.Point(627, 309);
            DodajZadatakNazivLabel.Name = "DodajZadatakNazivLabel";
            DodajZadatakNazivLabel.Size = new System.Drawing.Size(453, 43);
            DodajZadatakNazivLabel.TabIndex = 46;
            DodajZadatakNazivLabel.Text = "Naziv zadatka";
            DodajZadatakNazivLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajZadatakNazivLabel.UseWaitCursor = true;
            // 
            // DodajZadatakOpisLabel
            // 
            DodajZadatakOpisLabel.BackColor = System.Drawing.Color.Transparent;
            DodajZadatakOpisLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajZadatakOpisLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajZadatakOpisLabel.Location = new System.Drawing.Point(627, 389);
            DodajZadatakOpisLabel.Name = "DodajZadatakOpisLabel";
            DodajZadatakOpisLabel.Size = new System.Drawing.Size(453, 43);
            DodajZadatakOpisLabel.TabIndex = 47;
            DodajZadatakOpisLabel.Text = "Opis zadatka";
            DodajZadatakOpisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajZadatakOpisLabel.UseWaitCursor = true;
            // 
            // DodajZadatakClanoviListBox
            // 
            this.DodajZadatakClanoviListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DodajZadatakClanoviListBox.FormattingEnabled = true;
            this.DodajZadatakClanoviListBox.Location = new System.Drawing.Point(631, 610);
            this.DodajZadatakClanoviListBox.Name = "DodajZadatakClanoviListBox";
            this.DodajZadatakClanoviListBox.Size = new System.Drawing.Size(715, 119);
            this.DodajZadatakClanoviListBox.TabIndex = 30;
            // 
            // DodajZadatakProfilPanel
            // 
            this.DodajZadatakProfilPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DodajZadatakProfilPanel.Location = new System.Drawing.Point(0, 0);
            this.DodajZadatakProfilPanel.Name = "DodajZadatakProfilPanel";
            this.DodajZadatakProfilPanel.Size = new System.Drawing.Size(1920, 90);
            this.DodajZadatakProfilPanel.TabIndex = 26;
            // 
            // DodajZadatakProjektComboBox
            // 
            this.DodajZadatakProjektComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DodajZadatakProjektComboBox.FormattingEnabled = true;
            this.DodajZadatakProjektComboBox.Location = new System.Drawing.Point(631, 276);
            this.DodajZadatakProjektComboBox.Name = "DodajZadatakProjektComboBox";
            this.DodajZadatakProjektComboBox.Size = new System.Drawing.Size(715, 28);
            this.DodajZadatakProjektComboBox.TabIndex = 34;
            // 
            // DodajZadatakDateTimePicker1
            // 
            this.DodajZadatakDateTimePicker1.Location = new System.Drawing.Point(631, 779);
            this.DodajZadatakDateTimePicker1.Name = "DodajZadatakDateTimePicker1";
            this.DodajZadatakDateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.DodajZadatakDateTimePicker1.TabIndex = 37;
            // 
            // DodajZadatakDateTimePicker2
            // 
            this.DodajZadatakDateTimePicker2.Location = new System.Drawing.Point(894, 779);
            this.DodajZadatakDateTimePicker2.Name = "DodajZadatakDateTimePicker2";
            this.DodajZadatakDateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.DodajZadatakDateTimePicker2.TabIndex = 38;
            // 
            // DodajZadatakProfilPictureBox
            // 
            this.DodajZadatakProfilPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DodajZadatakProfilPictureBox.BackgroundImage")));
            this.DodajZadatakProfilPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DodajZadatakProfilPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DodajZadatakProfilPictureBox.Image")));
            this.DodajZadatakProfilPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("DodajZadatakProfilPictureBox.InitialImage")));
            this.DodajZadatakProfilPictureBox.Location = new System.Drawing.Point(1823, 13);
            this.DodajZadatakProfilPictureBox.Name = "DodajZadatakProfilPictureBox";
            this.DodajZadatakProfilPictureBox.Size = new System.Drawing.Size(65, 65);
            this.DodajZadatakProfilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DodajZadatakProfilPictureBox.TabIndex = 43;
            this.DodajZadatakProfilPictureBox.TabStop = false;
            // 
            // DodajZadatakNatragButton
            // 
            this.DodajZadatakNatragButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DodajZadatakNatragButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DodajZadatakNatragButton.BackgroundImage")));
            this.DodajZadatakNatragButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DodajZadatakNatragButton.Location = new System.Drawing.Point(12, 12);
            this.DodajZadatakNatragButton.Name = "DodajZadatakNatragButton";
            this.DodajZadatakNatragButton.Size = new System.Drawing.Size(64, 64);
            this.DodajZadatakNatragButton.TabIndex = 41;
            this.DodajZadatakNatragButton.UseVisualStyleBackColor = false;
            // 
            // DodajZadatakProfilLinkLabel
            // 
            this.DodajZadatakProfilLinkLabel.AutoSize = true;
            this.DodajZadatakProfilLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.DodajZadatakProfilLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DodajZadatakProfilLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DodajZadatakProfilLinkLabel.Location = new System.Drawing.Point(1651, 31);
            this.DodajZadatakProfilLinkLabel.Name = "DodajZadatakProfilLinkLabel";
            this.DodajZadatakProfilLinkLabel.Size = new System.Drawing.Size(157, 29);
            this.DodajZadatakProfilLinkLabel.TabIndex = 42;
            this.DodajZadatakProfilLinkLabel.TabStop = true;
            this.DodajZadatakProfilLinkLabel.Text = "Sara Bednaić";
            // 
            // DodajZadatakOpisRichTextBox
            // 
            this.DodajZadatakOpisRichTextBox.Location = new System.Drawing.Point(631, 435);
            this.DodajZadatakOpisRichTextBox.Name = "DodajZadatakOpisRichTextBox";
            this.DodajZadatakOpisRichTextBox.Size = new System.Drawing.Size(715, 121);
            this.DodajZadatakOpisRichTextBox.TabIndex = 48;
            this.DodajZadatakOpisRichTextBox.Text = "";
            // 
            // DodajZadatakStatusButton
            // 
            this.DodajZadatakStatusButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DodajZadatakStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DodajZadatakStatusButton.Enabled = false;
            this.DodajZadatakStatusButton.Location = new System.Drawing.Point(740, 854);
            this.DodajZadatakStatusButton.Margin = new System.Windows.Forms.Padding(2);
            this.DodajZadatakStatusButton.Name = "DodajZadatakStatusButton";
            this.DodajZadatakStatusButton.Size = new System.Drawing.Size(105, 30);
            this.DodajZadatakStatusButton.TabIndex = 49;
            this.DodajZadatakStatusButton.UseVisualStyleBackColor = false;
            // 
            // DodajZadatakStatusComboBox
            // 
            this.DodajZadatakStatusComboBox.FormattingEnabled = true;
            this.DodajZadatakStatusComboBox.Location = new System.Drawing.Point(631, 854);
            this.DodajZadatakStatusComboBox.Name = "DodajZadatakStatusComboBox";
            this.DodajZadatakStatusComboBox.Size = new System.Drawing.Size(95, 28);
            this.DodajZadatakStatusComboBox.TabIndex = 50;
            // 
            // DodajZadatak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.DodajZadatakStatusComboBox);
            this.Controls.Add(this.DodajZadatakStatusButton);
            this.Controls.Add(this.DodajZadatakOpisRichTextBox);
            this.Controls.Add(DodajZadatakOpisLabel);
            this.Controls.Add(DodajZadatakNazivLabel);
            this.Controls.Add(DodajZadatakProjektLabel);
            this.Controls.Add(this.DodajZadatakClanoviListBox);
            this.Controls.Add(this.DodajZadatakProfilPictureBox);
            this.Controls.Add(this.DodajZadatakNatragButton);
            this.Controls.Add(this.DodajZadatakProfilLinkLabel);
            this.Controls.Add(DodajZadatakButton);
            this.Controls.Add(this.DodajZadatakDateTimePicker2);
            this.Controls.Add(this.DodajZadatakDateTimePicker1);
            this.Controls.Add(this.DodajZadatakProjektComboBox);
            this.Controls.Add(DodajZadatakVrijemeLabel);
            this.Controls.Add(DodajZadatakClanoviLabel);
            this.Controls.Add(DodajZadatakNazivTextBox);
            this.Controls.Add(DodajZadatakNaslovLabel);
            this.Controls.Add(this.DodajZadatakProfilPanel);
            this.Controls.Add(DodajZadatakOdDoLabel);
            this.Controls.Add(DodajZadatakStatusLabel);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1440, 1018);
            this.Name = "DodajZadatak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DodajZadatakProfilPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox DodajZadatakClanoviListBox;
        private System.Windows.Forms.Panel DodajZadatakProfilPanel;
        private System.Windows.Forms.ComboBox DodajZadatakProjektComboBox;
        private System.Windows.Forms.DateTimePicker DodajZadatakDateTimePicker1;
        private System.Windows.Forms.DateTimePicker DodajZadatakDateTimePicker2;
        private System.Windows.Forms.PictureBox DodajZadatakProfilPictureBox;
        private System.Windows.Forms.Button DodajZadatakNatragButton;
        private System.Windows.Forms.LinkLabel DodajZadatakProfilLinkLabel;
        private System.Windows.Forms.RichTextBox DodajZadatakOpisRichTextBox;
        private System.Windows.Forms.Button DodajZadatakStatusButton;
        private System.Windows.Forms.ComboBox DodajZadatakStatusComboBox;
    }
}