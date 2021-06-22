using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public int yetki; 

        private void hastaKG_button_Click(object sender, EventArgs e)
        {
            yetki = 2;
            giris();
        }

        private void doktor_button_Click(object sender, EventArgs e)
        {
            yetki = 1;
            giris();
        }

        private void yonetici_button_Click(object sender, EventArgs e)
        {
            yetki = 0;
            giris();
        }
        public void giris()
        {
            Giris g = new Giris();
            g.yetki = yetki;
            g.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
