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
    public partial class HastaSorgula : Form
    {
        public HastaSorgula()
        {
            InitializeComponent();
        }
        
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastane; uid=root; Password=Enes!1905; Charset=utf8");
        
        private void HastaSorgula_Load(object sender, EventArgs e)
        {
            tc_text.MaxLength = 11;
            sil_button.Enabled = false;
            guncelle_button.Enabled = false;
            doldur();
            dataGridView1.Columns[0].ReadOnly = true;
            ((DataGridViewTextBoxColumn)dataGridView1.Columns[1]).MaxInputLength = 11;
            ((DataGridViewTextBoxColumn)dataGridView1.Columns[8]).MaxInputLength = 11;
        }

        private void sorgu_button_Click(object sender, EventArgs e)
        {
            //datagridview temizleme
            dataGridView1.DataSource = null;
            sorgulama();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sil_button.Enabled = true;
            guncelle_button.Enabled = true; 
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            sil();
            MessageBox.Show("Başarıyla Silindi.");
        }
        
        private void guncelle_button_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        //Fonksiyonlar

        //Datagridview'i başlangıçta doldurmak için.
        public void doldur()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("SELECT * FROM hasta", baglanti);
            DataTable oku = new DataTable();
            listele.Fill(oku);
            dataGridView1.DataSource = oku;
            baglanti.Close();
        }
        //Textbox ta ki değere göre datagridview'i doldur.
        public void sorgulama()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("SELECT * FROM hasta WHERE hasta_tc = " + tc_text.Text, baglanti);
            DataTable oku = new DataTable();
            listele.Fill(oku);
            dataGridView1.DataSource = oku;
            baglanti.Close();
        }
        //Seçili olan satırı silme.
        public void sil()
        {
            string silinecek = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["hasta_tc"].Value);
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            baglanti.Open();
            MySqlCommand sil = new MySqlCommand("DELETE FROM hasta WHERE hasta_tc =" + silinecek, baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }
        //Seçili olan satırı güncelle.
        public void guncelle()
        {
            string g_tc, g_ad, g_soyad, g_dogumT, g_il, g_ilce, g_cinsiyet, g_telefon, g_kurum, g_mail;
            g_tc = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["hasta_tc"].Value);
            g_ad = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["hasta_ad"].Value);
            g_soyad = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["hasta_soyad"].Value);
            g_dogumT = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["hasta_dogumT"].Value);
            g_il = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["hasta_il"].Value);
            g_ilce = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["hasta_ilce"].Value);
            g_cinsiyet = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["hasta_cinsiyet"].Value);
            g_telefon = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["hasta_telefon"].Value);
            g_kurum = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["hasta_kurum"].Value);
            g_mail = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["hasta_mail"].Value);
            string komut = "UPDATE hasta SET hasta_ad = '"+g_ad+"', hasta_soyad = '"+g_soyad+"' " +
                ", hasta_dogumT = '"+g_dogumT+"', hasta_il = '"+g_il+"', hasta_ilce = '"+g_ilce+"', hasta_cinsiyet = '"+g_cinsiyet+"' " +
                ", hasta_telefon = '"+g_telefon+"', hasta_kurum = '"+g_kurum+"', hasta_mail = '"+g_mail+"' WHERE hasta_tc = '"+g_tc+"'";
            try
            {
                baglanti.Open();
                MySqlCommand guncelle = new MySqlCommand(komut, baglanti);
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Güncellendi");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            baglanti.Close();
        }
    }
}
