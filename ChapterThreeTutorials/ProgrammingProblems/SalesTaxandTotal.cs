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
    public partial class SalesTaxandTotal : Form
    {
        public SalesTaxandTotal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //closes form
        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalText_Click(object sender, EventArgs e)
        {

        }

        private void lblCountyText_Click(object sender, EventArgs e)
        {

        }

        private void lblStateText_Click(object sender, EventArgs e)
        {

        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void lblTaxText_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPurchase.Text = "";
            lblState.Text = "";
            lblCounty.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
            //resets fields to blank
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblCounty_Click(object sender, EventArgs e)
        {

        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void txtPurchase_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //calculates fields with error handling for non numeric values

            try
            {
                double amount = double.Parse(txtPurchase.Text);
                double state = amount * 0.04;
                double county = amount * 0.02;
                double tax = state + county;
                double total = tax + amount;

                lblState.Text = state.ToString("c");
                lblCounty.Text = county.ToString("c");
                lblTax.Text = tax.ToString("c");
                lblTotal.Text = total.ToString("c");
            }
            catch
            {
                MessageBox.Show("you did the thing wrong");

            }
        }
    }
}
