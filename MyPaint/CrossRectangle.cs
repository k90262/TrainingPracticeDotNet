using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public class CrossRectangle : Rectangle
    {
        public override void Draw(Control c)
        {
            base.Draw(c);
            Graphics g = c.CreateGraphics();
            g.DrawLine(Pens.Red, X1, Y1, X2, Y2);
            g.DrawLine(Pens.Red, X1, Y2, X2, Y1);
        }
    }
}
