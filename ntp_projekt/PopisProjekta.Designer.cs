﻿namespace ntp_projekt
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
            this.PopisProjektaSearchRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PopisProjektaPanel = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.PopisProjektaProfilPictureBox = new System.Windows.Forms.PictureBox();
            this.PopisProjektaProfilLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PopisProjektaProjektiFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PopisProjektaSearchButton = new System.Windows.Forms.Button();
            this.PopisProjektaAddButton = new System.Windows.Forms.Button();
            PopisProjektaNaslovLabel = new System.Windows.Forms.Label();
            this.PopisProjektaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopisProjektaProfilPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PopisProjektaNaslovLabel
            // 
            resources.ApplyResources(PopisProjektaNaslovLabel, "PopisProjektaNaslovLabel");
            PopisProjektaNaslovLabel.Name = "PopisProjektaNaslovLabel";
            PopisProjektaNaslovLabel.Click += new System.EventHandler(this.UrediZadatakNaslovLabel_Click);
            // 
            // PopisProjektaSearchRichTextBox
            // 
            resources.ApplyResources(this.PopisProjektaSearchRichTextBox, "PopisProjektaSearchRichTextBox");
            this.PopisProjektaSearchRichTextBox.Name = "PopisProjektaSearchRichTextBox";
            // 
            // PopisProjektaPanel
            // 
            this.PopisProjektaPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PopisProjektaPanel.Controls.Add(this.PanelLogo);
            this.PopisProjektaPanel.Controls.Add(this.PopisProjektaProfilPictureBox);
            this.PopisProjektaPanel.Controls.Add(this.PopisProjektaProfilLinkLabel);
            resources.ApplyResources(this.PopisProjektaPanel, "PopisProjektaPanel");
            this.PopisProjektaPanel.Name = "PopisProjektaPanel";
            // 
            // PanelLogo
            // 
            resources.ApplyResources(this.PanelLogo, "PanelLogo");
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PopisProjektaPanelLogo_Paint);
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
            // buttonHistory
            // 
            this.buttonHistory.BackgroundImage = global::ntp_projekt.Properties.Resources._32223;
            resources.ApplyResources(this.buttonHistory, "buttonHistory");
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PopisProjektaSearchButton
            // 
            resources.ApplyResources(this.PopisProjektaSearchButton, "PopisProjektaSearchButton");
            this.PopisProjektaSearchButton.Name = "PopisProjektaSearchButton";
            this.PopisProjektaSearchButton.UseVisualStyleBackColor = true;
            this.PopisProjektaSearchButton.Click += new System.EventHandler(this.PopisProjektaSearchButton_Click);
            // 
            // PopisProjektaAddButton
            // 
            resources.ApplyResources(this.PopisProjektaAddButton, "PopisProjektaAddButton");
            this.PopisProjektaAddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PopisProjektaAddButton.Name = "PopisProjektaAddButton";
            this.PopisProjektaAddButton.UseVisualStyleBackColor = false;
            this.PopisProjektaAddButton.Click += new System.EventHandler(this.PopisProjektaAddButton_Click_1);
            // 
            // PopisProjekta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PopisProjektaProjektiFlowLayoutPanel);
            this.Controls.Add(this.PopisProjektaPanel);
            this.Controls.Add(this.PopisProjektaSearchButton);
            this.Controls.Add(this.PopisProjektaSearchRichTextBox);
            this.Controls.Add(PopisProjektaNaslovLabel);
            this.Controls.Add(this.PopisProjektaAddButton);
            this.Name = "PopisProjekta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PopisProjekta_Load);
            this.PopisProjektaPanel.ResumeLayout(false);
            this.PopisProjektaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopisProjektaProfilPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PopisProjektaAddButton;
        private System.Windows.Forms.RichTextBox PopisProjektaSearchRichTextBox;
        private System.Windows.Forms.Button PopisProjektaSearchButton;
        private System.Windows.Forms.Panel PopisProjektaPanel;
        private System.Windows.Forms.PictureBox PopisProjektaProfilPictureBox;
        private System.Windows.Forms.LinkLabel PopisProjektaProfilLinkLabel;
        private System.Windows.Forms.FlowLayoutPanel PopisProjektaProjektiFlowLayoutPanel;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHistory;
    }
}