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
    public partial class FormCustomerShalwarKamez : Form
    {
        SqlConnection con;
        public FormCustomerShalwarKamez()
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

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                gender = radioButton1.Text;
            else
                gender = radioButton2.Text;

            string Surroundplan = "";
            bool sChecked = radioButton4.Checked;
            if (sChecked)
                Surroundplan = radioButton4.Text;
            else
                Surroundplan = radioButton5.Text;

            string check = "";
            bool Checked = checkBox1.Checked;
            if (sChecked)
                check = "yes";
            else
                check = "no";


            try
            {
                con.Open();
                string query = "Insert into Shalwarkameez ( Sr,Name, Number ,Gender, orderDate,receivingDate,Quantity,Price,Length,shoulderslop,sleeve,neck,chest,waist,surround,shalwarlength,shalwarpocket,legbuttom,shalwarsurround,ban,collartip,cuffwidth,frontpocket,sidepocket,surroundr,extradetail) values ('" + tbSksr.Text + "','" + tbskname.Text + "','" + tbsknumber.Text + "','" + gender + "','" + dtpDateOrd.Value.Date + "','" + dtpDateRec.Value.Date + "','" + numericUpDown1.Text + "','" + tbskprice.Text + "','" + tblength.Text + "','" + tbshoulderslop.Text + "','" + tbsleeves.Text + "','" + tbneck.Text + "','" + tbchest.Text + "','" + tbwaist.Text + "','" + tbsurrounds.Text + "','" + tbslength.Text + "','" + check + "','" + tblegbutom.Text + "','" + tbshalwarsurround.Text + "','" + tbban.Text + "','" + tbcollartip.Text + "','" + tbcuffwidth.Text + "','" + tbfrontpocket.Text + "','" + tbsidepocket.Text + "','" + Surroundplan + "','" + richTextBox1.Text + "')";
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

        
    }
}
