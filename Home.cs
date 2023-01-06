using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnmobil_Click(object sender, EventArgs e)
        {
            mobil panggil = new mobil();
            panggil.Show();
        }

        private void btnpelanggan_Click(object sender, EventArgs e)
        {
            pelanggan panggil = new pelanggan();
            panggil.Show();
        }

        private void btntrans_Click(object sender, EventArgs e)
        {
            transaksi panggil = new transaksi();
            panggil.Show();
        }

        private void btnpenyewaan_Click(object sender, EventArgs e)
        {
            penyewaan panggil = new penyewaan();
            panggil.Show();
        }     
    }
}
