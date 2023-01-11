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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp13
{
    public partial class İade : Form
    {
        public İade()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\satış_geçmişi.mdf;Integrated Security=True;Connect Timeout=30");
        
        SqlCommand komut;
        SqlDataReader okuyucu;
        public static int adet;
        SqlDataAdapter da;
        DataTable dt;
        private void İade_Load(object sender, EventArgs e)
        {

            data();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            güncelle();
            data();
            geçmiş();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView();
                dv = dt.DefaultView;
                dv.RowFilter = $"Fiş_no like '%" + Convert.ToInt32(fiş.Text) + "%'";

                ad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                barkod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                fiya.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Böyle bir satış bulnamadı !");
                throw;
            }
        }
        void güncelle()
        {
            int adet = Convert.ToInt32(aded.Text);
            int fiyat = Convert.ToInt32(fiya.Text);
            int ödenecek = adet * fiyat;
            öde.Text = ödenecek.ToString();
            bagla.Open();
            SqlCommand sql = new SqlCommand("UPDATE satışlar SET adet = adet - @ade WHERE Fiş_no='"+fiş.Text+"'", bagla);
            sql.Parameters.AddWithValue("@ade", adet);
            sql.ExecuteNonQuery();
            bagla.Close();
        }
        void data()
        {
            bagla.Open();
            string kayit = "SELECT * from satışlar";
            komut = new SqlCommand(kayit, bagla);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            bagla.Close();
        }
        void geçmiş()
        {
            {
            DateTime bugun = DateTime.Now;
            string tarih=bugun.ToString();
            SqlConnection bagla = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\satış_geçmişi.mdf;Integrated Security=True;Connect Timeout=30");
           
            bagla.Open();
            string ekle = "insert into iade(Fiş_no,barkod,Ürün_Adı,adet,tarih_ve_saat) values('" + Convert.ToInt32(fiş.Text) + "', '" +barkod.Text + "', '" + ad.Text  + "', '" + Convert.ToInt32(aded.Text) + "', '" + tarih + "')";
            SqlCommand komut = new SqlCommand(ekle, bagla);
            var denetim = komut.ExecuteNonQuery();
            bagla.Close();


        }
        }

    }
}
