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
		public int SizeExchangeCard { get; set; }
		public int SizeExchangeCardFrame { get; set; }
		//public int MappositionX { get; set; }
		//public int MappositionY { get; set; }
		public int MapPointSize { get; set; }

		public Gamescreen screen { get; set; }


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
			
			exchangeCard = new Mappoint(files.bottomlefttop, true, true, true);
			//MappositionX = 0;
			//MappositionY = 0;

		}


		public Map(int Mapsize, int MapPointSize)
		{
			this.Mapsize = Mapsize;
			Board = new Mappoint[Mapsize, Mapsize];
			files = new FileManager();
			this.screen = screen;
			//this.MappositionX = MappositionX;
			//this.MappositionY = MappositionY;
			this.MapPointSize = MapPointSize;
			exchangeCard = new Mappoint(files.randomBitmap());
			this.SizeExchangeCard = Convert.ToInt32(MapPointSize - (MapPointSize * 0.25));
			//Ein Mappoint zum Verschieben wird beim ersten mal zufällig erstellt

		}

        /*
         * Die übergabeparameter sind einmal die Reihe beginnend bei 0
         * und dann die exchange card bzw ein beliebiger Mappoint dessen Position um 90Grad verändert werden soll 
         * Als erstes wird das "rausfallende" Element in einer help Variablen gespeichert.
         * nachdem verschieben der Reihe wird der neue Mappoint/exchangeCard am ende/bzw Anfang gespeichert
         * zum Schluss wird die neue exchangeCard gesetzt.
         */ 

		public void PushColumn(int Column, Mappoint newMapPoint)
		{
			Mappoint help = Board[Column, Mapsize - 1];
			for (int i = Mapsize - 1; i > 0; i--)
			{
				Board[Column, i] = Board[Column, i - 1];
			}			
			Board[Column, 0] = newMapPoint;
			this.exchangeCard = help;




		}
		public void PullColumn(int Column, Mappoint newMapPoint)					// Row beginnt bei 0!!!
		{
			Mappoint help = Board[Column, 0];
			for (int i = 0; i < Mapsize - 1; i++)
			{
				Board[Column, i] = Board[Column, i + 1];
			}
			Board[Column, Mapsize - 1] = newMapPoint;
			this.exchangeCard = help;
		}

		public void PushRow(int Row, Mappoint newMapPoint)				// Column beginnt bei 0!!!
		{
			Mappoint help = Board[Mapsize - 1, Row];

			for (int i = Mapsize - 1; i > 0; i--)
			{
				Board[i, Row] = Board[i - 1, Row];
			}
			Board[0, Row] = newMapPoint;
			this.exchangeCard = help;
		}


		public void PullRow(int Row, Mappoint newMapPoint)
		{
			Mappoint help = Board[0, Row];
			for (int i = 0; i < Mapsize - 1; i++)
			{
				Board[i, Row] = Board[i + 1, Row];
			}
			Board[Mapsize - 1, Row] = newMapPoint;
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
					if (j == 0 && i % 2 == 0)
					{
						if (i == 0)					// Ecke Links Oben
						{
							Board[i, j] = new Mappoint(files.rightbottom);
						}
						else if (i == Mapsize - 1)			//Ecke Rechts Oben 
						{
							Board[i, j] = new Mappoint(files.bottomleft);
						}
						else								//Seite Oben
						{
							Board[i, j] = new Mappoint(files.rightbottomleft);
						}
					}
					else if (i == 0 && j % 2 == 0)
					{
						if (j == Mapsize - 1)			//Ecke Unten Links
						{
							Board[i, j] = new Mappoint(files.topright);
						}
						else							//Seite Links
						{
							Board[i, j] = new Mappoint(files.toprightbottom);
						}
					}
					else if (j == Mapsize - 1 && i % 2 == 0)
					{
						if (i == Mapsize - 1)		// Ecke Unten Rechts			
						{
							Board[i, j] = new Mappoint(files.lefttop);
						}
						else						// Seite Unten
						{
							Board[i, j] = new Mappoint(files.lefttopright);
						}
					}
					else if (i == Mapsize -1 && j%2 == 0)		
					{
						if (Board[i, j] == null)		// Da die ecken breits gefüllt sind brauchen wir hier nur noch die Seite rechts
						{
							Board[i, j] = new Mappoint(files.bottomlefttop);
						}
					}
					else
					{
						Board[i, j] = new Mappoint(files.randomBitmap());
						
					}
					this.openPath(Board[i, j]);
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
					point.bottom = true;
				}
			}
		}

		/*
		 * Die Methode dient dazu dem Spieler die Möglichkeit zu geben ,
		 * die exchangeCard also die Karte die zum verschieben genutzt wird in die passende Position zu drehen.
         * wird im Doppelclick event der Form aufgerufen.
		 */ 
			public void switchPosition(Mappoint point)
			{
			if ((point.top == true && point.right == true) && (point.left == false && point.bottom == false))
			{
				point.top = false;
				point.bottom = true;
				point.looks = files.rightbottom;
			}
			else if ((point.right == true && point.bottom == true) && (point.left == false && point.top == false))
			{
				point.right = false;
				point.left = true;
				point.looks = files.bottomleft;
			}
			else if ((point.bottom == true && point.left == true) && (point.top == false && point.right == false))
			{
				point.bottom = false;
				point.top = true;
				point.looks = files.lefttop;
			}
			else if ((point.left == true && point.top == true) && (point.right == false && point.bottom == false))
			{
				point.left = false;
				point.right = true;
				point.looks = files.topright;
			}
			else if ((point.left == true && point.top == true && point.right == true) && (point.bottom == false))
			{
				point.left = false;
				point.bottom = true;
				point.looks = files.toprightbottom;
			}
			else if ((point.top == true && point.right == true && point.bottom == true) && (point.left == false))
			{
				point.top = false;
				point.left = true;
				point.looks = files.rightbottomleft;
			}
			else if ((point.right == true && point.bottom == true && point.left == true) && (point.top == false))
			{
				point.right = false;
				point.top = true;
				point.looks = files.bottomlefttop;
			}
			else if ((point.bottom == true && point.left == true && point.top == true) && (point.right == false))
			{
				point.bottom = false;
				point.right = true;
				point.looks = files.lefttopright;
				
			}
			else if ((point.left == true && point.right == true) && (point.top == false && point.bottom == false))
			{
				point.left= false;
				point.right = false;
				point.top = true;
				point.bottom = true;
				point.looks = files.topbottom;
			}
			else if ((point.top == true && point.bottom == true) && (point.left == false && point.right == false))
			{
				point.top = false;
				point.bottom = false;
				point.left = true;
				point.right = true;
				point.looks = files.leftright;
			}


		}


		public void addPropToMap(Map first)
		{				
			int indexListe = 0;
			Random ran = new Random();
			for (int i = 0; i < first.Mapsize; i++)
			{
				for (int j = 0; j < first.Mapsize; j++)
				{

					if (ran.Next(3) == 1 && indexListe < files.Proplist.Count)
					{
						Board[i, j].prop = files.Proplist[indexListe];
						indexListe += 1;
					}

				}
			}

		}

        //Methode liefert alle Mappoints zurück, die einen Pfad mit der übergebenden Position bilden
        public List<Point> getConnectedPaths(Point point)
        {
            List<Point> paths = new List<Point>();

            paths.Add(new Point(point.X, point.Y));

            for (int i = 0; i < paths.Count; i++)
            {
                if (paths[i].Y != 0 && Board[paths[i].X, paths[i].Y].top && Board[paths[i].X, paths[i].Y - 1].bottom && !checkAlreadyInList(new Point(paths[i].X, paths[i].Y - 1), paths) )
                {
                    paths.Add(new Point(paths[i].X, paths[i].Y - 1));
                }

                if (paths[i].Y != Mapsize - 1 && Board[paths[i].X, paths[i].Y].bottom && Board[paths[i].X, paths[i].Y + 1].top && !checkAlreadyInList(new Point(paths[i].X, paths[i].Y + 1), paths) )
                {
                    paths.Add(new Point(paths[i].X, paths[i].Y + 1));
                }

                if (paths[i].X != 0 && Board[paths[i].X, paths[i].Y].left && Board[paths[i].X - 1, paths[i].Y].right && !checkAlreadyInList(new Point(paths[i].X -1 , paths[i].Y ), paths) )
                {
                    paths.Add(new Point(paths[i].X - 1, paths[i].Y));
                }

                if (paths[i].X != Mapsize - 1 && Board[paths[i].X, paths[i].Y].right && Board[paths[i].X + 1, paths[i].Y].left && !checkAlreadyInList(new Point(paths[i].X + 1, paths[i].Y ), paths) )
                {
                    paths.Add(new Point(paths[i].X + 1, paths[i].Y));
                }
            }
            
            return paths;
        }

        //Methode überprüft ob ein Mappoint schon in der Liste vorhanden ist
        private bool checkAlreadyInList(Point point, List<Point> paths) 
        {
            bool found = false;

            for (int i = 0; i < paths.Count; i++)
            {
                if (paths[i] == point)
                    found = true;
            }

            if (!found)
                return false;

            else
                return true;
        }





	}
}
