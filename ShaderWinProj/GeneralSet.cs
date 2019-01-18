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
    public partial class GeneralSet : Form
    {
        Connection con = new Connection();

        public GeneralSet()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DataTable dt = con.SelectProc("GeneralSet_Select", null, null);
            if (dt.Rows.Count > 0)
            {
                con.ExcuteProc("GeneralSet_Update", new string[] { "name", "phone", "fax", "mob", "mail", "email", "dur" }, textBox_companyname.Text, textBox_phone.Text, textBox_fax.Text, textBox_mob.Text, textBox_mail.Text, textBox_email.Text, numericUpDown_dur.Value);
                MessageBox.Show("تم الحفظ");

            }
            else
            {
                con.ExcuteProc("GeneralSet_Insert", new string[] { "name", "phone", "fax", "mob", "mail", "email", "dur" }, textBox_companyname.Text, textBox_phone.Text, textBox_fax.Text, textBox_mob.Text, textBox_mail.Text, textBox_email.Text, numericUpDown_dur.Value);
                MessageBox.Show("تم الحفظ");
            }
        }

        private void GeneralSet_Load(object sender, EventArgs e)
        {
            BindGeneralSet();
        }
        private void BindGeneralSet()
        {
            try
            {
                DataTable dt = con.SelectProc("GeneralSet_Select", null, null);


                textBox_companyname.Text = dt.Rows[0][1].ToString();
                textBox_phone.Text = dt.Rows[0][2].ToString();
                textBox_fax.Text = dt.Rows[0][3].ToString();
                textBox_mob.Text = dt.Rows[0][4].ToString();
                textBox_mail.Text = dt.Rows[0][5].ToString();
                textBox_email.Text = dt.Rows[0][6].ToString();
                numericUpDown_dur.Value=Convert.ToInt32(dt.Rows[0][8].ToString());

                //byte[] bytes = (byte[])dt.Rows[0][7];
                //string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                //Image1.ImageUrl = Image1.ImageUrl = "data:image/png;base64," + base64String;
            }
            catch
            {
               
            }
        }
    }
}
