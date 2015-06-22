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
            int breite = Screen.PrimaryScreen.Bounds.Width;
            int höhe = Screen.PrimaryScreen.Bounds.Height;

            int x = breite - this.Width;
            int y = höhe - this.Height;

            this.Location = new Point(x / 2, y / 2);
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Countdown count = new Countdown();
            count.ShowDialog();

            GameLoading game = new GameLoading();
            game.Show();

            this.Close();
        }
    }
}
