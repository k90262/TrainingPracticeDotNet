using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_ForDelegateTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //f = Add;
        }

        double Add(double a, double b)
        {
            return a + b;
        }
        double Sub(double a, double b)
        {
            return a - b;
        }
        double Mul(double a, double b)
        {
            return a * b;
        }
        double Div(double a, double b)
        {
            return a / b;
        }
        double Mod(double a, double b)
        {
            return a % b;
        }
        Func<double, double, double> f;
        private void button1_Click(object sender, EventArgs e)
        {
            double no1 = double.Parse(textBox1.Text);
            double no2 = double.Parse(textBox2.Text);
            double ans =f.Invoke(no1, no2);
            label1.Text = ans.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text) {
                case "+":
                    f = delegate(double a, double b)
                    {
                        return a + b;
                    };
                    break;
                case "-":
                    f = (a, b) =>
                    {
                        return a - b;
                    };
                    break;
                case "*":
                    f = (a, b) => a * b;
                    break;
                case "/":
                    f = (a, b) => a / b;
                    break;
                case "%":
                    f = Mod;
                    break;
            }
        }
    }
}
