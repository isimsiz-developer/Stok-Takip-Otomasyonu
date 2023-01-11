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
    public partial class Stok_Siil : Form
    {
        public Stok_Siil()
        {
            InitializeComponent();
        }


        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\urunler2.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut;
        public static int adet;
        SqlDataAdapter da;
        DataTable dt;

        void çagır()
        {
            Baglanti.Open();
            string kayit = "SELECT ürün_adı,barkod,adet from urun";
            komut = new SqlCommand(kayit, Baglanti);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Baglanti.Close();
        }

        void sil()
        {
            Baglanti.Open();
            komut = new SqlCommand("update urun set adet=adet-'" + Convert.ToInt32(aded.Text) + "' where barkod='" + barkod.Text + "'", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            çagır();
        }

        void ara()
        {
            DataView dv = new DataView();
            dv = dt.DefaultView;
            dv.RowFilter = $"barkod like '%" + barkod.Text + "%'";
            ad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void Stok_Siil_Load(object sender, EventArgs e)
        {
            çagır();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sil();
            MessageBox.Show($"{aded.Text} Kadar {ad.Text} stoktan düşüldü !");
        }

        private void barkod_TextChanged(object sender, EventArgs e)
        {
            ara();
        }
    }
}
