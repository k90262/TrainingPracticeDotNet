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
        Button obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (obj != null)
                obj.Left += 10;
            else
                MessageBox.Show("Please choose a button!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj = button3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = button2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj = button1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj = button4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            obj = button5;
        }
    }
}
