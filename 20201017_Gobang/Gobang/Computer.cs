using System;
using System.Drawing;

namespace Gobang
{
    class Computer : Player
    {
        public Computer(Board board, Color color) : base(board, color)
        {
            
        }
        public override void Think()
        {
            Random rnd = new Random();
            int x, y;
            do {
                x = rnd.Next(Board.BoardSize);
                y = rnd.Next(Board.BoardSize);
            } while (this.Board[x, y] != Color.Empty);

            this.Board[x, y] = this.Color;
            this.Board.CurrentPlayer = this.NextPlayer;
        }
    }
}
