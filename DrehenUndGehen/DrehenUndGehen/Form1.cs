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
    public partial class Form1 : Form
    {
        Graphics g, f;
        Map first;
        Renderer rend;
        Mappoint point;

        public Form1()
        {
            InitializeComponent();
            first = new Map(5);
            first.fillMap(100);
            this.Width = 5 * 50 + 500;
            this.Height = 5 * 50 + 500;
            g = this.CreateGraphics();
            rend = new Renderer(first, g);
            point = new Mappoint(first.files.lefttopright, new Size(500, 500),true,false,true,true);
           
            f = pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            rend.drawMap();
        }

        private void column1_Click(object sender, EventArgs e)
        {
            first.PullRow(3, new Mappoint(first.files.bottomleft, new Size(100, 100)));
            rend.drawMap();
        }

        private void column2_Click(object sender, EventArgs e)
        {
            
        }

        private void column3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Refresh();
           
            Rectangle rec = new Rectangle(0,0,pictureBox1.Width,pictureBox1.Height);
            f.DrawImageUnscaledAndClipped(point.looks,rec);
            point.switchPosition();
            f.DrawImageUnscaledAndClipped(point.looks, rec);
           
        }


    }

}
