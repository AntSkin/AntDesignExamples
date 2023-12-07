// COPYRIGHT (C) Tom. ALL RIGHTS RESERVED.
// THE AntDesignExamples PROJECT IS AN WINFORM LIBRARY LICENSED UNDER THE Apache-2.0 License.
// LICENSED UNDER THE Apache License, VERSION 2.0 (THE "License");
// YOU MAY NOT USE THIS FILE EXCEPT IN COMPLIANCE WITH THE License.
// YOU MAY OBTAIN A COPY OF THE LICENSE AT
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING, SOFTWARE
// DISTRIBUTED UNDER THE LICENSE IS DISTRIBUTED ON AN "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED.
// SEE THE LICENSE FOR THE SPECIFIC LANGUAGE GOVERNING PERMISSIONS AND
// LIMITATIONS UNDER THE License.
// GITHUB: https://github.com/AntSkin/AntDesignExamples
// CSDN: https://blog.csdn.net/v_132
// QQ: 17379620

namespace Overview.Controls
{
    public partial class DatePicker : UserControl
    {
        public DatePicker()
        {
            InitializeComponent();
            DateTime now = DateTime.Now.AddDays(new Random().Next(-5, 5));
            datePicker1.BadgeAction = dates =>
            {
                return new List<AntDesign.DateBadge> {
                    new AntDesign.DateBadge(now.ToString("yyyy-MM-dd"),0,Color.FromArgb(112, 237, 58)),
                    new AntDesign.DateBadge(now.AddDays(1).ToString("yyyy-MM-dd"),5),
                    new AntDesign.DateBadge(now.AddDays(-2).ToString("yyyy-MM-dd"),99),
                    new AntDesign.DateBadge(now.AddDays(-6).ToString("yyyy-MM-dd"),998),
                };
            };
            datePickerRange1.BadgeAction = dates =>
            {
                return new List<AntDesign.DateBadge> {
                    new AntDesign.DateBadge(now.ToString("yyyy-MM-dd"),0,Color.FromArgb(112, 237, 58)),
                    new AntDesign.DateBadge(now.AddDays(1).ToString("yyyy-MM-dd"),5),
                    new AntDesign.DateBadge(now.AddDays(-2).ToString("yyyy-MM-dd"),99),
                    new AntDesign.DateBadge(now.AddDays(-6).ToString("yyyy-MM-dd"),998),
                };
            };
        }
    }
}