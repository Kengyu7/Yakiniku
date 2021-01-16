using System;
using System.Collections.Generic;
using System.Text;

namespace yakiniku {
    class Itemdynamite : Item{

        public Itemdynamite() {

        }

        override public string ItemName { get { return "dynamite"; } }
        override public int ItemPrice { get { return 100; } }
        override public double ItemYPS { get { return 1; } }
        override public int ItemNumber { get { return 0; } }
        override public string ItemPath { get { return @"C:\Users\松本良太\source\repos\yakiniku\WindowsFormsApp1\img\dynamite.png"; } }
        override public int ItemPositionX { get { return 700; } }
        override public int ItemPositionY { get { return 80; } }
        override public int ItemSizeX { get { return 64; } }
        override public int ItemSizeY { get { return 64; } }

    }
}
