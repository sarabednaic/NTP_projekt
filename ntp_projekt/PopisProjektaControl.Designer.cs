namespace ntp_projekt
{
    partial class PopisProjektaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopisProjektaControl));
            this.PopisProjektaControlProjektButton = new System.Windows.Forms.Button();
            this.PopisProjektaControlEditButton = new System.Windows.Forms.Button();
            this.PopisProjektaControlDeleteButton = new System.Windows.Forms.Button();
            this.PopisProjektaControlNaslovProjektaLabel = new System.Windows.Forms.Label();
            this.PopisProjektaControlOpisLabel = new System.Windows.Forms.Label();
            this.PopisProjektaControlStatusLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PopisProjektaControlProjektButton
            // 
            this.PopisProjektaControlProjektButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PopisProjektaControlProjektButton, "PopisProjektaControlProjektButton");
            this.PopisProjektaControlProjektButton.Name = "PopisProjektaControlProjektButton";
            this.PopisProjektaControlProjektButton.UseVisualStyleBackColor = false;
            this.PopisProjektaControlProjektButton.Click += new System.EventHandler(this.PopisProjektaControlProjektButton_Click);
            // 
            // PopisProjektaControlEditButton
            // 
            resources.ApplyResources(this.PopisProjektaControlEditButton, "PopisProjektaControlEditButton");
            this.PopisProjektaControlEditButton.Name = "PopisProjektaControlEditButton";
            this.PopisProjektaControlEditButton.UseVisualStyleBackColor = true;
            this.PopisProjektaControlEditButton.Click += new System.EventHandler(this.PopisProjektaControlEditButton_Click);
            // 
            // PopisProjektaControlDeleteButton
            // 
            resources.ApplyResources(this.PopisProjektaControlDeleteButton, "PopisProjektaControlDeleteButton");
            this.PopisProjektaControlDeleteButton.Name = "PopisProjektaControlDeleteButton";
            this.PopisProjektaControlDeleteButton.UseVisualStyleBackColor = true;
            this.PopisProjektaControlDeleteButton.Click += new System.EventHandler(this.PopisProjektaControlDeleteButton_Click);
            // 
            // PopisProjektaControlNaslovProjektaLabel
            // 
            resources.ApplyResources(this.PopisProjektaControlNaslovProjektaLabel, "PopisProjektaControlNaslovProjektaLabel");
            this.PopisProjektaControlNaslovProjektaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PopisProjektaControlNaslovProjektaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PopisProjektaControlNaslovProjektaLabel.Name = "PopisProjektaControlNaslovProjektaLabel";
            // 
            // PopisProjektaControlOpisLabel
            // 
            resources.ApplyResources(this.PopisProjektaControlOpisLabel, "PopisProjektaControlOpisLabel");
            this.PopisProjektaControlOpisLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PopisProjektaControlOpisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PopisProjektaControlOpisLabel.Name = "PopisProjektaControlOpisLabel";
            // 
            // PopisProjektaControlStatusLabel
            // 
            resources.ApplyResources(this.PopisProjektaControlStatusLabel, "PopisProjektaControlStatusLabel");
            this.PopisProjektaControlStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PopisProjektaControlStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PopisProjektaControlStatusLabel.Name = "PopisProjektaControlStatusLabel";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PopisProjektaControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PopisProjektaControlStatusLabel);
            this.Controls.Add(this.PopisProjektaControlOpisLabel);
            this.Controls.Add(this.PopisProjektaControlNaslovProjektaLabel);
            this.Controls.Add(this.PopisProjektaControlDeleteButton);
            this.Controls.Add(this.PopisProjektaControlEditButton);
            this.Controls.Add(this.PopisProjektaControlProjektButton);
            this.Name = "PopisProjektaControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PopisProjektaControlProjektButton;
        private System.Windows.Forms.Button PopisProjektaControlEditButton;
        private System.Windows.Forms.Button PopisProjektaControlDeleteButton;
        private System.Windows.Forms.Label PopisProjektaControlNaslovProjektaLabel;
        private System.Windows.Forms.Label PopisProjektaControlOpisLabel;
        private System.Windows.Forms.Label PopisProjektaControlStatusLabel;
        private System.Windows.Forms.Button button1;
    }
}
