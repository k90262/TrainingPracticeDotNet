using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shape obj = new Rectangle();
            obj.X1 = 100;
            obj.Y1 = 100;
            obj.X2 = 400;
            obj.Y2 = 300;
            obj.Draw(this);
        }
    }
}
