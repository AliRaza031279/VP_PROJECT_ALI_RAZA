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
    public partial class frmStudent : Form
    {
        StudentDataContext StdDataContext;
        CourseDataContext courseDtContext;
        ClassDataContext classDtContext;
        TeacherDataContext teacherDtContext;
        int SelectedStudentID;

        public frmStudent()
        {
            InitializeComponent();
            this.txtBalance.Enabled = false;
            courseDtContext = new CourseDataContext();
            classDtContext = new ClassDataContext();
            teacherDtContext = new TeacherDataContext();

            this.txtClass.Enabled = false;
            this.txtTeacher.Enabled = false;
            this.txtCourseFee.Enabled = false;
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            StdDataContext = new StudentDataContext();
            this.dataGridView1.DataSource = from studentTable in StdDataContext.StudentTables select studentTable;

          
            this.cmbCourse.Items.Clear();
            this.cmbGender.Items.Clear();
           
            var crsQuery = from crsTble in courseDtContext.CourseTables select crsTble;
            foreach (var crsQ in crsQuery)
            {
                this.cmbCourse.Items.Add(crsQ.CourseName);
              
            }

            this.cmbGender.Items.Add("Male");
            this.cmbGender.Items.Add("Female");
            this.cmbGender.Items.Add("Other");

         

        }

        String beforeCharInTxtFeePaid = "";
        private void txtFeePaid_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^[0-9]");
            if(rgx.IsMatch(this.txtFeePaid.Text))
            {
                MessageBox.Show("incorrect input");
                this.txtFeePaid.Text = beforeCharInTxtFeePaid;
            }
            else
            {
                beforeCharInTxtFeePaid = this.txtFeePaid.Text;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                this.dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                this.txtFirstName.Text = row.Cells[1].Value.ToString();
                this.txtLastName.Text = row.Cells[2].Value.ToString();
                this.txtFatherName.Text = row.Cells[3].Value.ToString();
                this.txtFatherId.Text = row.Cells[4].Value.ToString();
                this.maskedtxtDofBirth.Text = row.Cells[5].Value.ToString();
                this.maskedtxtDofReg.Text = row.Cells[6].Value.ToString();
                this.txtEmailID.Text = row.Cells[7].Value.ToString();
                this.txtMobNo.Text = row.Cells[8].Value.ToString();
                this.cmbGender.Text = row.Cells[9].Value.ToString();
                this.txtClass.Text = row.Cells[10].Value.ToString();
                this.cmbCourse.Text = row.Cells[11].Value.ToString();
                this.txtTeacher.Text = row.Cells[12].Value.ToString();
                this.txtCourseFee.Text = row.Cells[13].Value.ToString();
                this.txtFeePaid.Text = row.Cells[14].Value.ToString();
                this.txtBalance.Text = row.Cells[15].Value.ToString();
                this.txtAddress.Text = row.Cells[16].Value.ToString();


                SelectedStudentID = Int32.Parse(row.Cells[0].Value.ToString());
                this.pictureBox1.ImageLocation = @"D:\5th semester\Visual Programming\Project\Pics\" + txtFirstName.Text + ".jpg";
            }
            catch(Exception x)
            {
                MessageBox.Show("no value in field");
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == false)
            {
                StudentTable studentTable = new StudentTable();

                studentTable.FirstName = this.txtFirstName.Text;
                studentTable.LastName = this.txtLastName.Text;
                studentTable.FatherName = this.txtFatherName.Text;
                studentTable.FatherId = this.txtFatherId.Text;
                studentTable.DOB = this.maskedtxtDofBirth.Text;
                studentTable.DOR = this.maskedtxtDofReg.Text;
                studentTable.EmailiD = this.txtEmailID.Text;
                studentTable.MobNo = this.txtMobNo.Text;
                studentTable.Gender = this.cmbGender.Text;
                studentTable.Class = this.txtClass.Text;
                studentTable.Course = this.cmbCourse.Text;
                studentTable.Teacher = this.txtTeacher.Text;
                int courseFee = Int32.Parse(this.txtCourseFee.Text);
                studentTable.CourseFee = courseFee;
                int feePaid = Int32.Parse(this.txtFeePaid.Text);
                studentTable.FeePaid = feePaid;

                int crsFee = Int32.Parse(this.txtCourseFee.Text);
                int feePai = Int32.Parse(this.txtFeePaid.Text);
                studentTable.Balance = (crsFee - feePai);
                studentTable.Address = this.txtAddress.Text;

                StdDataContext.StudentTables.InsertOnSubmit(studentTable);
                StdDataContext.SubmitChanges();

                MessageBox.Show("Successfully inserted");

                // for update changes in gride view
                object sender1 = null;
                EventArgs e1 = null; 
                frmStudent_Load(sender1, e1);
                EmptyAllTextBoxes();
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == false)
            {
                StudentTable studentTable = StdDataContext.StudentTables.Single(record => record.StudentId == SelectedStudentID);

                studentTable.FirstName = this.txtFirstName.Text;
                studentTable.LastName = this.txtLastName.Text;
                studentTable.FatherName = this.txtFatherName.Text;
                studentTable.FatherId = this.txtFatherId.Text;
                studentTable.DOB = this.maskedtxtDofBirth.Text;
                studentTable.DOR = this.maskedtxtDofReg.Text;
                studentTable.EmailiD = this.txtEmailID.Text;
                studentTable.MobNo = this.txtMobNo.Text;
                studentTable.Gender = this.cmbGender.Text;
                studentTable.Class = this.txtClass.Text;
                studentTable.Course = this.cmbCourse.Text;
                studentTable.Teacher = this.txtTeacher.Text;
                int courseFee = Int32.Parse(this.txtCourseFee.Text);
                studentTable.CourseFee = courseFee;
                int feePaid = Int32.Parse(this.txtFeePaid.Text);
                studentTable.FeePaid = feePaid;

                studentTable.Balance = courseFee-feePaid;
                studentTable.Address = this.txtAddress.Text;

                StdDataContext.SubmitChanges();

                MessageBox.Show("Successfully updated");

                // for update changes in gride view
                object sender1 = null;
                EventArgs e1 = null;
                frmStudent_Load(sender1, e1);
                EmptyAllTextBoxes();
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StudentTable studentTable = StdDataContext.StudentTables.Single(record => record.StudentId == SelectedStudentID);
            StdDataContext.StudentTables.DeleteOnSubmit(studentTable);
            StdDataContext.SubmitChanges();

            MessageBox.Show("Successfully Deleted");

            // for update changes in gride view
            object sender1 = null;
            EventArgs e1 = null;
            frmStudent_Load(sender1, e1);

            EmptyAllTextBoxes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmDashboard Dashboardobj = new frmDashboard();
            this.Close();
            Dashboardobj.Show();
        }

        private void cmbCourse_TextChanged(object sender, EventArgs e)
        {
            String selectedCourseName = "" + this.cmbCourse.SelectedItem;
            String selectedCourseId;

            var query = from crsTable in courseDtContext.CourseTables select crsTable;
            int count = 0;
            foreach (var selected in query)
            {
                if (selected.CourseName == selectedCourseName)
                {
                    this.txtClass.Text = selected.ClassName;
                    this.txtCourseFee.Text =""+ selected.CourseFee;
                   
                    break;
                }

            }

            var query1 = from tchrsTable in teacherDtContext.TeacherTables select tchrsTable;
           
            foreach (var selected in query1)
            {
                if (selected.CourseName == selectedCourseName)
                {
                    this.txtTeacher.Text = selected.FirstName; 

                    break;
                }

            }
        }

        private bool checkEmpty()
        {
            bool check = false;
            if (this.txtAddress.Text == "" ||
            this.txtClass.Text == ""||
            this.txtCourseFee.Text == ""||
            this.txtEmailID.Text == ""||
            this.txtFatherId.Text == ""||
            this.txtFatherName.Text == ""||
            this.txtFeePaid.Text == ""||
            this.txtFirstName.Text == ""||
            this.txtLastName.Text == ""||
            this.txtMobNo.Text == ""||
            this.txtTeacher.Text == "")
            { check = true; }

            return check;
        }
        private void EmptyAllTextBoxes()
        {
            this.txtAddress.Text = "";
            this.txtBalance.Text = "";
            this.txtClass.Text = "";
            this.txtCourseFee.Text = "";
            this.txtEmailID.Text = "";
            this.txtFatherId.Text = "";
            this.txtFatherName.Text = "";
            this.txtFeePaid.Text = "";
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.txtMobNo.Text = "";
            this.txtTeacher.Text = "";
            this.pictureBox1.Image = null;
        }

        String beforeCharInTxtMobNo = "";
        private void txtMobNo_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9]");
            if(rgx.IsMatch(this.txtMobNo.Text))
            {
                MessageBox.Show("Only numeric values are allowed");
                this.txtMobNo.Text = beforeCharInTxtMobNo;
            }
            else
            {
                beforeCharInTxtMobNo = this.txtMobNo.Text;
            }
        }

        String beforeCharInTxtFatherId = "";
        private void txtFatherId_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9]");
            if (rgx.IsMatch(this.txtFatherId.Text))
            {
                MessageBox.Show("Only numeric values are allowed");
                this.txtFatherId.Text = beforeCharInTxtFatherId;
            }
            else
            {
                beforeCharInTxtFatherId = this.txtFatherId.Text;
            }
        }
    }
}
