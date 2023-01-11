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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp13
{
    public partial class sıfre_yenıle : Form
    {
        public sıfre_yenıle()
        {
            InitializeComponent();
        }

        private void sıfre_yenıle_Load(object sender, EventArgs e)
        {
            
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ysıfre.PasswordChar = '\0';
                ysıfre2.PasswordChar= '\0';
                checkBox1.Text = "Şifreyi gizle";
            }
            else
            {
                ysıfre.PasswordChar = '*';
                ysıfre2.PasswordChar = '*';
                checkBox1.Text = "Şifreyi göster";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tek_dogrula();
            kadı_dogrula();
        }
        void tek_dogrula()
        {
            //tek kullanımlık şifreyi doğrulama
            int tee = Convert.ToInt32(tek.Text);
            if (tee == Properties.Settings.Default.tek)
            {
                MessageBox.Show(tee.ToString());
            }
            else if (tee == Properties.Settings.Default.atek) { 
            }
            else
            {
                MessageBox.Show("hata:\n tek kullanımlık şifreniz hatalıdır!");
            }


        }
        #region baglantı
        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\kullanıcılar.mdf;Integrated Security=True;Connect Timeout=30");  
        SqlConnection Baglanti1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\kullanıcılar.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut = new SqlCommand();
        SqlDataReader okuyucu;
        public static string KullanıcıCharAd = "";
        public static string KullanıcıCharSifre = "";
        #endregion
        void kadı_dogrula()
        {
            #region bağlantıyı teyit etme

            try
            {
                bool temp;

                KullanıcıCharSifre = ysıfre.Text;

                Baglanti1.Open();
                komut = new SqlCommand("update admın set sıfre='" + ysıfre.Text + "' where kadı='" + kadı.Text+ "'", Baglanti1);

                okuyucu = komut.ExecuteReader();
                
                if (okuyucu.Read())
                    temp = true;
                else
                {
                    MessageBox.Show("şifre başarılı bir şekilde değiştirildi!");
                    temp = false;
                }
                Baglanti1.Close();

                
            }
            catch (Exception)
            {
                MessageBox.Show("hatalı");
                throw;
            }
            try
            {
                bool temp;
                Baglanti.Open();
                komut = new SqlCommand("update kullanıcılar set sıfre='" + ysıfre.Text + "' where kadı='" + kadı.Text + "'", Baglanti);

                okuyucu = komut.ExecuteReader();

                if (okuyucu.Read())
                    temp = true;
                else
                {
                    MessageBox.Show("şifre başarılı bir şekilde değiştirildi!");
                    temp = false;
                }
                Baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("hatalı");
                throw;
            }

            #endregion

        }


    }
}
