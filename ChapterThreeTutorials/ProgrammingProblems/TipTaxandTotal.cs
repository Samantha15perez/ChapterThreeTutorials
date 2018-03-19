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
    public partial class TipTaxandTotal : Form
    {
        public TipTaxandTotal()
        {
            InitializeComponent();
        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void txtMeal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTip_Click(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblTipText_Click(object sender, EventArgs e)
        {

        }

        private void lblTaxText_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalText_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {//calculates fields based on input, with error handling for non-numeric values. 
            try
            {
                double price = double.Parse(txtMeal.Text);
                double tip = price * 0.15;
                double tax = price * 0.07;
                double total = price + tip + tax;

                lblTip.Text = tip.ToString("c");
                lblTax.Text = tax.ToString("c");
                lblTotal.Text = total.ToString("c");
            }
            catch
            {
                MessageBox.Show("There was an issue calculating this. Make sure that all you entered were numbers.");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMeal.Text = "";
            lblTip.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
