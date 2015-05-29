using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace DrehenUndGehen
{
    class Renderer
    {
        private Map first{get;set;}
        Graphics g;


        public Renderer()
        {
            first   = new Map();
           
        }
        public Renderer(Map map ,Graphics g)
        {
            first = map;
            this.g = g;
        }


        public void drawMap()
        {

            for (int i = 0; i < first.Mapsize; i++)
            {
                for (int j = 0; j < first.Mapsize; j++)
                {
                    g.DrawImage(first.Board[i, j].looks, j * 50, i * 50);
                }
            }
        }
    }
}
