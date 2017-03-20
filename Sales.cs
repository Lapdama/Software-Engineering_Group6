using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SEProject
{
    public partial class Sales : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string connstr = "Data Source=LORD;Initial Catalog = SE; Integrated Security = True";

        public Sales()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.project.Drugs);
            // TODO: This line of code loads data into the 'project.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.project.Sales);

        }

        private void btnSDone_Click(object sender, EventArgs e)
        {
            // Saving records

            try
            {
                // Connecting to database
                SqlConnection conn = new SqlConnection(connstr);
                da.InsertCommand = new SqlCommand("Insert into Sales values(@Drug,@Date, @StockAvailable, @Price, @Quantity, @TotalAmount, @CustomerName, @CustomerTelephone)", conn);
                da.UpdateCommand = new SqlCommand("UPDATE Drugs SET Name= @Name, Quantity =@Quantity WHERE Name= @Name", conn);


                // Initializing variables  and making calculations         
                Double Stockleft = Convert.ToInt32(txtSStockAvailable.Text) - Convert.ToDouble(txtSQuantity.Text);
                //  Double total = Convert.ToInt32(txtStkQUANTITY);

                // Assigning results to quantity's text box
                txtSStockAvailable.Text = Convert.ToString(Stockleft);

                //Assigning variables to parameters                                                                                                  
                da.InsertCommand.Parameters.AddWithValue("@Drug", cmbSDrug.Text);
                da.InsertCommand.Parameters.AddWithValue("@Date", dtpSDate.Text);
                da.InsertCommand.Parameters.AddWithValue("@StockAvailable", txtSStockAvailable.Text);
                da.InsertCommand.Parameters.AddWithValue("@Price", txtSPrice.Text);
                da.InsertCommand.Parameters.AddWithValue("@Quantity", txtSQuantity.Text);
                da.InsertCommand.Parameters.AddWithValue("@TotalAmount", txtSTotalAmount.Text);
                da.InsertCommand.Parameters.AddWithValue("@CustomerName", txtSCutomerName.Text);
                da.InsertCommand.Parameters.AddWithValue("@CustomerTelephone", txtSCustomerPhone.Text);

                //Assigning variables to parameters                                                                                                  
                da.UpdateCommand.Parameters.AddWithValue("@Name", cmbSDrug.Text);
                da.UpdateCommand.Parameters.AddWithValue("@Quantity", txtSStockAvailable.Text);


                //Opening Connection
                conn.Open();
                da.UpdateCommand.ExecuteNonQuery();
                conn.Close();


                //Opening Connection
                conn.Open();
                da.InsertCommand.ExecuteNonQuery();
                conn.Close();

                //Clearing records
                txtSStockAvailable.Text = "";//clears text box
                txtSPrice.Text = "";//clears text box 
                txtSQuantity.Text = "";//clears text box   
                txtSTotalAmount.Text = "";//clears text box    
                txtSCutomerName.Text = "";//clears text box   
                txtSCustomerPhone.Text = "";//clears text box               
                txtSStockAvailable.Focus();// focuses cursor 

                //Calling method
                dgdisplay();
            }
            catch (Exception)

            {
                throw;
                // MessageBox.Show("YOU ARE NOT DOING SOMETHING RIGHT");
            }

        }

        //Creating a new method
        public void dgdisplay()
        {
            SqlConnection conn = new SqlConnection(connstr);
            da.SelectCommand = new SqlCommand("Select * from Sales", conn);

            //Makes you clear data
            ds.Clear();

            //Makes you fill with data
            da.Fill(ds);

            //Sends data to gridview
            dgvSales.DataSource = ds.Tables[0];
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            //calls method
            dgdisplay();
        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(connstr);
                da.SelectCommand = new SqlCommand("Select * from Drugs where Name = '" + cmbSDrug.Text + "'", conn);
                ds.Clear();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        cmbSDrug.Text = dr[0].ToString();
                        txtSPrice.Text = dr[1].ToString();
                        dtpSDEXPIRYDATE.Text = dr[2].ToString();
                        txtSStockAvailable.Text = dr[5].ToString();


                    }
                }
            }

            catch (Exception)
            {
                // throw;
                MessageBox.Show("Drug name does not exist");
            }
            this.dgdisplay();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            // Initializing variables  and making calculations         
            Double result = Convert.ToInt32(txtSPrice.Text) * Convert.ToDouble(txtSQuantity.Text);
            //  Double total = Convert.ToInt32(txtStkQUANTITY);

            // Assigning results to quantity's text box
            txtSTotalAmount.Text = Convert.ToString(result);

        }
    }
}
