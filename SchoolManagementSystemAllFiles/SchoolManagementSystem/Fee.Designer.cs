namespace SchoolManagementSystem
{
    partial class frmFee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFee = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLastNameSearch = new System.Windows.Forms.TextBox();
            this.lblLastNameSearch = new System.Windows.Forms.Label();
            this.txtFirstNameSearch = new System.Windows.Forms.TextBox();
            this.lblFirstNameSearch = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFeePaid = new System.Windows.Forms.TextBox();
            this.btnAddFee = new System.Windows.Forms.Button();
            this.lblFeepaid = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblCourseFee = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCourseFee = new System.Windows.Forms.TextBox();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblFee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(749, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 29);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.Location = new System.Drawing.Point(279, 9);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(139, 31);
            this.lblFee.TabIndex = 0;
            this.lblFee.Text = "Fee Portal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowStudents);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtLastNameSearch);
            this.groupBox1.Controls.Add(this.lblLastNameSearch);
            this.groupBox1.Controls.Add(this.txtFirstNameSearch);
            this.groupBox1.Controls.Add(this.lblFirstNameSearch);
            this.groupBox1.Location = new System.Drawing.Point(551, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Student";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(76, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 48);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLastNameSearch
            // 
            this.txtLastNameSearch.Location = new System.Drawing.Point(76, 61);
            this.txtLastNameSearch.Name = "txtLastNameSearch";
            this.txtLastNameSearch.Size = new System.Drawing.Size(131, 20);
            this.txtLastNameSearch.TabIndex = 16;
            // 
            // lblLastNameSearch
            // 
            this.lblLastNameSearch.AutoSize = true;
            this.lblLastNameSearch.Location = new System.Drawing.Point(-4, 61);
            this.lblLastNameSearch.Name = "lblLastNameSearch";
            this.lblLastNameSearch.Size = new System.Drawing.Size(61, 13);
            this.lblLastNameSearch.TabIndex = 15;
            this.lblLastNameSearch.Text = "Last Name:";
            // 
            // txtFirstNameSearch
            // 
            this.txtFirstNameSearch.Location = new System.Drawing.Point(76, 32);
            this.txtFirstNameSearch.Name = "txtFirstNameSearch";
            this.txtFirstNameSearch.Size = new System.Drawing.Size(131, 20);
            this.txtFirstNameSearch.TabIndex = 14;
            // 
            // lblFirstNameSearch
            // 
            this.lblFirstNameSearch.AutoSize = true;
            this.lblFirstNameSearch.Location = new System.Drawing.Point(-2, 32);
            this.lblFirstNameSearch.Name = "lblFirstNameSearch";
            this.lblFirstNameSearch.Size = new System.Drawing.Size(60, 13);
            this.lblFirstNameSearch.TabIndex = 13;
            this.lblFirstNameSearch.Text = "First Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCourseFee);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.txtTotalPaid);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblBalance);
            this.groupBox2.Controls.Add(this.lblTotalPaid);
            this.groupBox2.Controls.Add(this.lblCourseFee);
            this.groupBox2.Controls.Add(this.lblLastName);
            this.groupBox2.Controls.Add(this.lblFirstName);
            this.groupBox2.Location = new System.Drawing.Point(0, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 217);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Student Detail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(285, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(117, 137);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(115, 20);
            this.txtBalance.TabIndex = 11;
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(91, 111);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Size = new System.Drawing.Size(141, 20);
            this.txtTotalPaid.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(91, 58);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(141, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(91, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(141, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFeePaid);
            this.groupBox3.Controls.Add(this.btnAddFee);
            this.groupBox3.Controls.Add(this.lblFeepaid);
            this.groupBox3.Location = new System.Drawing.Point(6, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 56);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Fees: ";
            // 
            // txtFeePaid
            // 
            this.txtFeePaid.Location = new System.Drawing.Point(85, 24);
            this.txtFeePaid.Name = "txtFeePaid";
            this.txtFeePaid.Size = new System.Drawing.Size(141, 20);
            this.txtFeePaid.TabIndex = 12;
            this.txtFeePaid.TextChanged += new System.EventHandler(this.txtFeePaid_TextChanged);
            // 
            // btnAddFee
            // 
            this.btnAddFee.Location = new System.Drawing.Point(314, 22);
            this.btnAddFee.Name = "btnAddFee";
            this.btnAddFee.Size = new System.Drawing.Size(98, 23);
            this.btnAddFee.TabIndex = 7;
            this.btnAddFee.Text = "Add Fee";
            this.btnAddFee.UseVisualStyleBackColor = true;
            this.btnAddFee.Click += new System.EventHandler(this.btnAddFee_Click);
            // 
            // lblFeepaid
            // 
            this.lblFeepaid.AutoSize = true;
            this.lblFeepaid.Location = new System.Drawing.Point(6, 27);
            this.lblFeepaid.Name = "lblFeepaid";
            this.lblFeepaid.Size = new System.Drawing.Size(49, 13);
            this.lblFeepaid.TabIndex = 6;
            this.lblFeepaid.Text = "Pay Fee:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(12, 136);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(99, 13);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "RemainingBalance:";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Location = new System.Drawing.Point(12, 108);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(55, 13);
            this.lblTotalPaid.TabIndex = 3;
            this.lblTotalPaid.Text = "TotalPaid:";
            // 
            // lblCourseFee
            // 
            this.lblCourseFee.AutoSize = true;
            this.lblCourseFee.Location = new System.Drawing.Point(12, 82);
            this.lblCourseFee.Name = "lblCourseFee";
            this.lblCourseFee.Size = new System.Drawing.Size(61, 13);
            this.lblCourseFee.TabIndex = 2;
            this.lblCourseFee.Text = "CourseFee:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 169);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtCourseFee
            // 
            this.txtCourseFee.Location = new System.Drawing.Point(91, 85);
            this.txtCourseFee.Name = "txtCourseFee";
            this.txtCourseFee.Size = new System.Drawing.Size(141, 20);
            this.txtCourseFee.TabIndex = 13;
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(76, 155);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(119, 48);
            this.btnShowStudents.TabIndex = 21;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // frmFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFee";
            this.Text = "Fee";
            this.Load += new System.EventHandler(this.frmFee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblCourseFee;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFeePaid;
        private System.Windows.Forms.Button btnAddFee;
        private System.Windows.Forms.Label lblFeepaid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLastNameSearch;
        private System.Windows.Forms.Label lblLastNameSearch;
        private System.Windows.Forms.TextBox txtFirstNameSearch;
        private System.Windows.Forms.Label lblFirstNameSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCourseFee;
        private System.Windows.Forms.Button btnShowStudents;
    }
}