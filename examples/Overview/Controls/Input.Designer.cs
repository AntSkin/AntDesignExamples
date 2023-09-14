namespace Overview.Controls
{
    partial class Input
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
            input1 = new AntDesign.Input();
            input2 = new AntDesign.Input();
            input3 = new AntDesign.Input();
            input4 = new AntDesign.Input();
            input5 = new AntDesign.Input();
            input6 = new AntDesign.Input();
            header1 = new AntDesign.Header();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // input1
            // 
            input1.Location = new Point(3, 3);
            input1.Name = "input1";
            input1.Size = new Size(220, 60);
            input1.TabIndex = 0;
            input1.Text = "input1";
            // 
            // input2
            // 
            input2.AutoSize = true;
            input2.Location = new Point(3, 69);
            input2.Name = "input2";
            input2.Size = new Size(226, 48);
            input2.TabIndex = 0;
            input2.Text = "input1";
            // 
            // input3
            // 
            input3.Location = new Point(229, 3);
            input3.Name = "input3";
            input3.PlaceholderText = "请输入账号";
            input3.Round = true;
            input3.Size = new Size(220, 50);
            input3.TabIndex = 0;
            input3.Text = "";
            // 
            // input4
            // 
            input4.AutoSize = true;
            input4.Location = new Point(267, 187);
            input4.Name = "input4";
            input4.PasswordChar = '●';
            input4.Radius = 20;
            input4.Size = new Size(226, 50);
            input4.TabIndex = 0;
            input4.Text = "321";
            // 
            // input5
            // 
            input5.AutoSize = true;
            input5.Image = Properties.Resources.close;
            input5.Location = new Point(235, 69);
            input5.Name = "input5";
            input5.Radius = 20;
            input5.Size = new Size(226, 48);
            input5.TabIndex = 0;
            input5.Text = "321";
            // 
            // input6
            // 
            input6.BackColor = Color.Black;
            input6.BorderColor = Color.FromArgb(76, 76, 76);
            input6.BorderWidth = 4F;
            input6.Mode = AntDesign.TMode.Dark;
            input6.ForeColor = Color.White;
            input6.Location = new Point(3, 123);
            input6.Name = "input6";
            input6.Size = new Size(226, 55);
            input6.TabIndex = 0;
            input6.Text = "input1";
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Padding = new Padding(6);
            header1.Size = new Size(543, 79);
            header1.TabIndex = 4;
            header1.Text = "Input 输入框";
            header1.TextDesc = "通过鼠标或键盘输入内容，是最基础的表单域的包装。";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(input1);
            flowLayoutPanel1.Controls.Add(input3);
            flowLayoutPanel1.Controls.Add(input2);
            flowLayoutPanel1.Controls.Add(input4);
            flowLayoutPanel1.Controls.Add(input5);
            flowLayoutPanel1.Controls.Add(input6);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 79);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(543, 196);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // Input
            // 
            Controls.Add(flowLayoutPanel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Input";
            Size = new Size(543, 275);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntDesign.Input input1;
        private AntDesign.Input input2;
        private AntDesign.Input input3;
        private AntDesign.Input input4;
        private AntDesign.Input input5;
        private AntDesign.Input input6;
        private AntDesign.Header header1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}