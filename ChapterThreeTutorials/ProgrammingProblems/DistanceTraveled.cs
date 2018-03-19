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
    public partial class DistanceTraveled : Form
    {
        public DistanceTraveled()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //closes the form
        }

        private void lbl8DistanceText_Click(object sender, EventArgs e)
        {

        }

        private void lbl5DistanceText_Click(object sender, EventArgs e)
        {

        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void lbl12DistanceText_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSpeed.Text = "";
            lbl5Distance.Text = "";
            lbl8Distance.Text = "";
            lbl12Distance.Text = "";
            //resets fields to blank
        }

        private void lbl12Distance_Click(object sender, EventArgs e)
        {

        }

        private void lbl8Distance_Click(object sender, EventArgs e)
        {

        }

        private void lbl5Distance_Click(object sender, EventArgs e)
        {

        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //handles the multiplication necessary to calculate mileage, raises an error if input is invalid
            try
            {
                double speed = double.Parse(txtSpeed.Text);
                double five = speed * 5;
                double eight = speed * 8;
                double twelve = speed * 12;

                lbl5Distance.Text = five.ToString();
                lbl8Distance.Text = eight.ToString();
                lbl12Distance.Text = twelve.ToString();

            }
            catch
            {
                MessageBox.Show("Numbers Only, Please!");

            }
        }
    }
}
