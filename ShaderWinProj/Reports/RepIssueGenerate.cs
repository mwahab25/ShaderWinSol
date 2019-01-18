using CrystalDecisions.Shared;
using ShaderWinProj.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaderWinProj.Reports
{
    public partial class RepIssueGenerate : Form
    {
        Connection con = new Connection();

        public RepIssueGenerate()
        {
            InitializeComponent();
        }

        private void RepIssueGenerate_Load(object sender, EventArgs e)
        {
            RepIssue c1 = new RepIssue();
            c1.SetDataSource(con.SelectProc("SalesIssue_View_SelectByno", new string[] { "issueno" }, Sales.issue_no));
            crystalReportViewer1.ReportSource = c1;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            crystalReportViewer1.Refresh();
        }
    }
}
