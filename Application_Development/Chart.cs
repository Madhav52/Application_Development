using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Application_Development
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            BindChart(listStudents);



        }
        private void BindChart(List<Student> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.Course)
                    .Select(cl => new
                    {
                        Course = cl.First().Course,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                chart1.DataSource = dt;
                Series series1 = new Series("Courses");
                series1.ChartType = SeriesChartType.StackedColumn;
                series1.BorderWidth = 5;
                series1.IsXValueIndexed = true;
                series1.IsValueShownAsLabel = true;
                series1.MarkerStyle = MarkerStyle.Circle;
                series1.MarkerColor = System.Drawing.Color.MidnightBlue;
                series1.Color = System.Drawing.Color.Blue;

                // chart1.ChartAreas["Titles"].AxisY.LabelAutoFitStyle = LabelAutoFitStyles.None;

                // chart1.ChartAreas[""].AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 2.25F, System.Drawing.FontStyle.Bold);
                // chart1.Series[1].Font = new Font(Font.Name, 20, FontStyle.Bold);
                chart1.Name = "Course";
                chart1.Font = new Font(Font.FontFamily, 15, FontStyle.Regular);
                chart1.Series["Courses"].XValueMember = "Course";
                chart1.Series["Courses"].Color = Color.Red;
                //chart1.Series["Courses"].Points[0].Color = Color.Green;
                chart1.Series["Courses"].YValueMembers = "Count";
                // this.chart1.Titles.Remove(this.chart1.Titles.FirstOrDefault());
                // this.chart1.Titles.Add("Student Enrollment Chart");
                chart1.Series["Courses"].IsValueShownAsLabel = true;
            }
        }
    }
}
