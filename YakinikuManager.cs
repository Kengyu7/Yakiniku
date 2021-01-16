using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace yakiniku {
    class YakinikuManager {

        public int YakinikuNumber { get; set; } = 0; //焼肉の枚数
        public int YPS { get; set; } = 1; //1秒間あたりに焼ける焼肉

        public event EventHandler UpdateNumber;

        public YakinikuManager() {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new System.EventHandler(YakinikuAutoProduce);
            timer.Start();
        }

        public void YakinikuIncrease(int a) {
            YakinikuNumber += a;
        }

        public void YakinikuAutoProduce(object sender, EventArgs e) {
            YakinikuIncrease(YPS);
            UpdateNumber.Invoke(this,e);
        }

    }
}
