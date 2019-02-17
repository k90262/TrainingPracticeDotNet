using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinBall
{
    public class Bullet : Panel, IHitter, IMovable
    {
        private BulletStatus _Status = BulletStatus.Flying;
        public BulletStatus Status {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }
        public IHittable HitOthers()
        {
            if (!this.Visible) return null;

            foreach (Control c in this.Parent.Controls)
            {
                if (c is IHittable && c != this)
                {
                    IHittable obj = (IHittable)c;
                    if (obj.HitBy(this)) return obj;
                }
            }
            return null;
        }

        void IMovable.Move()
        {
            switch (this.Status)
            {
                case BulletStatus.Flying:
                    this.Top -= 4;

                    IHittable obj = HitOthers();
                    if (obj != null && obj is Brick)
                    {
                        Brick b = (Brick)obj;
                        b.Status = BrickStatus.Dead;
                        this.Status = BulletStatus.Dead;
                    }
                    if (obj != null && obj is Ball)
                    {
                        this.Status = BulletStatus.Dead;
                    //    Ball b = new Ball();
                    //    Ball ob = (Ball)obj;
                    //    b.Left = ob.Left;
                    //    b.Top = ob.Top;
                    //    b.dx = -b.dx;
                    //    this.Parent.Controls.Add(b);
                    }
                    break;
                case BulletStatus.Dead:
                    this.Visible = false;
                    break;
            }

        }
    }
}
