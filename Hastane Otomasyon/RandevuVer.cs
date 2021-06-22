using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Hastane_Otomasyon
{
    public partial class RandevuVer : Form
    {
        public RandevuVer()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastane; uid=root; Password=Enes!1905; Charset=utf8");
        List<int> dr_id = new List<int>();
        private void RandevuVer_Load(object sender, EventArgs e)
        {
            tc_text.MaxLength = 11;
            baglanti.Open();
            klinikDoldur();
            baglanti.Close();
        }
        private void klinik_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            doktorDoldur();
            baglanti.Close();
        }
        private void doktor_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            saatDoldur();
            baglanti.Close();
        }
        private void randevu_button_Click(object sender, EventArgs e)
        {
            try
            {
                randevuVer();
                MessageBox.Show("Başarılı İşlem.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
            }
        }

        //funcs
        void klinikDoldur()
        {
            string sorgu = "SELECT klinik_isim FROM klinik";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader dr = komut.ExecuteReader();
            List<string> klinik = new List<string>();
            while (dr.Read())
            {
                klinik.Add(dr["klinik_isim"].ToString());
            }
            foreach (string isim in klinik)
            {
                klinik_combo.Items.Add(isim);
            }
        }
        void doktorDoldur()
        {
            doktor_combo.Items.Clear();
            doktor_combo.Text = "";
            string klinik = klinik_combo.Text;
            string sorgu = "SELECT dr_ad, dr_id FROM doktor INNER JOIN klinik ON doktor.klinik_id = klinik.klinik_id WHERE klinik.klinik_isim ='"+klinik+"'";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader dr = komut.ExecuteReader();
            List<string> doktor = new List<string>();
            while (dr.Read())
            {
                doktor.Add(dr["dr_ad"].ToString());
                dr_id.Add(Convert.ToInt32(dr["dr_id"]));
            }
            foreach(string ad in doktor)
            {
                doktor_combo.Items.Add(ad);
            }
        }
        void saatDoldur()
        {
            saat_combo.Items.Clear();
            saat_combo.Text = "";
            int sec = doktor_combo.SelectedIndex;
            List<string> saat = new List<string>();
            saat.Add("09:00"); saat.Add("09:30"); saat.Add("10:00"); saat.Add("10:30"); saat.Add("11:00"); saat.Add("11:30"); saat.Add("12:00");
            saat.Add("13:30"); saat.Add("14:00"); saat.Add("14:30"); saat.Add("15:00"); saat.Add("15:30"); saat.Add("16:00"); saat.Add("16:30");
            string sorgu = "SELECT randevu_saat FROM doktor INNER JOIN randevu ON doktor.dr_id = randevu.dr_id WHERE doktor.dr_id = '"+dr_id[sec]+"'";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                for(int i=0; i<saat.Count; i++)
                {
                    if (dr["randevu_saat"].ToString() == saat[i])
                            saat.RemoveAt(i);
                }
            }
            foreach(string s in saat)
            {
                saat_combo.Items.Add(s);
            }
        }
        void randevuVer()
        {
            string saat = saat_combo.Text;
            string ekle = "INSERT INTO randevu(randevu_saat, dr_id, hasta_id, klinik_id) VALUES(@saat, @dr_id, @hasta_id, @klinik_id)";
            MySqlCommand komut = new MySqlCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@saat", saat);
            komut.Parameters.AddWithValue("@dr_id", dr_id[doktor_combo.SelectedIndex]);
            komut.Parameters.AddWithValue("@hasta_id", hastaID());
            komut.Parameters.AddWithValue("@klinik_id", klinikID());
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            tc_text.Clear();
            klinik_combo.Text = "";
            doktor_combo.Text = "";
            saat_combo.Text = "";
        }
        int hastaID()
        {
            int deger;
            string tcNo = tc_text.Text;
            string sorgu = "SELECT hasta_id FROM hasta WHERE hasta_tc = '"+tcNo+"'";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            deger = Convert.ToInt32(dr["hasta_id"]);
            baglanti.Close();
            return deger;
        }
        int klinikID()
        {
            baglanti.Open();
            int deger;
            string klinik = klinik_combo.Text;
            string sorgu = "SELECT klinik_id FROM klinik WHERE klinik_isim = '"+klinik+"'";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            deger = Convert.ToInt32(dr["klinik_id"]);
            baglanti.Close();
            return deger;
        }

    }
}
