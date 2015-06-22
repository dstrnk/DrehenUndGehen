using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DrehenUndGehen
{
    public partial class Countdown : Form
    {
        int i;
        Timer timer;
        public Countdown()
        {
            InitializeComponent();
            i = 0;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += timer_Tick;
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
                if(i == 0)
                {
                    pbCounter.Image = new Bitmap("4.bmp");

                }else if(i == 1)
                {
                    pbCounter.Image = new Bitmap("3.bmp");
                }
                else if (i == 2)
                {
                    pbCounter.Image = new Bitmap("2.bmp");
                }
                else if (i == 3)
                {
                    pbCounter.Image = new Bitmap("1.bmp");
                }
                else if (i == 4)
                {
                    this.Close();
                }
                i++;
                timer.Start();
            
        }





    }
}
