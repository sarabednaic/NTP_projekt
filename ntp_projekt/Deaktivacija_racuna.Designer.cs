namespace ntp_projekt
{
    partial class Deaktivacija_racuna
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
            System.Windows.Forms.Button DeaktivacijaButton;
            System.Windows.Forms.Label DeaktivacijaNaslovLabel;
            System.Windows.Forms.TextBox DeaktivacijaLozinkaTextBox;
            System.Windows.Forms.TextBox DeaktivacijaPonovnoLozinkaTextBox;
            System.Windows.Forms.Label DeaktivacijaPonovnoLozinkaLabel;
            System.Windows.Forms.Label DeaktivacijaLozinkaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deaktivacija_racuna));
            this.DeaktivacijaProfilPanel = new System.Windows.Forms.Panel();
            this.DeaktivacijaNatragButton = new System.Windows.Forms.Button();
            this.DeaktivacijaProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.DeaktivacijaProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            DeaktivacijaButton = new System.Windows.Forms.Button();
            DeaktivacijaNaslovLabel = new System.Windows.Forms.Label();
            DeaktivacijaLozinkaTextBox = new System.Windows.Forms.TextBox();
            DeaktivacijaPonovnoLozinkaTextBox = new System.Windows.Forms.TextBox();
            DeaktivacijaPonovnoLozinkaLabel = new System.Windows.Forms.Label();
            DeaktivacijaLozinkaLabel = new System.Windows.Forms.Label();
            this.DeaktivacijaProfilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeaktivacijaProfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeaktivacijaButton
            // 
            DeaktivacijaButton.BackColor = System.Drawing.Color.Red;
            DeaktivacijaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            DeaktivacijaButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            DeaktivacijaButton.Location = new System.Drawing.Point(857, 630);
            DeaktivacijaButton.Name = "DeaktivacijaButton";
            DeaktivacijaButton.Size = new System.Drawing.Size(220, 60);
            DeaktivacijaButton.TabIndex = 8;
            DeaktivacijaButton.Text = "Deaktiviraj račun";
            DeaktivacijaButton.UseVisualStyleBackColor = false;
            DeaktivacijaButton.Click += new System.EventHandler(this.PrijavaPrijavaButton_Click);
            // 
            // DeaktivacijaNaslovLabel
            // 
            DeaktivacijaNaslovLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DeaktivacijaNaslovLabel.Location = new System.Drawing.Point(681, 273);
            DeaktivacijaNaslovLabel.Name = "DeaktivacijaNaslovLabel";
            DeaktivacijaNaslovLabel.Size = new System.Drawing.Size(606, 120);
            DeaktivacijaNaslovLabel.TabIndex = 5;
            DeaktivacijaNaslovLabel.Text = "Deaktivacija računa";
            DeaktivacijaNaslovLabel.Click += new System.EventHandler(this.PrijavaNaslovLabel_Click);
            // 
            // DeaktivacijaLozinkaTextBox
            // 
            DeaktivacijaLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            DeaktivacijaLozinkaTextBox.Location = new System.Drawing.Point(741, 462);
            DeaktivacijaLozinkaTextBox.Name = "DeaktivacijaLozinkaTextBox";
            DeaktivacijaLozinkaTextBox.PasswordChar = '*';
            DeaktivacijaLozinkaTextBox.Size = new System.Drawing.Size(459, 26);
            DeaktivacijaLozinkaTextBox.TabIndex = 68;
            // 
            // DeaktivacijaPonovnoLozinkaTextBox
            // 
            DeaktivacijaPonovnoLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            DeaktivacijaPonovnoLozinkaTextBox.Location = new System.Drawing.Point(741, 539);
            DeaktivacijaPonovnoLozinkaTextBox.Name = "DeaktivacijaPonovnoLozinkaTextBox";
            DeaktivacijaPonovnoLozinkaTextBox.PasswordChar = '*';
            DeaktivacijaPonovnoLozinkaTextBox.Size = new System.Drawing.Size(459, 26);
            DeaktivacijaPonovnoLozinkaTextBox.TabIndex = 67;
            // 
            // DeaktivacijaPonovnoLozinkaLabel
            // 
            DeaktivacijaPonovnoLozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            DeaktivacijaPonovnoLozinkaLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DeaktivacijaPonovnoLozinkaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DeaktivacijaPonovnoLozinkaLabel.Location = new System.Drawing.Point(737, 507);
            DeaktivacijaPonovnoLozinkaLabel.Name = "DeaktivacijaPonovnoLozinkaLabel";
            DeaktivacijaPonovnoLozinkaLabel.Size = new System.Drawing.Size(287, 43);
            DeaktivacijaPonovnoLozinkaLabel.TabIndex = 66;
            DeaktivacijaPonovnoLozinkaLabel.Text = "Ponovite lozinku za potvrdu brisanja zadatka";
            DeaktivacijaPonovnoLozinkaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DeaktivacijaPonovnoLozinkaLabel.UseWaitCursor = true;
            // 
            // DeaktivacijaLozinkaLabel
            // 
            DeaktivacijaLozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            DeaktivacijaLozinkaLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DeaktivacijaLozinkaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DeaktivacijaLozinkaLabel.Location = new System.Drawing.Point(737, 426);
            DeaktivacijaLozinkaLabel.Name = "DeaktivacijaLozinkaLabel";
            DeaktivacijaLozinkaLabel.Size = new System.Drawing.Size(287, 43);
            DeaktivacijaLozinkaLabel.TabIndex = 65;
            DeaktivacijaLozinkaLabel.Text = "Upišite lozinku za potvrdu brisanja zadatka";
            DeaktivacijaLozinkaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            DeaktivacijaLozinkaLabel.UseWaitCursor = true;
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
            this.DeaktivacijaProfilPanel.TabIndex = 9;
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
            // Deaktivacija_racuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(DeaktivacijaLozinkaTextBox);
            this.Controls.Add(DeaktivacijaPonovnoLozinkaTextBox);
            this.Controls.Add(this.DeaktivacijaProfilPanel);
            this.Controls.Add(DeaktivacijaPonovnoLozinkaLabel);
            this.Controls.Add(DeaktivacijaButton);
            this.Controls.Add(DeaktivacijaLozinkaLabel);
            this.Controls.Add(DeaktivacijaNaslovLabel);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1440, 1018);
            this.Name = "Deaktivacija_racuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Deaktivacija_racuna_Load);
            this.DeaktivacijaProfilPanel.ResumeLayout(false);
            this.DeaktivacijaProfilPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeaktivacijaProfilPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DeaktivacijaProfilPanel;
        private System.Windows.Forms.LinkLabel DeaktivacijaProfilLinkLabel;
        private System.Windows.Forms.PictureBox DeaktivacijaProfilPictureBox;
        private System.Windows.Forms.Button DeaktivacijaNatragButton;
    }
}