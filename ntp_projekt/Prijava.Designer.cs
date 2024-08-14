namespace ntp_projekt
{
    partial class Prijava
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
            System.Windows.Forms.Label PrijavaNaslovLabel;
            System.Windows.Forms.Button PrijavaPrijavaButton;
            System.Windows.Forms.Label PrijavaLozinkaLabel;
            System.Windows.Forms.Label PrijavaKorisnickoImeLabel;
            this.PrijavaRegistracijaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PrijavaKorisImeTextBox = new System.Windows.Forms.TextBox();
            this.PrijavaLozinkaTextBox = new System.Windows.Forms.TextBox();
            PrijavaNaslovLabel = new System.Windows.Forms.Label();
            PrijavaPrijavaButton = new System.Windows.Forms.Button();
            PrijavaLozinkaLabel = new System.Windows.Forms.Label();
            PrijavaKorisnickoImeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrijavaNaslovLabel
            // 
            PrijavaNaslovLabel.Font = new System.Drawing.Font("Leelawadee UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PrijavaNaslovLabel.Location = new System.Drawing.Point(560, 126);
            PrijavaNaslovLabel.Name = "PrijavaNaslovLabel";
            PrijavaNaslovLabel.Size = new System.Drawing.Size(309, 120);
            PrijavaNaslovLabel.TabIndex = 0;
            PrijavaNaslovLabel.Text = "Prijava";
            PrijavaNaslovLabel.Click += new System.EventHandler(this.PrijavaNaslovLabel_Click);
            // 
            // PrijavaPrijavaButton
            // 
            PrijavaPrijavaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            PrijavaPrijavaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            PrijavaPrijavaButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            PrijavaPrijavaButton.Location = new System.Drawing.Point(543, 413);
            PrijavaPrijavaButton.Name = "PrijavaPrijavaButton";
            PrijavaPrijavaButton.Size = new System.Drawing.Size(220, 60);
            PrijavaPrijavaButton.TabIndex = 3;
            PrijavaPrijavaButton.Text = "Prijavi se";
            PrijavaPrijavaButton.UseVisualStyleBackColor = false;
            PrijavaPrijavaButton.Click += new System.EventHandler(this.PrijavaPrijavaButton_Click);
            // 
            // PrijavaLozinkaLabel
            // 
            PrijavaLozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            PrijavaLozinkaLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PrijavaLozinkaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            PrijavaLozinkaLabel.Location = new System.Drawing.Point(418, 317);
            PrijavaLozinkaLabel.Name = "PrijavaLozinkaLabel";
            PrijavaLozinkaLabel.Size = new System.Drawing.Size(287, 43);
            PrijavaLozinkaLabel.TabIndex = 64;
            PrijavaLozinkaLabel.Text = "Lozinka";
            PrijavaLozinkaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            PrijavaLozinkaLabel.UseWaitCursor = true;
            // 
            // PrijavaKorisnickoImeLabel
            // 
            PrijavaKorisnickoImeLabel.BackColor = System.Drawing.Color.Transparent;
            PrijavaKorisnickoImeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PrijavaKorisnickoImeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            PrijavaKorisnickoImeLabel.Location = new System.Drawing.Point(418, 245);
            PrijavaKorisnickoImeLabel.Name = "PrijavaKorisnickoImeLabel";
            PrijavaKorisnickoImeLabel.Size = new System.Drawing.Size(287, 43);
            PrijavaKorisnickoImeLabel.TabIndex = 63;
            PrijavaKorisnickoImeLabel.Text = "Korisničko ime";
            PrijavaKorisnickoImeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            PrijavaKorisnickoImeLabel.UseWaitCursor = true;
            // 
            // PrijavaRegistracijaLinkLabel
            // 
            this.PrijavaRegistracijaLinkLabel.AutoSize = true;
            this.PrijavaRegistracijaLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PrijavaRegistracijaLinkLabel.Location = new System.Drawing.Point(579, 513);
            this.PrijavaRegistracijaLinkLabel.Name = "PrijavaRegistracijaLinkLabel";
            this.PrijavaRegistracijaLinkLabel.Size = new System.Drawing.Size(232, 20);
            this.PrijavaRegistracijaLinkLabel.TabIndex = 4;
            this.PrijavaRegistracijaLinkLabel.TabStop = true;
            this.PrijavaRegistracijaLinkLabel.Text = "Nemate račun? Registrirajte se!";
            this.PrijavaRegistracijaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PrijavaRegistracijaLinkLabel_LinkClicked);
            // 
            // PrijavaKorisImeTextBox
            // 
            this.PrijavaKorisImeTextBox.Location = new System.Drawing.Point(423, 290);
            this.PrijavaKorisImeTextBox.Name = "PrijavaKorisImeTextBox";
            this.PrijavaKorisImeTextBox.Size = new System.Drawing.Size(445, 26);
            this.PrijavaKorisImeTextBox.TabIndex = 67;
            // 
            // PrijavaLozinkaTextBox
            // 
            this.PrijavaLozinkaTextBox.Location = new System.Drawing.Point(426, 366);
            this.PrijavaLozinkaTextBox.Name = "PrijavaLozinkaTextBox";
            this.PrijavaLozinkaTextBox.PasswordChar = '*';
            this.PrijavaLozinkaTextBox.Size = new System.Drawing.Size(441, 26);
            this.PrijavaLozinkaTextBox.TabIndex = 68;
            // 
            // Prijava
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.PrijavaLozinkaTextBox);
            this.Controls.Add(this.PrijavaKorisImeTextBox);
            this.Controls.Add(this.PrijavaRegistracijaLinkLabel);
            this.Controls.Add(PrijavaPrijavaButton);
            this.Controls.Add(PrijavaNaslovLabel);
            this.Controls.Add(PrijavaLozinkaLabel);
            this.Controls.Add(PrijavaKorisnickoImeLabel);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1440, 1018);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Prijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel PrijavaRegistracijaLinkLabel;
        private System.Windows.Forms.TextBox PrijavaKorisImeTextBox;
        private System.Windows.Forms.TextBox PrijavaLozinkaTextBox;
    }
}

