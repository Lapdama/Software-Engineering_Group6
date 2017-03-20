namespace SEProject
{
    partial class AddStock
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
            this.btnSEARCH = new System.Windows.Forms.Button();
            this.dgDisplayAddStock = new System.Windows.Forms.DataGridView();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project = new SEProject.Project();
            this.laDRUG = new System.Windows.Forms.Label();
            this.drugsTableAdapter = new SEProject.ProjectTableAdapters.DrugsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.cmbxStkCATEGORY = new System.Windows.Forms.ComboBox();
            this.cmbxStkSHELF = new System.Windows.Forms.ComboBox();
            this.dtpStkEXPIRYDATE = new System.Windows.Forms.DateTimePicker();
            this.laEStkXPIRINGDATE = new System.Windows.Forms.Label();
            this.labStkCategory = new System.Windows.Forms.Label();
            this.laStkSHELF = new System.Windows.Forms.Label();
            this.txtStkQUANTITY = new System.Windows.Forms.TextBox();
            this.laStkQUANTITY = new System.Windows.Forms.Label();
            this.txtStkPRICE = new System.Windows.Forms.TextBox();
            this.laStkPRICE = new System.Windows.Forms.Label();
            this.txtStkNAME = new System.Windows.Forms.TextBox();
            this.laStkNAME = new System.Windows.Forms.Label();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new SEProject.ProjectTableAdapters.CategoryTableAdapter();
            this.shelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelfTableAdapter = new SEProject.ProjectTableAdapters.ShelfTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCALCULATE = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.laQuantity = new System.Windows.Forms.Label();
            this.txtADDSTOCK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplayAddStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.Location = new System.Drawing.Point(644, 150);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(75, 23);
            this.btnSEARCH.TabIndex = 2;
            this.btnSEARCH.Text = "SEARCH";
            this.btnSEARCH.UseVisualStyleBackColor = true;
            this.btnSEARCH.Click += new System.EventHandler(this.btnSEARCH_Click);
            // 
            // dgDisplayAddStock
            // 
            this.dgDisplayAddStock.AutoGenerateColumns = false;
            this.dgDisplayAddStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplayAddStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceGHDataGridViewTextBoxColumn,
            this.exDateDataGridViewTextBoxColumn,
            this.shelfDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgDisplayAddStock.DataSource = this.drugsBindingSource;
            this.dgDisplayAddStock.Location = new System.Drawing.Point(12, 222);
            this.dgDisplayAddStock.Name = "dgDisplayAddStock";
            this.dgDisplayAddStock.Size = new System.Drawing.Size(1183, 303);
            this.dgDisplayAddStock.TabIndex = 3;
            this.dgDisplayAddStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDisplayAddStock_CellContentClick);
            // 
            // drugsBindingSource
            // 
            this.drugsBindingSource.DataMember = "Drugs";
            this.drugsBindingSource.DataSource = this.project;
            // 
            // project
            // 
            this.project.DataSetName = "Project";
            this.project.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laDRUG
            // 
            this.laDRUG.AutoSize = true;
            this.laDRUG.Location = new System.Drawing.Point(477, 195);
            this.laDRUG.Name = "laDRUG";
            this.laDRUG.Size = new System.Drawing.Size(39, 13);
            this.laDRUG.TabIndex = 4;
            this.laDRUG.Text = "DRUG";
            // 
            // drugsTableAdapter
            // 
            this.drugsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUPDATE);
            this.groupBox1.Controls.Add(this.btnSEARCH);
            this.groupBox1.Controls.Add(this.cmbxStkCATEGORY);
            this.groupBox1.Controls.Add(this.cmbxStkSHELF);
            this.groupBox1.Controls.Add(this.dtpStkEXPIRYDATE);
            this.groupBox1.Controls.Add(this.laEStkXPIRINGDATE);
            this.groupBox1.Controls.Add(this.labStkCategory);
            this.groupBox1.Controls.Add(this.laStkSHELF);
            this.groupBox1.Controls.Add(this.txtStkQUANTITY);
            this.groupBox1.Controls.Add(this.laStkQUANTITY);
            this.groupBox1.Controls.Add(this.txtStkPRICE);
            this.groupBox1.Controls.Add(this.laStkPRICE);
            this.groupBox1.Controls.Add(this.txtStkNAME);
            this.groupBox1.Controls.Add(this.laStkNAME);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DRUG DETAILS";
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(776, 150);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(75, 23);
            this.btnUPDATE.TabIndex = 4;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // cmbxStkCATEGORY
            // 
            this.cmbxStkCATEGORY.DataSource = this.categoryBindingSource;
            this.cmbxStkCATEGORY.DisplayMember = "CategoryName";
            this.cmbxStkCATEGORY.FormattingEnabled = true;
            this.cmbxStkCATEGORY.Location = new System.Drawing.Point(614, 32);
            this.cmbxStkCATEGORY.Name = "cmbxStkCATEGORY";
            this.cmbxStkCATEGORY.Size = new System.Drawing.Size(335, 21);
            this.cmbxStkCATEGORY.TabIndex = 3;
            this.cmbxStkCATEGORY.ValueMember = "CategoryName";
            // 
            // cmbxStkSHELF
            // 
            this.cmbxStkSHELF.DataSource = this.shelfBindingSource;
            this.cmbxStkSHELF.DisplayMember = "ShelfName";
            this.cmbxStkSHELF.FormattingEnabled = true;
            this.cmbxStkSHELF.Location = new System.Drawing.Point(89, 131);
            this.cmbxStkSHELF.Name = "cmbxStkSHELF";
            this.cmbxStkSHELF.Size = new System.Drawing.Size(375, 21);
            this.cmbxStkSHELF.TabIndex = 3;
            this.cmbxStkSHELF.ValueMember = "ShelfName";
            // 
            // dtpStkEXPIRYDATE
            // 
            this.dtpStkEXPIRYDATE.Location = new System.Drawing.Point(614, 80);
            this.dtpStkEXPIRYDATE.Name = "dtpStkEXPIRYDATE";
            this.dtpStkEXPIRYDATE.Size = new System.Drawing.Size(335, 20);
            this.dtpStkEXPIRYDATE.TabIndex = 2;
            // 
            // laEStkXPIRINGDATE
            // 
            this.laEStkXPIRINGDATE.AutoSize = true;
            this.laEStkXPIRINGDATE.Location = new System.Drawing.Point(518, 83);
            this.laEStkXPIRINGDATE.Name = "laEStkXPIRINGDATE";
            this.laEStkXPIRINGDATE.Size = new System.Drawing.Size(81, 13);
            this.laEStkXPIRINGDATE.TabIndex = 0;
            this.laEStkXPIRINGDATE.Text = "EXPIRY DATE:";
            // 
            // labStkCategory
            // 
            this.labStkCategory.AutoSize = true;
            this.labStkCategory.Location = new System.Drawing.Point(518, 36);
            this.labStkCategory.Name = "labStkCategory";
            this.labStkCategory.Size = new System.Drawing.Size(69, 13);
            this.labStkCategory.TabIndex = 0;
            this.labStkCategory.Text = "CATEGORY:";
            // 
            // laStkSHELF
            // 
            this.laStkSHELF.AutoSize = true;
            this.laStkSHELF.Location = new System.Drawing.Point(6, 131);
            this.laStkSHELF.Name = "laStkSHELF";
            this.laStkSHELF.Size = new System.Drawing.Size(44, 13);
            this.laStkSHELF.TabIndex = 0;
            this.laStkSHELF.Text = "SHELF:";
            // 
            // txtStkQUANTITY
            // 
            this.txtStkQUANTITY.Location = new System.Drawing.Point(614, 124);
            this.txtStkQUANTITY.Name = "txtStkQUANTITY";
            this.txtStkQUANTITY.Size = new System.Drawing.Size(335, 20);
            this.txtStkQUANTITY.TabIndex = 1;
            // 
            // laStkQUANTITY
            // 
            this.laStkQUANTITY.AutoSize = true;
            this.laStkQUANTITY.Location = new System.Drawing.Point(522, 127);
            this.laStkQUANTITY.Name = "laStkQUANTITY";
            this.laStkQUANTITY.Size = new System.Drawing.Size(65, 13);
            this.laStkQUANTITY.TabIndex = 0;
            this.laStkQUANTITY.Text = "QUANTITY:";
            // 
            // txtStkPRICE
            // 
            this.txtStkPRICE.Location = new System.Drawing.Point(89, 80);
            this.txtStkPRICE.Name = "txtStkPRICE";
            this.txtStkPRICE.Size = new System.Drawing.Size(375, 20);
            this.txtStkPRICE.TabIndex = 1;
            // 
            // laStkPRICE
            // 
            this.laStkPRICE.AutoSize = true;
            this.laStkPRICE.Location = new System.Drawing.Point(6, 83);
            this.laStkPRICE.Name = "laStkPRICE";
            this.laStkPRICE.Size = new System.Drawing.Size(42, 13);
            this.laStkPRICE.TabIndex = 0;
            this.laStkPRICE.Text = "PRICE:";
            // 
            // txtStkNAME
            // 
            this.txtStkNAME.Location = new System.Drawing.Point(89, 33);
            this.txtStkNAME.Name = "txtStkNAME";
            this.txtStkNAME.Size = new System.Drawing.Size(375, 20);
            this.txtStkNAME.TabIndex = 1;
            // 
            // laStkNAME
            // 
            this.laStkNAME.AutoSize = true;
            this.laStkNAME.Location = new System.Drawing.Point(6, 36);
            this.laStkNAME.Name = "laStkNAME";
            this.laStkNAME.Size = new System.Drawing.Size(41, 13);
            this.laStkNAME.TabIndex = 0;
            this.laStkNAME.Text = "NAME:";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.project;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // shelfBindingSource
            // 
            this.shelfBindingSource.DataMember = "Shelf";
            this.shelfBindingSource.DataSource = this.project;
            // 
            // shelfTableAdapter
            // 
            this.shelfTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCALCULATE);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.laQuantity);
            this.groupBox2.Controls.Add(this.txtADDSTOCK);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(992, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 173);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Make your calculations here";
            // 
            // btnCALCULATE
            // 
            this.btnCALCULATE.Location = new System.Drawing.Point(99, 121);
            this.btnCALCULATE.Name = "btnCALCULATE";
            this.btnCALCULATE.Size = new System.Drawing.Size(82, 23);
            this.btnCALCULATE.TabIndex = 12;
            this.btnCALCULATE.Text = "CALCULATE";
            this.btnCALCULATE.UseVisualStyleBackColor = true;
            this.btnCALCULATE.Click += new System.EventHandler(this.btnCALCULATE_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(80, 36);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(101, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // laQuantity
            // 
            this.laQuantity.AutoSize = true;
            this.laQuantity.Location = new System.Drawing.Point(11, 39);
            this.laQuantity.Name = "laQuantity";
            this.laQuantity.Size = new System.Drawing.Size(62, 13);
            this.laQuantity.TabIndex = 8;
            this.laQuantity.Text = "QUANTITY";
            // 
            // txtADDSTOCK
            // 
            this.txtADDSTOCK.Location = new System.Drawing.Point(80, 82);
            this.txtADDSTOCK.Name = "txtADDSTOCK";
            this.txtADDSTOCK.Size = new System.Drawing.Size(101, 20);
            this.txtADDSTOCK.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "STOCK";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 190;
            // 
            // priceGHDataGridViewTextBoxColumn
            // 
            this.priceGHDataGridViewTextBoxColumn.DataPropertyName = "Price(GH₵)";
            this.priceGHDataGridViewTextBoxColumn.HeaderText = "Price(GH₵)";
            this.priceGHDataGridViewTextBoxColumn.Name = "priceGHDataGridViewTextBoxColumn";
            this.priceGHDataGridViewTextBoxColumn.Width = 190;
            // 
            // exDateDataGridViewTextBoxColumn
            // 
            this.exDateDataGridViewTextBoxColumn.DataPropertyName = "ExDate";
            this.exDateDataGridViewTextBoxColumn.HeaderText = "ExDate";
            this.exDateDataGridViewTextBoxColumn.Name = "exDateDataGridViewTextBoxColumn";
            this.exDateDataGridViewTextBoxColumn.Width = 190;
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "Shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "Shelf";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            this.shelfDataGridViewTextBoxColumn.Width = 190;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 190;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 190;
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.laDRUG);
            this.Controls.Add(this.dgDisplayAddStock);
            this.Name = "AddStock";
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplayAddStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSEARCH;
        private System.Windows.Forms.DataGridView dgDisplayAddStock;
        private System.Windows.Forms.Label laDRUG;
        private Project project;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private ProjectTableAdapters.DrugsTableAdapter drugsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.ComboBox cmbxStkCATEGORY;
        private System.Windows.Forms.ComboBox cmbxStkSHELF;
        private System.Windows.Forms.DateTimePicker dtpStkEXPIRYDATE;
        private System.Windows.Forms.Label laEStkXPIRINGDATE;
        private System.Windows.Forms.Label labStkCategory;
        private System.Windows.Forms.Label laStkSHELF;
        private System.Windows.Forms.TextBox txtStkQUANTITY;
        private System.Windows.Forms.Label laStkQUANTITY;
        private System.Windows.Forms.TextBox txtStkPRICE;
        private System.Windows.Forms.Label laStkPRICE;
        private System.Windows.Forms.TextBox txtStkNAME;
        private System.Windows.Forms.Label laStkNAME;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private ProjectTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource shelfBindingSource;
        private ProjectTableAdapters.ShelfTableAdapter shelfTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCALCULATE;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label laQuantity;
        private System.Windows.Forms.TextBox txtADDSTOCK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}