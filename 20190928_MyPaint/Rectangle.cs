using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    [Serializable]
    class Rectangle : Shape
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
            g.DrawRectangle(Pens.Red, X, Y, Width, Height);
        }

        public override Shape Clone()
        {
            return new Rectangle();
        }
    }
}
