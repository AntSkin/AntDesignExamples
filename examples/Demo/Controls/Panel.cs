using AntDesign;

namespace TSkin
{
    public class Panel : System.Windows.Forms.Panel, IDpi
    {
        DpiPadding padding = new DpiPadding();
        public new Padding Padding
        {
            get => padding.Value;
            set
            {
                if (padding.SetValue(value, this)) base.Padding = padding.V;
            }
        }

        DpiSize size = new DpiSize();
        public new Size Size
        {
            get => size.Value;
            set
            {
                if (size.SetValue(value, this)) base.Size = size.V;
            }
        }

        DpiSize minimumSize = new DpiSize(), maximumSize = new DpiSize();
        public new Size MinimumSize
        {
            get => minimumSize.Value;
            set
            {
                if (minimumSize.SetValue(value, this)) base.MinimumSize = minimumSize.V;
            }
        }
        public new Size MaximumSize
        {
            get => maximumSize.Value;
            set
            {
                if (maximumSize.SetValue(value, this)) base.MaximumSize = maximumSize.V;
            }
        }

        public float Dpi()
        {
            return DeviceDpi / 96F;
        }

        public float Dpi(Graphics g)
        {
            return g.DpiX / 96F;
        }
    }
}