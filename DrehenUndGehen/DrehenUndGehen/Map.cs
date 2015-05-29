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
		public FileManager files;




		public Map()
		{
			Mapsize = 0;
			Board = new Mappoint[Mapsize,Mapsize];
			files = new FileManager();

		}
		public Map(int Mapsize)
		{
			this.Mapsize = Mapsize;
			Board = new Mappoint[Mapsize, Mapsize];
			files = new FileManager();
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
			for (int i = 0; i < Mapsize; i++)
			{
				for (int j = 0; j < Mapsize; j++)
				{
					Bitmap b = files.randomBitmap();
					
					Board[i, j] = new Mappoint(b, new Size(sizeOfMappoints, sizeOfMappoints));

					
					
				}
				
			}
          
		}





		


	}
}
