using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestorantUygulaması
{
    public partial class Form1 : Form
    {
        int hesap=0;
        int kazanc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbBaklava.Text = "0";
            tbCay.Text = "0";
            tbKadayif.Text = "0";
            tbKunefe.Text = "0";
            tbSobiyet.Text = "0";
            tbSutlac.Text = "0";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int baklavaFiyat = Convert.ToInt16(tbBaklava.Text) * 20;
                int sobFiyat = Convert.ToInt16(tbSobiyet.Text) * 30;
                int kadaFiyat = Convert.ToInt16(tbKadayif.Text) * 40;
                int sutFiyat = Convert.ToInt16(tbSutlac.Text) * 25;
                int kunFiyat = Convert.ToInt16(tbKunefe.Text) * 50;
                int cayFiyat = Convert.ToInt16(tbCay.Text) * 10;
                hesap = baklavaFiyat + sobFiyat + kadaFiyat + sutFiyat + kunFiyat + cayFiyat;
                lbTutar.Text = "Ödenecek Tutar:" + Convert.ToString(hesap);

            }
            catch
            {
                MessageBox.Show("Bir değer giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


         }

        private void btnOde_Click(object sender, EventArgs e)
        {
            
            kazanc +=hesap;
            lblKasaKazanc.Text = "Günlük Kazanç:" + Convert.ToString(kazanc);
        }
    }
}
