using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using yakiniku;


namespace yakiniku {
    class YakinikuClick : PictureBox{


        public int ClickCount = 0; //クリック回数
        public int ClickPower = 1; //１クリックで焼ける枚数
        public virtual string YakinikuPath { get; set; } = @"C:\Users\松本良太\source\repos\yakiniku\WindowsFormsApp1\img\yakiniku.png";
        public virtual int YakinikuPositionX { get; set; } = 64; //焼肉x座標
        public virtual int YakinikuPositionY { get; set; } = 196; //焼肉y座標
        public virtual int YakinikuSizeX { get; set; } = 256;//焼肉x方向の大きさ
        public virtual int YakinikuSizeY { get; set; } = 256; //焼肉y方向の大きさ

        public YakinikuClick() {
            this.ClientSize = new Size(YakinikuSizeX, YakinikuSizeY);
            this.Location = new Point(YakinikuPositionX, YakinikuPositionY);
            this.MouseClick += new MouseEventHandler(LeftClick);
            this.MouseDown += new MouseEventHandler(LeftClickDown);
            this.MouseUp += new MouseEventHandler(LeftClickUp);
            this.Paint += new PaintEventHandler(ImagePaint);
            this.Show();
        }

        private void LeftClick(object sender, MouseEventArgs e) {

            ClickCount++;
            if (ClickCount % 1 == 0) ClickPower = (int)(Math.Pow(ClickPower, 1.1)+1);
            Refresh();
        }

        private void ImagePaint(object senedr, PaintEventArgs e) {
            e.Graphics.DrawImage(Image.FromFile(YakinikuPath), YakinikuPositionX-64, YakinikuPositionY-192, YakinikuSizeX, YakinikuSizeY);
        }

        private void LeftClickDown(object sender, MouseEventArgs e) {
            if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left) {
                YakinikuPositionX = 80;
                YakinikuPositionY = 208;
                YakinikuSizeX = 224;
                YakinikuSizeY = 224;
                Refresh();
            }
        }

        private void LeftClickUp(object sender, MouseEventArgs e) {
            YakinikuPositionX = 64;
            YakinikuPositionY = 192;
            YakinikuSizeX = 256;
            YakinikuSizeY = 256;
            Refresh();
        }

    }
}
