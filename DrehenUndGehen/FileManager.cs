using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Media;

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
		public Bitmap arrowbottom { get; set; }
		public Bitmap arrowtop { get; set; }
		public Bitmap arrowright { get; set; }
		public Bitmap arrowleft { get; set; }
		public Bitmap exchangCardFrame { get; set; }
		
		public Bitmap background1 { get; set; }
		public Bitmap background2 { get; set; }
		public Bitmap background3 { get; set; }
		public Bitmap background4 { get; set; }
		public Bitmap background5 { get; set; }

		public SoundPlayer player { get; set; }
		public Bitmap Brunnen{get;set;}
		public Bitmap Drache { get; set; }
		public Bitmap Spiegel { get; set; }
		public Bitmap Feuer { get; set; }
		public Bitmap Ritter { get; set; }
		public Bitmap Waage { get; set; }
		public Bitmap Bär { get; set; }
		public Bitmap Edelsteine { get; set; }
        private Random ran;
		public List<Bitmap> Proplist { get; set; }

        public FileManager()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

			player = new SoundPlayer(path + @"\stonegrind.wav");
			background1 = new Bitmap(path + @"\Background1.bmp");
			background2 = new Bitmap(path + @"\background2.bmp");
			background3 = new Bitmap(path + @"\background3.bmp");
			background4 = new Bitmap(path + @"\background4.bmp");
			background5 = new Bitmap(path + @"\background5.bmp");
		
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
			arrowleft = new Bitmap(path + "\\arrowleft.png");
			arrowright = new Bitmap(path + "\\arrowright.png");
			arrowtop = new Bitmap(path + "\\arrowtop.png");
			arrowbottom = new Bitmap(path + "\\arrowbottom.png");
           
			token = new Bitmap(path + "\\token.png");
			exchangCardFrame = new Bitmap(path + "\\exchangecardframe.png");

			Brunnen = new Bitmap(path +"\\brunnen.png");
			Drache = new Bitmap(path + "\\Drache.png");
			Spiegel = new Bitmap(path + "\\Spiegel.png");
			Feuer = new Bitmap(path + "\\Feuer.png");
			Ritter = new Bitmap(path + "\\Ritter.png");
			Waage = new Bitmap(path + "\\Waage.png");
			Bär = new Bitmap(path + "\\Bär.png");
			Edelsteine= new Bitmap(path + "\\Edelsteine.png");
			
			Proplist = new List<Bitmap>();
            ran = new Random((int)DateTime.Now.Ticks); //r
			this.fillProplist();
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
		public void fillProplist()
		{
			Proplist.Add(Brunnen);
			Proplist.Add(Drache);
			Proplist.Add(Spiegel);
			Proplist.Add(Feuer);
			Proplist.Add(Waage);
			Proplist.Add(Edelsteine);
			Proplist.Add(Ritter);
			Proplist.Add(Bär);
		}

    }
}
