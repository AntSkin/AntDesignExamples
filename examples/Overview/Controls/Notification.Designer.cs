namespace Overview.Controls
{
    partial class Notification
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
            button4 = new AntDesign.Button();
            button6 = new AntDesign.Button();
            button2 = new AntDesign.Button();
            button5 = new AntDesign.Button();
            button3 = new AntDesign.Button();
            button1 = new AntDesign.Button();
            divider1 = new AntDesign.Divider();
            panel3 = new System.Windows.Forms.Panel();
            button7 = new AntDesign.Button();
            button8 = new AntDesign.Button();
            button9 = new AntDesign.Button();
            button10 = new AntDesign.Button();
            divider2 = new AntDesign.Divider();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            header1.Text = "Notification 通知提醒框";
            header1.TextDesc = "全局展示通知提醒信息。";
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
            panel1.Size = new Size(543, 378);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 179);
            panel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Image = Properties.Resources.BR;
            button4.Location = new Point(169, 58);
            button4.Name = "button4";
            button4.Size = new Size(157, 43);
            button4.TabIndex = 1;
            button4.Text = "bottomRight";
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Image = Properties.Resources.Bottom;
            button6.Location = new Point(169, 107);
            button6.Name = "button6";
            button6.Size = new Size(115, 43);
            button6.TabIndex = 1;
            button6.Text = "bottom";
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Image = Properties.Resources.TR;
            button2.Location = new Point(169, 9);
            button2.Name = "button2";
            button2.Size = new Size(125, 43);
            button2.TabIndex = 1;
            button2.Text = "topRight";
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Image = Properties.Resources.Top;
            button5.Location = new Point(14, 107);
            button5.Name = "button5";
            button5.Size = new Size(83, 43);
            button5.TabIndex = 1;
            button5.Text = "top";
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Image = Properties.Resources.BL;
            button3.Location = new Point(14, 58);
            button3.Name = "button3";
            button3.Size = new Size(144, 43);
            button3.TabIndex = 1;
            button3.Text = "bottomLeft";
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Image = Properties.Resources.TL;
            button1.Location = new Point(14, 9);
            button1.Name = "button1";
            button1.Size = new Size(112, 43);
            button1.TabIndex = 1;
            button1.Text = "topLeft";
            button1.Click += button1_Click;
            // 
            // divider1
            // 
            divider1.Dock = DockStyle.Top;
            divider1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider1.Location = new Point(0, 0);
            divider1.Margin = new Padding(10);
            divider1.Name = "divider1";
            divider1.Orientation = AntDesign.TOrientation.Left;
            divider1.Size = new Size(543, 22);
            divider1.TabIndex = 0;
            divider1.Text = "六种方向";
            // 
            // panel3
            // 
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button10);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 223);
            panel3.Name = "panel3";
            panel3.Size = new Size(543, 63);
            panel3.TabIndex = 4;
            // 
            // button7
            // 
            button7.Back = Color.FromArgb(217, 217, 217);
            button7.BorderWidth = 2F;
            button7.Location = new Point(305, 9);
            button7.Name = "button7";
            button7.Size = new Size(91, 40);
            button7.TabIndex = 1;
            button7.Text = "Info";
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Back = Color.FromArgb(217, 217, 217);
            button8.BorderWidth = 2F;
            button8.Location = new Point(208, 9);
            button8.Name = "button8";
            button8.Size = new Size(91, 40);
            button8.TabIndex = 1;
            button8.Text = "Warning";
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Back = Color.FromArgb(217, 217, 217);
            button9.BorderWidth = 2F;
            button9.Location = new Point(111, 9);
            button9.Name = "button9";
            button9.Size = new Size(91, 40);
            button9.TabIndex = 1;
            button9.Text = "Error";
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Back = Color.FromArgb(217, 217, 217);
            button10.BorderWidth = 2F;
            button10.Location = new Point(14, 9);
            button10.Name = "button10";
            button10.Size = new Size(91, 40);
            button10.TabIndex = 1;
            button10.Text = "Success";
            button10.Click += button10_Click;
            // 
            // divider2
            // 
            divider2.Dock = DockStyle.Top;
            divider2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider2.Location = new Point(0, 201);
            divider2.Margin = new Padding(10);
            divider2.Name = "divider2";
            divider2.Orientation = AntDesign.TOrientation.Left;
            divider2.Size = new Size(543, 22);
            divider2.TabIndex = 3;
            divider2.Text = "四种样式";
            // 
            // Notification
            // 
            Controls.Add(panel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Notification";
            Size = new Size(543, 457);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntDesign.Header header1;
        private System.Windows.Forms.Panel panel1;
        private AntDesign.Divider divider1;
        private System.Windows.Forms.Panel panel2;
        private AntDesign.Button button1;
        private AntDesign.Button button4;
        private AntDesign.Button button2;
        private AntDesign.Button button3;
        private AntDesign.Button button6;
        private AntDesign.Button button5;
        private System.Windows.Forms.Panel panel3;
        private AntDesign.Button button7;
        private AntDesign.Button button8;
        private AntDesign.Button button9;
        private AntDesign.Button button10;
        private AntDesign.Divider divider2;
    }
}