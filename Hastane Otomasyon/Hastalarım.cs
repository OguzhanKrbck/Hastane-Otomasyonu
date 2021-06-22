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
    public partial class Hastalarım : Form
    {
        public Hastalarım()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastane; Uid=root; Password=Enes!1905");
        public string doktor_tc { get; set; }

        private void Hastalarım_Load(object sender, EventArgs e)
        {
            doldur();
        }

        void doldur()
        {
            string sorgu = "SELECT h.hasta_tc, h.hasta_ad, h.hasta_soyad, r.randevu_saat FROM hasta AS h INNER JOIN randevu AS r ON h.hasta_id = r.hasta_id WHERE dr_id = '"+ doktorID()+ "' ORDER BY r.randevu_saat";
            MySqlDataAdapter listele = new MySqlDataAdapter(sorgu, baglanti);
            baglanti.Open();
            DataTable oku = new DataTable();
            listele.Fill(oku);
            dataGridView1.DataSource = oku;
            baglanti.Close();
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
