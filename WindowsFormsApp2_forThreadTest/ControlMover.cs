using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_forThreadTest
{
    class ControlMover
    {
        Control control;
        Thread thread; 
        public ControlMover(Control c)
        {
            this.control = c;
            this.thread = new Thread(Move);
        }

        void Move()
        {
            while (control.Right < control.Parent.ClientRectangle.Right)
            {
                Action act = UpdateUI;
                control.Invoke(act);
                for(int i=0;i<10000;i++);
            }
        }
        void UpdateUI()
        {
            control.Left++;
        }

        public void Start()
        {
            thread.Start();
        }
    }
}
