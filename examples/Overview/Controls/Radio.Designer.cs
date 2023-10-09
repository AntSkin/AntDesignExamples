namespace Overview.Controls
{
    partial class Radio
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
            radio1 = new AntDesign.Radio();
            radio2 = new AntDesign.Radio();
            radio3 = new AntDesign.Radio();
            header1 = new AntDesign.Header();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radio4 = new AntDesign.Radio();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // radio1
            // 
            radio1.AutoSize = AntDesign.TAutoSize.Auto;
            radio1.Location = new Point(3, 3);
            radio1.Name = "radio1";
            radio1.Size = new Size(114, 50);
            radio1.TabIndex = 0;
            radio1.Text = "选项1";
            radio1.CheckedChanged += radio_CheckedChanged;
            // 
            // radio2
            // 
            radio2.AutoSize = AntDesign.TAutoSize.Auto;
            radio2.Enabled = false;
            radio2.Location = new Point(123, 3);
            radio2.Name = "radio2";
            radio2.Size = new Size(202, 50);
            radio2.TabIndex = 0;
            radio2.Text = "选项2（禁用）";
            radio2.CheckedChanged += radio_CheckedChanged;
            // 
            // radio3
            // 
            radio3.AutoSize = AntDesign.TAutoSize.Auto;
            radio3.Checked = true;
            radio3.Color = Color.Red;
            radio3.Location = new Point(331, 3);
            radio3.Name = "radio3";
            radio3.RightToLeft = RightToLeft.Yes;
            radio3.Size = new Size(114, 50);
            radio3.TabIndex = 0;
            radio3.Text = "选项3";
            radio3.CheckedChanged += radio_CheckedChanged;
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Padding = new Padding(6);
            header1.Size = new Size(543, 79);
            header1.TabIndex = 5;
            header1.Text = "Radio 单选框";
            header1.TextDesc = "单选框。";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(radio1);
            flowLayoutPanel1.Controls.Add(radio2);
            flowLayoutPanel1.Controls.Add(radio3);
            flowLayoutPanel1.Controls.Add(radio4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 79);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(543, 136);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // radio4
            // 
            radio4.AutoSize = AntDesign.TAutoSize.Auto;
            radio4.Checked = true;
            radio4.Enabled = false;
            radio4.Location = new Point(3, 59);
            radio4.Name = "radio4";
            radio4.Size = new Size(202, 50);
            radio4.TabIndex = 0;
            radio4.Text = "选项4（禁用）";
            radio4.CheckedChanged += radio_CheckedChanged;
            // 
            // Radio
            // 
            Controls.Add(flowLayoutPanel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Radio";
            Size = new Size(543, 215);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntDesign.Radio radio1;
        private AntDesign.Radio radio2;
        private AntDesign.Radio radio3;
        private AntDesign.Header header1;
        private FlowLayoutPanel flowLayoutPanel1;
        private AntDesign.Radio radio4;
    }
}