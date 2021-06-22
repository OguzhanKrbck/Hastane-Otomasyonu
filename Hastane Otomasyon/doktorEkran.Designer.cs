namespace Hastane_Otomasyon
{
    partial class DoktorEkran
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
            this.recete_button = new System.Windows.Forms.Button();
            this.hasta_button = new System.Windows.Forms.Button();
            this.lab_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recete_button
            // 
            this.recete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recete_button.Location = new System.Drawing.Point(61, 101);
            this.recete_button.Name = "recete_button";
            this.recete_button.Size = new System.Drawing.Size(236, 144);
            this.recete_button.TabIndex = 1;
            this.recete_button.Text = "Reçete Oluştur";
            this.recete_button.UseVisualStyleBackColor = true;
            this.recete_button.Click += new System.EventHandler(this.recete_button_Click);
            // 
            // hasta_button
            // 
            this.hasta_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_button.Location = new System.Drawing.Point(352, 101);
            this.hasta_button.Name = "hasta_button";
            this.hasta_button.Size = new System.Drawing.Size(236, 144);
            this.hasta_button.TabIndex = 2;
            this.hasta_button.Text = "Hastalarım";
            this.hasta_button.UseVisualStyleBackColor = true;
            this.hasta_button.Click += new System.EventHandler(this.hasta_button_Click);
            // 
            // lab_button
            // 
            this.lab_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lab_button.Location = new System.Drawing.Point(646, 101);
            this.lab_button.Name = "lab_button";
            this.lab_button.Size = new System.Drawing.Size(236, 144);
            this.lab_button.TabIndex = 3;
            this.lab_button.Text = "Laboratuvar Kayıt";
            this.lab_button.UseVisualStyleBackColor = true;
            this.lab_button.Click += new System.EventHandler(this.lab_button_Click);
            // 
            // DoktorEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(943, 357);
            this.Controls.Add(this.lab_button);
            this.Controls.Add(this.hasta_button);
            this.Controls.Add(this.recete_button);
            this.Name = "DoktorEkran";
            this.Text = "Doktor Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recete_button;
        private System.Windows.Forms.Button hasta_button;
        private System.Windows.Forms.Button lab_button;
    }
}