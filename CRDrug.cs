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
    public partial class CRDrug : Form
    {
        public CRDrug()
        {
            InitializeComponent();
                        
            // Create an instance of Datatable and the Report

            DataTable oba = new DataTable();
            CRDRUGS rpt = new CRDRUGS();

            //An instance of the table adapter to retrieve the records
            ProjectTableAdapters.DrugsTableAdapter ob = new ProjectTableAdapters.DrugsTableAdapter();

            oba = ob.GetData();

            rpt.SetDataSource(oba);

            crystalReportViewer1.ReportSource = rpt;

        }

        private void CRDrug_Load(object sender, EventArgs e)
        {

        }
    }
}
