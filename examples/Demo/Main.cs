namespace Demo
{
    public partial class Main : AntDesign.Window
    {
        public Main()
        {
            InitializeComponent();

            panel_top.MouseDown += Window_MouseDown;
            label_title.MouseDown += Window_MouseDown;
            tableLayoutPanel8.MouseDown += Window_MouseDown;

            panel_top.MouseMove += Window_MouseMove;
            label_title.MouseMove += Window_MouseMove;
            tableLayoutPanel8.MouseMove += Window_MouseMove;
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

        private void Progress_Blue_1(object sender, EventArgs e)
        {
            progress1.Value = 0F;
            label1.Text = "0%";
            Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        progress1.Value += 0.001F;
                        Invoke(new Action(() =>
                        {
                            label1.Text = (progress1.Value * 100F).ToString("F0") + "%";
                        }));
                        if (progress1.Value >= 1)
                        {
                            Thread.Sleep(1000);
                            progress1.Value = 0.5F;
                            Invoke(new Action(() =>
                            {
                                label1.Text = (progress1.Value * 100F).ToString("F0") + "%";
                            }));
                            return;
                        }
                        Thread.Sleep(10);
                    }
                    catch
                    {
                        return;
                    }
                }
            });
        }

        private void Progress_Blue_2(object sender, EventArgs e)
        {
            progress4.Value = progress7.Value = 0F;
            progress4.Text = "0%";
            Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        progress7.Value = progress4.Value += 0.001F;
                        progress4.Text = (progress4.Value * 100F).ToString("F0") + "%";
                        if (progress4.Value >= 1)
                        {
                            Thread.Sleep(1000);
                            progress4.Value = progress7.Value = 0.68F;
                            progress4.Text = (progress4.Value * 100F).ToString("F0") + "%";
                            return;
                        }
                        Thread.Sleep(10);
                    }
                    catch
                    {
                        return;
                    }
                }
            });
        }

        private void Progress_Red(object sender, EventArgs e)
        {
            progress6.Icon = AntDesign.TType.None;
            progress3.Value = progress6.Value = progress9.Value = 0F;
            progress6.Text = "0%";
            progress3.Color = progress6.Color = progress1.Color;
            Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        progress3.Value = progress6.Value = progress9.Value += 0.001F;
                        progress6.Text = (progress6.Value * 100F).ToString("F0") + "%";
                        if (progress6.Value >= 0.7)
                        {
                            progress3.Value = progress6.Value = progress9.Value = 0.7F;
                            progress3.Color = progress6.Color = progress9.Color;
                            progress6.Text = null;
                            progress6.Icon = AntDesign.TType.Error;
                            return;
                        }
                        Thread.Sleep(10);
                    }
                    catch
                    {
                        return;
                    }
                }
            });
        }

        Random random = new Random();
        private void Button_Click(object? sender, EventArgs e)
        {
            if (sender is AntDesign.Button btn)
            {
                if (random.Next(0, 10) > 5)
                {
                    btn.Enabled = false;
                    Task.Run(() =>
                    {
                        Thread.Sleep(2000);
                        Invoke(new Action(() =>
                        {
                            btn.Enabled = true;
                        }));
                    });
                }
                else
                {
                    btn.Loading = true;
                    Task.Run(() =>
                    {
                        Thread.Sleep(2000);
                        btn.Loading = false;
                    });
                }
            }
        }

        private void btn_close_Click(object? sender, EventArgs e)
        {
            Close();
            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Process.Start(@"E:\Pro\source\oxdragon\AntDesignExamples\examples\Overview\bin\Debug\net6.0-windows\Overview.exe");
            //}).Start();
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
