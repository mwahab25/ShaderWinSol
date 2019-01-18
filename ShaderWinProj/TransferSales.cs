using ShaderWinProj.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaderWinProj
{
    public partial class TransferSales : Form
    {
        Connection con = new Connection();
        string new_no;

        public TransferSales()
        {
            InitializeComponent();
        }

        private void TransferSales_Load(object sender, EventArgs e)
        {
            new_no = NextNo();
            //comboBox_pno.Text = new_no;

            DataTable AllIssueno = con.SelectProc("Distribute_h_selectallno", null, null);
            DataRow dr1 = AllIssueno.NewRow();
            dr1["dist_no"] = new_no;
            //dr1["add_no"] = "0";
            AllIssueno.Rows.InsertAt(dr1, 0);
            comboBox_pno.DisplayMember = "dist_no";
            comboBox_pno.ValueMember = "dist_no";
            comboBox_pno.DataSource = AllIssueno;

            comboBox_type.SelectedIndex = 0;
            BindData();
            comboBox_unit.SelectedIndex = 0;
        }
        public void BindAva()
        {
            DataTable Av = con.SelectProc("Dist_AvaliableQty", new string[] { "code" }, comboBox_item.SelectedValue);
            if (Av.Rows.Count > 0)
            {
                label_ava.Text = Av.Rows[0][0].ToString();
            }
        }

        public void Bindcontact(int id)
        {
            DataTable Allc = con.SelectProc("Contacts_Select", new string[] { "type" }, id);
            DataRow dr1 = Allc.NewRow();
            dr1["Name"] = "--اختر--";
            dr1["ID"] = "0";
            Allc.Rows.InsertAt(dr1, 0);
            comboBox_cust.DisplayMember = "Name";
            comboBox_cust.ValueMember = "ID";
            comboBox_cust.DataSource = Allc;
        }
        public void BindData()
        {
            Bindcontact(2);

            //DataTable Allcat = con.SelectProc("Cat_Select", null, null);
            //DataRow dr2 = Allcat.NewRow();
            //dr2["Category_name"] = "--اختر--";
            //dr2["ID"] = "0";
            //Allcat.Rows.InsertAt(dr2, 0);
            //comboBox_Cat.DisplayMember = "Category_name";
            //comboBox_Cat.ValueMember = "ID";
            //comboBox_Cat.DataSource = Allcat;

            DataTable Alli = con.SelectProc("Items_SelectByCat", new string[] { "id" }, 1);
            DataRow dr2 = Alli.NewRow();
            dr2["Item_name"] = "--اختر--";
            dr2["Item_code"] = "0";
            Alli.Rows.InsertAt(dr2, 0);
            comboBox_item.DisplayMember = "Item_name";
            comboBox_item.ValueMember = "Item_code";
            comboBox_item.DataSource = Alli;
        }
        public string NextNo()
        {
            string add_no = "";
            int add_no_int = 0;

            DataTable dt = con.SelectProc("Distribute_SelectTopNo", null, null);

            if (dt.Rows.Count > 0)
                add_no = dt.Rows[0][0].ToString().Trim();
            string nadd_no = "";

            if (dt.Rows.Count > 0)
            {
                add_no_int = int.Parse(add_no);
                add_no_int += 1;
                int add_no_int_len = add_no_int.ToString().Length;
                int remender_zero_part_len = 10 - add_no_int_len;
                string remender_zero_part = "";
                for (int i = 0; i < remender_zero_part_len; i++)
                {
                    remender_zero_part += "0";
                }
                nadd_no = remender_zero_part + add_no_int.ToString();
            }
            else
            {
                nadd_no = "0000000000";
            }
            return nadd_no;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            decimal wei = Convert.ToDecimal(textBox_weight.Text);
            decimal pri = Convert.ToDecimal(textBox_price.Text);
            decimal tax = Convert.ToDecimal(textBox_tax.Text);
            int qty = Convert.ToInt32(textBox_qty.Text);
            if (comboBox_type.SelectedIndex==0)
            {
                if (comboBox_cust.SelectedIndex != 0 && textBox_qty.Value != 0 && !string.IsNullOrEmpty(this.textBox_weight.Text) && !string.IsNullOrEmpty(this.textBox_price.Text) && !string.IsNullOrEmpty(this.textBox_tax.Text))
                {
                    dataGridView_items.Rows.Add(1, comboBox_type.Text, comboBox_cust.SelectedValue, comboBox_cust.Text, qty, textBox_weight.Text, wei * pri, qty*tax);
                }
            }
            else
            {
                if (comboBox_cust.SelectedIndex != 0 && textBox_qty.Value != 0 && !string.IsNullOrEmpty(this.textBox_weight.Text) && !string.IsNullOrEmpty(this.textBox_price.Text) && !string.IsNullOrEmpty(this.textBox_tax.Text))
                {
                    dataGridView_items.Rows.Add(1, comboBox_type.Text, comboBox_cust.SelectedValue, comboBox_cust.Text, qty, textBox_weight.Text, wei * pri, qty * tax);
                }
            }
            
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            new_no = NextNo();
            comboBox_pno.Text = new_no;

            comboBox_cust.SelectedIndex = 0;
            //comboBox_Cat.SelectedIndex = 0;
            comboBox_item.SelectedIndex = 0;
            textBox_qty.Value = 0;
            dataGridView_items.Rows.Clear();
            textBox_weight.Text = "";
            textBox_price.Text = "";
            button_save.Enabled = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SqlConnection Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Shader"].ConnectionString);

            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }

            SqlTransaction tr;
            tr = Cn.BeginTransaction();

            try
            {

                if (dataGridView_items.Rows.Count > 0)
                {
                    foreach (DataGridViewRow R in dataGridView_items.Rows)
                    {
                        SqlCommand Run2 = new SqlCommand("Distribute_r_Insert", Cn, tr);
                        Run2.CommandType = CommandType.StoredProcedure;

                        Run2.Parameters.AddWithValue("@dist_no", new_no);
                        Run2.Parameters.AddWithValue("@type", R.Cells[1].Value);
                        Run2.Parameters.AddWithValue("@contactid", R.Cells[2].Value);
                        Run2.Parameters.AddWithValue("@qty", Convert.ToInt32(R.Cells[4].Value));
                        Run2.Parameters.AddWithValue("@unit", "جوال");
                        Run2.Parameters.AddWithValue("@weight", R.Cells[5].Value);
                        Run2.Parameters.AddWithValue("@unitprice", Convert.ToDecimal(R.Cells[6].Value)/ Convert.ToDecimal(R.Cells[5].Value));
                        Run2.Parameters.AddWithValue("@totalprice",Convert.ToDecimal(R.Cells[6].Value));
                        Run2.Parameters.AddWithValue("@tax", Convert.ToDecimal(R.Cells[7].Value));

                        Run2.ExecuteNonQuery();
                    }

                    SqlCommand Run1 = new SqlCommand("Distribute_h_Insert", Cn, tr);
                    Run1.CommandType = CommandType.StoredProcedure;

                    Run1.Parameters.AddWithValue("@dist_no", new_no);
                    Run1.Parameters.AddWithValue("@userid", Login.User);
                    Run1.Parameters.AddWithValue("@adddate", dateTimePicker_adddate.Value);
                    Run1.Parameters.AddWithValue("@code", comboBox_item.SelectedValue);

                    Run1.ExecuteNonQuery();

                    tr.Commit();
                    MessageBox.Show("تمت العملية بنجاح");
                    button_save.Enabled = false;
                    Cn.Close();

                }
                else
                {
                    MessageBox.Show("لا يوجد اصناف");
                }

            }
            catch
            {
                MessageBox.Show("حدث خطأ ما ، تأكد من صحة البيانات");
                tr.Rollback();
            }
        }

        private void button_report_Click(object sender, EventArgs e)
        {

        }

        private void button_addsup_Click(object sender, EventArgs e)
        {
            Customers s = new Customers();
            s.Show();
        }

        private void button_ref_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void comboBox_Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Alli = con.SelectProc("Items_SelectByCat", new string[] { "id" }, comboBox_Cat.SelectedValue);
            DataRow dr2 = Alli.NewRow();
            dr2["Item_name"] = "--اختر--";
            dr2["Item_code"] = "0";
            Alli.Rows.InsertAt(dr2, 0);
            comboBox_item.DisplayMember = "Item_name";
            comboBox_item.ValueMember = "Item_code";
            comboBox_item.DataSource = Alli;
        }

        private void comboBox_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindAva();
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_type.SelectedIndex == 0)
            {
                label5.Visible = false;
                button_addsup.Visible = false;
                button_ref.Visible = false;

                label3.Visible = true;
                Bindcontact(2);
            }
            else
            {
                label5.Visible = true;
                button_addsup.Visible = true;
                button_ref.Visible = true;

                label3.Visible = false;
                Bindcontact(1);
            }
        }

        private void comboBox_pno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView_items.Rows.Count > 0)
            {
                dataGridView_items.Rows.Clear();
            }

            DataTable Allc = con.SelectProc("Distribute_View_SelectByno", new string[] { "no" }, comboBox_pno.SelectedValue);
            if (Allc.Rows.Count > 0)
            {
                dateTimePicker_adddate.Value =Convert.ToDateTime(Allc.Rows[0][2].ToString());
                comboBox_item.SelectedValue = Allc.Rows[0][3].ToString();

                for (int i = 0; i < Allc.Rows.Count; i++)
                {
                    dataGridView_items.Rows.Add(1, Allc.Rows[i][12].ToString(), Allc.Rows[i][10].ToString(), Allc.Rows[i][11].ToString(), Allc.Rows[i][5].ToString(), Allc.Rows[i][7].ToString(), Allc.Rows[i][9].ToString(), Allc.Rows[i][13].ToString());

                }
            }
        }
    }
}
