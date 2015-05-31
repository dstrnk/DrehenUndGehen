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
        
        Graphics g; 
        Map first;
        Renderer rend;
        private bool _moving;
        private Point _startLocation;

        public Form1()
        {
            InitializeComponent();
            first = new Map(9,550,150);
            first.fillMap(75);           
            WindowState = FormWindowState.Maximized;
            g = this.CreateGraphics();
            rend = new Renderer(first, g,pictureBox1);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            rend.drawMap(75,this);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //first.exchangeCard.switchPosition();
            //pictureBox1.BackgroundImage = first.exchangeCard.looks;
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _moving = true;
            _startLocation = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _moving = false;
           
                    
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_moving)
            {
                pictureBox1.Left += e.Location.X - _startLocation.X;
                pictureBox1.Top += e.Location.Y - _startLocation.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var rectangle in rend.listofMarks)
                if (rectangle.Contains(e.Location))
                {
                    MessageBox.Show("Hallo");
                }
                   
 
        }
        
      

  

    }

}
