using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    //public class MyButton : Shape
    public class MyButton : Button, IDrawable
    {
        //public override void Draw(Control c)
        //{
        //Button b = new Button();
        //b.Left = X1;
        //b.Top = Y1;
        //b.Width = Width;
        //b.Height = Height; 
        //}
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public void Draw(Control c)
        {
            this.Left = Math.Min(X1, X2);
            this.Top = Math.Min(Y1, Y2);
            this.Width = Math.Abs(X2 - X1)+1;
            this.Height = Math.Abs(Y2 - Y1)+1;
            c.Controls.Add(this);
        }
    }
}
