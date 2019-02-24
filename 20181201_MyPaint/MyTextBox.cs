using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    class MyTextBox : TextBox, IDrawable
    {
        public MyTextBox()
        {
            this.Multiline = true;
        }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public IDrawable Draw(Control c)
        {
            this.Left = Math.Min(X1, X2);
            this.Top = Math.Min(Y1, Y2);
            this.Width = Math.Abs(X2 - X1) + 1;
            this.Height = Math.Abs(Y2 - Y1) + 1;
            c.Controls.Add(this);

            return new MyTextBox();
        }
    }
}
