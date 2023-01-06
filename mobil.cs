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
    public partial class mobil : Form
    {
        public mobil()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=;Initial Catalog=mobilRental;Integrated Security=True");
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from mobil";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "mobil");
            dgvmobil.DataSource = da;
            dgvmobil.DataMember = "mobil";
            dgvmobil.ReadOnly = true;
        }

        private void resetdata()
        {
            txtidmobil.Text = "";
            txtnamamobil.Text = "";
            txthargasewa.Text = "";
            txtmerkmobil.Text = "";
            txtnoplat.Text = "";
            txtunitmobil.Text = "";
        }

        private void mobil_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }

        private void btnsavemobil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ADDMOBIL";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter idMobil = new SqlParameter("@id",
                SqlDbType.VarChar);
            SqlParameter namaMobil = new SqlParameter("@nama",
                SqlDbType.VarChar);
            SqlParameter hargasewa = new SqlParameter("@hargasewa",
                SqlDbType.Int);
            SqlParameter noPlat = new SqlParameter("@noplat",
                SqlDbType.VarChar);
            SqlParameter unitMobil = new SqlParameter("@unitmobil",
                SqlDbType.Int);
            SqlParameter merkMobil = new SqlParameter("@merkmobil",
                SqlDbType.VarChar);
            idMobil.Value = txtidmobil.Text;
            namaMobil.Value = txtnamamobil.Text;
            hargasewa.Value = txthargasewa.Text;
            noPlat.Value = txtnoplat.Text;
            unitMobil.Value = txtunitmobil.Text;
            merkMobil.Value = txtmerkmobil.Text;
            cmd.Parameters.Add(idMobil);
            cmd.Parameters.Add(namaMobil);
            cmd.Parameters.Add(hargasewa);
            cmd.Parameters.Add(noPlat);
            cmd.Parameters.Add(unitMobil);
            cmd.Parameters.Add(merkMobil);
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
        }

        private void btndeletemobil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELLMOBIL";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter idMobil = new SqlParameter("@id",
                SqlDbType.VarChar);
            cmd.Parameters.Add(idMobil);
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
        }
    }
}
