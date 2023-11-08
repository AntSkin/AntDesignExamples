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
            int i = 1;
            foreach (var color in colors)
            {
                var _panel = tablePanel.Controls.Find("panel" + i, false);
                if (_panel.Length > 0)
                {
                    if (_panel[0] is AntDesign.Panel panel)
                    {
                        var _label = panel.Controls.Find("label" + i, true)[0];
                        if (_label is Label label)
                        {
                            var mode = color.ColorMode();
                            panel.ForeColor = mode ? Color.Black : Color.White;
                            label.ForeColor = mode ? Color.FromArgb(30, 30, 30) : Color.FromArgb(245, 245, 245);
                            panel.Back = color;
                            label.Text = "#" + color.ToHex();
                        }
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
                    label_primary_color.Text = textBox1.Text = "#" + dialog.Color.ToHex();
                    CCC();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel_primary.Back = textBox1.Text.ToColor();
            label_primary_color.Text = "#" + panel_primary.Back.Value.ToHex();
            CCC();
        }
    }
}
