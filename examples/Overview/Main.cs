namespace Overview
{
    public partial class Main : AntDesign.Window
    {
        public Main()
        {
            InitializeComponent();

            panel_top.MouseDown += Window_MouseDown;
            label_title.MouseDown += Window_MouseDown;

            panel_top.MouseMove += Window_MouseMove;
            label_title.MouseMove += Window_MouseMove;
        }

        void Window_MouseMove(object? sender, MouseEventArgs e)
        {
            ControlMouseMove(sender, e);
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
            if (sender is Control control && control.Tag is string code)
            {
                Control? control_add = null;
                switch (code)
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
                    case "Alert":
                        control_add = new Controls.Alert();
                        break;
                    case "Message":
                        control_add = new Controls.Message();
                        break;
                    case "Notification":
                        control_add = new Controls.Notification();
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
                            c.ExtraMouseHover = false;
                        }
                        control_add.Dock = DockStyle.Fill;
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
                if (btn_back.Tag is Control control) Controls.Remove(control);
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

        protected override void OnSizeChanged(EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                btn_max.Image = Properties.Resources.app_max2b;
            }
            else
            {
                btn_max.Image = Properties.Resources.app_maxb;
            }
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

            var dir = new List<IList>
            {
                new IList("Button","按钮",Properties.Resources.Button),
                new IList("Avatar","头像",Properties.Resources.Avatar),
                new IList("Carousel","走马灯",Properties.Resources.Carousel),
                new IList("Checkbox","多选框",Properties.Resources.Checkbox),
                new IList("Radio","单选框",Properties.Resources.Radio),
                new IList("Input","输入框",Properties.Resources.Input),
                new IList("Divider","分割线",Properties.Resources.Divider),
                new IList("Panel","面板",Properties.Resources.Panel),
                new IList("Progress","进度条",Properties.Resources.Progress),
                new IList("Slider","滑动输入条",Properties.Resources.Slider),
                new IList("Switch","开关",Properties.Resources.Switch),
                new IList("Tabs","标签页",Properties.Resources.Tabs),
                new IList("Badge","徽标数",Properties.Resources.Badge),
                new IList("Alert","警告提示",Properties.Resources.Alert),
                new IList("Message","全局提示",Properties.Resources.Message),
                new IList("Notification","通知提醒框",Properties.Resources.Notification),
                new IList("Tooltip","文字提示",Properties.Resources.Tooltip),
            };
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
                        Padding = new Padding(20),
                        Shadow = 20,
                        Size = new Size(229, 233),
                        Tag = item.id
                    };
                    var pic = new PictureBox
                    {
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Fill,
                        Image = item.img,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Tag = item.id
                    };

                    var divider = new AntDesign.Divider
                    {
                        Color = Color.FromArgb(20, 0, 0, 0),
                        Dock = DockStyle.Top,
                        Margin = new Padding(10),
                        Size = new Size(0, 1),
                        Tag = item.id
                    };
                    var label = new Label
                    {
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Top,
                        Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold, GraphicsUnit.Point),
                        Padding = new Padding(10, 0, 0, 0),
                        Size = new Size(0, 34),
                        Text = item.id + " " + item.key,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Tag = item.id
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
            public IList(string _id, string _key, Image _img)
            {
                id = _id;
                key = _key;
                img = _img;
            }
            public string id { get; set; }
            public string key { get; set; }
            public Image img { get; set; }
        }

        #endregion
    }
}