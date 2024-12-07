using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        double resultValue = 0;
        bool isOperationPerformed = false;
        string operationPerformed = "";
        public CalculatorForm()
        {
            InitializeComponent();
        }

        // adds entered numbers into the calculator field
        private void btn_Click(object sender, EventArgs e)
        {
            // clears the field so the 0 is deleted from in front of the equation
            // deters "0190 + 10 = 200" type situation
            if (txtResult.Text == "0" || isOperationPerformed)
            {
                txtResult.Clear();
            }
            Button button = (Button)sender;
            txtResult.Text += button.Text;
        }

        // saves the first number and the chosen operand
        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (txtResult.Text.Length > 0)
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(txtResult.Text);
                firstValue.Text = resultValue + " " + operationPerformed + " ";
                txtResult.Clear();
            }

            // gives user possibility to change operator after already choosing one
            // eg. user misclicked "-" but wanted to do addition ("+")
            if (operationPerformed != button.Text)
            {
                operationPerformed = button.Text;
                firstValue.Text = resultValue + " " + operationPerformed + " ";
                txtResult.Clear();
            }
        }

        //"CE" button function, resets everything
        private void btnClear_Click(object sender, EventArgs e)
        {
            resultValue = 0;
            isOperationPerformed = false;
            txtResult.Clear();
            firstValue.Text = "";
        }

        // does the operation with the already saved value
        // and the value currently typed into the calculator field
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                firstValue.Text = firstValue.Text + txtResult.Text;
                txtResult.Text = (resultValue + double.Parse(txtResult.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                firstValue.Text = firstValue.Text + txtResult.Text;
                txtResult.Text = (resultValue - double.Parse(txtResult.Text)).ToString();
            }
            else if (operationPerformed == "x")
            {
                firstValue.Text = firstValue.Text + txtResult.Text;
                txtResult.Text = (resultValue * double.Parse(txtResult.Text)).ToString();
            }
            else if (operationPerformed == "/")
            {
                firstValue.Text = firstValue.Text + txtResult.Text;
                txtResult.Text = (resultValue / double.Parse(txtResult.Text)).ToString();
            }
        }
    }
}