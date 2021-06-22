namespace Hastane_Otomasyon
{
    partial class HastaKabulEkran
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
            this.ekle_button = new System.Windows.Forms.Button();
            this.sorgu_button = new System.Windows.Forms.Button();
            this.randevuVer_button = new System.Windows.Forms.Button();
            this.randevuSorgu_button = new System.Windows.Forms.Button();
            this.labSorgu_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekle_button
            // 
            this.ekle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_button.Location = new System.Drawing.Point(24, 26);
            this.ekle_button.Name = "ekle_button";
            this.ekle_button.Size = new System.Drawing.Size(235, 120);
            this.ekle_button.TabIndex = 0;
            this.ekle_button.Text = "Hasta Ekle";
            this.ekle_button.UseVisualStyleBackColor = true;
            this.ekle_button.Click += new System.EventHandler(this.ekle_button_Click);
            // 
            // sorgu_button
            // 
            this.sorgu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorgu_button.Location = new System.Drawing.Point(352, 26);
            this.sorgu_button.Name = "sorgu_button";
            this.sorgu_button.Size = new System.Drawing.Size(235, 120);
            this.sorgu_button.TabIndex = 1;
            this.sorgu_button.Text = "Hasta Sorgula";
            this.sorgu_button.UseVisualStyleBackColor = true;
            this.sorgu_button.Click += new System.EventHandler(this.sorgu_button_Click);
            // 
            // randevuVer_button
            // 
            this.randevuVer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuVer_button.Location = new System.Drawing.Point(680, 26);
            this.randevuVer_button.Name = "randevuVer_button";
            this.randevuVer_button.Size = new System.Drawing.Size(235, 120);
            this.randevuVer_button.TabIndex = 2;
            this.randevuVer_button.Text = "Randevu Ver";
            this.randevuVer_button.UseVisualStyleBackColor = true;
            this.randevuVer_button.Click += new System.EventHandler(this.randevuVer_button_Click);
            // 
            // randevuSorgu_button
            // 
            this.randevuSorgu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuSorgu_button.Location = new System.Drawing.Point(155, 234);
            this.randevuSorgu_button.Name = "randevuSorgu_button";
            this.randevuSorgu_button.Size = new System.Drawing.Size(235, 120);
            this.randevuSorgu_button.TabIndex = 3;
            this.randevuSorgu_button.Text = "Randevu Sorgula";
            this.randevuSorgu_button.UseVisualStyleBackColor = true;
            this.randevuSorgu_button.Click += new System.EventHandler(this.randevuSorgu_button_Click);
            // 
            // labSorgu_button
            // 
            this.labSorgu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labSorgu_button.Location = new System.Drawing.Point(554, 234);
            this.labSorgu_button.Name = "labSorgu_button";
            this.labSorgu_button.Size = new System.Drawing.Size(235, 120);
            this.labSorgu_button.TabIndex = 4;
            this.labSorgu_button.Text = "Laboratuvar Sorgu ";
            this.labSorgu_button.UseVisualStyleBackColor = true;
            this.labSorgu_button.Click += new System.EventHandler(this.labSorgu_button_Click);
            // 
            // HastaKabulEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(951, 415);
            this.Controls.Add(this.labSorgu_button);
            this.Controls.Add(this.randevuSorgu_button);
            this.Controls.Add(this.randevuVer_button);
            this.Controls.Add(this.sorgu_button);
            this.Controls.Add(this.ekle_button);
            this.Name = "HastaKabulEkran";
            this.Text = " Hasta Kabul Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ekle_button;
        private System.Windows.Forms.Button sorgu_button;
        private System.Windows.Forms.Button randevuVer_button;
        private System.Windows.Forms.Button randevuSorgu_button;
        private System.Windows.Forms.Button labSorgu_button;
    }
}