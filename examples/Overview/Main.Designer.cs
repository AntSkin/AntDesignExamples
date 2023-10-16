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
            panel_top = new Panel();
            label_title = new Label();
            btn_back = new AntDesign.Button();
            btn_min = new AntDesign.Button();
            btn_max = new AntDesign.Button();
            btn_close = new AntDesign.Button();
            divider2 = new AntDesign.Divider();
            flowPanel = new FlowLayoutPanel();
            panel_top.SuspendLayout();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.Controls.Add(label_title);
            panel_top.Controls.Add(btn_back);
            panel_top.Controls.Add(btn_min);
            panel_top.Controls.Add(btn_max);
            panel_top.Controls.Add(btn_close);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(934, 40);
            panel_top.TabIndex = 1;
            // 
            // label_title
            // 
            label_title.Dock = DockStyle.Fill;
            label_title.Location = new Point(90, 0);
            label_title.Name = "label_title";
            label_title.Padding = new Padding(10, 0, 0, 0);
            label_title.Size = new Size(686, 40);
            label_title.TabIndex = 0;
            label_title.Text = "Ant Design 5.0 - Overview";
            label_title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_back
            // 
            btn_back.Back = Color.Transparent;
            btn_back.BackActive = Color.FromArgb(172, 172, 172);
            btn_back.BackHover = Color.FromArgb(223, 223, 223);
            btn_back.Dock = DockStyle.Left;
            btn_back.Image = Properties.Resources.back;
            btn_back.Location = new Point(0, 0);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(90, 40);
            btn_back.TabIndex = 7;
            btn_back.Text = "返回";
            btn_back.Visible = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_min
            // 
            btn_min.Back = Color.Transparent;
            btn_min.BackActive = Color.FromArgb(172, 172, 172);
            btn_min.BackHover = Color.FromArgb(223, 223, 223);
            btn_min.Dock = DockStyle.Right;
            btn_min.Font = new Font("Microsoft YaHei UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_min.Image = Properties.Resources.app_minb;
            btn_min.Location = new Point(776, 0);
            btn_min.Margins = 0;
            btn_min.Name = "btn_min";
            btn_min.Radius = 0;
            btn_min.Size = new Size(50, 40);
            btn_min.TabIndex = 6;
            btn_min.Click += btn_min_Click;
            // 
            // btn_max
            // 
            btn_max.Back = Color.Transparent;
            btn_max.BackActive = Color.FromArgb(172, 172, 172);
            btn_max.BackHover = Color.FromArgb(223, 223, 223);
            btn_max.Dock = DockStyle.Right;
            btn_max.Font = new Font("Microsoft YaHei UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_max.Image = Properties.Resources.app_maxb;
            btn_max.Location = new Point(826, 0);
            btn_max.Margins = 0;
            btn_max.Name = "btn_max";
            btn_max.Radius = 0;
            btn_max.Size = new Size(50, 40);
            btn_max.TabIndex = 5;
            btn_max.Click += btn_max_Click;
            // 
            // btn_close
            // 
            btn_close.Back = Color.Transparent;
            btn_close.BackActive = Color.FromArgb(145, 31, 20);
            btn_close.BackHover = Color.FromArgb(196, 43, 28);
            btn_close.Dock = DockStyle.Right;
            btn_close.Font = new Font("Microsoft YaHei UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_close.Image = Properties.Resources.app_closeb;
            btn_close.ImageHover = Properties.Resources.app_close;
            btn_close.Location = new Point(876, 0);
            btn_close.Margins = 0;
            btn_close.Name = "btn_close";
            btn_close.Radius = 0;
            btn_close.Size = new Size(58, 40);
            btn_close.TabIndex = 4;
            btn_close.Click += btn_close_Click;
            // 
            // divider2
            // 
            divider2.Dock = DockStyle.Top;
            divider2.Location = new Point(0, 40);
            divider2.Name = "divider2";
            divider2.Size = new Size(934, 4);
            divider2.TabIndex = 0;
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Location = new Point(0, 44);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(934, 544);
            flowPanel.TabIndex = 2;
            // 
            // Main
            // 
            BackColor = Color.White;
            ClientSize = new Size(1300, 720);
            Controls.Add(flowPanel);
            Controls.Add(divider2);
            Controls.Add(panel_top);
            Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Overview";
            panel_top.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_top;
        private Label label_title;
        private AntDesign.Button btn_min;
        private AntDesign.Button btn_max;
        private AntDesign.Button btn_close;
        private AntDesign.Divider divider2;
        private FlowLayoutPanel flowPanel;
        private AntDesign.Button btn_back;
    }
}