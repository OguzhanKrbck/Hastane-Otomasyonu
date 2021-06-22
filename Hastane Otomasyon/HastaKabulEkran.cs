using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon
{
    public partial class HastaKabulEkran : Form
    {
        public HastaKabulEkran()
        {
            InitializeComponent();
        }

        private void ekle_button_Click(object sender, EventArgs e)
        {
            HastaEkle he = new HastaEkle();
            he.Show();
        }

        private void sorgu_button_Click(object sender, EventArgs e)
        {
            HastaSorgula hs = new HastaSorgula();
            hs.Show();
        }

        private void randevuVer_button_Click(object sender, EventArgs e)
        {
            RandevuVer rv = new RandevuVer();
            rv.Show();
        }

        private void randevuSorgu_button_Click(object sender, EventArgs e)
        {
            RandevuSorgu rs = new RandevuSorgu();
            rs.Show();
        }

        private void labSorgu_button_Click(object sender, EventArgs e)
        {
            LabSorgu ls = new LabSorgu();
            ls.Show();
        }
    }
}
