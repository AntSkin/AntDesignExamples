using System.ComponentModel;

namespace AntDesign
{
    [DefaultProperty("Text")]
    public class Header : IControl
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

        readonly static StringFormat stringFormatLeft = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Near, Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap };

        protected override void OnPaint(PaintEventArgs e)
        {
            var _rect = ClientRectangle;
            var g = e.Graphics.High();
            var rect = _rect.PaddingRect(Padding);
            using (var brush = new SolidBrush(ForeColor))
            {
                int he = rect.Height / 3;
                g.DrawString(desc, Font, brush, new Rectangle(rect.X + 6, rect.Y + rect.Height - he, rect.Width, he), stringFormatLeft);
                using (var font = new Font(Font.FontFamily, Font.Size * 2F, FontStyle.Bold))
                {
                    g.DrawString(text, font, brush, new Rectangle(rect.X, rect.Y, rect.Width, rect.Height - he), stringFormatLeft);
                }
            }
            this.PaintBadge(g, this);
            base.OnPaint(e);
        }
    }
}