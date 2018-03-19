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
    public partial class CalorieCounter : Form
    {
        public CalorieCounter()
        {
            InitializeComponent();
        }

        int calories = 0;

        //sets calories as a variable

        private void pbBanana_Click(object sender, EventArgs e)
        {
            calories = calories + 115;
            lblOutput.Text = calories.ToString();

            //clicking this picturebox adds 115 to the calorie count
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            calories = 0;
            
            //clears output
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void pbPear_Click(object sender, EventArgs e)
        {
            calories = calories + 120;
            lblOutput.Text = calories.ToString();

            //clicking this picturebox adds 120 to the calorie count
        }

        private void pbOrange_Click(object sender, EventArgs e)
        {
            calories = calories + 90;
            lblOutput.Text = calories.ToString();

            //clicking this picturebox adds 90 to the calorie count
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            //closes document
        }

        private void pbApple_Click(object sender, EventArgs e)
        {
            calories = calories + 80;
            lblOutput.Text = calories.ToString();

            //clicking this picturebox adds 80 to the calorie count
            //this document has no need for error handling
        }
    }
}
