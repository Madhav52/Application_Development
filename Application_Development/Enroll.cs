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
    public partial class Enroll : Form
    {
        public Enroll()
        {
            InitializeComponent();
        }

        private void Enroll_Load(object sender, EventArgs e)
        {
            //new object of Student
            Student obj = new Student();

            //get input value of registered date
            DateTime registeredDate = dateReport.Value;

            //invoke the List method of Student class which return a List of Student
            List<Student> listStudents = obj.List();

            // invoke the FindWeek method which returns array containing week start and end date
            DateTime[] dateArray = obj.FindWeek(registeredDate);

            // invoke WeekStudent method which returns a list of student of a week
            List<Student> weeklyStudents = obj.WeeklyStudent(dateArray, listStudents);


            // group the list by course and create two columns i.e. course and count
            var result = weeklyStudents
                    .GroupBy(l => l.Course)
                    .Select(cl => new
                    {
                        Course = cl.First().Course,
                        Count = cl.Count().ToString()
                    }).ToList();

            // dataGridReport.Visible = true;
            // panelReport.Visible = true;
            // dataGridStudent.Hide();

            //convert the result to datatable and show in a datagrid view
            DataTable dt = Utility.ConvertToDataTable(result);
            dataGridReport.DataSource = dt;
            dataGridReport.CurrentCell = null;

        }
    }
}
