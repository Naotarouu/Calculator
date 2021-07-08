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
        calClass cal = new calClass();
        
        public Calculator()
        {
            InitializeComponent();

            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clickButton(object sender, EventArgs e)
        {
            if ((textResult.Text == "0") || (cal.PerformedOperation) || (cal.MemoryFlag))
                textResult.Clear();

            cal.PerformedOperation = false;
            cal.MemoryFlag = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textResult.Text.Contains("."))
                { 
                    textResult.Text += button.Text; 
                }
            }
            else 
            {
                textResult.Text += button.Text;               
            }
            
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
            cal.Value_result = 0;
            current_operation.Text = "";
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void clickOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (cal.Value_result != 0)
            {
                buttonEqual.PerformClick();
                cal.Performing_operation = button.Text;
                current_operation.Text = cal.Value_result + " " + cal.Performing_operation;
                cal.PerformedOperation = true;

            }
            else
            {
                cal.Performing_operation = button.Text;
                cal.Value_result = Double.Parse(textResult.Text);
                current_operation.Text = cal.Value_result + " " + cal.Performing_operation;
                cal.PerformedOperation = true;
            }

        }

        private void clickEqual(object sender, EventArgs e)
        {
            switch (cal.Performing_operation) 
            {
                case "+":
                    textResult.Text = (cal.Value_result + Double.Parse(textResult.Text)).ToString();
                    break;
                case "-":
                    textResult.Text = (cal.Value_result - Double.Parse(textResult.Text)).ToString();
                    break;
                case "*":
                    textResult.Text = (cal.Value_result * Double.Parse(textResult.Text)).ToString();
                    break;
                case "/":
                    textResult.Text = (cal.Value_result / Double.Parse(textResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            cal.Value_result = Double.Parse(textResult.Text);
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

        private void clickPercent(object sender, EventArgs e)
        {
            double percent = Double.Parse(textResult.Text);
            current_operation.Text = System.Convert.ToString(textResult.Text + "%");
            percent = percent / 100;
            textResult.Text = System.Convert.ToString(percent);
        }

        private void clickMS(object sender, EventArgs e)
        {
            cal.Memory = Double.Parse(textResult.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            cal.MemoryFlag = true;
        }

        private void clickMR(object sender, EventArgs e)
        {
            textResult.Text = cal.Memory.ToString();
            cal.MemoryFlag = true;
        }

        private void clickMC(object sender, EventArgs e)
        {
            textResult.Text = "0";
            cal.Memory = 0;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }

        private void clickMPlus(object sender, EventArgs e)
        {
            cal.Memory += Double.Parse(textResult.Text);
        }

        private void clickMMinus(object sender, EventArgs e)
        {
            cal.Memory -= Double.Parse(textResult.Text);
        }
    }
}
