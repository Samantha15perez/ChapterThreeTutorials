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
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void btnToCelsius_Click(object sender, EventArgs e)
        {
            //generates results in celsius 
            try
            {
                double fahr = double.Parse(txtInput.Text);
                double cels = (fahr - 32.0) / 1.8;

                lblOutput.Text = cels.ToString();
            }

            catch
            {
                MessageBox.Show("Invalid Input");

            }
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //closes form
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            lblOutput.Text = "";
        }//resets fields to blank

        private void btnToFahrenheit_Click(object sender, EventArgs e)
        {
            //generates results in fahrenheit
            try
            {
                double cels = double.Parse(txtInput.Text);
                double fahr = cels * 1.8 + 32;

                lblOutput.Text = fahr.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Input");

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
