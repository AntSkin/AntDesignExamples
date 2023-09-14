namespace Overview.Controls
{
    public partial class Notification : UserControl
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AntDesign.Notification.info((Form)Parent, "Notification " + button1.Text, "Hello, Ant Design!", AntDesign.TAlignFrom.TL, Font);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AntDesign.Notification.info((Form)Parent, "Notification " + button2.Text, "Hello, Ant Design!", AntDesign.TAlignFrom.TR, Font);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AntDesign.Notification.info((Form)Parent, "Notification " + button3.Text, "Hello, Ant Design!", AntDesign.TAlignFrom.BL, Font);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AntDesign.Notification.info((Form)Parent, "Notification " + button4.Text, "Hello, Ant Design!", AntDesign.TAlignFrom.BR, Font);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AntDesign.Notification.info((Form)Parent, "Notification " + button5.Text, "This is the content of the notification. This is the content of the notification. This is the content of the notification.", AntDesign.TAlignFrom.Top, Font);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AntDesign.Notification.info((Form)Parent, "Notification " + button6.Text, "This is the content of the notification. This is the content of the notification. This is the content of the notification.", AntDesign.TAlignFrom.Bottom, Font);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AntDesign.Notification.success((Form)Parent, "Notification Title", "This is the content of the notification. This is the content of the notification. This is the content of the notification.", AntDesign.TAlignFrom.TR, Font);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AntDesign.Notification.error((Form)Parent, "Notification Title", "This is the content of the notification. This is the content of the notification. This is the content of the notification.", AntDesign.TAlignFrom.TR, Font);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AntDesign.Notification.warn((Form)Parent, "Notification Title", "This is the content of the notification. This is the content of the notification. This is the content of the notification.", AntDesign.TAlignFrom.TR, Font);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AntDesign.Notification.info((Form)Parent, "Notification Title", "This is the content of the notification. This is the content of the notification. This is the content of the notification.", AntDesign.TAlignFrom.TR, Font);
        }
    }
}