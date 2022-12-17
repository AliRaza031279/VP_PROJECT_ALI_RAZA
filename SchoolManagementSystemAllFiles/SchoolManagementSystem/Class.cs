using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace SchoolManagementSystem
{
    public partial class frmClass : Form
    {
        
        SqlConnection con = new SqlConnection();
        SqlDataReader dr;
        SqlCommand cmd;
         SqlDataAdapter da;
        String SelectedClassId;
        public frmClass()
        {
            InitializeComponent();
        }

        private void Class_Load(object sender, EventArgs e)
        {
             con.ConnectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;

             cmd = new SqlCommand();
             cmd.Connection = con;
             cmd.CommandText = "Select * from ClassTable";
             con.Open();

             da = new SqlDataAdapter(cmd.CommandText,con);
             DataSet ds = new DataSet();
             da.Fill(ds);

             this.dataGridView1.DataSource = ds.Tables[0];
             con.Close();

            this.txtClassName.Text = "";
            this.txtClassTiming.Text = "";
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == false)
            {

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert into ClassTable(ClassName,ClassTiming) values( '" + txtClassName.Text + "','" + txtClassTiming.Text + "');";
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully inserted");

                // calling form class load to make changes in data grid view
                object sender1 = null;
                EventArgs e1 = null;
                Class_Load(sender1, e1);
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
                updateCourseTable();
                updateStudentTable();

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update ClassTable set ClassName='" + txtClassName.Text + "',ClassTiming='" +
                txtClassTiming.Text + "' where ID = '" + SelectedClassId + "';";
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated");

                // calling form class load to make changes in data grid view
                object sender1 = null;
                EventArgs e1 = null;
                Class_Load(sender1, e1);

                

            }
            else
            {
                MessageBox.Show("Please provide all the details");
            }

           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (deleteInCourseTable() == false)//check whether used as foreign key in course Table
            {
                deleteInStudentTable();
               cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from ClassTable where Id='" + SelectedClassId + "';";
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted");
                
                // calling form class load to make changes in data grid view
                object sender1 = null;
                EventArgs e1 = null;
                Class_Load(sender1, e1);
            }
            else
            {
                MessageBox.Show("cannot delete,first delete the refferd column");
            }


           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtClassName.Text = "";
            this.txtClassTiming.Text = "";
        }

        String SelectedClassName = "";
        private void GridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtClassName.Text = row.Cells[1].Value.ToString();
                SelectedClassName = row.Cells[1].Value.ToString();
                txtClassTiming.Text = row.Cells[2].Value.ToString();
                SelectedClassId = row.Cells[0].Value.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show("no value in field");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmDashboard Dashboardobj = new frmDashboard();
            this.Close();
            Dashboardobj.Show();
        }

        private bool checkEmpty()
        {
            bool check = false;
            if (this.txtClassName.Text == ""
                 || this.txtClassTiming.Text == "" )
            { check = true; }

            return check;
        }

        private void updateCourseTable()
        {
           
            CourseDataContext courseDtContext = new CourseDataContext();
            CourseTable courseTable = new CourseTable();
            var queryCourse = from crs in courseDtContext.CourseTables select crs;

         
                foreach (var qry in queryCourse)
                {
                    if (SelectedClassId == "" + qry.ClassID)
                    {
                        qry.ClassName = this.txtClassName.Text;
                        qry.CourseTiming = this.txtClassTiming.Text;
                        courseDtContext.SubmitChanges();
                      
                        break;
                    }
                
                }

           
        }

        private void updateStudentTable()
        {

            StudentDataContext studentDtContext = new StudentDataContext();
            StudentTable studentTable = new StudentTable();
            var queryStudent = from stdnt in studentDtContext.StudentTables select stdnt;

            foreach (var qry in queryStudent)
            {
              if(SelectedClassName==qry.Class)
                {
                    qry.Class = "";
                    studentDtContext.SubmitChanges();
                    break;
                }
               
            }


        }


        private bool deleteInCourseTable()
        {
            bool check = false;
            
                CourseDataContext courseDtContext = new CourseDataContext();
                CourseTable courseTable = new CourseTable();
                var queryCourse = from crs in courseDtContext.CourseTables select crs;

             
                foreach (var qry in queryCourse)
                {
                    if (SelectedClassId == "" + qry.ClassID)
                    {
                      
                        check = true;
                        break;
                    }
                }

            return check;


        }
        private void deleteInStudentTable()
        {
            StudentDataContext studentDtContext = new StudentDataContext();
            StudentTable studentTable = new StudentTable();
            var queryStudent = from stdnt in studentDtContext.StudentTables select stdnt;

            foreach (var qry in queryStudent)
            {
               
                    if (qry.Class == SelectedClassName)
                    {
                        qry.Class = "";
                        studentDtContext.SubmitChanges();
                     

                        break;
                    }
                   
               
            }

        }
    }
}
