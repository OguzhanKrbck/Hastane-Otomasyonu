namespace Hastane_Otomasyon
{
    partial class KlinikEkleSil
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
            this.sil_button = new System.Windows.Forms.Button();
            this.ekle_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sil_button
            // 
            this.sil_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_button.Location = new System.Drawing.Point(394, 211);
            this.sil_button.Name = "sil_button";
            this.sil_button.Size = new System.Drawing.Size(169, 78);
            this.sil_button.TabIndex = 5;
            this.sil_button.Text = "Sil";
            this.sil_button.UseVisualStyleBackColor = true;
            this.sil_button.Click += new System.EventHandler(this.sil_button_Click);
            // 
            // ekle_button
            // 
            this.ekle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_button.Location = new System.Drawing.Point(394, 48);
            this.ekle_button.Name = "ekle_button";
            this.ekle_button.Size = new System.Drawing.Size(169, 78);
            this.ekle_button.TabIndex = 4;
            this.ekle_button.Text = "Ekle";
            this.ekle_button.UseVisualStyleBackColor = true;
            this.ekle_button.Click += new System.EventHandler(this.ekle_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(337, 316);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // KlinikEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(602, 316);
            this.Controls.Add(this.sil_button);
            this.Controls.Add(this.ekle_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KlinikEkleSil";
            this.Text = "KlinikEkleSil";
            this.Load += new System.EventHandler(this.KlinikEkleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sil_button;
        private System.Windows.Forms.Button ekle_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}