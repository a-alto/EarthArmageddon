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
    public partial class frmLevel3 : Form
    {
        int countdown = 5; // countdown value
        bool stop = false; // true when the game ends
        int x = 180; // x position (pbMe)
        int y = 333; // y position (pbMe)
        int vME = 10; // pbMe speed
        int xS = 0; // pbShoot x position
        int yS = 0; // pbShoot y position
        bool GameOver = false; // if game is over
        bool lost = false; // true if life ends
        int points = 0; // points
        bool hit1 = false; // if Enemy1 is striken
        bool hit2 = false; // if Enemy2 is striken
        int v1 = 0; // enemy1 speed
        int v2 = 0; // enemy2 speed
        int[,] mov = new int[2, 2]; // enemiy position matrix
        int life = 4; // lifes
        int prob1 = 0; // probability to shoot (enemy1)
        int prob2 = 0; // probability to shoot (enemy2)
        bool IsShooting1 = false; // true if enemy1 is shooting
        bool IsShooting2 = false; // true if enemy2 is shooting
        int NoLife = 0; // when reach 5, decrement life
        int[,] vBlast = new int[2, 2]; // pbBlast 1 and 2 speed
        bool NotFound = false;

        SoundPlayer countd = new SoundPlayer(@"count.wav");
        SoundPlayer startg = new SoundPlayer(@"start.wav");
        SoundPlayer crash = new SoundPlayer(@"crash.wav");
        SoundPlayer gameov = new SoundPlayer(@"nofuel.wav");
        SoundPlayer meshoot = new SoundPlayer(@"meshoot.wav");
        SoundPlayer enshoot2 = new SoundPlayer(@"enshoot2.wav");
        SoundPlayer enshootnormal = new SoundPlayer(@"enshootnormal.wav");

        public frmLevel3()
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

        static void StopSound()
        {
            SoundPlayer snd = new SoundPlayer();
            snd.Stop();
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
                tmrMov.Enabled = true;
                tmrEnShoot.Enabled = true;
                tmrBlast.Enabled = true;
                tmrTotal.Enabled = true;
                tmrCountdown.Enabled = false;
            }
        }

        private void frmLevel3_KeyDown(object sender, KeyEventArgs e)
        {
            if (!stop)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        if (x < 660)
                        {
                            x += vME;
                            pbMe.Location = new Point(x, y);
                        }
                        break;

                    case Keys.Left:
                        if (x > -20)
                        {
                            x -= vME;
                            pbMe.Location = new Point(x, y);
                        }
                        break;

                    case Keys.Up:
                        if (y < 110)
                        {
                            y = 535;
                        }
                        y -= vME;
                        pbMe.Location = new Point(x, y);
                        break;

                    case Keys.Down:
                        if (y > 535)
                        {
                            y = 110;
                        }
                        y += vME;
                        pbMe.Location = new Point(x, y);
                        break;

                    case Keys.Z:
                        xS = x + 79;
                        yS = y + 25;
                        pbShoot.Location = new Point(xS, yS);
                        pbShoot.Visible = true;
                        tmrShoot.Enabled = true;
                        meshoot.Play();
                        break;

                    case Keys.Space:
                        xS = x + 79;
                        yS = y + 25;
                        pbShoot.Location = new Point(xS, yS);
                        pbShoot.Visible = true;
                        tmrShoot.Enabled = true;
                        meshoot.Play();
                        break;

                    case Keys.P:
                        if (!stop)
                        {
                            tmrMov.Enabled = false;
                            tmrEnShoot.Enabled = false;
                            tmrShoot.Enabled = false;
                            tmrBlast.Enabled = false;
                            tmrBoomE1.Enabled = false;
                            tmrBoomE2.Enabled = false;
                            tmrEnShoot.Enabled = false;
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
                                tmrShoot.Enabled = true;
                                tmrEnShoot.Enabled = true;
                                tmrBlast.Enabled = true;
                                tmrBoomE1.Enabled = true;
                                tmrBoomE2.Enabled = true;
                                tmrEnShoot.Enabled = true;
                                tmrTotal.Enabled = true;
                            }
                        }
                        break;
                } // end switch
            } // end if
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            xS += 10;
            pbShoot.Location = new Point(xS, yS);

            if (xS > 1280)
            {
                pbShoot.Visible = false;
                tmrShoot.Enabled = false;
            }

            if (pbShoot.Bounds.IntersectsWith(pbEnemy1.Bounds))
            {
                if (!hit1)
                {
                    hit1 = true;
                    tmrShoot.Enabled = false;
                    pbShoot.Visible = false;
                    pbEnemy1.Image = new Bitmap(@"EnemySpaceship3_r_boom.png");
                    tmrBoomE1.Enabled = true;
                    points += 3;
                    lblScore.Text = Convert.ToString(points);
                }
            }
            if (pbShoot.Bounds.IntersectsWith(pbEnemy2.Bounds))
            {
                if (!hit2)
                {
                    hit2 = true;
                    tmrShoot.Enabled = false;
                    pbShoot.Visible = false;
                    pbEnemy2.Image = new Bitmap(@"EnemySpaceship3_r_boom.png");
                    tmrBoomE2.Enabled = true;
                    points += 3;
                    lblScore.Text = Convert.ToString(points);
                }
            } // end last if
        }

        private void tmrBoomE1_Tick(object sender, EventArgs e)
        {
            pbEnemy1.Image = new Bitmap(@"EnemySpaceship3_r.png");
            Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            mov[0, 1] = rnd.Next(110, 239);
            mov[0, 0] = 1280;
            Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            v1 = rnd2.Next(5, 15);
            tmrBoomE1.Enabled = false;
            hit1 = false;
        }

        private void tmrBoomE2_Tick(object sender, EventArgs e)
        {
            pbEnemy2.Image = new Bitmap(@"EnemySpaceship3_r.png");
            Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            mov[1, 1] = rnd.Next(323, 451);
            mov[1, 0] = 1280;
            Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            v2 = rnd2.Next(5, 15);
            tmrBoomE2.Enabled = false;
            hit2 = false;
        }

        private void frmLevel3_Load(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            mov[0, 1] = rnd.Next(110, 239);
            mov[1, 1] = rnd.Next(323, 451);

            Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            v1 = rnd2.Next(5, 15);
            v2 = rnd2.Next(5, 15);

            mov[0, 0] = 1280;
            mov[1, 0] = 1280;

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
                    lblLife.Location = new Point(1225, 25);
                    lblS.Location = new Point(857, 25);
                    pbLife1.Location = new Point(1189, 20);
                    pbLife2.Location = new Point(1153, 20);
                    pbLife3.Location = new Point(1117, 20);
                    pbLife4.Location = new Point(1081, 20);
                    lblScore.Location = new Point(776, 22);
                    pbPause.Location = new Point(3, 3);
                    lblGameOver.Location = new Point((1280 - lblGameOver.Size.Width) / 2, (720 - lblGameOver.Size.Height) / 2);
                    lblWin.Location = new Point((1280 - lblWin.Size.Width) / 2, (720 - lblWin.Size.Height) / 2);
                    break;
            } // end languages switch

            frmMain.uscita = false;
        }

        private void tmrMov_Tick(object sender, EventArgs e)
        {
            if (mov[0, 0] < -5)
            {
                Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                mov[0, 1] = rnd.Next(110, 239);
                mov[0, 0] = 1280;
                Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                v1 = rnd2.Next(5, 15);
                points -= 1;
                lblScore.Text = Convert.ToString(points);
            }
            if (mov[1, 0] < -13)
            {
                Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                mov[1, 1] = rnd.Next(323, 451);
                mov[1, 0] = 1280;
                Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                v2 = rnd2.Next(5, 15);
                points -= 1;
                lblScore.Text = Convert.ToString(points);
            } // end relocation if

            mov[0, 0] -= v1;
            mov[1, 0] -= v2;

            if (!hit1)
            {
                pbEnemy1.Location = new Point(mov[0, 0], mov[0, 1]);
            }
            if (!hit2)
            {
                pbEnemy2.Location = new Point(mov[1, 0], mov[1, 1]);
            }

            if (pbMe.Bounds.IntersectsWith(pbEnemy1.Bounds))
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
                        tmrEnShoot.Enabled = false;
                        tmrShoot.Enabled = false;
                        tmrBlast.Enabled = false;
                        tmrBoomE1.Enabled = false;
                        tmrBoomE2.Enabled = false;
                        tmrEnShoot.Enabled = false;
                        pbBlast1.Visible = false;
                        pbBlast2.Visible = false;
                        pbEnemy1.Visible = false;
                        pbEnemy2.Visible = false;
                        lblGameOver.Visible = true;
                        lost = true;
                        GameOver = true;
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
                        tmrEnShoot.Enabled = false;
                        tmrShoot.Enabled = false;
                        tmrBlast.Enabled = false;
                        tmrBoomE1.Enabled = false;
                        tmrBoomE2.Enabled = false;
                        tmrEnShoot.Enabled = false;
                        pbBlast1.Visible = false;
                        pbBlast2.Visible = false;
                        pbEnemy1.Visible = false;
                        pbEnemy2.Visible = false;
                        lblGameOver.Visible = true;
                        lost = true;
                        GameOver = true;
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
        }

        private void tmrTotal_Tick(object sender, EventArgs e)
        {
            StopSound();
            pbEnemy1.Visible = false;
            pbEnemy2.Visible = false;
            pbEn1Shoot.Visible = false;
            pbEn2Shoot.Visible = false;
            tmrMov.Enabled = false;
            tmrEnShoot.Enabled = false;
            tmrShoot.Enabled = false;
            tmrBlast.Enabled = false;
            tmrBoomE1.Enabled = false;
            tmrBoomE2.Enabled = false;
            tmrEnShoot.Enabled = false;
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
                tmrEnShoot.Enabled = false;
                tmrShoot.Enabled = false;
                tmrBlast.Enabled = false;
                tmrBoomE1.Enabled = false;
                tmrBoomE2.Enabled = false;
                tmrEnShoot.Enabled = false;
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
                    tmrShoot.Enabled = true;
                    tmrEnShoot.Enabled = true;
                    tmrBlast.Enabled = true;
                    tmrBoomE1.Enabled = true;
                    tmrBoomE2.Enabled = true;
                    tmrEnShoot.Enabled = true;
                    tmrTotal.Enabled = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            StopSound();
            this.Close();
        }

        private void pbEnemy1_LocationChanged(object sender, EventArgs e)
        {
            if (!IsShooting1)
            {
                // enemy has 25% to shoot. Probability ratio is 1:3 so every 3% of probability to not shoot there's 1% to shoot
                Random rndS = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                prob1 = rndS.Next(0, 100);

                if ((prob1 > 1 && prob1 <= 4) || (prob1 > 6 && prob1 <= 9) || (prob1 > 11 && prob1 <= 14) || (prob1 > 16 && prob1 <= 19) || (prob1 > 21 && prob1 <= 24) || (prob1 > 26 && prob1 <= 29) || (prob1 > 31 && prob1 <= 34) || (prob1 > 36 && prob1 <= 39) || (prob1 > 41 && prob1 <= 44) || (prob1 > 46 && prob1 <= 49) || (prob1 > 51 && prob1 <= 54) || (prob1 > 56 && prob1 <= 59) || (prob1 > 61 && prob1 <= 64) || (prob1 > 66 && prob1 <= 69) || (prob1 > 71 && prob1 <= 74) || (prob1 > 76 && prob1 <= 79) || (prob1 > 81 && prob1 <= 84) || (prob1 > 86 && prob1 <= 89) || (prob1 > 91 && prob1 <= 94) || (prob1 > 96 && prob1 <= 99))
                {

                }
                else
                {
                    Random rndS2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                    prob1 = rndS2.Next(0, 100);
                    if (!(prob1 > 1 && prob1 <= 4) || (prob1 > 6 && prob1 <= 9) || (prob1 > 11 && prob1 <= 14) || (prob1 > 16 && prob1 <= 19) || (prob1 > 21 && prob1 <= 24) || (prob1 > 26 && prob1 <= 29) || (prob1 > 31 && prob1 <= 34) || (prob1 > 36 && prob1 <= 39) || (prob1 > 41 && prob1 <= 44) || (prob1 > 46 && prob1 <= 49) || (prob1 > 51 && prob1 <= 54) || (prob1 > 56 && prob1 <= 59) || (prob1 > 61 && prob1 <= 64) || (prob1 > 66 && prob1 <= 69) || (prob1 > 71 && prob1 <= 74) || (prob1 > 76 && prob1 <= 79) || (prob1 > 81 && prob1 <= 84) || (prob1 > 86 && prob1 <= 89) || (prob1 > 91 && prob1 <= 94) || (prob1 > 96 && prob1 <= 99))
                    {
                        pbEn1Shoot.Location = new Point((mov[0, 0] - 79), (mov[0, 1] + 40));
                        pbEn1Shoot.Visible = true;
                        IsShooting1 = true;
                        enshootnormal.Play();
                    }
                    else
                    {
                        pbBlast1.Location = new Point((mov[0, 0] - 26), (mov[0, 1] + 32));
                        vBlast[0, 0] = (pbBlast1.Location.X - x + 73) / 30;
                        vBlast[0, 1] = (pbMe.Location.Y - pbBlast1.Location.Y + 18) / 30;
                        pbBlast1.Visible = true;
                        IsShooting1 = true;
                        enshoot2.Play();
                    }
                }
            } // end last if for shoot
        }

        private void pbEnemy2_LocationChanged(object sender, EventArgs e)
        {
            if (!IsShooting2)
            {
                // enemy has 25% to shoot. Probability ratio is 1:3 so every 3% of probability to not shoot there's 1% to shoot
                Random rndS3 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                prob2 = rndS3.Next(0, 100);

                if ((prob2 > 1 && prob2 <= 4) || (prob2 > 6 && prob2 <= 9) || (prob2 > 11 && prob2 <= 14) || (prob2 > 16 && prob2 <= 19) || (prob2 > 21 && prob2 <= 24) || (prob2 > 26 && prob2 <= 29) || (prob2 > 31 && prob2 <= 34) || (prob2 > 36 && prob2 <= 39) || (prob2 > 41 && prob2 <= 44) || (prob2 > 46 && prob2 <= 49) || (prob2 > 51 && prob2 <= 54) || (prob2 > 56 && prob2 <= 59) || (prob2 > 61 && prob2 <= 64) || (prob2 > 66 && prob2 <= 69) || (prob2 > 71 && prob2 <= 74) || (prob2 > 76 && prob2 <= 79) || (prob2 > 81 && prob2 <= 84) || (prob2 > 86 && prob2 <= 89) || (prob2 > 91 && prob2 <= 94) || (prob2 > 96 && prob2 <= 99))
                {

                }
                else
                {
                    Random rndS4 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                    prob2 = rndS4.Next(0, 100);
                    if (!(prob2 > 1 && prob2 <= 4) || (prob2 > 6 && prob2 <= 9) || (prob2 > 11 && prob2 <= 14) || (prob2 > 16 && prob2 <= 19) || (prob2 > 21 && prob2 <= 24) || (prob2 > 26 && prob2 <= 29) || (prob2 > 31 && prob2 <= 34) || (prob2 > 36 && prob2 <= 39) || (prob2 > 41 && prob2 <= 44) || (prob2 > 46 && prob2 <= 49) || (prob2 > 51 && prob2 <= 54) || (prob2 > 56 && prob2 <= 59) || (prob2 > 61 && prob2 <= 64) || (prob2 > 66 && prob2 <= 69) || (prob2 > 71 && prob2 <= 74) || (prob2 > 76 && prob2 <= 79) || (prob2 > 81 && prob2 <= 84) || (prob2 > 86 && prob2 <= 89) || (prob2 > 91 && prob2 <= 94) || (prob2 > 96 && prob2 <= 99))
                    {
                        pbEn2Shoot.Location = new Point((mov[1, 0] - 79), (mov[1, 1] + 40));
                        pbEn2Shoot.Visible = true;
                        IsShooting2 = true;
                        enshootnormal.Play();
                    }
                    else
                    {
                        pbBlast2.Location = new Point((mov[1, 0] - 26), (mov[1, 1] + 32));
                        vBlast[1, 0] = (pbBlast2.Location.X - x + 73) / 30;
                        vBlast[1, 1] = (pbBlast2.Location.Y - y + 18) / 30;
                        pbBlast2.Visible = true;
                        IsShooting2 = true;
                        enshoot2.Play();
                    }
                }
            } // end last if for shoot
        }

        private void tmrEnShoot_Tick(object sender, EventArgs e)
        {
            pbEn1Shoot.Location = new Point((pbEn1Shoot.Location.X - 10), pbEn1Shoot.Location.Y);
            pbEn2Shoot.Location = new Point((pbEn2Shoot.Location.X - 10), pbEn2Shoot.Location.Y);

            if (pbEn1Shoot.Bounds.IntersectsWith(pbMe.Bounds) && pbEn1Shoot.Visible)
            {
                points -= 3;
                lblScore.Text = Convert.ToString(points);
                pbEn1Shoot.Visible = false;
                IsShooting1 = false;
                NoLife++;
                if (NoLife >= 3)
                {
                    life--;
                    switch (life)
                    {
                        case 3:
                            pbLife4.Visible = false;
                            break;

                        case 2:
                            pbLife3.Visible = false;
                            break;

                        case 1:
                            pbLife2.Visible = false;
                            break;

                        case 0:
                            pbLife1.Visible = false;
                            pbLife1.Visible = false;
                            tmrMov.Enabled = false;
                            tmrEnShoot.Enabled = false;
                            tmrShoot.Enabled = false;
                            tmrBlast.Enabled = false;
                            tmrBoomE1.Enabled = false;
                            tmrBoomE2.Enabled = false;
                            tmrEnShoot.Enabled = false;
                            pbBlast1.Visible = false;
                            pbBlast2.Visible = false;
                            pbEnemy1.Visible = false;
                            pbEnemy2.Visible = false;
                            pbEn1Shoot.Visible = false;
                            pbEn2Shoot.Visible = false;
                            lblGameOver.Visible = true;
                            lost = true;
                            GameOver = true;
                            frmMain.score += points;
                            btnExit.Visible = true;
                            StopSound();
                            gameov.Play();
                            stop = true;
                            break;
                    } // end switch

                    NoLife = 0;
                }
            } // end last if

            if (pbEn2Shoot.Bounds.IntersectsWith(pbMe.Bounds) && pbEn2Shoot.Visible)
            {
                points -= 3;
                lblScore.Text = Convert.ToString(points);
                pbEn2Shoot.Visible = false;
                IsShooting2 = false;
                NoLife++;
                if (NoLife >= 3)
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
                            pbLife1.Visible = false;
                            tmrMov.Enabled = false;
                            tmrEnShoot.Enabled = false;
                            tmrShoot.Enabled = false;
                            tmrBlast.Enabled = false;
                            tmrBoomE1.Enabled = false;
                            tmrBoomE2.Enabled = false;
                            tmrEnShoot.Enabled = false;
                            pbBlast1.Visible = false;
                            pbBlast2.Visible = false;
                            pbEnemy1.Visible = false;
                            pbEnemy2.Visible = false;
                            pbEn1Shoot.Visible = false;
                            pbEn2Shoot.Visible = false;
                            lblGameOver.Visible = true;
                            lost = true;
                            GameOver = true;
                            frmMain.score += points;
                            btnExit.Visible = true;
                            StopSound();
                            gameov.Play();
                            stop = true;
                            break;
                    } // end switch

                    NoLife = 0;
                }
            } // end last if

            if (pbEn1Shoot.Location.X < -34 && pbEn1Shoot.Visible)
            {
                pbEn1Shoot.Visible = false;
                IsShooting1 = false;
            }
            if (pbEn2Shoot.Location.X < -34 && pbEn2Shoot.Visible)
            {
                pbEn2Shoot.Visible = false;
                IsShooting2 = false;
            }
        }

        private void tmrBlast_Tick(object sender, EventArgs e)
        {
            pbBlast1.Location = new Point(pbBlast1.Location.X - vBlast[0, 0], pbBlast1.Location.Y + vBlast[0, 1]);
            pbBlast2.Location = new Point(pbBlast2.Location.X - vBlast[1, 0], pbBlast2.Location.Y - vBlast[1, 1]);

            if (pbBlast1.Bounds.IntersectsWith(pbMe.Bounds) && pbBlast1.Visible)
            {
                points -= 5;
                lblScore.Text = Convert.ToString(points);
                life--;
                pbBlast1.Visible = false;
                IsShooting1 = false;

                switch (life)
                {
                    case 3:
                        pbLife4.Visible = false;
                        break;

                    case 2:
                        pbLife3.Visible = false;
                        break;

                    case 1:
                        pbLife2.Visible = false;
                        break;

                    case 0:
                        pbLife1.Visible = false;
                        tmrMov.Enabled = false;
                        tmrBlast.Enabled = false;
                        tmrBoomE1.Enabled = false;
                        tmrBoomE2.Enabled = false;
                        tmrEnShoot.Enabled = false;
                        pbBlast1.Visible = false;
                        pbBlast2.Visible = false;
                        pbEnemy1.Visible = false;
                        pbEnemy2.Visible = false;
                        pbEn1Shoot.Visible = false;
                        pbEn2Shoot.Visible = false;
                        lblGameOver.Visible = true;
                        lost = true;
                        GameOver = true;
                        frmMain.score += points;
                        btnExit.Visible = true;
                        stop = true;
                        break;
                } // end switch
            } // end last if

            if (pbBlast2.Bounds.IntersectsWith(pbMe.Bounds) && pbBlast2.Visible)
            {
                points -= 5;
                lblScore.Text = Convert.ToString(points);
                life--;
                pbBlast2.Visible = false;
                IsShooting2 = false;

                switch (life)
                {
                    case 3:
                        pbLife4.Visible = false;
                        break;

                    case 2:
                        pbLife3.Visible = false;
                        break;

                    case 1:
                        pbLife2.Visible = false;
                        break;

                    case 0:
                        pbLife1.Visible = false;
                        tmrMov.Enabled = false;
                        tmrBlast.Enabled = false;
                        tmrBoomE1.Enabled = false;
                        tmrBoomE2.Enabled = false;
                        tmrEnShoot.Enabled = false;
                        pbBlast1.Visible = false;
                        pbBlast2.Visible = false;
                        pbEnemy1.Visible = false;
                        pbEnemy2.Visible = false;
                        pbEn1Shoot.Visible = false;
                        pbEn2Shoot.Visible = false;
                        lblGameOver.Visible = true;
                        lost = true;
                        GameOver = true;
                        frmMain.score += points;
                        btnExit.Visible = true;
                        stop = true;
                        break;
                } // end switch
            } // end last if

            if ((pbBlast1.Location.X < -20 || pbBlast1.Location.X > 1300 ||pbBlast1.Location.Y < -20 || pbBlast1.Location.Y > 740) && pbBlast1.Visible)
            {
                pbBlast1.Visible = false;
                IsShooting1 = false;
            }
            if ((pbBlast2.Location.X < -20 || pbBlast2.Location.X > 1300 ||pbBlast2.Location.Y < -20 || pbBlast2.Location.Y > 740) && pbBlast2.Visible)
            {
                pbBlast2.Visible = false;
                IsShooting2 = false;
            }
        }
    }
}
