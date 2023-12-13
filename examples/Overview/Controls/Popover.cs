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
    public partial class Popover : UserControl
    {
        public Popover()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(button1, "Basic Popover", "Content" + Environment.NewLine + "Content");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(button2, new Button() { Size = new Size(400, 300) });
        }

        private void buttonTL_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonTL, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.TL);
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonTop, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.Top);
        }

        private void buttonTR_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonTR, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.TR);
        }

        private void buttonRT_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonRT, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.RT);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonRight, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.Right);
        }

        private void buttonRB_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonRB, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.RB);
        }

        private void buttonBR_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonBR, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.BR);
        }

        private void buttonBottom_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonBottom, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.Bottom);
        }

        private void buttonBL_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonBL, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.BL);
        }

        private void buttonLB_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonLB, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.LB);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonLeft, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.Left);
        }

        private void buttonLT_Click(object sender, EventArgs e)
        {
            AntDesign.Popover.open(buttonLT, "Title", "Content" + Environment.NewLine + "Content", AntDesign.TAlign.LT);
        }
    }
}