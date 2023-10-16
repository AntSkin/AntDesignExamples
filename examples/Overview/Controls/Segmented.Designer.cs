namespace Overview.Controls
{
    partial class Segmented
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
            AntDesign.SegmentedItem segmentedItem1 = new AntDesign.SegmentedItem();
            AntDesign.SegmentedItem segmentedItem2 = new AntDesign.SegmentedItem();
            AntDesign.SegmentedItem segmentedItem3 = new AntDesign.SegmentedItem();
            AntDesign.SegmentedItem segmentedItem4 = new AntDesign.SegmentedItem();
            AntDesign.SegmentedItem segmentedItem5 = new AntDesign.SegmentedItem();
            AntDesign.SegmentedItem segmentedItem6 = new AntDesign.SegmentedItem();
            AntDesign.SegmentedItem segmentedItem7 = new AntDesign.SegmentedItem();
            AntDesign.SegmentedItem segmentedItem8 = new AntDesign.SegmentedItem();
            AntDesign.SegmentedItem segmentedItem9 = new AntDesign.SegmentedItem();
            header1 = new AntDesign.Header();
            panel1 = new System.Windows.Forms.Panel();
            segmented2 = new AntDesign.Segmented();
            segmented1 = new AntDesign.Segmented();
            panel1.SuspendLayout();
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
            header1.TabIndex = 5;
            header1.Text = "Segmented 分段控制器";
            header1.TextDesc = "分段控制器。";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(segmented2);
            panel1.Controls.Add(segmented1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 597);
            panel1.TabIndex = 7;
            // 
            // segmented2
            // 
            segmentedItem1.Img = Properties.Resources.img1;
            segmentedItem1.Text = "Daily";
            segmentedItem2.Img = Properties.Resources.bg7;
            segmentedItem2.Text = "Weekly";
            segmentedItem3.Img = Properties.Resources.bg1;
            segmentedItem3.Text = "Monthly";
            segmentedItem4.Img = Properties.Resources.bg5;
            segmentedItem4.Text = "Quarterly";
            segmented2.Items.AddRange(new AntDesign.SegmentedItem[] { segmentedItem1, segmentedItem2, segmentedItem3, segmentedItem4 });
            segmented2.Location = new Point(3, 55);
            segmented2.Margin = new Padding(1);
            segmented2.Name = "segmented2";
            segmented2.SelectIndex = 0;
            segmented2.Size = new Size(307, 73);
            segmented2.TabIndex = 12;
            // 
            // segmented1
            // 
            segmentedItem5.Text = "Daily";
            segmentedItem6.Text = "Weekly";
            segmentedItem7.Text = "Monthly";
            segmentedItem8.Text = "Quarterly";
            segmentedItem9.Text = "Yearly";
            segmented1.Items.AddRange(new AntDesign.SegmentedItem[] { segmentedItem5, segmentedItem6, segmentedItem7, segmentedItem8, segmentedItem9 });
            segmented1.Location = new Point(3, 6);
            segmented1.Name = "segmented1";
            segmented1.Size = new Size(377, 36);
            segmented1.TabIndex = 13;
            segmented1.Text = "segmented1";
            // 
            // Segmented
            // 
            Controls.Add(panel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Segmented";
            Size = new Size(1300, 676);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntDesign.Header header1;
        private System.Windows.Forms.Panel panel1;
        private AntDesign.Segmented segmented2;
        private AntDesign.Segmented segmented1;
    }
}