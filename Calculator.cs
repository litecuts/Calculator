using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppRemake
{
    public partial class CalculatorDisplay : Form
    {

        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        public CalculatorDisplay()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "1";
            Display.Text += userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "2";
            Display.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "3";
            Display.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "4";
            Display.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "5";
            Display.Text += userInput;
          
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "6";
            Display.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "7";
            Display.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "8";
            Display.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "9";
            Display.Text += userInput;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "0";
            Display.Text += userInput;
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            Display.Text += ".";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if(function == '+')
            {
                result = firstNum + secondNum;
                Display.Text = result.ToString();
            }
            else if(function == '-')
            {
                result = firstNum - secondNum;
                Display.Text = result.ToString();
            }
            else if(function == '/')
            {
                if (secondNum == '0')
                {
                    Display.Text = "LMAO NO";
                }
                else
                {
                    result = firstNum / secondNum;
                    Display.Text = result.ToString();
                }
                
            }
            else if(function == '*')
            {
                result = firstNum * secondNum;
                Display.Text = result.ToString();
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            Display.Text = "0";    

        }
    }
}
