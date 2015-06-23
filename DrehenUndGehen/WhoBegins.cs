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
        Random random;
        int number1, number2;

        Boolean playerOne = false;
        Boolean playerTwo = false;

        public WhoBegins()
        {
            InitializeComponent();
            random = new Random();
            number1 = 0;
            number2 = 0;
        }

        private void WhoBegins_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap("background4.bmp");
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

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            number1 = random.Next(1, 6);
            label1.Text = number1.ToString();
            btnPlayer2.Enabled = true;
            btnPlayer1.Enabled = false;
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            number2 = random.Next(1, 6);
            label2.Text = number2.ToString();
            btnPlayer2.Enabled = false;

            if(number1 > number2)
            {
                playerOne = true;
            }
            else if(number2>number1)
            {
                playerTwo = true;
            }
            else if(number2 == number1)
            {
                int masterNumber = random.Next(1, 2);
                if(masterNumber == 1)
                {
                     MessageBox.Show("Nun entscheidet das Glückslos wer beginnen darf : Player 1 beginnt");
                     playerOne = true;
                }
                else
                {
                    MessageBox.Show("Nun entscheidet das Glückslos wer beginnen darf : Player 2 beginnt");
                    playerTwo = true;
                }
                
                
            }


            btnGameStart.Visible = true;
        }
    }
}
