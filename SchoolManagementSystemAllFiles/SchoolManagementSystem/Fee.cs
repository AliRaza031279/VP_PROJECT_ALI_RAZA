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
    public partial class frmFee : Form
    {
        StudentDataContext stdDataContext2;
        int SelectedStudentId;
        public frmFee()
        {
            InitializeComponent();
            stdDataContext2 = new StudentDataContext();
        }

        private void frmFee_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = from studentT in stdDataContext2.StudentTables select studentT;
           
            this.txtFirstName.Enabled = false;
            this.txtLastName.Enabled = false;
            this.txtTotalPaid.Enabled = false;
            this.txtBalance.Enabled = false;
            this.txtCourseFee.Enabled = false;            

        }

        private void btnAddFee_Click(object sender, EventArgs e)
        {
            if (this.txtFeePaid.Text != "")
            {
                StudentTable stdTable2 = new StudentTable();
                int addFee = Int32.Parse(this.txtFeePaid.Text);
                stdTable2 = stdDataContext2.StudentTables.Single(record => record.StudentId == SelectedStudentId);

                stdTable2.FeePaid = stdTable2.FeePaid + addFee;
                stdTable2.Balance = (stdTable2.CourseFee - stdTable2.FeePaid);
                stdDataContext2.SubmitChanges();

                MessageBox.Show("Successfully Fee Added");

                // for update changes in gride view
                object sender1 = null;
                EventArgs e1 = null;
                frmFee_Load(sender1, e1);
            }
            else
            {
                MessageBox.Show("Alert: Fee is not added");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentTable studentTable = new StudentTable();
            this.dataGridView1.DataSource = from std in stdDataContext2.StudentTables
                                            where std.FirstName == this.txtFirstNameSearch.Text && std.LastName == this.txtLastNameSearch.Text
                                            select std;
            this.pictureBox1.ImageLocation = @"D:\5th semester\Visual Programming\Project\Pics\" + txtFirstNameSearch.Text + ".jpg";

            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.txtCourseFee.Text="";
            this.txtTotalPaid.Text = "";
            this.txtBalance.Text = "";
            this.txtFeePaid.Text= "";//remaining balance
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmDashboard Dashboardobj = new frmDashboard();
            this.Close();
            Dashboardobj.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                this.txtFirstName.Text = row.Cells[1].Value.ToString();
                this.txtLastName.Text = row.Cells[2].Value.ToString();
                this.txtCourseFee.Text = row.Cells[13].Value.ToString();
                this.txtTotalPaid.Text = row.Cells[14].Value.ToString();
                this.txtBalance.Text = row.Cells[15].Value.ToString();

                SelectedStudentId = Int32.Parse(row.Cells[0].Value.ToString());
                this.pictureBox1.ImageLocation = @"D:\5th semester\Visual Programming\Project\Pics\" + txtFirstName.Text + ".jpg";
            }
            catch(Exception x)
            {
                MessageBox.Show("no value in field");
            }

        }

        private void txtFeePaid_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9]");
            if (rgx.IsMatch(this.txtFeePaid.Text))
                MessageBox.Show("Incorrect Input");
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            object sender1 = null;
            EventArgs e1 = null;
            frmFee_Load(sender1, e1);
        }
    }
}
