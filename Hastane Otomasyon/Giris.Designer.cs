namespace Hastane_Otomasyon
{
    partial class Giris
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
            this.tc_box = new System.Windows.Forms.TextBox();
            this.sifre_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.giris_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // tc_box
            // 
            this.tc_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc_box.Location = new System.Drawing.Point(142, 66);
            this.tc_box.Name = "tc_box";
            this.tc_box.Size = new System.Drawing.Size(206, 34);
            this.tc_box.TabIndex = 1;
            // 
            // sifre_box
            // 
            this.sifre_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_box.Location = new System.Drawing.Point(142, 130);
            this.sifre_box.Name = "sifre_box";
            this.sifre_box.PasswordChar = '*';
            this.sifre_box.Size = new System.Drawing.Size(206, 34);
            this.sifre_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // giris_button
            // 
            this.giris_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_button.Location = new System.Drawing.Point(121, 205);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(166, 66);
            this.giris_button.TabIndex = 4;
            this.giris_button.Text = "GİRİŞ";
            this.giris_button.UseVisualStyleBackColor = true;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(419, 319);
            this.Controls.Add(this.giris_button);
            this.Controls.Add(this.sifre_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tc_box);
            this.Controls.Add(this.label1);
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tc_box;
        private System.Windows.Forms.TextBox sifre_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button giris_button;
    }
}