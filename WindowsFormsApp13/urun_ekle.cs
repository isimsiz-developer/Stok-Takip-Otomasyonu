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

namespace WindowsFormsApp13
{
    public partial class urun_ekle : Form
    {
        public urun_ekle()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\urunler2.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut;
        public static int adet;
        SqlDataAdapter da;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            komut = new SqlCommand("insert into urun (ürün_adı,adet,fiyat,barkod) values('"+ürün_ad.Text+"','"+Convert.ToInt32(aded.Text)+"','"+Convert.ToInt32(fiyat.Text)+"','"+barkod.Text+"')",Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Ürün eklendi");
            çagır();
    
            

        }
        void çagır()
        {
            Baglanti.Open();
            string kayit = "SELECT ürün_adı,barkod,fiyat,adet from urun";
            komut = new SqlCommand(kayit, Baglanti);
            da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Baglanti.Close();
        }

        private void urun_ekle_Load(object sender, EventArgs e)
        {
            çagır();
        }
    }
}
