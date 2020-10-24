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
        Board board = new Board();

        List<Line> finishedLines = new List<Line>();

    }
}
