using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinBall
{
    public interface IHittable
    {
        bool HitBy(IHitter hitter);
    }
}
