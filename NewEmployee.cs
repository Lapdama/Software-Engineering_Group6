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
    public partial class NewEmployee : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string connstr = "Data Source=(localdb)\\v11.0;Initial Catalog = SE; Integrated Security = True";

        public NewEmployee()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labDOB_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Saving records

            try
            {
                // Gender codes
                string gender = "";
                if (rbFemale.Checked == true)
                {
                    gender = "Female";
                }

                else
                {
                    gender = "Male";
                }

                // Connecting to database
                SqlConnection conn = new SqlConnection(connstr);
                da.InsertCommand = new SqlCommand("Insert into Employee values(@Username,@Password, @Fname, @Lname, @DOB, @Gender, @Telephone, @Address, @DOJ, @Salary)", conn);

                //Assigning variables to parameters                                                                                                  
                da.InsertCommand.Parameters.AddWithValue("@Username", txtUsername.Text);
                da.InsertCommand.Parameters.AddWithValue("@Password", txtPassword.Text);
                da.InsertCommand.Parameters.AddWithValue("@Fname", txtfname.Text);
                da.InsertCommand.Parameters.AddWithValue("@Lname", txtlname.Text);
                da.InsertCommand.Parameters.AddWithValue("@DOB", Convert.ToDateTime(dtppickerdob.Text));
                da.InsertCommand.Parameters.AddWithValue("@Gender", gender);
                da.InsertCommand.Parameters.AddWithValue("@Telephone", txttel.Text);
                da.InsertCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                da.InsertCommand.Parameters.AddWithValue("@DOJ", Convert.ToDateTime(dtpickerDOJ.Text));
                da.InsertCommand.Parameters.AddWithValue("@Salary", txtSalary.Text);

                //Opening Connection
                conn.Open();
                da.InsertCommand.ExecuteNonQuery();
                conn.Close();

                //Clearing records
                txtUsername.Text = "";//clears text box
                txtPassword.Text = "";//clears text box
                txtfname.Text = "";//clears text box
                txtlname.Text = "";//clears text box
                gender = "";//clears gender
                txttel.Text = "";//clears text box
                txtAddress.Text = "";//clears text box
                txtSalary.Text = "";//clears text box
                txtfname.Focus();// focuses cursor 

                // Calling method
                dgDisplay();
            }
            catch (Exception)

            {
               // throw;
                MessageBox.Show("YOU ARE NOT DOING SOMETHING RIGHT");
            }

        }

        //Creating a new method
        public void dgDisplay()
        {
            SqlConnection conn = new SqlConnection(connstr);
            da.SelectCommand = new SqlCommand("Select * from Employee", conn);

            //Makes you clear data
            ds.Clear();

            //Makes you fill with data
            da.Fill(ds);

            //Sends data to gridview
            dgbEmployee.DataSource = ds.Tables[0];
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            //calls method
            dgDisplay();
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.project.Employee);

        }
    }
}
