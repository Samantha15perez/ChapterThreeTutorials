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
    public partial class CookieCalories : Form
    {
        public CookieCalories()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCalories_Click(object sender, EventArgs e)
        {

        }

        private void txtCookies_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //closes the form
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCookies.Text = "";
            lblCalories.Text = "";
            //resets the fields
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //calculates field values and raises an error if the input is invalid
            try
            {
                double calories = double.Parse(txtCookies.Text) * 75;

                lblCalories.Text = calories.ToString();
            }
            catch
            {
                MessageBox.Show("Input is invalid");

            }
        }
    }
}
