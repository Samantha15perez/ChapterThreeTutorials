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
    public partial class AutomobileCosts : Form
    {
        public AutomobileCosts()
        {
            InitializeComponent();
        }

        private void txtLoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTires_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInsurance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaintenance_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMonthly_Click(object sender, EventArgs e)
        {

        }

        private void lblYearly_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Within the calculate button is a try-catch block that handles the math involved, raising an error if anything besides numeric values are supplied. 

            try
            {
                double maintain = double.Parse(txtMaintenance.Text);
                double loan = double.Parse(txtLoan.Text);
                double insure = double.Parse(txtInsurance.Text);
                double gas = double.Parse(txtGas.Text);
                double oil = double.Parse(txtOil.Text);
                double tires = double.Parse(txtTires.Text);
                double monthly = maintain + loan + insure + gas + oil + tires;
                double yearly = monthly * 12;

                lblMonthly.Text = monthly.ToString("c");
                lblYearly.Text = yearly.ToString("c");
            }
            catch
            {
                //Error is easy to follow

                MessageBox.Show("Numbers Only, Please!");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            //clear button resets every field to blank

            txtGas.Text = "";
            txtInsurance.Text = "";
            txtLoan.Text = "";
            txtMaintenance.Text = "";
            txtOil.Text = "";
            txtTires.Text = "";
            lblMonthly.Text = "";
            lblYearly.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close button closes the window

            this.Close();
        }
    }
}
