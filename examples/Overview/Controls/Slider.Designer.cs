namespace Overview.Controls
{
    partial class Slider
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            slider1 = new AntDesign.Slider();
            slider3 = new AntDesign.Slider();
            slider2 = new AntDesign.Slider();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Padding = new Padding(6);
            header1.Size = new Size(806, 79);
            header1.TabIndex = 4;
            header1.Text = "Slider 滑动输入条";
            header1.TextDesc = "滑动型输入器，展示当前值和可选范围。";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(slider1);
            flowLayoutPanel1.Controls.Add(slider3);
            flowLayoutPanel1.Controls.Add(slider2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 79);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(806, 409);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // slider1
            // 
            slider1.Location = new Point(3, 3);
            slider1.Name = "slider1";
            slider1.Size = new Size(212, 38);
            slider1.TabIndex = 4;
            slider1.Text = "slider1";
            // 
            // slider3
            // 
            slider3.Dots = new int[] { 20, 50, 70, 80 };
            slider3.DotSize = 18;
            slider3.DotSizeActive = 24;
            slider3.Location = new Point(221, 3);
            slider3.Name = "slider3";
            slider3.ShowValue = true;
            slider3.Size = new Size(485, 38);
            slider3.TabIndex = 2;
            // 
            // slider2
            // 
            slider2.Dots = new int[] { 20, 50, 70, 80 };
            slider2.DotSize = 18;
            slider2.DotSizeActive = 24;
            slider2.Location = new Point(712, 3);
            slider2.Name = "slider2";
            slider2.ShowValue = true;
            slider2.Size = new Size(40, 406);
            slider2.TabIndex = 3;
            slider2.Vertical = true;
            // 
            // Slider
            // 
            Controls.Add(flowLayoutPanel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Slider";
            Size = new Size(806, 488);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntDesign.Header header1;
        private FlowLayoutPanel flowLayoutPanel1;
        private AntDesign.Slider slider3;
        private AntDesign.Slider slider2;
        private AntDesign.Slider slider1;
    }
}