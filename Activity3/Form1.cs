using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity3
{
    public partial class Form1 : Form
    {

        double firstNumber;
        double secondNumber;
        double result;
        string operatorx;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e) {
            textBoxScreen.Text = textBoxScreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = textBoxScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = textBoxScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = textBoxScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = textBoxScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = textBoxScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = textBoxScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = textBoxScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = textBoxScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = textBoxScreen.Text + "9";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = textBoxScreen.Text + ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operatorx = "+";
            firstNumber = double.Parse(textBoxScreen.Text);
            textBoxScreen.Clear();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operatorx = "-";
            firstNumber = double.Parse(textBoxScreen.Text);
            textBoxScreen.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operatorx = "*";
            firstNumber = double.Parse(textBoxScreen.Text);
            textBoxScreen.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operatorx = "/";
            firstNumber = double.Parse(textBoxScreen.Text);
            textBoxScreen.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(textBoxScreen.Text);
            switch( operatorx)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    textBoxScreen.Text = result.ToString();
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    textBoxScreen.Text = result.ToString();
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    textBoxScreen.Text = result.ToString();
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    textBoxScreen.Text = result.ToString();
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxScreen.Clear();
        }
    }
}
