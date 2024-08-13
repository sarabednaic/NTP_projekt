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
            DeaktivacijaButton.Location = new System.Drawing.Point(1143, 788);
            DeaktivacijaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            DeaktivacijaButton.Name = "DeaktivacijaButton";
            DeaktivacijaButton.Size = new System.Drawing.Size(293, 75);
            DeaktivacijaButton.TabIndex = 8;
            DeaktivacijaButton.Text = "Deaktiviraj račun";
            DeaktivacijaButton.UseVisualStyleBackColor = false;
            DeaktivacijaButton.Click += new System.EventHandler(this.PrijavaPrijavaButton_Click);
            // 
            // DeaktivacijaNaslovLabel
            // 
            DeaktivacijaNaslovLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DeaktivacijaNaslovLabel.Location = new System.Drawing.Point(908, 341);
            DeaktivacijaNaslovLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DeaktivacijaNaslovLabel.Name = "DeaktivacijaNaslovLabel";
            DeaktivacijaNaslovLabel.Size = new System.Drawing.Size(808, 150);
            DeaktivacijaNaslovLabel.TabIndex = 5;
            DeaktivacijaNaslovLabel.Text = "Deaktivacija računa";
            DeaktivacijaNaslovLabel.Click += new System.EventHandler(this.PrijavaNaslovLabel_Click);
            // 
            // DeaktivacijaLozinkaTextBox
            // 
            DeaktivacijaLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            DeaktivacijaLozinkaTextBox.Location = new System.Drawing.Point(988, 578);
            DeaktivacijaLozinkaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            DeaktivacijaLozinkaTextBox.Name = "DeaktivacijaLozinkaTextBox";
            DeaktivacijaLozinkaTextBox.PasswordChar = '*';
            DeaktivacijaLozinkaTextBox.Size = new System.Drawing.Size(611, 31);
            DeaktivacijaLozinkaTextBox.TabIndex = 68;
            // 
            // DeaktivacijaPonovnoLozinkaTextBox
            // 
            DeaktivacijaPonovnoLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            DeaktivacijaPonovnoLozinkaTextBox.Location = new System.Drawing.Point(988, 674);
            DeaktivacijaPonovnoLozinkaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            DeaktivacijaPonovnoLozinkaTextBox.Name = "DeaktivacijaPonovnoLozinkaTextBox";
            DeaktivacijaPonovnoLozinkaTextBox.PasswordChar = '*';
            DeaktivacijaPonovnoLozinkaTextBox.Size = new System.Drawing.Size(611, 31);
            DeaktivacijaPonovnoLozinkaTextBox.TabIndex = 67;
            // 
            // DeaktivacijaPonovnoLozinkaLabel
            // 
            DeaktivacijaPonovnoLozinkaLabel.BackColor = System.Drawing.Color.Transparent;
            DeaktivacijaPonovnoLozinkaLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DeaktivacijaPonovnoLozinkaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            DeaktivacijaPonovnoLozinkaLabel.Location = new System.Drawing.Point(983, 634);
            DeaktivacijaPonovnoLozinkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DeaktivacijaPonovnoLozinkaLabel.Name = "DeaktivacijaPonovnoLozinkaLabel";
            DeaktivacijaPonovnoLozinkaLabel.Size = new System.Drawing.Size(383, 54);
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
            DeaktivacijaLozinkaLabel.Location = new System.Drawing.Point(983, 532);
            DeaktivacijaLozinkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DeaktivacijaLozinkaLabel.Name = "DeaktivacijaLozinkaLabel";
            DeaktivacijaLozinkaLabel.Size = new System.Drawing.Size(383, 54);
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
            this.DeaktivacijaProfilPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeaktivacijaProfilPanel.Name = "DeaktivacijaProfilPanel";
            this.DeaktivacijaProfilPanel.Size = new System.Drawing.Size(2560, 112);
            this.DeaktivacijaProfilPanel.TabIndex = 9;
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
            // Deaktivacija_racuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2525, 1261);
            this.Controls.Add(DeaktivacijaLozinkaTextBox);
            this.Controls.Add(DeaktivacijaPonovnoLozinkaTextBox);
            this.Controls.Add(this.DeaktivacijaProfilPanel);
            this.Controls.Add(DeaktivacijaPonovnoLozinkaLabel);
            this.Controls.Add(DeaktivacijaButton);
            this.Controls.Add(DeaktivacijaLozinkaLabel);
            this.Controls.Add(DeaktivacijaNaslovLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(2551, 1332);
            this.MinimumSize = new System.Drawing.Size(1911, 1255);
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