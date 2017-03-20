namespace SEProject
{
    partial class Purchases
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labPDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labPDrug = new System.Windows.Forms.Label();
            this.cmbPDrug = new System.Windows.Forms.ComboBox();
            this.labPQuantity = new System.Windows.Forms.Label();
            this.txtPDAvailable = new System.Windows.Forms.TextBox();
            this.labPPrice = new System.Windows.Forms.Label();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.labPTotalAmount = new System.Windows.Forms.Label();
            this.txtPTotalAmount = new System.Windows.Forms.TextBox();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPCost = new System.Windows.Forms.Button();
            this.labDDealer = new System.Windows.Forms.Label();
            this.cmbDDealer = new System.Windows.Forms.ComboBox();
            this.labPDQuantity = new System.Windows.Forms.Label();
            this.txtPDQuantity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPCost);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnPAdd);
            this.groupBox1.Controls.Add(this.txtPTotalAmount);
            this.groupBox1.Controls.Add(this.labPTotalAmount);
            this.groupBox1.Controls.Add(this.labDDealer);
            this.groupBox1.Controls.Add(this.txtPDQuantity);
            this.groupBox1.Controls.Add(this.labPDQuantity);
            this.groupBox1.Controls.Add(this.txtPPrice);
            this.groupBox1.Controls.Add(this.labPPrice);
            this.groupBox1.Controls.Add(this.txtPDAvailable);
            this.groupBox1.Controls.Add(this.labPQuantity);
            this.groupBox1.Controls.Add(this.cmbDDealer);
            this.groupBox1.Controls.Add(this.cmbPDrug);
            this.groupBox1.Controls.Add(this.labPDrug);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.labPDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchases Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labPDate
            // 
            this.labPDate.AutoSize = true;
            this.labPDate.Location = new System.Drawing.Point(6, 35);
            this.labPDate.Name = "labPDate";
            this.labPDate.Size = new System.Drawing.Size(30, 13);
            this.labPDate.TabIndex = 0;
            this.labPDate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // labPDrug
            // 
            this.labPDrug.AutoSize = true;
            this.labPDrug.Location = new System.Drawing.Point(9, 82);
            this.labPDrug.Name = "labPDrug";
            this.labPDrug.Size = new System.Drawing.Size(30, 13);
            this.labPDrug.TabIndex = 2;
            this.labPDrug.Text = "Drug";
            // 
            // cmbPDrug
            // 
            this.cmbPDrug.FormattingEnabled = true;
            this.cmbPDrug.Location = new System.Drawing.Point(84, 82);
            this.cmbPDrug.Name = "cmbPDrug";
            this.cmbPDrug.Size = new System.Drawing.Size(299, 21);
            this.cmbPDrug.TabIndex = 3;
            // 
            // labPQuantity
            // 
            this.labPQuantity.AutoSize = true;
            this.labPQuantity.Location = new System.Drawing.Point(6, 135);
            this.labPQuantity.Name = "labPQuantity";
            this.labPQuantity.Size = new System.Drawing.Size(50, 26);
            this.labPQuantity.TabIndex = 4;
            this.labPQuantity.Text = "Stock\r\nAvailable";
            // 
            // txtPDAvailable
            // 
            this.txtPDAvailable.Location = new System.Drawing.Point(84, 135);
            this.txtPDAvailable.Name = "txtPDAvailable";
            this.txtPDAvailable.Size = new System.Drawing.Size(299, 20);
            this.txtPDAvailable.TabIndex = 5;
            // 
            // labPPrice
            // 
            this.labPPrice.AutoSize = true;
            this.labPPrice.Location = new System.Drawing.Point(459, 35);
            this.labPPrice.Name = "labPPrice";
            this.labPPrice.Size = new System.Drawing.Size(59, 13);
            this.labPPrice.TabIndex = 4;
            this.labPPrice.Text = "Price(GH₵)";
            // 
            // txtPPrice
            // 
            this.txtPPrice.Location = new System.Drawing.Point(554, 35);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(299, 20);
            this.txtPPrice.TabIndex = 5;
            // 
            // labPTotalAmount
            // 
            this.labPTotalAmount.AutoSize = true;
            this.labPTotalAmount.Location = new System.Drawing.Point(450, 133);
            this.labPTotalAmount.Name = "labPTotalAmount";
            this.labPTotalAmount.Size = new System.Drawing.Size(98, 13);
            this.labPTotalAmount.TabIndex = 4;
            this.labPTotalAmount.Text = "Total Amount(GH₵)";
            // 
            // txtPTotalAmount
            // 
            this.txtPTotalAmount.Location = new System.Drawing.Point(554, 131);
            this.txtPTotalAmount.Name = "txtPTotalAmount";
            this.txtPTotalAmount.Size = new System.Drawing.Size(299, 20);
            this.txtPTotalAmount.TabIndex = 5;
            // 
            // btnPAdd
            // 
            this.btnPAdd.Location = new System.Drawing.Point(684, 173);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPAdd.TabIndex = 6;
            this.btnPAdd.Text = "Add";
            this.btnPAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(874, 240);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnPCost
            // 
            this.btnPCost.Location = new System.Drawing.Point(778, 173);
            this.btnPCost.Name = "btnPCost";
            this.btnPCost.Size = new System.Drawing.Size(75, 23);
            this.btnPCost.TabIndex = 6;
            this.btnPCost.Text = "Cost";
            this.btnPCost.UseVisualStyleBackColor = true;
            // 
            // labDDealer
            // 
            this.labDDealer.AutoSize = true;
            this.labDDealer.Location = new System.Drawing.Point(9, 194);
            this.labDDealer.Name = "labDDealer";
            this.labDDealer.Size = new System.Drawing.Size(38, 13);
            this.labDDealer.TabIndex = 4;
            this.labDDealer.Text = "Dealer";
            // 
            // cmbDDealer
            // 
            this.cmbDDealer.FormattingEnabled = true;
            this.cmbDDealer.Location = new System.Drawing.Point(84, 186);
            this.cmbDDealer.Name = "cmbDDealer";
            this.cmbDDealer.Size = new System.Drawing.Size(299, 21);
            this.cmbDDealer.TabIndex = 3;
            // 
            // labPDQuantity
            // 
            this.labPDQuantity.AutoSize = true;
            this.labPDQuantity.Location = new System.Drawing.Point(459, 79);
            this.labPDQuantity.Name = "labPDQuantity";
            this.labPDQuantity.Size = new System.Drawing.Size(46, 13);
            this.labPDQuantity.TabIndex = 4;
            this.labPDQuantity.Text = "Quantity";
            // 
            // txtPDQuantity
            // 
            this.txtPDQuantity.Location = new System.Drawing.Point(554, 79);
            this.txtPDQuantity.Name = "txtPDQuantity";
            this.txtPDQuantity.Size = new System.Drawing.Size(299, 20);
            this.txtPDQuantity.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(592, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Purchases";
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.Purchases_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.TextBox txtPTotalAmount;
        private System.Windows.Forms.Label labPTotalAmount;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.Label labPPrice;
        private System.Windows.Forms.TextBox txtPDAvailable;
        private System.Windows.Forms.Label labPQuantity;
        private System.Windows.Forms.ComboBox cmbPDrug;
        private System.Windows.Forms.Label labPDrug;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labPDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPCost;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labDDealer;
        private System.Windows.Forms.TextBox txtPDQuantity;
        private System.Windows.Forms.Label labPDQuantity;
        private System.Windows.Forms.ComboBox cmbDDealer;
    }
}