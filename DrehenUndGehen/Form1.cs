using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrehenUndGehen
{
	public partial class Form1 : Form
	{
		Graphics g;
		Map first;
		Renderer rend;
		bool moving;
		Point p, s;

		public Form1()
		{
			InitializeComponent();
			first = new Map(9,75,550,150);
			first.fillMap();
			WindowState = FormWindowState.Maximized;			            //Fenster wird auto Maximiert
			this.DoubleBuffered = true;                                     //Reduziert flimmern hierdurch kann allerdings nur im on_paint event gezeichnet werden    
            this.AllowDrop = true;                                          //für Drag and Drop bin mir aber nicht sicher ob es Programmintern überhaupt gebraucht wird
			p = new Point(50, 50);                              
			s = new Point(50, 50);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		public void Form1_Paint(object sender, PaintEventArgs e)
		{			
			g = e.Graphics;
			rend = new Renderer(first, g);
			rend.drawMap(this);
			rend.drawExchangeCard(p.X, p.Y);			
		}

		private void Form1_Shown(object sender, EventArgs e)
		{


		}


		public void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left&&new RectangleF(p.X,p.Y,first.MapPointSize,first.MapPointSize).Contains(e.Location))         // Überprüfung ob sich die Maus auf der exchangeCard Befindet
			{
				p.X = e.X-first.MapPointSize/2;                                                                                         // Falls ja wird die Maus in die Mitte der exchangeCard gesetzt
				p.Y = e.Y - first.MapPointSize / 2;                                                                                     // und moving wird auf true gesetzt
				moving = true;
			}
			



		

			
		}

		public void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (moving)                                                                                                                // wenn die Maus sich bewegt während moving true(also der Maus nicht losgelassen wurde) ist.
			{
				p.X = e.X-first.MapPointSize/2;                                                                                       // Wird die exchange card immer an die Position der Maus gezeichnet
				p.Y = e.Y-first.MapPointSize/2;                                                                                         // Drag and Drop halt....
			}
			Refresh();
			
			
			
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{

            /*
             * Hier wird überprüft ob die exchangeCard auf der richtigen Position abgelegt wurde(Rote Pfeile)
             * falls ja wird die Reihe/Spalte entsprechend verschoben
             */ 
            if (moving)
            {
                for (int i = 0; i < first.Mapsize; i++)
                {
                    if (i % 2 != 0)
                    {
                        if (new RectangleF(first.MappositionX - first.MapPointSize, first.MappositionY + first.MapPointSize * i, first.MapPointSize, first.MapPointSize).Contains(e.Location))
                        {
                            first.PushRow(i, first.exchangeCard);
                            Refresh();
                        }
                        else if (new RectangleF(first.MappositionX + first.MapPointSize * i, first.MappositionY - first.MapPointSize, first.MapPointSize, first.MapPointSize).Contains(e.Location))
                        {
                            first.PushColumn(i, first.exchangeCard);
                            Refresh();
                        }
                        else if (new RectangleF(first.MappositionX + first.MapPointSize * first.Mapsize, first.MappositionY + first.MapPointSize * i, first.MapPointSize, first.MapPointSize).Contains(e.Location))
                        {
                            first.PullRow(i, first.exchangeCard);
                            Refresh();
                        }
                        else if (new RectangleF(first.MappositionX + first.MapPointSize * i, first.MappositionY + first.MapPointSize * first.Mapsize, first.MapPointSize, first.MapPointSize).Contains(e.Location))
                        {
                            first.PullColumn(i, first.exchangeCard);
                            Refresh();
                        }

                    }
                }
            }
            /*
             * Hier wird moving auf false gesetzt weil wir die Maus loslassen denke das ist vernünftig xD
             */ 
			if (e.Button == MouseButtons.Left)
			{
				moving = false;
				p.X = s.X;
				p.Y = s.Y;
			}


			Refresh();
		}


        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Mit Doppelklick die Position der exchange Card ändern
            if (new Rectangle(p.X, p.Y, first.MapPointSize, first.MapPointSize).Contains(e.Location))
            {
                first.exchangeCard.switchPosition();
            }
        }





	}
}


