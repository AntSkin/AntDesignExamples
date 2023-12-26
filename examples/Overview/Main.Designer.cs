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

namespace Overview
{
    partial class Main
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
            btn_back = new AntDesign.Button();
            btn_mode = new AntDesign.Button();
            divider2 = new AntDesign.Divider();
            flowPanel = new FlowLayoutPanel();
            windowBar = new AntDesign.WindowBar();
            windowBar.SuspendLayout();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Dock = DockStyle.Left;
            btn_back.Ghost = true;
            btn_back.ImageSvg = Properties.Resources.app_back;
            btn_back.Location = new Point(0, 0);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(90, 40);
            btn_back.TabIndex = 7;
            btn_back.Text = "返回";
            btn_back.Visible = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_mode
            // 
            btn_mode.Dock = DockStyle.Right;
            btn_mode.Font = new Font("Microsoft YaHei UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_mode.Ghost = true;
            btn_mode.ImageSvg = Properties.Resources.app_light;
            btn_mode.Location = new Point(1094, 0);
            btn_mode.Margins = 0;
            btn_mode.Name = "btn_mode";
            btn_mode.Radius = 0;
            btn_mode.Size = new Size(50, 40);
            btn_mode.TabIndex = 6;
            btn_mode.Click += btn_mode_Click;
            // 
            // divider2
            // 
            divider2.Dock = DockStyle.Top;
            divider2.Location = new Point(0, 40);
            divider2.Name = "divider2";
            divider2.Size = new Size(1300, 4);
            divider2.TabIndex = 0;
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Location = new Point(0, 44);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(1300, 676);
            flowPanel.TabIndex = 2;
            // 
            // windowBar
            // 
            windowBar.Controls.Add(btn_mode);
            windowBar.Controls.Add(btn_back);
            windowBar.Dock = DockStyle.Top;
            windowBar.IconSvg = Properties.Resources.logo;
            windowBar.Location = new Point(0, 0);
            windowBar.Name = "windowBar";
            windowBar.Size = new Size(1300, 40);
            windowBar.SubText = "Overview";
            windowBar.TabIndex = 0;
            windowBar.Text = "Ant Design 5.0";
            // 
            // Main
            // 
            BackColor = Color.White;
            ClientSize = new Size(1300, 720);
            Controls.Add(flowPanel);
            Controls.Add(divider2);
            Controls.Add(windowBar);
            Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Overview";
            windowBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntDesign.Button btn_mode;
        private AntDesign.Divider divider2;
        private FlowLayoutPanel flowPanel;
        private AntDesign.Button btn_back;
        private AntDesign.WindowBar windowBar;
    }
}