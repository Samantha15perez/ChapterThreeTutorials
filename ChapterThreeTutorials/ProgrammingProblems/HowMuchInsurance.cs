using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProblems
{
    public partial class HowMuchInsurance : Form
    {
        public HowMuchInsurance()
        {
            InitializeComponent();
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblInsurance_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //closes the form

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCost.Text = "";
            lblInsurance.Text = "";
            //resets fields to blank
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //this button calculates the fields based on the options selected and outputs in terms of money. 
            try
            {
                double cost = double.Parse(txtCost.Text);
                double insure = cost * 0.8;

                lblInsurance.Text = insure.ToString("c");
            }
            catch
            {
                MessageBox.Show("Numbers Only, Please!");
                //improper inputs prompt an error
            }
        }
    }
}
