namespace ShaderWinProj
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_items = new System.Windows.Forms.DataGridView();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ItemcodeSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvaliableQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalpricesal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ref = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button_addsup = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_rem = new System.Windows.Forms.TextBox();
            this.textBox_pay = new System.Windows.Forms.TextBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.comboBox_cust = new System.Windows.Forms.ComboBox();
            this.comboBox_User = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_adddate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Issueno = new System.Windows.Forms.ComboBox();
            this.button_report = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_items);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(9, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(932, 415);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView_items
            // 
            this.dataGridView_items.AllowUserToAddRows = false;
            this.dataGridView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk,
            this.ItemcodeSal,
            this.ItemName,
            this.AvaliableQty,
            this.Qty,
            this.Pricesel,
            this.Totalpricesal});
            this.dataGridView_items.Location = new System.Drawing.Point(15, 26);
            this.dataGridView_items.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_items.Name = "dataGridView_items";
            this.dataGridView_items.RowHeadersWidth = 51;
            this.dataGridView_items.Size = new System.Drawing.Size(904, 369);
            this.dataGridView_items.TabIndex = 37;
            // 
            // Chk
            // 
            this.Chk.HeaderText = "";
            this.Chk.MinimumWidth = 6;
            this.Chk.Name = "Chk";
            this.Chk.Width = 30;
            // 
            // ItemcodeSal
            // 
            this.ItemcodeSal.HeaderText = "كود الصنف";
            this.ItemcodeSal.MinimumWidth = 6;
            this.ItemcodeSal.Name = "ItemcodeSal";
            this.ItemcodeSal.Visible = false;
            this.ItemcodeSal.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "اسم الصنف";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 300;
            // 
            // AvaliableQty
            // 
            this.AvaliableQty.HeaderText = "العدد";
            this.AvaliableQty.MinimumWidth = 6;
            this.AvaliableQty.Name = "AvaliableQty";
            this.AvaliableQty.Width = 80;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "الوزن";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 125;
            // 
            // Pricesel
            // 
            this.Pricesel.HeaderText = "سعر الوحدة";
            this.Pricesel.MinimumWidth = 6;
            this.Pricesel.Name = "Pricesel";
            this.Pricesel.Width = 110;
            // 
            // Totalpricesal
            // 
            this.Totalpricesal.HeaderText = "اجمالي";
            this.Totalpricesal.MinimumWidth = 6;
            this.Totalpricesal.Name = "Totalpricesal";
            this.Totalpricesal.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ref);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button_addsup);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_rem);
            this.groupBox1.Controls.Add(this.textBox_pay);
            this.groupBox1.Controls.Add(this.textBox_total);
            this.groupBox1.Controls.Add(this.comboBox_cust);
            this.groupBox1.Controls.Add(this.comboBox_User);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker_adddate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Issueno);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(932, 212);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // button_ref
            // 
            this.button_ref.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button_ref.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_ref.Location = new System.Drawing.Point(271, 165);
            this.button_ref.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ref.Name = "button_ref";
            this.button_ref.Size = new System.Drawing.Size(66, 32);
            this.button_ref.TabIndex = 6;
            this.button_ref.Text = "تحديث";
            this.button_ref.UseVisualStyleBackColor = true;
            this.button_ref.Click += new System.EventHandler(this.button_ref_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(192, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "الباقي";
            // 
            // button_addsup
            // 
            this.button_addsup.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button_addsup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_addsup.Location = new System.Drawing.Point(344, 165);
            this.button_addsup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_addsup.Name = "button_addsup";
            this.button_addsup.Size = new System.Drawing.Size(111, 32);
            this.button_addsup.TabIndex = 5;
            this.button_addsup.Text = "اضافة عميل";
            this.button_addsup.UseVisualStyleBackColor = true;
            this.button_addsup.Click += new System.EventHandler(this.button_addsup_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(182, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "المدفوع";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(180, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "الاجمالي";
            // 
            // textBox_rem
            // 
            this.textBox_rem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rem.Location = new System.Drawing.Point(7, 122);
            this.textBox_rem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_rem.Name = "textBox_rem";
            this.textBox_rem.Size = new System.Drawing.Size(143, 24);
            this.textBox_rem.TabIndex = 9;
            // 
            // textBox_pay
            // 
            this.textBox_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pay.Location = new System.Drawing.Point(7, 81);
            this.textBox_pay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_pay.Name = "textBox_pay";
            this.textBox_pay.Size = new System.Drawing.Size(143, 24);
            this.textBox_pay.TabIndex = 8;
            // 
            // textBox_total
            // 
            this.textBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total.Location = new System.Drawing.Point(7, 39);
            this.textBox_total.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(143, 24);
            this.textBox_total.TabIndex = 7;
            // 
            // comboBox_cust
            // 
            this.comboBox_cust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cust.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cust.FormattingEnabled = true;
            this.comboBox_cust.Location = new System.Drawing.Point(462, 167);
            this.comboBox_cust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_cust.Name = "comboBox_cust";
            this.comboBox_cust.Size = new System.Drawing.Size(349, 26);
            this.comboBox_cust.TabIndex = 4;
            this.comboBox_cust.SelectedIndexChanged += new System.EventHandler(this.comboBox_cust_SelectedIndexChanged);
            // 
            // comboBox_User
            // 
            this.comboBox_User.Enabled = false;
            this.comboBox_User.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_User.FormattingEnabled = true;
            this.comboBox_User.Location = new System.Drawing.Point(462, 122);
            this.comboBox_User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_User.Name = "comboBox_User";
            this.comboBox_User.Size = new System.Drawing.Size(349, 26);
            this.comboBox_User.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(876, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "العميل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(859, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "المستخدم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(841, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "تاريخ الفاتورة";
            // 
            // dateTimePicker_adddate
            // 
            this.dateTimePicker_adddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_adddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_adddate.Location = new System.Drawing.Point(462, 79);
            this.dateTimePicker_adddate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_adddate.Name = "dateTimePicker_adddate";
            this.dateTimePicker_adddate.RightToLeftLayout = true;
            this.dateTimePicker_adddate.Size = new System.Drawing.Size(349, 24);
            this.dateTimePicker_adddate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(849, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "رقم الفاتورة";
            // 
            // comboBox_Issueno
            // 
            this.comboBox_Issueno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Issueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Issueno.FormattingEnabled = true;
            this.comboBox_Issueno.Location = new System.Drawing.Point(462, 34);
            this.comboBox_Issueno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Issueno.Name = "comboBox_Issueno";
            this.comboBox_Issueno.Size = new System.Drawing.Size(349, 26);
            this.comboBox_Issueno.TabIndex = 1;
            this.comboBox_Issueno.SelectedIndexChanged += new System.EventHandler(this.comboBox_Issueno_SelectedIndexChanged);
            // 
            // button_report
            // 
            this.button_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_report.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report.ForeColor = System.Drawing.Color.Black;
            this.button_report.Location = new System.Drawing.Point(705, 647);
            this.button_report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_report.Name = "button_report";
            this.button_report.Size = new System.Drawing.Size(70, 39);
            this.button_report.TabIndex = 11;
            this.button_report.Text = "طباعة";
            this.button_report.UseVisualStyleBackColor = true;
            this.button_report.Click += new System.EventHandler(this.button_report_Click);
            // 
            // button_save
            // 
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Black;
            this.button_save.Location = new System.Drawing.Point(782, 647);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(70, 39);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "حفظ";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_new
            // 
            this.button_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_new.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new.ForeColor = System.Drawing.Color.Black;
            this.button_new.Location = new System.Drawing.Point(859, 647);
            this.button_new.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(70, 39);
            this.button_new.TabIndex = 0;
            this.button_new.Text = "جديد";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(950, 693);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_report);
            this.Controls.Add(this.button_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Sales";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فواتير المبيعات";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_items;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_rem;
        private System.Windows.Forms.TextBox textBox_pay;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.ComboBox comboBox_cust;
        private System.Windows.Forms.ComboBox comboBox_User;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_adddate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Issueno;
        private System.Windows.Forms.Button button_report;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_ref;
        private System.Windows.Forms.Button button_addsup;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemcodeSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvaliableQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pricesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalpricesal;
    }
}