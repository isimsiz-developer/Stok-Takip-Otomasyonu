using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class admin_anasayfa : Form
    {
        public admin_anasayfa()
        {
            InitializeComponent();
        }


        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urun_ekle ekle= new urun_ekle();
            ekle.Show();
        }

        private void satıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanıcı_kayıt kul=new kullanıcı_kayıt();
            kul.Show();
        }

        private void adminKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_kayıt adm = new admin_kayıt();
            adm.Show();
        }

      

        private void satToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Çalışan_Sil sil2=new Çalışan_Sil();
            sil2.Show();
        }

        private void zamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Zam zam =new Zam();
            zam.Show();
        }

       


        private void satışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satıs sat =new satıs();
            sat.Show();
        }

        private void satışİyadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İade iade =new İade();
            iade.Show();
        }

       

        private void stokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_Ekle ekle=new Stok_Ekle();
            ekle.Show();
        }

        private void stokSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_Siil sil =new Stok_Siil();
            sil.Show();
        }

        private void kamerayaBağlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kamera cam=new kamera();
            cam.Show();
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ürün_Sil sil2=new Ürün_Sil();
            sil2.Show();
        }

        private void iadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İade_Kontrol kon1= new İade_Kontrol();
            kon1.Show();
        }

        private void satışKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satış_control kon2=new Satış_control();
            kon2.Show();
        }

        private void alınlanacaklarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 aç=new Form1();
            aç.Show();
        }

        private void listeOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alınacaklar_oluştur oluştur=new alınacaklar_oluştur();
            oluştur.Show();

        }

        private void admin_anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
