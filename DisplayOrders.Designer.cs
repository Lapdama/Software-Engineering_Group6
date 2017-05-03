namespace SEProject
{
    partial class DisplayOrders
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
            this.dgDisplayOrders = new System.Windows.Forms.DataGridView();
            this.project = new SEProject.Project();
            this.noticesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noticesTableAdapter = new SEProject.ProjectTableAdapters.NoticesTableAdapter();
            this.drugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplayOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDisplayOrders
            // 
            this.dgDisplayOrders.AutoGenerateColumns = false;
            this.dgDisplayOrders.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDisplayOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplayOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drugDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerTelephoneDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgDisplayOrders.DataSource = this.noticesBindingSource;
            this.dgDisplayOrders.Location = new System.Drawing.Point(13, 13);
            this.dgDisplayOrders.Name = "dgDisplayOrders";
            this.dgDisplayOrders.Size = new System.Drawing.Size(855, 354);
            this.dgDisplayOrders.TabIndex = 0;
            // 
            // project
            // 
            this.project.DataSetName = "Project";
            this.project.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noticesBindingSource
            // 
            this.noticesBindingSource.DataMember = "Notices";
            this.noticesBindingSource.DataSource = this.project;
            // 
            // noticesTableAdapter
            // 
            this.noticesTableAdapter.ClearBeforeFill = true;
            // 
            // drugDataGridViewTextBoxColumn
            // 
            this.drugDataGridViewTextBoxColumn.DataPropertyName = "Drug";
            this.drugDataGridViewTextBoxColumn.HeaderText = "Drug";
            this.drugDataGridViewTextBoxColumn.Name = "drugDataGridViewTextBoxColumn";
            this.drugDataGridViewTextBoxColumn.Width = 180;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // customerTelephoneDataGridViewTextBoxColumn
            // 
            this.customerTelephoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerTelephone";
            this.customerTelephoneDataGridViewTextBoxColumn.HeaderText = "CustomerTelephone";
            this.customerTelephoneDataGridViewTextBoxColumn.Name = "customerTelephoneDataGridViewTextBoxColumn";
            this.customerTelephoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // DisplayOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 477);
            this.Controls.Add(this.dgDisplayOrders);
            this.Name = "DisplayOrders";
            this.Text = "DisplayOrders";
            this.Load += new System.EventHandler(this.DisplayOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplayOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDisplayOrders;
        private Project project;
        private System.Windows.Forms.BindingSource noticesBindingSource;
        private ProjectTableAdapters.NoticesTableAdapter noticesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}