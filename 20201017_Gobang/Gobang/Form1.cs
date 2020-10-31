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

using Hello;

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

            Player p1 = new Human(board, Color.Black);
            Player p2 = new Computer(board, Color.White);
            p1.NextPlayer = p2;
            p2.NextPlayer = p1;
            board.CurrentPlayer = p1;




        }

        void Test()
        {
            int[] data = { 10, 54, 12, 31, 57, 89, 25, 76 };

            List<int> result1 = Filter(data, CheckValue3);

            List<int> result2 = Filter(data, delegate(int no)
            {
                return no >= 10 && no <= 50;
            });

            List<int> result3 = Filter(data, (no) =>
            {
                return no >= 10 && no <= 50;
            });

            List<int> result4 = Filter(data, (no) => no >= 10 && no <= 50);

            List<int> result5 = Filter(data, no => no >= 10 && no <= 50);

            List<int> result6 = data.Filter(no => no >= 10 && no <= 50);

        }

        bool CheckValue1(int no)
        {
            return no % 2 == 1;
        }

        bool CheckValue2(int no)
        {
            return no % 2 == 0;
        }

        bool CheckValue3(int no)
        {
            return no >= 10 && no <= 50;
        }

        List<int> Filter(int[] data, Func<int, bool> f)
        {
            List<int> result = new List<int>();
            foreach(int no in data)
            {
                if (f.Invoke(no))
                {
                    result.Add(no);
                }
            }

            return result;
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
            if (Board.IsValid(x, y))
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
            if (board.CurrentPlayer is Human && CanPut(e.X, e.Y, out x, out y))
            {
                board[x, y] = board.CurrentPlayer.Color;
                this.Invalidate(); // send paint event

                finishedLines = board.CheckWin(x, y, board[x, y]);

                if (finishedLines.Where(line => line.Count >= 5).Count() > 0)
                {
                    this.Invalidate();
                    MessageBox.Show($"Player {board.CurrentPlayer.Color} win !");
                    //Application.Exit();
                }

                board.CurrentPlayer = board.CurrentPlayer.NextPlayer;
                board.CurrentPlayer.Think();
            }
        }

    }
}
