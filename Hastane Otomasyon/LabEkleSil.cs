using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Hastane_Otomasyon
{
    public partial class LabEkleSil : Form
    {
        public LabEkleSil()
        {
            InitializeComponent();
        }
        
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastane; Uid=root; Password=Enes!1905; Charset=utf8");
        
        private void LabEkleSil_Load(object sender, EventArgs e)
        {
            ekle_button.Enabled = false;
            sil_button.Enabled = false;
            doldur();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].ReadOnly = true;
            }
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ekle_button.Enabled = true;
            sil_button.Enabled = true;
        }

        private void ekle_button_Click(object sender, EventArgs e)
        {
            try
            {
                ekle();
                MessageBox.Show("Başariyla Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            try
            {
                sil();
                MessageBox.Show("Başariyla Silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void doldur()
        {
            string sorgu = "SELECT * FROM laboratuvar";
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter(sorgu, baglanti);
            DataTable oku = new DataTable();
            listele.Fill(oku);
            dataGridView1.DataSource = oku;
            baglanti.Close();
        }

        void ekle()
        {
            string isim = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["lab_isim"].Value);
            string komut = "INSERT INTO laboratuvar(lab_isim) VALUES(@lab_isim)";
            baglanti.Open();
            MySqlCommand ekle = new MySqlCommand(komut, baglanti);
            ekle.Parameters.AddWithValue("@lab_isim", isim);
            ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        void sil()
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["lab_id"].Value);
            string komut = "DELETE FROM laboratuvar WHERE lab_id = '" +id+ "'";
            baglanti.Open();
            MySqlCommand sil = new MySqlCommand(komut, baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }
    }
}
