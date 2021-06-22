namespace Hastane_Otomasyon
{
    partial class RandevuVer
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
            this.label1 = new System.Windows.Forms.Label();
            this.tc_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.klinik_combo = new System.Windows.Forms.ComboBox();
            this.doktor_combo = new System.Windows.Forms.ComboBox();
            this.saat_combo = new System.Windows.Forms.ComboBox();
            this.randevu_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // tc_text
            // 
            this.tc_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc_text.Location = new System.Drawing.Point(248, 47);
            this.tc_text.Name = "tc_text";
            this.tc_text.Size = new System.Drawing.Size(184, 30);
            this.tc_text.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(45, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Randevu Saati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(45, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Klinik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(45, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doktor:";
            // 
            // klinik_combo
            // 
            this.klinik_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.klinik_combo.FormattingEnabled = true;
            this.klinik_combo.Location = new System.Drawing.Point(248, 106);
            this.klinik_combo.Name = "klinik_combo";
            this.klinik_combo.Size = new System.Drawing.Size(184, 33);
            this.klinik_combo.TabIndex = 11;
            this.klinik_combo.SelectedIndexChanged += new System.EventHandler(this.klinik_combo_SelectedIndexChanged);
            // 
            // doktor_combo
            // 
            this.doktor_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_combo.FormattingEnabled = true;
            this.doktor_combo.Location = new System.Drawing.Point(248, 164);
            this.doktor_combo.Name = "doktor_combo";
            this.doktor_combo.Size = new System.Drawing.Size(184, 33);
            this.doktor_combo.TabIndex = 12;
            this.doktor_combo.SelectedIndexChanged += new System.EventHandler(this.doktor_combo_SelectedIndexChanged);
            // 
            // saat_combo
            // 
            this.saat_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat_combo.FormattingEnabled = true;
            this.saat_combo.Location = new System.Drawing.Point(248, 227);
            this.saat_combo.Name = "saat_combo";
            this.saat_combo.Size = new System.Drawing.Size(184, 33);
            this.saat_combo.TabIndex = 14;
            // 
            // randevu_button
            // 
            this.randevu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevu_button.Location = new System.Drawing.Point(154, 292);
            this.randevu_button.Name = "randevu_button";
            this.randevu_button.Size = new System.Drawing.Size(167, 88);
            this.randevu_button.TabIndex = 15;
            this.randevu_button.Text = "Randevu Ver";
            this.randevu_button.UseVisualStyleBackColor = true;
            this.randevu_button.Click += new System.EventHandler(this.randevu_button_Click);
            // 
            // RandevuVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(501, 413);
            this.Controls.Add(this.randevu_button);
            this.Controls.Add(this.saat_combo);
            this.Controls.Add(this.doktor_combo);
            this.Controls.Add(this.klinik_combo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tc_text);
            this.Controls.Add(this.label1);
            this.Name = "RandevuVer";
            this.Text = "RandevuVer";
            this.Load += new System.EventHandler(this.RandevuVer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tc_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox klinik_combo;
        private System.Windows.Forms.ComboBox doktor_combo;
        private System.Windows.Forms.ComboBox saat_combo;
        private System.Windows.Forms.Button randevu_button;
    }
}