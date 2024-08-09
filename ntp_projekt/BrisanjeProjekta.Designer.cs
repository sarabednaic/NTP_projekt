namespace ntp_projekt
{
    partial class Form1
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
            System.Windows.Forms.Label BriasnjeProjektaNaslovLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BrisanjeProjektaIzbrisiProjektButton = new System.Windows.Forms.Button();
            this.BrisanjeProjektaLozinkaTextBox = new System.Windows.Forms.RichTextBox();
            this.BrisanjeProjektaPonovnoLozinkaTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BrisanjeProjektaArrowButton = new System.Windows.Forms.Button();
            this.BrisanjeProjektaPFPButton = new System.Windows.Forms.Button();
            this.BrisanjeProjektaUserButton = new System.Windows.Forms.Button();
            BriasnjeProjektaNaslovLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrisanjeProjektaIzbrisiProjektButton
            // 
            this.BrisanjeProjektaIzbrisiProjektButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrisanjeProjektaIzbrisiProjektButton.BackColor = System.Drawing.Color.Red;
            this.BrisanjeProjektaIzbrisiProjektButton.ForeColor = System.Drawing.Color.White;
            this.BrisanjeProjektaIzbrisiProjektButton.Location = new System.Drawing.Point(628, 578);
            this.BrisanjeProjektaIzbrisiProjektButton.Name = "BrisanjeProjektaIzbrisiProjektButton";
            this.BrisanjeProjektaIzbrisiProjektButton.Size = new System.Drawing.Size(304, 78);
            this.BrisanjeProjektaIzbrisiProjektButton.TabIndex = 0;
            this.BrisanjeProjektaIzbrisiProjektButton.Text = "Izbriši Projekt";
            this.BrisanjeProjektaIzbrisiProjektButton.UseVisualStyleBackColor = false;
            this.BrisanjeProjektaIzbrisiProjektButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrisanjeProjektaLozinkaTextBox
            // 
            this.BrisanjeProjektaLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BrisanjeProjektaLozinkaTextBox.Location = new System.Drawing.Point(546, 417);
            this.BrisanjeProjektaLozinkaTextBox.Name = "BrisanjeProjektaLozinkaTextBox";
            this.BrisanjeProjektaLozinkaTextBox.Size = new System.Drawing.Size(459, 37);
            this.BrisanjeProjektaLozinkaTextBox.TabIndex = 1;
            this.BrisanjeProjektaLozinkaTextBox.Text = "Upišite trenutnu lozinku";
            // 
            // BrisanjeProjektaPonovnoLozinkaTextBox
            // 
            this.BrisanjeProjektaPonovnoLozinkaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BrisanjeProjektaPonovnoLozinkaTextBox.Location = new System.Drawing.Point(546, 491);
            this.BrisanjeProjektaPonovnoLozinkaTextBox.Name = "BrisanjeProjektaPonovnoLozinkaTextBox";
            this.BrisanjeProjektaPonovnoLozinkaTextBox.Size = new System.Drawing.Size(459, 35);
            this.BrisanjeProjektaPonovnoLozinkaTextBox.TabIndex = 2;
            this.BrisanjeProjektaPonovnoLozinkaTextBox.Text = "Ponovite trenutnu lozinku";
            // 
            // BriasnjeProjektaNaslovLabel
            // 
            BriasnjeProjektaNaslovLabel.AutoSize = true;
            BriasnjeProjektaNaslovLabel.Font = new System.Drawing.Font("Leelawadee UI", 40F, System.Drawing.FontStyle.Bold);
            BriasnjeProjektaNaslovLabel.Location = new System.Drawing.Point(359, 193);
            BriasnjeProjektaNaslovLabel.Name = "BriasnjeProjektaNaslovLabel";
            BriasnjeProjektaNaslovLabel.Size = new System.Drawing.Size(911, 142);
            BriasnjeProjektaNaslovLabel.TabIndex = 3;
            BriasnjeProjektaNaslovLabel.Text = "Brisanje Projekta";
            BriasnjeProjektaNaslovLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1563, 117);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BrisanjeProjektaArrowButton
            // 
            this.BrisanjeProjektaArrowButton.Image = ((System.Drawing.Image)(resources.GetObject("BrisanjeProjektaArrowButton.Image")));
            this.BrisanjeProjektaArrowButton.Location = new System.Drawing.Point(24, 23);
            this.BrisanjeProjektaArrowButton.Name = "BrisanjeProjektaArrowButton";
            this.BrisanjeProjektaArrowButton.Size = new System.Drawing.Size(130, 70);
            this.BrisanjeProjektaArrowButton.TabIndex = 5;
            this.BrisanjeProjektaArrowButton.UseVisualStyleBackColor = true;
            this.BrisanjeProjektaArrowButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // BrisanjeProjektaPFPButton
            // 
            this.BrisanjeProjektaPFPButton.Image = ((System.Drawing.Image)(resources.GetObject("BrisanjeProjektaPFPButton.Image")));
            this.BrisanjeProjektaPFPButton.Location = new System.Drawing.Point(1430, 9);
            this.BrisanjeProjektaPFPButton.Name = "BrisanjeProjektaPFPButton";
            this.BrisanjeProjektaPFPButton.Size = new System.Drawing.Size(101, 99);
            this.BrisanjeProjektaPFPButton.TabIndex = 6;
            this.BrisanjeProjektaPFPButton.UseVisualStyleBackColor = true;
            // 
            // BrisanjeProjektaUserButton
            // 
            this.BrisanjeProjektaUserButton.Location = new System.Drawing.Point(1207, 39);
            this.BrisanjeProjektaUserButton.Name = "BrisanjeProjektaUserButton";
            this.BrisanjeProjektaUserButton.Size = new System.Drawing.Size(188, 47);
            this.BrisanjeProjektaUserButton.TabIndex = 7;
            this.BrisanjeProjektaUserButton.Text = "Korisničko ime";
            this.BrisanjeProjektaUserButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 910);
            this.Controls.Add(this.BrisanjeProjektaUserButton);
            this.Controls.Add(this.BrisanjeProjektaPFPButton);
            this.Controls.Add(this.BrisanjeProjektaArrowButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(BriasnjeProjektaNaslovLabel);
            this.Controls.Add(this.BrisanjeProjektaPonovnoLozinkaTextBox);
            this.Controls.Add(this.BrisanjeProjektaLozinkaTextBox);
            this.Controls.Add(this.BrisanjeProjektaIzbrisiProjektButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrisanjeProjektaIzbrisiProjektButton;
        private System.Windows.Forms.RichTextBox BrisanjeProjektaLozinkaTextBox;
        private System.Windows.Forms.RichTextBox BrisanjeProjektaPonovnoLozinkaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BrisanjeProjektaArrowButton;
        private System.Windows.Forms.Button BrisanjeProjektaPFPButton;
        private System.Windows.Forms.Button BrisanjeProjektaUserButton;
    }
}