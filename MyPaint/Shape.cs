using System;
using System.Windows.Forms;

namespace MyPaint
{
    public abstract class Shape : IDrawable
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

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
                return Math.Abs(X2 - X1) + 1;
            }
        }

        public int Height
        {
            get
            {
                return Math.Abs(Y2 - Y1) + 1;
            }
        }

        public abstract void Draw(Control c);
    }
}
