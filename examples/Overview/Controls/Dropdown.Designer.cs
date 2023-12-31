﻿// COPYRIGHT (C) Tom. ALL RIGHTS RESERVED.
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
    partial class Dropdown
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
            button7 = new AntDesign.Dropdown();
            panel3 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            button4 = new AntDesign.Dropdown();
            button6 = new AntDesign.Dropdown();
            button2 = new AntDesign.Dropdown();
            button5 = new AntDesign.Dropdown();
            button3 = new AntDesign.Dropdown();
            button8 = new AntDesign.Dropdown();
            divider3 = new AntDesign.Divider();
            panel4 = new FlowLayoutPanel();
            button17 = new AntDesign.Dropdown();
            button19 = new AntDesign.Dropdown();
            dropdown1 = new AntDesign.Dropdown();
            divider1 = new AntDesign.Divider();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
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
            header1.Text = "Dropdown 下拉菜单";
            header1.TextDesc = "向下弹出的列表。";
            // 
            // button7
            // 
            button7.AutoSize = AntDesign.TAutoSize.Auto;
            button7.ForeColor = Color.White;
            button7.ImageSvg = Properties.Resources.icon_poweroff;
            button7.Items.AddRange(new object[] { "菜单1", "菜单2", "菜单3" });
            button7.Location = new Point(386, 3);
            button7.Name = "button7";
            button7.Placement = AntDesign.TAlignFrom.BR;
            button7.Shape = AntDesign.TShape.Circle;
            button7.Size = new Size(47, 47);
            button7.TabIndex = 0;
            button7.Type = AntDesign.TTypeMini.Primary;
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
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 196);
            panel1.TabIndex = 8;
            // 
            // button4
            // 
            button4.AutoSize = AntDesign.TAutoSize.Auto;
            button4.DropDownArrow = true;
            button4.ImageSvg = Properties.Resources.BR;
            button4.Items.AddRange(new object[] { "one st menu item", "two nd menu item", "three rd menu item", "four menu item", "five menu item", "six six six menu item" });
            button4.Location = new Point(296, 93);
            button4.Name = "button4";
            button4.Placement = AntDesign.TAlignFrom.BR;
            button4.Size = new Size(162, 50);
            button4.TabIndex = 2;
            button4.Text = "bottomRight";
            button4.Type = AntDesign.TTypeMini.Primary;
            // 
            // button6
            // 
            button6.AutoSize = AntDesign.TAutoSize.Auto;
            button6.DropDownArrow = true;
            button6.ImageSvg = Properties.Resources.Bottom;
            button6.Items.AddRange(new object[] { "one st menu item", "two nd menu item", "three rd menu item", "four menu item", "five menu item", "six six six menu item" });
            button6.Location = new Point(171, 93);
            button6.Name = "button6";
            button6.Placement = AntDesign.TAlignFrom.Bottom;
            button6.Size = new Size(120, 50);
            button6.TabIndex = 3;
            button6.Text = "bottom";
            button6.Type = AntDesign.TTypeMini.Primary;
            // 
            // button2
            // 
            button2.AutoSize = AntDesign.TAutoSize.Auto;
            button2.DropDownArrow = true;
            button2.ImageSvg = Properties.Resources.TR;
            button2.Items.AddRange(new object[] { "one st menu item", "two nd menu item", "three rd menu item", "four menu item", "five menu item", "six six six menu item" });
            button2.Location = new Point(328, 15);
            button2.Name = "button2";
            button2.Placement = AntDesign.TAlignFrom.TR;
            button2.Size = new Size(130, 50);
            button2.TabIndex = 4;
            button2.Text = "topRight";
            button2.Type = AntDesign.TTypeMini.Primary;
            // 
            // button5
            // 
            button5.AutoSize = AntDesign.TAutoSize.Auto;
            button5.DropDownArrow = true;
            button5.ImageSvg = Properties.Resources.Top;
            button5.Items.AddRange(new object[] { "one st menu item", "two nd menu item", "three rd menu item", "four menu item", "five menu item", "six six six menu item" });
            button5.Location = new Point(187, 15);
            button5.Name = "button5";
            button5.Placement = AntDesign.TAlignFrom.Top;
            button5.Size = new Size(88, 50);
            button5.TabIndex = 5;
            button5.Text = "top";
            button5.Type = AntDesign.TTypeMini.Primary;
            // 
            // button3
            // 
            button3.AutoSize = AntDesign.TAutoSize.Auto;
            button3.DropDownArrow = true;
            button3.ImageSvg = Properties.Resources.BL;
            button3.Items.AddRange(new object[] { "one st menu item", "two nd menu item", "three rd menu item", "four menu item", "five menu item", "six six six menu item" });
            button3.Location = new Point(14, 93);
            button3.Name = "button3";
            button3.Size = new Size(149, 50);
            button3.TabIndex = 6;
            button3.Text = "bottomLeft";
            button3.Type = AntDesign.TTypeMini.Primary;
            // 
            // button8
            // 
            button8.AutoSize = AntDesign.TAutoSize.Auto;
            button8.DropDownArrow = true;
            button8.ImageSvg = Properties.Resources.TL;
            button8.Items.AddRange(new object[] { "one st menu item", "two nd menu item", "three rd menu item", "four menu item", "five menu item", "six six six menu item" });
            button8.Location = new Point(14, 15);
            button8.Name = "button8";
            button8.Placement = AntDesign.TAlignFrom.TL;
            button8.Size = new Size(117, 50);
            button8.TabIndex = 7;
            button8.Text = "topLeft";
            button8.Type = AntDesign.TTypeMini.Primary;
            // 
            // divider3
            // 
            divider3.Dock = DockStyle.Top;
            divider3.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            divider3.Location = new Point(0, 95);
            divider3.Name = "divider3";
            divider3.Orientation = AntDesign.TOrientation.Left;
            divider3.Size = new Size(1300, 22);
            divider3.TabIndex = 7;
            divider3.Text = "六种方向";
            // 
            // panel4
            // 
            panel4.Controls.Add(button17);
            panel4.Controls.Add(button19);
            panel4.Controls.Add(dropdown1);
            panel4.Controls.Add(button7);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(1300, 73);
            panel4.TabIndex = 2;
            // 
            // button17
            // 
            button17.AutoSize = AntDesign.TAutoSize.Auto;
            button17.ForeColor = Color.White;
            button17.IsLink = true;
            button17.Items.AddRange(new object[] { "菜单1", "菜单2", "菜单3" });
            button17.Location = new Point(3, 3);
            button17.Name = "button17";
            button17.ShowArrow = true;
            button17.Size = new Size(127, 50);
            button17.TabIndex = 0;
            button17.Text = "Click me";
            button17.Type = AntDesign.TTypeMini.Primary;
            // 
            // button19
            // 
            button19.AutoSize = AntDesign.TAutoSize.Auto;
            button19.Items.AddRange(new object[] { "菜单1", "菜单2", "菜单3" });
            button19.ListAutoWidth = false;
            button19.Location = new Point(136, 3);
            button19.Name = "button19";
            button19.ShowArrow = true;
            button19.Size = new Size(138, 50);
            button19.TabIndex = 0;
            button19.Text = "Hover me";
            button19.TextAlign = ContentAlignment.MiddleLeft;
            button19.Trigger = AntDesign.Trigger.Hover;
            // 
            // dropdown1
            // 
            dropdown1.AutoSize = AntDesign.TAutoSize.Auto;
            dropdown1.ForeColor = Color.White;
            dropdown1.Location = new Point(280, 3);
            dropdown1.Name = "dropdown1";
            dropdown1.Size = new Size(100, 50);
            dropdown1.TabIndex = 0;
            dropdown1.Text = "多级菜单";
            dropdown1.Type = AntDesign.TTypeMini.Primary;
            dropdown1.SelectedValueChanged += dropdown1_SelectedValueChanged;
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
            // Dropdown
            // 
            Controls.Add(panel3);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Dropdown";
            Size = new Size(1300, 676);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntDesign.Header header1;
        private AntDesign.Dropdown button7;
        private System.Windows.Forms.Panel panel3;
        private AntDesign.Divider divider1;
        private FlowLayoutPanel panel4;
        private AntDesign.Dropdown button19;
        private AntDesign.Dropdown button17;
        private System.Windows.Forms.Panel panel1;
        private AntDesign.Divider divider3;
        private AntDesign.Dropdown button4;
        private AntDesign.Dropdown button6;
        private AntDesign.Dropdown button2;
        private AntDesign.Dropdown button5;
        private AntDesign.Dropdown button3;
        private AntDesign.Dropdown button8;
        private AntDesign.Dropdown dropdown1;
    }
}