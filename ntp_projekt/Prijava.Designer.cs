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
            System.Windows.Forms.TextBox PrijavaKorisnickoImeTextBox;
            System.Windows.Forms.TextBox PrijavaLozinkaTextBox;
            System.Windows.Forms.Button PrijavaPrijavaButton;
            this.PrijavaRegistracijaLinkLabel = new System.Windows.Forms.LinkLabel();
            PrijavaNaslovLabel = new System.Windows.Forms.Label();
            PrijavaKorisnickoImeTextBox = new System.Windows.Forms.TextBox();
            PrijavaLozinkaTextBox = new System.Windows.Forms.TextBox();
            PrijavaPrijavaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrijavaNaslovLabel
            // 
            PrijavaNaslovLabel.Font = new System.Drawing.Font("Leelawadee UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PrijavaNaslovLabel.Location = new System.Drawing.Point(523, 126);
            PrijavaNaslovLabel.Name = "PrijavaNaslovLabel";
            PrijavaNaslovLabel.Size = new System.Drawing.Size(309, 120);
            PrijavaNaslovLabel.TabIndex = 0;
            PrijavaNaslovLabel.Text = "Prijava";
            PrijavaNaslovLabel.Click += new System.EventHandler(this.PrijavaNaslovLabel_Click);
            // 
            // PrijavaKorisnickoImeTextBox
            // 
            PrijavaKorisnickoImeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            PrijavaKorisnickoImeTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            PrijavaKorisnickoImeTextBox.Location = new System.Drawing.Point(385, 284);
            PrijavaKorisnickoImeTextBox.Name = "PrijavaKorisnickoImeTextBox";
            PrijavaKorisnickoImeTextBox.Size = new System.Drawing.Size(452, 26);
            PrijavaKorisnickoImeTextBox.TabIndex = 1;
            PrijavaKorisnickoImeTextBox.Text = "korisničko ime";
            // 
            // PrijavaLozinkaTextBox
            // 
            PrijavaLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            PrijavaLozinkaTextBox.Location = new System.Drawing.Point(385, 354);
            PrijavaLozinkaTextBox.Name = "PrijavaLozinkaTextBox";
            PrijavaLozinkaTextBox.Size = new System.Drawing.Size(452, 26);
            PrijavaLozinkaTextBox.TabIndex = 2;
            PrijavaLozinkaTextBox.Text = "lozinka";
            PrijavaLozinkaTextBox.TextChanged += new System.EventHandler(this.PrijavaLozinkaTextBox_TextChanged);
            // 
            // PrijavaPrijavaButton
            // 
            PrijavaPrijavaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            PrijavaPrijavaButton.Location = new System.Drawing.Point(506, 413);
            PrijavaPrijavaButton.Name = "PrijavaPrijavaButton";
            PrijavaPrijavaButton.Size = new System.Drawing.Size(220, 60);
            PrijavaPrijavaButton.TabIndex = 3;
            PrijavaPrijavaButton.Text = "Prijavi se";
            PrijavaPrijavaButton.UseVisualStyleBackColor = false;
            // 
            // PrijavaRegistracijaLinkLabel
            // 
            this.PrijavaRegistracijaLinkLabel.AutoSize = true;
            this.PrijavaRegistracijaLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PrijavaRegistracijaLinkLabel.Location = new System.Drawing.Point(542, 513);
            this.PrijavaRegistracijaLinkLabel.Name = "PrijavaRegistracijaLinkLabel";
            this.PrijavaRegistracijaLinkLabel.Size = new System.Drawing.Size(232, 20);
            this.PrijavaRegistracijaLinkLabel.TabIndex = 4;
            this.PrijavaRegistracijaLinkLabel.TabStop = true;
            this.PrijavaRegistracijaLinkLabel.Text = "Nemate račun? Registrirajte se!";
            // 
            // Prijava
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.PrijavaRegistracijaLinkLabel);
            this.Controls.Add(PrijavaPrijavaButton);
            this.Controls.Add(PrijavaLozinkaTextBox);
            this.Controls.Add(PrijavaKorisnickoImeTextBox);
            this.Controls.Add(PrijavaNaslovLabel);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1440, 1018);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel PrijavaRegistracijaLinkLabel;
    }
}

