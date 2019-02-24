using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    class Triangle : Shape
    {
        public override void Draw(Control c)
        {
            Graphics g = c.CreateGraphics();
            int mx = (X1 + X2) / 2;
            g.DrawLine(Pens.Blue, mx, Y1, X1, Y2);
            g.DrawLine(Pens.Blue, mx, Y1, X2, Y2);
            g.DrawLine(Pens.Blue, X1, Y2, X2, Y2);
        }
    }
}
