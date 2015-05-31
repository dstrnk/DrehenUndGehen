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
        private Map first{get;set;}
        Graphics g;
        PictureBox s;


        public Renderer()
        {
            first   = new Map();
           
        }
        public Renderer(Map map ,Graphics g,PictureBox s)
        {
            first = map;
            
            this.g = g;
            this.s = s;
        }


        public void drawMap(int sizeOfMapPoints,Form1 form)
        {
            
            
            for (int i = 0; i < first.Mapsize; i++)
            {
                for (int j = 0; j < first.Mapsize; j++)
                {
                    int x = first.Board[i, j].size;
                    
                    if(i==0 && j%2 !=0)
                    {
                        /*
                         * ####Wird eventuell für Drag&Drop benötigt#####
                         * 
                         * PictureBox pic = new PictureBox();
                        
                        pic.Location = new Point(550 + j * x, 150 + i * x-sizeOfMapPoints);
                        pic.Size = new Size(sizeOfMapPoints, sizeOfMapPoints);
                        pic.BackgroundImageLayout = ImageLayout.Stretch;
                        pic.BackgroundImage = first.files.arrowdown;                        
                        pic.Visible = true;
                        
                        form.Controls.Add(pic);   */
                        
                        g.DrawImage(first.files.arrowdown, 550 + j * x, 150 + i * x - sizeOfMapPoints, x, x);
                    }
                    if(j==0 && i%2!=0)
                    {
                        g.DrawImage(first.files.arrowright, 550 + j * x - sizeOfMapPoints, 150 + i * x, x, x);
                    }
                    if (i == first.Mapsize-1 && j % 2 != 0)
                    {
                        g.DrawImage(first.files.arrowup, 550 + j * x, 150 + i * x + sizeOfMapPoints, x, x);
                    }
                    if( j == first.Mapsize-1 && i %2 !=0)
                    {
                        g.DrawImage(first.files.arrowleft, 550 + j * x + sizeOfMapPoints, 150 + i * x, x, x);
                    }
                        g.DrawImage(first.Board[i, j].looks, 550 + j * x, 150 + i * x, x, x);
                }
            }
            s.BackgroundImageLayout = ImageLayout.Stretch;
            s.BackgroundImage = first.exchangeCard.looks;
            
        }
    }
}
