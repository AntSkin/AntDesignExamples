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
    public partial class Main : AntDesign.Window
    {
        public Main()
        {
            InitializeComponent();

            panel_top.MouseDown += Window_MouseDown;
            label_title.MouseDown += Window_MouseDown;
        }

        void Window_MouseDown(object? sender, MouseEventArgs e)
        {
            ControlMouseDown(sender, e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            ControlMouseDown(this, e);
            base.OnMouseDown(e);
        }

        private void Btn(object? sender, EventArgs e)
        {
            if (sender is Control control && control.Tag is IList tag)
            {
                Control? control_add = null;
                switch (tag.id)
                {
                    case "Button":
                        control_add = new Controls.Button();
                        break;
                    case "Avatar":
                        control_add = new Controls.Avatar();
                        break;
                    case "Carousel":
                        control_add = new Controls.Carousel();
                        break;
                    case "Badge":
                        control_add = new Controls.Badge();
                        break;
                    case "Checkbox":
                        control_add = new Controls.Checkbox();
                        break;
                    case "Radio":
                        control_add = new Controls.Radio();
                        break;
                    case "Input":
                        control_add = new Controls.Input();
                        break;
                    case "Panel":
                        control_add = new Controls.Panel();
                        break;
                    case "Progress":
                        control_add = new Controls.Progress();
                        break;
                    case "Tooltip":
                        control_add = new Controls.Tooltip();
                        break;
                    case "Divider":
                        control_add = new Controls.Divider();
                        break;
                    case "Slider":
                        control_add = new Controls.Slider();
                        break;
                    case "Tabs":
                        control_add = new Controls.Tabs();
                        break;
                    case "Switch":
                        control_add = new Controls.Switch();
                        break;
                    case "Pagination":
                        control_add = new Controls.Pagination();
                        break;
                    case "Alert":
                        control_add = new Controls.Alert();
                        break;
                    case "Message":
                        control_add = new Controls.Message();
                        break;
                    case "Notification":
                        control_add = new Controls.Notification();
                        break;
                    case "Menu":
                        control_add = new Controls.Menu();
                        break;
                    case "Segmented":
                        control_add = new Controls.Segmented();
                        break;
                    case "Modal":
                        control_add = new Controls.Modal();
                        break;
                    case "DatePicker":
                        control_add = new Controls.DatePicker();
                        break;
                    case "Dropdown":
                        control_add = new Controls.Dropdown();
                        break;
                    case "Tree":
                        control_add = new Controls.Tree();
                        break;
                    case "Popover":
                        control_add = new Controls.Popover();
                        break;
                    case "Timeline":
                        control_add = new Controls.Timeline();
                        break;
                    case "Steps":
                        control_add = new Controls.Steps();
                        break;
                }
                if (control_add != null)
                {
                    btn_back.Tag = control_add;
                    BeginInvoke(() =>
                    {
                        flowPanel.Visible = false;
                        foreach (AntDesign.Panel c in flowPanel.Controls)
                        {
                            c.SetMouseHover(false);
                        }
                        control_add.Dock = DockStyle.Fill;
                        AutoDpi(control_add);
                        Controls.Add(control_add);
                        control_add.BringToFront();
                        btn_back.Visible = true;
                    });
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            BeginInvoke(() =>
            {
                if (btn_back.Tag is Control control)
                {
                    control.Dispose();
                    Controls.Remove(control);
                }
                btn_back.Visible = false;
                flowPanel.Visible = true;
            });
        }

        private void btn_close_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void btn_min_Click(object? sender, EventArgs e)
        {
            Min();
        }

        private void btn_mode_Click(object? sender, EventArgs e)
        {
            AntDesign.Config.IsDark = !AntDesign.Config.IsDark;
            Dark = AntDesign.Config.IsDark;
            if (Dark)
            {
                btn_mode.Image = Properties.Resources.app_light.SvgToBmp();
                BackColor = Color.Black;
                ForeColor = Color.White;
                btn_back.BackHover = btn_mode.BackHover = btn_min.BackHover = btn_max.BackHover = Color.FromArgb(32, 32, 32);
            }
            else
            {
                btn_mode.Image = Properties.Resources.app_dark.SvgToBmp();
                BackColor = Color.White;
                ForeColor = Color.Black;
                btn_back.BackHover = btn_mode.BackHover = btn_min.BackHover = btn_max.BackHover = Color.FromArgb(223, 223, 223);
            }
            foreach (AntDesign.Panel item in flowPanel.Controls)
            {
                foreach (Control control in item.Controls)
                {
                    if (control is PictureBox pic && pic.Tag is IList tag)
                    {
                        pic.Image = Dark ? tag.imgs[1] : tag.imgs[0];
                    }
                }
            }
            btn_back.Image = Properties.Resources.app_back.SvgToBmp();
            btn_min.Image = Properties.Resources.app_min.SvgToBmp();
            btn_close.Image = Properties.Resources.app_close.SvgToBmp();
            OnSizeChanged(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) btn_max.Image = Properties.Resources.app_restore.SvgToBmp();
            else btn_max.Image = Properties.Resources.app_max.SvgToBmp();
            base.OnSizeChanged(e);
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            MaxRestore();
        }

        #region 加载列表

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Run(LoadList);
        }

        void LoadList()
        {
            var dpi = AntDesign.Config.Dpi;

            var dir = new List<IList>
            {
                new IList("Button","按钮", res_light.Button, res_dark.Button),
                new IList("Avatar","头像", res_light.Avatar, res_dark.Avatar),
                new IList("Checkbox","多选框", res_light.Checkbox, res_dark.Checkbox),
                new IList("Radio","单选框", res_light.Radio, res_dark.Radio),
                new IList("Input","输入框", res_light.Input, res_dark.Input),
                new IList("DatePicker","日期选择框", res_light.DatePicker, res_dark.DatePicker),
                new IList("Dropdown","下拉菜单", res_light.Dropdown, res_dark.Dropdown),
                new IList("Menu","导航菜单", res_light.Menu, res_dark.Menu),
                new IList("Divider","分割线", res_light.Divider, res_dark.Divider),
                new IList("Panel","面板", res_light.Panel, res_dark.Panel),
                new IList("Carousel","走马灯",res_light.Carousel, res_dark.Carousel),
                new IList("Segmented","分段控制器",res_light.Segmented, res_dark.Segmented),
                new IList("Progress","进度条",res_light.Progress, res_dark.Progress),
                new IList("Slider","滑动输入条",res_light.Slider, res_dark.Slider),
                new IList("Switch","开关",res_light.Switch, res_dark.Switch),
                new IList("Pagination","分页",res_light.Pagination, res_dark.Pagination),
                new IList("Tabs","标签页",res_light.Tabs, res_dark.Tabs),
                new IList("Badge","徽标数",res_light.Badge, res_dark.Badge),
                new IList("Alert","警告提示",res_light.Alert, res_dark.Alert),
                new IList("Tree","树形控件",res_light.Tree, res_dark.Tree),
                new IList("Modal","对话框",res_light.Modal, res_dark.Modal),
                new IList("Message","全局提示",res_light.Message, res_dark.Message),
                new IList("Notification","通知提醒框",res_light.Notification, res_dark.Notification),
                new IList("Popover","气泡卡片",res_light.Popover, res_dark.Popover),
                new IList("Tooltip","文字提示",res_light.Tooltip, res_dark.Tooltip),
                new IList("Timeline","时间轴",res_light.Timeline, res_dark.Timeline),
                new IList("Steps","步骤条",res_light.Steps, res_dark.Steps),
            };

            var panel_size = new Size((int)(258 * dpi), (int)(244 * dpi));
            int title_height = (int)(44 * dpi), size = (int)(10 * dpi), size2 = size * 2;

            BeginInvoke(() =>
            {
                flowPanel.SuspendLayout();
                flowPanel.Controls.Clear();
                foreach (var item in dir)
                {
                    var panel = new AntDesign.Panel
                    {
                        BorderWidth = 1F,
                        Location = new Point(0, 0),
                        Margin = new Padding(0),
                        Padding = new Padding(size2),
                        Shadow = size2,
                        Size = panel_size,
                        Tag = item
                    };
                    var pic = new PictureBox
                    {
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Fill,
                        Image = Dark ? item.imgs[1] : item.imgs[0],
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        Tag = item
                    };

                    var divider = new AntDesign.Divider
                    {
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Top,
                        Margin = new Padding(size),
                        Size = new Size(0, 1),
                        Tag = item
                    };
                    var label = new Label
                    {
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Top,
                        Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold, GraphicsUnit.Point),
                        Padding = new Padding(size2, 0, 0, 0),
                        Size = new Size(0, title_height),
                        Text = item.id + " " + item.key,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Tag = item
                    };
                    panel.Controls.Add(pic);
                    panel.Controls.Add(divider);
                    panel.Controls.Add(label);
                    pic.Click += Btn;
                    label.Click += Btn;
                    flowPanel.Controls.Add(panel);
                }
                flowPanel.ResumeLayout();
            });
        }

        class IList
        {
            public IList(string _id, string _key, string _img_light, string _img_dark)
            {
                id = _id;
                key = _key;
                imgs = new Image[] { _img_light.SvgToBmp(false), _img_dark.SvgToBmp(true) };
            }
            public string id { get; set; }
            public string key { get; set; }
            public Image[] imgs { get; set; }
        }

        #endregion
    }
}