using System.Drawing;

namespace Gobang
{
    class Human : Player
    {
        public Human(Board board, Color color) : base(board, color)
        {

        }

        Point p = Point.Empty;
        
        public void SetPoint(int x, int y)
        {
            p = new Point(x, y);
        }

        public override Point Think()
        {
            Point current = p;
            p = Point.Empty;
            return current;
        }
    }
}
