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
    public partial class Customers : Form
    {
        Connection con = new Connection();
        int curr_row = -1;
        public Customers()
        {
            InitializeComponent();
        }
        private void Customers_Load(object sender, EventArgs e)
        {
            BindData();
        }
        public void BindData()
        {
            DataTable AllSC = con.SelectProc("Contacts_Select", new string[] { "type" }, 1);

            dataGridView_customers.Rows.Clear();
            if (AllSC.Rows.Count > 0)
            {
                for (int i = 0; i < AllSC.Rows.Count; i++)
                {
                    dataGridView_customers.Rows.Add(AllSC.Rows[i][0].ToString(), AllSC.Rows[i][1].ToString(), AllSC.Rows[i][2].ToString(), AllSC.Rows[i][3].ToString());
                }
            }
        }
        public void newdata()
        {
            textBox_name.Text = "";
            textBox_phone.Text = "";
            textBox_mob.Text = "";
            textBox_addr.Text = "";
            textBox_magicid.Text = "";
        }
        private void button_new_Click(object sender, EventArgs e)
        {
            newdata();
            BindData();
            textBox2.Text = "";
            textBox3.Text = "";  
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox_name.Text) && string.IsNullOrEmpty(this.textBox_magicid.Text))
            {
                con.ExcuteProc("Contacts_Insert", new string[] { "name","phone","mob","addr","type" }, textBox_name.Text, textBox_phone.Text, textBox_mob.Text, textBox_addr.Text,1);
                BindData();
            }
            else if (!string.IsNullOrEmpty(this.textBox_magicid.Text))
            {
                con.ExcuteProc("Contacts_Update", new string[] { "id","name", "phone", "mob", "addr" }, Convert.ToInt32(textBox_magicid.Text), textBox_name.Text, textBox_phone.Text, textBox_mob.Text, textBox_addr.Text);

                BindData();
            }
            else
            {
                MessageBox.Show("!ادخل إسم العميل", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox_magicid.Text))
            {
                if (MessageBox.Show("هل متأكد من الحذف؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.ExcuteProc("Contacts_Delete", new string[] { "id" }, Convert.ToInt32(textBox_magicid.Text));
                    newdata();
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("!اختر العميل الذي تريد حذفه", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            DataTable Cust = con.SelectProc("Contacts_SelectByName", new string[] { "name", "type" }, textBox2.Text,1);
            

            dataGridView_customers.Rows.Clear();
            if (Cust.Rows.Count > 0)
            {
                for (int i = 0; i < Cust.Rows.Count; i++)
                {
                    dataGridView_customers.Rows.Add(Cust.Rows[i][0].ToString(), Cust.Rows[i][1].ToString(), Cust.Rows[i][2].ToString(), Cust.Rows[i][3].ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable Cust = con.SelectProc("Contacts_SelectByMob", new string[] { "mob", "type" }, textBox3.Text, 1);
            dataGridView_customers.Rows.Clear();
            if (Cust.Rows.Count > 0)
            {
                for (int i = 0; i < Cust.Rows.Count; i++)
                {
                    dataGridView_customers.Rows.Add(Cust.Rows[i][0].ToString(), Cust.Rows[i][1].ToString(), Cust.Rows[i][2].ToString(),Cust.Rows[i][3].ToString());
                }
            }
        }

        private void dataGridView_customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (curr_row > -1)
                {
                    dataGridView_customers.Rows[curr_row].DefaultCellStyle.BackColor = Color.White;
                }

                int row = e.RowIndex;
                int l_no = Convert.ToInt32(dataGridView_customers.RowCount) - 1;
                if (row >= l_no)
                {
                    MessageBox.Show("!..لا يحتوي علي بيانات", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dataGridView_customers.Rows[row].Cells["ColID"].Value.ToString());

                DataTable AllById = con.SelectProc("Contacts_SelectByID", new string[] { "id", "type" }, id, 1);

                textBox_magicid.Text = AllById.Rows[0][0].ToString();
                textBox_name.Text = AllById.Rows[0][1].ToString();
                textBox_phone.Text = AllById.Rows[0][2].ToString();
                textBox_mob.Text = AllById.Rows[0][3].ToString();
                textBox_addr.Text = AllById.Rows[0][4].ToString();

                dataGridView_customers.Rows[row].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                curr_row = row;
            }
        }
    }
}
