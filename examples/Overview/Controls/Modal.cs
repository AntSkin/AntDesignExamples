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