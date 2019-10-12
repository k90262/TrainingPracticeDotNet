using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    [Serializable]
    class CrossRectangle : Rectangle
    {
        public override void Draw(Form1 f)
        {
            base.Draw(f);

            Graphics g = f.CreateGraphics();
            g.DrawLine(Pens.Red, X1, Y1, X2, Y2);
            g.DrawLine(Pens.Red, X2, Y1, X1, Y2);
        }

        public override Shape Clone()
        {
            return new CrossRectangle();
        }
    }
}
