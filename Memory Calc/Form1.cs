using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double value = 0;
        String operation = "";
        bool operation_Pressed = false;

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtAnswer.Text == "0")||(operation_Pressed))
                txtAnswer.Clear();
            operation_Pressed = false;

            Button b = (Button)sender;

            if (b.Text == ".")
            {
                if (!txtAnswer.Text.Contains("."))
                    txtAnswer.Text = txtAnswer.Text + b.Text;
            }
            else

                txtAnswer.Text = txtAnswer.Text + b.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(txtAnswer.Text);
            operation_Pressed = true;
            equation.Text = value + " " + operation;


        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    txtAnswer.Text = CalculatorB.Plus(value, Double.Parse(txtAnswer.Text)).ToString();
                    break;
                case "-":
                    txtAnswer.Text = CalculatorB.Minus(value, Double.Parse(txtAnswer.Text)).ToString();
                    break;
                case "*":
                    txtAnswer.Text = CalculatorB.Times(value, Double.Parse(txtAnswer.Text)).ToString();
                    break;
                case "/":
                    txtAnswer.Text = CalculatorB.Div(value, Double.Parse(txtAnswer.Text)).ToString();
                    break;

                    
            }

            value = Double.Parse(txtAnswer.Text);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case "0":
                    btn1.PerformClick();
                    break;
                case "+":
                    btnPlus.PerformClick();
                    break;
                case "-":
                    btnMinus.PerformClick();
                    break;
                case "*":
                    btnTimes.PerformClick();
                    break;
                case "/":
                    btnDiv.PerformClick();
                    break;

            }
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            CalculatorB.Negate(txtAnswer);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            CalculatorB.Squareroot(txtAnswer);
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            CalculatorB.Exponent(txtAnswer);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CalculatorB.Back(txtAnswer);
        }
    }
}
