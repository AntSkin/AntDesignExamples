namespace Overview.Controls
{
    public partial class Button : UserControl
    {
        public Button()
        {
            InitializeComponent();
        }

        private void Btn(object sender, EventArgs e)
        {
            AntDesign.Button btn = (AntDesign.Button)sender;
            btn.Loading = true;
            Task.Run(() =>
            {
                Thread.Sleep(2000);
                btn.Loading = false;
            });
        }
    }
}