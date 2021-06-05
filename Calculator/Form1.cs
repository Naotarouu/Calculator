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
        String performed_operation = "";
       
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clickButton(object sender, EventArgs e)
        {
            if (textResult.Text == "0")
                textResult.Clear();

            Button button = (Button)sender;
            textResult.Text = textResult.Text + button.Text;
        }

        private void buttonBSpace_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text.Substring(0, textResult.Text.Length - 1);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
            value_result = 0;
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void clickOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            performed_operation = button.Text;
            value_result = Double.Parse(textResult.Text);

        }


        private void clickEqual(object sender, EventArgs e)
        {
            switch (performed_operation) 
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
               
        }
    }
}
