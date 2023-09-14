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

        private void Btn(object sender, EventArgs e)
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
                    control_add.Dock = DockStyle.Fill;
                    SuspendLayout();
                    Controls.Add(control_add);
                    control_add.BringToFront();
                    ResumeLayout();
                    btn_back.Visible = true;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (btn_back.Tag is Control control)
            {
                SuspendLayout();
                Controls.Remove(control);
                ResumeLayout();
            }
            btn_back.Visible = false;
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
    }
}