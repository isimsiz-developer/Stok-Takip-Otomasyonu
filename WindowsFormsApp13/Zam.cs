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
namespace WindowsFormsApp13
{
    public partial class Zam : Form
    {
        public Zam()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\kullanıcılar.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut;
        SqlDataReader okuyucu;
        public static int adet;
        SqlDataAdapter da;
        DataTable dt;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        void göster()
        {
            Baglanti.Open();
            string kayit = "SELECT * from kullanıcılar";
            komut = new SqlCommand(kayit, Baglanti);
            da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Baglanti.Close();
        }
        private void Zam_Load(object sender, EventArgs e)
        {
            göster();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dogrula();
            Baglanti.Open();
            komut = new SqlCommand("update kullanıcılar set maaş = maaş+'" +textBox3.Text + "' where kadı ='"+textBox1.Text+"'", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }
        void dogrula()
        {
            komut = new SqlCommand("Select * From kullanıcılar where  cast(kadı as binary) =cast('" + textBox1.Text + "' as binary) AND cast(sıfre as binary) =cast('" + textBox2.Text + "' as binary) ", Baglanti);
            Baglanti.Open();
            okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
            {
                MessageBox.Show("Bilgiler doğru zam yapılıyor !!!");
            }
              
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre Yanlış");
                
            }

            Baglanti.Close();
            göster();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
