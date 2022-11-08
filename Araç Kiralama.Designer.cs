namespace üyeEkleSilProje
{
    partial class arackiralamaFrm
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
            this.aracBtn = new System.Windows.Forms.Button();
            this.musteriBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.sozBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // aracBtn
            // 
            this.aracBtn.Location = new System.Drawing.Point(12, 63);
            this.aracBtn.Name = "aracBtn";
            this.aracBtn.Size = new System.Drawing.Size(154, 58);
            this.aracBtn.TabIndex = 1;
            this.aracBtn.Text = "Araçlar";
            this.aracBtn.UseVisualStyleBackColor = true;
            this.aracBtn.Click += new System.EventHandler(this.musteriBtn_Click);
            // 
            // musteriBtn
            // 
            this.musteriBtn.Location = new System.Drawing.Point(12, 151);
            this.musteriBtn.Name = "musteriBtn";
            this.musteriBtn.Size = new System.Drawing.Size(154, 58);
            this.musteriBtn.TabIndex = 1;
            this.musteriBtn.Text = "Müşteriler";
            this.musteriBtn.UseVisualStyleBackColor = true;
            this.musteriBtn.Click += new System.EventHandler(this.aracBtn_Click_1);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(12, 491);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(154, 58);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "x";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.anasayfaBtn_Click);
            // 
            // sozBtn
            // 
            this.sozBtn.Location = new System.Drawing.Point(12, 242);
            this.sozBtn.Name = "sozBtn";
            this.sozBtn.Size = new System.Drawing.Size(154, 58);
            this.sozBtn.TabIndex = 1;
            this.sozBtn.Text = "Sözleşme";
            this.sozBtn.UseVisualStyleBackColor = true;
            this.sozBtn.Click += new System.EventHandler(this.aracBtn_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::üyeEkleSilProje.Properties.Resources.sakarya_tayfun_arac_kiralama_1;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(188, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(876, 570);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // arackiralamaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1071, 587);
            this.Controls.Add(this.sozBtn);
            this.Controls.Add(this.musteriBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.aracBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "arackiralamaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button aracBtn;
        private System.Windows.Forms.Button musteriBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button sozBtn;
    }
}

