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
    public partial class HastaEkle : Form
    {
        public HastaEkle()
        {
            InitializeComponent();
        }
        
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastane; uid=root; Password=Enes!1905; Charset=utf8");
        
        private void HastaEkle_Load(object sender, EventArgs e)
        {
            baslangicDeger();

        }

        private void ekle_button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                ekle();
                baglanti.Close();
                MessageBox.Show("Başarıyla eklendi");
                temizle();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
            }
        }

        public void ekle()
        {
            string tcNo = "", ad = "", soyad = "", dogumTarihi = "", il = "", ilce = "", cinsiyet = "", telefon = "", kurum = "", mail = "";

            if (tc_text.TextLength == 11 && ad_text.Text != null && soyad_text.Text != null && il_text.Text != null &&
                ilce_text.Text != null && telefon_text.TextLength == 11 && mail_text.Text != null)
            {
                tcNo = tc_text.Text;
                ad = ad_text.Text;
                soyad = soyad_text.Text;
                dogumTarihi = dogumT_dtp.Text;
                il = il_text.Text;
                ilce = ilce_text.Text;
                cinsiyet = cinsiyet_combo.Text;
                telefon = telefon_text.Text;
                kurum = kurum_combo.Text;
                mail = mail_text.Text + "@" + mail_combo.Text;
            }
            else
                MessageBox.Show("Eksik veya yanlış bilgi girdiniz.");

            string komut = "INSERT INTO hasta(hasta_tc, hasta_ad, hasta_soyad, hasta_dogumT, hasta_il, hasta_ilce, hasta_cinsiyet," +
                           "hasta_telefon, hasta_kurum, hasta_mail) " +
                            "VALUES(@tcNo, @ad, @soyad, @dTarihi, @il, @ilce, @cinsiyet, @tel, @kurum, @mail)";
            MySqlCommand ekle = new MySqlCommand(komut, baglanti);
            ekle.Parameters.AddWithValue("@tcNo", tcNo);
            ekle.Parameters.AddWithValue("@ad", ad);
            ekle.Parameters.AddWithValue("@soyad", soyad);
            ekle.Parameters.AddWithValue("@dTarihi", dogumTarihi);
            ekle.Parameters.AddWithValue("@il", il);
            ekle.Parameters.AddWithValue("@ilce", ilce);
            ekle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            ekle.Parameters.AddWithValue("@tel", telefon);
            ekle.Parameters.AddWithValue("@kurum", kurum);
            ekle.Parameters.AddWithValue("@mail", mail);
            ekle.ExecuteNonQuery();
        }
        
        
        public void baslangicDeger()
        {
            tc_text.MaxLength = 11;
            telefon_text.MaxLength = 11;
            cinsiyet_combo.Items.Add("Erkek");
            cinsiyet_combo.Items.Add("Kadın");
            cinsiyet_combo.SelectedIndex = 0;
            kurum_combo.Items.Add("SGK");
            kurum_combo.Items.Add("Emekli Sandığı");
            kurum_combo.Items.Add("Bağ-Kur");
            kurum_combo.SelectedIndex = 0;
            mail_combo.Items.Add("hotmail.com");
            mail_combo.Items.Add("gmail.com");
            mail_combo.Items.Add("outlook.com");
            mail_combo.SelectedIndex = 0;
        }
        public void temizle()
        {
            tc_text.Clear();
            ad_text.Clear();
            soyad_text.Clear();
            il_text.Clear();
            ilce_text.Clear();
            telefon_text.Clear();
            mail_text.Clear();
            cinsiyet_combo.SelectedIndex = 0;
            kurum_combo.SelectedIndex = 0;
            mail_combo.SelectedIndex = 0;
        }
    }
}
