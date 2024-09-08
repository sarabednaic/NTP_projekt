namespace TCPServerExe
{
    partial class tcpServer
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
            this.Status1 = new System.Windows.Forms.Label();
            this.Status2 = new System.Windows.Forms.Label();
            this.Status3 = new System.Windows.Forms.Label();
            this.Status4 = new System.Windows.Forms.Label();
            this.ZahtjevLabel = new System.Windows.Forms.Label();
            this.IsListeningOdgovor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Status1
            // 
            this.Status1.AutoSize = true;
            this.Status1.Location = new System.Drawing.Point(34, 27);
            this.Status1.Name = "Status1";
            this.Status1.Size = new System.Drawing.Size(75, 13);
            this.Status1.TabIndex = 0;
            this.Status1.Text = "Status: Closed";
            // 
            // Status2
            // 
            this.Status2.AutoSize = true;
            this.Status2.Location = new System.Drawing.Point(34, 52);
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(35, 13);
            this.Status2.TabIndex = 1;
            this.Status2.Text = "label1";
            // 
            // Status3
            // 
            this.Status3.AutoSize = true;
            this.Status3.Location = new System.Drawing.Point(34, 77);
            this.Status3.Name = "Status3";
            this.Status3.Size = new System.Drawing.Size(35, 13);
            this.Status3.TabIndex = 2;
            this.Status3.Text = "label1";
            // 
            // Status4
            // 
            this.Status4.AutoSize = true;
            this.Status4.Location = new System.Drawing.Point(34, 99);
            this.Status4.Name = "Status4";
            this.Status4.Size = new System.Drawing.Size(35, 13);
            this.Status4.TabIndex = 3;
            this.Status4.Text = "label1";
            // 
            // ZahtjevLabel
            // 
            this.ZahtjevLabel.AutoSize = true;
            this.ZahtjevLabel.Location = new System.Drawing.Point(186, 27);
            this.ZahtjevLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.ZahtjevLabel.Name = "ZahtjevLabel";
            this.ZahtjevLabel.Size = new System.Drawing.Size(35, 13);
            this.ZahtjevLabel.TabIndex = 4;
            this.ZahtjevLabel.Text = "label1";
            // 
            // IsListeningOdgovor
            // 
            this.IsListeningOdgovor.AutoSize = true;
            this.IsListeningOdgovor.Location = new System.Drawing.Point(186, 77);
            this.IsListeningOdgovor.Name = "IsListeningOdgovor";
            this.IsListeningOdgovor.Size = new System.Drawing.Size(35, 13);
            this.IsListeningOdgovor.TabIndex = 5;
            this.IsListeningOdgovor.Text = "label1";
            // 
            // tcpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 144);
            this.Controls.Add(this.IsListeningOdgovor);
            this.Controls.Add(this.ZahtjevLabel);
            this.Controls.Add(this.Status4);
            this.Controls.Add(this.Status3);
            this.Controls.Add(this.Status2);
            this.Controls.Add(this.Status1);
            this.MaximumSize = new System.Drawing.Size(420, 183);
            this.MinimumSize = new System.Drawing.Size(420, 183);
            this.Name = "tcpServer";
            this.Text = "TCPServer";
            this.Load += new System.EventHandler(this.tcpServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Status1;
        private System.Windows.Forms.Label Status2;
        private System.Windows.Forms.Label Status3;
        private System.Windows.Forms.Label Status4;
        private System.Windows.Forms.Label ZahtjevLabel;
        private System.Windows.Forms.Label IsListeningOdgovor;
    }
}
