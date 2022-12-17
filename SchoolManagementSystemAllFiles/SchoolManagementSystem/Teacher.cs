using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace SchoolManagementSystem
{
    public partial class frmTeacher : Form
    {
        TeacherDataContext TeacherDt;
        CourseDataContext CourseDtContext;
        int SelectedTeacherID;
        public frmTeacher()
        {
            InitializeComponent();
            TeacherDt = new TeacherDataContext();
            CourseDtContext = new CourseDataContext();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == false)
            {
                TeacherTable teacherTable = new TeacherTable();

                teacherTable.FirstName = this.txtFirstName.Text;
                teacherTable.LastName = this.txtLastName.Text;
                teacherTable.CNIC = this.txtCNIC.Text;
                teacherTable.Mobile = this.txtMobNo.Text;
                int salary = Int32.Parse(this.txtSalary.Text);
                teacherTable.Salary = salary;
                int id = Int32.Parse(this.txtCourseId.Text);
                teacherTable.CourseID = id;
                teacherTable.CourseName = this.cmbCoureT.SelectedItem.ToString();
                teacherTable.Address = this.txtAddress.Text;

                TeacherDt.TeacherTables.InsertOnSubmit(teacherTable);
                TeacherDt.SubmitChanges();

                MessageBox.Show("Successfully inserted");

                // for update changes in gride view
                object sender1 = null;
                EventArgs e1 = null;
                frmTeacher_Load(sender1, e1);
                EmptyAllTextBoxes();
            }
            else
            {
                MessageBox.Show("please fill all the fields");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == false)
            {
                updateStudentTable();

                TeacherTable teacherTable = TeacherDt.TeacherTables.Single(record => record.TeacherID == SelectedTeacherID);

                teacherTable.FirstName = this.txtFirstName.Text;
                teacherTable.LastName = this.txtLastName.Text;
                teacherTable.CNIC = this.txtCNIC.Text;
                teacherTable.Mobile = this.txtMobNo.Text;
                int salary = Int32.Parse(this.txtSalary.Text);
                teacherTable.Salary = salary;
                int id = Int32.Parse(this.txtCourseId.Text);
                teacherTable.CourseID = id;
                teacherTable.CourseName = this.cmbCoureT.SelectedItem.ToString();
                teacherTable.Address = this.txtAddress.Text;

                TeacherDt.SubmitChanges();

                MessageBox.Show("Successfully updated");

                // for update changes in gride view
                object sender1 = null;
                EventArgs e1 = null;
                frmTeacher_Load(sender1, e1);
                EmptyAllTextBoxes();
            }
            else
            {
                MessageBox.Show("please fill all the fields");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleteInStudentTable() == false)
            {

                TeacherTable teacherTable = TeacherDt.TeacherTables.Single(record => record.TeacherID == SelectedTeacherID);
                TeacherDt.TeacherTables.DeleteOnSubmit(teacherTable);
                TeacherDt.SubmitChanges();

                MessageBox.Show("Successfully deleted");

                // for update changes in gride view
                object sender1 = null;
                EventArgs e1 = null;
                frmTeacher_Load(sender1, e1);
                EmptyAllTextBoxes();
            }
            else
            {
                MessageBox.Show("this is used in student table,please delete from there first");
            }

        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = from teacherTable in TeacherDt.TeacherTables select teacherTable;

            CourseTable crsTable = new CourseTable();
            this.cmbCoureT.Items.Clear();
            this.txtCourseId.Enabled = false;
            var course = from crs in CourseDtContext.CourseTables select crs;
            foreach (var crs in course)
            {
                this.cmbCoureT.Items.Add(crs.CourseName);
            }

           
        }

      

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            String picName = "";
           if (op.ShowDialog() == DialogResult.OK)
            {
                picName = op.FileName;
               
            }
           
            FileInfo fi = new FileInfo(picName);
            picName = @"D:\5th semester\Visual Programming\Project\Pics\" + txtFirstName.Text + ".jpg";
            fi.MoveTo(picName);
            this.pictureBox1.ImageLocation = picName;
        }

        private void btnCloseT_Click(object sender, EventArgs e)
        {
            frmDashboard Dashboardobj = new frmDashboard();
            this.Close();
            Dashboardobj.Show();
        }
        String selectedFirstName = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                selectedFirstName= row.Cells[1].Value.ToString();
                this.txtFirstName.Text = row.Cells[1].Value.ToString();
                this.txtLastName.Text = row.Cells[2].Value.ToString();
                this.txtCNIC.Text = row.Cells[3].Value.ToString();
                this.cmbCoureT.Text = row.Cells[4].Value.ToString();
                this.txtAddress.Text = row.Cells[5].Value.ToString();
                this.txtMobNo.Text = row.Cells[6].Value.ToString();
                this.txtCourseId.Text = row.Cells[7].Value.ToString();
                this.txtSalary.Text = row.Cells[8].Value.ToString();

                SelectedTeacherID = Int32.Parse(row.Cells[0].Value.ToString());
                this.pictureBox1.ImageLocation = @"D:\5th semester\Visual Programming\Project\Pics\" + txtFirstName.Text + ".jpg";
            }
            catch(Exception x)
            {
                MessageBox.Show("no value in field");
            }
        }

        private void cmbCourseT_TextChanged(object sender, EventArgs e)
        {
            String selectedCourseName = "" + this.cmbCoureT.SelectedItem;
            String selectedCourseId;
            var query = from crsTable in CourseDtContext.CourseTables select crsTable;
            int count = 0;
            foreach (var selected in query)
            {
                if (selected.CourseName == selectedCourseName)
                {
                    this.txtCourseId.Text = "" + selected.CourseID;
                    break;
                }

            }
        }

        private void updateStudentTable()
        {
           
                StudentDataContext studentDtContext = new StudentDataContext();
                StudentTable studentTable = new StudentTable();
                var queryStudent = from stds in studentDtContext.StudentTables select stds;

                foreach (var qry in queryStudent)
                {
                   
                        if (selectedFirstName == qry.Teacher)
                        {
                            qry.Teacher = this.txtFirstName.Text;

                            studentDtContext.SubmitChanges();
                           
                            break;
                        }

                }

            }


        private bool deleteInStudentTable()
        {
            bool check = false;
            StudentDataContext studentDtContext = new StudentDataContext();
            StudentTable studentTable = new StudentTable();
            var queryStudent = from stds in studentDtContext.StudentTables select stds;

            foreach (var qry in queryStudent)
            {

                if (selectedFirstName == qry.Teacher)
                {
                    qry.Teacher = "";

                    studentDtContext.SubmitChanges();
                    check = true;

                    break;
                }

            }
            return check;

        }

        private bool checkEmpty()
        {
            bool check = false;
            if (this.txtFirstName.Text == ""
                 || this.txtLastName.Text == "" || this.txtMobNo.Text==""
                 || this.txtSalary.Text=="" || this.txtAddress.Text==""
                 || this.txtCNIC.Text=="")
            { check = true; }

            return check;
        }

        private void EmptyAllTextBoxes()
        {
            this.txtAddress.Text = "";
            this.txtCNIC.Text = "";
            this.txtCourseId.Text = "";
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.txtMobNo.Text = "";
            this.txtSalary.Text = "";
            this.pictureBox1.Image = null;
        }

        String beforeChar = "";
        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9]");

            if(rgx.IsMatch(this.txtSalary.Text))
            {
                MessageBox.Show("Incorrect input,only numeric values");
                this.txtSalary.Text = beforeChar;
                beforeChar = "";
            }
            else
            {
                beforeChar = this.txtSalary.Text;
            }
        }

        String beforeChar1 = "";
        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9]");

            if (rgx.IsMatch(this.txtSalary.Text))
            {
                MessageBox.Show("Incorrect input,only numeric values");
                this.txtCNIC.Text = beforeChar1;
                beforeChar1 = "";
            }
            else
            {
                beforeChar1 = this.txtCNIC.Text;
            }
        }

        String beforeChar2 = "";
        private void txtMobNo_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9]");

            if (rgx.IsMatch(this.txtMobNo.Text))
            {
                MessageBox.Show("Incorrect input,onl y numeric values");
                this.txtMobNo.Text = beforeChar2;
                beforeChar2 = "";
            }
            else
            {
                beforeChar2 = this.txtMobNo.Text;
            }
        }
    }
    
}

