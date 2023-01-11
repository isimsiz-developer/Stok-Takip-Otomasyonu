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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp13
{
    public partial class admın : Form
    {
        public admın()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\admin.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut = new SqlCommand();
        SqlDataReader okuyucu;
        public static string KullanıcıCharAd = "";
        public static string KullanıcıCharSifre = "";
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            dogrula dogrula= new dogrula();
            dogrula.Show();
        }
        void dogrula()
        {//mssql baglantı
            bool temp;
            KullanıcıCharAd = textBox1.Text;
            KullanıcıCharSifre = textBox2.Text;
            komut = new SqlCommand("Select * From admin where  cast(kadı as binary) =cast('" + textBox1.Text + "' as binary) AND cast(şifre as binary) =cast('" + textBox2.Text + "' as binary) ", Baglanti);
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
                admin_anasayfa anasayfa = new admin_anasayfa();
                anasayfa.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dogrula();
            if (checkBox2.Checked == true)
            {
                Properties.Settings.Default.akadı = textBox1.Text;
                Properties.Settings.Default.asıfre = textBox2.Text;
                Properties.Settings.Default.hatırla = true;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.akadı = "";
                Properties.Settings.Default.asıfre ="";
                Properties.Settings.Default.hatırla = false;
                Properties.Settings.Default.Save();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "şifreyi gizle";
                textBox2.PasswordChar = '\0';
            }
            else
            {
                checkBox1.Text = "şifreyi göster";
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //Kullanıcı eğer kullanıcı adı kısmını boş bırakırsa
            if (textBox1.Text == "" || textBox2.Text == "")
                button2.Enabled = false;
            else
                button2.Enabled = true;

            if (textBox1.Text == "")
                label4.Visible = true;
            else
                label4.Visible = false;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            //Kullanıcı eğer şifre kısmını boş bırakırsa
            if (textBox1.Text == "" || textBox2.Text == "")
                button2.Enabled = false;
            else
                button2.Enabled = true;

            if (textBox2.Text == "")
                label5.Visible = true;
            else
                label5.Visible = false;
        }

        private void admın_Load(object sender, EventArgs e)
        {
            //Kullanıcı eğer kullanıcı adı ve şifre kısmını boş bırakırsa
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                button2.Enabled=false;
            }
            if (Properties.Settings.Default.akadı != string.Empty)
            {
                textBox1.Text = Properties.Settings.Default.akadı;
                textBox2.Text = Properties.Settings.Default.asıfre;
                
            }
            if (Properties.Settings.Default.hatırla == true)
            {
                checkBox2.Checked = true;
            }
        }


     

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
