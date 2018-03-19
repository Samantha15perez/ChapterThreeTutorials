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
    public partial class NameFormatter : Form
    {
        public NameFormatter()
        {
            InitializeComponent();
        }

        private void lblPrefix_Click(object sender, EventArgs e)
        {

        }

        private void lblFirst_Click(object sender, EventArgs e)
        {

        }

        private void lblMiddle_Click(object sender, EventArgs e)
        {

        }

        private void lblLast_Click(object sender, EventArgs e)
        {

        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiddle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNameDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnPFML_Click(object sender, EventArgs e)
        {
            string first = txtFirst.Text;
            string middle = txtMiddle.Text;
            string last = txtLast.Text;
            string title = txtPrefix.Text;
            string name = title + " " + first + " " + middle + " " + last;

            lblNameDisplay.Text = name;
            //generates text order based on criteria listed
        }

        private void btnFML_Click(object sender, EventArgs e)
        {
            string first = txtFirst.Text;
            string middle = txtMiddle.Text;
            string last = txtLast.Text;
            string name = first + " " + middle + " " + last;

            lblNameDisplay.Text = name;
            //generates text order based on criteria listed
        }

        private void btnFL_Click(object sender, EventArgs e)
        {
            string first = txtFirst.Text;
            string last = txtLast.Text;
            string name = first + " " + last;

            lblNameDisplay.Text = name;
            //generates text order based on criteria listed
        }

        private void btnLFMP_Click(object sender, EventArgs e)
        {
            string first = txtFirst.Text;
            string middle = txtMiddle.Text;
            string last = txtLast.Text;
            string title = txtPrefix.Text;
            string name = last + ", " + first + " " + middle + ", " + title;

            lblNameDisplay.Text = name;
            //generates text order based on criteria listed
        }


        private void btnLFM_Click(object sender, EventArgs e)
        {
            string first = txtFirst.Text;
            string middle = txtMiddle.Text;
            string last = txtLast.Text;
            string title = txtPrefix.Text;
            string name = last + ", " + first + " " + middle;

            lblNameDisplay.Text = name;
            //generates text order based on criteria listed
        }

        private void btnLF_Click(object sender, EventArgs e)
        {
            string first = txtFirst.Text;
            string middle = txtMiddle.Text;
            string last = txtLast.Text;
            string title = txtPrefix.Text;
            string name = last + ", " + first;

            lblNameDisplay.Text = name;
            //generates text order based on criteria listed
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "";
            txtMiddle.Text = "";
            txtLast.Text = "";
            txtPrefix.Text = "";
            lblNameDisplay.Text = "";
            //resets fields to blank
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //closes the form
        }
    }
}

