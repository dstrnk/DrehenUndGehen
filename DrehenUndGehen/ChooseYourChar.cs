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
    public partial class ChooseYourChar : Form
    {
        Bitmap figuren;
        Bitmap marioandluigi;
        Bitmap monk;
        

        public ChooseYourChar()
        {
            InitializeComponent();

            figuren = new Bitmap("mario.bmp");
            marioandluigi = new Bitmap("luigi.bmp");
            monk = new Bitmap("peach.bmp");

            fillPictureBoxes();

             
        }

        private void ChooseYourChar_Load(object sender, EventArgs e)
        {

            int breite = Screen.PrimaryScreen.Bounds.Width;
            int höhe = Screen.PrimaryScreen.Bounds.Height;

            int x = breite - this.Width;
            int y = höhe - this.Height;

            this.Location = new Point(x / 2, y / 2);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            WhoBegins rollTheDice = new WhoBegins();
            rollTheDice.Visible = true;
            this.Visible = false;
        }

        public void fillPictureBoxes()
        {
           
            pbChar1.Image = figuren;
            pbChar2.Image = marioandluigi;
            pbChar3.Image = monk;
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Start_Screen start = new Start_Screen();
            start.goBack();
            this.Close();
        }

        //// Copies a part of a bitmap.
        //protected Bitmap CopyBitmap(Bitmap source, Rectangle part)
        //{
        //    Bitmap bmp = new Bitmap(80, 80);
        //    Graphics g = Graphics.FromImage(bmp);
        //    g.DrawImage(source, 0, 0, part, GraphicsUnit.Pixel);
        //    g.Dispose();
        //    bmp.MakeTransparent(Color.Green);
        //    return bmp;
        //}
    }
}
