namespace ntp_projekt
{
    partial class UrediZadatak
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label DodajZadatakVrijemeLabel;
            System.Windows.Forms.Label DodajZadatakClanoviLabel;
            System.Windows.Forms.TextBox DodajZadatakNazivTextBox;
            System.Windows.Forms.Label DodajZadatakLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Button DodajProjektButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrediZadatak));
            this.DeaktivacijaProfilPanel = new System.Windows.Forms.Panel();
            this.DeaktivacijaNatragButton = new System.Windows.Forms.Button();
            this.UrediZadatakProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.UrediZadatakProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UrediZadatakStatusButton = new System.Windows.Forms.Button();
            this.DodajZadatakOpisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DodajZadatakClanoviListBox = new System.Windows.Forms.CheckedListBox();
            this.DodajZadatakDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DodajZadatakDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DodajZadatakProjektComboBox = new System.Windows.Forms.ComboBox();
            this.UrediZadatakStatusComboBox = new System.Windows.Forms.ComboBox();
            UrediZadatakNaslovLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            DodajZadatakVrijemeLabel = new System.Windows.Forms.Label();
            DodajZadatakClanoviLabel = new System.Windows.Forms.Label();
            DodajZadatakNazivTextBox = new System.Windows.Forms.TextBox();
            DodajZadatakLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            DodajProjektButton = new System.Windows.Forms.Button();
            this.DeaktivacijaProfilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrediZadatakProfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UrediZadatakNaslovLabel
            // 
            UrediZadatakNaslovLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            UrediZadatakNaslovLabel.AutoSize = true;
            UrediZadatakNaslovLabel.Font = new System.Drawing.Font("Leelawadee UI", 25F, System.Drawing.FontStyle.Bold);
            UrediZadatakNaslovLabel.Location = new System.Drawing.Point(900, 169);
            UrediZadatakNaslovLabel.Name = "UrediZadatakNaslovLabel";
            UrediZadatakNaslovLabel.Size = new System.Drawing.Size(777, 89);
            UrediZadatakNaslovLabel.TabIndex = 12;
            UrediZadatakNaslovLabel.Text = "Uredi projektni zadatak";
            UrediZadatakNaslovLabel.Click += new System.EventHandler(this.BriasnjeProjektaNaslovLabel_Click);
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label4.Location = new System.Drawing.Point(804, 494);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(604, 54);
            label4.TabIndex = 62;
            label4.Text = "Opis zadatka";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label3.Location = new System.Drawing.Point(804, 394);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(604, 54);
            label3.TabIndex = 61;
            label3.Text = "Naziv zadatka";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label2.Location = new System.Drawing.Point(804, 299);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(604, 54);
            label2.TabIndex = 60;
            label2.Text = "Dodijeljeni projekt";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label2.UseWaitCursor = true;
            // 
            // DodajZadatakVrijemeLabel
            // 
            DodajZadatakVrijemeLabel.BackColor = System.Drawing.Color.Transparent;
            DodajZadatakVrijemeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajZadatakVrijemeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajZadatakVrijemeLabel.Location = new System.Drawing.Point(804, 924);
            DodajZadatakVrijemeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajZadatakVrijemeLabel.Name = "DodajZadatakVrijemeLabel";
            DodajZadatakVrijemeLabel.Size = new System.Drawing.Size(604, 54);
            DodajZadatakVrijemeLabel.TabIndex = 53;
            DodajZadatakVrijemeLabel.Text = "Vrijeme ";
            DodajZadatakVrijemeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajZadatakVrijemeLabel.UseWaitCursor = true;
            // 
            // DodajZadatakClanoviLabel
            // 
            DodajZadatakClanoviLabel.BackColor = System.Drawing.Color.Transparent;
            DodajZadatakClanoviLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DodajZadatakClanoviLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajZadatakClanoviLabel.Location = new System.Drawing.Point(804, 728);
            DodajZadatakClanoviLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajZadatakClanoviLabel.Name = "DodajZadatakClanoviLabel";
            DodajZadatakClanoviLabel.Size = new System.Drawing.Size(383, 54);
            DodajZadatakClanoviLabel.TabIndex = 52;
            DodajZadatakClanoviLabel.Text = "Dodijeli zadatak članovima tima";
            DodajZadatakClanoviLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DodajZadatakClanoviLabel.UseWaitCursor = true;
            // 
            // DodajZadatakNazivTextBox
            // 
            DodajZadatakNazivTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            DodajZadatakNazivTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            DodajZadatakNazivTextBox.Location = new System.Drawing.Point(809, 449);
            DodajZadatakNazivTextBox.Margin = new System.Windows.Forms.Padding(4);
            DodajZadatakNazivTextBox.Name = "DodajZadatakNazivTextBox";
            DodajZadatakNazivTextBox.Size = new System.Drawing.Size(952, 31);
            DodajZadatakNazivTextBox.TabIndex = 50;
            // 
            // DodajZadatakLabel
            // 
            DodajZadatakLabel.BackColor = System.Drawing.Color.Transparent;
            DodajZadatakLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            DodajZadatakLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DodajZadatakLabel.Location = new System.Drawing.Point(1079, 945);
            DodajZadatakLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DodajZadatakLabel.Name = "DodajZadatakLabel";
            DodajZadatakLabel.Size = new System.Drawing.Size(87, 56);
            DodajZadatakLabel.TabIndex = 58;
            DodajZadatakLabel.Text = "_";
            DodajZadatakLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            DodajZadatakLabel.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(804, 1028);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(604, 54);
            label1.TabIndex = 59;
            label1.Text = "Status";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.UseWaitCursor = true;
            // 
            // DodajProjektButton
            // 
            DodajProjektButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            DodajProjektButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            DodajProjektButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            DodajProjektButton.Location = new System.Drawing.Point(1169, 1131);
            DodajProjektButton.Margin = new System.Windows.Forms.Padding(4);
            DodajProjektButton.Name = "DodajProjektButton";
            DodajProjektButton.Size = new System.Drawing.Size(293, 75);
            DodajProjektButton.TabIndex = 65;
            DodajProjektButton.Text = "Uredi zadatak";
            DodajProjektButton.UseVisualStyleBackColor = false;
            DodajProjektButton.Click += new System.EventHandler(this.DodajProjektButton_Click);
            // 
            // DeaktivacijaProfilPanel
            // 
            this.DeaktivacijaProfilPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeaktivacijaProfilPanel.Controls.Add(this.DeaktivacijaNatragButton);
            this.DeaktivacijaProfilPanel.Controls.Add(this.UrediZadatakProfilPictureBox);
            this.DeaktivacijaProfilPanel.Controls.Add(this.UrediZadatakProfilLinkLabel);
            this.DeaktivacijaProfilPanel.Location = new System.Drawing.Point(0, 0);
            this.DeaktivacijaProfilPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DeaktivacijaProfilPanel.Name = "DeaktivacijaProfilPanel";
            this.DeaktivacijaProfilPanel.Size = new System.Drawing.Size(2560, 112);
            this.DeaktivacijaProfilPanel.TabIndex = 25;
            // 
            // DeaktivacijaNatragButton
            // 
            this.DeaktivacijaNatragButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeaktivacijaNatragButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeaktivacijaNatragButton.BackgroundImage")));
            this.DeaktivacijaNatragButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeaktivacijaNatragButton.Location = new System.Drawing.Point(16, 15);
            this.DeaktivacijaNatragButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeaktivacijaNatragButton.Name = "DeaktivacijaNatragButton";
            this.DeaktivacijaNatragButton.Size = new System.Drawing.Size(85, 80);
            this.DeaktivacijaNatragButton.TabIndex = 23;
            this.DeaktivacijaNatragButton.UseVisualStyleBackColor = false;
            this.DeaktivacijaNatragButton.Click += new System.EventHandler(this.DeaktivacijaNatragButton_Click);
            // 
            // UrediZadatakProfilPictureBox
            // 
            this.UrediZadatakProfilPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UrediZadatakProfilPictureBox.BackgroundImage")));
            this.UrediZadatakProfilPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UrediZadatakProfilPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UrediZadatakProfilPictureBox.Image")));
            this.UrediZadatakProfilPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("UrediZadatakProfilPictureBox.InitialImage")));
            this.UrediZadatakProfilPictureBox.Location = new System.Drawing.Point(2429, 16);
            this.UrediZadatakProfilPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.UrediZadatakProfilPictureBox.Name = "UrediZadatakProfilPictureBox";
            this.UrediZadatakProfilPictureBox.Size = new System.Drawing.Size(87, 81);
            this.UrediZadatakProfilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UrediZadatakProfilPictureBox.TabIndex = 22;
            this.UrediZadatakProfilPictureBox.TabStop = false;
            this.UrediZadatakProfilPictureBox.Click += new System.EventHandler(this.DeaktivacijaProfilPictureBox_Click);
            // 
            // UrediZadatakProfilLinkLabel
            // 
            this.UrediZadatakProfilLinkLabel.AutoSize = true;
            this.UrediZadatakProfilLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UrediZadatakProfilLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UrediZadatakProfilLinkLabel.Location = new System.Drawing.Point(2200, 39);
            this.UrediZadatakProfilLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UrediZadatakProfilLinkLabel.Name = "UrediZadatakProfilLinkLabel";
            this.UrediZadatakProfilLinkLabel.Size = new System.Drawing.Size(209, 37);
            this.UrediZadatakProfilLinkLabel.TabIndex = 0;
            this.UrediZadatakProfilLinkLabel.TabStop = true;
            this.UrediZadatakProfilLinkLabel.Text = "Sara Bednaić";
            this.UrediZadatakProfilLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeaktivacijaProfilLinkLabel_LinkClicked);
            // 
            // UrediZadatakStatusButton
            // 
            this.UrediZadatakStatusButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UrediZadatakStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.UrediZadatakStatusButton.Enabled = false;
            this.UrediZadatakStatusButton.Location = new System.Drawing.Point(955, 1072);
            this.UrediZadatakStatusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UrediZadatakStatusButton.Name = "UrediZadatakStatusButton";
            this.UrediZadatakStatusButton.Size = new System.Drawing.Size(140, 44);
            this.UrediZadatakStatusButton.TabIndex = 64;
            this.UrediZadatakStatusButton.UseVisualStyleBackColor = false;
            // 
            // DodajZadatakOpisRichTextBox
            // 
            this.DodajZadatakOpisRichTextBox.Location = new System.Drawing.Point(809, 551);
            this.DodajZadatakOpisRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DodajZadatakOpisRichTextBox.Name = "DodajZadatakOpisRichTextBox";
            this.DodajZadatakOpisRichTextBox.Size = new System.Drawing.Size(952, 150);
            this.DodajZadatakOpisRichTextBox.TabIndex = 63;
            this.DodajZadatakOpisRichTextBox.Text = "";
            // 
            // DodajZadatakClanoviListBox
            // 
            this.DodajZadatakClanoviListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DodajZadatakClanoviListBox.FormattingEnabled = true;
            this.DodajZadatakClanoviListBox.Location = new System.Drawing.Point(809, 770);
            this.DodajZadatakClanoviListBox.Margin = new System.Windows.Forms.Padding(4);
            this.DodajZadatakClanoviListBox.Name = "DodajZadatakClanoviListBox";
            this.DodajZadatakClanoviListBox.Size = new System.Drawing.Size(952, 144);
            this.DodajZadatakClanoviListBox.TabIndex = 51;
            // 
            // DodajZadatakDateTimePicker2
            // 
            this.DodajZadatakDateTimePicker2.Location = new System.Drawing.Point(1160, 981);
            this.DodajZadatakDateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.DodajZadatakDateTimePicker2.Name = "DodajZadatakDateTimePicker2";
            this.DodajZadatakDateTimePicker2.Size = new System.Drawing.Size(265, 31);
            this.DodajZadatakDateTimePicker2.TabIndex = 57;
            // 
            // DodajZadatakDateTimePicker1
            // 
            this.DodajZadatakDateTimePicker1.Location = new System.Drawing.Point(809, 981);
            this.DodajZadatakDateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.DodajZadatakDateTimePicker1.Name = "DodajZadatakDateTimePicker1";
            this.DodajZadatakDateTimePicker1.Size = new System.Drawing.Size(265, 31);
            this.DodajZadatakDateTimePicker1.TabIndex = 56;
            this.DodajZadatakDateTimePicker1.ValueChanged += new System.EventHandler(this.DodajZadatakDateTimePicker1_ValueChanged);
            // 
            // DodajZadatakProjektComboBox
            // 
            this.DodajZadatakProjektComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DodajZadatakProjektComboBox.FormattingEnabled = true;
            this.DodajZadatakProjektComboBox.Location = new System.Drawing.Point(809, 352);
            this.DodajZadatakProjektComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.DodajZadatakProjektComboBox.Name = "DodajZadatakProjektComboBox";
            this.DodajZadatakProjektComboBox.Size = new System.Drawing.Size(952, 33);
            this.DodajZadatakProjektComboBox.TabIndex = 54;
            // 
            // UrediZadatakStatusComboBox
            // 
            this.UrediZadatakStatusComboBox.FormattingEnabled = true;
            this.UrediZadatakStatusComboBox.Location = new System.Drawing.Point(809, 1075);
            this.UrediZadatakStatusComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.UrediZadatakStatusComboBox.Name = "UrediZadatakStatusComboBox";
            this.UrediZadatakStatusComboBox.Size = new System.Drawing.Size(125, 33);
            this.UrediZadatakStatusComboBox.TabIndex = 66;
            // 
            // UrediZadatak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2525, 1261);
            this.Controls.Add(this.UrediZadatakStatusComboBox);
            this.Controls.Add(DodajProjektButton);
            this.Controls.Add(this.DodajZadatakDateTimePicker2);
            this.Controls.Add(this.UrediZadatakStatusButton);
            this.Controls.Add(this.DodajZadatakOpisRichTextBox);
            this.Controls.Add(this.DeaktivacijaProfilPanel);
            this.Controls.Add(label4);
            this.Controls.Add(UrediZadatakNaslovLabel);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.DodajZadatakClanoviListBox);
            this.Controls.Add(DodajZadatakNazivTextBox);
            this.Controls.Add(DodajZadatakClanoviLabel);
            this.Controls.Add(this.DodajZadatakDateTimePicker1);
            this.Controls.Add(DodajZadatakVrijemeLabel);
            this.Controls.Add(this.DodajZadatakProjektComboBox);
            this.Controls.Add(DodajZadatakLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2551, 1332);
            this.MinimumSize = new System.Drawing.Size(1439, 1015);
            this.Name = "UrediZadatak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DeaktivacijaProfilPanel.ResumeLayout(false);
            this.DeaktivacijaProfilPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrediZadatakProfilPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel DeaktivacijaProfilPanel;
        private System.Windows.Forms.Button DeaktivacijaNatragButton;
        private System.Windows.Forms.PictureBox UrediZadatakProfilPictureBox;
        private System.Windows.Forms.LinkLabel UrediZadatakProfilLinkLabel;
        private System.Windows.Forms.Button UrediZadatakStatusButton;
        private System.Windows.Forms.RichTextBox DodajZadatakOpisRichTextBox;
        private System.Windows.Forms.CheckedListBox DodajZadatakClanoviListBox;
        private System.Windows.Forms.DateTimePicker DodajZadatakDateTimePicker2;
        private System.Windows.Forms.DateTimePicker DodajZadatakDateTimePicker1;
        private System.Windows.Forms.ComboBox DodajZadatakProjektComboBox;
        private System.Windows.Forms.ComboBox UrediZadatakStatusComboBox;
    }
}