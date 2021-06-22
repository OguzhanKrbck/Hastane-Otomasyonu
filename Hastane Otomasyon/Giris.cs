using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Hastane_Otomasyon
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastane; uid=root; Password=Enes!1905; Charset=utf8");
        MySqlCommand komut;
        MySqlDataReader dr;
        private void Giris_Load(object sender, EventArgs e)
        {
            tc_box.MaxLength = 11;
            sifre_box.MaxLength = 20;
           
        }
        public int yetki { get; set; }

        private void giris_button_Click(object sender, EventArgs e)
        {
            string tcNo, sifre;
            tcNo = tc_box.Text.ToString();
            sifre = sifre_box.Text.ToString();
            int giris;
            AnaSayfa ana = new AnaSayfa();
            giris = girisKontrol(tcNo, sifre);
            switch (giris)
            {
                case 1: case 3: case 5:
                    MessageBox.Show("Bilgileriniz Yanlış!");
                    break;
                case 0:
                    YoneticiEkran ye = new YoneticiEkran();
                    ye.Show();
                    this.Close();
                    ana.Close();
                    break;
                case 2:
                    DoktorEkran de = new DoktorEkran();
                    de.doktor_tc = tcNo;
                    de.Show();
                    this.Close();
                    ana.Close();
                    break;
                case 4:
                    HastaKabulEkran hke = new HastaKabulEkran();
                    hke.Show();
                    this.Close();
                    ana.Close();
                    break;
            }
        }
        public int girisKontrol(string tcNo, string sifre)
        {
            baglanti.Open();
            int girisKontrol = 5;
            switch (yetki)
            {
                case 0:
                    string sorgu = "SELECT * FROM yonetici WHERE yonetici_tc = '" + tcNo + "'AND yonetici_sifre = '" + sifre + "'";
                    komut = new MySqlCommand(sorgu, baglanti);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                        girisKontrol = 0;
                    else
                        girisKontrol = 1;
                    break;
                case 1:
                    string sorgu1 = "SELECT * FROM doktor WHERE dr_tc = '" + tcNo + "'AND dr_sifre = '" + sifre + "'";
                    komut = new MySqlCommand(sorgu1, baglanti);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                        girisKontrol = 2;
                    else
                        girisKontrol = 3;
                    break;
                case 2:
                    string sorgu2 = "SELECT * FROM hastakabulgorevlisi WHERE hk_tc = '" + tcNo + "'AND hk_sifre = '" + sifre + "'";
                    komut = new MySqlCommand(sorgu2, baglanti);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                        girisKontrol = 4;
                    else
                        girisKontrol = 5;
                    break;
            }
            baglanti.Close();
            return girisKontrol;
        }
    }
}
