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
    public partial class Orders : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string connstr = "Data Source=LORD;Initial Catalog = SE; Integrated Security = True";
        public Orders()
        {
            InitializeComponent();
        }

        private void btnSDone_Click(object sender, EventArgs e)
        {
            // Saving records

            try
            {

                // Connecting to database
                SqlConnection conn = new SqlConnection(connstr);
                da.InsertCommand = new SqlCommand("Insert into Notices values(@Drug,@Date, @CustomerName, @CustomerTelephone, @Quantity)", conn);


                //Assigning variables to parameters                                                                                                  
                da.InsertCommand.Parameters.AddWithValue("@Drug", cmbORDrug.Text);
                da.InsertCommand.Parameters.AddWithValue("@Date", dtpORdate.Text);
                da.InsertCommand.Parameters.AddWithValue("@CustomerName", txtORCustomerName.Text);
                da.InsertCommand.Parameters.AddWithValue("@CustomerTelephone", txtORCustomerPhone.Text);
                da.InsertCommand.Parameters.AddWithValue("@Quantity", txtORQuantity.Text);



                //Opening Connection
                conn.Open();
                da.InsertCommand.ExecuteNonQuery();
                conn.Close();

                //Clearing records
                cmbORDrug.Text = "";//clears text box
                dtpORdate.Text = "";//clears text box 
                txtORCustomerName.Text = "";//clears text box   
                txtORCustomerPhone.Text = "";//clears text box 
                txtORQuantity.Text = "";//clears text box    
                cmbORDrug.Focus();// focuses cursor 

                MessageBox.Show("Order Saved");


            }
            catch (Exception)

            {
               throw;
               // MessageBox.Show("YOU ARE NOT DOING SOMETHING RIGHT");
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.project.Drugs);

        }
    }
}
