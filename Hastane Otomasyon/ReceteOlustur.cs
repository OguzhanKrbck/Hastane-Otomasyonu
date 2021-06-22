using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Hastane_Otomasyon
{
    public partial class ReceteOlustur : Form
    {
        public ReceteOlustur()
        {
            InitializeComponent();
        }
        
        public string doktor_tc { get; set; }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastane; Uid=root; Password=Enes!1905; Charset=utf8");

        private void ReceteOlustur_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Enabled = false;
            tc_text.MaxLength = 11;
        }

        private void olustur_button_Click(object sender, EventArgs e)
        {
            ekle();
        }
        void ekle()
        {
            if(hastaID() != 0 && doktorID() != 0)
            {
                string hasta_tc, aciklama, tarih;
                hasta_tc = tc_text.Text;
                aciklama = aciklama_text.Text;
                tarih = dateTimePicker1.Text;
                string komut = "INSERT INTO recete(hasta_id, dr_id, dr_aciklama, recete_tarih) VALUES(@hasta_id, @dr_id, @dr_aciklama, @recete_tarih)";
                MySqlCommand ekle = new MySqlCommand(komut, baglanti);
                ekle.Parameters.AddWithValue("@hasta_id", hastaID());
                ekle.Parameters.AddWithValue("dr_id", doktorID());
                ekle.Parameters.AddWithValue("@dr_aciklama", aciklama);
                ekle.Parameters.AddWithValue("@recete_tarih", tarih);
                baglanti.Open();
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla oluşturuldu.");
            }
        }

        int hastaID()
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
                MessageBox.Show("Hasta bulunamadı.");
            }
            baglanti.Close();
            return id;
        }
        
        int doktorID()
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT dr_id FROM doktor WHERE dr_tc = '" + doktor_tc + "'", baglanti);
            MySqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            int id = Convert.ToInt32(dr["dr_id"]);
            baglanti.Close();
            return id;     
        }
    }
}
