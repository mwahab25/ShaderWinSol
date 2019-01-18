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
using System.Data.SqlClient;
using System.Configuration;

namespace ShaderWinProj
{
    public partial class Purchases : Form
    {
        Connection con = new Connection();
        string new_no;
        public Purchases()
        {
            InitializeComponent();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            new_no = NextNo();
            //comboBox_pno.Text = new_no;

            DataTable AllIssueno = con.SelectProc("Purchases_h_selectallno", null, null);
            DataRow dr1 = AllIssueno.NewRow();
            dr1["pur_no"] = new_no;
            //dr1["add_no"] = "0";
            AllIssueno.Rows.InsertAt(dr1, 0);
            comboBox_pno.DisplayMember = "pur_no";
            comboBox_pno.ValueMember = "pur_no";
            comboBox_pno.DataSource = AllIssueno;

            BindData();
            comboBox_User.Text = Login.User;
            comboBox_unit.SelectedIndex = 0;
        }

        public void BindData()
        {
            DataTable Allc = con.SelectProc("Contacts_Select", new string[] { "type" }, 0);
            DataRow dr1 = Allc.NewRow();
            dr1["Name"] = "--اختر--";
            dr1["ID"] = "0";
            Allc.Rows.InsertAt(dr1, 0);
            comboBox_Sup.DisplayMember = "Name";
            comboBox_Sup.ValueMember = "ID";
            comboBox_Sup.DataSource = Allc;

            //DataTable Allcat = con.SelectProc("Cat_Select", null,null);
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

            DataTable dt = con.SelectProc("Purchases_SelectTopNo", null, null);

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

        private void button_addsup_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();
            s.Show();
        }
        private void button_ref_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            new_no = NextNo();
            comboBox_pno.Text = new_no;

            comboBox_Sup.SelectedIndex = 0;
            //comboBox_Cat.SelectedIndex = 0;
            comboBox_item.SelectedIndex = 0;
            textBox_qty.Value = 0;
            dataGridView_items.Rows.Clear();

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
                            SqlCommand Run2 = new SqlCommand("Purchases_r_Insert", Cn, tr);
                            Run2.CommandType = CommandType.StoredProcedure;

                            Run2.Parameters.AddWithValue("@pur_no", new_no);
                            Run2.Parameters.AddWithValue("@code", R.Cells[1].Value);
                            Run2.Parameters.AddWithValue("@qty",Convert.ToInt32(R.Cells[3].Value));
                            Run2.Parameters.AddWithValue("@unit", "جوال");

                            Run2.ExecuteNonQuery();
                        }

                        SqlCommand Run1 = new SqlCommand("Purchases_h_Insert", Cn, tr);
                        Run1.CommandType = CommandType.StoredProcedure;

                        Run1.Parameters.AddWithValue("@pur_no", new_no);
                        Run1.Parameters.AddWithValue("@userid", comboBox_User.Text);
                        Run1.Parameters.AddWithValue("@contactid", comboBox_Sup.SelectedValue);
                        Run1.Parameters.AddWithValue("@adddate", dateTimePicker_adddate.Value);

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

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (comboBox_item.SelectedIndex !=0 && textBox_qty.Value !=0)
            {
                dataGridView_items.Rows.Add(1,comboBox_item.SelectedValue, comboBox_item.Text, textBox_qty.Value, comboBox_unit.Text);
            }
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

        private void comboBox_pno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView_items.Rows.Count > 0)
            {
                dataGridView_items.Rows.Clear();
            }

            DataTable Allc = con.SelectProc("Purchases_View_SelectByno", new string[] { "no" }, comboBox_pno.SelectedValue);
            if (Allc.Rows.Count > 0)
            {
                dateTimePicker_adddate.Value = Convert.ToDateTime(Allc.Rows[0][4].ToString());
                comboBox_User.SelectedValue = Allc.Rows[0][1].ToString();
                comboBox_Sup.SelectedValue = Allc.Rows[0][2].ToString();

                for (int i = 0; i < Allc.Rows.Count; i++)
                {
                    dataGridView_items.Rows.Add(1, Allc.Rows[i][5].ToString() ,Allc.Rows[i][6].ToString(), Allc.Rows[i][7].ToString());

                }
            }
        }
    }
}
