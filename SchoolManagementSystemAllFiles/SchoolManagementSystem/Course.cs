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


namespace SchoolManagementSystem
{
    public partial class frmCourse : Form
    {
        CourseDataContext CourseDtContext;
        ClassDataContext ClassDtContext;
        int SelectedCourseId;
        public frmCourse()
        {
            InitializeComponent();
            CourseDtContext = new CourseDataContext();
            ClassDtContext = new ClassDataContext();

            this.txtClassID.Enabled = false;
            this.txtCouseTiming.Enabled = false;
           
            

        }

        String beforeChar = "";
        private void txtCourseFee_TextChanged(object sender, EventArgs e)
        {
           
            Regex rgx = new Regex(@"[^0-9]");
            if (rgx.IsMatch(txtCourseFee.Text))
            {
                MessageBox.Show("please enter correct input");
                this.txtCourseFee.Text = beforeChar;
                
            }
            else
            {
                beforeChar = this.txtCourseFee.Text;
            }
           
               
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (checkEmpty()==false)
            {

                CourseTable courseTable = new CourseTable();

                courseTable.CourseName = this.txtCourseName.Text;
                courseTable.CourseStart = this.maskedTxtCoursestart.Text;
                courseTable.CourseEnd = this.maskedtxtCouseEnd.Text;
                int Fee = Int32.Parse(this.txtCourseFee.Text);
                courseTable.CourseFee = Fee;
                courseTable.CourseTiming = this.txtCouseTiming.Text;
                int ID = Int32.Parse(this.txtClassID.Text);
                courseTable.ClassID = ID;
                courseTable.ClassName = "" + this.cmbClassName.SelectedItem;

                CourseDtContext.CourseTables.InsertOnSubmit(courseTable);
                CourseDtContext.SubmitChanges();
                MessageBox.Show("Successfully inserted");


                // for update changes in gride view
                object sender1 = null;
                EventArgs e1 = null;
                frmCourse_Load(sender1, e1);
            }
            else
            {
                MessageBox.Show("pleas fill all the fields");
            }
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == false)
            {
                updateTeacherTable();
                updateStudentTable();

                CourseTable courseTable = CourseDtContext.CourseTables.Single(record => record.CourseID == SelectedCourseId);
                courseTable.CourseName = this.txtCourseName.Text;
                courseTable.CourseStart = this.maskedTxtCoursestart.Text;
                courseTable.CourseEnd = this.maskedtxtCouseEnd.Text;

                int Fee = Int32.Parse(this.txtCourseFee.Text);
                courseTable.CourseFee = Fee;

               // courseTable.CourseFee = Int32.Parse(this.txtCourseFee.Text);
                courseTable.CourseTiming = this.txtCouseTiming.Text;
                // courseTable.ClassID = Int32.Parse(this.txtClassID.SelectedText);
                int ID = Int32.Parse(this.txtClassID.Text);
                courseTable.ClassID = ID;

                courseTable.ClassName =""+ this.cmbClassName.SelectedItem;

                CourseDtContext.SubmitChanges();

                MessageBox.Show("successfully updated");
                // for update changes in gride view
                object sender1 = null;
                EventArgs e1 = null;
                frmCourse_Load(sender1, e1);
            }
            else
            {
                MessageBox.Show("pleas fill all the fields");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleteInTeacherTable() == false)
            {
                MessageBox.Show("successfully Deleted");
                DeleteInStudentTable();

                CourseTable courseTable = CourseDtContext.CourseTables.Single(record => record.CourseID == SelectedCourseId);
                CourseDtContext.CourseTables.DeleteOnSubmit(courseTable);
                CourseDtContext.SubmitChanges();

               
                // for update changes in gride view
                object sender1 = null;
                EventArgs e1 = null;
                frmCourse_Load(sender1, e1);
            }
            else
            {
                MessageBox.Show("cannot delete,first delete the refferd column");

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDashboard Dashboardobj = new frmDashboard();
            Dashboardobj.Show();
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            this.cmbClassName.Items.Clear();
            this.dataGridView1.DataSource = from courseTable in CourseDtContext.CourseTables select courseTable;

            var query = from clsTable in ClassDtContext.ClassTables select clsTable;

            foreach (var Cls in query)
            {
               
                this.cmbClassName.Items.Add(Cls.ClassName);
            }

            this.maskedTxtCoursestart.Text = "";
            this.maskedtxtCouseEnd.Text = "";
            this.txtClassID.Text = "";
            this.txtCourseFee.Text = "";
            this.txtCourseName.Text = "";
            this.txtCouseTiming.Text = "";
        }

        String SelectedCourseName = "";
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                this.cmbClassName.Text = row.Cells[7].Value.ToString();
                this.txtCourseName.Text = row.Cells[1].Value.ToString();

                SelectedCourseName=row.Cells[1].Value.ToString();
                this.maskedTxtCoursestart.Text = row.Cells[2].Value.ToString();
                this.txtCouseTiming.Text = row.Cells[4].Value.ToString();
                this.maskedtxtCouseEnd.Text = row.Cells[3].Value.ToString();
                this.txtCourseFee.Text = row.Cells[5].Value.ToString();
                this.txtClassID.Text = row.Cells[6].Value.ToString();

                SelectedCourseId = Int32.Parse(row.Cells[0].Value.ToString());
            }
            catch(Exception x)
            {
                MessageBox.Show("no value in field");
            }
        }

        private void cmbClassName_TextChanged(object sender, EventArgs e)
        {
            String selectedClassName =""+this.cmbClassName.SelectedItem;
            String selectedClassId;
            var query = from clsTable in ClassDtContext.ClassTables select clsTable;
            int count = 0;
            foreach(var selected in query)
            {
                if (selected.ClassName==selectedClassName )
                {
                    this.txtClassID.Text=""+selected.Id;
                    this.txtCouseTiming.Text = selected.ClassTiming;
                    break;
                }
                        
            }
           
        }

        private bool checkEmpty()
        {
            bool check = false;
           if(this.txtClassID.Text=="" || this.maskedTxtCoursestart.Text==""
                || this.txtCourseFee.Text=="" || this.txtCourseName.Text==""
                || this.txtCouseTiming.Text=="")
            { check = true; }
                
                return check;
        }

        private void updateTeacherTable()
        {

            TeacherDataContext TeacherDtContext = new TeacherDataContext();
            TeacherTable teacherTable = new TeacherTable();
            var queryTeacher = from tchrs in TeacherDtContext.TeacherTables select tchrs;

            foreach (var qry in queryTeacher)
            {
              if(SelectedCourseId==qry.CourseID)
                {
                    qry.CourseName = this.txtCourseName.Text;
                    TeacherDtContext.SubmitChanges();
                    break;
                }
            }


        }

        private void updateStudentTable()
        {

          
            StudentDataContext StudentDtContext = new StudentDataContext();
            StudentTable studentTable = new StudentTable();
            var queryStudent = from std in StudentDtContext.StudentTables select std;

            foreach (var qry in queryStudent)
            {
               
                    if (SelectedCourseName == qry.Course)
                    {
                        qry.Course = this.txtCourseName.Text ;
                        int fee = Int32.Parse(this.txtCourseFee.Text);
                        qry.CourseFee = fee;

                        StudentDtContext.SubmitChanges();
                       
                        break;
                    }

               
            }


        }


        private bool deleteInTeacherTable()
        {

            bool check = false;
            TeacherDataContext TeacherDtContext = new TeacherDataContext();
            TeacherTable teacherTable = new TeacherTable();
            var queryTeacher = from tchrs in TeacherDtContext.TeacherTables select tchrs;

            foreach (var qry in queryTeacher)
            {

                if (SelectedCourseId == qry.CourseID)
                {

                    check = true ;
                    break;
                }
            }
            return check;

        }

        private void DeleteInStudentTable()
        {

          
            StudentDataContext StudentDtContext = new StudentDataContext();
            StudentTable studentTable = new StudentTable();
            var queryStudent = from std in StudentDtContext.StudentTables select std;

            foreach (var qry in queryStudent)
            {

                if (SelectedCourseName == qry.Course)
                {
                    qry.Course = "";
                    int fee = 0;
                    qry.CourseFee = fee;

                    StudentDtContext.SubmitChanges();

                    break;
              
            }
        }


        }



    }
}
