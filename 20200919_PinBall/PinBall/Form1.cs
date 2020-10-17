using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinBall
{
    public partial class Form1 : Form
    {

        // constructor
        public Form1()
        {
            InitializeComponent();

            Timer t1 = new Timer();
            t1.Interval = 10;
            t1.Enabled = true;
            t1.Tick += timer_Tick;

            for(int y = 0; y < 3; y++)
            {
                for(int x = 0; x < 6; x++)
                {
                    Brick b = new Brick();
                    b.Left = b.Width * x;
                    b.Top = b.Height * y;

                    this.Controls.Add(b);
                }
            }

            Ball ball = new Ball();
            ball.Left = 200;
            ball.Top = 450;
            this.Controls.Add(ball);

            Bat bat = new Bat();
            bat.Left = 150;
            bat.Top = 500;
            bat.Width = 150;
            bat.Height = 20;
            this.Controls.Add(bat);


            Label lbl = new Label();
            lbl.Text = "Hello world";
            lbl.Left = 100;
            lbl.Top = 300;
            this.Controls.Add(lbl);


            ball.BringToFront();


            Brick test = new Brick();
            test.Left = 200;
            test.Top = 300;
            test.State = BrickState.Floating;
            this.Controls.Add(test);
            test.BringToFront();

        }


        private void timer_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();

            foreach(Control c in this.Controls)
            {
                if (c is IMovable)
                {
                    IMovable obj = (IMovable)c;
                    obj.Move();
                }
            }

        }
    }
}
