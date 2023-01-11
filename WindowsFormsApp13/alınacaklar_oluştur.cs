using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp13
{
    public partial class alınacaklar_oluştur : Form
    {
        public alınacaklar_oluştur()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\urunler2.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand komut;
        SqlDataReader okuyucu;
        public static int adet;
        SqlDataAdapter da;
        DataTable dt;
        StreamWriter sw;
        private void oluştur_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "txt dosyası|0.txt";
                saveFile.FileName = "alınacaklar.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(saveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    fs.Close();
                    for (int i = 0; i < goster.Rows.Count; i++)
                    {
                        string ad = goster.Rows[i].Cells["ürün_adı"].Value.ToString();
                        string barkod = goster.Rows[i].Cells["barkod"].Value.ToString();
                        string olanadt = goster.Rows[i].Cells["adet"].Value.ToString();
                        string içerik = ad + "  " + barkod + "  " + olanadt;
                        File.AppendAllText(saveFile.FileName, içerik + " " + DateTime.Now + "\n");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
                
           
        }

        private void alınacaklar_oluştur_Load(object sender, EventArgs e)
        {
            göster();

        }
        void göster()
        {
            Baglanti.Open();
            string kayit = "SELECT ürün_adı,barkod,adet from urun where adet=5 or adet<5 or adet=0 or adet<0";
            komut = new SqlCommand(kayit, Baglanti);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            goster.DataSource = dt;
            Baglanti.Close();
        }
    }
}
