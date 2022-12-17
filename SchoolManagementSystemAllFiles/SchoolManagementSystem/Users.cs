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
    public partial class frmUser : Form
    {
        UserDataContext usrDataContext;
        int SelectedUserId;
        public frmUser()
        {
            InitializeComponent();
            usrDataContext = new UserDataContext();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = from usr in usrDataContext.UsersTables select usr;

            this.txtPassword.Text = "";
            this.txtUsername.Text = ""; 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dataGridView1.Rows[e.RowIndex].ReadOnly = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                this.txtUsername.Text = row.Cells[1].Value.ToString();
                this.txtPassword.Text = row.Cells[2].Value.ToString();

                SelectedUserId = Int32.Parse(row.Cells[0].Value.ToString());
            }
            catch(Exception x)
            {
                MessageBox.Show("no value in field");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            UsersTable usrTable = new UsersTable();
            usrTable.Username = this.txtUsername.Text;
            usrTable.Password = this.txtPassword.Text;

            usrDataContext.UsersTables.InsertOnSubmit(usrTable);
            usrDataContext.SubmitChanges();

            MessageBox.Show("Successfully Inserted");

            // for update changes in gride view
            object sender1 = null;
            EventArgs e1 = null;
            frmUser_Load(sender1, e1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UsersTable usrTable = usrDataContext.UsersTables.Single(record => record.UserId == SelectedUserId);

            usrTable.Username = this.txtUsername.Text;
            usrTable.Password = this.txtPassword.Text;

            MessageBox.Show("Successfully Updated");

            // for update changes in gride view
            object sender1 = null;
            EventArgs e1 = null;
            frmUser_Load(sender1, e1);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UsersTable usrTable = usrDataContext.UsersTables.Single(record => record.UserId == SelectedUserId);

            usrDataContext.UsersTables.DeleteOnSubmit(usrTable);
            usrDataContext.SubmitChanges();

            MessageBox.Show("Successfully deleted");

            // for update changes in gride view
            object sender1 = null;
            EventArgs e1 = null;
            frmUser_Load(sender1, e1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmDashboard Dashboardobj = new frmDashboard();
            this.Close();
            Dashboardobj.Show();
        }
    }
}
