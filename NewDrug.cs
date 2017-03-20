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
    public partial class NewDrug : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string connstr = "Data Source=(localdb)\\v11.0;Initial Catalog = SE; Integrated Security = True";

        public NewDrug()
        {
            InitializeComponent();
        }

        private void NewDrug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.project.Drugs);
            // TODO: This line of code loads data into the 'project.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.project.Category);
            // TODO: This line of code loads data into the 'project.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.project.Category);
            // TODO: This line of code loads data into the 'project.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.project.Drugs);
            // TODO: This line of code loads data into the 'project.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.project.Drugs);
            // TODO: This line of code loads data into the 'project.Shelf' table. You can move, or remove it, as needed.
            this.shelfTableAdapter.Fill(this.project.Shelf);
            // TODO: This line of code loads data into the 'project.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.project.Category);

        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            // Saving records

            try
            {
                // Connecting to database
                SqlConnection conn = new SqlConnection(connstr);
                da.InsertCommand = new SqlCommand("Insert into Drugs values(@Name,@Price, @ExDate, @Shelf,  @Category, @Quantity)", conn);

                //Assigning variables to parameters                                                                                                  
                da.InsertCommand.Parameters.AddWithValue("@Name", txtDRNAME.Text);
                da.InsertCommand.Parameters.AddWithValue("@Price", txtDRPRICE.Text);
                da.InsertCommand.Parameters.AddWithValue("@ExDate", dtpEXPIRYDATE.Text);
                da.InsertCommand.Parameters.AddWithValue("@Shelf", cmbxSHELF.Text);
                da.InsertCommand.Parameters.AddWithValue("@Category", cmbxCATEGORY.Text);
                da.InsertCommand.Parameters.AddWithValue("@Quantity", txtDQUANTITY.Text);

                //Opening Connection
                conn.Open();
                da.InsertCommand.ExecuteNonQuery();
                conn.Close();

                //Clearing records
                txtDRNAME.Text = "";//clears text box
                txtDRPRICE.Text = "";//clears text box 
                txtDQUANTITY.Text = "";//clears text box                
                txtDRNAME.Focus();// focuses cursor 

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
            da.SelectCommand = new SqlCommand("Select * from Drugs", conn);

            //Makes you clear data
            ds.Clear();

            //Makes you fill with data
            da.Fill(ds);

            //Sends data to gridview
            dgvNDR.DataSource = ds.Tables[0];
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            //calls method
            dgdisplay();
        }
    }
}
