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
    public partial class Login : Form
    {
        public static bool x1;
        public static string User = "";
        public static string caption = "";
        Connection con = new Connection();

        public Login()
        {
            InitializeComponent();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.textBox_username.Text))
                {
                    DataTable Log = con.SelectProc("Users_UserLogin", new string[] { "name", "password" }, textBox_username.Text, textBox_pass.Text);

                    if (Log.Rows.Count > 0)
                    {
                        label2.Visible = false;
                        x1 = true;
                        this.Hide();
                        User = textBox_username.Text;
                        caption =textBox_username.Text;

                    }
                    else
                    {
                        label2.Visible = true;
                        label2.Text = "خطأ في اسم المستخدم او كلمة المرور ...";
                    }
                }
            }
            catch(Exception ex)
            {

                label2.Visible = true;
                label2.Text = ex.Message + "خطأ في اسم المستخدم او كلمة المرور ...";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_signin.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
