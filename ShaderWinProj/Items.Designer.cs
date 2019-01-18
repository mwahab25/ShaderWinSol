namespace ShaderWinProj
{
    partial class Items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_searchitem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_searchitemname = new System.Windows.Forms.TextBox();
            this.dataGridView_items = new System.Windows.Forms.DataGridView();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_alert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_itemname = new System.Windows.Forms.TextBox();
            this.button_itemnew = new System.Windows.Forms.Button();
            this.button_itemdelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.button_itemsave = new System.Windows.Forms.Button();
            this.button_itemupdate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 365);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Snow;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "الاصنــاف";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_searchitem);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_searchitemname);
            this.groupBox3.Controls.Add(this.dataGridView_items);
            this.groupBox3.Location = new System.Drawing.Point(10, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 326);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // button_searchitem
            // 
            this.button_searchitem.Location = new System.Drawing.Point(37, 32);
            this.button_searchitem.Name = "button_searchitem";
            this.button_searchitem.Size = new System.Drawing.Size(50, 23);
            this.button_searchitem.TabIndex = 23;
            this.button_searchitem.Text = "بحث";
            this.button_searchitem.UseVisualStyleBackColor = true;
            this.button_searchitem.Click += new System.EventHandler(this.button_searchitem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(332, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "بحث بالاسم";
            // 
            // textBox_searchitemname
            // 
            this.textBox_searchitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchitemname.Location = new System.Drawing.Point(93, 32);
            this.textBox_searchitemname.Name = "textBox_searchitemname";
            this.textBox_searchitemname.Size = new System.Drawing.Size(203, 23);
            this.textBox_searchitemname.TabIndex = 22;
            // 
            // dataGridView_items
            // 
            this.dataGridView_items.AllowUserToDeleteRows = false;
            this.dataGridView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IID,
            this.Item_code,
            this.Item_name,
            this.Alert});
            this.dataGridView_items.Location = new System.Drawing.Point(12, 66);
            this.dataGridView_items.Name = "dataGridView_items";
            this.dataGridView_items.ReadOnly = true;
            this.dataGridView_items.Size = new System.Drawing.Size(394, 251);
            this.dataGridView_items.TabIndex = 0;
            this.dataGridView_items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_items_CellClick);
            // 
            // IID
            // 
            this.IID.HeaderText = "م";
            this.IID.Name = "IID";
            this.IID.ReadOnly = true;
            this.IID.Visible = false;
            // 
            // Item_code
            // 
            this.Item_code.HeaderText = "كود الصنف";
            this.Item_code.Name = "Item_code";
            this.Item_code.ReadOnly = true;
            // 
            // Item_name
            // 
            this.Item_name.HeaderText = "اسم الصنف";
            this.Item_name.Name = "Item_name";
            this.Item_name.ReadOnly = true;
            this.Item_name.Width = 200;
            // 
            // Alert
            // 
            this.Alert.HeaderText = "التنبيه";
            this.Alert.Name = "Alert";
            this.Alert.ReadOnly = true;
            this.Alert.Width = 51;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_itemupdate);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox_alert);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox_itemname);
            this.groupBox4.Controls.Add(this.button_itemnew);
            this.groupBox4.Controls.Add(this.button_itemdelete);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox_code);
            this.groupBox4.Controls.Add(this.button_itemsave);
            this.groupBox4.Location = new System.Drawing.Point(436, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 326);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(280, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "الحد الادني";
            // 
            // textBox_alert
            // 
            this.textBox_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_alert.Location = new System.Drawing.Point(19, 99);
            this.textBox_alert.Name = "textBox_alert";
            this.textBox_alert.Size = new System.Drawing.Size(221, 21);
            this.textBox_alert.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(275, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "إسم الصنف";
            // 
            // textBox_itemname
            // 
            this.textBox_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_itemname.Location = new System.Drawing.Point(19, 66);
            this.textBox_itemname.Name = "textBox_itemname";
            this.textBox_itemname.Size = new System.Drawing.Size(221, 21);
            this.textBox_itemname.TabIndex = 14;
            // 
            // button_itemnew
            // 
            this.button_itemnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_itemnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_itemnew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemnew.ForeColor = System.Drawing.Color.Black;
            this.button_itemnew.Location = new System.Drawing.Point(180, 142);
            this.button_itemnew.Name = "button_itemnew";
            this.button_itemnew.Size = new System.Drawing.Size(60, 32);
            this.button_itemnew.TabIndex = 13;
            this.button_itemnew.Text = "جديد";
            this.button_itemnew.UseVisualStyleBackColor = true;
            this.button_itemnew.Click += new System.EventHandler(this.button_itemnew_Click);
            // 
            // button_itemdelete
            // 
            this.button_itemdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_itemdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_itemdelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemdelete.ForeColor = System.Drawing.Color.Black;
            this.button_itemdelete.Location = new System.Drawing.Point(48, 142);
            this.button_itemdelete.Name = "button_itemdelete";
            this.button_itemdelete.Size = new System.Drawing.Size(60, 32);
            this.button_itemdelete.TabIndex = 8;
            this.button_itemdelete.Text = "حذف";
            this.button_itemdelete.UseVisualStyleBackColor = true;
            this.button_itemdelete.Click += new System.EventHandler(this.button_itemdelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(277, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "كود الصنف";
            // 
            // textBox_code
            // 
            this.textBox_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_code.Location = new System.Drawing.Point(20, 32);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(220, 21);
            this.textBox_code.TabIndex = 2;
            // 
            // button_itemsave
            // 
            this.button_itemsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_itemsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_itemsave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemsave.ForeColor = System.Drawing.Color.Black;
            this.button_itemsave.Location = new System.Drawing.Point(114, 142);
            this.button_itemsave.Name = "button_itemsave";
            this.button_itemsave.Size = new System.Drawing.Size(60, 32);
            this.button_itemsave.TabIndex = 3;
            this.button_itemsave.Text = "حفظ";
            this.button_itemsave.UseVisualStyleBackColor = true;
            this.button_itemsave.Click += new System.EventHandler(this.button_itemsave_Click);
            // 
            // button_itemupdate
            // 
            this.button_itemupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_itemupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_itemupdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemupdate.ForeColor = System.Drawing.Color.Black;
            this.button_itemupdate.Location = new System.Drawing.Point(114, 180);
            this.button_itemupdate.Name = "button_itemupdate";
            this.button_itemupdate.Size = new System.Drawing.Size(60, 32);
            this.button_itemupdate.TabIndex = 18;
            this.button_itemupdate.Text = "تعديل";
            this.button_itemupdate.UseVisualStyleBackColor = true;
            this.button_itemupdate.Visible = false;
            this.button_itemupdate.Click += new System.EventHandler(this.button_itemupdate_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 360);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Items";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاصناف";
            this.Load += new System.EventHandler(this.Items_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_searchitem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_searchitemname;
        private System.Windows.Forms.DataGridView dataGridView_items;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_itemnew;
        private System.Windows.Forms.Button button_itemdelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Button button_itemsave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_alert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alert;
        private System.Windows.Forms.Button button_itemupdate;
    }
}