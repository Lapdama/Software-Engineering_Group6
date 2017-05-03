namespace SEProject
{
    partial class Orders
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
            this.cmbORDrug = new System.Windows.Forms.ComboBox();
            this.txtORQuantity = new System.Windows.Forms.TextBox();
            this.labSQuantity = new System.Windows.Forms.Label();
            this.dtpORdate = new System.Windows.Forms.DateTimePicker();
            this.labSItem = new System.Windows.Forms.Label();
            this.labSDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSDone = new System.Windows.Forms.Button();
            this.txtORCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtORCustomerName = new System.Windows.Forms.TextBox();
            this.labCustomerTelephone = new System.Windows.Forms.Label();
            this.labSCustomerName = new System.Windows.Forms.Label();
            this.project = new SEProject.Project();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugsTableAdapter = new SEProject.ProjectTableAdapters.DrugsTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbORDrug);
            this.groupBox1.Controls.Add(this.txtORQuantity);
            this.groupBox1.Controls.Add(this.labSQuantity);
            this.groupBox1.Controls.Add(this.dtpORdate);
            this.groupBox1.Controls.Add(this.labSItem);
            this.groupBox1.Controls.Add(this.labSDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drug Details";
            // 
            // cmbORDrug
            // 
            this.cmbORDrug.DataSource = this.drugsBindingSource;
            this.cmbORDrug.DisplayMember = "Name";
            this.cmbORDrug.FormattingEnabled = true;
            this.cmbORDrug.Location = new System.Drawing.Point(97, 82);
            this.cmbORDrug.Name = "cmbORDrug";
            this.cmbORDrug.Size = new System.Drawing.Size(322, 21);
            this.cmbORDrug.TabIndex = 3;
            this.cmbORDrug.ValueMember = "Name";
            // 
            // txtORQuantity
            // 
            this.txtORQuantity.Location = new System.Drawing.Point(576, 36);
            this.txtORQuantity.Name = "txtORQuantity";
            this.txtORQuantity.Size = new System.Drawing.Size(283, 20);
            this.txtORQuantity.TabIndex = 2;
            // 
            // labSQuantity
            // 
            this.labSQuantity.AutoSize = true;
            this.labSQuantity.Location = new System.Drawing.Point(485, 36);
            this.labSQuantity.Name = "labSQuantity";
            this.labSQuantity.Size = new System.Drawing.Size(46, 13);
            this.labSQuantity.TabIndex = 0;
            this.labSQuantity.Text = "Quantity";
            // 
            // dtpORdate
            // 
            this.dtpORdate.Location = new System.Drawing.Point(97, 37);
            this.dtpORdate.Name = "dtpORdate";
            this.dtpORdate.Size = new System.Drawing.Size(322, 20);
            this.dtpORdate.TabIndex = 1;
            // 
            // labSItem
            // 
            this.labSItem.AutoSize = true;
            this.labSItem.Location = new System.Drawing.Point(6, 84);
            this.labSItem.Name = "labSItem";
            this.labSItem.Size = new System.Drawing.Size(30, 13);
            this.labSItem.TabIndex = 0;
            this.labSItem.Text = "Drug";
            // 
            // labSDate
            // 
            this.labSDate.AutoSize = true;
            this.labSDate.Location = new System.Drawing.Point(6, 37);
            this.labSDate.Name = "labSDate";
            this.labSDate.Size = new System.Drawing.Size(30, 13);
            this.labSDate.TabIndex = 0;
            this.labSDate.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSDone);
            this.groupBox2.Controls.Add(this.txtORCustomerPhone);
            this.groupBox2.Controls.Add(this.txtORCustomerName);
            this.groupBox2.Controls.Add(this.labCustomerTelephone);
            this.groupBox2.Controls.Add(this.labSCustomerName);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // btnSDone
            // 
            this.btnSDone.Location = new System.Drawing.Point(665, 59);
            this.btnSDone.Name = "btnSDone";
            this.btnSDone.Size = new System.Drawing.Size(75, 23);
            this.btnSDone.TabIndex = 2;
            this.btnSDone.Text = "Add";
            this.btnSDone.UseVisualStyleBackColor = true;
            this.btnSDone.Click += new System.EventHandler(this.btnSDone_Click);
            // 
            // txtORCustomerPhone
            // 
            this.txtORCustomerPhone.Location = new System.Drawing.Point(586, 33);
            this.txtORCustomerPhone.Name = "txtORCustomerPhone";
            this.txtORCustomerPhone.Size = new System.Drawing.Size(268, 20);
            this.txtORCustomerPhone.TabIndex = 1;
            // 
            // txtORCustomerName
            // 
            this.txtORCustomerName.Location = new System.Drawing.Point(133, 33);
            this.txtORCustomerName.Name = "txtORCustomerName";
            this.txtORCustomerName.Size = new System.Drawing.Size(262, 20);
            this.txtORCustomerName.TabIndex = 1;
            // 
            // labCustomerTelephone
            // 
            this.labCustomerTelephone.AutoSize = true;
            this.labCustomerTelephone.Location = new System.Drawing.Point(460, 33);
            this.labCustomerTelephone.Name = "labCustomerTelephone";
            this.labCustomerTelephone.Size = new System.Drawing.Size(105, 13);
            this.labCustomerTelephone.TabIndex = 0;
            this.labCustomerTelephone.Text = "Customer Telephone";
            // 
            // labSCustomerName
            // 
            this.labSCustomerName.AutoSize = true;
            this.labSCustomerName.Location = new System.Drawing.Point(6, 33);
            this.labSCustomerName.Name = "labSCustomerName";
            this.labSCustomerName.Size = new System.Drawing.Size(82, 13);
            this.labSCustomerName.TabIndex = 0;
            this.labSCustomerName.Text = "Customer Name";
            // 
            // project
            // 
            this.project.DataSetName = "Project";
            this.project.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugsBindingSource
            // 
            this.drugsBindingSource.DataMember = "Drugs";
            this.drugsBindingSource.DataSource = this.project;
            // 
            // drugsTableAdapter
            // 
            this.drugsTableAdapter.ClearBeforeFill = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 304);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbORDrug;
        private System.Windows.Forms.TextBox txtORQuantity;
        private System.Windows.Forms.Label labSQuantity;
        private System.Windows.Forms.DateTimePicker dtpORdate;
        private System.Windows.Forms.Label labSItem;
        private System.Windows.Forms.Label labSDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSDone;
        private System.Windows.Forms.TextBox txtORCustomerPhone;
        private System.Windows.Forms.TextBox txtORCustomerName;
        private System.Windows.Forms.Label labCustomerTelephone;
        private System.Windows.Forms.Label labSCustomerName;
        private Project project;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private ProjectTableAdapters.DrugsTableAdapter drugsTableAdapter;
    }
}