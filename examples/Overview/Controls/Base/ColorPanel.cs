using System.ComponentModel;

namespace AntDesign
{
    [DefaultProperty("Text")]
    public class ColorPanel : IControl
    {
        #region 属性

        string? text = null;
        /// <summary>
        /// 文本
        /// </summary>
        [Description("文本"), Category("外观"), DefaultValue(null)]
        public new string? Text
        {
            get => text;
            set
            {
                if (text != value)
                {
                    text = value;
                    Invalidate();
                }
            }
        }

        string? desc = null;
        /// <summary>
        /// 描述
        /// </summary>
        [Description("描述"), Category("外观"), DefaultValue(null)]
        public string? TextDesc
        {
            get => desc;
            set
            {
                if (desc != value)
                {
                    desc = value;
                    Invalidate();
                }
            }
        }

        #endregion

        readonly static StringFormat stringFormatCenter = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center, Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap };

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics.High();
            var rect = ClientRectangle;
            using (var brush = new SolidBrush(ForeColor))
            {
                if (desc == null) g.DrawString(text, Font, brush, rect, stringFormatCenter);
                else
                {
                    var size = g.MeasureString(text, Font);
                    using (var font = new Font(Font.FontFamily, Font.Size * 0.7F))
                    {
                        var sizedesc = g.MeasureString(desc, font);
                        float y = (rect.Height - (size.Height + sizedesc.Height)) / 2;
                        g.DrawString(text, Font, brush, new RectangleF(rect.X, rect.Y + y, rect.Width, size.Height), stringFormatCenter);
                        using (var brush_desc = new SolidBrush(Color.FromArgb(200, ForeColor)))
                        {
                            g.DrawString(desc, font, brush_desc, new RectangleF(rect.X, rect.Y + y + size.Height * 1.3F, rect.Width, sizedesc.Height), stringFormatCenter);
                        }
                    }
                }
            }
            this.PaintBadge(g, this);
            base.OnPaint(e);
        }
    }
}