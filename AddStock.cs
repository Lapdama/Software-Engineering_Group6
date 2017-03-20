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
    public partial class AddStock : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string connstr = "Data Source=LORD;Initial Catalog = SE; Integrated Security = True";

        public AddStock()
        {
            InitializeComponent();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project.Shelf' table. You can move, or remove it, as needed.
            this.shelfTableAdapter.Fill(this.project.Shelf);
            // TODO: This line of code loads data into the 'project.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.project.Category);
            // TODO: This line of code loads data into the 'project.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.project.Drugs);

        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(connstr);
                da.SelectCommand = new SqlCommand("Select * from Drugs where Name = '" + txtStkNAME.Text + "'", conn);
                ds.Clear();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        txtStkNAME.Text = dr[0].ToString();
                        txtStkPRICE.Text = dr[1].ToString();
                        dtpStkEXPIRYDATE.Text = dr[2].ToString();
                        cmbxStkSHELF.Text = dr[3].ToString();
                        cmbxStkCATEGORY.Text = dr[4].ToString();
                        txtStkQUANTITY.Text = dr[5].ToString();
                        txtQuantity.Text = dr[5].ToString();

                    }
                }

                else
                {
                    MessageBox.Show("Drug name  does not exist");
                }
            }

            catch (Exception)
            {
                // throw;
                MessageBox.Show("You are not doing something right");
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            // Updating records            
            try
            {
                // Connecting to database
                SqlConnection conn = new SqlConnection(connstr);
                da.UpdateCommand = new SqlCommand("UPDATE Drugs SET Name= @Name,[Price(GH₵)]= @Price,ExDate =@ExDate,Shelf= @Shelf,Category =@Category,Quantity =@Quantity WHERE Name= @Name", conn);

                //Assigning variables to parameters                                                                                                  
                da.UpdateCommand.Parameters.AddWithValue("@Name", txtStkNAME.Text);
                da.UpdateCommand.Parameters.AddWithValue("@Price", txtStkPRICE.Text);
                da.UpdateCommand.Parameters.AddWithValue("@ExDate", Convert.ToDateTime(dtpStkEXPIRYDATE.Text));
                da.UpdateCommand.Parameters.AddWithValue("@Shelf", cmbxStkSHELF.SelectedValue);
                da.UpdateCommand.Parameters.AddWithValue("@Category", cmbxStkCATEGORY.SelectedValue);
                da.UpdateCommand.Parameters.AddWithValue("@Quantity", txtStkQUANTITY.Text);
               

                //Opening Connection
                conn.Open();
                da.UpdateCommand.ExecuteNonQuery();
                conn.Close();

                //Clearing records
                txtStkNAME.Text = "";//clears text box
                txtStkPRICE.Text = "";//clears text box 
                txtStkQUANTITY.Text = "";//clears text box  
                txtQuantity.Text = "";//clears text box 
                txtADDSTOCK.Text = "";//clears text box                 
                txtStkNAME.Focus();// focuses cursor 



                // Calling method
                dgDisplay();
            }
            catch (Exception)

            {
                throw;
                // MessageBox.Show("YOU ARE NOT DOING SOMETHING RIGHT");
            }
        }

        //Creating a new method
        public void dgDisplay()
        {
            SqlConnection conn = new SqlConnection(connstr);
            da.SelectCommand = new SqlCommand("Select * from Drugs", conn);

            //Makes you clear data
            ds.Clear();

            //Makes you fill with data
            da.Fill(ds);

            //Sends data to gridview
            dgDisplayAddStock.DataSource = ds.Tables[0];
        }

        private void Region_Load(object sender, EventArgs e)
        {
            //calls method
            dgDisplay();
        }

        private void btnCALCULATE_Click(object sender, EventArgs e)
        {
            // Initializing variables  and making calculations         
            Double result = Convert.ToInt32(txtQuantity.Text) + Convert.ToDouble(txtADDSTOCK.Text);
          //  Double total = Convert.ToInt32(txtStkQUANTITY);

            // Assigning results to quantity's text box
            txtStkQUANTITY.Text = Convert.ToString(result);
            txtQuantity.Text = Convert.ToString(result);
            
        }

        private void dgDisplayAddStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
