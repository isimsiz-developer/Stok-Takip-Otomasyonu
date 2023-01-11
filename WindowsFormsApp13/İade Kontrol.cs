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
    public partial class İade_Kontrol : Form
    {
        public İade_Kontrol()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\satış_geçmişi.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut;
        SqlDataReader okuyucu;
        public static int adet;
        SqlDataAdapter da;
        DataTable dt;
        private void İade_Kontrol_Load(object sender, EventArgs e)
        {
            {

                Baglanti.Open();
                string kayit = "SELECT ürün_adı,barkod,fiyat,adet from iade";
                komut = new SqlCommand(kayit, Baglanti);
                da = new SqlDataAdapter(komut);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                Baglanti.Close();

            }
        }
    }
}
