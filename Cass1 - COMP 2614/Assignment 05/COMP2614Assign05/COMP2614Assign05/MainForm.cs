using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //reset runtime label
            labelOutput.Text = string.Empty;
        }

        //validate and output result
        private void buttonCheckDate_Click(object sender, EventArgs e)
        {
            bool validDate = DateValidator.Validate(textBoxYear.Text,textBoxMonth.Text,textBoxDay.Text);
            
            if(validDate)
            {
                labelOutput.ForeColor = Color.Green;
                labelOutput.Text = "Valid";
                toolTipOnMainForm.SetToolTip(labelOutput, "Entered Date is Valid");
            }
            else
            {
                labelOutput.ForeColor = Color.Red;
                labelOutput.Text = "Invalid";
                toolTipOnMainForm.SetToolTip(labelOutput, "Entered Date is NOT Valid");
            }
        }

        private void textBoxYear_Enter(object sender, EventArgs e)
        {
            textBoxYear.SelectAll();
        }

        private void textBoxMonth_Enter(object sender, EventArgs e)
        {
            textBoxMonth.SelectAll();
        }

        private void textBoxDay_Enter(object sender, EventArgs e)
        {
            textBoxDay.SelectAll();
        }
    }
}
