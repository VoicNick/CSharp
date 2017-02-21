using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TableGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string regex = @"^\d\d\d\d\d\d$";

            if (textBoxStudentNumber.Text.Length == 0)
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Please complete your student number";
                return;
            }

            if (!Regex.IsMatch(textBoxStudentNumber.Text, regex))
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Please enter six digits";
                return;
            }

            string tableName = string.Format("Client{0}", textBoxStudentNumber.Text);

            try
            {
                DbUtilities.GenerateTable(tableName);
                labelResult.ForeColor = Color.Black;
                labelResult.Text = string.Format("The table {0} has been created successfully", tableName);
            }
            catch (Exception ex)
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = string.Format("The table {0} was not created\r\n{1}", tableName, ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelResult.Text = string.Empty;
        }
    }
}
