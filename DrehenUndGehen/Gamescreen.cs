using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DrehenUndGehen
{
	public class Gamescreen
	{
		public Map first;
		
		public int MaximizedScreenHight;
		public int MaximizedScreenWidth;
		
		public Point MapPosition;
		public Point ExchangeCardPosition;
		public Point ExchangeCardFramePosition;
		public Point UserMenu;
		public Point ButtonPosition;
		public Rectangle Background;
		

		public Gamescreen()
		{
			Size s = SystemInformation.PrimaryMonitorMaximizedWindowSize;
			MaximizedScreenHight = s.Height;
			MaximizedScreenWidth = s.Width;
						
		}
		public Gamescreen(Map first)
		{
			this.first = first;
			Size s = SystemInformation.PrimaryMonitorSize; ;
			
			MaximizedScreenHight = s.Height;
			MaximizedScreenWidth = s.Width;
			
			UserMenu = new Point(s.Width - s.Width / 4, 0);
			ExchangeCardFramePosition = new Point(UserMenu.X + s.Width - UserMenu.X / 2 - first.SizeExchangeCardFrame / 2, MapPosition.Y);
			ExchangeCardPosition = new Point(UserMenu.X + s.Width - UserMenu.X / 2 - first.SizeExchangeCard / 2, MapPosition.Y);
			Background = new Rectangle(0, 0, s.Width - (s.Width - UserMenu.X), s.Height);
			MapPosition = new Point(350, (s.Height - first.Mapsize * first.MapPointSize) / 2);
			






		}




	}
}
