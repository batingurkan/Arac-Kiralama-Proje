using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace üyeEkleSilProje
{
    public partial class musteriFrm : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public musteriFrm()
        {
            InitializeComponent();
            MusteriGetir();
        }
        void MusteriGetir()
        {
            baglanti = new SqlConnection("Data Source=BATIN-PC\\SQLEXPRESS;Initial Catalog=arackirala;Integrated Security=True");
            da = new SqlDataAdapter("SELECT *FROM musteri", baglanti);
            baglanti.Open();
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
