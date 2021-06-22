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
    public partial class RandevuSorgu : Form
    {
        public RandevuSorgu()
        {
            InitializeComponent();
        }
       
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastane; uid=root; Password=Enes!1905; Charset=utf8");
        
        private void RandevuSorgu_Load(object sender, EventArgs e)
        {
            tc_text.MaxLength = 11;
            sil_button.Enabled = false;
            doldur();
        }
       
         
        private void sorgu_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            sorgula();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sil_button.Enabled = true;
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            sil();
        }

        void doldur()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("SELECT h.hasta_tc, h.hasta_ad, r.klinik_id, r.dr_id, r.randevu_saat, r.randevu_id" +
                " FROM randevu AS r INNER JOIN hasta h ON r.hasta_id = h.hasta_id", baglanti);
            DataTable oku = new DataTable();
            listele.Fill(oku);
            dataGridView1.DataSource = oku;
            baglanti.Close();
        }

        void sorgula()
        {
            int id = deger();
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("SELECT h.hasta_tc, h.hasta_ad, r.klinik_id, r.dr_id, r.randevu_saat, r.randevu_id" +
                " FROM randevu AS r INNER JOIN hasta h ON r.hasta_id = h.hasta_id WHERE h.hasta_id = '" + id + "'", baglanti);
            DataTable oku = new DataTable();
            listele.Fill(oku);
            dataGridView1.DataSource = oku;
            baglanti.Close();
        }

        void sil()
        {
            string silinecek = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["randevu_id"].Value);
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            baglanti.Open();
            MySqlCommand sil = new MySqlCommand("DELETE FROM randevu WHERE randevu_id = '" +silinecek+ "'", baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        int deger()
        {
            int id = 0;
            baglanti.Open();
            try
            {
                MySqlCommand komut = new MySqlCommand("SELECT hasta_id FROM hasta WHERE hasta_tc = '" + tc_text.Text + "'", baglanti);
                MySqlDataReader dr = komut.ExecuteReader();
                dr.Read();
                id = Convert.ToInt32(dr["hasta_id"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bulunamadı.");
            }
            baglanti.Close();
            return id;
        }


    }
}
