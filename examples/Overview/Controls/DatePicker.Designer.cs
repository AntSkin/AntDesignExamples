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
            panel2 = new System.Windows.Forms.Panel();
            datePicker3 = new AntDesign.DatePicker();
            datePicker2 = new AntDesign.DatePicker();
            datePicker1 = new AntDesign.DatePicker();
            divider1 = new AntDesign.Divider();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(divider1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 367);
            panel1.TabIndex = 6;
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
            datePicker2.Size = new Size(200, 44);
            datePicker2.TabIndex = 20;
            datePicker2.Text = "";
            // 
            // datePicker1
            // 
            datePicker1.BackColor = Color.Transparent;
            datePicker1.Location = new Point(19, 6);
            datePicker1.Name = "datePicker1";
            datePicker1.PlaceholderText = "请选择日期";
            datePicker1.Size = new Size(200, 44);
            datePicker1.TabIndex = 21;
            datePicker1.Text = "";
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
    }
}