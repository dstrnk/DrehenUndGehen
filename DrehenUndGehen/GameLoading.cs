using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;

namespace DrehenUndGehen
{
	public partial class GameLoading : Form
	{
		Graphics g;
		Map first;
		Renderer rend;
		bool moving, push;
		Point p, s;
		int row = -1; 
		int column = -1;
		int pixeloffset = 0;
		Gamescreen screen;

		public GameLoading()
		{
			InitializeComponent();
			first = new Map(7,100);			
			first.fillMap();			
			first.addPropToMap(first);			
			WindowState = FormWindowState.Maximized;			            //Fenster wird auto Maximiert
			this.DoubleBuffered = true;                                     //Reduziert flimmern hierdurch kann allerdings nur im on_paint event gezeichnet werden    
            this.AllowDrop = true;                                          //für Drag and Drop bin mir aber nicht sicher ob es Programmintern überhaupt gebraucht wird
			p = new Point(50, 50);                              
			s = new Point(50, 50);
			screen = new Gamescreen(first);
			
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}

		public void Form1_Paint(object sender, PaintEventArgs e)
		{			
			g = e.Graphics;
			rend = new Renderer(first, g,screen);
			rend.drawBackground();
			if (moving == true)
			{
				rend.drawMarks(new Point(p.X + first.MapPointSize / 2, p.Y + first.MapPointSize / 2));
			}
			
			if (column == -1 && row == -1)
			{
				rend.drawMap();
				rend.drawExchangeCard(p.X, p.Y);
			}
			else
			{
				rend.drawMap(pixeloffset,push,row,column);
				rend.drawExchangeCard(pixeloffset,push,row,column);
			}			
			
			
			
		
			
		}

		private void Form1_Shown(object sender, EventArgs e)
		{


		}


		public void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left&&new RectangleF(p.X,p.Y,first.MapPointSize,first.MapPointSize).Contains(e.Location))         // Überprüfung ob sich die Maus auf der exchangeCard Befindet
			{
				p.X = e.X-first.MapPointSize/2;                                                                                         // Falls ja wird die Maus in die Mitte der exchangeCard gesetzt
				p.Y = e.Y- first.MapPointSize / 2;                                                                                     // und moving wird auf true gesetzt
				moving = true;
			}
					
		}

		public void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (moving)                                                                                                                // wenn die Maus sich bewegt während moving true(also der Maus nicht losgelassen wurde) ist.
			{
				p.X = e.X-first.SizeExchangeCard/2;                                                                                       // Wird die exchange card immer an die Position der Maus gezeichnet
				p.Y = e.Y-first.SizeExchangeCard/2;                                                                                         // Drag and Drop halt....
				Refresh();
			}
			
								
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{	/*
             * Hier wird überprüft ob die exchangeCard auf der richtigen Position abgelegt wurde(Rote Pfeile)
             * falls ja wird die Reihe/Spalte entsprechend verschoben
             */ 
            if (moving)
            {
                for (int i = 0; i < first.Mapsize; i++)
                {
                    if (i % 2 != 0)
                    {
						if (new RectangleF(screen.MapPosition.X - first.MapPointSize, screen.MapPosition.Y + first.MapPointSize * i, first.MapPointSize, first.MapPointSize).Contains(e.Location))
                        {
							push = true;
							row = i;
							timer1.Enabled = true;							
							timer1.Interval = 50;
							first.files.player.Play();
							//timer1.Start();
							//first.PushRow(i, first.exchangeCard);
						 					   
	 
                        }
						else if (new RectangleF(screen.MapPosition.X + first.MapPointSize * i, screen.MapPosition.Y - first.MapPointSize, first.MapPointSize, first.MapPointSize).Contains(e.Location))
                        {
							push = true;
							column = i;
							timer1.Enabled = true;
							timer1.Interval = 50;
							first.files.player.Play();

                            //first.PushColumn(i, first.exchangeCard);
                            //Refresh();
                        }
						else if (new RectangleF(screen.MapPosition.X + first.MapPointSize * first.Mapsize, screen.MapPosition.Y + first.MapPointSize * i, first.MapPointSize, first.MapPointSize).Contains(e.Location))
                        {
							push = false;
							row = i;
							timer1.Enabled = true;
							timer1.Interval = 50;
							first.files.player.Play();
                            //first.PullRow(i, first.exchangeCard);
                            //Refresh();
                        }
						else if (new RectangleF(screen.MapPosition.X + first.MapPointSize * i, screen.MapPosition.Y + first.MapPointSize * first.Mapsize, first.MapPointSize, first.MapPointSize).Contains(e.Location))
                        {
							push = false;
							column = i;
							timer1.Enabled = true;
							timer1.Interval = 50;
							first.files.player.Play();
                            //first.PullColumn(i, first.exchangeCard);
                            //Refresh();
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
                first.switchPosition(first.exchangeCard);
            }
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
			pixeloffset += 2;
			if (pixeloffset >= first.MapPointSize)
			{
				first.files.player.Stop();
				if (push && row!=-1)
				{
					first.PushRow(row, first.exchangeCard);
					row = -1;
					column = -1;
					timer1.Stop();
					pixeloffset = 0;
				}
				else if(push && row ==- 1)
				{
					first.PushColumn(column, first.exchangeCard);
					row = -1;
					column = -1;
					timer1.Stop();
					pixeloffset = 0;
				}
				else if (!push && row != -1)
				{
					first.PullRow(row, first.exchangeCard);
					row = -1;
					column = -1;
					timer1.Stop();
					pixeloffset = 0;
				}
				else if (!push && row ==-1)
				{
					first.PullColumn(column, first.exchangeCard);
					row = -1;
					column = -1;
					timer1.Stop();
					pixeloffset = 0;
				}
			}
			
			Refresh();
		}

     
        //Methode zum Testen einiger Funktionen
		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
			checkBox1.Checked = false;
			checkBox2.Checked = false;
			checkBox3.Checked = false;
			checkBox4.Checked = false;

			if (first.Board[Convert.ToInt32((e.X - screen.MapPosition.X) / first.MapPointSize), Convert.ToInt32((e.Y - screen.MapPosition.Y) / first.MapPointSize)].top == true)
			{
				checkBox1.Checked = true;
			}
			if (first.Board[Convert.ToInt32((e.X - screen.MapPosition.X) / first.MapPointSize), Convert.ToInt32((e.Y - screen.MapPosition.Y) / first.MapPointSize)].right == true)
			{
				checkBox3.Checked = true;
			}
			if (first.Board[Convert.ToInt32((e.X - screen.MapPosition.X) / first.MapPointSize), Convert.ToInt32((e.Y - screen.MapPosition.Y) / first.MapPointSize)].bottom == true)
			{
				checkBox4.Checked = true;
			}
			if (first.Board[Convert.ToInt32((e.X - screen.MapPosition.X) / first.MapPointSize), Convert.ToInt32((e.Y - screen.MapPosition.Y) / first.MapPointSize)].left == true)
			{
				checkBox2.Checked = true;
			}

            pictureBox1.Image = first.Board[Convert.ToInt32((e.X - screen.MapPosition.X) / first.MapPointSize), Convert.ToInt32((e.Y - screen.MapPosition.Y) / first.MapPointSize)].looks;


            listBox1.DataSource = first.findPath(new Point(0,0), new Point(Convert.ToInt32((e.X - screen.MapPosition.X) / first.MapPointSize), Convert.ToInt32((e.Y - screen.MapPosition.Y) / first.MapPointSize)));
			
		}

	




	}
}


