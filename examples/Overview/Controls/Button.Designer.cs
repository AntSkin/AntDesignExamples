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
            header1 = new AntDesign.Header();
            button3 = new AntDesign.Button();
            button5 = new AntDesign.Button();
            button16 = new AntDesign.Button();
            button9 = new AntDesign.Button();
            button7 = new AntDesign.Button();
            panel3 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            button8 = new AntDesign.Button();
            button20 = new AntDesign.Button();
            panel2 = new AntDesign.Panel();
            button10 = new AntDesign.Button();
            button15 = new AntDesign.Button();
            button2 = new AntDesign.Button();
            divider3 = new AntDesign.Divider();
            panel4 = new FlowLayoutPanel();
            button17 = new AntDesign.Button();
            button18 = new AntDesign.Button();
            button19 = new AntDesign.Button();
            button26 = new AntDesign.Button();
            divider1 = new AntDesign.Divider();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Padding = new Padding(6);
            header1.Size = new Size(1300, 79);
            header1.TabIndex = 4;
            header1.Text = "Button 按钮";
            header1.TextDesc = "按钮用于开始一个即时操作。";
            // 
            // button3
            // 
            button3.AutoSize = AntDesign.TAutoSize.Auto;
            button3.Enabled = false;
            button3.ForeColor = Color.White;
            button3.Location = new Point(501, 3);
            button3.Name = "button3";
            button3.Size = new Size(172, 50);
            button3.TabIndex = 0;
            button3.Text = "Primary(disabled)";
            button3.Type = AntDesign.TTypeMini.Primary;
            button3.Click += Btn2;
            // 
            // button5
            // 
            button5.AutoSize = AntDesign.TAutoSize.Auto;
            button5.BorderWidth = 2F;
            button5.Ghost = true;
            button5.Location = new Point(679, 3);
            button5.Name = "button5";
            button5.Shape = AntDesign.TShape.Round;
            button5.Size = new Size(154, 50);
            button5.TabIndex = 0;
            button5.Text = "Danger Default";
            button5.Type = AntDesign.TTypeMini.Error;
            button5.Click += Btn2;
            // 
            // button16
            // 
            button16.AutoSize = AntDesign.TAutoSize.Auto;
            button16.ForeColor = Color.White;
            button16.Location = new Point(939, 3);
            button16.Name = "button16";
            button16.Shape = AntDesign.TShape.Round;
            button16.Size = new Size(92, 50);
            button16.TabIndex = 0;
            button16.Text = "Danger";
            button16.Type = AntDesign.TTypeMini.Error;
            button16.Click += Btn2;
            // 
            // button9
            // 
            button9.AutoSize = AntDesign.TAutoSize.Auto;
            button9.ForeColor = Color.White;
            button9.Image = Properties.Resources.search;
            button9.Location = new Point(839, 3);
            button9.Name = "button9";
            button9.Size = new Size(94, 50);
            button9.TabIndex = 0;
            button9.Text = "搜索";
            button9.Type = AntDesign.TTypeMini.Primary;
            button9.Click += Btn2;
            // 
            // button7
            // 
            button7.AutoSize = AntDesign.TAutoSize.Auto;
            button7.ForeColor = Color.White;
            button7.Image = Properties.Resources.close;
            button7.Location = new Point(448, 3);
            button7.Name = "button7";
            button7.Shape = AntDesign.TShape.Circle;
            button7.Size = new Size(47, 47);
            button7.TabIndex = 0;
            button7.Type = AntDesign.TTypeMini.Primary;
            button7.Click += Btn2;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(divider3);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(divider1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(1300, 597);
            panel3.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 118);
            panel1.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(button8);
            panel5.Controls.Add(button20);
            panel5.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(485, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(147, 48);
            panel5.TabIndex = 16;
            // 
            // button8
            // 
            button8.Back = Color.FromArgb(17, 24, 39);
            button8.BackActive = Color.FromArgb(17, 24, 39);
            button8.BackHover = Color.FromArgb(17, 24, 39);
            button8.Dock = DockStyle.Fill;
            button8.JoinLeft = true;
            button8.Location = new Point(50, 0);
            button8.Margins = 0;
            button8.Name = "button8";
            button8.Radius = 4;
            button8.Size = new Size(97, 48);
            button8.TabIndex = 1;
            button8.Text = "Button";
            button8.Type = AntDesign.TTypeMini.Primary;
            // 
            // button20
            // 
            button20.Back = Color.FromArgb(168, 85, 247);
            button20.BackActive = Color.FromArgb(147, 51, 234);
            button20.BackHover = Color.FromArgb(147, 51, 234);
            button20.Dock = DockStyle.Left;
            button20.Image = Properties.Resources.search;
            button20.JoinRight = true;
            button20.Location = new Point(0, 0);
            button20.Margins = 0;
            button20.Name = "button20";
            button20.Radius = 4;
            button20.Size = new Size(50, 48);
            button20.TabIndex = 0;
            button20.Type = AntDesign.TTypeMini.Primary;
            // 
            // panel2
            // 
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button15);
            panel2.Controls.Add(button2);
            panel2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(14, 10);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.PaddingWidth = -10;
            panel2.ShadowOpacity = 0.2F;
            panel2.Size = new Size(417, 89);
            panel2.TabIndex = 0;
            panel2.Text = "panel2";
            // 
            // button10
            // 
            button10.AutoSize = AntDesign.TAutoSize.Auto;
            button10.Back = Color.FromArgb(217, 217, 217);
            button10.BackColor = Color.Transparent;
            button10.BorderWidth = 2F;
            button10.Dock = DockStyle.Fill;
            button10.JoinLeft = true;
            button10.Location = new Point(270, 20);
            button10.Name = "button10";
            button10.Size = new Size(125, 46);
            button10.TabIndex = 0;
            button10.Text = "Default Button";
            button10.Click += Btn;
            // 
            // button15
            // 
            button15.AutoSize = AntDesign.TAutoSize.Auto;
            button15.Back = Color.FromArgb(217, 217, 217);
            button15.BackColor = Color.Transparent;
            button15.BorderWidth = 2F;
            button15.Dock = DockStyle.Left;
            button15.JoinLeft = true;
            button15.JoinRight = true;
            button15.Location = new Point(145, 20);
            button15.Name = "button15";
            button15.Size = new Size(125, 46);
            button15.TabIndex = 0;
            button15.Text = "Default Button";
            button15.Click += Btn;
            // 
            // button2
            // 
            button2.AutoSize = AntDesign.TAutoSize.Auto;
            button2.Back = Color.FromArgb(217, 217, 217);
            button2.BackColor = Color.Transparent;
            button2.BorderWidth = 2F;
            button2.Dock = DockStyle.Left;
            button2.JoinRight = true;
            button2.Location = new Point(20, 20);
            button2.Name = "button2";
            button2.Size = new Size(125, 46);
            button2.TabIndex = 0;
            button2.Text = "Default Button";
            button2.Click += Btn;
            // 
            // divider3
            // 
            divider3.Dock = DockStyle.Top;
            divider3.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider3.Location = new Point(0, 158);
            divider3.Name = "divider3";
            divider3.Orientation = AntDesign.TOrientation.Left;
            divider3.Size = new Size(1300, 22);
            divider3.TabIndex = 7;
            divider3.Text = "组合按钮";
            // 
            // panel4
            // 
            panel4.Controls.Add(button17);
            panel4.Controls.Add(button18);
            panel4.Controls.Add(button19);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button16);
            panel4.Controls.Add(button26);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(1300, 136);
            panel4.TabIndex = 2;
            // 
            // button17
            // 
            button17.AutoSize = AntDesign.TAutoSize.Auto;
            button17.ForeColor = Color.White;
            button17.Location = new Point(3, 3);
            button17.Name = "button17";
            button17.Size = new Size(152, 50);
            button17.TabIndex = 0;
            button17.Text = "Primary Button";
            button17.Type = AntDesign.TTypeMini.Primary;
            button17.Click += Btn2;
            // 
            // button18
            // 
            button18.AutoSize = AntDesign.TAutoSize.Auto;
            button18.BorderWidth = 2F;
            button18.Location = new Point(161, 3);
            button18.Name = "button18";
            button18.Size = new Size(150, 50);
            button18.TabIndex = 0;
            button18.Text = "Default Button";
            button18.Click += Btn2;
            // 
            // button19
            // 
            button19.AutoSize = AntDesign.TAutoSize.Auto;
            button19.Location = new Point(317, 3);
            button19.Name = "button19";
            button19.Size = new Size(125, 50);
            button19.TabIndex = 0;
            button19.Text = "Text Button";
            button19.Click += Btn2;
            // 
            // button26
            // 
            button26.AutoSize = AntDesign.TAutoSize.Auto;
            button26.BorderWidth = 2F;
            button26.Image = Properties.Resources.search;
            button26.Location = new Point(1037, 3);
            button26.Name = "button26";
            button26.Shape = AntDesign.TShape.Circle;
            button26.Size = new Size(47, 47);
            button26.TabIndex = 6;
            button26.Type = AntDesign.TTypeMini.Error;
            button26.Click += Btn2;
            // 
            // divider1
            // 
            divider1.Dock = DockStyle.Top;
            divider1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider1.Location = new Point(0, 0);
            divider1.Name = "divider1";
            divider1.Orientation = AntDesign.TOrientation.Left;
            divider1.Size = new Size(1300, 22);
            divider1.TabIndex = 1;
            divider1.Text = "按钮类型";
            // 
            // Button
            // 
            Controls.Add(panel3);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Button";
            Size = new Size(1300, 676);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntDesign.Header header1;
        private AntDesign.Button button3;
        private AntDesign.Button button16;
        private AntDesign.Button button5;
        private AntDesign.Button button7;
        private AntDesign.Button button9;
        private System.Windows.Forms.Panel panel3;
        private AntDesign.Divider divider1;
        private FlowLayoutPanel panel4;
        private AntDesign.Button button19;
        private AntDesign.Button button18;
        private AntDesign.Button button17;
        private System.Windows.Forms.Panel panel1;
        private AntDesign.Panel panel2;
        private AntDesign.Divider divider3;
        private AntDesign.Button button10;
        private AntDesign.Button button15;
        private AntDesign.Button button2;
        private System.Windows.Forms.Panel panel5;
        private AntDesign.Button button8;
        private AntDesign.Button button20;
        private AntDesign.Button button26;
    }
}