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
    public partial class WhoBegins : Form
    {
        int i;
        Bitmap[] coin;
        public WhoBegins()
        {
            InitializeComponent();
            coin = new Bitmap[12];
            coin[0] = new Bitmap(@"coin\IMG00000.bmp");
            coin[1] = new Bitmap(@"coin\IMG00001.bmp");
            coin[2] = new Bitmap(@"coin\IMG00002.bmp");
            coin[3] = new Bitmap(@"coin\IMG00003.bmp");
            coin[4] = new Bitmap(@"coin\IMG00004.bmp");
            coin[5] = new Bitmap(@"coin\IMG00005.bmp");
            coin[6] = new Bitmap(@"coin\IMG00006.bmp");
            coin[7] = new Bitmap(@"coin\IMG00007.bmp");
            coin[8] = new Bitmap(@"coin\IMG00008.bmp");
            coin[9] = new Bitmap(@"coin\IMG00009.bmp");
            coin[10] = new Bitmap(@"coin\IMG00010.bmp");
            coin[11] = new Bitmap(@"coin\IMG00011.bmp");
            i = 0;

        }

        private void WhoBegins_Load(object sender, EventArgs e)
        {
            int breite = Screen.PrimaryScreen.Bounds.Width;
            int höhe = Screen.PrimaryScreen.Bounds.Height;

            int x = breite - this.Width;
            int y = höhe - this.Height;

            this.Location = new Point(x / 2, y / 2);
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 12)
                i = 0;
            timer1.Interval = timer1.Interval - Convert.ToInt32(timer1.Interval / 10);
            if (timer1.Interval == 10)
            {
                timer1.Enabled = false;
                this.Visible = false;
                Countdown count = new Countdown();
                count.ShowDialog();

                GameLoading game = new GameLoading();
                game.Show();

                this.Close();
            }
            pictureBox1.Image = coin[i];
        }
    }
}
