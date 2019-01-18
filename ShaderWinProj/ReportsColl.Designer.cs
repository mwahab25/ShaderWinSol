namespace ShaderWinProj
{
    partial class ReportsColl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsColl));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_filter = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.radioButton_bydate = new System.Windows.Forms.RadioButton();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.radioButton_daily = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_purshow = new System.Windows.Forms.Button();
            this.comboBox_pursup = new System.Windows.Forms.ComboBox();
            this.comboBox_puritem = new System.Windows.Forms.ComboBox();
            this.comboBox_purcat = new System.Windows.Forms.ComboBox();
            this.checkBox_pursup = new System.Windows.Forms.CheckBox();
            this.checkBox_puritem = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_distshow = new System.Windows.Forms.Button();
            this.comboBox_distcust = new System.Windows.Forms.ComboBox();
            this.comboBox_distitem = new System.Windows.Forms.ComboBox();
            this.comboBox_distcat = new System.Windows.Forms.ComboBox();
            this.checkBox_distcust = new System.Windows.Forms.CheckBox();
            this.checkBox_distitem = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_salesshow = new System.Windows.Forms.Button();
            this.comboBox_salescust = new System.Windows.Forms.ComboBox();
            this.checkBox_salescust = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_filter);
            this.groupBox2.Controls.Add(this.dateTimePicker_to);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker_from);
            this.groupBox2.Controls.Add(this.radioButton_bydate);
            this.groupBox2.Controls.Add(this.radioButton_all);
            this.groupBox2.Controls.Add(this.radioButton_daily);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(8, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(770, 65);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ضبط التقارير";
            // 
            // comboBox_filter
            // 
            this.comboBox_filter.FormattingEnabled = true;
            this.comboBox_filter.Items.AddRange(new object[] {
            "فرز تصاعدي",
            "فرز تنازلي"});
            this.comboBox_filter.Location = new System.Drawing.Point(9, 24);
            this.comboBox_filter.Name = "comboBox_filter";
            this.comboBox_filter.Size = new System.Drawing.Size(93, 22);
            this.comboBox_filter.TabIndex = 28;
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_to.Location = new System.Drawing.Point(120, 25);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(131, 21);
            this.dateTimePicker_to.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(257, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "حتي تاريخ";
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_from.Location = new System.Drawing.Point(320, 25);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(131, 21);
            this.dateTimePicker_from.TabIndex = 12;
            // 
            // radioButton_bydate
            // 
            this.radioButton_bydate.AutoSize = true;
            this.radioButton_bydate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.radioButton_bydate.ForeColor = System.Drawing.Color.Black;
            this.radioButton_bydate.Location = new System.Drawing.Point(457, 25);
            this.radioButton_bydate.Name = "radioButton_bydate";
            this.radioButton_bydate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_bydate.Size = new System.Drawing.Size(123, 18);
            this.radioButton_bydate.TabIndex = 2;
            this.radioButton_bydate.Text = "تقرير محدد من تاريخ";
            this.radioButton_bydate.UseVisualStyleBackColor = true;
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Checked = true;
            this.radioButton_all.Font = new System.Drawing.Font("Tahoma", 9F);
            this.radioButton_all.ForeColor = System.Drawing.Color.Black;
            this.radioButton_all.Location = new System.Drawing.Point(586, 25);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_all.Size = new System.Drawing.Size(82, 18);
            this.radioButton_all.TabIndex = 1;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "تقرير شامل";
            this.radioButton_all.UseVisualStyleBackColor = true;
            // 
            // radioButton_daily
            // 
            this.radioButton_daily.AutoSize = true;
            this.radioButton_daily.Font = new System.Drawing.Font("Tahoma", 9F);
            this.radioButton_daily.ForeColor = System.Drawing.Color.Black;
            this.radioButton_daily.Location = new System.Drawing.Point(674, 25);
            this.radioButton_daily.Name = "radioButton_daily";
            this.radioButton_daily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_daily.Size = new System.Drawing.Size(77, 18);
            this.radioButton_daily.TabIndex = 0;
            this.radioButton_daily.Text = "تقرير يومي";
            this.radioButton_daily.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_purshow);
            this.groupBox1.Controls.Add(this.comboBox_pursup);
            this.groupBox1.Controls.Add(this.comboBox_puritem);
            this.groupBox1.Controls.Add(this.comboBox_purcat);
            this.groupBox1.Controls.Add(this.checkBox_pursup);
            this.groupBox1.Controls.Add(this.checkBox_puritem);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(8, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(770, 177);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تقرير المشتريات";
            // 
            // button_purshow
            // 
            this.button_purshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_purshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_purshow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_purshow.ForeColor = System.Drawing.Color.Black;
            this.button_purshow.Location = new System.Drawing.Point(666, 134);
            this.button_purshow.Name = "button_purshow";
            this.button_purshow.Size = new System.Drawing.Size(85, 29);
            this.button_purshow.TabIndex = 27;
            this.button_purshow.Text = "عرض";
            this.button_purshow.UseVisualStyleBackColor = true;
            this.button_purshow.Click += new System.EventHandler(this.button_purshow_Click);
            // 
            // comboBox_pursup
            // 
            this.comboBox_pursup.Enabled = false;
            this.comboBox_pursup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_pursup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_pursup.FormattingEnabled = true;
            this.comboBox_pursup.Location = new System.Drawing.Point(398, 98);
            this.comboBox_pursup.Name = "comboBox_pursup";
            this.comboBox_pursup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_pursup.Size = new System.Drawing.Size(353, 23);
            this.comboBox_pursup.TabIndex = 26;
            // 
            // comboBox_puritem
            // 
            this.comboBox_puritem.Enabled = false;
            this.comboBox_puritem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_puritem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_puritem.FormattingEnabled = true;
            this.comboBox_puritem.Location = new System.Drawing.Point(398, 62);
            this.comboBox_puritem.Name = "comboBox_puritem";
            this.comboBox_puritem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_puritem.Size = new System.Drawing.Size(227, 23);
            this.comboBox_puritem.TabIndex = 25;
            // 
            // comboBox_purcat
            // 
            this.comboBox_purcat.Enabled = false;
            this.comboBox_purcat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_purcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_purcat.FormattingEnabled = true;
            this.comboBox_purcat.Location = new System.Drawing.Point(633, 62);
            this.comboBox_purcat.Name = "comboBox_purcat";
            this.comboBox_purcat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_purcat.Size = new System.Drawing.Size(118, 23);
            this.comboBox_purcat.TabIndex = 24;
            this.comboBox_purcat.SelectedIndexChanged += new System.EventHandler(this.comboBox_purcat_SelectedIndexChanged);
            // 
            // checkBox_pursup
            // 
            this.checkBox_pursup.AutoSize = true;
            this.checkBox_pursup.Location = new System.Drawing.Point(577, 29);
            this.checkBox_pursup.Name = "checkBox_pursup";
            this.checkBox_pursup.Size = new System.Drawing.Size(78, 18);
            this.checkBox_pursup.TabIndex = 23;
            this.checkBox_pursup.Text = "مورد محدد";
            this.checkBox_pursup.UseVisualStyleBackColor = true;
            this.checkBox_pursup.CheckedChanged += new System.EventHandler(this.checkBox_pursup_CheckedChanged);
            // 
            // checkBox_puritem
            // 
            this.checkBox_puritem.AutoSize = true;
            this.checkBox_puritem.Location = new System.Drawing.Point(669, 29);
            this.checkBox_puritem.Name = "checkBox_puritem";
            this.checkBox_puritem.Size = new System.Drawing.Size(81, 18);
            this.checkBox_puritem.TabIndex = 22;
            this.checkBox_puritem.Text = "صنف محدد";
            this.checkBox_puritem.UseVisualStyleBackColor = true;
            this.checkBox_puritem.CheckedChanged += new System.EventHandler(this.checkBox_puritem_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_distshow);
            this.groupBox3.Controls.Add(this.comboBox_distcust);
            this.groupBox3.Controls.Add(this.comboBox_distitem);
            this.groupBox3.Controls.Add(this.comboBox_distcat);
            this.groupBox3.Controls.Add(this.checkBox_distcust);
            this.groupBox3.Controls.Add(this.checkBox_distitem);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(8, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(770, 188);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تقرير التوزيع علي العملاء";
            // 
            // button_distshow
            // 
            this.button_distshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_distshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_distshow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_distshow.ForeColor = System.Drawing.Color.Black;
            this.button_distshow.Location = new System.Drawing.Point(666, 142);
            this.button_distshow.Name = "button_distshow";
            this.button_distshow.Size = new System.Drawing.Size(85, 29);
            this.button_distshow.TabIndex = 21;
            this.button_distshow.Text = "عرض";
            this.button_distshow.UseVisualStyleBackColor = true;
            this.button_distshow.Click += new System.EventHandler(this.button_distshow_Click);
            // 
            // comboBox_distcust
            // 
            this.comboBox_distcust.Enabled = false;
            this.comboBox_distcust.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_distcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_distcust.FormattingEnabled = true;
            this.comboBox_distcust.Location = new System.Drawing.Point(398, 103);
            this.comboBox_distcust.Name = "comboBox_distcust";
            this.comboBox_distcust.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_distcust.Size = new System.Drawing.Size(351, 23);
            this.comboBox_distcust.TabIndex = 20;
            // 
            // comboBox_distitem
            // 
            this.comboBox_distitem.Enabled = false;
            this.comboBox_distitem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_distitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_distitem.FormattingEnabled = true;
            this.comboBox_distitem.Location = new System.Drawing.Point(398, 66);
            this.comboBox_distitem.Name = "comboBox_distitem";
            this.comboBox_distitem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_distitem.Size = new System.Drawing.Size(227, 23);
            this.comboBox_distitem.TabIndex = 19;
            // 
            // comboBox_distcat
            // 
            this.comboBox_distcat.Enabled = false;
            this.comboBox_distcat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_distcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_distcat.FormattingEnabled = true;
            this.comboBox_distcat.Location = new System.Drawing.Point(631, 66);
            this.comboBox_distcat.Name = "comboBox_distcat";
            this.comboBox_distcat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_distcat.Size = new System.Drawing.Size(118, 23);
            this.comboBox_distcat.TabIndex = 18;
            this.comboBox_distcat.SelectedIndexChanged += new System.EventHandler(this.comboBox_distcat_SelectedIndexChanged);
            // 
            // checkBox_distcust
            // 
            this.checkBox_distcust.AutoSize = true;
            this.checkBox_distcust.Location = new System.Drawing.Point(577, 33);
            this.checkBox_distcust.Name = "checkBox_distcust";
            this.checkBox_distcust.Size = new System.Drawing.Size(84, 18);
            this.checkBox_distcust.TabIndex = 17;
            this.checkBox_distcust.Text = "عميل محدد";
            this.checkBox_distcust.UseVisualStyleBackColor = true;
            this.checkBox_distcust.CheckedChanged += new System.EventHandler(this.checkBox_distcust_CheckedChanged);
            // 
            // checkBox_distitem
            // 
            this.checkBox_distitem.AutoSize = true;
            this.checkBox_distitem.Location = new System.Drawing.Point(669, 33);
            this.checkBox_distitem.Name = "checkBox_distitem";
            this.checkBox_distitem.Size = new System.Drawing.Size(81, 18);
            this.checkBox_distitem.TabIndex = 16;
            this.checkBox_distitem.Text = "صنف محدد";
            this.checkBox_distitem.UseVisualStyleBackColor = true;
            this.checkBox_distitem.CheckedChanged += new System.EventHandler(this.checkBox_distitem_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_salesshow);
            this.groupBox4.Controls.Add(this.comboBox_salescust);
            this.groupBox4.Controls.Add(this.checkBox_salescust);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(8, 450);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(770, 140);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "فواتير المبيعات";
            // 
            // button_salesshow
            // 
            this.button_salesshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_salesshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salesshow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salesshow.ForeColor = System.Drawing.Color.Black;
            this.button_salesshow.Location = new System.Drawing.Point(665, 96);
            this.button_salesshow.Name = "button_salesshow";
            this.button_salesshow.Size = new System.Drawing.Size(84, 29);
            this.button_salesshow.TabIndex = 22;
            this.button_salesshow.Text = "عرض";
            this.button_salesshow.UseVisualStyleBackColor = true;
            this.button_salesshow.Click += new System.EventHandler(this.button_salesshow_Click);
            // 
            // comboBox_salescust
            // 
            this.comboBox_salescust.Enabled = false;
            this.comboBox_salescust.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_salescust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_salescust.FormattingEnabled = true;
            this.comboBox_salescust.Location = new System.Drawing.Point(398, 58);
            this.comboBox_salescust.Name = "comboBox_salescust";
            this.comboBox_salescust.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_salescust.Size = new System.Drawing.Size(351, 23);
            this.comboBox_salescust.TabIndex = 21;
            // 
            // checkBox_salescust
            // 
            this.checkBox_salescust.AutoSize = true;
            this.checkBox_salescust.Location = new System.Drawing.Point(665, 30);
            this.checkBox_salescust.Name = "checkBox_salescust";
            this.checkBox_salescust.Size = new System.Drawing.Size(84, 18);
            this.checkBox_salescust.TabIndex = 18;
            this.checkBox_salescust.Text = "عميل محدد";
            this.checkBox_salescust.UseVisualStyleBackColor = true;
            this.checkBox_salescust.CheckedChanged += new System.EventHandler(this.checkBox_salescust_CheckedChanged);
            // 
            // ReportsColl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(784, 596);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportsColl";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التقارير";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_bydate;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.RadioButton radioButton_daily;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_purshow;
        private System.Windows.Forms.ComboBox comboBox_pursup;
        private System.Windows.Forms.ComboBox comboBox_puritem;
        private System.Windows.Forms.ComboBox comboBox_purcat;
        private System.Windows.Forms.CheckBox checkBox_pursup;
        private System.Windows.Forms.CheckBox checkBox_puritem;
        private System.Windows.Forms.Button button_distshow;
        private System.Windows.Forms.ComboBox comboBox_distcust;
        private System.Windows.Forms.ComboBox comboBox_distitem;
        private System.Windows.Forms.ComboBox comboBox_distcat;
        private System.Windows.Forms.CheckBox checkBox_distcust;
        private System.Windows.Forms.CheckBox checkBox_distitem;
        private System.Windows.Forms.Button button_salesshow;
        private System.Windows.Forms.ComboBox comboBox_salescust;
        private System.Windows.Forms.CheckBox checkBox_salescust;
        private System.Windows.Forms.ComboBox comboBox_filter;
    }
}