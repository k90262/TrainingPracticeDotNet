using System;
using System.Drawing;
using System.Windows.Forms;

namespace PinBall
{
    class Bat : Button, IMovable, IHittable
    {
        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);

            if (mevent.Button == MouseButtons.Left)
            {
                int dx = mevent.X - this.Width/2;
                int dy = mevent.Y - this.Height/2;
                this.Left += dx;
                this.Top += dy;
            }
        }
        public bool HitBy(IHitter hitter)
        {
            Rectangle r1 = new Rectangle(this.Location, this.Size);
            Control c = (Control)hitter;
            Rectangle r2 = new Rectangle(c.Location, c.Size);
            bool hit = r1.IntersectsWith(r2);

            return hit;
        }

        void IMovable.Move()
        {
            
        }
    }

}