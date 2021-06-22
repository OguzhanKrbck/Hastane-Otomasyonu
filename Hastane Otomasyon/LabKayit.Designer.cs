namespace Hastane_Otomasyon
{
    partial class LabKayit
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
            this.label2 = new System.Windows.Forms.Label();
            this.lab_combo = new System.Windows.Forms.ComboBox();
            this.ekle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // tc_text
            // 
            this.tc_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc_text.Location = new System.Drawing.Point(245, 38);
            this.tc_text.Name = "tc_text";
            this.tc_text.Size = new System.Drawing.Size(184, 34);
            this.tc_text.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Laboratuvar:";
            // 
            // lab_combo
            // 
            this.lab_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lab_combo.FormattingEnabled = true;
            this.lab_combo.Location = new System.Drawing.Point(245, 112);
            this.lab_combo.Name = "lab_combo";
            this.lab_combo.Size = new System.Drawing.Size(184, 37);
            this.lab_combo.TabIndex = 3;
            // 
            // ekle_button
            // 
            this.ekle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_button.Location = new System.Drawing.Point(170, 197);
            this.ekle_button.Name = "ekle_button";
            this.ekle_button.Size = new System.Drawing.Size(158, 80);
            this.ekle_button.TabIndex = 4;
            this.ekle_button.Text = "Ekle";
            this.ekle_button.UseVisualStyleBackColor = true;
            this.ekle_button.Click += new System.EventHandler(this.ekle_button_Click);
            // 
            // LabKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(485, 317);
            this.Controls.Add(this.ekle_button);
            this.Controls.Add(this.lab_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tc_text);
            this.Controls.Add(this.label1);
            this.Name = "LabKayit";
            this.Text = "Laboratuvar İşlem Kayıt";
            this.Load += new System.EventHandler(this.LabKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tc_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lab_combo;
        private System.Windows.Forms.Button ekle_button;
    }
}