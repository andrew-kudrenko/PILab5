namespace PILab5
{
    public partial class ChartForm : Form
    {
        private BarChartBuilder _ChartBuilder = new();
        private AxisBuilder _AxisBuilder = new(new Point(375, 435), new Point(400, 400));
        private Graphics _Graphics;
        public ChartForm()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ChartForm_Paint(object sender, PaintEventArgs e)
        {
            using (_Graphics = e.Graphics)
            { 
                _AxisBuilder.SetGraphics(_Graphics);
                _AxisBuilder.DrawBoth();

                _ChartBuilder.SetGraphics(_Graphics);

                DrawChart();
            }
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            const int ROWS = 5;
            const int COLS = 3;

            UserDataGrid.Rows.Clear();
            Random random = new();

            for (int y = 0; y < ROWS; y++)
            {
                DataGridViewRow row = new();

                for (int x = 0; x < COLS; x++)
                {
                    DataGridViewTextBoxCell cell = new() { Value = random.Next(10, 100) };
                    row.Cells.Add(cell);
                }

                UserDataGrid.Rows.Add(row);
            }
        }
        private void OnCompute(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void DrawChart()
        {
            const int startsFromX = 400;
            const int startsFromY = 435;
            const int gap = 75;
            var gridRows = UserDataGrid.Rows;

            List<List<int>> rows = new();

            for (int y = 0; y < gridRows.Count; y++)
            {
                rows.Add(new List<int>());

                for (int x = 0; x < gridRows[y].Cells.Count; x++)
                {
                    string rawValue = gridRows[y].Cells[x].Value?.ToString() ?? "";
                    rows[y].Add(rawValue.Trim().Length > 0 ? int.Parse(rawValue) : 0);
                }
            }

            List<Color> colors = new() { Color.Cyan, Color.Red, Color.GreenYellow };

            for (int i = 0; i < rows.Count; i++)
            {
                List<int> values = rows[i];

                for (int j = 0; j < values.Count; j++)
                {
                    int x = startsFromX + gap * i;
                    int y = startsFromY - values.Sum();
                    int prevSum = values.Take(j).Sum();
                    _ChartBuilder.Color = colors[j];
                    _ChartBuilder.DrawBar(new Point(x, y + prevSum), values[j]);
                }
            }
        }
    }
}