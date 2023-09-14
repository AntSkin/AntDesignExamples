using AntDesign;

namespace Overview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var arrd = panel1.Back.DarkColors(3, 40);
            var arrl = panel1.Back.LightColors(3, 40);
            label2.BackColor = arrd[0];
            label3.BackColor = arrd[1];
            label4.BackColor = arrd[2];

            label5.BackColor = arrl[0];
            label6.BackColor = arrl[1];
            label7.BackColor = arrl[2];

            panel2.Back = arrl[0];

            label16.Text = "#" + arrl[0].Name.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var arrd = panel1.Back.DarkColors(20, 100);
                var arrl = panel1.Back.LightColors(20, 100);
                foreach (var item in arrd)
                {
                    panel2.Back = item;
                    var mode = item.ColorMode();
                    label6.Invoke(() =>
                    {
                        panel2.ForeColor = mode ? Color.Black : Color.White;
                        label16.ForeColor = mode ? Color.DarkGray : Color.WhiteSmoke;
                        label16.Text = "#" + item.Name.ToUpper();
                    });
                    Thread.Sleep(500);
                }
                Thread.Sleep(1000);
                foreach (var item in arrl)
                {
                    panel2.Back = item;
                    var mode = item.ColorMode();
                    label6.Invoke(() =>
                    {
                        panel2.ForeColor = mode ? Color.Black : Color.White;
                        label16.ForeColor = mode ? Color.DarkGray : Color.WhiteSmoke;
                        label16.Text = "#" + item.Name.ToUpper();
                    });
                    Thread.Sleep(500);
                }
            });
        }
    }
}
