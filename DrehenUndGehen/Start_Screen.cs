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
    public partial class Start_Screen : Form
    {
        ChooseYourMap mapSelection;

        public Start_Screen()
        {
            InitializeComponent();
            Bitmap background = new Bitmap("background4.bmp");
            this.BackgroundImage = background;
            mapSelection = new ChooseYourMap();

        }

        /// <summary>
        /// Methode um das Spiel ganz zu Beginn noch abzubrechen / zu beenden 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Öffnet die Windows Form zur Mapauswahl und schließt den "StartUp-Screen"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStarten_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mapSelection.Visible = true;
            
        }

        /// <summary>
        /// Startposition des Auswahlfensters um ins Spiel einzusteigen wird auf die Mitte des Bildschirms festgelegt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Screen_Load(object sender, EventArgs e)
        {
            int breite = Screen.PrimaryScreen.Bounds.Width;
            int höhe = Screen.PrimaryScreen.Bounds.Height;

            int x = breite - this.Width;
            int y = höhe - this.Height;

            this.Location = new Point(x / 2, y / 2);
        }

        /// <summary>
        /// Die Form des Startbildschirms wird wieder sichtbar gemacht, wenn bei nachfolgender Form auf zurück geklickt wird
        /// </summary>
        public void goBack()                                                
        {
 
            this.Visible = true;
        }
    }
}
