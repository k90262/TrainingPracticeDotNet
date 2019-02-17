using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        private int no = 0;
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
            //    button4.Left += 20;
            //else
            //    btnMove.Left += 10;
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
                    btnMove.Left += 10;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            no = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            no = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            no = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            no = 4;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            btnTarget.Top -= 10;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            btnTarget.Left += 10;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnTarget.Left -= 10;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            btnTarget.Top += 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
