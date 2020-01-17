using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                chart1.Name = "Course";
                chart1.Series["Series1"].XValueMember = "Course";
                chart1.Series["Series1"].YValueMembers = "Count";
                this.chart1.Titles.Remove(this.chart1.Titles.FirstOrDefault());
                this.chart1.Titles.Add("Student Enrollment Chart");
                chart1.Series["Series1"].IsValueShownAsLabel = true;
            }
        }
    }
}
