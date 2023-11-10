using AntDesign;

namespace Overview
{
    public partial class Colors : Form
    {
        public Colors()
        {
            InitializeComponent();
            CCC();
        }
        void CCC()
        {
            var colors = panel_primary.Back.Value.GenerateColors();
            panel11.Back = panel_primary.Back.Value.shade();
            color_dark.TextDesc = "#" + panel11.Back.Value.ToHex();
            int i = 1;
            foreach (var color in colors)
            {
                var _panel = tablePanel.Controls.Find("colorPanel" + i, false);
                if (_panel.Length > 0)
                {
                    if (_panel[0] is ColorPanel panel)
                    {
                        var mode = color.ColorMode();
                        panel.ForeColor = mode ? Color.Black : Color.White;
                        panel.BackColor = color;
                        panel.TextDesc = "#" + color.ToHex();
                    }
                }
                i++;
            }
        }
        private void label15_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog
            {
                Color = panel_primary.Back.Value
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    panel_primary.Back = dialog.Color;
                    color_primary.TextDesc = textBox1.Text = "#" + dialog.Color.ToHex();
                    CCC();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel_primary.Back = textBox1.Text.ToColor();
            color_primary.TextDesc = "#" + panel_primary.Back.Value.ToHex();
            CCC();
        }

        private void ColorPanel_MouseEnter(object sender, EventArgs e)
        {
            if (sender is ColorPanel panel)
            {
                panel.Margin = new Padding(0);
            }
        }

        private void ColorPanel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is ColorPanel panel)
            {
                panel.Margin = new Padding(0, 20, 0, 0);
            }
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            if (sender is ColorPanel panel)
            {
                textBox1.Text = panel.TextDesc;
                Clipboard.SetText(panel.TextDesc);
            }
        }
    }
}
