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
using System.Data;

namespace WindowsFormsApp13
{
    public partial class Ürün_Sil : Form
    {
        public Ürün_Sil()
        {
            InitializeComponent();
        }

        private void Ürün_Sil_Load(object sender, EventArgs e)
        {
            çagır();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\urunler2.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut;
        public static int adet;
        SqlDataAdapter da;
        DataTable dt;
        void çagır()
        {
            Baglanti.Open();
            string kayit = "SELECT ürün_adı,barkod,fiyat,adet from urun";
            komut = new SqlCommand(kayit, Baglanti);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView();
            dv = dt.DefaultView;
            dv.RowFilter = $"barkod like '%" + barkod.Text + "%'";
            ad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            aded.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti.Open();

            komut = new SqlCommand("delete urun where (barkod)='"+barkod.Text+"'", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            çagır();
        }
    }
}
