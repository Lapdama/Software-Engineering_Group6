using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEProject
{
    public partial class DisplayDrugs : Form
    {
        public DisplayDrugs()
        {
            InitializeComponent();
        }

        private void DisplayDrugs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.project.Drugs);
            // TODO: This line of code loads data into the 'project.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.project.Drugs);

        }
    }
}
