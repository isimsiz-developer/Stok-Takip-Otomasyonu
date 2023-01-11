using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data.Common;

namespace WindowsFormsApp13
{
    public partial class dogrula : Form
    {
        public dogrula()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\kullanıcılar.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Baglanti1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\admin.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut = new SqlCommand();
        SqlDataReader okuyucu;
        public static string KullanıcıCharAd = "";
        public static string KullanıcıCharSifre = "";
        bool denetle=false;
        private void button1_Click(object sender, EventArgs e)
        {
            dogrula_kadı();
            admın_dogrula();
            if(denetle==true) 
            {
                sıfre_yenıle git = new sıfre_yenıle();
                git.Show();
            }
          
            
        }
        void admın_dogrula()
        {//admin olup olmadığını doğrulama
            if (checkBox1.Checked == true)
            {
                KullanıcıCharAd = textBox1.Text;
                komut = new SqlCommand("Select * From admin where  cast(posta as binary) =cast('" + textBox1.Text + "' as binary)", Baglanti);
                Baglanti.Open();
                okuyucu = komut.ExecuteReader();
                string adres = textBox1.Text;
                Random rastgele = new Random();
                int sayi = rastgele.Next(100000, 999999);
                MessageBox.Show("Hoşgeldin sayın admin bilgilerini kontrol ediyorum!!");

                try
                {
                    SmtpClient smtp = new SmtpClient();
                    MailMessage msj = new MailMessage();
                    string tarih = DateTime.Now.ToLongDateString();
                    string msjadres = ("gedikemre109@gmail.com");
                    string sıfre = ("3344emre");
                    string smltp = "smtp.office365.com";
                    string konu = ("Şifre değiştirme talebi");
                    string yaz = ("sayın admin, " + tarih + " tarihli şifre değişikliği talebince tek kullanımlık şifreniz:\n" + sayi + " dir. \n Şifrenizi kimse ile paylaşmayınız!!");
                    smtp.Credentials = new NetworkCredential(msjadres, sıfre);
                    smtp.Port = 587;
                    smtp.Host = smltp;
                    smtp.EnableSsl = true;
                    msj.From = new MailAddress(msjadres);
                    msj.To.Add(adres.ToString());
                    msj.Subject = konu;
                    msj.Body = yaz;
                    smtp.Send(msj);
                    this.Hide();
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("bilgiler doğru mesaj gönderildi");
                    Properties.Settings.Default.atek = sayi;
                    denetle = true;
                    Properties.Settings.Default.takadı = textBox1.Text;

                    Baglanti.Close();

                }
                catch (Exception )
                {

                    MessageBox.Show("hata:" + "böyle bir eposta bulunamadı!"+ MessageBoxButtons.OK + MessageBoxIcon.Warning);
                }



            }
            else
            {//kullanıcıyı teyit etme ve ona göre işlem yapma
                KullanıcıCharAd = textBox1.Text;
                komut = new SqlCommand("Select * From kullanıcılar where  cast(posta as binary) =cast('" + textBox1.Text + "' as binary)", Baglanti);
                Baglanti.Open();
                okuyucu = komut.ExecuteReader();

                string adres = textBox1.Text;
                Random rastgele = new Random();
                int sayi = rastgele.Next(100000, 999999);
                MessageBox.Show("hoşgeldin sayın görevli bilgilerini kontrol ediyorum!!");
                

                try
                {
                    SmtpClient smtp = new SmtpClient();
                    MailMessage msj = new MailMessage();
                    string tarih = DateTime.Now.ToLongDateString();
                    string msjadres = ("gedikemre109@gmail.com");
                    string sıfre = ("3344emre");
                    string smltp = "smtp.office365.com";
                    string konu = ("Şifre değiştirme talebi");
                    string yaz = ("sayın kullanıcı, " + tarih + " tarihli şifre değişikliği talebince tek kullanımlık şifreniz:\n" + sayi + " dir. \n Şifrenizi kimse ile paylaşmayınız!!");
                    smtp.Credentials = new NetworkCredential(msjadres, sıfre);
                    smtp.Port = 587;
                    smtp.Host = smltp;
                    smtp.EnableSsl = true;
                    msj.From = new MailAddress(msjadres);
                    msj.To.Add(adres.ToString());
                    msj.Subject = konu;
                    msj.Body = yaz;
                    smtp.Send(msj);
                    this.Hide();
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("bilgiler doğru mesaj gönderildi");
                    Properties.Settings.Default.tek = sayi;
                    denetle = true;
                    Baglanti.Close();
                    Properties.Settings.Default.tkadı = textBox1.Text;
                }
                
                catch (Exception)
                {

                    MessageBox.Show("hata:\nböyle bir eposta bulunamadı!");
                }
                
            }
           


        }
        void dogrula_kadı()
        {
            if(checkBox1.Checked)
            {
                Baglanti.Open();
                KullanıcıCharAd = textBox2.Text;
                komut = new SqlCommand("Select * From admin where  cast(kadı as binary) =cast('" + textBox2.Text + "' as binary)", Baglanti);              
                okuyucu = komut.ExecuteReader();
                Properties.Settings.Default.tkadı = textBox2.Text;
                Baglanti.Close();

            }
            else
            {
                KullanıcıCharAd = textBox2.Text;
                komut = new SqlCommand("Select * From kullanıcılar where  cast(kadı as binary) =cast('" + textBox2.Text + "' as binary)", Baglanti);
                Baglanti.Open();
                okuyucu = komut.ExecuteReader();
                Properties.Settings.Default.tkadı = textBox2.Text;
                Baglanti.Close();

            }

           

        }
        void posta()
        {
            if (checkBox1.Checked)
            {
                KullanıcıCharAd = textBox2.Text;
                komut = new SqlCommand("Select * From admin where  cast(posta as binary) =cast('" + textBox1.Text + "' as binary)", Baglanti);
                Baglanti.Open();
                okuyucu = komut.ExecuteReader();
                Properties.Settings.Default.tkadı = textBox2.Text;
                Baglanti.Close();
            }
            else
            {

                KullanıcıCharAd = textBox2.Text;
                komut = new SqlCommand("Select * From kullanıcılar where  cast(posta as binary) =cast('" + textBox1.Text + "' as binary)", Baglanti);
                Baglanti.Open();
                okuyucu = komut.ExecuteReader();
                Properties.Settings.Default.tkadı = textBox2.Text;
                Baglanti.Close();
            }
        }

        private void dogrula_Load(object sender, EventArgs e)
        {

        }
    }
}
