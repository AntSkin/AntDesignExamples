// COPYRIGHT (C) Tom. ALL RIGHTS RESERVED.
// THE AntDesignExamples PROJECT IS AN WINFORM LIBRARY LICENSED UNDER THE Apache-2.0 License.
// LICENSED UNDER THE Apache License, VERSION 2.0 (THE "License")
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
    partial class Carousel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntDesign.CarouselItem carouselItem1 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem2 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem3 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem4 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem5 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem6 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem7 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem8 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem9 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem10 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem11 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem12 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem13 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem14 = new AntDesign.CarouselItem();
            AntDesign.CarouselItem carouselItem15 = new AntDesign.CarouselItem();
            header1 = new AntDesign.Header();
            flowLayoutPanel1 = new FlowLayoutPanel();
            carousel2 = new AntDesign.Carousel();
            carousel3 = new AntDesign.Carousel();
            panel2 = new System.Windows.Forms.Panel();
            carousel1 = new AntDesign.Carousel();
            slider1 = new AntDesign.Slider();
            image3d1 = new AntDesign.Image3D();
            image3d2 = new AntDesign.Image3D();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Padding = new Padding(6);
            header1.Size = new Size(1300, 79);
            header1.TabIndex = 4;
            header1.Text = "Carousel 走马灯";
            header1.TextDesc = "旋转木马，一组轮播的区域。";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(carousel2);
            flowLayoutPanel1.Controls.Add(carousel3);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(image3d1);
            flowLayoutPanel1.Controls.Add(image3d2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 79);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1300, 597);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // carousel2
            // 
            carousel2.DotPosition = AntDesign.TAlignMini.Left;
            carouselItem1.Img = Properties.Resources.img1;
            carouselItem2.Img = Properties.Resources.bg1;
            carouselItem3.Img = Properties.Resources.bg7;
            carouselItem4.Img = Properties.Resources.bg2;
            carousel2.Image.AddRange(new AntDesign.CarouselItem[] { carouselItem1, carouselItem2, carouselItem3, carouselItem4 });
            carousel2.Location = new Point(3, 3);
            carousel2.Name = "carousel2";
            carousel2.Radius = 8;
            carousel2.Size = new Size(393, 211);
            carousel2.TabIndex = 3;
            // 
            // carousel3
            // 
            carousel3.DotPosition = AntDesign.TAlignMini.Top;
            carouselItem5.Img = Properties.Resources.img1;
            carouselItem6.Img = Properties.Resources.bg1;
            carouselItem7.Img = Properties.Resources.bg7;
            carouselItem8.Img = Properties.Resources.bg2;
            carouselItem9.Img = Properties.Resources.bg3;
            carouselItem10.Img = Properties.Resources.bg4;
            carouselItem11.Img = Properties.Resources.bg5;
            carouselItem12.Img = Properties.Resources.bg6;
            carousel3.Image.AddRange(new AntDesign.CarouselItem[] { carouselItem5, carouselItem6, carouselItem7, carouselItem8, carouselItem9, carouselItem10, carouselItem11, carouselItem12 });
            carousel3.Location = new Point(402, 3);
            carousel3.Name = "carousel3";
            carousel3.Size = new Size(393, 211);
            carousel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(carousel1);
            panel2.Controls.Add(slider1);
            panel2.Location = new Point(801, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 275);
            panel2.TabIndex = 5;
            // 
            // carousel1
            // 
            carousel1.Autoplay = true;
            carousel1.BackColor = Color.Transparent;
            carousel1.Dock = DockStyle.Fill;
            carousel1.DotPosition = AntDesign.TAlignMini.Bottom;
            carouselItem13.Img = Properties.Resources.bg1;
            carouselItem14.Img = Properties.Resources.bg7;
            carouselItem15.Img = Properties.Resources.bg2;
            carousel1.Image.AddRange(new AntDesign.CarouselItem[] { carouselItem13, carouselItem14, carouselItem15 });
            carousel1.Location = new Point(0, 0);
            carousel1.Name = "carousel1";
            carousel1.Radius = 60;
            carousel1.SelectIndex = 2;
            carousel1.Size = new Size(225, 215);
            carousel1.TabIndex = 4;
            // 
            // slider1
            // 
            slider1.Dock = DockStyle.Bottom;
            slider1.Location = new Point(0, 215);
            slider1.Name = "slider1";
            slider1.Size = new Size(225, 60);
            slider1.TabIndex = 3;
            slider1.Text = "slider1";
            // 
            // image3d1
            // 
            image3d1.Image = Properties.Resources.bg7;
            image3d1.Location = new Point(3, 284);
            image3d1.Name = "image3d1";
            image3d1.Padding = new Padding(20);
            image3d1.Radius = 10;
            image3d1.Shadow = 20;
            image3d1.Size = new Size(300, 180);
            image3d1.TabIndex = 14;
            image3d1.Click += image3d1_Click;
            // 
            // image3d2
            // 
            image3d2.Duration = 200;
            image3d2.Image = Properties.Resources.bg1;
            image3d2.Location = new Point(309, 284);
            image3d2.Name = "image3d2";
            image3d2.Padding = new Padding(20);
            image3d2.Radius = 10;
            image3d2.Size = new Size(300, 180);
            image3d2.TabIndex = 13;
            image3d2.Vertical = true;
            image3d2.Click += image3d2_Click;
            // 
            // Carousel
            // 
            Controls.Add(flowLayoutPanel1);
            Controls.Add(header1);
            Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Carousel";
            Size = new Size(1300, 676);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntDesign.Header header1;
        private FlowLayoutPanel flowLayoutPanel1;
        private AntDesign.Carousel carousel2;
        private AntDesign.Carousel carousel1;
        private AntDesign.Slider slider1;
        private System.Windows.Forms.Panel panel2;
        private AntDesign.Carousel carousel3;
        private AntDesign.Image3D image3d2;
        private AntDesign.Image3D image3d1;
    }
}