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
    public partial class Button : UserControl
    {
        public Button()
        {
            InitializeComponent();
            button4.Image = Properties.Resources.icon_search.SvgToBmp(false);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            panel2.Width = button2.Width + button15.Width + button10.Width + panel2.Padding.Horizontal;
            panel2.Height = button2.Height + panel2.Padding.Vertical;
        }
        private void Btn(object sender, EventArgs e)
        {
            AntDesign.Button btn = (AntDesign.Button)sender;
            btn.Loading = true;
            bool change = false;
            if (btn.Parent == panel2)
            {
                change = true;
                panel2.Width = button2.Width + button15.Width + button10.Width + panel2.Padding.Horizontal;
            }
            Task.Run(() =>
            {
                Thread.Sleep(2000);
                btn.Loading = false;
            }).ContinueWith(action =>
            {
                if (change)
                {
                    panel2.Invoke(() =>
                    {
                        panel2.Width = button2.Width + button15.Width + button10.Width + panel2.Padding.Horizontal;
                    });
                }
            });
        }

        Random random = new Random();
        private void Btn2(object sender, EventArgs e)
        {
            AntDesign.Button btn = (AntDesign.Button)sender;
            int nnn = random.Next(0, 20);
            if (nnn > 10)
            {
                btn.Loading = true;
                btn.Enabled = false;
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    btn.Loading = false;
                    btn.Invoke(() =>
                    {
                        btn.Enabled = true;
                    });
                });
            }
            else if (nnn > 5)
            {
                btn.Loading = true;
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    btn.Loading = false;
                });
            }
            else
            {
                btn.Enabled = false;
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    btn.Invoke(() =>
                    {
                        btn.Enabled = true;
                    });
                });
            }
        }
    }
}