using ShaderWinProj.App_Code;
using ShaderWinProj.Reports;
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
    public partial class Sales : Form
    {
        Connection con = new Connection();

        public static string issue_no;
        string newissue_no;
       
        public Sales()
        {
            InitializeComponent();
        }
   
        public string NextNo()
        {
            string add_no = "";
            int add_no_int = 0;

            DataTable dt = con.SelectProc("Sales_SelectTopNo", null, null);

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

        private void Sales_Load(object sender, EventArgs e)
        {
            newissue_no = NextNo();
            comboBox_Issueno.Text = newissue_no;
            BindData();
            comboBox_User.Text = Login.User;
        }
        public void BindData()
        {
            DataTable Allc = con.SelectProc("Contacts_Select", new string[] { "type" }, 1);
            DataRow dr1 = Allc.NewRow();
            dr1["Name"] = "--اختر--";
            dr1["ID"] = "0";
            Allc.Rows.InsertAt(dr1, 0);
            comboBox_cust.DisplayMember = "Name";
            comboBox_cust.ValueMember = "ID";
            comboBox_cust.DataSource = Allc;
        }
        private void button_ref_Click(object sender, EventArgs e)
        {

        }

        private void button_addsup_Click(object sender, EventArgs e)
        {
            Customers s = new Customers();
            s.Show();
        }
        private void button_new_Click(object sender, EventArgs e)
        {
            newissue_no = NextNo();
            comboBox_Issueno.Text = newissue_no;

            dataGridView_items.Rows.Clear();
            textBox_total.Text = "";
            textBox_pay.Text = "";
            textBox_rem.Text = "";
            comboBox_cust.SelectedIndex = 0;
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
                string distno = NextNo();

                if (dataGridView_items.Rows.Count > 0)
                {
                    foreach (DataGridViewRow R in dataGridView_items.Rows)
                    {
                        SqlCommand Run2 = new SqlCommand("Sales_r_Insert", Cn, tr);
                        Run2.CommandType = CommandType.StoredProcedure;

                        Run2.Parameters.AddWithValue("@salesno", distno);
                        Run2.Parameters.AddWithValue("@code", R.Cells[1].Value);
                        Run2.Parameters.AddWithValue("@qty", Convert.ToInt32(R.Cells[3].Value));
                        Run2.Parameters.AddWithValue("@unit", R.Cells[4].Value);
                        Run2.Parameters.AddWithValue("@weight", R.Cells[5].Value);
                        Run2.Parameters.AddWithValue("@unitprice", Convert.ToDecimal(R.Cells[6].Value));
                        Run2.Parameters.AddWithValue("@totalprice", Convert.ToDecimal(R.Cells[7].Value));

                        Run2.ExecuteNonQuery();
                    }

                    SqlCommand Run1 = new SqlCommand("Sales_h_Insert", Cn, tr);
                    Run1.CommandType = CommandType.StoredProcedure;

                    Run1.Parameters.AddWithValue("@salesno", distno);
                    Run1.Parameters.AddWithValue("@userid", Login.User);
                    Run1.Parameters.AddWithValue("@adddate", dateTimePicker_adddate.Value);
                    Run1.Parameters.AddWithValue("@contactid", comboBox_cust.SelectedValue);
                    Run1.Parameters.AddWithValue("@total", Convert.ToDecimal(textBox_total.Text));
                    Run1.Parameters.AddWithValue("@rec", Convert.ToDecimal(textBox_pay.Text));
                    Run1.Parameters.AddWithValue("@rem", Convert.ToDecimal(textBox_rem.Text));

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
            issue_no = comboBox_Issueno.Text;

            RepIssueGenerate newop = new RepIssueGenerate();
            newop.Show();
        }

        private void comboBox_cust_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Allc = con.SelectProc("Distribute_View_SelectByCust", new string[] { "contactid" }, comboBox_cust.SelectedValue);
            dataGridView_items.Rows.Clear();
            
            if (Allc.Rows.Count > 0)
            {
                decimal sum = 0;
                for (int i = 0; i < Allc.Rows.Count; i++)
                {
                    decimal total =Convert.ToDecimal(Allc.Rows[i][9].ToString());
                    decimal tax = Convert.ToDecimal(Allc.Rows[i][13].ToString());

                    sum += total + tax;
                    dataGridView_items.Rows.Add(1, Allc.Rows[i][3].ToString(), Allc.Rows[i][4].ToString(), Allc.Rows[i][5].ToString(), Allc.Rows[i][7].ToString(), Allc.Rows[i][8].ToString(), tax + total);
                }

                textBox_total.Text = sum.ToString();
            }
        }

        private void comboBox_Issueno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
