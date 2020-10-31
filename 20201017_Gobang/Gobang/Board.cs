
using System.Collections.Generic;
using System.Drawing;

namespace Gobang
{
    class Board
    {
        public const int BoardSize = 15;
        public int Count = BoardSize * BoardSize; 
        Color[,] chess = new Color[BoardSize, BoardSize];

        public Player CurrentPlayer { get; set; }

        // 棋子四條連線的各兩個方向座標差值
        int[,,] lines = {
            // 左右
            {
                { -1, 0 },  // 左
                { +1, 0 }   // 右
            },
            // 上下
            {
                { 0, -1 },  // 上
                { 0, +1 }   // 下
            },
            // 左上右下
            {
                { -1, -1 }, // 左上
                { +1, +1 }  // 右下
            },
            // 右上左下
            {
                { +1, -1 }, // 右上
                { -1, +1 }  // 左下
            }
        };

        public Color this[int x, int y]
        {
            get
            {
                return chess[x, y];
            }
            set
            {
                chess[x, y] = value;
                Count--;
            }
        }

        public List<Line> CheckWin(int cx, int cy, Color color)
        {
            List<Line> finishedLines = new List<Line>();

            for (int lineNo = 0; lineNo < lines.GetLength(0); lineNo++)
            {
                int count = 1;
                int space = 0;
                List<Point> points = new List<Point>();
                for (int direction = 0; direction < lines.GetLength(1); direction++)
                {
                    int dx = lines[lineNo, direction, 0];
                    int dy = lines[lineNo, direction, 1];
                    int x = cx + dx;
                    int y = cy + dy;

                    while (IsValid(x, y) && this[x, y] == color)
                    {
                        count++;
                        x += dx;
                        y += dy;
                    }

                    points.Add(new Point(x - dx, y - dy));

                    while (IsValid(x, y) && this[x, y] == Color.Empty)
                    {
                        space++;
                        x += dx;
                        y += dy;
                    }
                }

                finishedLines.Add(new Line(count, space, points[0].X, points[0].Y, points[1].X, points[1].Y));

            }

            return finishedLines;
        }

        public static bool IsValid(int x, int y)
        {
            return x >= 0 && x < Board.BoardSize && y >= 0 && y < Board.BoardSize;
        }


    }
}
