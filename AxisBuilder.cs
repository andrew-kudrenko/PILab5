namespace PILab5
{
    internal class AxisBuilder
    {
        private Graphics _Graphics;

        public Point Coords { get; set; }
        public Point Size { get; set; }
        public Color Color { get; set; } = Color.DarkGray;
        public int LineWidth { get; set; } = 2;

        public AxisBuilder(Point coords, Point size)
        {
            Coords = coords;
            Size = size;
        }

        public void DrawBoth()
        {
            DrawX();
            DrawY();
        }

        public void DrawY()
        {
            Point to = new(Coords.X, Coords.Y - Size.Y);
           _Graphics.DrawLine(new Pen(Color, LineWidth), Coords, to);
        }

        public void DrawX()
        {
            Point to = new(Coords.X + Size.X, Coords.Y);
            _Graphics.DrawLine(new Pen(Color, LineWidth), Coords, to);
        }

        public void SetGraphics(Graphics graphics)
        {
            _Graphics = graphics;
        }
    }
}
