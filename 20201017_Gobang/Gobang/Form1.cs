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
        public Form1()
        {
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
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X = {e.X}, Y = {e.Y}, Button={e.Button}";

            int x, y;
            if (CanPut(e.X, e.Y, out x, out y))
            {
                this.Text = $"X = {e.X}, Y = {e.Y}, Button={e.Button}, x={x}, y={y}";
            }
        }

        private bool CanPut(int mx, int my, out int x, out int y)
        {
            x = 5;
            y = 10;
            return true;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = e.Button.ToString();
        }

    }
}
