using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;

namespace DrehenUndGehen
{
    class Renderer
    {

        /* 
         * Der Renderer wird für die Zeichnung benutzt
         * Wo wird welcher Mappoint gezeichnet und wo wird die exchangeCard plaziert.
         */ 
        public Map first{get;set;}
        Graphics g;
		public Gamescreen screen { get; set; }
      
        

        public Renderer()
        {
            first   = new Map();          
        }
        public Renderer(Map map ,Graphics g,Gamescreen screen)
        {
            this.first = map;           
            this.g = g;
			this.screen = screen;

			
        }


        public void drawMap()
        {
			
			int x = first.MapPointSize;

            for (int i = 0; i < first.Mapsize; i++)
            {
                for (int j = 0; j < first.Mapsize; j++)
                {                  
                    if(j==0 && i%2 !=0)
                    {                       
                        g.DrawImage(first.files.arrowbottom, screen.MapPosition.X + i * x, screen.MapPosition.Y + j * x- x, x, x);
						
                    }
                    else if(i==0 && j%2 != 0)
                    {
						g.DrawImage(first.files.arrowright, screen.MapPosition.X + i * x - x, screen.MapPosition.Y + j * x, x, x);
                    }
					else if (j == first.Mapsize-1 && i % 2 != 0)
                    {
						g.DrawImage(first.files.arrowtop, screen.MapPosition.X + i * x, screen.MapPosition.Y + j * x + x, x, x);
                    }
					else if (i == first.Mapsize - 1 && j % 2 != 0)
					{
						g.DrawImage(first.files.arrowleft, screen.MapPosition.X + i * x + x, screen.MapPosition.Y + j * x, x, x);
					}

					g.DrawImage(first.Board[i, j].looks, screen.MapPosition.X + x * i, screen.MapPosition.Y + x * j, x, x);
						if (first.Board[i, j].prop != null)
						{
							//first.Board[i, j].prop.MakeTransparent(Color.Black);
							g.DrawImage(first.Board[i, j].prop, screen.MapPosition.X + x * i + (first.MapPointSize / 4), screen.MapPosition.Y + x * j + (first.MapPointSize / 4), x / 2, x / 2);
						}
									
                }
            }
			//g.DrawImage(first.files.exchangCardFrame, 1200, first.MappositionY, first.MapPointSize * 4, first.MapPointSize * 4);
           
            
        }
		public void drawMap(int PixelOffset ,bool push, int row=-1,int column=-1)
		{
			
			if (push && row != -1)
			{
				int x = first.MapPointSize;

				for (int i = 0; i < first.Mapsize; i++)
				{
					for (int j = 0; j < first.Mapsize; j++)
					{

						if (j == 0 && i % 2 != 0)
						{
							g.DrawImage(first.files.arrowbottom, screen.MapPosition.X + i * x, screen.MapPosition.Y + j * x - x, x, x);
						}
						else if (i == 0 && j % 2 != 0)
						{
							g.DrawImage(first.files.arrowright, screen.MapPosition.X + i * x - x, screen.MapPosition.Y + j * x, x, x);
						}
						else if (j == first.Mapsize - 1 && i % 2 != 0)
						{
							g.DrawImage(first.files.arrowtop, screen.MapPosition.X + i * x, screen.MapPosition.Y + j * x + x, x, x);
						}
						else if (i == first.Mapsize - 1 && j % 2 != 0)
						{
							g.DrawImage(first.files.arrowleft, screen.MapPosition.X + i * x + x, screen.MapPosition.Y + j * x, x, x);
						}
						if (j != row)
						{
							g.DrawImage(first.Board[i, j].looks, screen.MapPosition.X + x * i, screen.MapPosition.Y + x * j, x, x);
							if (first.Board[i, j].prop != null)
							{
								//first.Board[i, j].prop.MakeTransparent(Color.Black);
								g.DrawImage(first.Board[i, j].prop, screen.MapPosition.X + x * i + (first.MapPointSize / 4), screen.MapPosition.Y + x * j + (first.MapPointSize / 4), x / 2, x / 2);
							}
						}
						if ( j == row)
						{
							g.DrawImage(first.Board[i, j].looks, screen.MapPosition.X + x * i + PixelOffset, screen.MapPosition.Y + x * j, x, x);
							if (first.Board[i, j].prop != null)
							{
								//first.Board[i, j].prop.MakeTransparent(Color.Black);
								g.DrawImage(first.Board[i, j].prop, screen.MapPosition.X + x * i + (first.MapPointSize / 4) + PixelOffset, screen.MapPosition.Y + x * j + (first.MapPointSize / 4), x / 2, x / 2);
							}
						}

					}
				}
			}
			if (push && row == -1)
			{
				int x = first.MapPointSize;

				for (int i = 0; i < first.Mapsize; i++)
				{
					for (int j = 0; j < first.Mapsize; j++)
					{

						if (j == 0 && i % 2 != 0)
						{
							g.DrawImage(first.files.arrowbottom, screen.MapPosition.X + i * x, screen.MapPosition.Y + j * x - x, x, x);
						}
						else if (i == 0 && j % 2 != 0)
						{
							g.DrawImage(first.files.arrowright, screen.MapPosition.X + i * x - x, screen.MapPosition.Y + j * x, x, x);
						}
						else if (j == first.Mapsize - 1 && i % 2 != 0)
						{
							g.DrawImage(first.files.arrowtop, screen.MapPosition.X + i * x, screen.MapPosition.Y + j * x + x, x, x);
						}
						else if (i == first.Mapsize - 1 && j % 2 != 0)
						{
							g.DrawImage(first.files.arrowleft, screen.MapPosition.X + i * x + x, screen.MapPosition.Y + j * x, x, x);
						}
						if (i != column)
						{
							g.DrawImage(first.Board[i, j].looks, screen.MapPosition.X + x * i, screen.MapPosition.Y + x * j, x, x);
							if (first.Board[i, j].prop != null)
							{
								//first.Board[i, j].prop.MakeTransparent(Color.Black);
								g.DrawImage(first.Board[i, j].prop, screen.MapPosition.X + x * i + (first.MapPointSize / 4), screen.MapPosition.Y + x * j + (first.MapPointSize / 4), x / 2, x / 2);
							}
						}
						if (i == column)
						{
							g.DrawImage(first.Board[i, j].looks, screen.MapPosition.X + x * i, screen.MapPosition.Y + x * j + PixelOffset, x, x);
							if (first.Board[i, j].prop != null)
							{
								//first.Board[i, j].prop.MakeTransparent(Color.Black);
								g.DrawImage(first.Board[i, j].prop, screen.MapPosition.X + x * i + (first.MapPointSize / 4), screen.MapPosition.Y + x * j + (first.MapPointSize / 4) + PixelOffset, x / 2, x / 2);
							}
						}

					}
				}
			}
			if (!push && column != -1)
			{
				int x = first.MapPointSize;

				for (int i = 0; i < first.Mapsize; i++)
				{
					for (int j = 0; j < first.Mapsize; j++)
					{

						if (j == 0 && i % 2 != 0)
						{
							g.DrawImage(first.files.arrowbottom, screen.MapPosition.X + i * x, screen.MapPosition.Y + j * x - x, x, x);
						}
						else if (i == 0 && j % 2 != 0)
						{
							g.DrawImage(first.files.arrowright, screen.MapPosition.X + i * x - x, screen.MapPosition.Y + j * x, x, x);
						}
						else if (j == first.Mapsize - 1 && i % 2 != 0)
						{
							g.DrawImage(first.files.arrowtop, screen.MapPosition.X + i * x, screen.MapPosition.Y + j * x + x, x, x);
						}
						else if (i == first.Mapsize - 1 && j % 2 != 0)
						{
							g.DrawImage(first.files.arrowleft, screen.MapPosition.X + i * x + x, screen.MapPosition.Y + j * x, x, x);
						}
						if (i != column)
						{
							g.DrawImage(first.Board[i, j].looks, screen.MapPosition.X + x * i, screen.MapPosition.Y + x * j, x, x);
							if (first.Board[i, j].prop != null)
							{
								//first.Board[i, j].prop.MakeTransparent(Color.Black);
								g.DrawImage(first.Board[i, j].prop, screen.MapPosition.X + x * i + (first.MapPointSize / 4), screen.MapPosition.Y + x * j + (first.MapPointSize / 4), x / 2, x / 2);
							}
						}
						if (i == column)
						{
							g.DrawImage(first.Board[i, j].looks, screen.MapPosition.X + x * i, screen.MapPosition.Y + x * j - PixelOffset, x, x);
							if (first.Board[i, j].prop != null)
							{
								//first.Board[i, j].prop.MakeTransparent(Color.Black);
								g.DrawImage(first.Board[i, j].prop, screen.MapPosition.X + x * i + (first.MapPointSize / 4), screen.MapPosition.Y + x * j + (first.MapPointSize / 4) - PixelOffset, x / 2, x / 2);
							}
						}

					}

				}

			}
			if (!push && column == -1)
			{
				int x = first.MapPointSize;

				for (int i = 0; i < first.Mapsize; i++)
				{
					for (int j = 0; j < first.Mapsize; j++)
					{

						if (j == 0 && i % 2 != 0)
						{
							g.DrawImage(first.files.arrowbottom, screen.MapPosition.X + i * x, screen.MapPosition.Y + j * x - x, x, x);
						}
						else if (i == 0 && j % 2 != 0)
						{
							g.DrawImage(first.files.arrowright, screen.MapPosition.X + i * x - x, screen.MapPosition.Y + j * x, x, x);
						}
						else if (j == first.Mapsize - 1 && i % 2 != 0)
						{
							g.DrawImage(first.files.arrowtop, screen.MapPosition.X + i * x, screen.MapPosition.Y + j * x + x, x, x);
						}
						else if (i == first.Mapsize - 1 && j % 2 != 0)
						{
							g.DrawImage(first.files.arrowleft, screen.MapPosition.X + i * x + x, screen.MapPosition.Y + j * x, x, x);
						}
						if (j != row)
						{
							g.DrawImage(first.Board[i, j].looks, screen.MapPosition.X + x * i, screen.MapPosition.Y + x * j, x, x);
							if (first.Board[i, j].prop != null)
							{
								//first.Board[i, j].prop.MakeTransparent(Color.Black);
								g.DrawImage(first.Board[i, j].prop, screen.MapPosition.X + x * i + (first.MapPointSize / 4), screen.MapPosition.Y + x * j + (first.MapPointSize / 4), x / 2, x / 2);
							}
						}
						if (j == row)
						{
							g.DrawImage(first.Board[i, j].looks, screen.MapPosition.X + x * i - PixelOffset, screen.MapPosition.Y + x * j, x, x);
							if (first.Board[i, j].prop != null)
							{
								//first.Board[i, j].prop.MakeTransparent(Color.Black);
								g.DrawImage(first.Board[i, j].prop, screen.MapPosition.X + x * i + (first.MapPointSize / 4) - PixelOffset, screen.MapPosition.Y + x * j + (first.MapPointSize / 4), x / 2, x / 2);
							}
						}

					}
				}
			}
		}
		public void drawExchangeCard(int x , int y)
		{
			
			g.DrawImage(first.exchangeCard.looks,x,y, first.SizeExchangeCard, first.SizeExchangeCard);
			if (first.exchangeCard.prop != null)
			{
				g.DrawImage(first.exchangeCard.prop, x + first.SizeExchangeCard / 4, y + first.SizeExchangeCard / 4, first.SizeExchangeCard / 2, first.SizeExchangeCard / 2);

			}
		}
		
		public void drawExchangeCard(int pixeloffset,bool push,int row = -1,int column = -1 )
		{
			if(push && row !=-1)
			{
				g.DrawImage(first.exchangeCard.looks, screen.MapPosition.X - first.MapPointSize + pixeloffset, screen.MapPosition.Y + first.MapPointSize * row, first.MapPointSize, first.MapPointSize);
				if (first.exchangeCard.prop != null)
				{
					g.DrawImage(first.exchangeCard.prop, screen.MapPosition.X - first.MapPointSize + pixeloffset + first.MapPointSize / 4, screen.MapPosition.Y + first.MapPointSize * row + first.MapPointSize / 4, first.MapPointSize / 2, first.MapPointSize / 2); 
				}
			}
			else if (push && row == -1)
			{
				g.DrawImage(first.exchangeCard.looks, screen.MapPosition.X + first.MapPointSize * column, screen.MapPosition.Y - first.MapPointSize + pixeloffset, first.MapPointSize, first.MapPointSize);
				if (first.exchangeCard.prop!= null)
				{
					g.DrawImage(first.exchangeCard.prop, screen.MapPosition.X + first.MapPointSize * column + first.MapPointSize / 4, screen.MapPosition.Y - first.MapPointSize + pixeloffset + first.MapPointSize / 4, first.MapPointSize / 2, first.MapPointSize / 2); 
				}
			}
			else if (!push && row != -1)
			{
				g.DrawImage(first.exchangeCard.looks, screen.MapPosition.X + first.MapPointSize * first.Mapsize - pixeloffset, screen.MapPosition.Y + first.MapPointSize * row, first.MapPointSize, first.MapPointSize);
				if (first.exchangeCard.prop != null)
				{
					g.DrawImage(first.exchangeCard.prop, screen.MapPosition.X + first.MapPointSize * first.Mapsize - pixeloffset + first.MapPointSize / 4, screen.MapPosition.Y + first.MapPointSize * row + first.MapPointSize / 4, first.MapPointSize / 2, first.MapPointSize / 2);
				}
			}
			else 
			{
				g.DrawImage(first.exchangeCard.looks, screen.MapPosition.X + first.MapPointSize * column, screen.MapPosition.Y + first.MapPointSize * first.Mapsize - pixeloffset, first.MapPointSize, first.MapPointSize);
				if (first.exchangeCard.prop != null)
				{
					g.DrawImage(first.exchangeCard.prop, screen.MapPosition.X + first.MapPointSize * column + first.MapPointSize / 4, screen.MapPosition.Y + first.MapPointSize * first.Mapsize - pixeloffset + first.MapPointSize / 4, first.MapPointSize / 2, first.MapPointSize / 2);
				}
			}
		}

		public void drawMarks(Point p)
		{
			SolidBrush brush = new SolidBrush(Color.PaleVioletRed);
			SolidBrush brush2 = new SolidBrush(Color.PaleGreen);
			int x = first.MapPointSize;
			
			Pen penRed = new Pen(brush,8);
			Pen penGreen = new Pen(brush2, 8);
			for (int i = 0; i < first.Mapsize; i++)
			{
				for (int j = 0; j < first.Mapsize; j++)
				{
					if (i == 0 && j % 2 != 0)
					{
						Rectangle rec = new Rectangle(screen.MapPosition.X + j * x, screen.MapPosition.Y + i * x - x, x, x);
						
						if (rec.Contains(p))
						{
							g.DrawRectangle(penGreen, screen.MapPosition.X + j * x, screen.MapPosition.Y + i * x - x, x, x);
						}
						else
						{
							g.DrawRectangle(penRed, screen.MapPosition.X + j * x, screen.MapPosition.Y + i * x - x, x, x);
						}
						
					}
					if (j == 0 && i % 2 != 0)
					{
						Rectangle rec = new Rectangle(screen.MapPosition.X + j * x - x, screen.MapPosition.Y + i * x, x, x);
						if (rec.Contains(p))
						{
							g.DrawRectangle(penGreen, screen.MapPosition.X + j * x - x, screen.MapPosition.Y + i * x, x, x);
						}
						else
						{
							g.DrawRectangle(penRed, screen.MapPosition.X + j * x - x, screen.MapPosition.Y + i * x, x, x);
						}

					}
					if (i == first.Mapsize - 1 && j % 2 != 0)
					{
						Rectangle rec = new Rectangle(screen.MapPosition.X + j * x, screen.MapPosition.Y + i * x + x, x, x);
						if (rec.Contains(p))
						{
							g.DrawRectangle(penGreen, screen.MapPosition.X + j * x, screen.MapPosition.Y + i * x + x, x, x);
						}
						else
						{
							g.DrawRectangle(penRed, screen.MapPosition.X + j * x, screen.MapPosition.Y + i * x + x, x, x);
						}

					}
					if (j == first.Mapsize - 1 && i % 2 != 0)
					{
						Rectangle rec = new Rectangle(screen.MapPosition.X + j * x + x, screen.MapPosition.Y + i * x, x, x);
						if (rec.Contains(p))
						{
							g.DrawRectangle(penGreen, screen.MapPosition.X + j * x + x, screen.MapPosition.Y + i * x, x, x);
						}
						else
						{
							g.DrawRectangle(penRed, screen.MapPosition.X + j * x + x, screen.MapPosition.Y + i * x, x, x);
						}
						
					}
				}
			}
		}	

	public void drawBackground()
	{
		g.DrawImage(first.files.background4, screen.Background);
	}

    }
}
