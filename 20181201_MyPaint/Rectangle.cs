using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public class Rectangle : Shape
    {
        public override void Draw(Control c)
        {
            Graphics g = c.CreateGraphics();
            g.DrawRectangle(Pens.Red, X, Y, Width, Height) ;
        }
    }
}
