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
    public partial class FormCoatPent : Form
    {
        SqlConnection con;
        public FormCoatPent()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\humay\source\repos\ExpertApp\ExpertApp\Expertdb.mdf;Integrated Security=True");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string gender = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                gender = radioButton1.Text;
            else
                gender = radioButton2.Text;

            try
            {
                con.Open();
                string query = "Insert into PentCoat ( Sr,Name, Number ,Gender, orderDate,receivingDate,Quantity,Price,Length,shoulderslop,chest,waist,hip,neck,plength,pwaist,phip,pgadri,pknee,plegbuttom,clength,cshoulderslop,csleeves,cchest,cwaist,chip,ccorssback,chalfback,ccrotchpoint,Extradetails) values ('" + tbPCsr.Text + "','" + tbPCname.Text + "','" + tbPCnumber.Text + "','" + gender + "','" + dtpDateOrd.Value.Date + "','" + dtpDateRec.Value.Date + "','" + numericUpDown1.Text + "','" + tbPCprice.Text + "','" + tbwheight.Text + "','" + tbwShoulderslope.Text + "','" + tbwchest.Text + "','" + tbwwaist.Text + "','" + tbwhip.Text + "','" + tbwneck.Text + "','" + tbheight.Text + "','" + tbpwaist.Text + "','" + tbphip.Text + "','" + tbpgadri.Text + "','" + tbpknee.Text + "','" + tbplegbuttom.Text + "','" + tbCheight.Text + "','" + tbcshoulderslop.Text + "','" + tbCsleeves.Text + "','" + tbCchest.Text + "','" + tbcwaist.Text + "','" + tbchip.Text + "','" + tbccrossback.Text + "','" + tbchalfback.Text + "','" + tbccrotchpoint.Text + "','" + tbextradetails.Text + "')";
                SqlCommand insert = new SqlCommand(query, con);
                insert.ExecuteNonQuery();
                MessageBox.Show("Record Inserted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
