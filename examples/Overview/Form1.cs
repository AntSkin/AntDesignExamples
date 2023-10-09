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
        Random random = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            image3d1_Click(sender, e);
        }

        private void image3d1_Click(object sender, EventArgs e)
        {
            var num = random.Next(1, 9);
            switch (num)
            {
                case 1:
                    image3d1.Image = Properties.Resources.bg1; break;
                case 2:
                    image3d1.Image = Properties.Resources.bg2; break;
                case 3:
                    image3d1.Image = Properties.Resources.bg3; break;
                case 4:
                    image3d1.Image = Properties.Resources.bg4; break;
                case 5:
                    image3d1.Image = Properties.Resources.bg5; break;
                case 6:
                    image3d1.Image = Properties.Resources.bg6; break;
                default:
                    image3d1.Image = Properties.Resources.bg7;
                    break;
            }
        }

        private void image3d2_Click(object sender, EventArgs e)
        {
            var num = random.Next(1, 9);
            switch (num)
            {
                case 1:
                    image3d2.Image = Properties.Resources.bg1; break;
                case 2:
                    image3d2.Image = Properties.Resources.bg2; break;
                case 3:
                    image3d2.Image = Properties.Resources.bg3; break;
                case 4:
                    image3d2.Image = Properties.Resources.bg4; break;
                case 5:
                    image3d2.Image = Properties.Resources.bg5; break;
                case 6:
                    image3d2.Image = Properties.Resources.bg6; break;
                default:
                    image3d2.Image = Properties.Resources.bg7;
                    break;
            }
        }
    }
}
