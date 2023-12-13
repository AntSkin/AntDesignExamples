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
    public partial class Modal : UserControl
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AntDesign.Modal.open(new AntDesign.Modal.Config((Form)Parent, "This is a success message", "Some contents...Some contents...Some contents...Some contents...Some contents...Some contents...Some contents...", AntDesign.TType.Success)
            {
                CancelText = null,
                OkText = "ÖªµÀÁË"
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AntDesign.Modal.open((Form)Parent, "This is a error message", "Some contents...Some contents...Some contents...Some contents...Some contents...Some contents...Some contents...", AntDesign.TType.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            AntDesign.Modal.open(new AntDesign.Modal.Config((Form)Parent, "This is a warn message", "Some contents...Some contents...Some contents...Some contents...Some contents...Some contents...Some contents...", AntDesign.TType.Warn)
            {
                OnOk = config =>
                {
                    Thread.Sleep(1000);
                    return true;
                }
            });
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AntDesign.Modal.open((Form)Parent, "Hello, Ant Design!", "Some contents...Some contents...Some contents...Some contents...Some contents...Some contents...Some contents...");
        }
    }
}