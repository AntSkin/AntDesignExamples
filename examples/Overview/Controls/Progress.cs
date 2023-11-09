namespace Overview.Controls
{
    public partial class Progress : UserControl
    {
        public Progress()
        {
            InitializeComponent();
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
            iError2.Visible = false;
            progress3.Value = progress6.Value = progress9.Value = 0F;
            progress6.Text = "0%";
            progress3.Fill = progress6.Fill = progress1.Fill;
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
                            progress3.Fill = progress6.Fill = progress9.Fill;
                            progress6.Text = null;
                            Invoke(new Action(() =>
                            {
                                iError2.Visible = true;
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
    }
}