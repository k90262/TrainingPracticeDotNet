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

        private void radioButton1_Click(object sender, EventArgs e)
        {
            obj = new Line();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            obj = new Rectangle();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            obj = new Ellipse();
        }

        IDrawable obj;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            obj.X1 = e.X;
            obj.Y1 = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            obj.X2 = e.X;
            obj.Y2 = e.Y;
            obj.Draw(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            obj = new Triangle();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            obj = new CrossRectangle();
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            obj = new MyButton();
        }
    }
}
