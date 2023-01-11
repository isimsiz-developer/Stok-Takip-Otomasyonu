using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Çalışan_Sil : Form
    {
        public Çalışan_Sil()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\kullanıcılar.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Baglanti1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\admin.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut = new SqlCommand();
        SqlDataReader okuyucu;
        public static string KullanıcıCharAd = "";
        public static string KullanıcıCharSifre = "";
        SqlDataAdapter da;
        DataTable dt;
        private void Çalışan_Sil_Load(object sender, EventArgs e)
        {
            çağır();
        }
        void çağır()
        {
            Baglanti.Open();
            string kayit = "SELECT *from kullanıcılar";
            komut = new SqlCommand(kayit, Baglanti);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Baglanti.Close();
        }
        void dogrula()
        {//mssql baglantı
            bool temp;
            KullanıcıCharAd = Aadı.Text;
            KullanıcıCharSifre = Aşıfre.Text;
            komut = new SqlCommand("Select * From admin where  cast(kadı as binary) =cast('" + Aadı.Text + "' as binary) AND cast(şifre as binary) =cast('" + Aşıfre.Text + "' as binary) ", Baglanti1 );
            Baglanti1.Open();
            okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
                temp = true;
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre Yanlış");
                temp = false;
            }

            Baglanti1.Close();

        }
        void ara()
        {
            DataView dv = new DataView();
            dv = dt.DefaultView;
            dv.RowFilter = $"kadı like '%" +Çadı.Text + "'";
            
        }
        void sil()
        {
            Baglanti.Open();
            komut = new SqlCommand("delete kullanıcılar where (kadı) ='" + Çadı.Text + "'", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dogrula();
            sil();
            çağır();
        }

        private void Çadı_TextChanged(object sender, EventArgs e)
        {
            ara();
        }
    }
}
