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
    public partial class DoktorEkran : Form
    {
        public DoktorEkran()
        {
            InitializeComponent();
        }
        
        public string doktor_tc { get; set; }
        
        private void recete_button_Click(object sender, EventArgs e)
        {
            ReceteOlustur ro = new ReceteOlustur();
            ro.doktor_tc = this.doktor_tc;
            ro.Show();
        }

        private void hasta_button_Click(object sender, EventArgs e)
        {
            Hastalarım h = new Hastalarım();
            h.doktor_tc = this.doktor_tc;
            h.Show();
        }

        private void lab_button_Click(object sender, EventArgs e)
        {
            LabKayit lk = new LabKayit();
            lk.Show();
        }
    }
}
