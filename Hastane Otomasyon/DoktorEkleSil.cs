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
    public partial class DoktorEkleSil : Form
    {
        public DoktorEkleSil()
        {
            InitializeComponent();
        }
       
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastane; Uid=root; Password=Enes!1905");
        
        private void DoktorEkleSil_Load(object sender, EventArgs e)
        {
            ekle_button.Enabled = false;
            sil_button.Enabled = false;
            doldur();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].ReadOnly = true;
            }
            dataGridView1.Columns[0].ReadOnly = true;
            ((DataGridViewTextBoxColumn)dataGridView1.Columns[3]).MaxInputLength = 11;
            ((DataGridViewTextBoxColumn)dataGridView1.Columns[5]).MaxInputLength = 11;
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
                MessageBox.Show("Başarıyla Silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void doldur()
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM doktor";
            MySqlDataAdapter listele = new MySqlDataAdapter(sorgu, baglanti);
            DataTable oku = new DataTable();
            listele.Fill(oku);
            dataGridView1.DataSource = oku;
            baglanti.Close();
        }


        void ekle()
        {
            string ad = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["dr_ad"].Value);
            string soyad = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["dr_soyad"].Value);
            string tc = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["dr_tc"].Value);
            string cinsiyet = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["dr_cinsiyet"].Value);
            string telefon = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["dr_telefon"].Value);
            string sifre = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["dr_sifre"].Value);
            int klinik = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["klinik_id"].Value);

            baglanti.Open();
            string komut = "INSERT INTO doktor(dr_ad, dr_soyad, dr_tc, dr_cinsiyet, dr_telefon, dr_sifre, klinik_id)" +
                "VALUES(@ad, @soyad, @tc, @cinsiyet, @telefon, @sifre, @klinik)";
            MySqlCommand ekle = new MySqlCommand(komut, baglanti);
            ekle.Parameters.AddWithValue("@ad", ad);
            ekle.Parameters.AddWithValue("@soyad", soyad);
            ekle.Parameters.AddWithValue("@tc", tc);
            ekle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            ekle.Parameters.AddWithValue("@telefon", telefon);
            ekle.Parameters.AddWithValue("@sifre", sifre);
            ekle.Parameters.AddWithValue("@klinik", klinik);
            ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        void sil()
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["dr_id"].Value);
            string komut = "DELETE FROM doktor WHERE dr_id = '" + id + "'";
            baglanti.Open();
            MySqlCommand sil = new MySqlCommand(komut, baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }
    }
}
