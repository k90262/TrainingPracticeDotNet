
using System.Drawing;

namespace Gobang
{
    class Board
    {
        const int BoardSize = 15;
        Color[,] chess = new Color[BoardSize, BoardSize];

        public Color this[int x, int y]
        {
            get 
            {
                return chess[x, y];
            }
            set
            {
                chess[x, y] = value;
            }
        }

        public Player CurrentPlayer { get; set; }

    }
}
