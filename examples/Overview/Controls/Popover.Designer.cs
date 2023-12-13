// COPYRIGHT (C) Tom. ALL RIGHTS RESERVED.
// THE AntDesignExamples PROJECT IS AN WINFORM LIBRARY LICENSED UNDER THE Apache-2.0 License.
// LICENSED UNDER THE Apache License, VERSION 2.0 (THE "License")
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
    partial class Popover
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
            buttonRB = new AntDesign.Button();
            buttonLB = new AntDesign.Button();
            buttonRight = new AntDesign.Button();
            buttonLeft = new AntDesign.Button();
            buttonRT = new AntDesign.Button();
            buttonLT = new AntDesign.Button();
            buttonBR = new AntDesign.Button();
            buttonTR = new AntDesign.Button();
            buttonBottom = new AntDesign.Button();
            buttonTop = new AntDesign.Button();
            buttonBL = new AntDesign.Button();
            buttonTL = new AntDesign.Button();
            divider1 = new AntDesign.Divider();
            panel2 = new System.Windows.Forms.Panel();
            button2 = new AntDesign.Button();
            button1 = new AntDesign.Button();
            divider3 = new AntDesign.Divider();
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
            header1.Size = new Size(840, 79);
            header1.TabIndex = 5;
            header1.Text = "Popover 气泡卡片";
            header1.TextDesc = "弹出气泡式的卡片浮层。";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(divider1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(divider3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 597);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonRB);
            panel3.Controls.Add(buttonLB);
            panel3.Controls.Add(buttonRight);
            panel3.Controls.Add(buttonLeft);
            panel3.Controls.Add(buttonRT);
            panel3.Controls.Add(buttonLT);
            panel3.Controls.Add(buttonBR);
            panel3.Controls.Add(buttonTR);
            panel3.Controls.Add(buttonBottom);
            panel3.Controls.Add(buttonTop);
            panel3.Controls.Add(buttonBL);
            panel3.Controls.Add(buttonTL);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 240);
            panel3.Name = "panel3";
            panel3.Size = new Size(840, 250);
            panel3.TabIndex = 12;
            // 
            // buttonRB
            // 
            buttonRB.Back = Color.FromArgb(217, 217, 217);
            buttonRB.BorderWidth = 2F;
            buttonRB.Location = new Point(347, 149);
            buttonRB.Name = "buttonRB";
            buttonRB.Size = new Size(60, 40);
            buttonRB.TabIndex = 3;
            buttonRB.Text = "RB";
            buttonRB.Click += buttonRB_Click;
            // 
            // buttonLB
            // 
            buttonLB.Back = Color.FromArgb(217, 217, 217);
            buttonLB.BorderWidth = 2F;
            buttonLB.Location = new Point(55, 149);
            buttonLB.Name = "buttonLB";
            buttonLB.Size = new Size(60, 40);
            buttonLB.TabIndex = 4;
            buttonLB.Text = "LB";
            buttonLB.Click += buttonLB_Click;
            // 
            // buttonRight
            // 
            buttonRight.Back = Color.FromArgb(217, 217, 217);
            buttonRight.BorderWidth = 2F;
            buttonRight.Location = new Point(347, 103);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(86, 40);
            buttonRight.TabIndex = 5;
            buttonRight.Text = "Right";
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Back = Color.FromArgb(217, 217, 217);
            buttonLeft.BorderWidth = 2F;
            buttonLeft.Location = new Point(29, 103);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(86, 40);
            buttonLeft.TabIndex = 6;
            buttonLeft.Text = "Left";
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRT
            // 
            buttonRT.Back = Color.FromArgb(217, 217, 217);
            buttonRT.BorderWidth = 2F;
            buttonRT.Location = new Point(347, 57);
            buttonRT.Name = "buttonRT";
            buttonRT.Size = new Size(60, 40);
            buttonRT.TabIndex = 7;
            buttonRT.Text = "RT";
            buttonRT.Click += buttonRT_Click;
            // 
            // buttonLT
            // 
            buttonLT.Back = Color.FromArgb(217, 217, 217);
            buttonLT.BorderWidth = 2F;
            buttonLT.Location = new Point(55, 57);
            buttonLT.Name = "buttonLT";
            buttonLT.Size = new Size(60, 40);
            buttonLT.TabIndex = 8;
            buttonLT.Text = "LT";
            buttonLT.Click += buttonLT_Click;
            // 
            // buttonBR
            // 
            buttonBR.Back = Color.FromArgb(217, 217, 217);
            buttonBR.BorderWidth = 2F;
            buttonBR.Location = new Point(287, 195);
            buttonBR.Name = "buttonBR";
            buttonBR.Size = new Size(60, 40);
            buttonBR.TabIndex = 9;
            buttonBR.Text = "BR";
            buttonBR.Click += buttonBR_Click;
            // 
            // buttonTR
            // 
            buttonTR.Back = Color.FromArgb(217, 217, 217);
            buttonTR.BorderWidth = 2F;
            buttonTR.Location = new Point(287, 15);
            buttonTR.Name = "buttonTR";
            buttonTR.Size = new Size(60, 40);
            buttonTR.TabIndex = 10;
            buttonTR.Text = "TR";
            buttonTR.Click += buttonTR_Click;
            // 
            // buttonBottom
            // 
            buttonBottom.Back = Color.FromArgb(217, 217, 217);
            buttonBottom.BorderWidth = 2F;
            buttonBottom.Location = new Point(181, 195);
            buttonBottom.Name = "buttonBottom";
            buttonBottom.Size = new Size(100, 40);
            buttonBottom.TabIndex = 11;
            buttonBottom.Text = "Bottom";
            buttonBottom.Click += buttonBottom_Click;
            // 
            // buttonTop
            // 
            buttonTop.Back = Color.FromArgb(217, 217, 217);
            buttonTop.BorderWidth = 2F;
            buttonTop.Location = new Point(181, 15);
            buttonTop.Name = "buttonTop";
            buttonTop.Size = new Size(100, 40);
            buttonTop.TabIndex = 12;
            buttonTop.Text = "Top";
            buttonTop.Click += buttonTop_Click;
            // 
            // buttonBL
            // 
            buttonBL.Back = Color.FromArgb(217, 217, 217);
            buttonBL.BorderWidth = 2F;
            buttonBL.Location = new Point(115, 195);
            buttonBL.Name = "buttonBL";
            buttonBL.Size = new Size(60, 40);
            buttonBL.TabIndex = 13;
            buttonBL.Text = "BL";
            buttonBL.Click += buttonBL_Click;
            // 
            // buttonTL
            // 
            buttonTL.Back = Color.FromArgb(217, 217, 217);
            buttonTL.BorderWidth = 2F;
            buttonTL.Location = new Point(115, 15);
            buttonTL.Name = "buttonTL";
            buttonTL.Size = new Size(60, 40);
            buttonTL.TabIndex = 14;
            buttonTL.Text = "TL";
            buttonTL.Click += buttonTL_Click;
            // 
            // divider1
            // 
            divider1.Dock = DockStyle.Top;
            divider1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider1.Location = new Point(0, 218);
            divider1.Name = "divider1";
            divider1.Orientation = AntDesign.TOrientation.Left;
            divider1.Size = new Size(840, 22);
            divider1.TabIndex = 11;
            divider1.Text = "位置";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(840, 196);
            panel2.TabIndex = 10;
            // 
            // button2
            // 
            button2.AutoSize = AntDesign.TAutoSize.Auto;
            button2.Location = new Point(145, 17);
            button2.Name = "button2";
            button2.Size = new Size(186, 50);
            button2.TabIndex = 7;
            button2.Text = "自定义控件内容弹出";
            button2.Type = AntDesign.TTypeMini.Primary;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = AntDesign.TAutoSize.Auto;
            button1.Location = new Point(14, 17);
            button1.Name = "button1";
            button1.Size = new Size(104, 50);
            button1.TabIndex = 7;
            button1.Text = "普通弹出";
            button1.Type = AntDesign.TTypeMini.Primary;
            button1.Click += button1_Click;
            // 
            // divider3
            // 
            divider3.Dock = DockStyle.Top;
            divider3.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider3.Location = new Point(0, 0);
            divider3.Name = "divider3";
            divider3.Orientation = AntDesign.TOrientation.Left;
            divider3.Size = new Size(840, 22);
            divider3.TabIndex = 9;
            divider3.Text = "常规";
            // 
            // Popover
            // 
            Controls.Add(panel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Popover";
            Size = new Size(840, 676);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntDesign.Header header1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private AntDesign.Divider divider1;
        private System.Windows.Forms.Panel panel2;
        private AntDesign.Divider divider3;
        private AntDesign.Button button1;
        private AntDesign.Button button2;
        private AntDesign.Button buttonRB;
        private AntDesign.Button buttonLB;
        private AntDesign.Button buttonRight;
        private AntDesign.Button buttonLeft;
        private AntDesign.Button buttonRT;
        private AntDesign.Button buttonLT;
        private AntDesign.Button buttonBR;
        private AntDesign.Button buttonTR;
        private AntDesign.Button buttonBottom;
        private AntDesign.Button buttonTop;
        private AntDesign.Button buttonBL;
        private AntDesign.Button buttonTL;
    }
}