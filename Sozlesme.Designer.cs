﻿namespace üyeEkleSilProje
{
    partial class sozlesmeFrm
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(32, 454);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(114, 64);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "x";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // sozlesmeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 540);
            this.Controls.Add(this.closeBtn);
            this.Name = "sozlesmeFrm";
            this.Text = "Sözleşme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
    }
}