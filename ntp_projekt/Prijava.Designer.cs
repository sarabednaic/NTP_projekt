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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
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
            resources.ApplyResources(PrijavaNaslovLabel, "PrijavaNaslovLabel");
            PrijavaNaslovLabel.Name = "PrijavaNaslovLabel";
            PrijavaNaslovLabel.Click += new System.EventHandler(this.PrijavaNaslovLabel_Click);
            // 
            // PrijavaPrijavaButton
            // 
            resources.ApplyResources(PrijavaPrijavaButton, "PrijavaPrijavaButton");
            PrijavaPrijavaButton.BackColor = System.Drawing.SystemColors.HotTrack;
            PrijavaPrijavaButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            PrijavaPrijavaButton.Name = "PrijavaPrijavaButton";
            PrijavaPrijavaButton.UseVisualStyleBackColor = false;
            PrijavaPrijavaButton.Click += new System.EventHandler(this.PrijavaPrijavaButton_Click);
            // 
            // PrijavaLozinkaLabel
            // 
            resources.ApplyResources(PrijavaLozinkaLabel, "PrijavaLozinkaLabel");
            PrijavaLozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            PrijavaLozinkaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            PrijavaLozinkaLabel.Name = "PrijavaLozinkaLabel";
            PrijavaLozinkaLabel.UseWaitCursor = true;
            // 
            // PrijavaKorisnickoImeLabel
            // 
            resources.ApplyResources(PrijavaKorisnickoImeLabel, "PrijavaKorisnickoImeLabel");
            PrijavaKorisnickoImeLabel.BackColor = System.Drawing.Color.Transparent;
            PrijavaKorisnickoImeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            PrijavaKorisnickoImeLabel.Name = "PrijavaKorisnickoImeLabel";
            PrijavaKorisnickoImeLabel.UseWaitCursor = true;
            // 
            // PrijavaRegistracijaLinkLabel
            // 
            resources.ApplyResources(this.PrijavaRegistracijaLinkLabel, "PrijavaRegistracijaLinkLabel");
            this.PrijavaRegistracijaLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PrijavaRegistracijaLinkLabel.Name = "PrijavaRegistracijaLinkLabel";
            this.PrijavaRegistracijaLinkLabel.TabStop = true;
            this.PrijavaRegistracijaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PrijavaRegistracijaLinkLabel_LinkClicked);
            // 
            // PrijavaKorisImeTextBox
            // 
            resources.ApplyResources(this.PrijavaKorisImeTextBox, "PrijavaKorisImeTextBox");
            this.PrijavaKorisImeTextBox.Name = "PrijavaKorisImeTextBox";
            // 
            // PrijavaLozinkaTextBox
            // 
            resources.ApplyResources(this.PrijavaLozinkaTextBox, "PrijavaLozinkaTextBox");
            this.PrijavaLozinkaTextBox.Name = "PrijavaLozinkaTextBox";
            // 
            // Prijava
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PrijavaLozinkaTextBox);
            this.Controls.Add(this.PrijavaKorisImeTextBox);
            this.Controls.Add(this.PrijavaRegistracijaLinkLabel);
            this.Controls.Add(PrijavaPrijavaButton);
            this.Controls.Add(PrijavaNaslovLabel);
            this.Controls.Add(PrijavaLozinkaLabel);
            this.Controls.Add(PrijavaKorisnickoImeLabel);
            this.Name = "Prijava";
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

