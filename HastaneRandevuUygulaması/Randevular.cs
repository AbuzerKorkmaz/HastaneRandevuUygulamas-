using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuUygulaması
{
    public partial class Randevular : Form
    {
        public Randevular()
        {
            InitializeComponent();
            listBox1.DataSource = Form1.hastaRandevulari;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //int sayi = listBox1.SelectedIndex;
            //Hasta yenihasta= Form1.hastaRandevulari[sayi];
            
            Hasta yenihasta = (Hasta)listBox1.SelectedItem;
            MessageBox.Show($"AdSoyad : {yenihasta.AdSoyAd} \n TC : {yenihasta.TC} \n Cinsiyet : {yenihasta.Cinsiyet}","Hasta bilgi",MessageBoxButtons.OK);
        }
    }
}
