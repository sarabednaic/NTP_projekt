namespace ntp_projekt
{
    partial class PopisProjekta
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
            System.Windows.Forms.Label PopisProjektaNaslovLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopisProjekta));
            this.PopisProjektaAddButton = new System.Windows.Forms.Button();
            this.PopisProjektaSortButton = new System.Windows.Forms.Button();
            this.PopisProjektaSearchRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PopisProjektaSearchButton = new System.Windows.Forms.Button();
            this.PopisProjektaPanel = new System.Windows.Forms.Panel();
            this.PopisProjektaProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.PopisProjektaProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PopisProjektaProjektiFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            PopisProjektaNaslovLabel = new System.Windows.Forms.Label();
            this.PopisProjektaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopisProjektaProfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PopisProjektaNaslovLabel
            // 
            resources.ApplyResources(PopisProjektaNaslovLabel, "PopisProjektaNaslovLabel");
            PopisProjektaNaslovLabel.Name = "PopisProjektaNaslovLabel";
            PopisProjektaNaslovLabel.Click += new System.EventHandler(this.UrediZadatakNaslovLabel_Click);
            // 
            // PopisProjektaAddButton
            // 
            resources.ApplyResources(this.PopisProjektaAddButton, "PopisProjektaAddButton");
            this.PopisProjektaAddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PopisProjektaAddButton.Name = "PopisProjektaAddButton";
            this.PopisProjektaAddButton.UseVisualStyleBackColor = false;
            this.PopisProjektaAddButton.Click += new System.EventHandler(this.PopisProjektaAddButton_Click_1);
            // 
            // PopisProjektaSortButton
            // 
            resources.ApplyResources(this.PopisProjektaSortButton, "PopisProjektaSortButton");
            this.PopisProjektaSortButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PopisProjektaSortButton.Name = "PopisProjektaSortButton";
            this.PopisProjektaSortButton.UseVisualStyleBackColor = false;
            // 
            // PopisProjektaSearchRichTextBox
            // 
            resources.ApplyResources(this.PopisProjektaSearchRichTextBox, "PopisProjektaSearchRichTextBox");
            this.PopisProjektaSearchRichTextBox.Name = "PopisProjektaSearchRichTextBox";
            // 
            // PopisProjektaSearchButton
            // 
            resources.ApplyResources(this.PopisProjektaSearchButton, "PopisProjektaSearchButton");
            this.PopisProjektaSearchButton.Name = "PopisProjektaSearchButton";
            this.PopisProjektaSearchButton.UseVisualStyleBackColor = true;
            // 
            // PopisProjektaPanel
            // 
            resources.ApplyResources(this.PopisProjektaPanel, "PopisProjektaPanel");
            this.PopisProjektaPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PopisProjektaPanel.Controls.Add(this.PopisProjektaProfilPictureBox);
            this.PopisProjektaPanel.Controls.Add(this.PopisProjektaProfilLinkLabel);
            this.PopisProjektaPanel.Name = "PopisProjektaPanel";
            // 
            // PopisProjektaProfilPictureBox
            // 
            resources.ApplyResources(this.PopisProjektaProfilPictureBox, "PopisProjektaProfilPictureBox");
            this.PopisProjektaProfilPictureBox.Name = "PopisProjektaProfilPictureBox";
            this.PopisProjektaProfilPictureBox.TabStop = false;
            this.PopisProjektaProfilPictureBox.Click += new System.EventHandler(this.PopisProjektaProfilPictureBox_Click_1);
            // 
            // PopisProjektaProfilLinkLabel
            // 
            resources.ApplyResources(this.PopisProjektaProfilLinkLabel, "PopisProjektaProfilLinkLabel");
            this.PopisProjektaProfilLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PopisProjektaProfilLinkLabel.Name = "PopisProjektaProfilLinkLabel";
            this.PopisProjektaProfilLinkLabel.TabStop = true;
            this.PopisProjektaProfilLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PopisProjektaProfilLinkLabel_LinkClicked_1);
            // 
            // PopisProjektaProjektiFlowLayoutPanel
            // 
            resources.ApplyResources(this.PopisProjektaProjektiFlowLayoutPanel, "PopisProjektaProjektiFlowLayoutPanel");
            this.PopisProjektaProjektiFlowLayoutPanel.Name = "PopisProjektaProjektiFlowLayoutPanel";
            this.PopisProjektaProjektiFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PopisProjektaProjektiFlowLayoutPanel_Paint);
            // 
            // PopisProjekta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PopisProjektaProjektiFlowLayoutPanel);
            this.Controls.Add(this.PopisProjektaPanel);
            this.Controls.Add(this.PopisProjektaSearchButton);
            this.Controls.Add(this.PopisProjektaSearchRichTextBox);
            this.Controls.Add(PopisProjektaNaslovLabel);
            this.Controls.Add(this.PopisProjektaSortButton);
            this.Controls.Add(this.PopisProjektaAddButton);
            this.Name = "PopisProjekta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PopisProjekta_Load);
            this.PopisProjektaPanel.ResumeLayout(false);
            this.PopisProjektaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopisProjektaProfilPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PopisProjektaAddButton;
        private System.Windows.Forms.Button PopisProjektaSortButton;
        private System.Windows.Forms.RichTextBox PopisProjektaSearchRichTextBox;
        private System.Windows.Forms.Button PopisProjektaSearchButton;
        private System.Windows.Forms.Panel PopisProjektaPanel;
        private System.Windows.Forms.PictureBox PopisProjektaProfilPictureBox;
        private System.Windows.Forms.LinkLabel PopisProjektaProfilLinkLabel;
        private System.Windows.Forms.FlowLayoutPanel PopisProjektaProjektiFlowLayoutPanel;
    }
}