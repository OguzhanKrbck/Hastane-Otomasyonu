namespace Hastane_Otomasyon
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.hastaKG_button = new System.Windows.Forms.Button();
            this.doktor_button = new System.Windows.Forms.Button();
            this.yonetici_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hastaKG_button
            // 
            this.hastaKG_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaKG_button.Location = new System.Drawing.Point(84, 358);
            this.hastaKG_button.Name = "hastaKG_button";
            this.hastaKG_button.Size = new System.Drawing.Size(209, 113);
            this.hastaKG_button.TabIndex = 0;
            this.hastaKG_button.Text = "Hasta Kabul Görevlisi Giriş";
            this.hastaKG_button.UseVisualStyleBackColor = true;
            this.hastaKG_button.Click += new System.EventHandler(this.hastaKG_button_Click);
            // 
            // doktor_button
            // 
            this.doktor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_button.Location = new System.Drawing.Point(495, 358);
            this.doktor_button.Name = "doktor_button";
            this.doktor_button.Size = new System.Drawing.Size(209, 113);
            this.doktor_button.TabIndex = 1;
            this.doktor_button.Text = "Doktor Giriş";
            this.doktor_button.UseVisualStyleBackColor = true;
            this.doktor_button.Click += new System.EventHandler(this.doktor_button_Click);
            // 
            // yonetici_button
            // 
            this.yonetici_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetici_button.Location = new System.Drawing.Point(906, 358);
            this.yonetici_button.Name = "yonetici_button";
            this.yonetici_button.Size = new System.Drawing.Size(209, 113);
            this.yonetici_button.TabIndex = 2;
            this.yonetici_button.Text = "Yönetici Giriş";
            this.yonetici_button.UseVisualStyleBackColor = true;
            this.yonetici_button.Click += new System.EventHandler(this.yonetici_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1031, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1261, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yonetici_button);
            this.Controls.Add(this.doktor_button);
            this.Controls.Add(this.hastaKG_button);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AnaSayfa";
            this.Text = "Toprak Hastanesi";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hastaKG_button;
        private System.Windows.Forms.Button doktor_button;
        private System.Windows.Forms.Button yonetici_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

