
using System.Drawing;

namespace Gobang
{
    class Board
    {
        const int BoardSize = 15;
        Color[,] chess = new Color[BoardSize, BoardSize];

        public Player CurrentPlayer { get; set; }

    }
}
