using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class Line : Shape
    {

        public override void Draw(Form1 f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawLine(Pens.Red, X1, Y1, X2, Y2);
        }

    }
}
