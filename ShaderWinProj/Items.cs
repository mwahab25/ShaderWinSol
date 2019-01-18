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

namespace ShaderWinProj
{
    public partial class Items : Form
    {
        Connection con = new Connection();
        public Items()
        {
            InitializeComponent();
        }

        int curr_itemrow = -1;

        private void Items_Load(object sender, EventArgs e)
        {
            BindItemData();

            textBox_code.Text = NextNo();
        }
        
        public string NextNo()
        {
            string add_no = "";
            int add_no_int = 0;

            DataTable dt = con.SelectProc("Item_SelectTopNo", null, null);

            if (dt.Rows.Count > 0)
                add_no = dt.Rows[0][0].ToString().Trim();
            string nadd_no = "";

            if (dt.Rows.Count > 0)
            {
                add_no_int = int.Parse(add_no);
                add_no_int += 1;
                int add_no_int_len = add_no_int.ToString().Length;
                int remender_zero_part_len = 7 - add_no_int_len;
                string remender_zero_part = "";
                for (int i = 0; i < remender_zero_part_len; i++)
                {
                    remender_zero_part += "0";
                }
                nadd_no = remender_zero_part + add_no_int.ToString();
            }
            else
            {
                nadd_no = "0000000";
            }
            return nadd_no;
        }
        public void BindItemData()
        {
            DataTable Alli = con.SelectProc("Item_Select", null, null);

            dataGridView_items.Rows.Clear();
            if (Alli.Rows.Count > 0)
            {
                for (int i = 0; i < Alli.Rows.Count; i++)
                {
                    dataGridView_items.Rows.Add(Alli.Rows[i][0].ToString(), Alli.Rows[i][1].ToString(), Alli.Rows[i][2].ToString(), Alli.Rows[i][3].ToString());
                }
            }
        }
        private void button_itemnew_Click(object sender, EventArgs e)
        {
            textBox_code.Text = NextNo();

            textBox_itemname.Text = "";
            textBox_alert.Text = "";
            //comboBox_Cat.SelectedIndex = 0;
            //comboBox_catname.SelectedIndex = 0;
            textBox_searchitemname.Text = "";

            button_itemupdate.Visible = false;
            button_itemsave.Visible = true;
            BindItemData();
        }
        private void button_itemsave_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(this.textBox_itemname.Text) && !string.IsNullOrEmpty(this.textBox_alert.Text))
            {
                DataTable ch = con.SelectProc("Item_Selectcode", new string[] { "code" }, textBox_code.Text);
                if (ch.Rows.Count > 0)
                {
                    MessageBox.Show("!كود متكرر", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    con.ExcuteProc("Item_Insert", new string[] { "code", "name", "qty", "catid" }, textBox_code.Text, textBox_itemname.Text, textBox_alert.Text, 1);
                    BindItemData();
                }
            }
            else
            {
                MessageBox.Show("!ادخل البيانات الناقصة", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void button_itemupdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox_itemname.Text) && !string.IsNullOrEmpty(this.textBox_alert.Text))
            {
                con.ExcuteProc("Item_Update", new string[] { "code", "name", "qty", "catid" }, textBox_code.Text, textBox_itemname.Text, textBox_alert.Text, 1);
                BindItemData();
            }
            else
            {
                MessageBox.Show("!ادخل البيانات الناقصة", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void button_itemdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل متأكد من الحذف؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.ExcuteProc("Item_Delete", new string[] { "code" }, textBox_code.Text);

                textBox_itemname.Text = "";
                button_itemupdate.Visible = false;
                button_itemsave.Visible = true;
                BindItemData();
            }
        }

        
        private void button_searchitem_Click(object sender, EventArgs e)
        {
            DataTable CByName = con.SelectProc("Item_SelectByName", new string[] { "name" }, textBox_searchitemname.Text);
            dataGridView_items.Rows.Clear();
            if (CByName.Rows.Count > 0)
            {
                for (int i = 0; i < CByName.Rows.Count; i++)
                {
                    dataGridView_items.Rows.Add(CByName.Rows[i][0].ToString(), CByName.Rows[i][1].ToString(), CByName.Rows[i][2].ToString(), CByName.Rows[i][3].ToString());
                }
            }
        }
        private void dataGridView_items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (curr_itemrow > -1)
                {
                    dataGridView_items.Rows[curr_itemrow].DefaultCellStyle.BackColor = Color.White;
                }

                int row = e.RowIndex;
                int l_no = Convert.ToInt32(dataGridView_items.RowCount) - 1;
                if (row >= l_no)
                {
                    MessageBox.Show("!..لا يحتوي علي بيانات", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string code = dataGridView_items.Rows[row].Cells["Item_code"].Value.ToString();

                DataTable AllById = con.SelectProc("Item_SelectBycode", new string[] { "code" }, code);

                textBox_code.Text = code.ToString();
                textBox_itemname.Text = AllById.Rows[0][2].ToString();
                textBox_alert.Text = AllById.Rows[0][3].ToString();
                

                dataGridView_items.Rows[row].DefaultCellStyle.BackColor = Color.LightSkyBlue;

                curr_itemrow = row;

                button_itemupdate.Visible = true;
                button_itemsave.Visible = false;
            }
        }
    }
}
