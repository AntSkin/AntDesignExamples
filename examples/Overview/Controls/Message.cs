namespace Overview.Controls
{
    public partial class Message : UserControl
    {
        public Message()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AntDesign.Message.success((Form)Parent, "This is a success message", Font);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AntDesign.Message.error((Form)Parent, "This is a error message", Font);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AntDesign.Message.warn((Form)Parent, "This is a warn message", Font);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AntDesign.Message.info((Form)Parent, "Hello, Ant Design!", Font);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            AntDesign.Message.loading((Form)Parent, "Action in progress..", (config) =>
            {
                Thread.Sleep(3000);
                config.OK("This is a success message");
                Invoke(new Action(() =>
                {
                    button8.Enabled = true;
                }));
            }, Font);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            AntDesign.Message.loading((Form)Parent, "Action in progress..", (config) =>
            {
                Thread.Sleep(3000);
                config.Error("This is a error message");
                Invoke(new Action(() =>
                {
                    button7.Enabled = true;
                }));
            }, Font);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            AntDesign.Message.loading((Form)Parent, "Action in progress..", (config) =>
            {
                Thread.Sleep(3000);
                config.Warn("This is a warn message");
                Invoke(new Action(() =>
                {
                    button6.Enabled = true;
                }));
            }, Font);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            AntDesign.Message.loading((Form)Parent, "Action in progress..", (config) =>
            {
                Thread.Sleep(3000);
                config.Info("Hello, Ant Design!");
                Invoke(new Action(() =>
                {
                    button5.Enabled = true;
                }));
            }, Font);
        }
    }
}