using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial33
{
    public partial class SalePriceCalc : Form
    {
        public SalePriceCalc()
        {
            InitializeComponent();
        }

        private void originalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountPercentageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salePriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal discountAmount;
            decimal salePrice;

            originalPrice = decimal.Parse(originalPriceTextBox.Text);

            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            discountPercentage = discountPercentage / 100;

            discountAmount = originalPrice * discountPercentage;

            salePrice = originalPrice - discountAmount;

            salePriceLabel.Text = salePrice.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
