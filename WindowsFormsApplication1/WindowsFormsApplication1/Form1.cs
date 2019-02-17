using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Control obj;

        private void button_Click(object sender, EventArgs e)
        {
            obj = sender as Button;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (obj != null)
                obj.Left += 10;
            else
                btnMove.Left += 10;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            obj = textBox1;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            obj = this;
        }
    }
}
