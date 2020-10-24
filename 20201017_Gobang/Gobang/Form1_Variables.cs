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
        const int CellPadding = 4;
        const int BoardSize = 15;
        Color[,] chess = new Color[BoardSize, BoardSize];

        List<Line> finishedLines = new List<Line>();


        Color[] players = { Color.Black, Color.White };
        int currentPlayer = 0;

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


    }
}
