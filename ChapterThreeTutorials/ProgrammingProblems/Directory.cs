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
    public partial class Directory : Form
    {
        public Directory()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameFormatter_Click(object sender, EventArgs e)
        {
            NameFormatter NF = new NameFormatter();
            NF.Show();
        }

        private void TipTaxandTotal_Click(object sender, EventArgs e)
        {
            TipTaxandTotal TTT = new TipTaxandTotal();
            TTT.Show();
        }

        private void DistanceTraveled_Click(object sender, EventArgs e)
        {
            DistanceTraveled DT = new DistanceTraveled();
            DT.Show();
        }

        private void SalesTaxandTotal_Click(object sender, EventArgs e)
        {
            SalesTaxandTotal STT = new SalesTaxandTotal();
            STT.Show();
        }

        private void TemperatureConverter_Click(object sender, EventArgs e)
        {
            TemperatureConverter TC = new TemperatureConverter();
            TC.Show();
        }

        private void BodyMassIndex_Click(object sender, EventArgs e)
        {
            BodyMassIndex BMI = new BodyMassIndex();
            BMI.Show();
        }

       
        private void button9_Click(object sender, EventArgs e)
        {
            HowMuchInsurance HMI = new HowMuchInsurance();
            HMI.Show();
        }

        private void CookieCalories_Click(object sender, EventArgs e)
        {
            CookieCalories CC = new CookieCalories();
            CC.Show();
        }

        private void CalorieCounter_Click(object sender, EventArgs e)
        {
            CalorieCounter CC2 = new CalorieCounter();
            CC2.Show();
        }

        private void AutomobileCosts_Click(object sender, EventArgs e)
        {
            AutomobileCosts AC = new AutomobileCosts();
            AC.Show();
        }

        private void PaintJobEstimator_Click(object sender, EventArgs e)
        {
            PaintJobEstimator PJE = new PaintJobEstimator();
            PJE.Show();
        }

        private void PropertyTax_Click(object sender, EventArgs e)
        {
            PropertyTax PT = new PropertyTax();
            PT.Show();
        }

      
    }
}
