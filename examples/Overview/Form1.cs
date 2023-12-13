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
    public partial class Form1 : AntDesign.BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AntDesign.Config.IsDark = AntDesign.Config.IsLight;
            panel9.Spin(() =>
            {
                Thread.Sleep(1000);
                AntDesign.Modal.open(new AntDesign.Modal.Config(this, "Basic Modal", "Some contents...Some contents...Some contents...Some contents...Some contents...Some contents...Some contents...", AntDesign.TType.Warn)
                {
                    CancelText = null,
                    OkText = "确认你个鸡儿",
                    OkType = AntDesign.TTypeMini.Error,
                    OnOk = config =>
                    {
                        Thread.Sleep(2000);
                        return true;
                    }
                });
                Thread.Sleep(1000);
            });
        }
    }
}
