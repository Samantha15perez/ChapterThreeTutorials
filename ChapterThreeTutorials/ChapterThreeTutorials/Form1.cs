using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapterThreeTutorials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
        
                //Declare a string variable.
                string output;
                //Concatenate the input and build the output string
                output = dayOfWeekTextbox.Text + ", " +
                    monthTextBox.Text + " " +
                    dayOfMonthTextBox.Text + ", " +
                    yearTextBox.Text;

                //display the output string in the label control.
                dateOutputLabel.Text = output;
            }
            private void clearButton_Click(object sender, EventArgs e)
            {
                //Clear the textboxes
                dayOfWeekTextbox.Text = "";
                monthTextBox.Text = "";
                dayOfMonthTextBox.Text = "";
                yearTextBox.Text = "";
                //Clear the dateoutputlabel control
                dateOutputLabel.Text = "";
            }
            private void exitButton_Click(object sender, EventArgs e)
            {
                //close the form
                this.Close();
            }

        private void dayOfWeekTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dayOfMonthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
}
