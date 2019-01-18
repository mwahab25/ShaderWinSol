namespace ShaderWinProj
{
    partial class TransferSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferSales));
            this.button_new = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.comboBox_Cat = new System.Windows.Forms.ComboBox();
            this.comboBox_item = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_items = new System.Windows.Forms.DataGridView();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvaliableQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.السعر = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trasomola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_adddate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_cust = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.textBox_tax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_qty = new System.Windows.Forms.NumericUpDown();
            this.button_ref = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_addsup = new System.Windows.Forms.Button();
            this.comboBox_unit = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_pno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ava = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_qty)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_new
            // 
            this.button_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_new.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new.ForeColor = System.Drawing.Color.Black;
            this.button_new.Location = new System.Drawing.Point(703, 524);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(60, 32);
            this.button_new.TabIndex = 0;
            this.button_new.Text = "جديد";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_save
            // 
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Black;
            this.button_save.Location = new System.Drawing.Point(637, 524);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(60, 32);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "حفظ";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox_Cat
            // 
            this.comboBox_Cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Cat.FormattingEnabled = true;
            this.comboBox_Cat.Location = new System.Drawing.Point(53, 27);
            this.comboBox_Cat.Name = "comboBox_Cat";
            this.comboBox_Cat.Size = new System.Drawing.Size(300, 23);
            this.comboBox_Cat.TabIndex = 2;
            this.comboBox_Cat.Visible = false;
            this.comboBox_Cat.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cat_SelectedIndexChanged);
            // 
            // comboBox_item
            // 
            this.comboBox_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_item.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_item.FormattingEnabled = true;
            this.comboBox_item.Location = new System.Drawing.Point(359, 94);
            this.comboBox_item.Name = "comboBox_item";
            this.comboBox_item.Size = new System.Drawing.Size(300, 23);
            this.comboBox_item.TabIndex = 3;
            this.comboBox_item.SelectedIndexChanged += new System.EventHandler(this.comboBox_item_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(707, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "الصنف";
            // 
            // dataGridView_items
            // 
            this.dataGridView_items.AllowUserToAddRows = false;
            this.dataGridView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk,
            this.Column1type,
            this.Custvalue,
            this.ItemName,
            this.AvaliableQty,
            this.Qty,
            this.السعر,
            this.Trasomola});
            this.dataGridView_items.Location = new System.Drawing.Point(11, 102);
            this.dataGridView_items.Name = "dataGridView_items";
            this.dataGridView_items.Size = new System.Drawing.Size(743, 234);
            this.dataGridView_items.TabIndex = 15;
            // 
            // Chk
            // 
            this.Chk.HeaderText = "";
            this.Chk.Name = "Chk";
            this.Chk.Width = 30;
            // 
            // Column1type
            // 
            this.Column1type.HeaderText = "الدفع";
            this.Column1type.Name = "Column1type";
            // 
            // Custvalue
            // 
            this.Custvalue.HeaderText = "رقم العميل";
            this.Custvalue.Name = "Custvalue";
            this.Custvalue.Visible = false;
            this.Custvalue.Width = 50;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "العميل/المستلم";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 200;
            // 
            // AvaliableQty
            // 
            this.AvaliableQty.HeaderText = "العدد";
            this.AvaliableQty.Name = "AvaliableQty";
            this.AvaliableQty.Width = 90;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "الوزن";
            this.Qty.Name = "Qty";
            // 
            // السعر
            // 
            this.السعر.HeaderText = "السعر";
            this.السعر.Name = "السعر";
            // 
            // Trasomola
            // 
            this.Trasomola.HeaderText = "العمولة";
            this.Trasomola.Name = "Trasomola";
            this.Trasomola.Width = 80;
            // 
            // textBox_weight
            // 
            this.textBox_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_weight.Location = new System.Drawing.Point(500, 59);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(88, 21);
            this.textBox_weight.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(709, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "العدد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(594, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "الوزن";
            // 
            // textBox_price
            // 
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_price.Location = new System.Drawing.Point(352, 59);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(88, 21);
            this.textBox_price.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(446, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "السعر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(584, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "العميل";
            // 
            // dateTimePicker_adddate
            // 
            this.dateTimePicker_adddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_adddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_adddate.Location = new System.Drawing.Point(359, 61);
            this.dateTimePicker_adddate.Name = "dateTimePicker_adddate";
            this.dateTimePicker_adddate.RightToLeftLayout = true;
            this.dateTimePicker_adddate.Size = new System.Drawing.Size(300, 21);
            this.dateTimePicker_adddate.TabIndex = 1;
            // 
            // comboBox_cust
            // 
            this.comboBox_cust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cust.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cust.FormattingEnabled = true;
            this.comboBox_cust.Location = new System.Drawing.Point(342, 25);
            this.comboBox_cust.Name = "comboBox_cust";
            this.comboBox_cust.Size = new System.Drawing.Size(236, 23);
            this.comboBox_cust.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(718, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "تاريخ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_type);
            this.groupBox2.Controls.Add(this.textBox_tax);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_qty);
            this.groupBox2.Controls.Add(this.button_ref);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Controls.Add(this.button_addsup);
            this.groupBox2.Controls.Add(this.comboBox_cust);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_price);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_weight);
            this.groupBox2.Controls.Add(this.dataGridView_items);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(9, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(769, 370);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(584, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "المستلم";
            // 
            // comboBox_type
            // 
            this.comboBox_type.Font = new System.Drawing.Font("Tahoma", 9F);
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "نقدية",
            "آجلة"});
            this.comboBox_type.Location = new System.Drawing.Point(658, 25);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(88, 22);
            this.comboBox_type.TabIndex = 7;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // textBox_tax
            // 
            this.textBox_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tax.Location = new System.Drawing.Point(198, 59);
            this.textBox_tax.Name = "textBox_tax";
            this.textBox_tax.Size = new System.Drawing.Size(88, 21);
            this.textBox_tax.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(292, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 54;
            this.label10.Text = "العمولة";
            // 
            // textBox_qty
            // 
            this.textBox_qty.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textBox_qty.Location = new System.Drawing.Point(642, 59);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(61, 22);
            this.textBox_qty.TabIndex = 8;
            // 
            // button_ref
            // 
            this.button_ref.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button_ref.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_ref.Location = new System.Drawing.Point(171, 23);
            this.button_ref.Name = "button_ref";
            this.button_ref.Size = new System.Drawing.Size(57, 26);
            this.button_ref.TabIndex = 6;
            this.button_ref.Text = "تحديث";
            this.button_ref.UseVisualStyleBackColor = true;
            this.button_ref.Click += new System.EventHandler(this.button_ref_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_add.Location = new System.Drawing.Point(11, 26);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(65, 54);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "اضافة";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_addsup
            // 
            this.button_addsup.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button_addsup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_addsup.Location = new System.Drawing.Point(234, 23);
            this.button_addsup.Name = "button_addsup";
            this.button_addsup.Size = new System.Drawing.Size(95, 26);
            this.button_addsup.TabIndex = 5;
            this.button_addsup.Text = "اضافة عميل";
            this.button_addsup.UseVisualStyleBackColor = true;
            this.button_addsup.Click += new System.EventHandler(this.button_addsup_Click);
            // 
            // comboBox_unit
            // 
            this.comboBox_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_unit.FormattingEnabled = true;
            this.comboBox_unit.Items.AddRange(new object[] {
            "جوال",
            "باليتة"});
            this.comboBox_unit.Location = new System.Drawing.Point(53, 56);
            this.comboBox_unit.Name = "comboBox_unit";
            this.comboBox_unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_unit.Size = new System.Drawing.Size(71, 23);
            this.comboBox_unit.TabIndex = 9;
            this.comboBox_unit.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboBox_pno);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox_unit);
            this.groupBox3.Controls.Add(this.label_ava);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox_item);
            this.groupBox3.Controls.Add(this.comboBox_Cat);
            this.groupBox3.Controls.Add(this.dateTimePicker_adddate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(9, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(769, 141);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(687, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "رقم العملية";
            // 
            // comboBox_pno
            // 
            this.comboBox_pno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_pno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_pno.FormattingEnabled = true;
            this.comboBox_pno.Location = new System.Drawing.Point(359, 27);
            this.comboBox_pno.Name = "comboBox_pno";
            this.comboBox_pno.Size = new System.Drawing.Size(300, 23);
            this.comboBox_pno.TabIndex = 0;
            this.comboBox_pno.SelectedIndexChanged += new System.EventHandler(this.comboBox_pno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(252, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "الكمية المتاحة";
            // 
            // label_ava
            // 
            this.label_ava.Enabled = false;
            this.label_ava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ava.Location = new System.Drawing.Point(158, 94);
            this.label_ava.Name = "label_ava";
            this.label_ava.Size = new System.Drawing.Size(88, 21);
            this.label_ava.TabIndex = 16;
            // 
            // TransferSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(785, 565);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TransferSales";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.Load += new System.EventHandler(this.TransferSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_qty)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox comboBox_Cat;
        private System.Windows.Forms.ComboBox comboBox_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_items;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_adddate;
        private System.Windows.Forms.ComboBox comboBox_cust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_ref;
        private System.Windows.Forms.Button button_addsup;
        private System.Windows.Forms.NumericUpDown textBox_qty;
        private System.Windows.Forms.ComboBox comboBox_unit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox label_ava;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_pno;
        private System.Windows.Forms.TextBox textBox_tax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvaliableQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn السعر;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trasomola;
    }
}