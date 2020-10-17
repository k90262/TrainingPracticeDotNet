using System.Drawing;
using System.Windows.Forms;

namespace PinBall
{
    class Bat : Button, IMovable, IHittable
    {
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