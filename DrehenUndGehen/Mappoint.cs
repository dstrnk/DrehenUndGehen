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

   /*
    * Eine einzelne Kachel. 
    * Auf dem Form durch die Bitmaps dargestellt
    * die Eigenschaften top bottom right left geben in welche Richtung die Spielfigur später die Kachel verlassen kann
    * 
	* 
	*/
		public bool top { get; set; }
		public bool bottom { get; set; }
		public bool left { get; set; }
		public bool right { get; set; }
		public int size { get; set; }
		public Bitmap looks { get; set; }
		public Bitmap prop { get; set; }
	
		
	/*
	 * Standartkonstruktor wird momentan nie genutzt aber, 
	 * falls man die Klasse doch noch ableiten will oder ihn für andere Dinge nutzt ist er vorhanden
	 */
		
		public Mappoint ()
		{
			top=false;
			bottom = false;
			left = false;
			right = false;		
			looks = null;      
			
		}
		/*
		 * Der überladene Konstruktor die Werte looks und size müssen angegebn werden alle 
		 * anderen werden falls keine Angabe erfolgt automatisch false gesetzt
		 */ 
        public Mappoint(Bitmap looks, bool top = false, bool bottom = false, bool left = false, bool right = false)
		{
			this.top = top;
			this.bottom = bottom;
			this.left = left;
			this.right = right;			
			this.looks = looks;
			this.prop = null;
            
            

		}

		
		
	
	
	}
}
