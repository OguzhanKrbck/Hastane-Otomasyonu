namespace Hastane_Otomasyon
{
    partial class HastaSorgula
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_text = new System.Windows.Forms.TextBox();
            this.sorgu_button = new System.Windows.Forms.Button();
            this.sil_button = new System.Windows.Forms.Button();
            this.guncelle_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(568, 572);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(706, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tc Kimlik No";
            // 
            // tc_text
            // 
            this.tc_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc_text.Location = new System.Drawing.Point(684, 176);
            this.tc_text.Name = "tc_text";
            this.tc_text.Size = new System.Drawing.Size(257, 34);
            this.tc_text.TabIndex = 2;
            // 
            // sorgu_button
            // 
            this.sorgu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorgu_button.Location = new System.Drawing.Point(741, 247);
            this.sorgu_button.Name = "sorgu_button";
            this.sorgu_button.Size = new System.Drawing.Size(154, 69);
            this.sorgu_button.TabIndex = 3;
            this.sorgu_button.Text = "Sorgu";
            this.sorgu_button.UseVisualStyleBackColor = true;
            this.sorgu_button.Click += new System.EventHandler(this.sorgu_button_Click);
            // 
            // sil_button
            // 
            this.sil_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_button.Location = new System.Drawing.Point(634, 353);
            this.sil_button.Name = "sil_button";
            this.sil_button.Size = new System.Drawing.Size(154, 69);
            this.sil_button.TabIndex = 4;
            this.sil_button.Text = "Sil";
            this.sil_button.UseVisualStyleBackColor = true;
            this.sil_button.Click += new System.EventHandler(this.sil_button_Click);
            // 
            // guncelle_button
            // 
            this.guncelle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_button.Location = new System.Drawing.Point(854, 353);
            this.guncelle_button.Name = "guncelle_button";
            this.guncelle_button.Size = new System.Drawing.Size(154, 69);
            this.guncelle_button.TabIndex = 5;
            this.guncelle_button.Text = "Güncelle";
            this.guncelle_button.UseVisualStyleBackColor = true;
            this.guncelle_button.Click += new System.EventHandler(this.guncelle_button_Click);
            // 
            // HastaSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1084, 572);
            this.Controls.Add(this.guncelle_button);
            this.Controls.Add(this.sil_button);
            this.Controls.Add(this.sorgu_button);
            this.Controls.Add(this.tc_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HastaSorgula";
            this.Text = "HastaSorgula";
            this.Load += new System.EventHandler(this.HastaSorgula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tc_text;
        private System.Windows.Forms.Button sorgu_button;
        private System.Windows.Forms.Button sil_button;
        private System.Windows.Forms.Button guncelle_button;
    }
}