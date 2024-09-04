namespace ntp_projekt
{
    partial class HTTPDownload
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
            this.PreuzimanjeProgressBar = new System.Windows.Forms.ProgressBar();
            this.PreuzimanjeNaslovLabel = new System.Windows.Forms.Label();
            this.PreuzimanjeZaustaviButton = new System.Windows.Forms.Button();
            this.PreuzimanjeNastavibutton = new System.Windows.Forms.Button();
            this.PreuzimanjeBrzinaRadioButton1 = new System.Windows.Forms.RadioButton();
            this.PreuzimanjeBrzinaRadioButton2 = new System.Windows.Forms.RadioButton();
            this.PreuzimanjeBrzinaRadioButton3 = new System.Windows.Forms.RadioButton();
            this.BrzinaPreutimanjaLabel = new System.Windows.Forms.Label();
            this.PreuzimanjePostotakLabel = new System.Windows.Forms.Label();
            this.PreuzimanjeZapočniButton = new System.Windows.Forms.Button();
            this.Speed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PreuzimanjeProgressBar
            // 
            this.PreuzimanjeProgressBar.Location = new System.Drawing.Point(12, 36);
            this.PreuzimanjeProgressBar.MarqueeAnimationSpeed = 100000;
            this.PreuzimanjeProgressBar.Name = "PreuzimanjeProgressBar";
            this.PreuzimanjeProgressBar.Size = new System.Drawing.Size(608, 23);
            this.PreuzimanjeProgressBar.Step = 5;
            this.PreuzimanjeProgressBar.TabIndex = 0;
            // 
            // PreuzimanjeNaslovLabel
            // 
            this.PreuzimanjeNaslovLabel.AutoSize = true;
            this.PreuzimanjeNaslovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PreuzimanjeNaslovLabel.Location = new System.Drawing.Point(12, 9);
            this.PreuzimanjeNaslovLabel.Name = "PreuzimanjeNaslovLabel";
            this.PreuzimanjeNaslovLabel.Size = new System.Drawing.Size(115, 24);
            this.PreuzimanjeNaslovLabel.TabIndex = 1;
            this.PreuzimanjeNaslovLabel.Text = "Preuzimanje";
            // 
            // PreuzimanjeZaustaviButton
            // 
            this.PreuzimanjeZaustaviButton.Location = new System.Drawing.Point(467, 65);
            this.PreuzimanjeZaustaviButton.Name = "PreuzimanjeZaustaviButton";
            this.PreuzimanjeZaustaviButton.Size = new System.Drawing.Size(75, 23);
            this.PreuzimanjeZaustaviButton.TabIndex = 2;
            this.PreuzimanjeZaustaviButton.Text = "Zaustavi";
            this.PreuzimanjeZaustaviButton.UseVisualStyleBackColor = true;
            this.PreuzimanjeZaustaviButton.Click += new System.EventHandler(this.PreuzimanjeZaustaviButton_Click);
            // 
            // PreuzimanjeNastavibutton
            // 
            this.PreuzimanjeNastavibutton.Location = new System.Drawing.Point(548, 65);
            this.PreuzimanjeNastavibutton.Name = "PreuzimanjeNastavibutton";
            this.PreuzimanjeNastavibutton.Size = new System.Drawing.Size(75, 23);
            this.PreuzimanjeNastavibutton.TabIndex = 3;
            this.PreuzimanjeNastavibutton.Text = "Nastavi";
            this.PreuzimanjeNastavibutton.UseVisualStyleBackColor = true;
            this.PreuzimanjeNastavibutton.Click += new System.EventHandler(this.PreuzimanjeNastavibutton_Click);
            // 
            // PreuzimanjeBrzinaRadioButton1
            // 
            this.PreuzimanjeBrzinaRadioButton1.AutoSize = true;
            this.PreuzimanjeBrzinaRadioButton1.Location = new System.Drawing.Point(12, 82);
            this.PreuzimanjeBrzinaRadioButton1.Name = "PreuzimanjeBrzinaRadioButton1";
            this.PreuzimanjeBrzinaRadioButton1.Size = new System.Drawing.Size(58, 17);
            this.PreuzimanjeBrzinaRadioButton1.TabIndex = 4;
            this.PreuzimanjeBrzinaRadioButton1.TabStop = true;
            this.PreuzimanjeBrzinaRadioButton1.Text = "5 KB/s";
            this.PreuzimanjeBrzinaRadioButton1.UseVisualStyleBackColor = true;
            this.PreuzimanjeBrzinaRadioButton1.CheckedChanged += new System.EventHandler(this.PreuzimanjeBrzinaRadioButton1_CheckedChanged);
            // 
            // PreuzimanjeBrzinaRadioButton2
            // 
            this.PreuzimanjeBrzinaRadioButton2.AutoSize = true;
            this.PreuzimanjeBrzinaRadioButton2.Location = new System.Drawing.Point(12, 105);
            this.PreuzimanjeBrzinaRadioButton2.Name = "PreuzimanjeBrzinaRadioButton2";
            this.PreuzimanjeBrzinaRadioButton2.Size = new System.Drawing.Size(64, 17);
            this.PreuzimanjeBrzinaRadioButton2.TabIndex = 5;
            this.PreuzimanjeBrzinaRadioButton2.TabStop = true;
            this.PreuzimanjeBrzinaRadioButton2.Text = "10 KB/s";
            this.PreuzimanjeBrzinaRadioButton2.UseVisualStyleBackColor = true;
            this.PreuzimanjeBrzinaRadioButton2.CheckedChanged += new System.EventHandler(this.PreuzimanjeBrzinaRadioButton2_CheckedChanged);
            // 
            // PreuzimanjeBrzinaRadioButton3
            // 
            this.PreuzimanjeBrzinaRadioButton3.AutoSize = true;
            this.PreuzimanjeBrzinaRadioButton3.Location = new System.Drawing.Point(12, 128);
            this.PreuzimanjeBrzinaRadioButton3.Name = "PreuzimanjeBrzinaRadioButton3";
            this.PreuzimanjeBrzinaRadioButton3.Size = new System.Drawing.Size(64, 17);
            this.PreuzimanjeBrzinaRadioButton3.TabIndex = 6;
            this.PreuzimanjeBrzinaRadioButton3.TabStop = true;
            this.PreuzimanjeBrzinaRadioButton3.Text = "20 KB/s";
            this.PreuzimanjeBrzinaRadioButton3.UseVisualStyleBackColor = true;
            this.PreuzimanjeBrzinaRadioButton3.CheckedChanged += new System.EventHandler(this.PreuzimanjeBrzinaRadioButton3_CheckedChanged);
            // 
            // BrzinaPreutimanjaLabel
            // 
            this.BrzinaPreutimanjaLabel.AutoSize = true;
            this.BrzinaPreutimanjaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BrzinaPreutimanjaLabel.Location = new System.Drawing.Point(9, 62);
            this.BrzinaPreutimanjaLabel.Name = "BrzinaPreutimanjaLabel";
            this.BrzinaPreutimanjaLabel.Size = new System.Drawing.Size(129, 17);
            this.BrzinaPreutimanjaLabel.TabIndex = 7;
            this.BrzinaPreutimanjaLabel.Text = "Brzina preuzimanja";
            // 
            // PreuzimanjePostotakLabel
            // 
            this.PreuzimanjePostotakLabel.AutoSize = true;
            this.PreuzimanjePostotakLabel.Location = new System.Drawing.Point(599, 20);
            this.PreuzimanjePostotakLabel.Name = "PreuzimanjePostotakLabel";
            this.PreuzimanjePostotakLabel.Size = new System.Drawing.Size(21, 13);
            this.PreuzimanjePostotakLabel.TabIndex = 8;
            this.PreuzimanjePostotakLabel.Text = "0%";
            // 
            // PreuzimanjeZapočniButton
            // 
            this.PreuzimanjeZapočniButton.Location = new System.Drawing.Point(388, 65);
            this.PreuzimanjeZapočniButton.Name = "PreuzimanjeZapočniButton";
            this.PreuzimanjeZapočniButton.Size = new System.Drawing.Size(73, 23);
            this.PreuzimanjeZapočniButton.TabIndex = 9;
            this.PreuzimanjeZapočniButton.Text = "Započni";
            this.PreuzimanjeZapočniButton.UseVisualStyleBackColor = true;
            this.PreuzimanjeZapočniButton.Click += new System.EventHandler(this.PreuzimanjeZapočniButton_Click);
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(385, 105);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(40, 13);
            this.Speed.TabIndex = 10;
            this.Speed.Text = "0 KB/s";
            // 
            // HTTPDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 164);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.PreuzimanjeZapočniButton);
            this.Controls.Add(this.PreuzimanjePostotakLabel);
            this.Controls.Add(this.BrzinaPreutimanjaLabel);
            this.Controls.Add(this.PreuzimanjeBrzinaRadioButton3);
            this.Controls.Add(this.PreuzimanjeBrzinaRadioButton2);
            this.Controls.Add(this.PreuzimanjeBrzinaRadioButton1);
            this.Controls.Add(this.PreuzimanjeNastavibutton);
            this.Controls.Add(this.PreuzimanjeZaustaviButton);
            this.Controls.Add(this.PreuzimanjeNaslovLabel);
            this.Controls.Add(this.PreuzimanjeProgressBar);
            this.Name = "HTTPDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preuzimanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PreuzimanjeProgressBar;
        private System.Windows.Forms.Label PreuzimanjeNaslovLabel;
        private System.Windows.Forms.Button PreuzimanjeZaustaviButton;
        private System.Windows.Forms.Button PreuzimanjeNastavibutton;
        private System.Windows.Forms.RadioButton PreuzimanjeBrzinaRadioButton1;
        private System.Windows.Forms.RadioButton PreuzimanjeBrzinaRadioButton2;
        private System.Windows.Forms.RadioButton PreuzimanjeBrzinaRadioButton3;
        private System.Windows.Forms.Label BrzinaPreutimanjaLabel;
        private System.Windows.Forms.Label PreuzimanjePostotakLabel;
        private System.Windows.Forms.Button PreuzimanjeZapočniButton;
        private System.Windows.Forms.Label Speed;
    }
}