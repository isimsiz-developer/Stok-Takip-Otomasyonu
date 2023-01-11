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
    public partial class kullanıcı : Form
    {
        public kullanıcı()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\kullanıcılar.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut = new SqlCommand();
        SqlDataReader okuyucu;
        public static string KullanıcıCharAd = "";
        public static string KullanıcıCharSifre = "";
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            dogrula dogrula = new dogrula();
            dogrula.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dogrula();
            if (checkBox2.Checked == true)
            {
                Properties.Settings.Default.kadı = textBox1.Text;
                Properties.Settings.Default.sıfre = textBox2.Text;
                Properties.Settings.Default.hatırla = true;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.kadı = "";
                Properties.Settings.Default.sıfre = "";
                Properties.Settings.Default.hatırla = false;
                Properties.Settings.Default.Save();
            }
        }


        void dogrula()
        {//mssql baglantı
            bool temp;
            KullanıcıCharAd = textBox1.Text;
            KullanıcıCharSifre = textBox2.Text;
            komut = new SqlCommand("Select * From kullanıcılar where  cast(kadı as binary) =cast('" + textBox1.Text + "' as binary) AND cast(sıfre as binary) =cast('" + textBox2.Text + "' as binary) ", Baglanti);
            Baglanti.Open();
            okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
                temp = true;
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre Yanlış");
                temp = false;
            }

            Baglanti.Close();
            if (temp == true)
            {
                satıs satıs = new satıs();
                satıs.Show();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "şifreyi gizle";
                textBox1.PasswordChar = '\0';
            }
            else
            {
                checkBox1.Text = "şifreyi göster";
                textBox1.PasswordChar = '*';
            }
        }

        private void kullanıcı_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.kadı != string.Empty)
            {
                textBox1.Text = Properties.Settings.Default.kadı;
                textBox2.Text = Properties.Settings.Default.sıfre;

            }
            if (Properties.Settings.Default.hatırla == true)
            {
                checkBox2.Checked = true;
            }
        }
    }
}
