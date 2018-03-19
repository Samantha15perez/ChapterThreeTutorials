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
    public partial class BodyMassIndex : Form
    {
        public BodyMassIndex()
        {
            InitializeComponent();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close button closes the window

            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear button resets every field to blank

            txtHeight.Text = "";
            txtWeight.Text = "";
            lblOutput.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Within the calculate button is a try-catch block that handles the math involved, raising an error if anything besides numeric values are supplied. 

            try
            {
                double weight = double.Parse(txtWeight.Text);
                double height = double.Parse(txtHeight.Text);
                double BMI = weight * 703 / (height * height);

                lblOutput.Text = BMI.ToString("N3");
            }
            catch
            {
                //Error is easy to follow

                MessageBox.Show("Numbers Only, Please!");

            }
        }
    }
}
