using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Gobang
{
    class Computer : Player
    {
        long[] attack = {
            0,
            10,          // 1
            1000,        // 2
            100000,      // 3
            10000000,    // 4
            1000000000,   // 5
            1000000000,   // 5
            1000000000,   // 5
            1000000000,   // 5
            1000000000,   // 5
            1000000000,   // 5
            1000000000,   // 5
            1000000000,   // 5
            1000000000,   // 5
            1000000000,   // 5
            1000000000,   // 5
            1000000000   // 5
        };

        long[] defence = {
            0,
            1,           // 1
            100,         // 2
            10000,       // 3
            1000000,     // 4
            100000000,    // 5
            100000000,    // 5
            100000000,    // 5
            100000000,    // 5
            100000000,    // 5
            100000000,    // 5
            100000000,    // 5
            100000000,    // 5
            100000000,    // 5
            100000000,    // 5
            100000000    // 5
        };

        public Computer(Board board, Color color) : base(board, color)
        {

        }

        public override Point Think()
        {
            long weight = 0;
            List<Point> points = new List<Point>();

            for (int x = 0; x < Board.BoardSize; x++)
            {
                for (int y = 0; y < Board.BoardSize; y++)
                {
                    if (this.Board[x, y] == Color.Empty)
                    {
                        var attackLines = this.Board.CheckWin(x, y, this.Color);
                        var defenceLines = this.Board.CheckWin(x, y, this.NextPlayer.Color);

                        long w = 0;
                        foreach(var line in attackLines.Where(l => l.Count + l.Space >= 5)) w += attack[line.Count] + line.Space; // fixed the 1st point of computer who are the first player
                        foreach(var line in defenceLines.Where(l => l.Count + l.Space >= 5)) w += defence[line.Count] + line.Space;

                        if (w >= weight)
                        {
                            if (w > weight)
                            {
                                points.Clear();
                                weight = w;
                            }
                            points.Add(new Point(x, y));
                        }
                    }
                }
            }

            Random rnd = new Random();
        
            Point p = points[rnd.Next(points.Count)];

            this.Board[p.X, p.Y] = this.Color;

            return p;
        }
    }
}
