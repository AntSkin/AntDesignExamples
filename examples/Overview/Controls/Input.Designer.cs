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
            AntDesign.DividerSelectItem dividerSelectItem2 = new AntDesign.DividerSelectItem();
            input1 = new AntDesign.Input();
            input2 = new AntDesign.Input();
            input3 = new AntDesign.Input();
            input4 = new AntDesign.Input();
            input5 = new AntDesign.Input();
            input6 = new AntDesign.Input();
            header1 = new AntDesign.Header();
            panel1 = new System.Windows.Forms.Panel();
            panel7 = new System.Windows.Forms.Panel();
            panel8 = new System.Windows.Forms.Panel();
            select3 = new AntDesign.Select();
            button4 = new AntDesign.Button();
            select2 = new AntDesign.Select();
            select1 = new AntDesign.Select();
            divider3 = new AntDesign.Divider();
            panel3 = new System.Windows.Forms.Panel();
            panel5 = new AntDesign.Panel();
            input8 = new AntDesign.Input();
            button1 = new AntDesign.Button();
            panel6 = new System.Windows.Forms.Panel();
            input9 = new AntDesign.Input();
            button2 = new AntDesign.Button();
            panel4 = new AntDesign.Panel();
            input7 = new AntDesign.Input();
            button3 = new AntDesign.Button();
            divider2 = new AntDesign.Divider();
            panel2 = new System.Windows.Forms.Panel();
            divider1 = new AntDesign.Divider();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // input1
            // 
            input1.Location = new Point(18, 6);
            input1.Name = "input1";
            input1.Size = new Size(220, 44);
            input1.TabIndex = 0;
            input1.Text = "input1";
            // 
            // input2
            // 
            input2.Location = new Point(18, 54);
            input2.Name = "input2";
            input2.Size = new Size(220, 44);
            input2.TabIndex = 2;
            input2.Text = "input1";
            // 
            // input3
            // 
            input3.Location = new Point(244, 6);
            input3.Name = "input3";
            input3.PlaceholderText = "请输入账号";
            input3.Round = true;
            input3.Size = new Size(220, 44);
            input3.TabIndex = 1;
            input3.Text = "";
            // 
            // input4
            // 
            input4.Location = new Point(244, 54);
            input4.Name = "input4";
            input4.PasswordChar = '●';
            input4.Round = true;
            input4.Size = new Size(220, 44);
            input4.TabIndex = 3;
            input4.Text = "321";
            // 
            // input5
            // 
            input5.Image = Properties.Resources.close;
            input5.Location = new Point(18, 101);
            input5.Name = "input5";
            input5.Radius = 10;
            input5.Size = new Size(220, 44);
            input5.TabIndex = 4;
            input5.Text = "321";
            // 
            // input6
            // 
            input6.BackColor = Color.Black;
            input6.BorderColor = Color.FromArgb(76, 76, 76);
            input6.BorderWidth = 4F;
            input6.ForeColor = Color.White;
            input6.Location = new Point(244, 102);
            input6.Name = "input6";
            input6.Size = new Size(220, 44);
            input6.TabIndex = 5;
            input6.Text = "input1";
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Padding = new Padding(6);
            header1.Size = new Size(555, 79);
            header1.TabIndex = 0;
            header1.TabStop = false;
            header1.Text = "Input 输入框";
            header1.TextDesc = "通过鼠标或键盘输入内容，是最基础的表单域的包装。";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(divider3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(divider2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(divider1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 475);
            panel1.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(select2);
            panel7.Controls.Add(select1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 367);
            panel7.Name = "panel7";
            panel7.Size = new Size(555, 100);
            panel7.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(select3);
            panel8.Controls.Add(button4);
            panel8.Location = new Point(306, 16);
            panel8.Name = "panel8";
            panel8.Size = new Size(220, 46);
            panel8.TabIndex = 2;
            panel8.Text = "panel4";
            // 
            // select3
            // 
            select3.Dock = DockStyle.Fill;
            select3.Items.AddRange(new object[] { "Lucy", "Tom", "AduSkin", "WangLi", "HUAWEI", "XIAOMI" });
            select3.JoinRight = true;
            select3.Location = new Point(0, 0);
            select3.Margins = 6;
            select3.Name = "select3";
            select3.PlaceholderText = "输入点什么搜索";
            select3.Size = new Size(170, 46);
            select3.TabIndex = 0;
            select3.Text = "";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Dock = DockStyle.Right;
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.search;
            button4.JoinLeft = true;
            button4.Location = new Point(170, 0);
            button4.Margins = 6;
            button4.Name = "button4";
            button4.Size = new Size(50, 46);
            button4.TabIndex = 1;
            // 
            // select2
            // 
            select2.Items.AddRange(new AntDesign.ISelectItem[] { new AntDesign.SelectItem(0, "Lucy"), new AntDesign.SelectItem(1, "Tom"), new AntDesign.SelectItem(1, "AduSkin"), new AntDesign.DividerSelectItem(), new AntDesign.SelectItem(0, "WangLi"), new AntDesign.SelectItem(0, "HUAWEI"), new AntDesign.SelectItem(0, "XIAOMI") });
            select2.List = true;
            select2.ListAutoWidth = true;
            select2.Location = new Point(160, 19);
            select2.Margin = new Padding(2, 3, 2, 3);
            select2.Name = "select2";
            select2.Size = new Size(126, 41);
            select2.TabIndex = 1;
            select2.Text = "（选择）";
            // 
            // select1
            // 
            select1.AllowClear = true;
            select1.Items.AddRange(new object[] { "Lucy", "Tom", "AduSkin", "WangLi", "HUAWEI", "XIAOMI" });
            select1.Location = new Point(18, 19);
            select1.Margin = new Padding(2, 3, 2, 3);
            select1.Name = "select1";
            select1.Size = new Size(120, 41);
            select1.TabIndex = 0;
            select1.Text = "";
            // 
            // divider3
            // 
            divider3.Dock = DockStyle.Top;
            divider3.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider3.Location = new Point(0, 345);
            divider3.Name = "divider3";
            divider3.Orientation = AntDesign.TOrientation.Left;
            divider3.Size = new Size(555, 22);
            divider3.TabIndex = 2;
            divider3.Text = "选择器";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 206);
            panel3.Name = "panel3";
            panel3.Size = new Size(555, 139);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(input8);
            panel5.Controls.Add(button1);
            panel5.Location = new Point(253, 16);
            panel5.Name = "panel5";
            panel5.Shadow = 0;
            panel5.Size = new Size(220, 50);
            panel5.TabIndex = 1;
            panel5.Text = "panel4";
            // 
            // input8
            // 
            input8.Dock = DockStyle.Fill;
            input8.JoinLeft = true;
            input8.Location = new Point(63, 0);
            input8.Margins = 6;
            input8.Name = "input8";
            input8.PlaceholderText = "输入点什么搜索";
            input8.Size = new Size(157, 50);
            input8.TabIndex = 0;
            input8.Text = "";
            // 
            // button1
            // 
            button1.AutoSize = AntDesign.TAutoSize.Width;
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Left;
            button1.ForeColor = Color.White;
            button1.JoinRight = true;
            button1.Location = new Point(0, 0);
            button1.Margins = 6;
            button1.Name = "button1";
            button1.Size = new Size(63, 50);
            button1.TabIndex = 1;
            button1.Text = "搜索";
            button1.Click += Btn;
            // 
            // panel6
            // 
            panel6.Controls.Add(input9);
            panel6.Controls.Add(button2);
            panel6.Location = new Point(18, 76);
            panel6.Name = "panel6";
            panel6.Size = new Size(220, 46);
            panel6.TabIndex = 2;
            panel6.Text = "panel4";
            // 
            // input9
            // 
            input9.Dock = DockStyle.Fill;
            input9.JoinRight = true;
            input9.Location = new Point(0, 0);
            input9.Margins = 6;
            input9.Name = "input9";
            input9.PlaceholderText = "输入点什么搜索";
            input9.Size = new Size(170, 46);
            input9.TabIndex = 0;
            input9.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Right;
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.search;
            button2.JoinLeft = true;
            button2.Location = new Point(170, 0);
            button2.Margins = 6;
            button2.Name = "button2";
            button2.Size = new Size(50, 46);
            button2.TabIndex = 1;
            button2.Click += Btn;
            // 
            // panel4
            // 
            panel4.Controls.Add(input7);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(18, 16);
            panel4.Name = "panel4";
            panel4.Shadow = 0;
            panel4.Size = new Size(220, 50);
            panel4.TabIndex = 0;
            panel4.Text = "panel4";
            // 
            // input7
            // 
            input7.Dock = DockStyle.Fill;
            input7.JoinRight = true;
            input7.Location = new Point(0, 0);
            input7.Margins = 6;
            input7.Name = "input7";
            input7.PlaceholderText = "输入点什么搜索";
            input7.Size = new Size(157, 50);
            input7.TabIndex = 0;
            input7.Text = "";
            // 
            // button3
            // 
            button3.AutoSize = AntDesign.TAutoSize.Width;
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Right;
            button3.ForeColor = Color.White;
            button3.JoinLeft = true;
            button3.Location = new Point(157, 0);
            button3.Margins = 6;
            button3.Name = "button3";
            button3.Size = new Size(63, 50);
            button3.TabIndex = 1;
            button3.Text = "搜索";
            button3.Click += Btn;
            // 
            // divider2
            // 
            divider2.Dock = DockStyle.Top;
            divider2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider2.Location = new Point(0, 184);
            divider2.Name = "divider2";
            divider2.Orientation = AntDesign.TOrientation.Left;
            divider2.Size = new Size(555, 22);
            divider2.TabIndex = 1;
            divider2.TabStop = false;
            divider2.Text = "组合";
            // 
            // panel2
            // 
            panel2.Controls.Add(input6);
            panel2.Controls.Add(input5);
            panel2.Controls.Add(input4);
            panel2.Controls.Add(input2);
            panel2.Controls.Add(input3);
            panel2.Controls.Add(input1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 162);
            panel2.TabIndex = 0;
            // 
            // divider1
            // 
            divider1.Dock = DockStyle.Top;
            divider1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider1.Location = new Point(0, 0);
            divider1.Name = "divider1";
            divider1.Orientation = AntDesign.TOrientation.Left;
            divider1.Size = new Size(555, 22);
            divider1.TabIndex = 1;
            divider1.TabStop = false;
            divider1.Text = "常规";
            // 
            // Input
            // 
            Controls.Add(panel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Input";
            Size = new Size(555, 554);
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntDesign.Input input1;
        private AntDesign.Input input2;
        private AntDesign.Input input3;
        private AntDesign.Input input4;
        private AntDesign.Input input5;
        private AntDesign.Input input6;
        private AntDesign.Header header1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AntDesign.Divider divider1;
        private AntDesign.Divider divider2;
        private System.Windows.Forms.Panel panel3;
        private AntDesign.Panel panel5;
        private AntDesign.Input input8;
        private AntDesign.Button button1;
        private System.Windows.Forms.Panel panel6;
        private AntDesign.Input input9;
        private AntDesign.Button button2;
        private AntDesign.Panel panel4;
        private AntDesign.Input input7;
        private AntDesign.Button button3;
        private System.Windows.Forms.Panel panel7;
        private AntDesign.Divider divider3;
        private AntDesign.Select select1;
        private AntDesign.Select select2;
        private System.Windows.Forms.Panel panel8;
        private AntDesign.Select select3;
        private AntDesign.Button button4;
    }
}