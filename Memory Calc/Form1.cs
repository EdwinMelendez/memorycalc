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
        }
    }
}
