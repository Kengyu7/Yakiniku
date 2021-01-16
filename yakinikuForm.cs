using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace yakiniku {
    public partial class yakinikuForm : Form {

        YakinikuManager yakinikuManager = new YakinikuManager();
        YakinikuClick yakinikuClick = new YakinikuClick();
        ItemStore itemstore = new ItemStore();
        itemstore.form = this;
        Item item = new Item();
        Item itemteppan = new Itemteppan();

        Font drawFontyakiniku = new Font("Arial", 24);
        Font drawFontYPS = new Font("Arial", 18);
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        

        public yakinikuForm() {
            InitializeComponent();
            yakinikuClick.MouseClick += new MouseEventHandler(LeftClick);
            yakinikuManager.UpdateNumber += new System.EventHandler(UpdateLabel);
            itemteppan.MouseClick += new MouseEventHandler(ItemClick);
        }

        private void LeftClick(object sender, MouseEventArgs e) {
            yakinikuManager.YakinikuIncrease(yakinikuClick.ClickPower);
            Refresh();
        }

        private void ItemClick(object sender,MouseEventArgs e) {

        }

        private void UpdateLabel(object sender,EventArgs eventArgs) {
            this.label2.Text = $"{yakinikuManager.YakinikuNumber}枚";
            label2.Refresh();
            this.label3.Text = $"クリックパワー:{yakinikuClick.ClickPower}";
            label3.Refresh();
        }


    }
}
