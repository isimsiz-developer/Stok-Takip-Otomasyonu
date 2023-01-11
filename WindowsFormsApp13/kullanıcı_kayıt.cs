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
    public partial class kullanıcı_kayıt : Form
    {
        public kullanıcı_kayıt()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\kullanıcılar.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut = new SqlCommand();
        SqlDataReader okuyucu;
        public static string KullanıcıCharAd = "";
        public static string KullanıcıCharSifre = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {

                Baglanti.Open();
                string getir = "select * from kullanıcılar where cast(kadı as binary)=cast('" + textBox1.Text + "' as binary) ";
                SqlCommand sorgu = new SqlCommand(getir, Baglanti);
                SqlDataAdapter adapter2 = new SqlDataAdapter(sorgu);
                SqlDataReader reader2 = sorgu.ExecuteReader();
                if (reader2.Read())
                {
                    MessageBox.Show("Bu Kullanıcı Adı Alınmıştır !!!");

                }
                else
                {


                    Baglanti.Close();
                    Baglanti.Open();
                    string ekle = "insert into kullanıcılar (kadı,sıfre,posta,maaş) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "')";
                    SqlCommand komut = new SqlCommand(ekle, Baglanti);
                    var denetim = komut.ExecuteNonQuery();
                    Baglanti.Close();
                    MessageBox.Show("kaydedildi giriş ekranına yönlendirilceksiniz!");
                    this.Close();

                }
                Baglanti.Close();
            }
            else
            {
                MessageBox.Show("şifre tekrar yanlış!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "şifreyi gizle";
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                checkBox1.Text = "şifreyi göster";
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        private void kullanıcı_kayıt_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }
    }
}
