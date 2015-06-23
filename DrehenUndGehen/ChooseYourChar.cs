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
        Bitmap mario;
        Bitmap luigi;
        Bitmap peach;
        Bitmap yoshi;
        Bitmap toad;
        Bitmap bowser;
        Bitmap all;

        int playerReady;

        Bitmap playerOneUp;
        Bitmap playerOneDown;
        Bitmap playerOneRight;
        Bitmap playerOneLeft;
        Bitmap playerTwoUp;
        Bitmap playerTwoDown;
        Bitmap playerTwoRight;
        Bitmap playerTwoLeft;

        public ChooseYourChar()
        {
            InitializeComponent();
            playerReady = 0;

            mario = new Bitmap("mario.bmp");
            luigi = new Bitmap("luigi.bmp");
            peach = new Bitmap("peach.bmp");
            yoshi = new Bitmap("yoshi.bmp");
            toad = new Bitmap("toad.bmp");
            bowser = new Bitmap("bowser.bmp");
            all = new Bitmap("AllCharsAnimated.bmp");

            fillPictureBoxes();
  
        }

        private void ChooseYourChar_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap("background4.bmp");
            MessageBox.Show("Hallo");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            WhoBegins rollTheDice = new WhoBegins();
            rollTheDice.Visible = true;
            this.Visible = false;
        }

        public void fillPictureBoxes()
        {

            pbChar1.Image = mario;
            pbChar2.Image = luigi;
            pbChar3.Image = peach;
            pbChar4.Image = yoshi;
            pbChar5.Image = toad;
            pbChar6.Image = bowser;
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Start_Screen start = new Start_Screen();
            start.goBack();
            this.Close();
        }


        private void btnbereit_Click(object sender, EventArgs e)
        {
            playerReady++;
            Rectangle rect;

            if(playerReady == 1)
            {
                    if(rbMario.Checked == true)
                    {
                        playerOneUp = CopyBitmap(all, rect = new Rectangle(72, 0, 24, 31));
                        playerOneDown = CopyBitmap(all, rect = new Rectangle(72, 64, 24, 31));
                        playerOneRight = CopyBitmap(all, rect = new Rectangle(72, 35, 24, 31));
                        playerOneLeft = CopyBitmap(all, rect = new Rectangle(72, 96, 24, 31));
                        rbMario.Enabled = false;
                        

                    }else if(rbLuigi.Checked == true)
                    {
                        playerOneUp = CopyBitmap(all, rect = new Rectangle(24,128, 24, 31));
                        playerOneDown = CopyBitmap(all, rect = new Rectangle(24,192, 24, 31));
                        playerOneRight = CopyBitmap(all, rect = new Rectangle(24, 160, 24, 31));
                        playerOneLeft = CopyBitmap(all, rect = new Rectangle(24, 224, 24, 31));
                        rbLuigi.Enabled = false;

                    }else if(rbPeach.Checked == true)
                    {
                        playerOneUp = CopyBitmap(all, rect = new Rectangle(96, 128, 24, 31));
                        playerOneDown = CopyBitmap(all, rect = new Rectangle(96, 192, 24, 31));
                        playerOneRight = CopyBitmap(all, rect = new Rectangle(96, 160, 24, 31));
                        playerOneLeft = CopyBitmap(all, rect = new Rectangle(96, 224, 24, 31));
                        rbPeach.Enabled = false;

                    }else if(rbYoshi.Checked == true)
                    {
                        playerOneUp = CopyBitmap(all, rect = new Rectangle(241, 128, 24, 31));
                        playerOneDown = CopyBitmap(all, rect = new Rectangle(241, 192, 24, 31));
                        playerOneRight = CopyBitmap(all, rect = new Rectangle(241, 160, 24, 31));
                        playerOneLeft = CopyBitmap(all, rect = new Rectangle(241, 224, 24, 31));
                        rbYoshi.Enabled = false;

                    }else if(rbBowser.Checked == true)
                    {
                        playerOneUp = CopyBitmap(all, rect = new Rectangle(24,0, 24, 31));
                        playerOneDown = CopyBitmap(all, rect = new Rectangle(24, 63, 24, 31));
                        playerOneRight = CopyBitmap(all, rect = new Rectangle(24, 32, 24, 31));
                        playerOneLeft = CopyBitmap(all, rect = new Rectangle(24, 96, 24, 31));
                        rbBowser.Enabled = false;

                    }else if (rbToad.Checked == true)
                    {
                        playerOneUp = CopyBitmap(all, rect = new Rectangle(168, 0, 24, 31));
                        playerOneDown = CopyBitmap(all, rect = new Rectangle(168, 64, 24, 31));
                        playerOneRight = CopyBitmap(all, rect = new Rectangle(168, 32, 24, 31));
                        playerOneLeft = CopyBitmap(all, rect = new Rectangle(168, 96, 24, 31));
                        rbToad.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("Sie müssen eine Auswahl treffen");
                    }

                    btnbereit.Text = "Spieler 2 Bereit!";
                    MessageBox.Show("Nun wählen Sie Spieler 2 und bestätigen durch den Button !");

            }else if(playerReady == 2)
            {
                if (rbMario.Checked == true)
                {
                    playerTwoUp = CopyBitmap(all, rect = new Rectangle(72, 0, 24, 31));
                    playerTwoDown = CopyBitmap(all, rect = new Rectangle(72, 64, 24, 31));
                    playerTwoRight = CopyBitmap(all, rect = new Rectangle(72, 35, 24, 31));
                    playerTwoLeft = CopyBitmap(all, rect = new Rectangle(72, 96, 24, 31));
                    rbMario.Enabled = false;

                }
                else if (rbLuigi.Checked == true)
                {
                    playerTwoUp = CopyBitmap(all, rect = new Rectangle(24, 128, 24, 31));
                    playerTwoDown = CopyBitmap(all, rect = new Rectangle(24, 192, 24, 31));
                    playerTwoRight = CopyBitmap(all, rect = new Rectangle(24, 160, 24, 31));
                    playerTwoLeft = CopyBitmap(all, rect = new Rectangle(24, 224, 24, 31));
                    rbLuigi.Enabled = false;

                }
                else if (rbPeach.Checked == true)
                {
                    playerTwoUp = CopyBitmap(all, rect = new Rectangle(96, 128, 24, 31));
                    playerTwoDown = CopyBitmap(all, rect = new Rectangle(96, 192, 24, 31));
                    playerTwoRight = CopyBitmap(all, rect = new Rectangle(96, 160, 24, 31));
                    playerTwoLeft = CopyBitmap(all, rect = new Rectangle(96, 224, 24, 31));
                    rbPeach.Enabled = false;
                }
                else if (rbYoshi.Checked == true)
                {
                    playerTwoUp = CopyBitmap(all, rect = new Rectangle(241, 128, 24, 31));
                    playerTwoDown = CopyBitmap(all, rect = new Rectangle(241, 192, 24, 31));
                    playerTwoRight = CopyBitmap(all, rect = new Rectangle(241, 160, 24, 31));
                    playerTwoLeft = CopyBitmap(all, rect = new Rectangle(241, 224, 24, 31));
                    rbYoshi.Enabled = false;
                }
                else if (rbBowser.Checked == true)
                {
                    playerTwoUp = CopyBitmap(all, rect = new Rectangle(24, 0, 24, 31));
                    playerTwoDown = CopyBitmap(all, rect = new Rectangle(24, 63, 24, 31));
                    playerTwoRight = CopyBitmap(all, rect = new Rectangle(24, 32, 24, 31));
                    playerTwoLeft = CopyBitmap(all, rect = new Rectangle(24, 96, 24, 31));
                    rbBowser.Enabled = false;
                }
                else if (rbToad.Checked == true)
                {
                    playerTwoUp = CopyBitmap(all, rect = new Rectangle(168, 0, 24, 31));
                    playerTwoDown = CopyBitmap(all, rect = new Rectangle(168, 64, 24, 31));
                    playerTwoRight = CopyBitmap(all, rect = new Rectangle(168, 32, 24, 31));
                    playerTwoLeft = CopyBitmap(all, rect = new Rectangle(168, 96, 24, 31));
                    rbToad.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sie müssen eine Auswahl treffen");
                }

                btnNext.Visible = true;
                btnbereit.Visible = false;
            }
        }

        // Copies a part of a bitmap.
        protected Bitmap CopyBitmap(Bitmap source, Rectangle part)
        {
            Bitmap bmp = new Bitmap(80, 80);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(source, 0, 0, part, GraphicsUnit.Pixel);
            g.Dispose();
            bmp.MakeTransparent(Color.Green);
            return bmp;
        }
    }
}
