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

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            {
                SqlConnection koneksi = new SqlConnection("Data Source=;Initial Catalog=mobilRental;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select count (*) from operator where userId = '" +txtuser.Text+ "' and password = '" +txtpass.Text+ "'", koneksi);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Home panggil = new Home();
                    panggil.Show();
                }
                else
                {
                    MessageBox.Show("Mohon isi Username dan Password anda dengan benar !", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
