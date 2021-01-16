using System.Windows.Forms;

namespace yakiniku {
    partial class yakinikuForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent() {

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 12);
            this.label1.Font = new System.Drawing.Font("Arial", 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "令和の焼肉りっかー";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 12);
            this.label2.Font = new System.Drawing.Font("Arial", 28);
            this.label2.TabIndex = 0;
            this.label2.Text = $"{yakinikuManager.YakinikuNumber}枚";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label2";
            this.label3.Size = new System.Drawing.Size(92, 12);
            this.label3.Font = new System.Drawing.Font("Arial", 18);
            this.label3.TabIndex = 0;
            this.label3.Text = $"クリックパワー:{yakinikuClick.ClickPower}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 170);
            this.label4.Name = "label2";
            this.label4.Size = new System.Drawing.Size(92, 12);
            this.label4.Font = new System.Drawing.Font("Arial", 18);
            this.label4.TabIndex = 0;
            this.label4.Text = $"YPS:{yakinikuManager.YPS}";
            // 
            // Form01
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form01";
            this.Text = "yakiniku";
            this.ResumeLayout(false);
            this.PerformLayout();

            Item Itemteppan = new Itemteppan();
            Item Itemdynamite = new Itemdynamite();
            
            this.Controls.Add(Itemteppan);
            this.Controls.Add(Itemdynamite);
            this.Controls.Add(yakinikuClick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);


            //this.DoubleBuffered = true;
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
            //this.SetStyle(ControlStyles.DoubleBuffer, true);
            //this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);


        }

        #endregion
    }
}