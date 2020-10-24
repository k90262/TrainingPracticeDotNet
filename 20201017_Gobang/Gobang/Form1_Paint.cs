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
        void Form_Paint(object sender, PaintEventArgs e)
        {
            for(int x = 0; x < BoardSize; x++)
            {
                for(int y = 0; y < BoardSize; y++)
                {
                    if (chess[x, y] != Color.Empty)
                    {
                        Brush b = new SolidBrush(chess[x, y]);
                        int cx = OriginX + CellPadding + x * CellSize;
                        int cy = OriginY + CellPadding + y * CellSize;
                        int size = CellSize - CellPadding * 2;
                        e.Graphics.FillEllipse(b, cx, cy, size, size);
                    }
                }
            }

            foreach(Line line in finishedLines)
            {
                int x1 = OriginX + CellSize / 2 + line.X1 * CellSize;   
                int y1 = OriginY + CellSize / 2 + line.Y1 * CellSize;   
                int x2 = OriginX + CellSize / 2 + line.X2 * CellSize;   
                int y2 = OriginY + CellSize / 2 + line.Y2 * CellSize;   
                Pen p = new Pen(Color.Yellow, 10);
                e.Graphics.DrawLine(p, x1, y1, x2, y2);
            }

        }
    }
}
