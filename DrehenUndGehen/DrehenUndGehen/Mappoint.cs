using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DrehenUndGehen
{

	public class Mappoint
	{
		public bool top { get; set; }
		public bool bottom { get; set; }
		public bool left { get; set; }
		public bool right { get; set; }
		public Size size { get; set; }
		public Bitmap looks { get; set; }
		public FileManager files { get; set; }
		
		
		public Mappoint ()
		{
			top=false;
			bottom = false;
			left = false;
			right = false;
			size = new Size(10, 10);
			looks = null;
			files = null;
			
		}
		public Mappoint(Bitmap looks,Size size, bool top = false, bool bottom= false, bool left = false, bool right = false)
		{
			this.top = top;
			this.bottom = bottom;
			this.left = left;
			this.right = right;
			this.size = size;
			this.looks = looks;

		}
		public void switchPosition()
		{
			if ((top == true && right == true) && (left == false && bottom == false))
			{
				top = false;
				bottom = true;
				looks = files.rightbottom;
			}
			else if ((right == true && bottom == true) && (left == false && top == false))
			{
				right = false;
				left = true;
				looks = files.bottomleft;
			}
			else if((bottom == true && left == true) && (top == false && right == false))
			{
				bottom = false;
				top = true;
				looks = files.lefttop;
			}
			else if(( left == true && top == true)&&(right == false && bottom == false))
			{
				left = false;
				right = true;
				looks = files.topright;
			}
			else if ((left == true && top == true && right == true) && (bottom == false))
			{
				left = false;
				bottom = true;
				looks = files.toprightbottom;
			}
			else if ((top == true && right == true && bottom == true) && (left == false))
			{
				top = false;
				left = true;
				looks = files.rightbottomleft;
			}
			else if ((right == true && bottom == true && left == true)&&( top == false))
			{
				right = false;
				top = true;
				looks = files.bottomlefttop;
			}
			else if ((bottom == true && left == true && top == true) && (right == false))
			{
				bottom = false;
				right = true;
				looks = files.lefttopright;
				
			}
			else if((left == true && right== true)&&(top == false && bottom == false))
			{
				left= false;
				right = false;
				top = true;
				bottom = true;
				looks = files.topbottom;
			}
			else if((top == true && bottom == true)&& ( left == false && right == false))
			{
				top = false;
				bottom = false;
				left = true;
				right = true;
				looks = files.leftright;
			}

		}
		/*public void showlooks(Mappoint mappi,Graphics g)
		{
			g.DrawImage(mappi.looks,0,0);
		}*/
		
	}
}
