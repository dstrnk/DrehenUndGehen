using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;


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
        
        


        public Renderer()
        {
            first   = new Map();          
        }
        public Renderer(Map map ,Graphics g)
        {
            this.first = map;           
            this.g = g;          
        }


        public void drawMap(Form1 form)
        {
			int x = first.MapPointSize;

            for (int i = 0; i < first.Mapsize; i++)
            {
                for (int j = 0; j < first.Mapsize; j++)
                {                  
                    if(i==0 && j%2 !=0)
                    {
                       
                        g.DrawImage(first.files.arrowdown, first.MappositionX + j * x, first.MappositionY + i * x- x, x, x);
                    }
                    if(j==0 && i%2 != 0)
                    {
                       
                        g.DrawImage(first.files.arrowright, first.MappositionX + j * x - x, first.MappositionY + i * x, x, x);
                    }
                    if (i == first.Mapsize-1 && j % 2 != 0)
                    {
                      
                        g.DrawImage(first.files.arrowup, first.MappositionX + j * x, first.MappositionY + i * x + x, x, x);
                    }
                    if( j == first.Mapsize-1 && i %2 !=0)
                    {
                      
                        g.DrawImage(first.files.arrowleft, first.MappositionX + j * x + x, first.MappositionY + i * x, x, x);
                    }

                    g.DrawImage(first.Board[i, j].looks,first.MappositionX+x*j,first.MappositionY+x*i,x,x);
					
                }
            }
           
            
        }
		public void drawExchangeCard(int x , int y)
		{
			g.DrawImage(first.exchangeCard.looks,x,y, first.MapPointSize, first.MapPointSize);
		}
	
    }
}
