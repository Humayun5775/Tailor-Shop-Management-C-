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

namespace ExpertApp
{
    public partial class FormShalwarkameezDetails : Form
    {
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable datatable;
        public FormShalwarkameezDetails()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\humay\source\repos\ExpertApp\ExpertApp\Expertdb.mdf;Integrated Security=True");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            data_load();
        }

        private void data_load()
        {
            try
            {
                string query = "Select * from ShalwarKameez";
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
                this.dt.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("select * from ShalwarKameez where (Name == '" + tbname.Text + ") OR (Number == '" + tbnumber.Text + ") OR (Sr == '" + tbsr.Text + ")  %'", con);
            datatable = new DataTable();
            adapt.Fill(datatable);
            dt.DataSource = datatable;
        }

        private void tbsr_TextChanged(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("select * from ShalwarKameez where Sr like '" + tbsr.Text + "%'", con);
            datatable = new DataTable();
            adapt.Fill(datatable);
            dt.DataSource = datatable;
        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("select * from ShalwarKameez where Name like '" + tbname.Text + "%'", con);
            datatable = new DataTable();
            adapt.Fill(datatable);
            dt.DataSource = datatable;
        }

        private void tbnumber_TextChanged(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("select * from ShalwarKameez where Number like '" + tbnumber.Text + "%'", con);
            datatable = new DataTable();
            adapt.Fill(datatable);
            dt.DataSource = datatable;
        }
    }
}
