namespace Overview
{
    partial class Form1
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
            button1 = new AntDesign.Button();
            iconWarn1 = new AntDesign.Icon.IconWarn();
            iconError1 = new AntDesign.Icon.IconError();
            iconComplete1 = new AntDesign.Icon.IconComplete();
            iconInfo1 = new AntDesign.Icon.IconInfo();
            spin1 = new AntDesign.Spin();
            panel9 = new AntDesign.Panel();
            label9 = new Label();
            label8 = new Label();
            avatar2 = new AntDesign.Avatar();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.White;
            button1.Location = new Point(56, 41);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(140, 47);
            button1.TabIndex = 1;
            button1.Text = "加载";
            button1.Type = AntDesign.TTypeMini.Primary;
            button1.Click += button1_Click;
            // 
            // iconWarn1
            // 
            iconWarn1.Location = new Point(411, 18);
            iconWarn1.Margin = new Padding(3, 4, 3, 4);
            iconWarn1.Name = "iconWarn1";
            iconWarn1.Size = new Size(60, 59);
            iconWarn1.TabIndex = 3;
            iconWarn1.Text = "iconWarn1";
            // 
            // iconError1
            // 
            iconError1.Location = new Point(477, 18);
            iconError1.Margin = new Padding(3, 4, 3, 4);
            iconError1.Name = "iconError1";
            iconError1.Size = new Size(60, 59);
            iconError1.TabIndex = 4;
            iconError1.Text = "iconError1";
            // 
            // iconComplete1
            // 
            iconComplete1.Location = new Point(543, 18);
            iconComplete1.Margin = new Padding(3, 4, 3, 4);
            iconComplete1.Name = "iconComplete1";
            iconComplete1.Size = new Size(60, 59);
            iconComplete1.TabIndex = 5;
            iconComplete1.Text = "iconComplete1";
            // 
            // iconInfo1
            // 
            iconInfo1.Location = new Point(345, 18);
            iconInfo1.Margin = new Padding(3, 4, 3, 4);
            iconInfo1.Name = "iconInfo1";
            iconInfo1.Size = new Size(60, 59);
            iconInfo1.TabIndex = 6;
            iconInfo1.Text = "iconInfo1";
            // 
            // spin1
            // 
            spin1.Location = new Point(225, 3);
            spin1.Name = "spin1";
            spin1.Size = new Size(77, 74);
            spin1.TabIndex = 7;
            spin1.Text = "Loading...";
            // 
            // panel9
            // 
            panel9.ArrowAlign = AntDesign.TAlign.TL;
            panel9.ArrowSize = 10;
            panel9.Back = Color.FromArgb(0, 144, 255);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(label8);
            panel9.Controls.Add(avatar2);
            panel9.ForeColor = Color.White;
            panel9.Location = new Point(12, 108);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(38);
            panel9.PaddingWidth = -12;
            panel9.Radius = 10;
            panel9.Shadow = 24;
            panel9.ShadowOpacity = 0.18F;
            panel9.Size = new Size(320, 258);
            panel9.TabIndex = 15;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(38, 178);
            label9.Name = "label9";
            label9.Padding = new Padding(2, 0, 2, 0);
            label9.Size = new Size(244, 42);
            label9.TabIndex = 12;
            label9.Text = "Here is the content, here is the conten";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(38, 148);
            label8.Name = "label8";
            label8.Size = new Size(244, 30);
            label8.TabIndex = 11;
            label8.Text = "Tour Title";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // avatar2
            // 
            avatar2.BackColor = Color.Transparent;
            avatar2.Dock = DockStyle.Top;
            avatar2.Image = Properties.Resources.img1;
            avatar2.Location = new Point(38, 38);
            avatar2.Name = "avatar2";
            avatar2.Radius = 6;
            avatar2.Size = new Size(244, 110);
            avatar2.TabIndex = 9;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 689);
            Controls.Add(panel9);
            Controls.Add(spin1);
            Controls.Add(iconInfo1);
            Controls.Add(iconComplete1);
            Controls.Add(iconError1);
            Controls.Add(iconWarn1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntDesign.Button button1;
        private AntDesign.Icon.IconWarn iconWarn1;
        private AntDesign.Icon.IconError iconError1;
        private AntDesign.Icon.IconComplete iconComplete1;
        private AntDesign.Icon.IconInfo iconInfo1;
        private AntDesign.Spin spin1;
        private AntDesign.Panel panel9;
        private Label label9;
        private Label label8;
        private AntDesign.Avatar avatar2;
    }
}