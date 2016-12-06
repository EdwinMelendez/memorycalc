using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Calc
{
    public class CalculatorB
    {


        public static double Plus(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Minus(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Times(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Div(double n1, double n2)
        {
            return n1 / n2;
        }



        public static void Negate(TextBox Inside) //negate method
        {
            string n = Convert.ToString(Inside.Text);
            string negate = "";

            if (n.StartsWith("-")) { negate = n.Trim('-'); }
            else { negate = "-" + n; }

            Inside.Text = Convert.ToString(negate);
        }

        public static void Exponent(TextBox Inside) //exponent method
        {
            decimal n = Convert.ToDecimal(Inside.Text);
            decimal exponent = 1 / n;
            Inside.Text = Convert.ToString(exponent);
        }

        public static void Squareroot(TextBox Inside) //square root method
        {
            double n = Convert.ToDouble(Inside.Text);
            double sqrt = Math.Sqrt(n);
            Inside.Text = Convert.ToString(sqrt);
        }

        public static void Back(TextBox Inside) //back button
        {
            string n = Convert.ToString(Inside.Text);
            string back = n.Remove(n.Length - 1);
            Inside.Text = Convert.ToString(back);
        }

    }
}
