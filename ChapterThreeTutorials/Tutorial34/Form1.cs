using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial34
{
    public partial class TestAverage : Form
    {
        public TestAverage()
        {
            InitializeComponent();
        }

        private void TL1_Click(object sender, EventArgs e)
        {

        }

        private void test1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void test2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void test3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            try
            {
                double test1;
                double test2;
                double test3;
                double average;

                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                average = (test1 + test2 + test3) / 3.0;

                outputDescriptionLabel.Text = average.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            outputDescriptionLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
