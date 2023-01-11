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
    public partial class giriş : Form
    {
        public giriş()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            admın admın=new admın();
            admın.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            kullanıcı kullanıcı=new kullanıcı();
            kullanıcı.Show();

        }
    }
}
