namespace ShaderWinProj
{
    partial class Purchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchases));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_pno = new System.Windows.Forms.ComboBox();
            this.button_ref = new System.Windows.Forms.Button();
            this.button_addsup = new System.Windows.Forms.Button();
            this.comboBox_Sup = new System.Windows.Forms.ComboBox();
            this.comboBox_User = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_adddate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Cat = new System.Windows.Forms.ComboBox();
            this.comboBox_item = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_qty = new System.Windows.Forms.NumericUpDown();
            this.comboBox_unit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView_items = new System.Windows.Forms.DataGridView();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvaliableQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_save = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_pno);
            this.groupBox1.Controls.Add(this.button_ref);
            this.groupBox1.Controls.Add(this.button_addsup);
            this.groupBox1.Controls.Add(this.comboBox_Sup);
            this.groupBox1.Controls.Add(this.comboBox_User);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker_adddate);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(880, 198);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(798, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "رقم العملية";
            // 
            // comboBox_pno
            // 
            this.comboBox_pno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_pno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox_pno.FormattingEnabled = true;
            this.comboBox_pno.Location = new System.Drawing.Point(404, 26);
            this.comboBox_pno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_pno.Name = "comboBox_pno";
            this.comboBox_pno.Size = new System.Drawing.Size(349, 26);
            this.comboBox_pno.TabIndex = 1;
            this.comboBox_pno.SelectedIndexChanged += new System.EventHandler(this.comboBox_pno_SelectedIndexChanged);
            // 
            // button_ref
            // 
            this.button_ref.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button_ref.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_ref.Location = new System.Drawing.Point(202, 151);
            this.button_ref.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ref.Name = "button_ref";
            this.button_ref.Size = new System.Drawing.Size(66, 32);
            this.button_ref.TabIndex = 6;
            this.button_ref.Text = "تحديث";
            this.button_ref.UseVisualStyleBackColor = true;
            this.button_ref.Click += new System.EventHandler(this.button_ref_Click);
            // 
            // button_addsup
            // 
            this.button_addsup.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button_addsup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_addsup.Location = new System.Drawing.Point(275, 151);
            this.button_addsup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_addsup.Name = "button_addsup";
            this.button_addsup.Size = new System.Drawing.Size(111, 32);
            this.button_addsup.TabIndex = 5;
            this.button_addsup.Text = "اضافة مورد";
            this.button_addsup.UseVisualStyleBackColor = true;
            this.button_addsup.Click += new System.EventHandler(this.button_addsup_Click);
            // 
            // comboBox_Sup
            // 
            this.comboBox_Sup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox_Sup.FormattingEnabled = true;
            this.comboBox_Sup.Location = new System.Drawing.Point(404, 151);
            this.comboBox_Sup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Sup.Name = "comboBox_Sup";
            this.comboBox_Sup.Size = new System.Drawing.Size(349, 26);
            this.comboBox_Sup.TabIndex = 4;
            // 
            // comboBox_User
            // 
            this.comboBox_User.Enabled = false;
            this.comboBox_User.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox_User.FormattingEnabled = true;
            this.comboBox_User.Location = new System.Drawing.Point(404, 108);
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
            this.label5.Location = new System.Drawing.Point(827, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "المورد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(806, 113);
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
            this.label6.Location = new System.Drawing.Point(834, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "تاريخ";
            // 
            // dateTimePicker_adddate
            // 
            this.dateTimePicker_adddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePicker_adddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_adddate.Location = new System.Drawing.Point(404, 68);
            this.dateTimePicker_adddate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_adddate.Name = "dateTimePicker_adddate";
            this.dateTimePicker_adddate.RightToLeftLayout = true;
            this.dateTimePicker_adddate.Size = new System.Drawing.Size(349, 24);
            this.dateTimePicker_adddate.TabIndex = 2;
            // 
            // comboBox_Cat
            // 
            this.comboBox_Cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox_Cat.FormattingEnabled = true;
            this.comboBox_Cat.Items.AddRange(new object[] {
            "خضار",
            "فاكهة"});
            this.comboBox_Cat.Location = new System.Drawing.Point(391, 26);
            this.comboBox_Cat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Cat.Name = "comboBox_Cat";
            this.comboBox_Cat.Size = new System.Drawing.Size(349, 26);
            this.comboBox_Cat.TabIndex = 7;
            this.comboBox_Cat.Visible = false;
            this.comboBox_Cat.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cat_SelectedIndexChanged);
            // 
            // comboBox_item
            // 
            this.comboBox_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_item.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox_item.FormattingEnabled = true;
            this.comboBox_item.Items.AddRange(new object[] {
            "طماطم",
            "خيار"});
            this.comboBox_item.Location = new System.Drawing.Point(391, 26);
            this.comboBox_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_item.Name = "comboBox_item";
            this.comboBox_item.Size = new System.Drawing.Size(349, 26);
            this.comboBox_item.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(821, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "الصنف";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_qty);
            this.groupBox2.Controls.Add(this.comboBox_unit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Controls.Add(this.dataGridView_items);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_item);
            this.groupBox2.Controls.Add(this.comboBox_Cat);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(9, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(880, 482);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // textBox_qty
            // 
            this.textBox_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox_qty.Location = new System.Drawing.Point(214, 27);
            this.textBox_qty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(83, 24);
            this.textBox_qty.TabIndex = 9;
            // 
            // comboBox_unit
            // 
            this.comboBox_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox_unit.FormattingEnabled = true;
            this.comboBox_unit.Items.AddRange(new object[] {
            "جوال",
            "باليتة"});
            this.comboBox_unit.Location = new System.Drawing.Point(111, 26);
            this.comboBox_unit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_unit.Name = "comboBox_unit";
            this.comboBox_unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_unit.Size = new System.Drawing.Size(95, 26);
            this.comboBox_unit.TabIndex = 10;
            this.comboBox_unit.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(323, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "العدد";
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_add.Location = new System.Drawing.Point(12, 21);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(77, 65);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "اضافة";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dataGridView_items
            // 
            this.dataGridView_items.AllowUserToAddRows = false;
            this.dataGridView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk,
            this.ItemCode,
            this.ItemName,
            this.AvaliableQty});
            this.dataGridView_items.Location = new System.Drawing.Point(12, 94);
            this.dataGridView_items.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_items.Name = "dataGridView_items";
            this.dataGridView_items.RowHeadersWidth = 51;
            this.dataGridView_items.Size = new System.Drawing.Size(855, 369);
            this.dataGridView_items.TabIndex = 12;
            // 
            // Chk
            // 
            this.Chk.HeaderText = "";
            this.Chk.MinimumWidth = 6;
            this.Chk.Name = "Chk";
            this.Chk.Width = 30;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "كود الصنف";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 120;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "اسم الصنف";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 400;
            // 
            // AvaliableQty
            // 
            this.AvaliableQty.HeaderText = "العدد";
            this.AvaliableQty.MinimumWidth = 6;
            this.AvaliableQty.Name = "AvaliableQty";
            this.AvaliableQty.Width = 140;
            // 
            // button_save
            // 
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Black;
            this.button_save.Location = new System.Drawing.Point(742, 695);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(70, 39);
            this.button_save.TabIndex = 13;
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
            this.button_new.Location = new System.Drawing.Point(819, 695);
            this.button_new.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(70, 39);
            this.button_new.TabIndex = 0;
            this.button_new.Text = "جديد";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(915, 745);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Purchases";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المشتريات";
            this.Load += new System.EventHandler(this.Purchases_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Sup;
        private System.Windows.Forms.ComboBox comboBox_User;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_adddate;
        private System.Windows.Forms.ComboBox comboBox_Cat;
        private System.Windows.Forms.ComboBox comboBox_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_items;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_unit;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_addsup;
        private System.Windows.Forms.Button button_ref;
        private System.Windows.Forms.NumericUpDown textBox_qty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_pno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvaliableQty;
    }
}