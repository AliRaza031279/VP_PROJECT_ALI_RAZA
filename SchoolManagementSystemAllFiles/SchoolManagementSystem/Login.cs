using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = this.btnSignIn;
        }
      
        

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;

            SqlCommand command = new SqlCommand("Select Username,Password from UsersTable", connection);
            connection.Open();

            SqlDataReader dataReader = command.ExecuteReader();

           
                bool check = false;

            while(dataReader.Read())
            {
                if(dataReader.GetString(0)==this.txtUsername.Text && dataReader.GetString(1)==this.txtPassword.Text)
                {
                    check = true;
                    break;
                }
            }
            if (check==true)
            {
                frmDashboard dashboard = new frmDashboard();
                this.Hide();
                
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
           
            connection.Close();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
    }
}
