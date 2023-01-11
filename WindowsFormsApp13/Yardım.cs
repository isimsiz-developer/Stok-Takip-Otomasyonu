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

namespace WindowsFormsApp13
{
    public partial class Yardım : Form
    {
        public Yardım()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient();
            MailMessage msj = new MailMessage();
            string tarih = DateTime.Now.ToLongDateString();
            string msjadres = ("gedikemre109@gmail.com");
            string sıfre = ("3344emre");
            string smltp = "smtp.office365.com";
            string konu = (kon.Text);
            string yaz = (tarih+" "+body.Text);
            smtp.Credentials = new NetworkCredential(msjadres, sıfre);
            smtp.Port = 587;
            smtp.Host = smltp;
            smtp.EnableSsl = true;
            msj.From = new MailAddress(msjadres);
            msj.To.Add("emregedik470@gmail.com");
            msj.Subject = konu;
            msj.Body = yaz;
            smtp.Send(msj);
            this.Hide();
            DialogResult bilgi = new DialogResult();
            bilgi = MessageBox.Show("mesaj gönderildi");

        }


    }
}
