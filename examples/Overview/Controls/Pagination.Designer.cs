namespace Overview.Controls
{
    partial class Pagination
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
            pagination2 = new AntDesign.Pagination();
            pagination1 = new AntDesign.Pagination();
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
            header1.Text = "Pagination 分页";
            header1.TextDesc = "采用分页的形式分隔长列表，每次只加载一个页面。";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pagination2);
            panel1.Controls.Add(pagination1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 597);
            panel1.TabIndex = 7;
            // 
            // pagination2
            // 
            pagination2.Location = new Point(3, 55);
            pagination2.Margin = new Padding(1);
            pagination2.Name = "pagination2";
            pagination2.Padding = new Padding(4);
            pagination2.ShowSizeChanger = true;
            pagination2.Size = new Size(307, 38);
            pagination2.TabIndex = 12;
            pagination2.Total = 100;
            // 
            // pagination1
            // 
            pagination1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pagination1.Location = new Point(3, 6);
            pagination1.Name = "pagination1";
            pagination1.Size = new Size(1282, 30);
            pagination1.TabIndex = 13;
            pagination1.TextDesc = "1/10";
            pagination1.Total = 1000;
            // 
            // Pagination
            // 
            Controls.Add(panel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Pagination";
            Size = new Size(1300, 676);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntDesign.Header header1;
        private System.Windows.Forms.Panel panel1;
        private AntDesign.Pagination pagination2;
        private AntDesign.Pagination pagination1;
    }
}