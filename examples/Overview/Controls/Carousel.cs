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
    }
}