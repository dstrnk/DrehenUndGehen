using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DrehenUndGehen
{
	public class Map
    {
        /*
         * Die Map besteht hauptsächlich aus einem 2 Dimensionalen-Array von Mappoints
         * Die exchange card wird anfangs einmal zufällig generiert und danach wird die Karte zugeordnet die beim Schieben das Spielfeld "verlässt".
         * Mapposition ist die Position der Rechten oberen Ecke auf dem Steuerelement
         * Mappointsize gibt an wieviele pixel in x und y-Richtung eine Kachel/Mappoint hat.
         */
 
		public int Mapsize { get; set; }
		public Mappoint[,] Board { get; set; }
		public FileManager files { get; set; }
		public Mappoint exchangeCard { get; set; }
		public int MappositionX { get; set; }
		public int MappositionY { get; set; }
		public int MapPointSize { get; set; }


        /*
         * 
         * Wie bei Mappoints der Standartkonstruktor wird von mir noch nicht genutzt könnte aber
         * evtl für den Mapeditor Brauchbar sein.
         */ 
		public Map()
		{
			Mapsize = 0;
			Board = new Mappoint[Mapsize, Mapsize];
			files = new FileManager();
			exchangeCard = new Mappoint(files.bottomlefttop, 75, true, true, true);
			MappositionX = 0;
			MappositionY = 0;

		}


		public Map(int Mapsize, int MapPointSize, int MappositionX, int MappositionY)
		{
			this.Mapsize = Mapsize;
			Board = new Mappoint[Mapsize, Mapsize];
			files = new FileManager();
			this.MappositionX = MappositionX;
			this.MappositionY = MappositionY;
			this.MapPointSize = MapPointSize;
			exchangeCard = new Mappoint(files.randomBitmap(), MapPointSize);            //Ein Mappoint zum Verschieben wird beim ersten mal zufällig erstellt

		}

        /*
         * Die übergabeparameter sind einmal die Reihe beginnend bei 0
         * und dann die exchange card bzw ein beliebiger Mappoint dessen Position um 90Grad verändert werden soll 
         * Als erstes wird das "rausfallende" Element in einer help Variablen gespeichert.
         * nachdem verschieben der Reihe wird der neue Mappoint/exchangeCard am ende/bzw Anfang gespeichert
         * zum Schluss wird die neue exchangeCard gesetzt.
         */ 

		public void PushRow(int Row, Mappoint newMapPoint)
		{
			Mappoint help = Board[Row, Mapsize - 1];
			for (int i = Mapsize - 1; i > 0; i--)
			{
				Board[Row, i] = Board[Row, i - 1];
			}			
			Board[Row, 0] = newMapPoint;
			this.exchangeCard = help;




		}
		public void PullRow(int Row, Mappoint newMapPoint)					// Row beginnt bei 0!!!
		{
			Mappoint help = Board[Row, 0];
			for (int i = 0; i < Mapsize - 1; i++)
			{
				Board[Row, i] = Board[Row, i + 1];
			}
			Board[Row, Mapsize - 1] = newMapPoint;
			this.exchangeCard = help;
		}

		public void PushColumn(int Column, Mappoint newMapPoint)				// Column beginnt bei 0!!!
		{
			Mappoint help = Board[Mapsize - 1, Column];

			for (int i = Mapsize - 1; i > 0; i--)
			{
				Board[i, Column] = Board[i - 1, Column];
			}
			Board[0, Column] = newMapPoint;
			this.exchangeCard = help;
		}


		public void PullColumn(int Column, Mappoint newMapPoint)
		{
			Mappoint help = Board[0, Column];
			for (int i = 0; i < Mapsize - 1; i++)
			{
				Board[i, Column] = Board[i + 1, Column];
			}
			Board[Mapsize - 1, Column] = newMapPoint;
			this.exchangeCard = help;
		}

		public void fillMap()
		{
			int x = this.MapPointSize;
			this.openPath(this.exchangeCard);
			for (int i = 0; i < Mapsize; i++)
			{
				for (int j = 0; j < Mapsize; j++)
				{
					Bitmap b = files.randomBitmap();
					Board[j, i] = new Mappoint(files.randomBitmap(), x);
					this.openPath(Board[j, i]);
				}

			}

		}
        /*
         * Je nachdem welches Bitmap zufällig ausgewählt wurde, werden die entsprechenden Wege auf true gesetzt.
         * Wichtig für die spätere Überprüfung welchen Weg die Spielfigur laufen kann. 
         */

        public void openPath(Mappoint point)
		{
			if (point.looks != null)
			{
				if (point.looks == files.bottomleft)                   
				{                                                                     
					point.bottom = true;
					point.left = true;
				}
				else if (point.looks == files.bottomlefttop)
				{
					point.bottom = true;
					point.left = true;
					point.top = true;
				}
				else if (point.looks == files.leftright)
				{
					point.right = true;
					point.left = true;
				}
				else if (point.looks == files.lefttop)
				{
					point.top = true;
					point.left = true;
				}
				else if (point.looks == files.lefttopright)
				{
					point.top = true;
					point.left = true;
					point.right = true;
				}
				else if (point.looks == files.rightbottom)
				{
					point.bottom = true;
					point.right = true;
				}
				else if (point.looks == files.rightbottomleft)
				{
					point.bottom = true;
					point.right = true;
					point.left = true;
				}
				else if (point.looks == files.topbottom)
				{
					point.bottom = true;
					point.top = true;
				}
				else if (point.looks == files.topright)
				{
					point.right = true;
					point.top = true;
				}
				else if (point.looks == files.toprightbottom)
				{
					point.right = true;
					point.top = true;
					point.right = true;
				}
			}

		}








	}
}
