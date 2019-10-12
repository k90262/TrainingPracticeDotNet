using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    [Serializable]
    class Aim : Ellipse
    {
        public override void Draw(Form1 f)
        {
            base.Draw(f);

            Graphics g = f.CreateGraphics();
            int mx = (X1 + X2) / 2;
            int my = (Y1 + Y2) / 2;
            g.DrawLine(Pens.Red, mx, Y1, mx, Y2);
            g.DrawLine(Pens.Red, X1, my, X2, my);
        }

        public override Shape Clone()
        {
            return new Aim();
        }
    }
}
