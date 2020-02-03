using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            BindGrid();
            btnUpdate.Visible = false;
            dataGridReport.Visible= false;
            panelReport.Visible = false;
            
        }

        private void cbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter your first name!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txtLastName.Text == "" || txtLastName.Text == null)
            {
                MessageBox.Show("Please enter your last name!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAddress.Text == "" || txtAddress.Text == null)
            {
                MessageBox.Show("Please enter your address!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtContactNo.Text == "" || txtContactNo.Text == null)
            {
                MessageBox.Show("Please enter your valid Phone Number!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gender.SelectedItem == null)
            {
                MessageBox.Show("Please select your Gender!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEmail.Text == "" || txtEmail.Text == null)
            {
                MessageBox.Show("Please enter your valid Email!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (enrolProgram.SelectedItem == null)
            {
                MessageBox.Show("Please select your enrolled program!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rBtnPending.Checked == false && rBtnPublished.Checked == false)
            {
                MessageBox.Show("Please select status!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Regex.IsMatch(txtContactNo.Text,"^[0-9]{10}"))
                {
                    Student obj = new Student();
                    obj.FirstName = txtFirstName.Text;
                    obj.LastName = txtLastName.Text;
                    obj.Name = txtFirstName.Text + " " + txtLastName.Text;
                    obj.Address = txtAddress.Text;
                    obj.Email = txtEmail.Text;
                    obj.BirthDate = dob.Value;
                    obj.ContactNo = txtContactNo.Text;
                    obj.Gender = gender.SelectedItem.ToString();
                    obj.RegistrationDate = regDate.Value;
                    obj.Course = enrolProgram.SelectedItem.ToString();
                    if (rBtnPending.Checked == true)
                    {
                        obj.Status = rBtnPending.Text;
                    }

                    else if (rBtnPublished.Checked == true)
                    {
                        obj.Status = rBtnPublished.Text;
                    }

                    obj.Add(obj);
                    MessageBox.Show("Data is Sucessfully saved", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Invalid Number Occurred! Please enter valid phone number", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            dataGridStudent.DataSource = dt;
            
        }
        private void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            dob.Value = DateTime.Today;
            txtContactNo.Text = "";
            gender.SelectedItem = null;
            regDate.Value = DateTime.Today;
            enrolProgram.SelectedItem = null;
            if (rBtnPending.Checked)
            {
                rBtnPending.Checked = false;
            }
            else
            {
                rBtnPublished.Checked = false;
            }
            
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbSorting.SelectedItem != null)
            {
                if (cbSorting.SelectedItem.ToString() == "First Name")
                {
                    Student obj = new Student();

                    //original list of student
                    List<Student> listStudents = obj.List();

                    //list after sorting
                    List<Student> lst = obj.Sort(listStudents, "First Name");

                    //adding sorted list to datatable
                    DataTable dt = Utility.ConvertToDataTable(lst);
                    dataGridStudent.DataSource = dt;
                }
                else
                {
                    Student obj = new Student();

                    //original list of student
                    List<Student> listStudents = obj.List();

                    //list after sorting
                    List<Student> lst = obj.Sort(listStudents, "Registration Date");

                    //adding sorted list to datatable
                    DataTable dt = Utility.ConvertToDataTable(lst);
                    dataGridStudent.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Invalid Input! Please, select any value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.Id = int.Parse(txtId.Text);
            obj.FirstName = txtFirstName.Text;
            obj.LastName = txtLastName.Text;
            obj.Name = txtFirstName.Text + " " + txtLastName.Text;
            obj.Address = txtAddress.Text;
            obj.Email = txtEmail.Text;
            obj.BirthDate = dob.Value;
            if (Regex.IsMatch(txtContactNo.Text, "^[0-9]{10}"))
            {
                obj.ContactNo = txtContactNo.Text;
                obj.Gender = gender.SelectedItem.ToString();
                obj.RegistrationDate = regDate.Value;
                obj.Course = enrolProgram.SelectedItem.ToString();
                if (rBtnPending.Checked == true)
                {
                    obj.Status = rBtnPending.Text;
                }

                else if (rBtnPublished.Checked == true)
                {
                    obj.Status = rBtnPublished.Text;
                }
                obj.Edit(obj);
                BindGrid();
                Clear();
                btnUpdate.Visible = false;
                btnSave.Visible = true;
                MessageBox.Show("Data is Sucessfully Updated", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Number Occurred! Please enter valid phone number", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            int rowIndex = dataGridStudent.CurrentCell.RowIndex;
            string message = "Do you really want to delete this Record?";
            string title = "Delete Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                //get the value of the clicked rows id column
                string value = dataGridStudent[0, rowIndex].Value.ToString();
                obj.Delete(int.Parse(value));
                BindGrid();
                MessageBox.Show("Record is Sucessfully Deleted", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //get the value of the clicked rows id column
            Student obj = new Student();
            int rowIndex = dataGridStudent.CurrentCell.RowIndex;
            string value = dataGridStudent[0, rowIndex].Value.ToString();
            int id = 0;
            if (String.IsNullOrEmpty(value))
            {
                MessageBox.Show("Empty record found, Please select the record", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                id = int.Parse(value);
                Student s = obj.List().Where(x => x.Id == id).FirstOrDefault();
                txtId.Text = s.Id.ToString();
                txtFirstName.Text = s.Name.Split(' ')[0];
                txtLastName.Text = s.Name.Split(' ')[1];
                txtAddress.Text = s.Address;
                txtContactNo.Text = s.ContactNo;
                txtEmail.Text = s.Email;
                gender.SelectedItem = s.Gender;
                enrolProgram.SelectedItem = s.Course;
                regDate.Value = s.RegistrationDate;
     
                
                
            }
            btnUpdate.Visible = true;
            btnSave.Visible = false;
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            Chart chart1 = new Chart();
            chart1.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
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

            dataGridReport.Visible = true;
            panelReport.Visible = true;
            dataGridStudent.Hide();

            //convert the result to datatable and show in a datagrid view
            DataTable dt = Utility.ConvertToDataTable(result);
            dataGridReport.DataSource = dt;
            dataGridReport.CurrentCell = null;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import importFile = new Import();
            importFile.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridReport.Visible = false;
            panelReport.Visible = false;
            dataGridStudent.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            MessageBox.Show("Data is cleared sucessfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
