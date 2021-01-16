
using System;
using System.Drawing;
using System.Windows.Forms;
using yakiniku;

static class MyMain {
    //< 60FPSで処理
    private const int waitTimes = (int)(1000.0 / 600.0);

    [STAThread]
    static void Main() {
        yakinikuForm MainForm = new yakinikuForm();     //< フォーム生成
        MainForm.Show();                    //< フォームの表示
        
        int targetTimes = System.Environment.TickCount & int.MaxValue;
        targetTimes += waitTimes;

        while (MainForm.Created) {
            int tickCount = System.Environment.TickCount & int.MaxValue;
            if (targetTimes <= tickCount) {
                // メインの処理

                MainForm.Invalidate();

            }

            System.Threading.Thread.Sleep(1);       //< スリープ処理
            Application.DoEvents();                 //< Windowメッセージ処理
        }
    }
}

