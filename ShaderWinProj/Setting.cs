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
    public partial class Setting : Form
    {
        Connection con = new Connection();
        int curr_row = -1;
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            DataTable Allusers = con.SelectProc("Users_Select", null, null);
            

            dataGridView_users.Rows.Clear();
            if (Allusers.Rows.Count > 0)
            {
                for (int i = 0; i < Allusers.Rows.Count; i++)
                {
                    dataGridView_users.Rows.Add(Allusers.Rows[i][1].ToString());
                }
            }

        }
        public bool CheckUserExist()
        {
            DataTable AllByusername = con.SelectProc("Users_SelectUsersByUsername", new string[] { "username" }, textBox_username.Text);
            if (AllByusername.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void dataGridView_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (curr_row > -1)
                {
                    dataGridView_users.Rows[curr_row].DefaultCellStyle.BackColor = Color.White;
                }

                int row = e.RowIndex;
                int l_no = Convert.ToInt32(dataGridView_users.RowCount) - 1;
                if (row >= l_no)
                {
                    MessageBox.Show("!..لا يحتوي علي بيانات", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string username = dataGridView_users.Rows[row].Cells["Username"].Value.ToString();

                DataTable AllByusername = con.SelectProc("Users_SelectUsersByUsername", new string[] { "username" }, username);

                textBox_username.Text = AllByusername.Rows[0][1].ToString();
                textBox_pass.Text = AllByusername.Rows[0][2].ToString();

                dataGridView_users.Rows[row].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                curr_row = row;

            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox_pass.Text) && !string.IsNullOrEmpty(this.textBox_pass.Text))
            {
                if (CheckUserExist())
                {
                    con.ExcuteProc("Users_Insert", new string[] { "name","pass" }, textBox_username.Text, textBox_pass.Text);
                    BindData();
                }
                else
                {
                    con.ExcuteProc("Users_Update", new string[] { "name", "pass" }, textBox_username.Text, textBox_pass.Text);
                    BindData();
                }

            }
            else
            {
                MessageBox.Show("!ادخل اسم المستخدم وكلمة المرور", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            textBox_username.Text = "";
            textBox_pass.Text = "";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            con.ExcuteProc("Users_Delete", new string[] { "name"}, textBox_username.Text);
            BindData();
        }
    }
}
