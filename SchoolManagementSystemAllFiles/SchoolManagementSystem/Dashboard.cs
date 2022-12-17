using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

         
        }
      
        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin Loginobj = new frmLogin();
            this.Close();
            Loginobj.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudentPortal_Click(object sender, EventArgs e)
        {
            frmStudent StudentObj = new frmStudent();
            this.Hide();
            StudentObj.Show();
        }

        private void btnCoursePortal_Click(object sender, EventArgs e)
        {
            frmCourse CourseObj = new frmCourse();
            this.Hide();
            CourseObj.Show();
        }

        private void btnTeacherPortal_Click(object sender, EventArgs e)
        {
            frmTeacher TeacherObj = new frmTeacher();
            this.Hide();
            TeacherObj.Show();
        }

        private void btnClassPortal_Click(object sender, EventArgs e)
        {
            frmClass ClassObj = new frmClass();
            this.Hide();
            ClassObj.Show();
        }

        private void btnFeePortal_Click(object sender, EventArgs e)
        {
            frmFee FeeObj = new frmFee();
            this.Hide();
            FeeObj.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUser UserObj = new frmUser();
            this.Hide();
            UserObj.Show();
        }
    }
}
