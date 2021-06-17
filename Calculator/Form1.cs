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
    public partial class Calculator : Form
    {
        Double value_result = 0;
        String performing_operation = "";
        bool performedOperation = false;
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clickButton(object sender, EventArgs e)
        {
            if ((textResult.Text == "0") || (performedOperation))
                textResult.Clear();

            performedOperation = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textResult.Text.Contains("."))
                    textResult.Text += button.Text;

            }
            else { }
            textResult.Text += button.Text;
        }

        private void buttonBSpace_Click(object sender, EventArgs e)
        {
            if (textResult.Text.Length > 0)
            {
                textResult.Text = textResult.Text.Remove(textResult.Text.Length - 1, 1);
            }

            if (textResult.Text == "")
            {
                textResult.Text = "0";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
            value_result = 0;
            current_operation.Text = "";
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void clickOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (value_result != 0)
            {
                buttonEqual.PerformClick();
                performing_operation = button.Text;
                current_operation.Text = value_result + " " + performing_operation;
                performedOperation = true;

            }
            else
            {
                performing_operation = button.Text;
                value_result = Double.Parse(textResult.Text);
                current_operation.Text = value_result + " " + performing_operation;
                performedOperation = true;
            }

        }


        private void clickEqual(object sender, EventArgs e)
        {
            switch (performing_operation) 
            {
                case "+":
                    textResult.Text = (value_result + Double.Parse(textResult.Text)).ToString();
                    break;
                case "-":
                    textResult.Text = (value_result - Double.Parse(textResult.Text)).ToString();
                    break;
                case "*":
                    textResult.Text = (value_result * Double.Parse(textResult.Text)).ToString();
                    break;
                case "/":
                    textResult.Text = (value_result / Double.Parse(textResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            value_result = Double.Parse(textResult.Text);
            current_operation.Text = "";        
        }

        private void clickSqrt(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(textResult.Text);
            current_operation.Text = System.Convert.ToString("Sqrt" + "(" + (textResult.Text) + ")");
            sqrt = Math.Sqrt(sqrt);
            textResult.Text = System.Convert.ToString(sqrt);
        }

        private void clickReciprocal(object sender, EventArgs e)
        {
            double reciprocal = Double.Parse(textResult.Text);
            current_operation.Text = System.Convert.ToString("1/" + "(" + textResult.Text + ")" );
            reciprocal = 1 / reciprocal;
            textResult.Text = System.Convert.ToString(reciprocal);
        }

        private void clickNegation(object sender, EventArgs e)
        {
            double negation = Double.Parse(textResult.Text);
            current_operation.Text = System.Convert.ToString("-" + "(" + textResult.Text + ")");
            negation = negation * -1;
            textResult.Text = System.Convert.ToString(negation);
        }
    }
}
