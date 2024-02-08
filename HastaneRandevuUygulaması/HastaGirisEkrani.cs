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
    public partial class HastaGirisEkrani : Form
    {
        public HastaGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Hasta hasta = new Hasta();
            hasta.AdSoyAd = textBox1.Text;
            hasta.TC=maskedTextBox1.Text;
            hasta.Telefon=maskedTextBox2.Text;
            hasta.Cinsiyet=radioButton5.Checked? radioButton5.Text: radioButton6.Text;
            hasta.Poliklinic = comboBox1.SelectedItem.ToString();

            hasta.Tarih = dateTimePicker1.Value;

            foreach (Control item in this.Controls)
            {
                if (item is RadioButton)
                {
                    if (((RadioButton)item).Checked) hasta.Saat = item.Text;
                }
            }
            //if (radioButton1.Checked) hasta.Saat = radioButton1.Text;
            //else if (radioButton2.Checked) hasta.Saat = radioButton2.Text;
            //else if (radioButton3.Checked) hasta.Saat = radioButton3.Text;
            //else if(radioButton4.Checked) hasta.Saat =radioButton4.Text;
            
            Form1.hastaRandevulari.Add(hasta);
            MessageBox.Show("Randevunuz Eklenmiştir. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
