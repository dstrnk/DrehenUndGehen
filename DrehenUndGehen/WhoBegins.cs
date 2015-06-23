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
        public WhoBegins()
        {
            InitializeComponent();
        }

        private void WhoBegins_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap("background4.bmp");
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
    }
}
