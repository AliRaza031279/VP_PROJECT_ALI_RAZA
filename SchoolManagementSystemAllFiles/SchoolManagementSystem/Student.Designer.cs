namespace SchoolManagementSystem
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCourseFee = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.maskedtxtDofBirth = new System.Windows.Forms.MaskedTextBox();
            this.maskedtxtDofReg = new System.Windows.Forms.MaskedTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtFeePaid = new System.Windows.Forms.TextBox();
            this.txtMobNo = new System.Windows.Forms.TextBox();
            this.txtFatherId = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblDateofReg = new System.Windows.Forms.Label();
            this.lblDateoFBirth = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblFeePaid = new System.Windows.Forms.Label();
            this.lblCourseFee = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMobNo = new System.Windows.Forms.Label();
            this.lblEamilID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFatherID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblStudent);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 53);
            this.panel1.TabIndex = 2;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(292, 9);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(186, 31);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student Portal";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(799, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 33);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddPic);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Location = new System.Drawing.Point(635, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 379);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Details";
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(144, 32);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(32, 23);
            this.btnAddPic.TabIndex = 9;
            this.btnAddPic.Text = "+";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(19, 287);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 37);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(19, 246);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsert.Location = new System.Drawing.Point(19, 200);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(172, 40);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCourseFee);
            this.groupBox1.Controls.Add(this.txtTeacher);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.cmbCourse);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.txtEmailID);
            this.groupBox1.Controls.Add(this.maskedtxtDofBirth);
            this.groupBox1.Controls.Add(this.maskedtxtDofReg);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.txtFeePaid);
            this.groupBox1.Controls.Add(this.txtMobNo);
            this.groupBox1.Controls.Add(this.txtFatherId);
            this.groupBox1.Controls.Add(this.txtFatherName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblDateofReg);
            this.groupBox1.Controls.Add(this.lblDateoFBirth);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblFeePaid);
            this.groupBox1.Controls.Add(this.lblCourseFee);
            this.groupBox1.Controls.Add(this.lblTeacher);
            this.groupBox1.Controls.Add(this.lblCourse);
            this.groupBox1.Controls.Add(this.lblClass);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblMobNo);
            this.groupBox1.Controls.Add(this.lblEamilID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblFatherID);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 379);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // txtCourseFee
            // 
            this.txtCourseFee.Location = new System.Drawing.Point(71, 160);
            this.txtCourseFee.Name = "txtCourseFee";
            this.txtCourseFee.Size = new System.Drawing.Size(111, 20);
            this.txtCourseFee.TabIndex = 37;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(470, 133);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(126, 20);
            this.txtTeacher.TabIndex = 36;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(71, 133);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(111, 20);
            this.txtClass.TabIndex = 35;
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbCourse.Location = new System.Drawing.Point(265, 136);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbCourse.TabIndex = 32;
            this.cmbCourse.TextChanged += new System.EventHandler(this.cmbCourse_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 159);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(470, 98);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 29;
            // 
            // txtEmailID
            // 
            this.txtEmailID.Location = new System.Drawing.Point(75, 99);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(123, 20);
            this.txtEmailID.TabIndex = 28;
            // 
            // maskedtxtDofBirth
            // 
            this.maskedtxtDofBirth.Location = new System.Drawing.Point(265, 64);
            this.maskedtxtDofBirth.Mask = "00/00/0000";
            this.maskedtxtDofBirth.Name = "maskedtxtDofBirth";
            this.maskedtxtDofBirth.Size = new System.Drawing.Size(123, 20);
            this.maskedtxtDofBirth.TabIndex = 27;
            this.maskedtxtDofBirth.ValidatingType = typeof(System.DateTime);
            // 
            // maskedtxtDofReg
            // 
            this.maskedtxtDofReg.Location = new System.Drawing.Point(470, 69);
            this.maskedtxtDofReg.Mask = "00/00/0000";
            this.maskedtxtDofReg.Name = "maskedtxtDofReg";
            this.maskedtxtDofReg.Size = new System.Drawing.Size(126, 20);
            this.maskedtxtDofReg.TabIndex = 26;
            this.maskedtxtDofReg.ValidatingType = typeof(System.DateTime);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(66, 191);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(527, 49);
            this.txtAddress.TabIndex = 25;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(501, 163);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(92, 20);
            this.txtBalance.TabIndex = 24;
            // 
            // txtFeePaid
            // 
            this.txtFeePaid.Location = new System.Drawing.Point(265, 163);
            this.txtFeePaid.Name = "txtFeePaid";
            this.txtFeePaid.Size = new System.Drawing.Size(123, 20);
            this.txtFeePaid.TabIndex = 23;
            this.txtFeePaid.TextChanged += new System.EventHandler(this.txtFeePaid_TextChanged);
            // 
            // txtMobNo
            // 
            this.txtMobNo.Location = new System.Drawing.Point(265, 99);
            this.txtMobNo.Name = "txtMobNo";
            this.txtMobNo.Size = new System.Drawing.Size(123, 20);
            this.txtMobNo.TabIndex = 22;
            this.txtMobNo.TextChanged += new System.EventHandler(this.txtMobNo_TextChanged);
            // 
            // txtFatherId
            // 
            this.txtFatherId.Location = new System.Drawing.Point(75, 66);
            this.txtFatherId.Name = "txtFatherId";
            this.txtFatherId.Size = new System.Drawing.Size(123, 20);
            this.txtFatherId.TabIndex = 21;
            this.txtFatherId.TextChanged += new System.EventHandler(this.txtFatherId_TextChanged);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(470, 39);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(126, 20);
            this.txtFatherName.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(75, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(123, 20);
            this.txtFirstName.TabIndex = 19;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(268, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(122, 20);
            this.txtLastName.TabIndex = 18;
            // 
            // lblDateofReg
            // 
            this.lblDateofReg.AutoSize = true;
            this.lblDateofReg.Location = new System.Drawing.Point(396, 69);
            this.lblDateofReg.Name = "lblDateofReg";
            this.lblDateofReg.Size = new System.Drawing.Size(64, 13);
            this.lblDateofReg.TabIndex = 17;
            this.lblDateofReg.Text = "DateOfReg:";
            // 
            // lblDateoFBirth
            // 
            this.lblDateoFBirth.AutoSize = true;
            this.lblDateoFBirth.Location = new System.Drawing.Point(204, 69);
            this.lblDateoFBirth.Name = "lblDateoFBirth";
            this.lblDateoFBirth.Size = new System.Drawing.Size(63, 13);
            this.lblDateoFBirth.TabIndex = 16;
            this.lblDateoFBirth.Text = "DateofBirth:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 191);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(396, 163);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(99, 13);
            this.lblBalance.TabIndex = 14;
            this.lblBalance.Text = "RemainingBalance:";
            // 
            // lblFeePaid
            // 
            this.lblFeePaid.AutoSize = true;
            this.lblFeePaid.Location = new System.Drawing.Point(198, 163);
            this.lblFeePaid.Name = "lblFeePaid";
            this.lblFeePaid.Size = new System.Drawing.Size(49, 13);
            this.lblFeePaid.TabIndex = 13;
            this.lblFeePaid.Text = "Pay Fee:";
            // 
            // lblCourseFee
            // 
            this.lblCourseFee.AutoSize = true;
            this.lblCourseFee.Location = new System.Drawing.Point(12, 163);
            this.lblCourseFee.Name = "lblCourseFee";
            this.lblCourseFee.Size = new System.Drawing.Size(61, 13);
            this.lblCourseFee.TabIndex = 12;
            this.lblCourseFee.Text = "CourseFee:";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(396, 136);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(50, 13);
            this.lblTeacher.TabIndex = 11;
            this.lblTeacher.Text = "Teacher:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(198, 136);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(43, 13);
            this.lblCourse.TabIndex = 10;
            this.lblCourse.Text = "Course:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(12, 136);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "Class:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(396, 102);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender:";
            // 
            // lblMobNo
            // 
            this.lblMobNo.AutoSize = true;
            this.lblMobNo.Location = new System.Drawing.Point(204, 102);
            this.lblMobNo.Name = "lblMobNo";
            this.lblMobNo.Size = new System.Drawing.Size(55, 13);
            this.lblMobNo.TabIndex = 7;
            this.lblMobNo.Text = "Mob No#:";
            // 
            // lblEamilID
            // 
            this.lblEamilID.AutoSize = true;
            this.lblEamilID.Location = new System.Drawing.Point(12, 102);
            this.lblEamilID.Name = "lblEamilID";
            this.lblEamilID.Size = new System.Drawing.Size(46, 13);
            this.lblEamilID.TabIndex = 6;
            this.lblEamilID.Text = "EmailID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FatherID:";
            // 
            // lblFatherID
            // 
            this.lblFatherID.AutoSize = true;
            this.lblFatherID.Location = new System.Drawing.Point(396, 42);
            this.lblFatherID.Name = "lblFatherID";
            this.lblFatherID.Size = new System.Drawing.Size(68, 13);
            this.lblFatherID.TabIndex = 2;
            this.lblFatherID.Text = "FatherName:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(204, 42);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "LastName:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 42);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "FirstName:";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEamilID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFatherID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblMobNo;
        private System.Windows.Forms.Label lblDateofReg;
        private System.Windows.Forms.Label lblDateoFBirth;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblFeePaid;
        private System.Windows.Forms.Label lblCourseFee;
        private System.Windows.Forms.MaskedTextBox maskedtxtDofReg;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtFeePaid;
        private System.Windows.Forms.TextBox txtMobNo;
        private System.Windows.Forms.TextBox txtFatherId;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.MaskedTextBox maskedtxtDofBirth;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtCourseFee;
    }
}