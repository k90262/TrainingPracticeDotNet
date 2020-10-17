

using System.Drawing;
using System.Windows.Forms;

namespace PinBall
{

    enum BrickState
    {
        Normal,
        Falling,
        Floating,
        Dead
    }

    class Brick : Button, IMovable, IHittable, IHitter
    {
        public BrickState State { get; set; }

        public Brick()
        {
            this.State = BrickState.Normal;
        }

        void IMovable.Move()
        {
            switch (this.State)
            {
                case BrickState.Normal:

                    break;
                case BrickState.Falling:
                    this.Top += 3;
                    break;
                case BrickState.Floating:
                    this.Top -= 3;
                    if (this.Top <= 0) this.State = BrickState.Normal;
 
                    break;
                case BrickState.Dead:

                    break;
            }
        }

        public bool HitBy(IHitter hitter)
        {
            Rectangle r1 = new Rectangle(this.Location, this.Size);
            Control c = (Control)hitter;
            Rectangle r2 = new Rectangle(c.Location, c.Size);
            bool hit = r1.IntersectsWith(r2);

            // TODO: 實作磚塊被球打到的反應
            

            return hit;
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