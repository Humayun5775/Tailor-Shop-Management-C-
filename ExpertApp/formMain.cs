using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertApp
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCustomerShalwarKamez formCustomerShalwarKamez = new FormCustomerShalwarKamez();
            formCustomerShalwarKamez.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCoatPent formCoatPent = new FormCoatPent();
            formCoatPent.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormShalwarkameezDetails formDetails = new FormShalwarkameezDetails();
            formDetails.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formPentCoatDetail formPentCoatDetail = new formPentCoatDetail();
            formPentCoatDetail.Show();

        }
    }
}
