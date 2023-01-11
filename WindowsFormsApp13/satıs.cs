using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class satıs : Form
    {
        public satıs()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\urunler2.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut;
        SqlDataReader okuyucu;
        public static int adet ;
        SqlDataAdapter da;
        private void satıs_Load(object sender, EventArgs e)
        {
            göster();


            
        }

            void list(object sender, KeyEventArgs e)
        {
           
        }
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            sat();
            şatış();
            geçmiş();
        }
        void sat()
        {//satış tuşu komutu
            int yeni;
            Baglanti.Open();
            komut = new SqlCommand("select adet from urun where cast(barkod as binary)=cast('" + barkod.Text + "' as binary)", Baglanti);
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                int adet = Convert.ToInt32(aded.Text);
                int okuyuc = (int)okuyucu[0];
                yeni = okuyuc - adet;
            }
            Baglanti.Close();


              void sıfır()
            {
                Baglanti.Open();
                komut = new SqlCommand("select * from urun where barkod='"+barkod.Text+"'and adet=0 or adet<0",Baglanti);
                okuyucu= komut.ExecuteReader();
                while (okuyucu.Read())
                {
                    MessageBox.Show("Ürün stoklarımızda bulunmamaktadır !");
                }
                Baglanti.Close();
            }

        }
        
        public void göster()
        {  
            Baglanti.Open();
            string kayit = "SELECT ürün_adı,barkod,fiyat,adet from urun";
            komut = new SqlCommand(kayit, Baglanti);
            da = new SqlDataAdapter(komut);
             dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            Baglanti.Close();
        }
       DataView ara()
        {//arama yapma



                DataView dv = new DataView();
                dv = dt.DefaultView;
                dv.RowFilter = $"barkod like '%" + Convert.ToInt64(barkod.Text) + "%'";
                ad.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                fiyat.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            return dv;
            
            

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {//fiyat hesaplama
 
            int alınacak_adet = Convert.ToInt32(aded.Text);
            int fiyat = Convert.ToInt32(this.fiyat.Text);
            toplam.Text = Convert.ToString(alınacak_adet * fiyat);
        }

        void şatış()
        {
            Baglanti.Open();
            komut = new SqlCommand("update urun set adet=adet-'"+Convert.ToInt32(aded.Text) +"'where barkod='"+barkod.Text+"'",Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            göster();
        }
        void geçmiş()
        {
            DateTime bugun = DateTime.Now;
            string tarih=bugun.ToString();
            SqlConnection bagla = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\satış_geçmişi.mdf;Integrated Security=True;Connect Timeout=30");
           
            bagla.Open();
            string ekle = "insert into satışlar(Fiş_no,barkod,Ürün_Adı,fiyat,adet,tarih_ve_saat) values('" + Convert.ToInt32(fiş.Text) + "', '" +barkod.Text + "', '" + ad.Text  +"', '" + Convert.ToInt32(fiyat.Text) + "', '" + Convert.ToInt32(aded.Text) + "', '" + tarih + "')";
            SqlCommand komut = new SqlCommand(ekle, bagla);
            var denetim = komut.ExecuteNonQuery();
            bagla.Close();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            İade iade=new İade();
            iade.Show();
        }

        private void barkod_TextChanged(object sender, EventArgs e)
        {
            ara();
            
        }
    }
}
