using System.Windows.Forms;

namespace PinBall
{
    class Ball : RadioButton, IMovable, IHitter
    {
        
        public Ball()
        {
            this.Checked = true;
            this.Height = 15;
            this.Width = 15;
        }

        int dx = 3, dy = 3;
        void IMovable.Move()
        {
            this.Left += dx;
            this.Top += dy;

            if (this.Left <= 0 || this.Right >= this.Parent.ClientRectangle.Right) dx = -dx;
            if (this.Top <= 0 || this.Bottom >= this.Parent.ClientRectangle.Bottom) dy = -dy;

            IHittable obj = HitOthers();
            if (obj != null)
            {
                dy = -dy;
            }

        }

        public IHittable HitOthers()
        {
            foreach(Control c in this.Parent.Controls)
            {
                if (c is IHittable && c != this)
                {
                    IHittable obj = (IHittable)c;
                    if (obj.HitBy(this))
                    {
                        return obj;
                    }
                }
            }
            return null;
        }
    }

}