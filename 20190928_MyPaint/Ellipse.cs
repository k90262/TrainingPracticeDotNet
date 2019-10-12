using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    [Serializable]
    class Ellipse : Shape
    {

        public int X
        {
            get
            {
                return Math.Min(X1, X2);
            }
        }

        public int Y
        {
            get
            {
                return Math.Min(Y1, Y2);
            }
        }

        public int Width
        {
            get
            {
                return Math.Abs(X1 - X2) + 1;
            }
        }

        public int Height
        {
            get
            {
                return Math.Abs(Y1 - Y2) + 1;
            }
        }

        public override void Draw(Form1 f)
        {
            Graphics g = f.CreateGraphics();
            int x = X1 < X2 ? X1 : X2;
            int y = Math.Min(Y1, Y2);
            int w = Math.Abs(X1 - X2) + 1;
            int h = Math.Abs(Y1 - Y2) + 1;
            g.DrawEllipse(Pens.Red, X, Y, Width, Height);
        }

        public override Shape Clone()
        {
            return new Ellipse();
        }
    }
}
