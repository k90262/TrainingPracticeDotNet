using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        }

        Shape obj;
        List<Shape> shapes = new List<Shape>();

        private void radLine_Click(object sender, EventArgs e)
        {
            obj = new Line();
        }

        private void radEllipse_Click(object sender, EventArgs e)
        {
            obj = new Ellipse();
        }

        private void radRectangle_Click(object sender, EventArgs e)
        {
            obj = new Rectangle();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            obj.X1 = e.X;
            obj.Y1 = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            obj.X2 = e.X;
            obj.Y2 = e.Y;
            shapes.Add(obj);
            this.Invalidate();
            obj = obj.Clone();
        }

        private void radCrossRectangle_Click(object sender, EventArgs e)
        {
            obj = new CrossRectangle();
        }

        private void radAim_Click(object sender, EventArgs e)
        {
            obj = new Aim();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Shape s in shapes)
            {
                s.Draw(this);
            }
        }

        const string savedFile = @"C:\Demos\shapes.data";

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch(e.KeyCode)
                {
                    case Keys.Z:
                        if (shapes.Count > 0)
                        {
                            shapes.RemoveAt(shapes.Count - 1);
                            this.Invalidate();
                        }
                        break;
                    case Keys.S:
                        BinaryFormatter serializer = new BinaryFormatter();
                        FileStream fs = new FileStream(savedFile, FileMode.Create);
                        serializer.Serialize(fs, shapes);
                        fs.Close();

                        MessageBox.Show("SAVED");
                        break;
                    case Keys.L:
                        BinaryFormatter deserializer = new BinaryFormatter();
                        FileStream fsRead = new FileStream(savedFile, FileMode.Open);
                        shapes = (List<Shape>)deserializer.Deserialize(fsRead);
                        fsRead.Close();
                        this.Invalidate();

                        MessageBox.Show("LOADED");
                        break;
                }

            }

        }
    }
}
