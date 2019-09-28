using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        private int no;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //if (no == 1)
            //    button1.Left += 10;
            //else if (no == 2)
            //    button2.Left += 10;
            //else if (no == 3)
            //    button3.Left += 10;
            //else if (no == 4)
            //    button4.Left += 10;
            //else
            //    MessageBox.Show("Please choose a button!");

            switch (no)
            {
                case 1:
                    button1.Left += 10;
                    break;
                case 2:
                    button2.Left += 10;
                    break;
                case 3:
                    button3.Left += 10;
                    break;
                case 4:
                    button4.Left += 10;
                    break;
                default:
                    MessageBox.Show("Please choose a button!");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            no = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            no = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            no = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            no = 4;
        }
    }
}
