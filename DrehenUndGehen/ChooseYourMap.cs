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
    public partial class ChooseYourMap : Form
    {
        ChooseYourChar charSelektion;

        public ChooseYourMap()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Startposition des Auswahlfensters für die gewünschte Map soll sich in der Mitte des Bildschirms öffnen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseYourMap_Load(object sender, EventArgs e)
        {
            
            int breite = Screen.PrimaryScreen.Bounds.Width;
            int höhe = Screen.PrimaryScreen.Bounds.Height;

            int x = breite - this.Width;
            int y = höhe - this.Height;

            this.Location = new Point(x / 2, y / 2);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            charSelektion = new ChooseYourChar();
            charSelektion.Visible = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            ChooseYourMap mapSelektion = new ChooseYourMap();
            mapSelektion.goBack();
            this.Close();
            
        }

        public void goBack()
        {
            charSelektion.Close();
            this.Visible = true;
        }
    }
}
