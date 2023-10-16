namespace Overview.Controls
{
    public partial class Carousel : UserControl
    {
        public Carousel()
        {
            InitializeComponent();
            if (carousel1.Image != null) slider1.MaxValue = carousel1.Image.Count - 1;
            carousel1.SelectIndexChanged += (a, b) =>
            {
                slider1.Value = carousel1.SelectIndex;
            };
            slider1.ValueChanged += (a) =>
            {
                carousel1.SelectIndex = a;
            };
        }

        Random random = new Random();
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