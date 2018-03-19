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
    public partial class PaintJobEstimator : Form
    {
        public PaintJobEstimator()
        {
            InitializeComponent();
        }

        private void txtWallSpace_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblLaborCost_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblPaintCost_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblLaborHours_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBasePaint_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGallonNumber_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBasePaint.Text = "";
            txtWallSpace.Text = "";
            lblGallonNumber.Text = "";
            lblLaborHours.Text = "";
            lblLaborCost.Text = "";
            lblPaintCost.Text = "";
            lblTotalCost.Text = "";

            //resets fields to blank
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Calculates the fields properly, with error handling for invalid inputs
            try
            {
                double wallspace = double.Parse(txtWallSpace.Text);
                double paintprice = double.Parse(txtBasePaint.Text);
                double gallonsneeded = Math.Ceiling(wallspace / 115);
                double laborhours = Math.Ceiling((wallspace / 115) * 8);
                double paintcost = gallonsneeded * paintprice;
                double laborcost = laborhours * 20.00;
                double totalcost = laborcost + paintcost;


                lblGallonNumber.Text = gallonsneeded.ToString();
                lblLaborHours.Text = laborhours.ToString();
                lblPaintCost.Text = paintcost.ToString("c");
                lblLaborCost.Text = laborcost.ToString("c");
                lblTotalCost.Text = totalcost.ToString("c");
            }
            catch
            {
                MessageBox.Show("Numbers Only, Please!");

            }
        }
    }
}
