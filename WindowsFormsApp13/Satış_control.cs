using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp13
{
    public partial class Satış_control : Form
    {
        public Satış_control()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\satış_geçmişi.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand komut;
        private void Satış_control_Load(object sender, EventArgs e)
        {
            bagla.Open();
            string kayit = "SELECT * from satışlar";
            komut = new SqlCommand(kayit, bagla);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            bagla.Close();
        }
    }
}
