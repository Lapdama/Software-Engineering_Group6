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
    public partial class SReport : Form
    {
        public SReport()
        {
            InitializeComponent();

            // Create an instance of Datatable and the Report
            DataTable oba = new DataTable();
            CRSales rpt = new CRSales();

            //An instance of the table adapter to retrieve the records
            ProjectTableAdapters.SalesTableAdapter ob = new ProjectTableAdapters.SalesTableAdapter();

            oba = ob.GetData();

            rpt.SetDataSource(oba);

            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
