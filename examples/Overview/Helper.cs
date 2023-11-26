namespace Overview
{
    public static class Helper
    {
        public static Bitmap SvgToBmp(this string str)
        {
            var doc = Svg.SvgDocument.FromSvg<Svg.SvgDocument>(str);
            ((Svg.SvgColourServer)doc.Color).Colour = AntDesign.Config.Mode == AntDesign.TMode.Dark ? Color.White : Color.Black;
            if (AntDesign.Config.Dpi != 1F)
            {
                var dpi = AntDesign.Config.Dpi;
                doc.Width = doc.Width * dpi;
                doc.Height = doc.Height * dpi;
            }
            return doc.Draw();
        }
        public static Bitmap SvgToBmp(this string str, bool isdark)
        {
            var doc = Svg.SvgDocument.FromSvg<Svg.SvgDocument>(str);
            ((Svg.SvgColourServer)doc.Color).Colour = isdark ? Color.White : Color.Black;
            if (AntDesign.Config.Dpi != 1F)
            {
                var dpi = AntDesign.Config.Dpi;
                doc.Width = doc.Width * dpi;
                doc.Height = doc.Height * dpi;
            }
            return doc.Draw();
        }
    }
}