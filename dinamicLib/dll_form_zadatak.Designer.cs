namespace dinamicLib
{
    partial class dll_form_zadatak
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
            this.labelZadatak = new System.Windows.Forms.Label();
            this.buttonZadatakNe = new System.Windows.Forms.Button();
            this.buttonZadatakDa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelZadatak
            // 
            this.labelZadatak.AutoSize = true;
            this.labelZadatak.Location = new System.Drawing.Point(128, 59);
            this.labelZadatak.Name = "labelZadatak";
            this.labelZadatak.Size = new System.Drawing.Size(328, 20);
            this.labelZadatak.TabIndex = 5;
            this.labelZadatak.Text = "Jeste li sigurni da želite obrisati ovaj zadatak?";
            // 
            // buttonZadatakNe
            // 
            this.buttonZadatakNe.Location = new System.Drawing.Point(304, 101);
            this.buttonZadatakNe.Name = "buttonZadatakNe";
            this.buttonZadatakNe.Size = new System.Drawing.Size(85, 47);
            this.buttonZadatakNe.TabIndex = 4;
            this.buttonZadatakNe.Text = "Ne";
            this.buttonZadatakNe.UseVisualStyleBackColor = true;
            this.buttonZadatakNe.Click += new System.EventHandler(this.buttonZadatakNe_Click);
            // 
            // buttonZadatakDa
            // 
            this.buttonZadatakDa.Location = new System.Drawing.Point(168, 101);
            this.buttonZadatakDa.Name = "buttonZadatakDa";
            this.buttonZadatakDa.Size = new System.Drawing.Size(85, 47);
            this.buttonZadatakDa.TabIndex = 3;
            this.buttonZadatakDa.Text = "Da";
            this.buttonZadatakDa.UseVisualStyleBackColor = true;
            this.buttonZadatakDa.Click += new System.EventHandler(this.buttonZadatakDa_Click);
            // 
            // dll_form_zadatak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 214);
            this.Controls.Add(this.labelZadatak);
            this.Controls.Add(this.buttonZadatakNe);
            this.Controls.Add(this.buttonZadatakDa);
            this.Name = "dll_form_zadatak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brisanje zadatka";
            this.Load += new System.EventHandler(this.dll_form_zadatak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZadatak;
        private System.Windows.Forms.Button buttonZadatakNe;
        private System.Windows.Forms.Button buttonZadatakDa;
    }
}