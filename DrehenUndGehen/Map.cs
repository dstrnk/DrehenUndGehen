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
		public int Mapsize { get; set; }
		public Mappoint[,] Board { get; set; }
        public FileManager files { get; set; }
        public Mappoint exchangeCard {get; set;}
        public int MappositionX { get; set;}
        public int MappositionY { get; set;}




		public Map()
		{
			Mapsize = 0;
			Board = new Mappoint[Mapsize,Mapsize];
			files = new FileManager();
            exchangeCard = new Mappoint(files.bottomlefttop,10,new RectangleF(0,0,0,0),true,true,true);
            MappositionX = 0;
            MappositionY = 0;

		}
		public Map(int Mapsize,int MappositionX,int MappositionY)
		{
			this.Mapsize = Mapsize;
			Board = new Mappoint[Mapsize, Mapsize];
			files = new FileManager();
            exchangeCard = new Mappoint(files.bottomlefttop, 10, new RectangleF(0, 0, 0, 0), true, true, true);
            this.MappositionX = MappositionX;
            this.MappositionY = MappositionY;
		}

		public void PushRow (int Row,Mappoint newMapPoint)
		{
			for (int i = Mapsize-1; i > 0; i--)
			{
				
				Board[Row, i] = Board[Row, i-1];
				
			}
			Board[Row, 0] = newMapPoint;


		}
		public void PullRow(int Row, Mappoint newMapPoint)					// Row beginnt bei 0!!!
		{
			for (int i = 0; i < Mapsize-1; i++)
			{			
				Board[Row, i] = Board[Row, i+1];
			}
			Board[Row, Mapsize - 1] = newMapPoint;
		}
		
		public void PushColumn(int Column,Mappoint newMapPoint)				// Column beginnt bei 0!!!
		{
 			for (int i = Mapsize-1; i>0 ; i--)
			{
				Board[i , Column] = Board[i-1 , Column];
			}
			Board[0, Column] = newMapPoint;
		}


		public void PullColumn(int Column, Mappoint newMapPoint)
		{
            for (int i = 0; i < Mapsize-1; i++)
            {
              Board[i, Column] = Board[i+1, Column];
            }
			Board[Mapsize - 1, Column] = newMapPoint;
 
		}

		public void fillMap(int sizeOfMappoints)
		{
            exchangeCard.size = sizeOfMappoints*2;
			for (int i = 0; i < Mapsize; i++)
			{
				for (int j = 0; j < Mapsize; j++)
				{
					Bitmap b = files.randomBitmap();					
					Board[i, j] = new Mappoint(b, sizeOfMappoints,new RectangleF(i*sizeOfMappoints+MappositionX,j*sizeOfMappoints+MappositionY,sizeOfMappoints,sizeOfMappoints));
                    
                    
                    if (Board[i, j].looks == files.bottomleft)                    //Je nachdem welches Bitmap zufällig ausgewählt wurde, werden die entsprechenden Wege auf true gesetzt.
                    {                                                             //Wichtig für die spätere Überprüfung welchen Weg die Spielfigur laufen kann.          
                        Board[i, j].bottom = true;                              
                        Board[i, j].left = true;
                    }
                    else if (Board[i, j].looks == files.bottomlefttop)
                    {
                        Board[i, j].bottom = true;
                        Board[i, j].left = true;
                        Board[i, j].top = true;                        
                    }
                    else if (Board[i, j].looks == files.leftright)
                    {
                        Board[i, j].right = true;
                        Board[i, j].left = true;
                    }
                    else if (Board[i, j].looks == files.lefttop)
                    {
                        Board[i, j].top = true;
                        Board[i, j].left = true;
                    }
                    else if (Board[i, j].looks == files.lefttopright)
                    {
                        Board[i, j].top = true;
                        Board[i, j].left = true;
                        Board[i, j].right = true;
                    }
                    else if (Board[i, j].looks == files.rightbottom)
                    {
                        Board[i, j].bottom = true;                       
                        Board[i, j].right = true;
                    }
                    else if (Board[i, j].looks == files.rightbottomleft)
                    {
                        Board[i, j].bottom = true;
                        Board[i, j].right = true;
                        Board[i, j].left = true;
                    }
                    else if (Board[i, j].looks == files.topbottom)
                    {
                        Board[i, j].bottom = true;
                        Board[i, j].top = true;                        
                    }
                    else if (Board[i, j].looks == files.topright)
                    {
                        Board[i, j].right = true;
                        Board[i, j].top = true;
                    }
                    else if (Board[i, j].looks == files.toprightbottom)
                    {
                        Board[i, j].right = true;
                        Board[i, j].top = true;
                        Board[i, j].right = true;
                    }
                  
 
				}
				
			}
          
		}





		


	}
}
