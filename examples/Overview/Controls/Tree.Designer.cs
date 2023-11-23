namespace Overview.Controls
{
    partial class Tree
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
            tree1 = new AntDesign.Tree();
            tree2 = new AntDesign.Tree();
            SuspendLayout();
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Padding = new Padding(6);
            header1.Size = new Size(740, 79);
            header1.TabIndex = 4;
            header1.Text = "Tree 树形控件";
            header1.TextDesc = "多层次的结构列表。";
            // 
            // tree1
            // 
            tree1.Checkable = true;
            tree1.Dock = DockStyle.Left;
            tree1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tree1.Location = new Point(0, 79);
            tree1.Name = "tree1";
            tree1.Size = new Size(328, 323);
            tree1.TabIndex = 18;
            tree1.Text = "menu1";
            // 
            // tree2
            // 
            tree2.BlockNode = true;
            tree2.Dock = DockStyle.Fill;
            tree2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tree2.Location = new Point(328, 79);
            tree2.Name = "tree2";
            tree2.Size = new Size(412, 323);
            tree2.TabIndex = 19;
            tree2.Text = "menu1";
            // 
            // Tree
            // 
            Controls.Add(tree2);
            Controls.Add(tree1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Tree";
            Size = new Size(740, 402);
            ResumeLayout(false);
        }

        #endregion

        private AntDesign.Header header1;
        private AntDesign.Tree tree1;
        private AntDesign.Tree tree2;
    }
}