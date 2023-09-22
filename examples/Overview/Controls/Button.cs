namespace Overview.Controls
{
    public partial class Button : UserControl
    {
        public Button()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            panel2.Width = button2.Width + button15.Width + button10.Width + 40;
            panel2.Height = button2.Height + 40;
        }
        private void Btn(object sender, EventArgs e)
        {
            AntDesign.Button btn = (AntDesign.Button)sender;
            btn.Loading = true;
            bool change = false;
            if (btn.Parent == panel2)
            {
                change = true;
                panel2.Width = button2.Width + button15.Width + button10.Width + 40;
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
                        panel2.Width = button2.Width + button15.Width + button10.Width + 40;
                    });
                }
            });
        }
    }
}