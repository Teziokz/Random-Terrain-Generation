﻿namespace MapGenerator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.genButton = new System.Windows.Forms.Button();
            this.centreBar = new System.Windows.Forms.TrackBar();
            this.Centr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.centreBar)).BeginInit();
            this.SuspendLayout();
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(506, 592);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(75, 23);
            this.genButton.TabIndex = 1;
            this.genButton.Text = "Regenerate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // centreBar
            // 
            this.centreBar.Location = new System.Drawing.Point(12, 684);
            this.centreBar.Maximum = 100;
            this.centreBar.Name = "centreBar";
            this.centreBar.Size = new System.Drawing.Size(143, 45);
            this.centreBar.TabIndex = 2;
            this.centreBar.TickFrequency = 0;
            this.centreBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.centreBar.Scroll += new System.EventHandler(this.centreBar_Scroll);
            // 
            // Centr
            // 
            this.Centr.AutoSize = true;
            this.Centr.Location = new System.Drawing.Point(47, 668);
            this.Centr.Name = "Centr";
            this.Centr.Size = new System.Drawing.Size(70, 13);
            this.Centr.TabIndex = 3;
            this.Centr.Text = "Centralisation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 741);
            this.Controls.Add(this.Centr);
            this.Controls.Add(this.centreBar);
            this.Controls.Add(this.genButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.centreBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.TrackBar centreBar;
        private System.Windows.Forms.Label Centr;
    }
}

