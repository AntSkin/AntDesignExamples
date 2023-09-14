namespace Overview.Controls
{
    partial class Checkbox
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
            checkbox1 = new AntDesign.Checkbox();
            checkbox2 = new AntDesign.Checkbox();
            checkbox3 = new AntDesign.Checkbox();
            header1 = new AntDesign.Header();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkbox4 = new AntDesign.Checkbox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkbox1
            // 
            checkbox1.AutoSize = true;
            checkbox1.Location = new Point(3, 3);
            checkbox1.Name = "checkbox1";
            checkbox1.Size = new Size(114, 50);
            checkbox1.TabIndex = 0;
            checkbox1.Text = "选项1";
            checkbox1.CheckedChanged += Checkbox_CheckedChanged;
            // 
            // checkbox2
            // 
            checkbox2.AutoSize = true;
            checkbox2.Enabled = false;
            checkbox2.Location = new Point(123, 3);
            checkbox2.Name = "checkbox2";
            checkbox2.Size = new Size(202, 50);
            checkbox2.TabIndex = 0;
            checkbox2.Text = "选项2（禁用）";
            checkbox2.CheckedChanged += Checkbox_CheckedChanged;
            // 
            // checkbox3
            // 
            checkbox3.AutoSize = true;
            checkbox3.Checked = true;
            checkbox3.Color = Color.Red;
            checkbox3.Location = new Point(331, 3);
            checkbox3.Name = "checkbox3";
            checkbox3.RightToLeft = RightToLeft.Yes;
            checkbox3.Size = new Size(114, 50);
            checkbox3.TabIndex = 0;
            checkbox3.Text = "选项3";
            checkbox3.CheckedChanged += Checkbox_CheckedChanged;
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
            header1.Text = "Checkbox 多选框";
            header1.TextDesc = "多选框。";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(checkbox1);
            flowLayoutPanel1.Controls.Add(checkbox2);
            flowLayoutPanel1.Controls.Add(checkbox3);
            flowLayoutPanel1.Controls.Add(checkbox4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 79);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(543, 136);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // checkbox4
            // 
            checkbox4.AutoSize = true;
            checkbox4.Checked = true;
            checkbox4.Enabled = false;
            checkbox4.Location = new Point(3, 59);
            checkbox4.Name = "checkbox4";
            checkbox4.Size = new Size(202, 50);
            checkbox4.TabIndex = 0;
            checkbox4.Text = "选项4（禁用）";
            checkbox4.CheckedChanged += Checkbox_CheckedChanged;
            // 
            // Checkbox
            // 
            Controls.Add(flowLayoutPanel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Checkbox";
            Size = new Size(543, 215);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntDesign.Checkbox checkbox1;
        private AntDesign.Checkbox checkbox2;
        private AntDesign.Checkbox checkbox3;
        private AntDesign.Header header1;
        private FlowLayoutPanel flowLayoutPanel1;
        private AntDesign.Checkbox checkbox4;
    }
}