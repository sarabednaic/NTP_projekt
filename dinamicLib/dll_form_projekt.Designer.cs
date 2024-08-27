namespace dinamicLib
{
    partial class dll_form_projekt
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
            this.buttonDaProjekt = new System.Windows.Forms.Button();
            this.buttonNeProjekt = new System.Windows.Forms.Button();
            this.labelProjekt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDaProjekt
            // 
            this.buttonDaProjekt.Location = new System.Drawing.Point(165, 99);
            this.buttonDaProjekt.Name = "buttonDaProjekt";
            this.buttonDaProjekt.Size = new System.Drawing.Size(85, 47);
            this.buttonDaProjekt.TabIndex = 0;
            this.buttonDaProjekt.Text = "Da";
            this.buttonDaProjekt.UseVisualStyleBackColor = true;
            this.buttonDaProjekt.Click += new System.EventHandler(this.buttonDaProjekt_Click);
            // 
            // buttonNeProjekt
            // 
            this.buttonNeProjekt.Location = new System.Drawing.Point(301, 99);
            this.buttonNeProjekt.Name = "buttonNeProjekt";
            this.buttonNeProjekt.Size = new System.Drawing.Size(85, 47);
            this.buttonNeProjekt.TabIndex = 1;
            this.buttonNeProjekt.Text = "Ne";
            this.buttonNeProjekt.UseVisualStyleBackColor = true;
            this.buttonNeProjekt.Click += new System.EventHandler(this.buttonNeProjekt_Click);
            // 
            // labelProjekt
            // 
            this.labelProjekt.AutoSize = true;
            this.labelProjekt.Location = new System.Drawing.Point(125, 57);
            this.labelProjekt.Name = "labelProjekt";
            this.labelProjekt.Size = new System.Drawing.Size(319, 20);
            this.labelProjekt.TabIndex = 2;
            this.labelProjekt.Text = "Jeste li sigurni da želite obrisati ovaj projekt?";
            // 
            // dll_form_projekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 214);
            this.Controls.Add(this.labelProjekt);
            this.Controls.Add(this.buttonNeProjekt);
            this.Controls.Add(this.buttonDaProjekt);
            this.Name = "dll_form_projekt";
            this.Text = "Brisanje projekta";
            this.Load += new System.EventHandler(this.dll_form_projekt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDaProjekt;
        private System.Windows.Forms.Button buttonNeProjekt;
        private System.Windows.Forms.Label labelProjekt;
    }
}