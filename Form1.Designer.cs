﻿namespace TypingSpeed
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SourceText = new System.Windows.Forms.Label();
            this.TargetText = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.TypingProgress = new System.Windows.Forms.ProgressBar();
            this.TypingTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeProgress = new System.Windows.Forms.ProgressBar();
            this.CurrentCPM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceText
            // 
            this.SourceText.BackColor = System.Drawing.SystemColors.Control;
            this.SourceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceText.Location = new System.Drawing.Point(12, 9);
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(759, 146);
            this.SourceText.TabIndex = 0;
            this.SourceText.Text = resources.GetString("SourceText.Text");
            // 
            // TargetText
            // 
            this.TargetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetText.Location = new System.Drawing.Point(12, 235);
            this.TargetText.Multiline = true;
            this.TargetText.Name = "TargetText";
            this.TargetText.Size = new System.Drawing.Size(759, 153);
            this.TargetText.TabIndex = 1;
            this.TargetText.TextChanged += new System.EventHandler(this.TargetText_TextChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::TypingSpeed.Properties.Resources.close_blue;
            this.CloseButton.Location = new System.Drawing.Point(691, 394);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(80, 80);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // TypingProgress
            // 
            this.TypingProgress.Location = new System.Drawing.Point(12, 195);
            this.TypingProgress.Name = "TypingProgress";
            this.TypingProgress.Size = new System.Drawing.Size(754, 23);
            this.TypingProgress.TabIndex = 3;
            // 
            // TypingTimer
            // 
            this.TypingTimer.Interval = 1000;
            this.TypingTimer.Tick += new System.EventHandler(this.TypingTimer_Tick);
            // 
            // TimeProgress
            // 
            this.TimeProgress.Location = new System.Drawing.Point(12, 166);
            this.TimeProgress.Name = "TimeProgress";
            this.TimeProgress.Size = new System.Drawing.Size(754, 23);
            this.TimeProgress.TabIndex = 4;
            // 
            // CurrentCPM
            // 
            this.CurrentCPM.AutoSize = true;
            this.CurrentCPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CurrentCPM.Location = new System.Drawing.Point(17, 418);
            this.CurrentCPM.Name = "CurrentCPM";
            this.CurrentCPM.Size = new System.Drawing.Size(149, 25);
            this.CurrentCPM.TabIndex = 5;
            this.CurrentCPM.Text = "Current CPM: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 486);
            this.ControlBox = false;
            this.Controls.Add(this.CurrentCPM);
            this.Controls.Add(this.TimeProgress);
            this.Controls.Add(this.TypingProgress);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TargetText);
            this.Controls.Add(this.SourceText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SourceText;
        private System.Windows.Forms.TextBox TargetText;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.ProgressBar TypingProgress;
        private System.Windows.Forms.Timer TypingTimer;
        private System.Windows.Forms.ProgressBar TimeProgress;
        private System.Windows.Forms.Label CurrentCPM;
    }
}

