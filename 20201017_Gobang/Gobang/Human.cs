using System.Drawing;

namespace Gobang
{
    class Human : Player
    {
        public Human(Board board, Color color) : base(board, color)
        {

        }

        public override Point Think()
        {
            return new Point(0, 0);
        }
    }
}
