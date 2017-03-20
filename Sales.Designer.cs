namespace SEProject
{
    partial class Sales
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
            this.dtpSDEXPIRYDATE = new System.Windows.Forms.DateTimePicker();
            this.laEStkXPIRINGDATE = new System.Windows.Forms.Label();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.cmbSDrug = new System.Windows.Forms.ComboBox();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project = new SEProject.Project();
            this.txtSTotalAmount = new System.Windows.Forms.TextBox();
            this.txtSStockAvailable = new System.Windows.Forms.TextBox();
            this.labSAmount = new System.Windows.Forms.Label();
            this.txtSPrice = new System.Windows.Forms.TextBox();
            this.labStkAvailable = new System.Windows.Forms.Label();
            this.txtSQuantity = new System.Windows.Forms.TextBox();
            this.labSPrice = new System.Windows.Forms.Label();
            this.labSQuantity = new System.Windows.Forms.Label();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.labSItem = new System.Windows.Forms.Label();
            this.labSDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSDone = new System.Windows.Forms.Button();
            this.txtSCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtSCutomerName = new System.Windows.Forms.TextBox();
            this.labCustomerTelephone = new System.Windows.Forms.Label();
            this.labSCustomerName = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.drugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new SEProject.ProjectTableAdapters.SalesTableAdapter();
            this.drugsTableAdapter = new SEProject.ProjectTableAdapters.DrugsTableAdapter();
            this.btnFee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFee);
            this.groupBox1.Controls.Add(this.dtpSDEXPIRYDATE);
            this.groupBox1.Controls.Add(this.laEStkXPIRINGDATE);
            this.groupBox1.Controls.Add(this.btnSSearch);
            this.groupBox1.Controls.Add(this.cmbSDrug);
            this.groupBox1.Controls.Add(this.txtSTotalAmount);
            this.groupBox1.Controls.Add(this.txtSStockAvailable);
            this.groupBox1.Controls.Add(this.labSAmount);
            this.groupBox1.Controls.Add(this.txtSPrice);
            this.groupBox1.Controls.Add(this.labStkAvailable);
            this.groupBox1.Controls.Add(this.txtSQuantity);
            this.groupBox1.Controls.Add(this.labSPrice);
            this.groupBox1.Controls.Add(this.labSQuantity);
            this.groupBox1.Controls.Add(this.dtpSDate);
            this.groupBox1.Controls.Add(this.labSItem);
            this.groupBox1.Controls.Add(this.labSDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drug Details";
            // 
            // dtpSDEXPIRYDATE
            // 
            this.dtpSDEXPIRYDATE.Location = new System.Drawing.Point(102, 181);
            this.dtpSDEXPIRYDATE.Name = "dtpSDEXPIRYDATE";
            this.dtpSDEXPIRYDATE.Size = new System.Drawing.Size(317, 20);
            this.dtpSDEXPIRYDATE.TabIndex = 6;
            // 
            // laEStkXPIRINGDATE
            // 
            this.laEStkXPIRINGDATE.AutoSize = true;
            this.laEStkXPIRINGDATE.Location = new System.Drawing.Point(6, 184);
            this.laEStkXPIRINGDATE.Name = "laEStkXPIRINGDATE";
            this.laEStkXPIRINGDATE.Size = new System.Drawing.Size(81, 13);
            this.laEStkXPIRINGDATE.TabIndex = 5;
            this.laEStkXPIRINGDATE.Text = "EXPIRY DATE:";
            // 
            // btnSSearch
            // 
            this.btnSSearch.Location = new System.Drawing.Point(664, 174);
            this.btnSSearch.Name = "btnSSearch";
            this.btnSSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSSearch.TabIndex = 4;
            this.btnSSearch.Text = "Search";
            this.btnSSearch.UseVisualStyleBackColor = true;
            this.btnSSearch.Click += new System.EventHandler(this.btnSSearch_Click);
            // 
            // cmbSDrug
            // 
            this.cmbSDrug.DataSource = this.drugsBindingSource;
            this.cmbSDrug.DisplayMember = "Name";
            this.cmbSDrug.FormattingEnabled = true;
            this.cmbSDrug.Location = new System.Drawing.Point(97, 82);
            this.cmbSDrug.Name = "cmbSDrug";
            this.cmbSDrug.Size = new System.Drawing.Size(322, 21);
            this.cmbSDrug.TabIndex = 3;
            this.cmbSDrug.ValueMember = "Name";
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
            // txtSTotalAmount
            // 
            this.txtSTotalAmount.Location = new System.Drawing.Point(586, 136);
            this.txtSTotalAmount.Name = "txtSTotalAmount";
            this.txtSTotalAmount.Size = new System.Drawing.Size(283, 20);
            this.txtSTotalAmount.TabIndex = 2;
            // 
            // txtSStockAvailable
            // 
            this.txtSStockAvailable.Location = new System.Drawing.Point(97, 133);
            this.txtSStockAvailable.Name = "txtSStockAvailable";
            this.txtSStockAvailable.Size = new System.Drawing.Size(322, 20);
            this.txtSStockAvailable.TabIndex = 2;
            // 
            // labSAmount
            // 
            this.labSAmount.AutoSize = true;
            this.labSAmount.Location = new System.Drawing.Point(482, 140);
            this.labSAmount.Name = "labSAmount";
            this.labSAmount.Size = new System.Drawing.Size(98, 13);
            this.labSAmount.TabIndex = 0;
            this.labSAmount.Text = "Total Amount(GH₵)";
            // 
            // txtSPrice
            // 
            this.txtSPrice.Location = new System.Drawing.Point(586, 36);
            this.txtSPrice.Name = "txtSPrice";
            this.txtSPrice.Size = new System.Drawing.Size(283, 20);
            this.txtSPrice.TabIndex = 2;
            // 
            // labStkAvailable
            // 
            this.labStkAvailable.AutoSize = true;
            this.labStkAvailable.Location = new System.Drawing.Point(6, 136);
            this.labStkAvailable.Name = "labStkAvailable";
            this.labStkAvailable.Size = new System.Drawing.Size(50, 26);
            this.labStkAvailable.TabIndex = 0;
            this.labStkAvailable.Text = "Stock \r\nAvailable";
            // 
            // txtSQuantity
            // 
            this.txtSQuantity.Location = new System.Drawing.Point(586, 83);
            this.txtSQuantity.Name = "txtSQuantity";
            this.txtSQuantity.Size = new System.Drawing.Size(283, 20);
            this.txtSQuantity.TabIndex = 2;
            this.txtSQuantity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labSPrice
            // 
            this.labSPrice.AutoSize = true;
            this.labSPrice.Location = new System.Drawing.Point(495, 36);
            this.labSPrice.Name = "labSPrice";
            this.labSPrice.Size = new System.Drawing.Size(59, 13);
            this.labSPrice.TabIndex = 0;
            this.labSPrice.Text = "Price(GH₵)";
            // 
            // labSQuantity
            // 
            this.labSQuantity.AutoSize = true;
            this.labSQuantity.Location = new System.Drawing.Point(495, 83);
            this.labSQuantity.Name = "labSQuantity";
            this.labSQuantity.Size = new System.Drawing.Size(46, 13);
            this.labSQuantity.TabIndex = 0;
            this.labSQuantity.Text = "Quantity";
            // 
            // dtpSDate
            // 
            this.dtpSDate.Location = new System.Drawing.Point(97, 37);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(322, 20);
            this.dtpSDate.TabIndex = 1;
            this.dtpSDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.groupBox2.Controls.Add(this.txtSCustomerPhone);
            this.groupBox2.Controls.Add(this.txtSCutomerName);
            this.groupBox2.Controls.Add(this.labCustomerTelephone);
            this.groupBox2.Controls.Add(this.labSCustomerName);
            this.groupBox2.Location = new System.Drawing.Point(11, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // btnSDone
            // 
            this.btnSDone.Location = new System.Drawing.Point(665, 59);
            this.btnSDone.Name = "btnSDone";
            this.btnSDone.Size = new System.Drawing.Size(75, 23);
            this.btnSDone.TabIndex = 2;
            this.btnSDone.Text = "Done";
            this.btnSDone.UseVisualStyleBackColor = true;
            this.btnSDone.Click += new System.EventHandler(this.btnSDone_Click);
            // 
            // txtSCustomerPhone
            // 
            this.txtSCustomerPhone.Location = new System.Drawing.Point(586, 33);
            this.txtSCustomerPhone.Name = "txtSCustomerPhone";
            this.txtSCustomerPhone.Size = new System.Drawing.Size(268, 20);
            this.txtSCustomerPhone.TabIndex = 1;
            // 
            // txtSCutomerName
            // 
            this.txtSCutomerName.Location = new System.Drawing.Point(133, 33);
            this.txtSCutomerName.Name = "txtSCutomerName";
            this.txtSCutomerName.Size = new System.Drawing.Size(262, 20);
            this.txtSCutomerName.TabIndex = 1;
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
            // dgvSales
            // 
            this.dgvSales.AutoGenerateColumns = false;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drugDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.stockAvailableDataGridViewTextBoxColumn,
            this.priceGHDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerTelephoneDataGridViewTextBoxColumn});
            this.dgvSales.DataSource = this.salesBindingSource;
            this.dgvSales.Location = new System.Drawing.Point(12, 328);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(915, 314);
            this.dgvSales.TabIndex = 2;
            // 
            // drugDataGridViewTextBoxColumn
            // 
            this.drugDataGridViewTextBoxColumn.DataPropertyName = "Drug";
            this.drugDataGridViewTextBoxColumn.HeaderText = "Drug";
            this.drugDataGridViewTextBoxColumn.Name = "drugDataGridViewTextBoxColumn";
            this.drugDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // stockAvailableDataGridViewTextBoxColumn
            // 
            this.stockAvailableDataGridViewTextBoxColumn.DataPropertyName = "StockAvailable";
            this.stockAvailableDataGridViewTextBoxColumn.HeaderText = "StockAvailable";
            this.stockAvailableDataGridViewTextBoxColumn.Name = "stockAvailableDataGridViewTextBoxColumn";
            // 
            // priceGHDataGridViewTextBoxColumn
            // 
            this.priceGHDataGridViewTextBoxColumn.DataPropertyName = "Price(GH₵)";
            this.priceGHDataGridViewTextBoxColumn.HeaderText = "Price(GH₵)";
            this.priceGHDataGridViewTextBoxColumn.Name = "priceGHDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerTelephoneDataGridViewTextBoxColumn
            // 
            this.customerTelephoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerTelephone";
            this.customerTelephoneDataGridViewTextBoxColumn.HeaderText = "CustomerTelephone";
            this.customerTelephoneDataGridViewTextBoxColumn.Name = "customerTelephoneDataGridViewTextBoxColumn";
            this.customerTelephoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.project;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // drugsTableAdapter
            // 
            this.drugsTableAdapter.ClearBeforeFill = true;
            // 
            // btnFee
            // 
            this.btnFee.Location = new System.Drawing.Point(769, 174);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(75, 23);
            this.btnFee.TabIndex = 7;
            this.btnFee.Text = "Fee";
            this.btnFee.UseVisualStyleBackColor = true;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 654);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSTotalAmount;
        private System.Windows.Forms.TextBox txtSStockAvailable;
        private System.Windows.Forms.Label labSAmount;
        private System.Windows.Forms.TextBox txtSPrice;
        private System.Windows.Forms.Label labStkAvailable;
        private System.Windows.Forms.TextBox txtSQuantity;
        private System.Windows.Forms.Label labSPrice;
        private System.Windows.Forms.Label labSQuantity;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.Label labSItem;
        private System.Windows.Forms.Label labSDate;
        private System.Windows.Forms.ComboBox cmbSDrug;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSDone;
        private System.Windows.Forms.TextBox txtSCustomerPhone;
        private System.Windows.Forms.TextBox txtSCutomerName;
        private System.Windows.Forms.Label labCustomerTelephone;
        private System.Windows.Forms.Label labSCustomerName;
        private System.Windows.Forms.DataGridView dgvSales;
        private Project project;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private ProjectTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private ProjectTableAdapters.DrugsTableAdapter drugsTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpSDEXPIRYDATE;
        private System.Windows.Forms.Label laEStkXPIRINGDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnFee;
    }
}