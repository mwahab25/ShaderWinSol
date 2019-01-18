using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaderWinProj
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(4500);

            InitializeComponent();

            t.Abort();

            
        }

        public void SplashStart()
        {
            Application.Run(new Starting());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

            this.toolStripStatusLabel_productver.Text = "برنامج شادر (نسخة تجريبية)" + " | "; ;
            this.toolStripStatusLabel_user.Text = "المستخدم الحالي : " + Login.User + " | ";
            this.toolStripStatusLabel_date.Text = "تاريخ الدخول : " + DateTime.Now.ToShortDateString() + " | ";
            this.toolStripStatusLabel_time.Text = "وقت الدخول : " + DateTime.Now.ToShortTimeString();
            
            this.Controls.Add(statusStrip1);

            if (Login.x1 == false)
            {
                Application.Exit();
                return;
            }

            if (Login.x1 == true)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void العملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers();
            cust.MdiParent = this;
            cust.Show();
        }

        private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers sup = new Suppliers();
            sup.MdiParent = this;
            sup.Show();
        }

        private void الاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items item = new Items();
            item.MdiParent = this;
            item.Show();
        }

        private void إعداداتالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralSet set = new GeneralSet();
            set.MdiParent = this;
            set.Show();
        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting set = new Setting();
            set.MdiParent = this;
            set.Show();
        }

        private void قاعدةالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button_purchases_Click(object sender, EventArgs e)
        {
            Purchases pur = new Purchases();
            pur.MdiParent = this;
            pur.Show();
        }

        private void button_sales_Click(object sender, EventArgs e)
        {
            Sales sal = new Sales();
            sal.MdiParent = this;
            sal.Show();
        }

        private void button_inv_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.MdiParent = this;
            inv.Show();
        }

        private void button_reports_Click(object sender, EventArgs e)
        {
            ReportsColl rep = new ReportsColl();
            rep.MdiParent = this;
            rep.Show();
        }

        private void button_divide_Click(object sender, EventArgs e)
        {

            TransferSales rep = new TransferSales();
            rep.MdiParent = this;
            rep.Show();

        }

        private void حولالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.MdiParent = this;
            a.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الخروج ؟", "خروج", MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GeneralSet set = new GeneralSet();
            set.MdiParent = this;
            set.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneralSet set = new GeneralSet();
            set.MdiParent = this;
            set.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Setting set = new Setting();
            set.MdiParent = this;
            set.Show();
        }

        private void الموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.MdiParent = this;
            emp.Show();
        }
    }
}
