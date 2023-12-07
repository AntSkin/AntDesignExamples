// COPYRIGHT (C) Tom. ALL RIGHTS RESERVED.
// THE AntDesignExamples PROJECT IS AN WINFORM LIBRARY LICENSED UNDER THE Apache-2.0 License.
// LICENSED UNDER THE Apache License, VERSION 2.0 (THE "License");
// YOU MAY NOT USE THIS FILE EXCEPT IN COMPLIANCE WITH THE License.
// YOU MAY OBTAIN A COPY OF THE LICENSE AT
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING, SOFTWARE
// DISTRIBUTED UNDER THE LICENSE IS DISTRIBUTED ON AN "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED.
// SEE THE LICENSE FOR THE SPECIFIC LANGUAGE GOVERNING PERMISSIONS AND
// LIMITATIONS UNDER THE License.
// GITHUB: https://github.com/AntSkin/AntDesignExamples
// CSDN: https://blog.csdn.net/v_132
// QQ: 17379620

namespace Overview.Controls
{
    partial class DatePicker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            header1 = new AntDesign.Header();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            datePickerRange1 = new AntDesign.DatePickerRange();
            inputRange1 = new AntDesign.DatePickerRange();
            divider2 = new AntDesign.Divider();
            panel2 = new System.Windows.Forms.Panel();
            datePicker3 = new AntDesign.DatePicker();
            datePicker2 = new AntDesign.DatePicker();
            datePicker1 = new AntDesign.DatePicker();
            divider1 = new AntDesign.Divider();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Padding = new Padding(6);
            header1.Size = new Size(614, 79);
            header1.TabIndex = 4;
            header1.Text = "DatePicker 日期选择框";
            header1.TextDesc = "输入或选择日期的控件。";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(divider2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(divider1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 367);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(datePickerRange1);
            panel3.Controls.Add(inputRange1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 118);
            panel3.TabIndex = 5;
            // 
            // datePickerRange1
            // 
            datePickerRange1.Location = new Point(19, 61);
            datePickerRange1.Name = "datePickerRange1";
            datePickerRange1.Size = new Size(300, 40);
            datePickerRange1.TabIndex = 23;
            // 
            // inputRange1
            // 
            inputRange1.Location = new Point(19, 15);
            inputRange1.Name = "inputRange1";
            inputRange1.PlaceholderEnd = "结束日期";
            inputRange1.PlaceholderStart = "开始日期";
            inputRange1.Size = new Size(300, 40);
            inputRange1.TabIndex = 24;
            // 
            // divider2
            // 
            divider2.Dock = DockStyle.Top;
            divider2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider2.Location = new Point(0, 140);
            divider2.Name = "divider2";
            divider2.Orientation = AntDesign.TOrientation.Left;
            divider2.Size = new Size(614, 22);
            divider2.TabIndex = 4;
            divider2.Text = "日期范围";
            // 
            // panel2
            // 
            panel2.Controls.Add(datePicker3);
            panel2.Controls.Add(datePicker2);
            panel2.Controls.Add(datePicker1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(614, 118);
            panel2.TabIndex = 3;
            // 
            // datePicker3
            // 
            datePicker3.AllowClear = true;
            datePicker3.BackColor = Color.Transparent;
            datePicker3.DropDownArrow = true;
            datePicker3.Location = new Point(19, 56);
            datePicker3.Name = "datePicker3";
            datePicker3.PlaceholderText = "请选择日期";
            datePicker3.Size = new Size(148, 44);
            datePicker3.TabIndex = 20;
            datePicker3.Text = "2013-11-11";
            datePicker3.Value = new DateTime(2013, 11, 11, 0, 0, 0, 0);
            // 
            // datePicker2
            // 
            datePicker2.AllowClear = true;
            datePicker2.BackColor = Color.Transparent;
            datePicker2.Location = new Point(253, 6);
            datePicker2.Name = "datePicker2";
            datePicker2.Placement = AntDesign.TAlignFrom.BR;
            datePicker2.Size = new Size(200, 44);
            datePicker2.TabIndex = 20;
            // 
            // datePicker1
            // 
            datePicker1.BackColor = Color.Transparent;
            datePicker1.Location = new Point(19, 6);
            datePicker1.Name = "datePicker1";
            datePicker1.PlaceholderText = "请选择日期";
            datePicker1.Size = new Size(200, 44);
            datePicker1.TabIndex = 21;
            // 
            // divider1
            // 
            divider1.Dock = DockStyle.Top;
            divider1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider1.Location = new Point(0, 0);
            divider1.Name = "divider1";
            divider1.Orientation = AntDesign.TOrientation.Left;
            divider1.Size = new Size(614, 22);
            divider1.TabIndex = 2;
            divider1.Text = "选择日期";
            // 
            // DatePicker
            // 
            Controls.Add(panel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "DatePicker";
            Size = new Size(614, 446);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntDesign.Header header1;
        private System.Windows.Forms.Panel panel1;
        private AntDesign.Divider divider1;
        private System.Windows.Forms.Panel panel2;
        private AntDesign.DatePicker datePicker2;
        private AntDesign.DatePicker datePicker1;
        private AntDesign.DatePicker datePicker3;
        private System.Windows.Forms.Panel panel3;
        private AntDesign.Divider divider2;
        private AntDesign.DatePickerRange datePickerRange1;
        private AntDesign.DatePickerRange inputRange1;
    }
}