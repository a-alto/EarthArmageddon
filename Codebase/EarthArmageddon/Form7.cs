using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Drawing.Text;

namespace EarthArmageddon
{
    public partial class frmLevel1 : Form
    {
        int x = 613; // x position
        int y = 580; // y position
        int countdown = 5; // countdown value
        // enemies speed
        int v1 = 0;
        int v2 = 0;
        int v3 = 0;
        int v4 = 0;
        int vME = 10;
        int life = 4; // lifes
        bool stop = false; // go true when finish the game or press pause button
        int[,] mov = new int[4, 2]; // enemies coordinates matrix
        bool GameOver = false;
        bool lost = false;
        int points = 0;
        bool NotFound = false;

        SoundPlayer countd = new SoundPlayer(@"count.wav");
        SoundPlayer startg = new SoundPlayer(@"start.wav");
        SoundPlayer crash = new SoundPlayer(@"crash.wav");
        SoundPlayer gameov = new SoundPlayer(@"nofuel.wav");

        static void StopSound()
        {
            SoundPlayer snd = new SoundPlayer();
            snd.Stop();
        }
        

        public frmLevel1()
        {
            InitializeComponent();
        }

        // disable close button from ControlBox
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams mdiCp = base.CreateParams;
                mdiCp.ClassStyle |= 0x200;
                return mdiCp;
            }
        }

        private void frmLevel1_Load(object sender, EventArgs e)
        {
            /*PictureBox[] enemy = new PictureBox[3]; // PictureBox array to manage enemies

            // inizialize array
            for (int i = 0; i < n; i++)
            {
                enemy[i] = new PictureBox(); // create new PictureBox
            }*/

            Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            mov[0, 0] = rnd.Next(315, 410);
            mov[1, 0] = rnd.Next(475, 570);
            mov[2, 0] = rnd.Next(635, 730);
            mov[3, 0] = rnd.Next(795, 898);

            Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            v1 = rnd2.Next(5, 15);
            v2 = rnd2.Next(5, 15);
            v3 = rnd2.Next(5, 15);
            v4 = rnd2.Next(5, 15);

            PrivateFontCollection pfc = new PrivateFontCollection();
            try
            {
                pfc.AddFontFile(@"C:\EarthArmageddonFonts\FREEDOM_0.ttf");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Font not found! The game interface could appear quite different.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NotFound = true;
            }
            if (!NotFound)
            {
                lblLife.Font = new Font(pfc.Families[0], 26, FontStyle.Regular);
                lblS.Font = new Font(pfc.Families[0], 26, FontStyle.Regular);
            }
            NotFound = false;

            PrivateFontCollection pfc2 = new PrivateFontCollection();
            try
            {
                pfc2.AddFontFile(@"C:\EarthArmageddonFonts\MODERNESANS.ttf");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Font not found! The game interface could appear quite different.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NotFound = true;
            }
            if (!NotFound)
            {
                lblScore.Font = new Font(pfc2.Families[0], 18, FontStyle.Regular);
            }
            NotFound = false;

            switch (frmMain.lang)
            {
                case 1:
                    lblLife.Text = "Vite:";
                    lblS.Text = "Punti:";
                    lblWin.Text = "HAI VINTO!";
                    btnExit.Text = "esci";
                    break;

                case 2:
                    lblLife.Text = "Life:";
                    lblS.Text = "Score:";
                    lblWin.Text = "YOU WON!";
                    lblWin.Location = new Point((1280 - lblWin.Size.Width) / 2, lblWin.Location.Y);
                    btnExit.Text = "exit";
                    break;

                case 3:
                    lblLife.Text = "Vie:";
                    lblS.Text = "Point:";
                    lblWin.Text = "TU AS GAGNÉ";
                    lblWin.Location = new Point((1280 - lblWin.Size.Width) / 2, lblWin.Location.Y);
                    btnExit.Text = "se déconnecter";
                    btnExit.Size = new Size(251, 39);
                    btnExit.Location = new Point(515, 442);
                    break;

                case 4:
                    lblLife.Text = "حياة";
                    lblS.Text = "أحرز هدفا";
                    lblGameOver.Text = "انتهت اللعبة";
                    lblWin.Text = "فزت";
                    btnExit.Text = "الخروج";
                    lblLife.Location = new Point(265, 25);
                    lblS.Location = new Point(211, 79);
                    pbLife1.Location = new Point(229, 20);
                    pbLife2.Location = new Point(193, 20);
                    pbLife3.Location = new Point(157, 20);
                    pbLife4.Location = new Point(121, 20);
                    lblScore.Location = new Point(143, 76);
                    pbPause.Location = new Point(12, 12);
                    lblGameOver.Location = new Point((1280 - lblGameOver.Size.Width) / 2, (720 - lblGameOver.Size.Height) / 2);
                    lblWin.Location = new Point((1280 - lblWin.Size.Width) / 2, (720 - lblWin.Size.Height) / 2);
                    pnSX.Location = new Point(960, 0);
                    pnDX.Location = new Point(0, 0);
                    break;
            }

            frmMain.uscita = false;
        }

        private void frmLevel1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!stop)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        if (x > 943)
                        {
                            x = 287;
                        }
                        x += vME;
                        pbMe.Location = new Point(x, y);
                        break;

                    case Keys.Left:
                        if (x < 292)
                        {
                            x = 938;
                        }
                        x -= vME;
                        pbMe.Location = new Point(x, y);
                        break;

                    case Keys.Up:
                        if (y > -35)
                        {
                            y -= vME;
                            pbMe.Location = new Point(x, y);
                        }
                        break;

                    case Keys.Down:
                        if (y < 665)
                        {
                            y += vME;
                            pbMe.Location = new Point(x, y);
                        }
                        break;

                    case Keys.P:
                        if (!stop)
                        {
                            tmrMov.Enabled = false;
                            tmrTotal.Enabled = false;
                            frmPause pause = new frmPause();
                            pause.ShowDialog();

                            if (frmMain.uscita)
                            {
                                this.Close();
                            }
                            else
                            {
                                frmMain.uscita = false;
                                tmrMov.Enabled = true;
                                tmrTotal.Enabled = true;
                            }
                        }
                        break;
                } // end switch
            } // end if
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            countdown--;
            if (countdown > -1)
            {
                lblCountdown.Text = Convert.ToString(countdown);
                countd.Play();
            }
            else
            {
                startg.Play();
                lblCountdown.Visible = false;
                pbMe.Visible = true;
                pbEnemy1.Visible = true;
                pbEnemy2.Visible = true;
                pbEnemy3.Visible = true;
                pbEnemy4.Visible = true;
                tmrMov.Enabled = true;
                tmrTotal.Enabled = true;
                tmrCountdown.Enabled = false;
            }
        }

        private void tmrMov_Tick(object sender, EventArgs e)
        {
            if (mov[0, 1] > 730)
            {
                Random rnd = new Random(DateTime.Now.Minute*DateTime.Now.Second * DateTime.Now.Millisecond);
                mov[0, 0] = rnd.Next(315, 410);
                mov[0, 1] = -90;
                Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                v1 = rnd2.Next(5, 15);
                points += 3;
                lblScore.Text = Convert.ToString(points);
            }
            if (mov[1, 1] > 735)
            {
                Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                mov[1, 0] = rnd.Next(475, 570);
                mov[1, 1] = -90;
                Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                v2 = rnd2.Next(5, 15);
                points += 3;
                lblScore.Text = Convert.ToString(points);
            }
            if (mov[2, 1] > 725)
            {
                Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                mov[2, 0] = rnd.Next(635,730);
                mov[2, 1] = -90;
                Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                v3 = rnd2.Next(5, 15);
                points += 3;
                lblScore.Text = Convert.ToString(points);
            }
            if (mov[3, 1] > 737)
            {
                Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                mov[3, 0] = rnd.Next(795, 898);
                mov[3, 1] = -90;
                Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                v4 = rnd2.Next(5, 15);
                points += 3;
                lblScore.Text = Convert.ToString(points);
            }
            mov[0, 1] += v1;
            mov[1, 1] += v2;
            mov[2, 1] += v3;
            mov[3, 1] += v4;

            pbEnemy1.Location = new Point(mov[0, 0], mov[0, 1]);
            pbEnemy2.Location = new Point(mov[1, 0], mov[1, 1]);
            pbEnemy3.Location = new Point(mov[2, 0], mov[2, 1]);
            pbEnemy4.Location = new Point(mov[3, 0], mov[3, 1]);

            if(pbMe.Bounds.IntersectsWith(pbEnemy1.Bounds))
            {
                life--;
                points -= 5;
                lblScore.Text = Convert.ToString(points);
                switch (life)
                {
                    case 3:
                        pbLife4.Visible = false;
                        crash.Play();
                        break;

                    case 2:
                        pbLife3.Visible = false;
                        crash.Play();
                        break;

                    case 1:
                        pbLife2.Visible = false;
                        crash.Play();
                        break;

                    case 0:
                        pbLife1.Visible = false;
                        tmrMov.Enabled = false;
                        tmrTotal.Enabled = false;
                        pbEnemy1.Visible = false;
                        pbEnemy2.Visible = false;
                        pbEnemy3.Visible = false;
                        pbEnemy4.Visible = false;
                        lblGameOver.Visible = true;
                        frmMain.score += points;
                        btnExit.Visible = true;
                        StopSound();
                        gameov.Play();
                        stop = true;
                        break;
                } // end switch

                if (life > 0)
                {
                    Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                    mov[0, 0] = rnd.Next(315, 410);
                    mov[0, 1] = -90;
                    Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                    v1 = rnd2.Next(5, 15);
                }
            } // end if1
            if (pbMe.Bounds.IntersectsWith(pbEnemy2.Bounds))
            {
                life--;
                switch (life)
                {
                    case 3:
                        pbLife4.Visible = false;
                        crash.Play();
                        break;

                    case 2:
                        pbLife3.Visible = false;
                        crash.Play();
                        break;

                    case 1:
                        pbLife2.Visible = false;
                        crash.Play();
                        break;

                    case 0:
                        pbLife1.Visible = false;
                        tmrMov.Enabled = false;
                        tmrTotal.Enabled = false;
                        pbEnemy1.Visible = false;
                        pbEnemy2.Visible = false;
                        pbEnemy3.Visible = false;
                        pbEnemy4.Visible = false;
                        lblGameOver.Visible = true;
                        frmMain.score += points;
                        btnExit.Visible = true;
                        StopSound();
                        gameov.Play();
                        stop = true;
                        break;
                } // end switch

                if (life > 0)
                {
                    Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                    mov[1, 0] = rnd.Next(475, 570);
                    mov[1, 1] = -90;
                    Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                    v2 = rnd2.Next(5, 15);
                }
            } // end if2
            if (pbMe.Bounds.IntersectsWith(pbEnemy3.Bounds))
            {
                life--;
                switch (life)
                {
                    case 3:
                        pbLife4.Visible = false;
                        crash.Play();
                        break;

                    case 2:
                        pbLife3.Visible = false;
                        crash.Play();
                        break;

                    case 1:
                        pbLife2.Visible = false;
                        crash.Play();
                        break;

                    case 0:
                        pbLife1.Visible = false;
                        tmrTotal.Enabled = false;
                        tmrMov.Enabled = false;
                        pbEnemy1.Visible = false;
                        pbEnemy2.Visible = false;
                        pbEnemy3.Visible = false;
                        pbEnemy4.Visible = false;
                        lblGameOver.Visible = true;
                        frmMain.score += points;
                        btnExit.Visible = true;
                        StopSound();
                        gameov.Play();
                        stop = true;
                        break;
                } // end switch

                if (life > 0)
                {
                    Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                    mov[2, 0] = rnd.Next(635, 730);
                    mov[2, 1] = -90;
                    Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                    v3 = rnd2.Next(5, 15);
                }
            } // end if3
            if (pbMe.Bounds.IntersectsWith(pbEnemy4.Bounds))
            {
                life--;
                switch (life)
                {
                    case 3:
                        pbLife4.Visible = false;
                        crash.Play();
                        break;

                    case 2:
                        pbLife3.Visible = false;
                        crash.Play();
                        break;

                    case 1:
                        pbLife2.Visible = false;
                        crash.Play();
                        break;

                    case 0:
                        pbLife1.Visible = false;
                        tmrMov.Enabled = false;
                        tmrTotal.Enabled = false;
                        pbEnemy1.Visible = false;
                        pbEnemy2.Visible = false;
                        pbEnemy3.Visible = false;
                        pbEnemy4.Visible = false;
                        lblGameOver.Visible = true;
                        frmMain.score += points;
                        btnExit.Visible = true;
                        StopSound();
                        gameov.Play();
                        stop = true;
                        break;

                    
                } // end switch

                if (life > 0)
                {
                    Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                    mov[3, 0] = rnd.Next(795, 898);
                    mov[3, 1] = -90;
                    Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                    v4 = rnd2.Next(5, 15);
                }
            } // end if4

            if (life <= 0)
            {
                StopSound();
                tmrMov.Enabled = false;
            }
        }// end tmrMov_tick

        private void pbPause_MouseHover(object sender, EventArgs e)
        {
            pbPause.Image = new Bitmap(@"pauseFULL.png");
        }

        private void pbPause_MouseLeave(object sender, EventArgs e)
        {
            pbPause.Image = new Bitmap(@"pause.png");
        }

        private void pbPause_Click(object sender, EventArgs e)
        {
            if (!stop)
            {
                tmrMov.Enabled = false;
                tmrTotal.Enabled = false;
                frmPause pause = new frmPause();
                pause.ShowDialog();

                if (frmMain.uscita)
                {
                    this.Close();
                }
                else
                {
                    frmMain.uscita = false;
                    tmrMov.Enabled = true;
                    tmrTotal.Enabled = true;
                }
            }
        }

        private void tmrTotal_Tick(object sender, EventArgs e)
        {
            StopSound();
            tmrMov.Enabled = false;
            pbEnemy1.Visible = false;
            pbEnemy2.Visible = false;
            pbEnemy3.Visible = false;
            pbEnemy4.Visible = false;
            if (!lost)
            {
                lblWin.Visible = true;
                frmMain.score += points;
            }
            btnExit.Visible = true;
            GameOver = true;
            stop = true;
            tmrTotal.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            StopSound();
            this.Close();
        }
    }
}
