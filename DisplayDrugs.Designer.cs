namespace SEProject
{
    partial class DisplayDrugs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project = new SEProject.Project();
            this.drugsTableAdapter = new SEProject.ProjectTableAdapters.DrugsTableAdapter();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceGHDataGridViewTextBoxColumn,
            this.exDateDataGridViewTextBoxColumn,
            this.shelfDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.drugsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1123, 495);
            this.dataGridView1.TabIndex = 0;
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
            // drugsTableAdapter
            // 
            this.drugsTableAdapter.ClearBeforeFill = true;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = this.project;
            this.projectBindingSource.Position = 0;
            // 
            // drugsBindingSource1
            // 
            this.drugsBindingSource1.DataMember = "Drugs";
            this.drugsBindingSource1.DataSource = this.project;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceGHDataGridViewTextBoxColumn
            // 
            this.priceGHDataGridViewTextBoxColumn.DataPropertyName = "Price(GH₵)";
            this.priceGHDataGridViewTextBoxColumn.HeaderText = "Price(GH₵)";
            this.priceGHDataGridViewTextBoxColumn.Name = "priceGHDataGridViewTextBoxColumn";
            // 
            // exDateDataGridViewTextBoxColumn
            // 
            this.exDateDataGridViewTextBoxColumn.DataPropertyName = "ExDate";
            this.exDateDataGridViewTextBoxColumn.HeaderText = "ExDate";
            this.exDateDataGridViewTextBoxColumn.Name = "exDateDataGridViewTextBoxColumn";
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "Shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "Shelf";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // DisplayDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 507);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DisplayDrugs";
            this.Text = "DisplayDrugs";
            this.Load += new System.EventHandler(this.DisplayDrugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Project project;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private ProjectTableAdapters.DrugsTableAdapter drugsTableAdapter;
        private System.Windows.Forms.BindingSource drugsBindingSource1;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}