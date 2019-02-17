using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public class Line : Shape
    {
        override public void Draw(Control c)
        {
            Graphics g = c.CreateGraphics();
            g.DrawLine(Pens.Red, X1, Y1, X2, Y2);
        }
    }
}

