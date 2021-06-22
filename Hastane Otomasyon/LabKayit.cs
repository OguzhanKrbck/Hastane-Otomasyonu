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
    public partial class LabKayit : Form
    {
        public LabKayit()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastane; Uid=root; Password=Enes!1905; Charset=utf8");

        private void LabKayit_Load(object sender, EventArgs e)
        {
            tc_text.MaxLength = 11;
            comboDoldur();
        }
        
        private void ekle_button_Click(object sender, EventArgs e)
        {
            ekle();
        }

        void comboDoldur()
        {
            List<string> lab = new List<string>();
            string sorgu = "SELECT lab_isim FROM laboratuvar";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            baglanti.Open();
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lab.Add(dr["lab_isim"].ToString());
            }
            foreach(string isim in lab)
            {
                lab_combo.Items.Add(isim);
            }
            baglanti.Close();
        }

        void ekle()
        {
            if(hastaID() != 0 && labID() != 0)
            {
                string komut = "INSERT INTO laboratuvarislem(lab_id, hasta_id) VALUES(@lab_id, @hasta_id)";
                MySqlCommand ekle = new MySqlCommand(komut, baglanti);
                ekle.Parameters.AddWithValue("@lab_id", labID());
                ekle.Parameters.AddWithValue("@hasta_id", hastaID());
                baglanti.Open();
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla eklendi.");
            }
        }

        int hastaID()
        {
            int id = 0;
            baglanti.Open();
            string sorgu = "SELECT hasta_id FROM hasta WHERE hasta_tc = '" + tc_text.Text + "'";
            try
            {
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                MySqlDataReader dr = komut.ExecuteReader();
                dr.Read();
                id = Convert.ToInt32(dr["hasta_id"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hasta bulunamadı");
            }
            baglanti.Close();
            return id;
        }
        
        int labID()
        {
            int id = 0;
            baglanti.Open();
            string sorgu = "Select lab_id FROM laboratuvar WHERE lab_isim = '" + lab_combo.Text + "'";
            try
            {
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                MySqlDataReader dr = komut.ExecuteReader();
                dr.Read();
                id = Convert.ToInt32(dr["lab_id"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            baglanti.Close();
            return id;
        }


    }
}
