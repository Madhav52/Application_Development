namespace Application_Development
{
    partial class Chart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 5;
            chartArea1.Area3DStyle.Inclination = 10;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 10;
            chartArea1.Area3DStyle.PointGapDepth = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 5;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Blue;
            chartArea1.BackColor = System.Drawing.Color.Red;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            chartArea1.BackImage = "C:\\Users\\BIPIN\\source\\repos\\Application_Development\\Application_Development\\textu" +
    "re5.jpg";
            chartArea1.BackSecondaryColor = System.Drawing.Color.Yellow;
            chartArea1.BorderColor = System.Drawing.Color.Red;
            chartArea1.BorderWidth = 5;
            chartArea1.CursorY.LineColor = System.Drawing.Color.Lime;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.ShadowOffset = 4;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(26, 27);
            this.chart1.Name = "chart1";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBorderWidth = 2;
            series1.LabelForeColor = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.MarkerSize = 8;
            series1.Name = "Courses";
            series1.ShadowColor = System.Drawing.Color.Gray;
            series1.ShadowOffset = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(571, 347);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart";
            title1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            title1.BorderWidth = 2;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Madhav";
            title1.ShadowColor = System.Drawing.Color.Silver;
            title1.Text = "Student\'s Courses Enrollment Chart";
            this.chart1.Titles.Add(title1);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 399);
            this.Controls.Add(this.chart1);
            this.Name = "Chart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}