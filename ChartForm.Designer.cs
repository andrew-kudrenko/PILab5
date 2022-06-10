namespace PILab5
{
    partial class ChartForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.UserDataGrid = new System.Windows.Forms.DataGridView();
            this.Category1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataGrid
            // 
            this.UserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category1,
            this.Category2,
            this.Column3});
            this.UserDataGrid.Location = new System.Drawing.Point(12, 36);
            this.UserDataGrid.Name = "UserDataGrid";
            this.UserDataGrid.RowTemplate.Height = 25;
            this.UserDataGrid.Size = new System.Drawing.Size(345, 402);
            this.UserDataGrid.TabIndex = 0;
            this.UserDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGrid_CellContentClick);
            // 
            // Category1
            // 
            this.Category1.HeaderText = "Category";
            this.Category1.Name = "Category1";
            // 
            // Category2
            // 
            this.Category2.HeaderText = "Column2";
            this.Category2.Name = "Category2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Below id random-generated data for histogram";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserDataGrid);
            this.Name = "ChartForm";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChartForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridView UserDataGrid;

        private Label label1;

        private void DrawBarSegment()
        {
            
        }

        private DataGridViewTextBoxColumn Category1;
        private DataGridViewTextBoxColumn Category2;
        private DataGridViewTextBoxColumn Column3;
    }
}