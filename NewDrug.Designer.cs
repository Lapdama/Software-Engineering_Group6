namespace SEProject
{
    partial class NewDrug
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
            this.btnSAVE = new System.Windows.Forms.Button();
            this.cmbxCATEGORY = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project = new SEProject.Project();
            this.cmbxSHELF = new System.Windows.Forms.ComboBox();
            this.shelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpEXPIRYDATE = new System.Windows.Forms.DateTimePicker();
            this.laEXPIRINGDATE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.laSHELF = new System.Windows.Forms.Label();
            this.txtDQUANTITY = new System.Windows.Forms.TextBox();
            this.laQUANTITY = new System.Windows.Forms.Label();
            this.txtDRPRICE = new System.Windows.Forms.TextBox();
            this.laPRICE = new System.Windows.Forms.Label();
            this.txtDRNAME = new System.Windows.Forms.TextBox();
            this.laDRUGNAME = new System.Windows.Forms.Label();
            this.laAVAILABLEDRUGS = new System.Windows.Forms.Label();
            this.dgvNDR = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelfTableAdapter = new SEProject.ProjectTableAdapters.ShelfTableAdapter();
            this.categoryTableAdapter = new SEProject.ProjectTableAdapters.CategoryTableAdapter();
            this.drugsTableAdapter = new SEProject.ProjectTableAdapters.DrugsTableAdapter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSAVE);
            this.groupBox1.Controls.Add(this.cmbxCATEGORY);
            this.groupBox1.Controls.Add(this.cmbxSHELF);
            this.groupBox1.Controls.Add(this.dtpEXPIRYDATE);
            this.groupBox1.Controls.Add(this.laEXPIRINGDATE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.laSHELF);
            this.groupBox1.Controls.Add(this.txtDQUANTITY);
            this.groupBox1.Controls.Add(this.laQUANTITY);
            this.groupBox1.Controls.Add(this.txtDRPRICE);
            this.groupBox1.Controls.Add(this.laPRICE);
            this.groupBox1.Controls.Add(this.txtDRNAME);
            this.groupBox1.Controls.Add(this.laDRUGNAME);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DRUG DETAILS";
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(662, 153);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(75, 23);
            this.btnSAVE.TabIndex = 4;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // cmbxCATEGORY
            // 
            this.cmbxCATEGORY.DataSource = this.categoryBindingSource;
            this.cmbxCATEGORY.DisplayMember = "CategoryName";
            this.cmbxCATEGORY.FormattingEnabled = true;
            this.cmbxCATEGORY.Location = new System.Drawing.Point(614, 32);
            this.cmbxCATEGORY.Name = "cmbxCATEGORY";
            this.cmbxCATEGORY.Size = new System.Drawing.Size(335, 21);
            this.cmbxCATEGORY.TabIndex = 3;
            this.cmbxCATEGORY.ValueMember = "CategoryName";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.project;
            // 
            // project
            // 
            this.project.DataSetName = "Project";
            this.project.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbxSHELF
            // 
            this.cmbxSHELF.FormattingEnabled = true;
            this.cmbxSHELF.Location = new System.Drawing.Point(89, 131);
            this.cmbxSHELF.Name = "cmbxSHELF";
            this.cmbxSHELF.Size = new System.Drawing.Size(375, 21);
            this.cmbxSHELF.TabIndex = 3;
            // 
            // shelfBindingSource
            // 
            this.shelfBindingSource.DataMember = "Shelf";
            this.shelfBindingSource.DataSource = this.project;
            // 
            // dtpEXPIRYDATE
            // 
            this.dtpEXPIRYDATE.Location = new System.Drawing.Point(614, 80);
            this.dtpEXPIRYDATE.Name = "dtpEXPIRYDATE";
            this.dtpEXPIRYDATE.Size = new System.Drawing.Size(335, 20);
            this.dtpEXPIRYDATE.TabIndex = 2;
            // 
            // laEXPIRINGDATE
            // 
            this.laEXPIRINGDATE.AutoSize = true;
            this.laEXPIRINGDATE.Location = new System.Drawing.Point(518, 83);
            this.laEXPIRINGDATE.Name = "laEXPIRINGDATE";
            this.laEXPIRINGDATE.Size = new System.Drawing.Size(81, 13);
            this.laEXPIRINGDATE.TabIndex = 0;
            this.laEXPIRINGDATE.Text = "EXPIRY DATE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "CATEGORY:";
            // 
            // laSHELF
            // 
            this.laSHELF.AutoSize = true;
            this.laSHELF.Location = new System.Drawing.Point(6, 131);
            this.laSHELF.Name = "laSHELF";
            this.laSHELF.Size = new System.Drawing.Size(44, 13);
            this.laSHELF.TabIndex = 0;
            this.laSHELF.Text = "SHELF:";
            // 
            // txtDQUANTITY
            // 
            this.txtDQUANTITY.Location = new System.Drawing.Point(614, 124);
            this.txtDQUANTITY.Name = "txtDQUANTITY";
            this.txtDQUANTITY.Size = new System.Drawing.Size(335, 20);
            this.txtDQUANTITY.TabIndex = 1;
            // 
            // laQUANTITY
            // 
            this.laQUANTITY.AutoSize = true;
            this.laQUANTITY.Location = new System.Drawing.Point(522, 127);
            this.laQUANTITY.Name = "laQUANTITY";
            this.laQUANTITY.Size = new System.Drawing.Size(65, 13);
            this.laQUANTITY.TabIndex = 0;
            this.laQUANTITY.Text = "QUANTITY:";
            // 
            // txtDRPRICE
            // 
            this.txtDRPRICE.Location = new System.Drawing.Point(89, 80);
            this.txtDRPRICE.Name = "txtDRPRICE";
            this.txtDRPRICE.Size = new System.Drawing.Size(375, 20);
            this.txtDRPRICE.TabIndex = 1;
            // 
            // laPRICE
            // 
            this.laPRICE.AutoSize = true;
            this.laPRICE.Location = new System.Drawing.Point(6, 83);
            this.laPRICE.Name = "laPRICE";
            this.laPRICE.Size = new System.Drawing.Size(42, 13);
            this.laPRICE.TabIndex = 0;
            this.laPRICE.Text = "PRICE:";
            // 
            // txtDRNAME
            // 
            this.txtDRNAME.Location = new System.Drawing.Point(89, 33);
            this.txtDRNAME.Name = "txtDRNAME";
            this.txtDRNAME.Size = new System.Drawing.Size(375, 20);
            this.txtDRNAME.TabIndex = 1;
            // 
            // laDRUGNAME
            // 
            this.laDRUGNAME.AutoSize = true;
            this.laDRUGNAME.Location = new System.Drawing.Point(6, 36);
            this.laDRUGNAME.Name = "laDRUGNAME";
            this.laDRUGNAME.Size = new System.Drawing.Size(41, 13);
            this.laDRUGNAME.TabIndex = 0;
            this.laDRUGNAME.Text = "NAME:";
            // 
            // laAVAILABLEDRUGS
            // 
            this.laAVAILABLEDRUGS.AutoSize = true;
            this.laAVAILABLEDRUGS.Location = new System.Drawing.Point(434, 208);
            this.laAVAILABLEDRUGS.Name = "laAVAILABLEDRUGS";
            this.laAVAILABLEDRUGS.Size = new System.Drawing.Size(106, 13);
            this.laAVAILABLEDRUGS.TabIndex = 0;
            this.laAVAILABLEDRUGS.Text = "AVAILABLE DRUGS";
            // 
            // dgvNDR
            // 
            this.dgvNDR.AllowUserToAddRows = false;
            this.dgvNDR.AllowUserToDeleteRows = false;
            this.dgvNDR.AutoGenerateColumns = false;
            this.dgvNDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNDR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceGHDataGridViewTextBoxColumn,
            this.exDateDataGridViewTextBoxColumn,
            this.shelfDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvNDR.DataSource = this.drugsBindingSource;
            this.dgvNDR.Location = new System.Drawing.Point(21, 239);
            this.dgvNDR.Name = "dgvNDR";
            this.dgvNDR.ReadOnly = true;
            this.dgvNDR.Size = new System.Drawing.Size(946, 242);
            this.dgvNDR.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceGHDataGridViewTextBoxColumn
            // 
            this.priceGHDataGridViewTextBoxColumn.DataPropertyName = "Price(GH₵)";
            this.priceGHDataGridViewTextBoxColumn.HeaderText = "Price(GH₵)";
            this.priceGHDataGridViewTextBoxColumn.Name = "priceGHDataGridViewTextBoxColumn";
            this.priceGHDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceGHDataGridViewTextBoxColumn.Width = 150;
            // 
            // exDateDataGridViewTextBoxColumn
            // 
            this.exDateDataGridViewTextBoxColumn.DataPropertyName = "ExDate";
            this.exDateDataGridViewTextBoxColumn.HeaderText = "ExDate";
            this.exDateDataGridViewTextBoxColumn.Name = "exDateDataGridViewTextBoxColumn";
            this.exDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.exDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "Shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "Shelf";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            this.shelfDataGridViewTextBoxColumn.ReadOnly = true;
            this.shelfDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // drugsBindingSource
            // 
            this.drugsBindingSource.DataMember = "Drugs";
            this.drugsBindingSource.DataSource = this.project;
            // 
            // shelfTableAdapter
            // 
            this.shelfTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // drugsTableAdapter
            // 
            this.drugsTableAdapter.ClearBeforeFill = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // NewDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 493);
            this.Controls.Add(this.dgvNDR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.laAVAILABLEDRUGS);
            this.Name = "NewDrug";
            this.Text = "New Drug";
            this.Load += new System.EventHandler(this.NewDrug_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbxCATEGORY;
        private System.Windows.Forms.ComboBox cmbxSHELF;
        private System.Windows.Forms.DateTimePicker dtpEXPIRYDATE;
        private System.Windows.Forms.Label laEXPIRINGDATE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label laSHELF;
        private System.Windows.Forms.TextBox txtDRPRICE;
        private System.Windows.Forms.Label laPRICE;
        private System.Windows.Forms.TextBox txtDRNAME;
        private System.Windows.Forms.Label laDRUGNAME;
        private System.Windows.Forms.Label laAVAILABLEDRUGS;
        private System.Windows.Forms.DataGridView dgvNDR;
        private System.Windows.Forms.Button btnSAVE;
        private Project project;
        private System.Windows.Forms.BindingSource shelfBindingSource;
        private ProjectTableAdapters.ShelfTableAdapter shelfTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private ProjectTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.TextBox txtDQUANTITY;
        private System.Windows.Forms.Label laQUANTITY;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private ProjectTableAdapters.DrugsTableAdapter drugsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}