using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinBall
{
    public class Ball : RadioButton, IMovable, IHitter, IHittable 
    {
        public int dx = 3;
        public int dy = -3;
        int[,] exploring = {
        { 1, 0, -2, -4 },
        { 2, 0, +2, -4 },
        { 0, 1, -4, -2 },
        { 3, 1, +4, -2 },
        { 0, 2, +4, +2 },
        { 3, 2, +4, +2 },
        { 1, 3, +2, +4 },
        { 2, 3, +2, +4 }
    };
        public bool HitBy(IHitter hitter)
        {
            if (!this.Visible || hitter is Ball ) return false;

            Control c = (Control)hitter;
            Rectangle r1 = new Rectangle(this.Left, this.Top, this.Width, this.Height);
            Rectangle r2 = new Rectangle(c.Left, c.Top, c.Width, c.Height);
            bool hit = r1.IntersectsWith(r2);

            if (hit && c is Bullet)
            {
                this.Visible = false; // 由於課中時間關係，自己去實作狀況

                for (int i = 0; i <= exploring.GetUpperBound(0); i++)
                {
                    Ball obj = new Ball();
                    obj.Width = this.Width;
                    obj.Height = this.Height;
                    obj.Checked = true;
                    obj.Left = this.Left - this.Width * 3 / 2 + exploring[i,0] * obj.Width;
                    obj.Top = this.Top - this.Height * 3 / 2 + exploring[i,1] * obj.Height;
                    obj.dx = exploring[i,2];
                    obj.dy = exploring[i,3];
                    this.Parent.Controls.Add(obj);
                }
            }
            return hit;
        }

        public IHittable HitOthers()
        {
            if (!this.Visible) return null;
             
            foreach (Control c in this.Parent.Controls) {
                if (c is IHittable && c != this) {
                    IHittable obj = (IHittable) c;
                    if (obj.HitBy(this)) return obj;
                }
            }
            return null;
        }

        void IMovable.Move()
        {
            if (!this.Visible) return;

            this.Left += dx;
            this.Top += dy;

            if (this.Left <= 0 || this.Right >= this.Parent.ClientRectangle.Right)
                dx = -dx;
            if (this.Top <= 0) {
                dy = -dy;
                if (this.Top <= 0) this.Top = 0;
                if (this.Bottom >= this.Parent.ClientRectangle.Bottom) this.Top =  this.Parent.ClientRectangle.Bottom - this.Height;
            }
            if (this.Bottom >= this.Parent.ClientRectangle.Bottom) this.Visible = false;

            IHittable obj = HitOthers();
            if (obj != null)
            {
                Control c = (Control)obj;
                /** 避免球卡在中間，因此重新計算球的位置 */
                if (dy < 0) // 球原先往上
                    this.Top = c.Bottom + 1;
                else
                    this.Top = c.Top - this.Height;
                dy = -dy;  
            }
        }
    }
}
