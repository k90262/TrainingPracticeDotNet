using System.Drawing;

namespace Gobang
{
    abstract class Player
    {
        public Color Color { get; set; }
        public Player NextPlayer { get; set; }
        public Board Board { get; set; }
        public abstract void Think();

    }
}
