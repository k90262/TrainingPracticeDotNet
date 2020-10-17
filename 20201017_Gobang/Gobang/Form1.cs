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
        const int OriginX = 4;
        const int OriginY = 4;
        const int CellSize = 35;
        const int CellPending = 3;
        const int BoardSize = 15;
        Color[,] chess = new Color[BoardSize, BoardSize];
        public Form1()
        {
            //MessageBox.Show($"{chess[5,7]==Color.Empty}");

            InitializeComponent();

            //this.Text = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = Path.GetDirectoryName(Application.ExecutablePath) + @"\ChessBoard.jpg";

            Image img = new Bitmap(filename);
            this.BackgroundImage = img;
            this.ClientSize = new Size(img.Width, img.Height);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.CenterToScreen();

            this.MouseMove += Form_MouseMove;
            this.MouseDown += Form_MouseDown;
            //PaintEventHandler
            this.Paint += Form_Paint;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X = {e.X}, Y = {e.Y}, Button={e.Button}";

            int x, y;
            if (CanPut(e.X, e.Y, out x, out y))
            {
                this.Text = $"X = {e.X}, Y = {e.Y}, Button={e.Button}, x={x}, y={y}";
                this.Cursor = Cursors.Hand;
            }
            else 
                this.Cursor = Cursors.No;

        }

        private bool CanPut(int mx, int my, out int x, out int y)
        {
            x = (mx - OriginX) / CellSize;
            y = (my - OriginY) / CellSize;

            if (x >= 0 && x < BoardSize &&
                y >= 0 && y < BoardSize)
            {
                int ax = (mx - OriginX) % CellSize;
                int ay = (my - OriginY) % CellSize;
                return ax > CellPending && ax < CellSize - CellPending && ay > CellPending && ay < CellSize - CellPending && chess[x, y] == Color.Empty;
            }
            else 
                return false;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = e.Button.ToString();

            int x, y;
            if (CanPut(e.X, e.Y, out x, out y))
            {
                chess[x, y] = Color.White;
                //MessageBox.Show("OK");
            }
        }

        private void Form_Paint(object sender, PaintEventArgs e) 
        {
            //e.Graphics.DrawLine(Pens.Blue, 100, 100, 200, 300);
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    Brush b = new SolidBrush(chess[x, y]);
                    int cx = OriginX + CellPending + x * CellSize;
                    int cy = OriginY + CellPending + y * CellSize;
                    int size = CellSize - CellPending * 2;
                    e.Graphics.FillEllipse(b, cx, cy, size, size);
                }
            }
        }

    }
}
