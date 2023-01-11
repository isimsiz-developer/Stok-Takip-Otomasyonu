using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WindowsFormsApp13
{
    public partial class kamera : Form
    {
        public kamera()
        {
            InitializeComponent();
        }

        private void kamera_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bir kere basıldıktan sonra sonsuz döngüde çekme
           while(true)
            { 
                göster();
            }
        }
        private void göster()
        {
            //kameradan görüntü çekme
            int yükseklik=Convert.ToInt32(yük.Text);
            int genişlik=Convert.ToInt32(gen.Text);
            string url = this.url.Text;
            byte[] buffer= new byte[yükseklik*genişlik];

            int r, t = 0;
            HttpWebRequest req= (HttpWebRequest)WebRequest.Create(url);
            WebResponse res= req.GetResponse();
            Stream st= res.GetResponseStream();

            while((r=st.Read(buffer,t,1000)) !=0)
            {
                t += r;
            }
            Bitmap bp= (Bitmap) Bitmap.FromStream(new MemoryStream(buffer,0,t));
            pictureBox1.Image = bp;

        }

    }
}
