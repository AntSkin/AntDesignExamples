namespace Overview.Controls
{
    partial class Button
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
            button1 = new System.Windows.Forms.Button();
            button2 = new AntDesign.Button();
            button3 = new AntDesign.Button();
            button8 = new AntDesign.Button();
            button10 = new AntDesign.Button();
            panel1 = new AntDesign.Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button7 = new AntDesign.Button();
            button15 = new AntDesign.Button();
            button5 = new AntDesign.Button();
            button16 = new AntDesign.Button();
            button9 = new AntDesign.Button();
            label2 = new Label();
            panel2 = new AntDesign.Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button13 = new AntDesign.Button();
            button11 = new AntDesign.Button();
            button12 = new AntDesign.Button();
            button14 = new AntDesign.Button();
            button4 = new AntDesign.Button();
            button6 = new AntDesign.Button();
            label1 = new Label();
            header1 = new AntDesign.Header();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(5, 14);
            button1.Name = "button1";
            button1.Size = new Size(186, 46);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 50);
            button2.TabIndex = 0;
            button2.Text = "Primary";
            button2.Click += Btn;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Enabled = false;
            button3.ForeColor = Color.White;
            button3.Location = new Point(121, 3);
            button3.Name = "button3";
            button3.Size = new Size(215, 50);
            button3.TabIndex = 0;
            button3.Text = "Primary(disabled)";
            button3.Click += Btn;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(3, 465);
            button8.Name = "button8";
            button8.Radius = 30;
            button8.Size = new Size(297, 87);
            button8.TabIndex = 0;
            button8.Text = "Big Button";
            button8.Click += Btn;
            // 
            // button10
            // 
            button10.AutoSize = true;
            button10.BorderWidth = 2F;
            button10.Location = new Point(3, 59);
            button10.Name = "button10";
            button10.Size = new Size(186, 50);
            button10.TabIndex = 0;
            button10.Text = "Default Button";
            button10.Click += Btn;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 225);
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.Controls.Add(button15);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button16);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(495, 185);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.ForeColor = Color.White;
            button7.Image = Properties.Resources.close;
            button7.Location = new Point(342, 3);
            button7.Name = "button7";
            button7.Shape = AntDesign.TShape.Circle;
            button7.Size = new Size(50, 50);
            button7.TabIndex = 0;
            button7.Text = "Primary";
            button7.Click += Btn;
            // 
            // button15
            // 
            button15.AutoSize = true;
            button15.BorderWidth = 2F;
            button15.Enabled = false;
            button15.Location = new Point(195, 59);
            button15.Name = "button15";
            button15.Size = new Size(186, 50);
            button15.TabIndex = 0;
            button15.Text = "Default Button";
            button15.Click += Btn;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Back = Color.FromArgb(220, 68, 70);
            button5.BackActive = Color.FromArgb(217, 54, 62);
            button5.BackHover = Color.FromArgb(255, 120, 117);
            button5.BorderWidth = 2F;
            button5.ForeColor = Color.FromArgb(220, 68, 70);
            button5.Location = new Point(3, 115);
            button5.Name = "button5";
            button5.Shape = AntDesign.TShape.Round;
            button5.Size = new Size(192, 50);
            button5.TabIndex = 0;
            button5.Text = "Danger Default";
            button5.Click += Btn;
            // 
            // button16
            // 
            button16.AutoSize = true;
            button16.Back = Color.FromArgb(220, 68, 70);
            button16.BackActive = Color.FromArgb(217, 54, 62);
            button16.BackHover = Color.FromArgb(255, 120, 117);
            button16.ForeColor = Color.White;
            button16.Location = new Point(201, 115);
            button16.Name = "button16";
            button16.Shape = AntDesign.TShape.Round;
            button16.Size = new Size(109, 50);
            button16.TabIndex = 0;
            button16.Text = "Danger";
            button16.Click += Btn;
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.ForeColor = Color.White;
            button9.Image = Properties.Resources.search;
            button9.Location = new Point(316, 115);
            button9.Name = "button9";
            button9.Size = new Size(113, 50);
            button9.TabIndex = 0;
            button9.Text = "搜索";
            button9.Click += Btn;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(8, 0, 0, 0);
            label2.Size = new Size(495, 40);
            label2.TabIndex = 2;
            label2.Text = "Light";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Back = Color.FromArgb(20, 20, 20);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(3, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 225);
            panel2.TabIndex = 1;
            panel2.Text = "panel1";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Black;
            flowLayoutPanel2.Controls.Add(button13);
            flowLayoutPanel2.Controls.Add(button11);
            flowLayoutPanel2.Controls.Add(button12);
            flowLayoutPanel2.Controls.Add(button14);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 40);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(495, 185);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // button13
            // 
            button13.AutoSize = true;
            button13.Mode = AntDesign.TMode.Dark;
            button13.ForeColor = Color.White;
            button13.Location = new Point(3, 3);
            button13.Name = "button13";
            button13.Size = new Size(112, 50);
            button13.TabIndex = 0;
            button13.Text = "Primary";
            button13.Click += Btn;
            // 
            // button11
            // 
            button11.AutoSize = true;
            button11.Mode = AntDesign.TMode.Dark;
            button11.Enabled = false;
            button11.ForeColor = Color.White;
            button11.Location = new Point(121, 3);
            button11.Name = "button11";
            button11.Size = new Size(215, 50);
            button11.TabIndex = 0;
            button11.Text = "Primary(disabled)";
            button11.Click += Btn;
            // 
            // button12
            // 
            button12.AutoSize = true;
            button12.Back = Color.FromArgb(66, 66, 66);
            button12.BackHover = Color.FromArgb(60, 137, 232);
            button12.BorderWidth = 2F;
            button12.Mode = AntDesign.TMode.Dark;
            button12.Location = new Point(3, 59);
            button12.Name = "button12";
            button12.Size = new Size(186, 50);
            button12.TabIndex = 0;
            button12.Text = "Default Button";
            button12.Click += Btn;
            // 
            // button14
            // 
            button14.AutoSize = true;
            button14.Back = Color.FromArgb(66, 66, 66);
            button14.BackHover = Color.FromArgb(60, 137, 232);
            button14.BorderWidth = 2F;
            button14.Mode = AntDesign.TMode.Dark;
            button14.Enabled = false;
            button14.Location = new Point(195, 59);
            button14.Name = "button14";
            button14.Size = new Size(186, 50);
            button14.TabIndex = 0;
            button14.Text = "Default Button";
            button14.Click += Btn;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Back = Color.FromArgb(220, 68, 70);
            button4.BackActive = Color.FromArgb(173, 57, 58);
            button4.BackHover = Color.FromArgb(232, 110, 107);
            button4.Mode = AntDesign.TMode.Dark;
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 115);
            button4.Name = "button4";
            button4.Shape = AntDesign.TShape.Round;
            button4.Size = new Size(109, 50);
            button4.TabIndex = 0;
            button4.Text = "Danger";
            button4.Click += Btn;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Back = Color.FromArgb(220, 68, 70);
            button6.BackActive = Color.FromArgb(173, 57, 58);
            button6.BackHover = Color.FromArgb(232, 110, 107);
            button6.BorderWidth = 2F;
            button6.Mode = AntDesign.TMode.Dark;
            button6.ForeColor = Color.FromArgb(220, 68, 70);
            button6.Location = new Point(118, 115);
            button6.Name = "button6";
            button6.Shape = AntDesign.TShape.Round;
            button6.Size = new Size(192, 50);
            button6.TabIndex = 0;
            button6.Text = "Danger Default";
            button6.Click += Btn;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(8, 0, 0, 0);
            label1.Size = new Size(495, 40);
            label1.TabIndex = 2;
            label1.Text = "Dark";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            header1.Text = "Button 按钮";
            header1.TextDesc = "按钮用于开始一个即时操作。";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.Controls.Add(panel1);
            flowLayoutPanel3.Controls.Add(panel2);
            flowLayoutPanel3.Controls.Add(button8);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 79);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(543, 559);
            flowLayoutPanel3.TabIndex = 5;
            // 
            // Button
            // 
            Controls.Add(flowLayoutPanel3);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Button";
            Size = new Size(543, 638);
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AntDesign.Button button2;
        private AntDesign.Button button3;
        private AntDesign.Button button8;
        private AntDesign.Button button10;
        private AntDesign.Panel panel1;
        private Label label2;
        private AntDesign.Panel panel2;
        private Label label1;
        private AntDesign.Button button11;
        private AntDesign.Button button12;
        private AntDesign.Button button13;
        private AntDesign.Button button15;
        private AntDesign.Button button14;
        private AntDesign.Button button16;
        private AntDesign.Button button4;
        private AntDesign.Button button5;
        private AntDesign.Button button6;
        private AntDesign.Button button7;
        private AntDesign.Button button9;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private AntDesign.Header header1;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}