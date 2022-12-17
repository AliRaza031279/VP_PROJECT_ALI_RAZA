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
    public partial class frmLoadingApp : Form
    {
        public frmLoadingApp()
        {
            InitializeComponent();
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = 0;
        }

        private void frmLoadingApp_Load(object sender, EventArgs e)
        {

            this.timer1.Interval = 500;
            this.timer1.Start();
            
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value += 10;
            if(this.progressBar1.Value==100)
            {
                this.timer1.Stop();
                this.Hide();
                frmLogin loginObj = new frmLogin();
                loginObj.Show();
            }

        }

        private void lblOwner_Click(object sender, EventArgs e)
        {

        }
    }
}
