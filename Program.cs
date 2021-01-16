
using System;
using System.Drawing;
using System.Windows.Forms;
using yakiniku;

static class MyMain {
    //< 60FPS�ŏ���
    private const int waitTimes = (int)(1000.0 / 600.0);

    [STAThread]
    static void Main() {
        yakinikuForm MainForm = new yakinikuForm();     //< �t�H�[������
        MainForm.Show();                    //< �t�H�[���̕\��
        
        int targetTimes = System.Environment.TickCount & int.MaxValue;
        targetTimes += waitTimes;

        while (MainForm.Created) {
            int tickCount = System.Environment.TickCount & int.MaxValue;
            if (targetTimes <= tickCount) {
                // ���C���̏���

                MainForm.Invalidate();

            }

            System.Threading.Thread.Sleep(1);       //< �X���[�v����
            Application.DoEvents();                 //< Window���b�Z�[�W����
        }
    }
}

