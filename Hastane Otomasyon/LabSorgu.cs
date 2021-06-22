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
    public partial class LabSorgu : Form
    {
        public LabSorgu()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=hastane; uid=root; Password=Enes!1905; Charset=utf8");

        private void LabSorgu_Load(object sender, EventArgs e)
        {
            tc_text.MaxLength = 11;
            doldur();
        }

        void doldur()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("SELECT h.hasta_tc, li.lab_id, li.islem_id " +
                "FROM laboratuvarislem AS li INNER JOIN hasta AS h ON li.hasta_id = h.hasta_id ", baglanti);
            DataTable oku = new DataTable();
            listele.Fill(oku);
            dataGridView1.DataSource = oku;
            baglanti.Close();
        }

        private void sorgu_button_Click(object sender, EventArgs e)
        {

        }
    }
}
