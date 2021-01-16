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
    class Item : PictureBox{

        
        public virtual string ItemName { get; set; } //アイテムの名前
        public virtual int ItemPrice { get; set; } //アイテムの値段
        public virtual double ItemYPS { get; set; } //アイテムが1秒間に焼く枚数
        public virtual int ItemNumber { get; set; } //アイテムを何個もっているか
        public virtual string ItemPath { get; set; }  //画像のパス
        public virtual int ItemPositionX { get; set; } //アイテムx座標
        public virtual int ItemPositionY { get; set; } //アイテムy座標
        public virtual int ItemSizeX { get; set; } //アイテムx方向の大きさ
        public virtual int ItemSizeY { get; set; } //アイテムy方向の大きさ

        public Item() {
            this.ClientSize = new Size(ItemSizeX, ItemSizeY);
            this.Location = new Point(ItemPositionX, ItemPositionY);
            this.MouseClick += new MouseEventHandler(mouseClick);
            this.Paint += new PaintEventHandler(imagePaint);
            this.Show();
        }

        private void mouseClick(object sender, MouseEventArgs e) {
         //   if(yakinikuManager.yakinikuNumber >= ItemPrice) {
         //       yakinikuForm.yakinikuNumber -= ItemPrice;
         //       yakinikuForm.YPS += ItemYPS;

          //  }
        }

        public void ItemGet() {
            
        }

        private void imagePaint(object senedr, PaintEventArgs e) {
            e.Graphics.DrawImage(Image.FromFile(ItemPath), 0, 0, ItemSizeX, ItemSizeY);
        }

    }
}
