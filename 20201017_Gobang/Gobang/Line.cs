namespace Gobang
{
    struct Line
    {
        public int Space { get; set; }
        public int Count { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public Line(int count, int space, int x1, int y1, int x2, int y2)
        {
            this.Count = count;
            this.Space = space;
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }
    }
}
