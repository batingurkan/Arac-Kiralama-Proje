using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace üyeEkleSilProje
{
    public partial class arackiralamaFrm : Form
    {
        public arackiralamaFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void musteriBtn_Click(object sender, EventArgs e)
        {
            aracFrm arac = new aracFrm();
            arac.ShowDialog();
        }

        private void aracBtn_Click_1(object sender, EventArgs e)
        {
            musteriFrm musteri = new musteriFrm();
            musteri.ShowDialog();
        }

        private void anasayfaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
