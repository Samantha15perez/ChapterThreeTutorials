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
    public partial class PropertyTax : Form
    {
        public PropertyTax()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPropTax_Click(object sender, EventArgs e)
        {

        }

        private void txtPropValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //closes form
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPropValue.Text = "";
            lblPropTax.Text = "";
            //resets the form
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //calculates property tax with error handling for non-numeric input
            try
            {
                double tax = (double.Parse(txtPropValue.Text) / 100) * 0.64;

                lblPropTax.Text = tax.ToString();
            }
            catch
            {
                MessageBox.Show("Numbers Only, Please!")

                    ;

            }
        }
    }
}
