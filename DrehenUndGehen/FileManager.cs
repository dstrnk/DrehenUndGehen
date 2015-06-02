using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.IO;

namespace DrehenUndGehen
{
    public class FileManager
    {
        /*
         * 
         * 
         * Hier werden Alle Bitmaps geladen
         * und falls nötig ein zufälliger ausgewählt
         */ 
        public Bitmap topright { get; set; }
        public Bitmap rightbottom { get; set; }
        public Bitmap bottomleft { get; set; }
        public Bitmap lefttop { get; set; }
        public Bitmap leftright { get; set; }
        public Bitmap topbottom { get; set; }
        public Bitmap lefttopright { get; set; }
        public Bitmap toprightbottom { get; set; }
        public Bitmap rightbottomleft { get; set; }
        public Bitmap bottomlefttop { get; set; }
        public Bitmap alltrue { get; set; }
        public Bitmap token { get; set; }
        public Bitmap arrowup { get; set; }
        public Bitmap arrowdown { get; set; }
        public Bitmap arrowright { get; set; }
        public Bitmap arrowleft { get; set; }
        private Random ran;

        public FileManager()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            topright = new Bitmap(path + "\\topright.png");
            rightbottom = new Bitmap(path + "\\rightbottom.png");
            bottomleft = new Bitmap(path + "\\leftbottom.png");
            lefttop = new Bitmap(path + "\\lefttop.png");
            leftright = new Bitmap(path + "\\leftright.png");
            topbottom = new Bitmap(path + "\\topbottom.png");
            lefttopright = new Bitmap(path + "\\lefttopright.png");
            toprightbottom = new Bitmap(path + "\\toprightbottom.png");
            rightbottomleft = new Bitmap(path + "\\rightbottomleft.png");
            bottomlefttop = new Bitmap(path + "\\bottomlefttop.png");
            alltrue = new Bitmap(path + "\\alltrue.png");
            token = new Bitmap(path + "\\token.png");
            arrowdown = new Bitmap(path + "\\arrowdown.png");
            arrowleft = new Bitmap(path + "\\arrowleft.png");
            arrowright = new Bitmap(path + "\\arrowright.png");
            arrowup = new Bitmap(path + "\\arrowup.png");

            ran = new Random((int)DateTime.Now.Ticks); //r
        }
        public Bitmap randomBitmap()
        {
            int i = ran.Next(1, 11);

            switch (i)
            {
                case 1:
                    return topright;
                case 2:
                    return rightbottom;
                case 3:
                    return bottomleft;
                case 4:
                    return lefttop;
                case 5:
                    return leftright;
                case 6:
                    return topbottom;
                case 7:
                    return lefttopright;
                case 8:
                    return toprightbottom;
                case 9:
                    return rightbottomleft;
                case 10:
                    return bottomlefttop;

                default:
                    return null;
            }

        }

    }
}
