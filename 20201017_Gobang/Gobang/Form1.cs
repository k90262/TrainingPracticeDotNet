using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gobang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string filename = Path.GetDirectoryName(Application.ExecutablePath) + @"\ChessBoard.jpg";
            Image img = new Bitmap(filename);
            this.BackgroundImage = img;
            this.ClientSize = new Size(img.Width, img.Height);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.CenterToScreen();

            this.MouseMove += Form_MouseMove;
            this.MouseDown += Form_MouseDown;
            this.Paint += Form_Paint;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }


        void Form_MouseMove(object sender, MouseEventArgs e)
        {
            // this.Text = "X=" + e.X.ToString() + ", Y=" + e.Y.ToString() + ", Button=" + e.Button.ToString();
            // this.Text = string.Format("X={0}, Y={1}, Button={2}", e.X, e.Y, e.Button);
            // this.Text = $"X={e.X}, Y={e.Y}, Button={e.Button}";

            int x, y;
            if (CanPut(e.X, e.Y, out x, out y))
            {
                // this.Text = $"X={e.X}, Y={e.Y}, Button={e.Button}, x={x}, y={y}";
                this.Cursor = Cursors.Hand;
            }
            else
                this.Cursor = Cursors.No;

        }

        private bool CanPut(int mx, int my, out int x, out int y)
        {
            x = (mx - OriginX) / CellSize;
            y = (my - OriginY) / CellSize;
            if (x >= 0 && x < BoardSize && y >= 0 && y < BoardSize)
            {
                int ax = (mx - OriginX) % CellSize;
                int ay = (my - OriginY) % CellSize;
                return ax > CellPadding && ax < CellSize - CellPadding && ay > CellPadding && ay < CellSize - CellPadding && board[x, y] == Color.Empty;
            }
            else
                return false;
        }

        void Form_MouseDown(object sender, MouseEventArgs e)
        {
            int x, y;
            if (CanPut(e.X, e.Y, out x, out y))
            {
                board[x, y] = players[currentPlayer];
                this.Invalidate();

                finishedLines = CheckWin(x, y);
                if (finishedLines.Count > 0)
                {
                    this.Invalidate();
                    MessageBox.Show($"Player {players[currentPlayer]} win !");
                    //Application.Exit();
                }

                currentPlayer++;
                if (currentPlayer >= players.Length) currentPlayer = 0;

            }
        }

        private List<Line> CheckWin(int cx, int cy)
        {
            List<Line> finishedLines = new List<Line>();

            for (int lineNo = 0; lineNo < lines.GetLength(0); lineNo++)
            {
                int count = 1;
                List<Point> points = new List<Point>();
                for (int direction = 0; direction < lines.GetLength(1); direction++)
                {
                    int dx = lines[lineNo, direction, 0];
                    int dy = lines[lineNo, direction, 1];
                    int x = cx + dx;
                    int y = cy + dy;

                    while (IsValid(x, y) && board[x, y] == board[cx, cy])
                    {
                        count++;
                        x += dx;
                        y += dy;
                    }

                    points.Add(new Point(x - dx, y - dy));
                }

                if (count >= 5)
                {
                    finishedLines.Add(new Line(points[0].X, points[0].Y, points[1].X, points[1].Y));
                }

            }


            return finishedLines;
        }

        private bool IsValid(int x, int y)
        {
            return x >= 0 && x < BoardSize && y >= 0 && y < BoardSize;
        }
    }
}
