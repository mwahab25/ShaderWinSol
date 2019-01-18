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
    public partial class RepPurchases : Form
    {
        Connection con = new Connection();

        public RepPurchases()
        {
            InitializeComponent();
        }

        private void RepPurchases_Load(object sender, EventArgs e)
        {
            ParameterFields fields = new ParameterFields();

            //ParameterField field1 = new ParameterField();
            ParameterField field2 = new ParameterField();
            ParameterField field3 = new ParameterField();
            //ParameterField field4 = new ParameterField();
            //ParameterField field5 = new ParameterField();

            //ParameterDiscreteValue val1 = new ParameterDiscreteValue();
            ParameterDiscreteValue val2 = new ParameterDiscreteValue();
            ParameterDiscreteValue val3 = new ParameterDiscreteValue();
            //ParameterDiscreteValue val4 = new ParameterDiscreteValue();
            //ParameterDiscreteValue val5 = new ParameterDiscreteValue();


            //val1.Value = ReportsColl.type;
            //field1.Name = "type";
            //field1.CurrentValues.Add(val1);
            //fields.Add(field1);

            val2.Value = ReportsColl.from;
            field2.Name = "from";
            field2.CurrentValues.Add(val2);
            fields.Add(field2);

            val3.Value = ReportsColl.to;
            field3.Name = "to";
            field3.CurrentValues.Add(val3);
            fields.Add(field3);

            //val4.Value = ReportsColl.item;
            //field4.Name = "item";
            //field4.CurrentValues.Add(val4);
            //fields.Add(field4);

            //val5.Value = ReportsColl.contact;
            //field5.Name = "contact";
            //field5.CurrentValues.Add(val5);
            //fields.Add(field5);

            if(ReportsColl.type== "daily_asc_peritem")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateItem", new string[] { "from", "to", "code" }, ReportsColl.from, ReportsColl.to, ReportsColl.item));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if(ReportsColl.type == "daily_asc_persup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateSup", new string[] { "from", "to", "contact" }, ReportsColl.from, ReportsColl.to, ReportsColl.contact));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if(ReportsColl.type == "daily_asc_peritemsup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateItemSup", new string[] { "from", "to", "contact", "code" }, ReportsColl.from, ReportsColl.to, ReportsColl.contact, ReportsColl.item));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "daily_asc_all")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDate", new string[] { "from", "to" }, ReportsColl.from, ReportsColl.to));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "daily_desc_peritem")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateItemdesc", new string[] { "from", "to", "code" }, ReportsColl.from, ReportsColl.to, ReportsColl.item));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "daily_desc_persup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateSupdesc", new string[] { "from", "to", "contact" }, ReportsColl.from, ReportsColl.to, ReportsColl.contact));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "daily_desc_peritemsup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateItemSupdesc", new string[] { "from", "to", "contact", "code" }, ReportsColl.from, ReportsColl.to, ReportsColl.contact, ReportsColl.item));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "daily_desc_all")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDatedesc", new string[] { "from", "to" }, ReportsColl.from, ReportsColl.to));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "alldate_asc_peritem")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByItem", new string[] { "code" }, ReportsColl.item));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "alldate_asc_persup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByContact", new string[] { "contact" }, ReportsColl.contact));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "alldate_asc_peritemsup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByItemContact", new string[] { "code","contact" }, ReportsColl.item, ReportsColl.contact));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "alldate_asc_all")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_Select", null, null));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "alldate_desc_peritem")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByItemdesc", new string[] { "code" }, ReportsColl.item));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "alldate_desc_persup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByContactdesc", new string[] { "contact" }, ReportsColl.contact));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "alldate_desc_peritemsup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByItemContactdesc", new string[] { "code", "contact" }, ReportsColl.item, ReportsColl.contact));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "alldate_desc_all")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_Selectdesc", null, null));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "bydate_asc_peritem")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateItem", new string[] { "from", "to", "code" }, ReportsColl.from, ReportsColl.to, ReportsColl.item));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "bydate_asc_persup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateSup", new string[] { "from", "to", "contact" }, ReportsColl.from, ReportsColl.to, ReportsColl.contact));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "bydate_asc_peritemsup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateItemSup", new string[] { "from", "to", "contact","code" }, ReportsColl.from, ReportsColl.to, ReportsColl.contact, ReportsColl.item));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "bydate_asc_all")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDate", new string[] { "from", "to" }, ReportsColl.from, ReportsColl.to));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "bydate_desc_peritem")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateItemdesc", new string[] { "from", "to","code" }, ReportsColl.from, ReportsColl.to, ReportsColl.item));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "bydate_desc_persup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateSupdesc", new string[] { "from", "to", "contact" }, ReportsColl.from, ReportsColl.to, ReportsColl.contact));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "bydate_desc_peritemsup")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDateItemSupdesc", new string[] { "from", "to", "contact", "code" }, ReportsColl.from, ReportsColl.to, ReportsColl.contact, ReportsColl.item));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }
            else if (ReportsColl.type == "bydate_desc_all")
            {
                RepPurchases1 c1 = new RepPurchases1();
                c1.SetDataSource(con.SelectProc("Purchases_View_SelectByDatedesc", new string[] { "from", "to" }, ReportsColl.from, ReportsColl.to));
                crystalReportViewer1.ParameterFieldInfo = fields;
                crystalReportViewer1.ReportSource = c1;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                crystalReportViewer1.Refresh();
            }

        }
    }
}
