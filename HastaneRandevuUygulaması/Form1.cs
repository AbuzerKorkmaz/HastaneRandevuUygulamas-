using System.Windows.Forms;

namespace HastaneRandevuUygulaması
{
    public partial class Form1 : Form
    {


        public static List<Hasta> hastaRandevulari=new List<Hasta>();
        public Form1()
        {
            InitializeComponent();
            FormCagir(new HastaGirisEkrani());
            
        }

        private void randevuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCagir(new HastaGirisEkrani());
           
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCagir(new Randevular());
           
        }

        private void FormCagir(Form form)
        {

            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();

        }
    }
}
