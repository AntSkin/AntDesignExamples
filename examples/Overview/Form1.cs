namespace Overview
{
    public partial class Form1 : Form
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
