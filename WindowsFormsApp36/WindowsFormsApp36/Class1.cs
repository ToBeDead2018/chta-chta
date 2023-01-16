using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp36
{
    class METODS

    {
        public static int R = 0;
        public static int G = 0;
        public static int B = 0;
        public static int D = 0;

        public static void Zveta(Form1 lol)// смена цвета
        {
            lol.BackColor = System.Drawing.Color.FromArgb(R,G,B);
        }

        public static void ICON(Form1 lol)//смена иконки
        {
            switch (D)
            {
                case 1:
                    lol.Icon = WindowsFormsApp36.Properties.Resources.lakitu;
                    break;
                case 2:
                    lol.Icon = WindowsFormsApp36.Properties.Resources.peachprincess;
                    break;
                case 3:
                    lol.Icon = WindowsFormsApp36.Properties.Resources.toad;
                    break;
            }
            
        }

        public static void TEXT(Form1 lol)//смена названия
        {
            switch (D)
            {
                case 1:
                    lol.Text = "азазазаз";
                    break;
                case 2:
                    lol.Text = "пон";
                    break;
                case 3:
                    lol.Text = "кони";
                    break;
            }

        }
    }
    
}
