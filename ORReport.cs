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
    public partial class ORReport : Form
    {
        public ORReport()
        {
            InitializeComponent();

            // Create an instance of Datatable and the Report
            DataTable oba = new DataTable();
            CROrders rpt = new CROrders();

            //An instance of the table adapter to retrieve the records
            ProjectTableAdapters.NoticesTableAdapter ob = new ProjectTableAdapters.NoticesTableAdapter();

            oba = ob.GetData();

            rpt.SetDataSource(oba);

            crystalReportViewer1.ReportSource = rpt;
        }        
    }
}
