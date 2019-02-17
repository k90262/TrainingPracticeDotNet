using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_forThreadTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void MoveButton1()
        {
            while (button1.Right < button1.Parent.ClientRectangle.Right)
            {
                Action act = UpdateButton1;
                button1.Invoke(act);
                Thread.Sleep(1);
            }     
        }
        void MoveButton2()
        {
            while (button2.Right < button2.Parent.ClientRectangle.Right)
            {
                Action act = UpdateButton2;
                button2.Invoke(act);
                Thread.Sleep(1);
            }
        }
        void MoveButton3()
        {
            while (button3.Right < button3.Parent.ClientRectangle.Right)
            {
                Action act = UpdateButton3;
                button3.Invoke(act);
                Thread.Sleep(1);
            }
        }
        void UpdateButton1()
        {
            button1.Left++;
        }
        void UpdateButton2()
        {
            button2.Left++;
        }
        void UpdateButton3()
        {
            button3.Left++;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            //MoveButton1();
            //Thread t1 = new Thread(MoveButton1);
            //Thread t2 = new Thread(MoveButton2);
            //Thread t3 = new Thread(MoveButton3);
            //t1.Start();
            //t2.Start();
            //t3.Start();
            //MoveButton2();

            ControlMover cm1 = new ControlMover(button1);
            cm1.Start();
            ControlMover cm2 = new ControlMover(button2);
            cm2.Start();
            ControlMover cm3 = new ControlMover(button3);
            cm3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
