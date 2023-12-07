// COPYRIGHT (C) Tom. ALL RIGHTS RESERVED.
// THE AntDesignExamples PROJECT IS AN WINFORM LIBRARY LICENSED UNDER THE Apache-2.0 License.
// LICENSED UNDER THE Apache License, VERSION 2.0 (THE "License");
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
    partial class Modal
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
            button3 = new AntDesign.Button();
            button2 = new AntDesign.Button();
            button1 = new AntDesign.Button();
            divider1 = new AntDesign.Divider();
            panel1.SuspendLayout();
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
            header1.Size = new Size(543, 79);
            header1.TabIndex = 5;
            header1.Text = "Modal 对话框";
            header1.TextDesc = "模态对话框。";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
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
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 63);
            panel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.BorderWidth = 2F;
            button4.Location = new Point(362, 9);
            button4.Name = "button4";
            button4.Size = new Size(110, 40);
            button4.TabIndex = 1;
            button4.Text = "None";
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BorderWidth = 2F;
            button3.Location = new Point(246, 9);
            button3.Name = "button3";
            button3.Size = new Size(110, 40);
            button3.TabIndex = 1;
            button3.Text = "Warning";
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BorderWidth = 2F;
            button2.Location = new Point(130, 9);
            button2.Name = "button2";
            button2.Size = new Size(110, 40);
            button2.TabIndex = 1;
            button2.Text = "Error";
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BorderWidth = 2F;
            button1.Location = new Point(14, 9);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 1;
            button1.Text = "Success";
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
            divider1.Text = "基本";
            // 
            // Modal
            // 
            Controls.Add(panel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Modal";
            Size = new Size(543, 457);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntDesign.Header header1;
        private System.Windows.Forms.Panel panel1;
        private AntDesign.Divider divider1;
        private AntDesign.Button button1;
        private AntDesign.Button button3;
        private AntDesign.Button button2;
        private AntDesign.Button button4;
        private System.Windows.Forms.Panel panel2;
    }
}