namespace SEProject
{
    partial class NewEmployee
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labfname = new System.Windows.Forms.Label();
            this.lablname = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.labGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.labDOB = new System.Windows.Forms.Label();
            this.dtppickerdob = new System.Windows.Forms.DateTimePicker();
            this.txttel = new System.Windows.Forms.TextBox();
            this.labTelephone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpickerDOJ = new System.Windows.Forms.DateTimePicker();
            this.labDOJ = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgbEmployee = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.project = new SEProject.Project();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new SEProject.ProjectTableAdapters.EmployeeTableAdapter();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryGHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.labTelephone);
            this.groupBox1.Controls.Add(this.labDOJ);
            this.groupBox1.Controls.Add(this.dtpickerDOJ);
            this.groupBox1.Controls.Add(this.labDOB);
            this.groupBox1.Controls.Add(this.dtppickerdob);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.labGender);
            this.groupBox1.Controls.Add(this.labfname);
            this.groupBox1.Controls.Add(this.labPassword);
            this.groupBox1.Controls.Add(this.labUsername);
            this.groupBox1.Controls.Add(this.lablname);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtlname);
            this.groupBox1.Controls.Add(this.txtfname);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labfname
            // 
            this.labfname.AutoSize = true;
            this.labfname.Location = new System.Drawing.Point(6, 35);
            this.labfname.Name = "labfname";
            this.labfname.Size = new System.Drawing.Size(55, 13);
            this.labfname.TabIndex = 2;
            this.labfname.Text = "Firstname:";
            // 
            // lablname
            // 
            this.lablname.AutoSize = true;
            this.lablname.Location = new System.Drawing.Point(6, 79);
            this.lablname.Name = "lablname";
            this.lablname.Size = new System.Drawing.Size(56, 13);
            this.lablname.TabIndex = 3;
            this.lablname.Text = "Lastname:";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(81, 79);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(308, 20);
            this.txtlname.TabIndex = 4;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(81, 35);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(308, 20);
            this.txtfname.TabIndex = 5;
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(9, 132);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(42, 13);
            this.labGender.TabIndex = 6;
            this.labGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(77, 132);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(201, 132);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // labDOB
            // 
            this.labDOB.AutoSize = true;
            this.labDOB.Location = new System.Drawing.Point(9, 179);
            this.labDOB.Name = "labDOB";
            this.labDOB.Size = new System.Drawing.Size(66, 13);
            this.labDOB.TabIndex = 8;
            this.labDOB.Text = "Date of Birth";
            this.labDOB.Click += new System.EventHandler(this.labDOB_Click);
            // 
            // dtppickerdob
            // 
            this.dtppickerdob.Location = new System.Drawing.Point(81, 179);
            this.dtppickerdob.Name = "dtppickerdob";
            this.dtppickerdob.Size = new System.Drawing.Size(308, 20);
            this.dtppickerdob.TabIndex = 9;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(666, 35);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(322, 20);
            this.txttel.TabIndex = 11;
            // 
            // labTelephone
            // 
            this.labTelephone.AutoSize = true;
            this.labTelephone.Location = new System.Drawing.Point(591, 35);
            this.labTelephone.Name = "labTelephone";
            this.labTelephone.Size = new System.Drawing.Size(58, 13);
            this.labTelephone.TabIndex = 10;
            this.labTelephone.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(666, 79);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(322, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // dtpickerDOJ
            // 
            this.dtpickerDOJ.Location = new System.Drawing.Point(666, 179);
            this.dtpickerDOJ.Name = "dtpickerDOJ";
            this.dtpickerDOJ.Size = new System.Drawing.Size(322, 20);
            this.dtpickerDOJ.TabIndex = 9;
            // 
            // labDOJ
            // 
            this.labDOJ.AutoSize = true;
            this.labDOJ.Location = new System.Drawing.Point(594, 179);
            this.labDOJ.Name = "labDOJ";
            this.labDOJ.Size = new System.Drawing.Size(64, 13);
            this.labDOJ.TabIndex = 8;
            this.labDOJ.Text = "Date Joined";
            this.labDOJ.Click += new System.EventHandler(this.labDOB_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(666, 125);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(322, 20);
            this.txtSalary.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Salary";
            // 
            // dgbEmployee
            // 
            this.dgbEmployee.AutoGenerateColumns = false;
            this.dgbEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dOJDataGridViewTextBoxColumn,
            this.salaryGHDataGridViewTextBoxColumn});
            this.dgbEmployee.DataSource = this.employeeBindingSource;
            this.dgbEmployee.Location = new System.Drawing.Point(2, 316);
            this.dgbEmployee.Name = "dgbEmployee";
            this.dgbEmployee.Size = new System.Drawing.Size(1045, 235);
            this.dgbEmployee.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(786, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(81, 230);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(308, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Location = new System.Drawing.Point(6, 230);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(58, 13);
            this.labUsername.TabIndex = 3;
            this.labUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(666, 223);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(322, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(594, 226);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(56, 13);
            this.labPassword.TabIndex = 3;
            this.labPassword.Text = "Password:";
            // 
            // project
            // 
            this.project.DataSetName = "Project";
            this.project.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.project;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dOJDataGridViewTextBoxColumn
            // 
            this.dOJDataGridViewTextBoxColumn.DataPropertyName = "DOJ";
            this.dOJDataGridViewTextBoxColumn.HeaderText = "DOJ";
            this.dOJDataGridViewTextBoxColumn.Name = "dOJDataGridViewTextBoxColumn";
            // 
            // salaryGHDataGridViewTextBoxColumn
            // 
            this.salaryGHDataGridViewTextBoxColumn.DataPropertyName = "Salary(GH₵)";
            this.salaryGHDataGridViewTextBoxColumn.HeaderText = "Salary(GH₵)";
            this.salaryGHDataGridViewTextBoxColumn.Name = "salaryGHDataGridViewTextBoxColumn";
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 563);
            this.Controls.Add(this.dgbEmployee);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewEmployee";
            this.Text = "NewEmployee";
            this.Load += new System.EventHandler(this.NewEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label labTelephone;
        private System.Windows.Forms.Label labDOJ;
        private System.Windows.Forms.DateTimePicker dtpickerDOJ;
        private System.Windows.Forms.Label labDOB;
        private System.Windows.Forms.DateTimePicker dtppickerdob;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labfname;
        private System.Windows.Forms.Label lablname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.DataGridView dgbEmployee;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private Project project;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ProjectTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryGHDataGridViewTextBoxColumn;
    }
}