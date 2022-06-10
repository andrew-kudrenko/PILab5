namespace PILab5
{
    internal class BarChartBuilder
    {
        public int Width { get; set; } = 35;
        public int BorderWidth { get; set; } = 2;
        public Color Color { get; set; } = Color.Red;
        public Color BorderColor { get; set; } = Color.Black;

        private Graphics _graphics;

        public void DrawBar(Point coords, int height)
        {
            Rectangle rect = new(coords.X, coords.Y, Width, height);
            Pen pen = new(new SolidBrush(BorderColor), BorderWidth); 
            _graphics.DrawRectangle(pen, rect);

            Brush brush = new SolidBrush(Color);
            _graphics.FillRectangle(brush, rect);
        }

        public void SetGraphics(Graphics graphics)
        {
            _graphics = graphics;
        }
    }
}
