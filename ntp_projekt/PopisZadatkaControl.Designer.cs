namespace ntp_projekt
{
    partial class PopisZadatkaControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopisZadatkaControl));
            this.PZControlZadatakButton = new System.Windows.Forms.Button();
            this.PZControlStatusButton = new System.Windows.Forms.Button();
            this.PZControlDeleteButton = new System.Windows.Forms.Button();
            this.PZControlEditButton = new System.Windows.Forms.Button();
            this.PZControlStatusLabel = new System.Windows.Forms.Label();
            this.PZControlNaslodLabel = new System.Windows.Forms.Label();
            this.PZControlPopisLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PZControlZadatakButton
            // 
            this.PZControlZadatakButton.Location = new System.Drawing.Point(3, 3);
            this.PZControlZadatakButton.Name = "PZControlZadatakButton";
            this.PZControlZadatakButton.Size = new System.Drawing.Size(1307, 200);
            this.PZControlZadatakButton.TabIndex = 3;
            this.PZControlZadatakButton.UseVisualStyleBackColor = true;
            this.PZControlZadatakButton.Click += new System.EventHandler(this.PZControlZadatakButton_Click);
            // 
            // PZControlStatusButton
            // 
            this.PZControlStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PZControlStatusButton.Enabled = false;
            this.PZControlStatusButton.Location = new System.Drawing.Point(433, 44);
            this.PZControlStatusButton.Name = "PZControlStatusButton";
            this.PZControlStatusButton.Size = new System.Drawing.Size(120, 35);
            this.PZControlStatusButton.TabIndex = 4;
            this.PZControlStatusButton.UseVisualStyleBackColor = false;
            // 
            // PZControlDeleteButton
            // 
            this.PZControlDeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PZControlDeleteButton.BackgroundImage")));
            this.PZControlDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PZControlDeleteButton.Location = new System.Drawing.Point(1220, 65);
            this.PZControlDeleteButton.Name = "PZControlDeleteButton";
            this.PZControlDeleteButton.Size = new System.Drawing.Size(76, 76);
            this.PZControlDeleteButton.TabIndex = 5;
            this.PZControlDeleteButton.UseVisualStyleBackColor = true;
            this.PZControlDeleteButton.Click += new System.EventHandler(this.PZControlDeleteButton_Click);
            // 
            // PZControlEditButton
            // 
            this.PZControlEditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PZControlEditButton.BackgroundImage")));
            this.PZControlEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PZControlEditButton.Location = new System.Drawing.Point(1138, 65);
            this.PZControlEditButton.Name = "PZControlEditButton";
            this.PZControlEditButton.Size = new System.Drawing.Size(76, 76);
            this.PZControlEditButton.TabIndex = 6;
            this.PZControlEditButton.UseVisualStyleBackColor = true;
            this.PZControlEditButton.Click += new System.EventHandler(this.PZControlEditButton_Click);
            // 
            // PZControlStatusLabel
            // 
            this.PZControlStatusLabel.AutoSize = true;
            this.PZControlStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PZControlStatusLabel.Location = new System.Drawing.Point(335, 45);
            this.PZControlStatusLabel.Name = "PZControlStatusLabel";
            this.PZControlStatusLabel.Size = new System.Drawing.Size(92, 31);
            this.PZControlStatusLabel.TabIndex = 7;
            this.PZControlStatusLabel.Text = "Status";
            // 
            // PZControlNaslodLabel
            // 
            this.PZControlNaslodLabel.AutoSize = true;
            this.PZControlNaslodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.PZControlNaslodLabel.Location = new System.Drawing.Point(46, 37);
            this.PZControlNaslodLabel.Name = "PZControlNaslodLabel";
            this.PZControlNaslodLabel.Size = new System.Drawing.Size(255, 39);
            this.PZControlNaslodLabel.TabIndex = 8;
            this.PZControlNaslodLabel.Text = "Naslov zadatka";
            // 
            // PZControlPopisLabel
            // 
            this.PZControlPopisLabel.AutoSize = true;
            this.PZControlPopisLabel.Location = new System.Drawing.Point(48, 116);
            this.PZControlPopisLabel.Name = "PZControlPopisLabel";
            this.PZControlPopisLabel.Size = new System.Drawing.Size(347, 25);
            this.PZControlPopisLabel.TabIndex = 9;
            this.PZControlPopisLabel.Text = "Popis članova koji rade na zadatku";
            // 
            // PopisZadatkaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PZControlPopisLabel);
            this.Controls.Add(this.PZControlNaslodLabel);
            this.Controls.Add(this.PZControlStatusLabel);
            this.Controls.Add(this.PZControlEditButton);
            this.Controls.Add(this.PZControlDeleteButton);
            this.Controls.Add(this.PZControlStatusButton);
            this.Controls.Add(this.PZControlZadatakButton);
            this.Name = "PopisZadatkaControl";
            this.Size = new System.Drawing.Size(1313, 206);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PZControlZadatakButton;
        private System.Windows.Forms.Button PZControlStatusButton;
        private System.Windows.Forms.Button PZControlDeleteButton;
        private System.Windows.Forms.Button PZControlEditButton;
        private System.Windows.Forms.Label PZControlStatusLabel;
        private System.Windows.Forms.Label PZControlNaslodLabel;
        private System.Windows.Forms.Label PZControlPopisLabel;
    }
}
