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

namespace Overview
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntDesign.TabsBadge tabsBadge1 = new AntDesign.TabsBadge();
            AntDesign.TabsBadge tabsBadge2 = new AntDesign.TabsBadge();
            button1 = new AntDesign.Button();
            dropdown1 = new AntDesign.Dropdown();
            dropdown2 = new AntDesign.Dropdown();
            input1 = new AntDesign.Input();
            panel1 = new Panel();
            datePickerRange1 = new AntDesign.DatePickerRange();
            button210 = new AntDesign.Button();
            inputRange1 = new AntDesign.DatePickerRange();
            input7 = new AntDesign.Select();
            input6 = new AntDesign.Input();
            input4 = new AntDesign.Input();
            input2 = new AntDesign.Input();
            button218 = new AntDesign.Button();
            button29 = new AntDesign.Button();
            button26 = new AntDesign.Button();
            button217 = new AntDesign.Button();
            button22 = new AntDesign.Button();
            button220 = new AntDesign.Button();
            button25 = new AntDesign.Button();
            button216 = new AntDesign.Button();
            button219 = new AntDesign.Button();
            button24 = new AntDesign.Button();
            button215 = new AntDesign.Button();
            button3 = new AntDesign.Button();
            button21 = new AntDesign.Button();
            input5 = new AntDesign.Input();
            input3 = new AntDesign.Input();
            button2 = new AntDesign.Button();
            button23 = new AntDesign.Button();
            avatar2 = new AntDesign.Avatar();
            label8 = new Label();
            label9 = new Label();
            panel9 = new AntDesign.Panel();
            tabs1 = new AntDesign.Tabs();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            datePickerRange2 = new AntDesign.DatePicker();
            datePicker1 = new AntDesign.DatePicker();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            tabs1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.White;
            button1.Location = new Point(339, 75);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(140, 47);
            button1.TabIndex = 1;
            button1.Text = "加载";
            button1.Type = AntDesign.TTypeMini.Primary;
            button1.Click += button1_Click;
            // 
            // dropdown1
            // 
            dropdown1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dropdown1.Items.AddRange(new object[] { "哈哈", "哈哈", "君不见，黄河之水天上来，奔流到海不复回。", "君不见，高堂明镜悲白发，朝如青丝暮成雪。", "人生得意须尽欢，莫使金樽空对月。", "天生我材必有用，千金散尽还复来。", "烹羊宰牛且为乐，会须一饮三百杯。", "岑夫子，丹丘生，将进酒，杯莫停。", "与君歌一曲，请君为我倾耳听。", "钟鼓馔玉不足贵，但愿长醉不愿醒。", "古来圣贤皆寂寞，惟有饮者留其名。", "陈王昔时宴平乐，斗酒十千恣欢谑。", "主人何为言少钱，径须沽取对君酌。", "五花马，千金裘，呼儿将出换美酒，与尔同销万古愁。" });
            dropdown1.Location = new Point(339, 12);
            dropdown1.Name = "dropdown1";
            dropdown1.Placement = AntDesign.TAlignFrom.BR;
            dropdown1.ShowArrow = true;
            dropdown1.Size = new Size(214, 56);
            dropdown1.TabIndex = 16;
            dropdown1.Text = "dropdown1";
            dropdown1.Trigger = AntDesign.Trigger.Hover;
            dropdown1.Type = AntDesign.TTypeMini.Primary;
            // 
            // dropdown2
            // 
            dropdown2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dropdown2.Items.AddRange(new object[] { "君不见，黄河之水天上来，奔流到海不复回。", "君不见，高堂明镜悲白发，朝如青丝暮成雪。", "人生得意须尽欢，莫使金樽空对月。", "天生我材必有用，千金散尽还复来。", "烹羊宰牛且为乐，会须一饮三百杯。", "岑夫子，丹丘生，将进酒，杯莫停。", "与君歌一曲，请君为我倾耳听。", "钟鼓馔玉不足贵，但愿长醉不愿醒。", "古来圣贤皆寂寞，惟有饮者留其名。", "陈王昔时宴平乐，斗酒十千恣欢谑。", "主人何为言少钱，径须沽取对君酌。", "五花马，千金裘，呼儿将出换美酒，与尔同销万古愁。" });
            dropdown2.Location = new Point(354, 134);
            dropdown2.Name = "dropdown2";
            dropdown2.Placement = AntDesign.TAlignFrom.BR;
            dropdown2.ShowArrow = true;
            dropdown2.Size = new Size(69, 56);
            dropdown2.TabIndex = 16;
            dropdown2.Type = AntDesign.TTypeMini.Primary;
            // 
            // input1
            // 
            input1.Location = new Point(12, 12);
            input1.Name = "input1";
            input1.Size = new Size(152, 44);
            input1.TabIndex = 20;
            input1.Text = "input1";
            // 
            // panel1
            // 
            panel1.Controls.Add(datePickerRange1);
            panel1.Controls.Add(button210);
            panel1.Controls.Add(inputRange1);
            panel1.Controls.Add(input7);
            panel1.Controls.Add(input6);
            panel1.Controls.Add(input4);
            panel1.Controls.Add(input2);
            panel1.Controls.Add(button218);
            panel1.Controls.Add(button29);
            panel1.Controls.Add(button26);
            panel1.Controls.Add(button217);
            panel1.Controls.Add(button22);
            panel1.Controls.Add(button220);
            panel1.Controls.Add(button25);
            panel1.Controls.Add(button216);
            panel1.Controls.Add(button219);
            panel1.Controls.Add(button24);
            panel1.Controls.Add(button215);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button21);
            panel1.Controls.Add(input5);
            panel1.Controls.Add(input3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button23);
            panel1.Controls.Add(input1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 299);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 390);
            panel1.TabIndex = 21;
            // 
            // datePickerRange1
            // 
            datePickerRange1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datePickerRange1.Location = new Point(528, 319);
            datePickerRange1.Name = "datePickerRange1";
            datePickerRange1.Size = new Size(260, 40);
            datePickerRange1.TabIndex = 22;
            // 
            // button210
            // 
            button210.BorderWidth = 1F;
            button210.Location = new Point(354, 61);
            button210.Name = "button210";
            button210.ShowArrow = true;
            button210.Size = new Size(152, 44);
            button210.TabIndex = 19;
            button210.Text = "button21";
            button210.TextAlign = ContentAlignment.MiddleLeft;
            button210.Type = AntDesign.TTypeMini.Error;
            // 
            // inputRange1
            // 
            inputRange1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputRange1.Location = new Point(528, 269);
            inputRange1.Name = "inputRange1";
            inputRange1.PlaceholderEnd = "结束日期";
            inputRange1.PlaceholderStart = "开始日期";
            inputRange1.Presets.AddRange(new object[] { "今天", "昨天", "过去7天", "过去39天", "本周", "上周", "本月", "上月", "本季", "上季", "本年", "去年" });
            inputRange1.Size = new Size(260, 40);
            inputRange1.TabIndex = 22;
            // 
            // input7
            // 
            input7.Image = Properties.Resources.close;
            input7.Items.AddRange(new object[] { "321", "321321" });
            input7.List = true;
            input7.Location = new Point(354, 269);
            input7.Multiline = true;
            input7.Name = "input7";
            input7.PlaceholderText = "水印";
            input7.Size = new Size(152, 109);
            input7.TabIndex = 20;
            // 
            // input6
            // 
            input6.Image = Properties.Resources.close;
            input6.Location = new Point(186, 269);
            input6.Multiline = true;
            input6.Name = "input6";
            input6.PlaceholderText = "水印";
            input6.Size = new Size(152, 109);
            input6.TabIndex = 20;
            // 
            // input4
            // 
            input4.Image = Properties.Resources.close;
            input4.Location = new Point(186, 58);
            input4.Name = "input4";
            input4.PlaceholderText = "水印";
            input4.Size = new Size(152, 44);
            input4.TabIndex = 20;
            // 
            // input2
            // 
            input2.Image = Properties.Resources.close;
            input2.Location = new Point(186, 12);
            input2.Name = "input2";
            input2.Size = new Size(152, 44);
            input2.TabIndex = 20;
            input2.Text = "input1";
            // 
            // button218
            // 
            button218.BorderWidth = 1F;
            button218.Ghost = true;
            button218.Location = new Point(354, 208);
            button218.Name = "button218";
            button218.ShowArrow = true;
            button218.Size = new Size(152, 44);
            button218.TabIndex = 19;
            button218.Text = "button21";
            button218.TextAlign = ContentAlignment.MiddleLeft;
            button218.Type = AntDesign.TTypeMini.Primary;
            // 
            // button29
            // 
            button29.BorderWidth = 1F;
            button29.Image = Properties.Resources.search;
            button29.Location = new Point(528, 61);
            button29.Name = "button29";
            button29.ShowArrow = true;
            button29.Size = new Size(152, 44);
            button29.TabIndex = 19;
            button29.Text = "button21";
            button29.TextAlign = ContentAlignment.MiddleLeft;
            button29.Type = AntDesign.TTypeMini.Error;
            // 
            // button26
            // 
            button26.BorderWidth = 1F;
            button26.Location = new Point(354, 12);
            button26.Name = "button26";
            button26.ShowArrow = true;
            button26.Size = new Size(152, 44);
            button26.TabIndex = 19;
            button26.Text = "button21";
            button26.TextAlign = ContentAlignment.MiddleLeft;
            button26.Type = AntDesign.TTypeMini.Primary;
            // 
            // button217
            // 
            button217.BorderWidth = 1F;
            button217.Ghost = true;
            button217.Image = Properties.Resources.close;
            button217.Location = new Point(528, 208);
            button217.Name = "button217";
            button217.ShowArrow = true;
            button217.Size = new Size(152, 44);
            button217.TabIndex = 19;
            button217.Text = "button21";
            button217.TextAlign = ContentAlignment.MiddleLeft;
            button217.Type = AntDesign.TTypeMini.Primary;
            // 
            // button22
            // 
            button22.AutoSize = AntDesign.TAutoSize.Auto;
            button22.BorderWidth = 1F;
            button22.Location = new Point(12, 208);
            button22.Name = "button22";
            button22.ShowArrow = true;
            button22.Size = new Size(154, 54);
            button22.TabIndex = 19;
            button22.Text = "button21";
            button22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button220
            // 
            button220.Ghost = true;
            button220.IsLink = true;
            button220.Location = new Point(354, 158);
            button220.Name = "button220";
            button220.ShowArrow = true;
            button220.Size = new Size(152, 44);
            button220.TabIndex = 19;
            button220.Text = "button21";
            button220.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button25
            // 
            button25.BorderWidth = 1F;
            button25.Image = Properties.Resources.search;
            button25.Location = new Point(528, 12);
            button25.Name = "button25";
            button25.ShowArrow = true;
            button25.Size = new Size(152, 44);
            button25.TabIndex = 19;
            button25.Text = "button21";
            button25.TextAlign = ContentAlignment.MiddleLeft;
            button25.Type = AntDesign.TTypeMini.Primary;
            // 
            // button216
            // 
            button216.BorderWidth = 1F;
            button216.Ghost = true;
            button216.IsLink = true;
            button216.Location = new Point(354, 108);
            button216.Name = "button216";
            button216.ShowArrow = true;
            button216.Size = new Size(152, 44);
            button216.TabIndex = 19;
            button216.Text = "button21";
            button216.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button219
            // 
            button219.Ghost = true;
            button219.Image = Properties.Resources.close;
            button219.IsLink = true;
            button219.Location = new Point(528, 158);
            button219.Name = "button219";
            button219.ShowArrow = true;
            button219.Size = new Size(152, 44);
            button219.TabIndex = 19;
            button219.Text = "button21";
            button219.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button24
            // 
            button24.AutoSize = AntDesign.TAutoSize.Auto;
            button24.BorderWidth = 1F;
            button24.Image = Properties.Resources.close;
            button24.Location = new Point(186, 208);
            button24.Name = "button24";
            button24.ShowArrow = true;
            button24.Size = new Size(185, 54);
            button24.TabIndex = 19;
            button24.Text = "button21";
            button24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button215
            // 
            button215.BorderWidth = 1F;
            button215.Ghost = true;
            button215.Image = Properties.Resources.close;
            button215.IsLink = true;
            button215.Location = new Point(528, 108);
            button215.Name = "button215";
            button215.ShowArrow = true;
            button215.Size = new Size(152, 44);
            button215.TabIndex = 19;
            button215.Text = "button21";
            button215.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            button3.AutoSize = AntDesign.TAutoSize.Auto;
            button3.BorderWidth = 1F;
            button3.IsLink = true;
            button3.Location = new Point(12, 108);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(123, 54);
            button3.TabIndex = 19;
            button3.Text = "button21";
            // 
            // button21
            // 
            button21.AutoSize = AntDesign.TAutoSize.Auto;
            button21.BorderWidth = 1F;
            button21.IsLink = true;
            button21.Location = new Point(12, 158);
            button21.Name = "button21";
            button21.ShowArrow = true;
            button21.Size = new Size(154, 54);
            button21.TabIndex = 19;
            button21.Text = "button21";
            button21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // input5
            // 
            input5.Location = new Point(12, 269);
            input5.Multiline = true;
            input5.Name = "input5";
            input5.PlaceholderText = "水印";
            input5.Size = new Size(152, 109);
            input5.TabIndex = 20;
            // 
            // input3
            // 
            input3.Location = new Point(12, 58);
            input3.Name = "input3";
            input3.PlaceholderText = "水印";
            input3.Size = new Size(152, 44);
            input3.TabIndex = 20;
            // 
            // button2
            // 
            button2.AutoSize = AntDesign.TAutoSize.Auto;
            button2.BorderWidth = 1F;
            button2.IsLink = true;
            button2.Location = new Point(186, 108);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(123, 54);
            button2.TabIndex = 19;
            button2.Text = "button21";
            // 
            // button23
            // 
            button23.AutoSize = AntDesign.TAutoSize.Auto;
            button23.BorderWidth = 1F;
            button23.Image = Properties.Resources.close;
            button23.IsLink = true;
            button23.Location = new Point(186, 158);
            button23.Name = "button23";
            button23.ShowArrow = true;
            button23.Size = new Size(185, 54);
            button23.TabIndex = 19;
            button23.Text = "button21";
            button23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // avatar2
            // 
            avatar2.BackColor = Color.Transparent;
            avatar2.Dock = DockStyle.Top;
            avatar2.Image = Properties.Resources.img1;
            avatar2.Location = new Point(38, 38);
            avatar2.Name = "avatar2";
            avatar2.Radius = 6;
            avatar2.Size = new Size(244, 110);
            avatar2.TabIndex = 9;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(38, 148);
            label8.Name = "label8";
            label8.Size = new Size(244, 30);
            label8.TabIndex = 11;
            label8.Text = "Tour Title";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(38, 178);
            label9.Name = "label9";
            label9.Padding = new Padding(2, 0, 2, 0);
            label9.Size = new Size(244, 42);
            label9.TabIndex = 12;
            label9.Text = "Here is the content, here is the conten";
            // 
            // panel9
            // 
            panel9.ArrowAlign = AntDesign.TAlign.TL;
            panel9.ArrowSize = 10;
            panel9.Back = Color.FromArgb(0, 144, 255);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(label8);
            panel9.Controls.Add(avatar2);
            panel9.ForeColor = Color.White;
            panel9.Location = new Point(4, 2);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(38);
            panel9.PaddingWidth = -12;
            panel9.Radius = 10;
            panel9.Shadow = 24;
            panel9.ShadowOpacity = 0.18F;
            panel9.Size = new Size(320, 258);
            panel9.TabIndex = 15;
            // 
            // tabs1
            // 
            tabsBadge1.Count = 0;
            tabsBadge1.Fill = null;
            tabsBadge1.Index = 0;
            tabsBadge2.Count = 2;
            tabsBadge2.Fill = null;
            tabsBadge2.Index = 1;
            tabs1.Badge.AddRange(new AntDesign.TabsBadge[] { tabsBadge1, tabsBadge2 });
            tabs1.Controls.Add(tabPage1);
            tabs1.Controls.Add(tabPage2);
            tabs1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabs1.ItemSize = new Size(140, 40);
            tabs1.Location = new Point(609, 12);
            tabs1.Name = "tabs1";
            tabs1.SelectedIndex = 0;
            tabs1.Size = new Size(314, 141);
            tabs1.SizeMode = TabSizeMode.Fixed;
            tabs1.TabIndex = 22;
            tabs1.Type = AntDesign.TabType.Card;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(306, 93);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(306, 93);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // datePickerRange2
            // 
            datePickerRange2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datePickerRange2.Format = "yyyy-MM-dd HH:mm:ss";
            datePickerRange2.Location = new Point(478, 180);
            datePickerRange2.Name = "datePickerRange2";
            datePickerRange2.Size = new Size(260, 40);
            datePickerRange2.TabIndex = 22;
            // 
            // datePicker1
            // 
            datePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datePicker1.Format = "yyyy-MM-dd HH:mm:ss";
            datePicker1.Location = new Point(478, 235);
            datePicker1.Name = "datePicker1";
            datePicker1.Presets.AddRange(new object[] { "今天", "昨天", "过去7天", "过去39天", "本周", "上周", "本月", "上月", "本季", "上季", "本年", "去年", "去年1", "去年2" });
            datePicker1.Size = new Size(260, 40);
            datePicker1.TabIndex = 22;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 689);
            Controls.Add(tabs1);
            Controls.Add(panel1);
            Controls.Add(datePicker1);
            Controls.Add(datePickerRange2);
            Controls.Add(dropdown2);
            Controls.Add(dropdown1);
            Controls.Add(panel9);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            tabs1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntDesign.Button button1;
        private AntDesign.Dropdown dropdown1;
        private AntDesign.Dropdown dropdown2;
        private AntDesign.Input input1;
        private Panel panel1;
        private AntDesign.Input input2;
        private AntDesign.Button button23;
        private AntDesign.Button button24;
        private AntDesign.Button button26;
        private AntDesign.Button button22;
        private AntDesign.Button button25;
        private AntDesign.Button button21;
        private AntDesign.Button button210;
        private AntDesign.Button button29;
        private AntDesign.Button button218;
        private AntDesign.Button button217;
        private AntDesign.Button button216;
        private AntDesign.Button button215;
        private AntDesign.Button button220;
        private AntDesign.Button button219;
        private AntDesign.Input input4;
        private AntDesign.Input input3;
        private AntDesign.Button button3;
        private AntDesign.Button button2;
        private AntDesign.Input input6;
        private AntDesign.Input input5;
        private AntDesign.Select input7;
        private AntDesign.Avatar avatar2;
        private Label label8;
        private Label label9;
        private AntDesign.Panel panel9;
        private AntDesign.DatePickerRange inputRange1;
        private AntDesign.DatePickerRange datePickerRange1;
        private AntDesign.Tabs tabs1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private AntDesign.DatePicker datePickerRange2;
        private AntDesign.DatePicker datePicker1;
    }
}