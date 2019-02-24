using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinBall
{
    public class Bat : Button, IMovable, IHittable
    {
        private int originalX, originalY;
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (mevent.Button == MouseButtons.Left)
            {
                originalX = mevent.X;
                originalY = mevent.Y;
            }

            if (mevent.Button == MouseButtons.Right)
            {
                Bullet obj = new Bullet();
                obj.Width = 4;
                obj.Height = 10;
                obj.BackColor = Color.Red;
                obj.Left = this.Left + (this.Width - obj.Width)/2;
                obj.Top = this.Top - obj.Height;
                this.Parent.Controls.Add(obj);
            }
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            if (mevent.Button == MouseButtons.Left) {
                int dx = mevent.X - originalX;
                int dy = mevent.Y - originalY;
                this.Left += dx;
                this.Top += dy;
            }
        }

        public bool HitBy(IHitter hitter)
        {
            Control c = (Control)hitter;
            Rectangle r1 = new Rectangle(this.Left, this.Top, this.Width, this.Height);
            Rectangle r2 = new Rectangle(c.Left, c.Top, c.Width, c.Height);
            bool hit = r1.IntersectsWith(r2);

            return hit;
        }

        void IMovable.Move()
        {

        }
    }
}
