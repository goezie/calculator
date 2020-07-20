using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private float floFirstNumber;
        private double dubFirstNumber;
        private float floSecondNumber;
        private string strOperator;
        private string strExtraOutput = "";
        private string strOutput = "";
        private float floOutput;
        private double dubOutput;
        private decimal decEuro;

        private void updateDisplay(string s)
        {
            strOutput += s;
            output.Text = strOutput;
            extraOutput.Text = strExtraOutput;
        }

        private void updateDisplay()
        {
            output.Text = strOutput;
            extraOutput.Text = strExtraOutput;
        }


        private void one_Click(object sender, EventArgs e)
        {
            updateDisplay("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            updateDisplay("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            updateDisplay("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            updateDisplay("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            updateDisplay("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            updateDisplay("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            updateDisplay("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            updateDisplay("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            updateDisplay("9");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            updateDisplay("0");
        }

        private void comma_Click(object sender, EventArgs e)
        {
            updateDisplay(",");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(strOutput) || strOutput == "-")
            {
                strOutput = "-";
                output.Text = strOutput;
            } else
            {
                strOperator = "-";
                floFirstNumber = float.Parse(strOutput);
                strExtraOutput = $"{strOutput} {strOperator}";
                extraOutput.Text = strExtraOutput;
                strOutput = "";
                output.Text = strOutput;
            }

        }

        private void square_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strOutput) && strOutput != "-")
            {
                floFirstNumber = float.Parse(strOutput);
                floOutput = floFirstNumber * floFirstNumber;
                strOutput = floOutput.ToString();
                output.Text = strOutput;
                strExtraOutput = $"{floFirstNumber}²";
                extraOutput.Text = strExtraOutput;
                
            }
        }

        private void euro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strOutput) && strOutput != "-")
            {
                dubOutput = double.Parse(strOutput);
                strOutput = RoundDown(dubOutput, 2).ToString();
                updateDisplay();
            }
        }

        private void correction_Click(object sender, EventArgs e)
        {
            strOutput = strOutput.Remove(strOutput.Length - 1);
            updateDisplay();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strOutput) && strOutput != "-")
            {
                strOperator = "+";
                floFirstNumber = float.Parse(strOutput);
                strExtraOutput = $"{strOutput} {strOperator}";
                extraOutput.Text = strExtraOutput;
                strOutput = "";
                output.Text = strOutput;
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strOutput) && strOutput != "-")
            {
                strOperator = "*";
                floFirstNumber = float.Parse(strOutput);
                strExtraOutput = $"{strOutput} {strOperator}";
                extraOutput.Text = strExtraOutput;
                strOutput = "";
                output.Text = strOutput;
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strOutput) && strOutput != "-")
            {
                strOperator = "/";
                floFirstNumber = float.Parse(strOutput);
                strExtraOutput = $"{strOutput} {strOperator}";
                extraOutput.Text = strExtraOutput;
                strOutput = "";
                output.Text = strOutput;
            }
        }

        private void root_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strOutput) && strOutput != "-")
            {
                dubFirstNumber = double.Parse(strOutput);
                dubOutput = Math.Sqrt(dubFirstNumber);
                strOutput = dubOutput.ToString();
                output.Text = strOutput;
                strExtraOutput = $"√{dubFirstNumber}";
                extraOutput.Text = strExtraOutput;

            }
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strOperator) && !string.IsNullOrEmpty(strOutput))
            {
                floSecondNumber = float.Parse(strOutput) / 100;
                updateDisplay("%");
                solve();
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            floSecondNumber = float.Parse(strOutput);
            solve();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            strOutput = "";
            strExtraOutput = "";
            updateDisplay();
        }

        private void solve()
        {
            

            if (strOperator == "+")
            {
                floOutput = floFirstNumber + floSecondNumber;
                strOutput = floOutput.ToString();
                strExtraOutput += $" {floSecondNumber}";
                updateDisplay();
            }
            if (strOperator == "-")
            {
                floOutput = floFirstNumber - floSecondNumber;
                strOutput = floOutput.ToString();
                strExtraOutput += $" {floSecondNumber}";
                updateDisplay();
            }
            if (strOperator == "*")
            {
                floOutput = floFirstNumber * floSecondNumber;
                strOutput = floOutput.ToString();
                strExtraOutput += $" {floSecondNumber}";
                updateDisplay();
            }
            if (strOperator == "/")
            {
                floOutput = floFirstNumber / floSecondNumber;
                strOutput = floOutput.ToString();
                strExtraOutput += $" {floSecondNumber}";
                updateDisplay();
            }
            floSecondNumber = 0;
        }

        private double RoundDown(double number, int decimalPlaces)
        {
            return Math.Floor(number * Math.Pow(10, decimalPlaces)) / Math.Pow(10, decimalPlaces);
        }
    }
}
