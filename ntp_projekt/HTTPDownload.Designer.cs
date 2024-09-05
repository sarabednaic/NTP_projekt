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
            this.PreuzimanjeProgressBar.Location = new System.Drawing.Point(18, 55);
            this.PreuzimanjeProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreuzimanjeProgressBar.MarqueeAnimationSpeed = 100000;
            this.PreuzimanjeProgressBar.Name = "PreuzimanjeProgressBar";
            this.PreuzimanjeProgressBar.Size = new System.Drawing.Size(912, 35);
            this.PreuzimanjeProgressBar.Step = 5;
            this.PreuzimanjeProgressBar.TabIndex = 0;
            // 
            // PreuzimanjeNaslovLabel
            // 
            this.PreuzimanjeNaslovLabel.AutoSize = true;
            this.PreuzimanjeNaslovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PreuzimanjeNaslovLabel.Location = new System.Drawing.Point(18, 14);
            this.PreuzimanjeNaslovLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreuzimanjeNaslovLabel.Name = "PreuzimanjeNaslovLabel";
            this.PreuzimanjeNaslovLabel.Size = new System.Drawing.Size(173, 32);
            this.PreuzimanjeNaslovLabel.TabIndex = 1;
            this.PreuzimanjeNaslovLabel.Text = "Preuzimanje";
            // 
            // PreuzimanjeZaustaviButton
            // 
            this.PreuzimanjeZaustaviButton.Location = new System.Drawing.Point(700, 100);
            this.PreuzimanjeZaustaviButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreuzimanjeZaustaviButton.Name = "PreuzimanjeZaustaviButton";
            this.PreuzimanjeZaustaviButton.Size = new System.Drawing.Size(112, 35);
            this.PreuzimanjeZaustaviButton.TabIndex = 2;
            this.PreuzimanjeZaustaviButton.Text = "Zaustavi";
            this.PreuzimanjeZaustaviButton.UseVisualStyleBackColor = true;
            this.PreuzimanjeZaustaviButton.Click += new System.EventHandler(this.PreuzimanjeZaustaviButton_Click);
            // 
            // PreuzimanjeNastavibutton
            // 
            this.PreuzimanjeNastavibutton.Location = new System.Drawing.Point(822, 100);
            this.PreuzimanjeNastavibutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreuzimanjeNastavibutton.Name = "PreuzimanjeNastavibutton";
            this.PreuzimanjeNastavibutton.Size = new System.Drawing.Size(112, 35);
            this.PreuzimanjeNastavibutton.TabIndex = 3;
            this.PreuzimanjeNastavibutton.Text = "Nastavi";
            this.PreuzimanjeNastavibutton.UseVisualStyleBackColor = true;
            this.PreuzimanjeNastavibutton.Click += new System.EventHandler(this.PreuzimanjeNastavibutton_Click);
            // 
            // PreuzimanjeBrzinaRadioButton1
            // 
            this.PreuzimanjeBrzinaRadioButton1.AutoSize = true;
            this.PreuzimanjeBrzinaRadioButton1.Location = new System.Drawing.Point(18, 126);
            this.PreuzimanjeBrzinaRadioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreuzimanjeBrzinaRadioButton1.Name = "PreuzimanjeBrzinaRadioButton1";
            this.PreuzimanjeBrzinaRadioButton1.Size = new System.Drawing.Size(80, 24);
            this.PreuzimanjeBrzinaRadioButton1.TabIndex = 4;
            this.PreuzimanjeBrzinaRadioButton1.TabStop = true;
            this.PreuzimanjeBrzinaRadioButton1.Text = "5 KB/s";
            this.PreuzimanjeBrzinaRadioButton1.UseVisualStyleBackColor = true;
            this.PreuzimanjeBrzinaRadioButton1.CheckedChanged += new System.EventHandler(this.PreuzimanjeBrzinaRadioButton1_CheckedChanged);
            // 
            // PreuzimanjeBrzinaRadioButton2
            // 
            this.PreuzimanjeBrzinaRadioButton2.AutoSize = true;
            this.PreuzimanjeBrzinaRadioButton2.Location = new System.Drawing.Point(18, 162);
            this.PreuzimanjeBrzinaRadioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreuzimanjeBrzinaRadioButton2.Name = "PreuzimanjeBrzinaRadioButton2";
            this.PreuzimanjeBrzinaRadioButton2.Size = new System.Drawing.Size(89, 24);
            this.PreuzimanjeBrzinaRadioButton2.TabIndex = 5;
            this.PreuzimanjeBrzinaRadioButton2.TabStop = true;
            this.PreuzimanjeBrzinaRadioButton2.Text = "10 KB/s";
            this.PreuzimanjeBrzinaRadioButton2.UseVisualStyleBackColor = true;
            this.PreuzimanjeBrzinaRadioButton2.CheckedChanged += new System.EventHandler(this.PreuzimanjeBrzinaRadioButton2_CheckedChanged);
            // 
            // PreuzimanjeBrzinaRadioButton3
            // 
            this.PreuzimanjeBrzinaRadioButton3.AutoSize = true;
            this.PreuzimanjeBrzinaRadioButton3.Location = new System.Drawing.Point(18, 197);
            this.PreuzimanjeBrzinaRadioButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreuzimanjeBrzinaRadioButton3.Name = "PreuzimanjeBrzinaRadioButton3";
            this.PreuzimanjeBrzinaRadioButton3.Size = new System.Drawing.Size(89, 24);
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
            this.BrzinaPreutimanjaLabel.Location = new System.Drawing.Point(14, 95);
            this.BrzinaPreutimanjaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrzinaPreutimanjaLabel.Name = "BrzinaPreutimanjaLabel";
            this.BrzinaPreutimanjaLabel.Size = new System.Drawing.Size(178, 25);
            this.BrzinaPreutimanjaLabel.TabIndex = 7;
            this.BrzinaPreutimanjaLabel.Text = "Brzina preuzimanja";
            // 
            // PreuzimanjePostotakLabel
            // 
            this.PreuzimanjePostotakLabel.AutoSize = true;
            this.PreuzimanjePostotakLabel.Location = new System.Drawing.Point(898, 31);
            this.PreuzimanjePostotakLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreuzimanjePostotakLabel.Name = "PreuzimanjePostotakLabel";
            this.PreuzimanjePostotakLabel.Size = new System.Drawing.Size(32, 20);
            this.PreuzimanjePostotakLabel.TabIndex = 8;
            this.PreuzimanjePostotakLabel.Text = "0%";
            // 
            // PreuzimanjeZapočniButton
            // 
            this.PreuzimanjeZapočniButton.Location = new System.Drawing.Point(582, 100);
            this.PreuzimanjeZapočniButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreuzimanjeZapočniButton.Name = "PreuzimanjeZapočniButton";
            this.PreuzimanjeZapočniButton.Size = new System.Drawing.Size(110, 35);
            this.PreuzimanjeZapočniButton.TabIndex = 9;
            this.PreuzimanjeZapočniButton.Text = "Započni";
            this.PreuzimanjeZapočniButton.UseVisualStyleBackColor = true;
            this.PreuzimanjeZapočniButton.Click += new System.EventHandler(this.PreuzimanjeZapočniButton_Click);
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(578, 162);
            this.Speed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(55, 20);
            this.Speed.TabIndex = 10;
            this.Speed.Text = "0 KB/s";
            // 
            // HTTPDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 252);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HTTPDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preuzimanje";
            this.Load += new System.EventHandler(this.HTTPDownload_Load);
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