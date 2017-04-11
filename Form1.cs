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
    public partial class Form1 : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string connstr = "Data Source=LORD;Initial Catalog = SE; Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Logining in
            try
            {
                SqlConnection conn = new SqlConnection(connstr);
                da.SelectCommand = new SqlCommand("Select * from LoginOwner where UserName = '" + txtUserName.Text + "'and Password ='" + txtPassword.Text + "'", conn);
                ds.Clear();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Owner form = new Owner();
                    form.Show();
                }

                // else
                da.SelectCommand = new SqlCommand("Select * from Employee where UserName = '" + txtUserName.Text + "'and Password ='" + txtPassword.Text + "'", conn);
                ds.Clear();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    Employee form = new Employee();
                    form.Show();
                }
            }

            catch (Exception)
            {
                //throw
                MessageBox.Show("Username or Password incorrect");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                //Closing inventory window
                var result = MessageBox.Show("Are you sure you would like to exit?", "Closing Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

            catch (Exception)
            {
                //throw
                MessageBox.Show("You are not doing something right");
            }
            
        }
    }
    }

