using ShaderWinProj.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShaderWinProj.App_Code;

namespace ShaderWinProj
{
    public partial class ReportsColl : Form
    {
        Connection con = new Connection();

        public static DateTime from= new DateTime(2016, 01, 01);
        public static DateTime to=DateTime.Now;
        public static int contact=0;
        public static string item="";
        public static string type="";

        public ReportsColl()
        {
            InitializeComponent();
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            comboBox_filter.SelectedIndex = 0;

            DataTable Allcat = con.SelectProc("Cat_Select", null, null);
            DataRow dr2 = Allcat.NewRow();
            dr2["Category_name"] = "--اختر--";
            dr2["ID"] = "0";
            Allcat.Rows.InsertAt(dr2, 0);
            comboBox_purcat.DisplayMember = "Category_name";
            comboBox_purcat.ValueMember = "ID";
            comboBox_purcat.DataSource = Allcat;

            DataTable Allcat2 = con.SelectProc("Cat_Select", null, null);
            DataRow dr = Allcat2.NewRow();
            dr["Category_name"] = "--اختر--";
            dr["ID"] = "0";
            Allcat2.Rows.InsertAt(dr, 0);
            comboBox_distcat.DisplayMember = "Category_name";
            comboBox_distcat.ValueMember = "ID";
            comboBox_distcat.DataSource = Allcat2;

            DataTable Allc = con.SelectProc("Contacts_Select", new string[] { "type" }, 0);
            DataRow dr1 = Allc.NewRow();
            dr1["Name"] = "--اختر--";
            dr1["ID"] = "0";
            Allc.Rows.InsertAt(dr1, 0);
            comboBox_pursup.DisplayMember = "Name";
            comboBox_pursup.ValueMember = "ID";
            comboBox_pursup.DataSource = Allc;

            DataTable Allcs = con.SelectProc("Contacts_Select", new string[] { "type" }, 1);
            DataRow drc = Allcs.NewRow();
            drc["Name"] = "--اختر--";
            drc["ID"] = "0";
            Allcs.Rows.InsertAt(drc, 0);
            comboBox_distcust.DisplayMember = "Name";
            comboBox_distcust.ValueMember = "ID";
            comboBox_distcust.DataSource = Allcs;

            DataTable Allcs1 = con.SelectProc("Contacts_Select", new string[] { "type" }, 1);
            DataRow drc1 = Allcs1.NewRow();
            drc1["Name"] = "--اختر--";
            drc1["ID"] = "0";
            Allcs1.Rows.InsertAt(drc1, 0);
            comboBox_salescust.DisplayMember = "Name";
            comboBox_salescust.ValueMember = "ID";
            comboBox_salescust.DataSource = Allcs1;
        }

        private void checkBox_puritem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_puritem.Checked)
            {
                comboBox_purcat.Enabled = true;
                comboBox_puritem.Enabled = true;
            }
            else
            {
                comboBox_purcat.Enabled = false;
                comboBox_puritem.Enabled = false;


            }
        }
        private void checkBox_pursup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pursup.Checked)
            {
                comboBox_pursup.Enabled = true;
            }
            else
            {
                comboBox_pursup.Enabled = false;
            }
        }
        private void button_purshow_Click(object sender, EventArgs e)
        {
            if(radioButton_daily.Checked)
            {
                if(comboBox_filter.SelectedIndex==0)
                {
                    if(checkBox_puritem.Checked && !checkBox_pursup.Checked)
                    {
                        type = "daily_asc_peritem";
                        from = DateTime.Now;
                        to = DateTime.Now;
                        item = comboBox_puritem.SelectedValue.ToString();

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if(checkBox_pursup.Checked && !checkBox_puritem.Checked)
                    {
                        type = "daily_asc_persup";
                        from = DateTime.Now;
                        to = DateTime.Now;
                        contact =Convert.ToInt32(comboBox_pursup.SelectedValue);

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if (checkBox_puritem.Checked && checkBox_pursup.Checked)
                    {
                        type = "daily_asc_peritemsup";
                        from = DateTime.Now;
                        to = DateTime.Now;
                        item = comboBox_puritem.SelectedValue.ToString();
                        contact = Convert.ToInt32(comboBox_pursup.SelectedValue);

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else
                    {
                        type = "daily_asc_all";
                        from = DateTime.Now;
                        to = DateTime.Now;
                        
                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                }
                else
                {
                    if (checkBox_puritem.Checked && !checkBox_pursup.Checked)
                    {
                        type = "daily_desc_peritem";
                        from = DateTime.Now;
                        to = DateTime.Now;
                        item = comboBox_puritem.SelectedValue.ToString();

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if (checkBox_pursup.Checked && !checkBox_puritem.Checked)
                    {
                        type = "daily_desc_persup";
                        from = DateTime.Now;
                        to = DateTime.Now;
                        contact = Convert.ToInt32(comboBox_pursup.SelectedValue);

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if (checkBox_puritem.Checked && checkBox_pursup.Checked)
                    {
                        type = "daily_desc_peritemsup";
                        from = DateTime.Now;
                        to = DateTime.Now;
                        item = comboBox_puritem.SelectedValue.ToString();
                        contact = Convert.ToInt32(comboBox_pursup.SelectedValue);

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else
                    {
                        type = "daily_desc_all";
                        from = DateTime.Now;
                        to = DateTime.Now;

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                }
            }
            else if(radioButton_all.Checked)
            {
                if (comboBox_filter.SelectedIndex == 0)
                {
                    if (checkBox_puritem.Checked && !checkBox_pursup.Checked)
                    {
                        type = "alldate_asc_peritem";
                        item = comboBox_puritem.SelectedValue.ToString();

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if (checkBox_pursup.Checked && !checkBox_puritem.Checked)
                    {
                        type = "alldate_asc_persup";
                        contact = Convert.ToInt32(comboBox_pursup.SelectedValue);

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if (checkBox_puritem.Checked && checkBox_pursup.Checked)
                    {
                        type = "alldate_asc_peritemsup";
                        item = comboBox_puritem.SelectedValue.ToString();
                        contact = Convert.ToInt32(comboBox_pursup.SelectedValue);

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else
                    {
                        type = "alldate_asc_all";
                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                }
                else
                {
                    if (checkBox_puritem.Checked && !checkBox_pursup.Checked)
                    {
                        type = "alldate_desc_peritem";
                        item = comboBox_puritem.SelectedValue.ToString();

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if (checkBox_pursup.Checked && !checkBox_puritem.Checked)
                    {
                        type = "alldate_desc_persup";
                        contact = Convert.ToInt32(comboBox_pursup.SelectedValue);

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if (checkBox_puritem.Checked && checkBox_pursup.Checked)
                    {
                        type = "alldate_desc_peritemsup";
                        item = comboBox_puritem.SelectedValue.ToString();
                        contact = Convert.ToInt32(comboBox_pursup.SelectedValue);

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else
                    {
                        type = "alldate_desc_all";
                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                }
            }
            else if(radioButton_bydate.Checked)
            {
                if (comboBox_filter.SelectedIndex == 0)
                {
                    if (checkBox_puritem.Checked && !checkBox_pursup.Checked)
                    {
                        type = "bydate_asc_peritem";
                        item = comboBox_puritem.SelectedValue.ToString();
                        from = dateTimePicker_from.Value;
                        to = dateTimePicker_to.Value;
                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if (checkBox_pursup.Checked && !checkBox_puritem.Checked)
                    {
                        type = "bydate_asc_persup";
                        contact = Convert.ToInt32(comboBox_pursup.SelectedValue);
                        from = dateTimePicker_from.Value;
                        to = dateTimePicker_to.Value;
                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if (checkBox_puritem.Checked && checkBox_pursup.Checked)
                    {
                        type = "bydate_asc_peritemsup";
                        item = comboBox_puritem.SelectedValue.ToString();
                        contact = Convert.ToInt32(comboBox_pursup.SelectedValue);
                        from = dateTimePicker_from.Value;
                        to = dateTimePicker_to.Value;
                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else
                    {
                        type = "bydate_asc_all";
                        from = dateTimePicker_from.Value;
                        to = dateTimePicker_to.Value;
                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                }
                else
                {
                    if (checkBox_puritem.Checked &&!checkBox_pursup.Checked)
                    {
                        type = "bydate_desc_peritem";
                        item = comboBox_puritem.SelectedValue.ToString();
                        from = dateTimePicker_from.Value;
                        to = dateTimePicker_to.Value;
                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if (checkBox_pursup.Checked && !checkBox_puritem.Checked)
                    {
                        type = "bydate_desc_persup";
                        contact = Convert.ToInt32(comboBox_pursup.SelectedValue);
                        from = dateTimePicker_from.Value;
                        to = dateTimePicker_to.Value;

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else if (checkBox_puritem.Checked && checkBox_pursup.Checked)
                    {
                        type = "bydate_desc_peritemsup";
                        contact = Convert.ToInt32(comboBox_pursup.SelectedValue);
                        item = comboBox_puritem.SelectedValue.ToString();
                        from = dateTimePicker_from.Value;
                        to = dateTimePicker_to.Value;

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                    else
                    {
                        type = "bydate_desc_all";
                        from = dateTimePicker_from.Value;
                        to = dateTimePicker_to.Value;

                        RepPurchases r = new RepPurchases();
                        r.Show();
                    }
                }
            }

            
        }

        private void checkBox_distitem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_distitem.Checked)
            {
                comboBox_distcat.Enabled = true;
                comboBox_distitem.Enabled = true;
            }
            else
            {
                comboBox_distcat.Enabled = false;
                comboBox_distitem.Enabled = false;
            }
        }  
        private void checkBox_distcust_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_distcust.Checked)
            {
                comboBox_distcust.Enabled = true;
            }
            else
            {
                comboBox_distcust.Enabled = false;
            }
        }
        private void button_distshow_Click(object sender, EventArgs e)
        {
            if (radioButton_daily.Checked)
            {
                if (comboBox_filter.SelectedIndex == 0)
                {
                    if(checkBox_distitem.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if(checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if(checkBox_distitem.Checked && checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                }
                else
                {
                    if (checkBox_distitem.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if (checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if (checkBox_distitem.Checked && checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                }
            }
            else if (radioButton_all.Checked)
            {
                if (comboBox_filter.SelectedIndex == 0)
                {
                    if (checkBox_distitem.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if (checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if (checkBox_distitem.Checked && checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                }
                else
                {
                    if (checkBox_distitem.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if (checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if (checkBox_distitem.Checked && checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                }
            }
            else if (radioButton_bydate.Checked)
            {
                if (comboBox_filter.SelectedIndex == 0)
                {
                    if (checkBox_distitem.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if (checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if (checkBox_distitem.Checked && checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                }
                else
                {
                    if (checkBox_distitem.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if (checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else if (checkBox_distitem.Checked && checkBox_distcust.Checked)
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                    else
                    {
                        RepDist r = new RepDist();
                        r.Show();
                    }
                }
            }
            
        }

        private void checkBox_salescust_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_salescust.Checked)
                comboBox_salescust.Enabled = true;
            else
                comboBox_salescust.Enabled = false;
        }
        private void button_salesshow_Click(object sender, EventArgs e)
        {
            if (radioButton_daily.Checked)
            {
                if (comboBox_filter.SelectedIndex == 0)
                {
                    if(checkBox_salescust.Checked)
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                    else
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                }
                else
                {
                    if (checkBox_salescust.Checked)
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                    else
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                }
            }
            else if (radioButton_all.Checked)
            {
                if (comboBox_filter.SelectedIndex == 0)
                {
                    if (checkBox_salescust.Checked)
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                    else
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                }
                else
                {
                    if (checkBox_salescust.Checked)
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                    else
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                }
            }
            else if (radioButton_bydate.Checked)
            {
                if (comboBox_filter.SelectedIndex == 0)
                {
                    if (checkBox_salescust.Checked)
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                    else
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                }
                else
                {
                    if (checkBox_salescust.Checked)
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                    else
                    {
                        RepSales r = new RepSales();
                        r.Show();
                    }
                }
            }
            
        }

        private void comboBox_purcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Alli = con.SelectProc("Items_SelectByCat", new string[] { "id" }, comboBox_purcat.SelectedValue);
            DataRow dr2 = Alli.NewRow();
            dr2["Item_name"] = "--اختر--";
            dr2["Item_code"] = "0";
            Alli.Rows.InsertAt(dr2, 0);
            comboBox_puritem.DisplayMember = "Item_name";
            comboBox_puritem.ValueMember = "Item_code";
            comboBox_puritem.DataSource = Alli;
        }

        private void comboBox_distcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Alli = con.SelectProc("Items_SelectByCat", new string[] { "id" }, comboBox_distcat.SelectedValue);
            DataRow dr2 = Alli.NewRow();
            dr2["Item_name"] = "--اختر--";
            dr2["Item_code"] = "0";
            Alli.Rows.InsertAt(dr2, 0);
            comboBox_distitem.DisplayMember = "Item_name";
            comboBox_distitem.ValueMember = "Item_code";
            comboBox_distitem.DataSource = Alli;
        }
    }
}
