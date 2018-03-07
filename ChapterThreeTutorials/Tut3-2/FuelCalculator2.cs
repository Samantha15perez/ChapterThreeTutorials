using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut3_2
{
    public partial class FuelCalculator2 : Form
    {
        public FuelCalculator2()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles; //to hold miles driven
            double gallons; //to hold gallons used
            double mpg; //to hold  mpg
            //get the miles driven and assign it to
            //the miles variable
            miles = double.Parse(milesTextBox.Text);
            //get the gallons used and assign it to
            //the gallons variable
            gallons = double.Parse(gallonsTextBox.Text);
            //Calculate MPG
            mpg = miles / gallons;
            //display the mpg in the mpglabel control
            mpgLabel.Text = mpg.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the thing
            this.Close();
        }

        private void milesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gallonsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void milesPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void gallonsPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void mpgLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
