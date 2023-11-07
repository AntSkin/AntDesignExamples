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
            panel1.Spin(() =>
            {
                Thread.Sleep(2000);
            });
        }
    }
}
