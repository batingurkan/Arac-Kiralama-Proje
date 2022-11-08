using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace üyeEkleSilProje
{
    public partial class aracFrm : Form
    {
        
        public aracFrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void MusteriGetir()
        {
            baglanti = new SqlConnection("Data Source=BATIN-PC\\SQLEXPRESS;Initial Catalog=arackirala;Integrated Security=True");
            da = new SqlDataAdapter("SELECT *FROM araclar", baglanti);
            baglanti.Open();
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }

        private void musteriFrm_Load(object sender, EventArgs e)
            
        {
            MusteriGetir();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
           

        }
    }
}
