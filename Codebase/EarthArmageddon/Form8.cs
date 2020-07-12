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
    public partial class frmLevel2 : Form
    {
        int x = 613; // x position
        int y = 580; // y position
        int life = 4; // lifes
        bool stop = false; // go true when finish the game or press pause button
        int vME = 10;
        int xS = 0; // pbShoot x position
        int yS = 0; // pbShoot x position
        int countdown = 5; // countdown value
        int[,] mov = new int[3, 2]; // enemies coordinates matrix
        // enemy spaceships speed
        int v1 = 0;
        int v2 = 0;
        int v3 = 0;
        // enemy movement directions (SX or DX)
        int dir1 = 0;
        int dir2 = 0;
        int dir3 = 0;
        // if an enemy is stricken
        bool hit1 = false;
        bool hit2 = false;
        bool hit3 = false;
        // when (x position) enemy have to shoot
        int shoot1 = 0;
        int shoot2 = 0;
        int shoot3 = 0;
        // if enemy shoot is moving
        bool colpo1 = false;
        bool colpo2 = false;
        bool colpo3 = false;
        int NoLife = 0; // when reach 5, decrement life
        bool GameOver = false; // if game is over
        bool lost = false; // true if life ends
        int points = 0;
        bool NotFound = false;

        SoundPlayer countd = new SoundPlayer(@"count.wav");
        SoundPlayer startg = new SoundPlayer(@"start.wav");
        SoundPlayer crash = new SoundPlayer(@"crash.wav");
        SoundPlayer gameov = new SoundPlayer(@"nofuel.wav");
        SoundPlayer meshoot = new SoundPlayer(@"meshoot.wav");
        SoundPlayer enshoot = new SoundPlayer(@"enshoot.wav");

        public frmLevel2()
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

        // calculate enemy spaceship direction (SX or DX)
        static int CalculateDirection()
        {
            int direction=0;
            Random rnd3 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            direction = rnd3.Next(0, 100);
            return direction;
        }

        static int CalculateShoot()
        {
            int xShoot = 0;
            Random rnd4 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            xShoot = rnd4.Next(170, 980);
            return xShoot;
        }

        private void pbPause_Click(object sender, EventArgs e)
        {
            if (!stop)
            {
                tmrMov.Enabled = false;
                tmrEnShoot.Enabled = false;
                tmrShoot.Enabled = false;
                tmrBoomE1.Enabled = false;
                tmrBoomE2.Enabled = false;
                tmrBoomE3.Enabled = false;
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
                    tmrBoomE1.Enabled = true;
                    tmrBoomE2.Enabled = true;
                    tmrBoomE3.Enabled = true;
                    tmrTotal.Enabled = true;
                }
            }
        }

        private void frmLevel2_KeyDown(object sender, KeyEventArgs e)
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
                        if (y < 375)
                        {
                            y = 664;
                        }
                        y -= vME;
                        pbMe.Location = new Point(x, y);
                        break;

                    case Keys.Down:
                        if (y < 665)
                        {
                            y += vME;
                            pbMe.Location = new Point(x, y);
                        }
                        break;

                    case Keys.Z:
                        xS = x + 25;
                        yS = y - 40;
                        pbShoot.Location = new Point(xS, yS);
                        pbShoot.Visible = true;
                        tmrShoot.Enabled = true;
                        meshoot.Play();
                        break;

                    case Keys.Space:
                        xS = x + 25;
                        yS = y - 40;
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
                            tmrBoomE1.Enabled = false;
                            tmrBoomE2.Enabled = false;
                            tmrBoomE3.Enabled = false;
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
                                tmrBoomE1.Enabled = true;
                                tmrBoomE2.Enabled = true;
                                tmrBoomE3.Enabled = true;
                                tmrTotal.Enabled = true;
                            }
                        }
                        break;
                } // end switch
            } // end if
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            yS -= 10;
            pbShoot.Location = new Point(xS, yS);

            if (yS < -50)
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
                    pbEnemy1.Image = new Bitmap(@"ufo_boom.png");
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
                    pbEnemy2.Image = new Bitmap(@"ufo_boom.png");
                    tmrBoomE2.Enabled = true;
                    points += 3;
                    lblScore.Text = Convert.ToString(points);
                }
            }
            if (pbShoot.Bounds.IntersectsWith(pbEnemy3.Bounds))
            {
                if (!hit3)
                {
                    hit3 = true;
                    tmrShoot.Enabled = false;
                    pbShoot.Visible = false;
                    pbEnemy3.Image = new Bitmap(@"ufo_boom.png");
                    tmrBoomE3.Enabled = true;
                    points += 3;
                    lblScore.Text = Convert.ToString(points);
                }
            }

        }

        private void pbShoot_LocationChanged(object sender, EventArgs e)
        {
            if (yS < -2)
            {
                tmrShoot.Enabled = false;
                pbShoot.Visible = false;
            }
        }

        private void pbPause_MouseHover(object sender, EventArgs e)
        {
            pbPause.Image = new Bitmap(@"pauseFULL.png");
        }

        private void pbPause_MouseLeave(object sender, EventArgs e)
        {
            pbPause.Image = new Bitmap(@"pause.png");
        }

        private void frmLevel2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            mov[0, 1] = rnd.Next(0, 60);
            mov[1, 1] = rnd.Next(120, 180);
            mov[2, 1] = rnd.Next(240, 300);
            mov[0, 0] = 205;
            mov[1, 0] = 205;
            mov[2, 0] = 205;

            dir1 = CalculateDirection();
            dir2 = CalculateDirection();
            dir3 = CalculateDirection();

            Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            v1 = rnd2.Next(5, 15);
            v2 = rnd2.Next(5, 15);
            v3 = rnd2.Next(5, 15);

            shoot1 = CalculateShoot();
            shoot2 = CalculateShoot();
            shoot3 = CalculateShoot();

            if ((dir1 >= 25 && dir1 < 50) || (dir1 >= 75 && dir1 <= 100))
            {
                v1 *= -1;
                mov[0, 0] = 950;
            }
            if ((dir2 >= 25 && dir2 < 50) || (dir2 >= 75 && dir2 <= 100))
            {
                v2 *= -1;
                mov[1, 0] = 950;
            }
            if ((dir3 >= 25 && dir3 < 50) || (dir3 >= 75 && dir3 <= 100))
            {
                v3 *= -1;
                mov[2, 0] = 950;
            }

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
                    break;
            }

            frmMain.uscita = false;
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
                tmrMov.Enabled = true;
                tmrEnShoot.Enabled = true;
                tmrTotal.Enabled = true;
                tmrCountdown.Enabled = false;
            }
        }

        private void tmrMov_Tick(object sender, EventArgs e)
        {
            if (mov[0, 0] < 185 || mov[0,0] > 975)
            {
                Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                mov[0, 1] = rnd.Next(0, 60);
                mov[0, 0] = 205;
                Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                v1 = rnd2.Next(5, 15);
                dir1 = CalculateDirection();
                shoot1 = CalculateShoot();
                if ((dir1 >= 25 && dir1 < 50) || (dir1 >= 75 && dir1 <= 100))
                {
                    v1 *= -1;
                    mov[0, 0] = 950;
                }
                colpo1 = false;
            }
            if (mov[1, 0] < 190 || mov[1, 0] > 955)
            {
                Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                mov[1, 1] = rnd.Next(120, 180);
                mov[1, 0] = 205;
                Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                v2 = rnd2.Next(5, 15);
                dir2 = CalculateDirection();
                shoot2 = CalculateShoot();
                if ((dir2 >= 25 && dir2 < 50) || (dir2 >= 75 && dir2 <= 100))
                {
                    v2 *= -1;
                    mov[1, 0] = 950;
                }
                colpo2 = false;
            }
            if (mov[2, 0] < 170 || mov[2, 0] > 980)
            {
                Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                mov[2, 1] = rnd.Next(240, 300);
                mov[2, 0] = 205;
                Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
                v3 = rnd2.Next(5, 15);
                dir3 = CalculateDirection();
                shoot3 = CalculateShoot();
                if ((dir3 >= 25 && dir3 < 50) || (dir3 >= 75 && dir3 <= 100))
                {
                    v3 *= -1;
                    mov[2, 0] = 950;
                }
                colpo3 = false;
            } // end last if

            mov[0, 0] += v1;
            mov[1, 0] += v2;
            mov[2, 0] += v3;

            if (!hit1)
            {
                pbEnemy1.Location = new Point(mov[0, 0], mov[0, 1]);
            }
            if (!hit2)
            {
                pbEnemy2.Location = new Point(mov[1, 0], mov[1, 1]);
            }
            if (!hit3)
            {
                pbEnemy3.Location = new Point(mov[2, 0], mov[2, 1]);
            }
        }

        private void tmrBoomE1_Tick(object sender, EventArgs e)
        {
            pbEnemy1.Image = new Bitmap(@"ufo.png");
            Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            mov[0, 1] = rnd.Next(0, 60);
            mov[0, 0] = 205;
            Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            v1 = rnd2.Next(5, 15);
            dir1 = CalculateDirection();
            shoot1 = CalculateShoot();
            if ((dir1 >= 25 && dir1 < 50) || (dir1 >= 75 && dir1 <= 100))
            {
                v1 *= -1;
                mov[0, 0] = 950;
            }
            tmrBoomE1.Enabled = false;
            hit1 = false;
        }

        private void tmrBoomE2_Tick(object sender, EventArgs e)
        {
            pbEnemy2.Image = new Bitmap(@"ufo.png");
            Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            mov[1, 1] = rnd.Next(120, 180);
            mov[1, 0] = 205;
            Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            v2 = rnd2.Next(5, 15);
            dir2 = CalculateDirection();
            shoot2 = CalculateShoot();
            if ((dir2 >= 25 && dir2 < 50) || (dir2 >= 75 && dir2 <= 100))
            {
                v2 *= -1;
                mov[1, 0] = 950;
            }
            tmrBoomE2.Enabled = false;
            hit2 = false;
        }

        private void tmrBoomE3_Tick(object sender, EventArgs e)
        {
            pbEnemy3.Image = new Bitmap(@"ufo.png");
            Random rnd = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            mov[2, 1] = rnd.Next(240, 300);
            mov[2, 0] = 205;
            Random rnd2 = new Random(DateTime.Now.Minute * DateTime.Now.Second * DateTime.Now.Millisecond);
            v3 = rnd2.Next(5, 15);
            dir3 = CalculateDirection();
            shoot3 = CalculateShoot();
            if ((dir3 >= 25 && dir3 < 50) || (dir3 >= 75 && dir3 <= 100))
            {
                v3 *= -1;
                mov[2, 0] = 950;
            }
            tmrBoomE3.Enabled = false;
            hit3 = false;
        }

        private void pbEnemy1_LocationChanged(object sender, EventArgs e)
        {
            if (!colpo1)
            {
                if (v1 > 0)
                {
                    if (mov[0, 0] > shoot1)
                    {
                        pbEn1Shoot.Location = new Point((mov[0, 0] + 55), (mov[0, 1] + 66));
                        pbEn1Shoot.Visible = true;
                        colpo1 = true;
                        enshoot.Play();
                    }
                }
                else
                {
                    if (mov[0, 0] < shoot1)
                    {
                        pbEn1Shoot.Location = new Point((mov[0, 0] + 55), (mov[0, 1] + 66));
                        pbEn1Shoot.Visible = true;
                        colpo1 = true;
                        enshoot.Play();
                    }
                }
            }
        }

        private void pbEnemy2_LocationChanged(object sender, EventArgs e)
        {
            if (!colpo2)
            {
                if (dir2 > 0)
                {
                    if (mov[1, 0] > shoot2)
                    {
                        pbEn2Shoot.Location = new Point((mov[1, 0] + 55), (mov[1, 1] + 66));
                        pbEn2Shoot.Visible = true;
                        colpo2 = true;
                        enshoot.Play();
                    }
                }
                else
                {
                    if (mov[1, 0] < shoot2)
                    {
                        pbEn2Shoot.Location = new Point((mov[1, 0] + 55), (mov[1, 1] + 66));
                        pbEn2Shoot.Visible = true;
                        colpo2 = true;
                        enshoot.Play();
                    }
                }
            }
        }

        private void pbEnemy3_LocationChanged(object sender, EventArgs e)
        {
            if (!colpo3)
            {
                if (dir3 > 0)
                {
                    if (mov[2, 0] > shoot3)
                    {
                        pbEn3Shoot.Location = new Point((mov[2, 0] + 55), (mov[2, 1] + 66));
                        pbEn3Shoot.Visible = true;
                        colpo3 = true;
                        enshoot.Play();
                    }
                }
                else
                {
                    if (mov[2, 0] < shoot3)
                    {
                        pbEn3Shoot.Location = new Point((mov[2, 0] + 55), (mov[2, 1] + 66));
                        pbEn3Shoot.Visible = true;
                        colpo3 = true;
                        enshoot.Play();
                    }
                }
            }
        }

        private void tmrEnShoot_Tick(object sender, EventArgs e)
        {
            pbEn1Shoot.Location = new Point(pbEn1Shoot.Location.X, (pbEn1Shoot.Location.Y + 10));
            pbEn2Shoot.Location = new Point(pbEn2Shoot.Location.X, (pbEn2Shoot.Location.Y + 10));
            pbEn3Shoot.Location = new Point(pbEn3Shoot.Location.X, (pbEn3Shoot.Location.Y + 10));

            if(pbEn1Shoot.Bounds.IntersectsWith(pbMe.Bounds) && pbEn1Shoot.Visible)
            {
                points-=3;
                lblScore.Text = Convert.ToString(points);
                pbEn1Shoot.Visible = false;
                NoLife++;
                if (NoLife >= 2)
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
                            tmrShoot.Enabled = false;
                            tmrEnShoot.Enabled = false;
                            tmrBoomE1.Enabled = false;
                            tmrBoomE2.Enabled = false;
                            tmrBoomE3.Enabled = false;
                            pbEnemy1.Visible = false;
                            pbEnemy2.Visible = false;
                            pbEnemy3.Visible = false;
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
            }
            if (pbEn2Shoot.Bounds.IntersectsWith(pbMe.Bounds) && pbEn2Shoot.Visible)
            {
                points-=3;
                lblScore.Text = Convert.ToString(points);
                pbEn2Shoot.Visible = false;
                NoLife++;
                if (NoLife >= 2)
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
                            tmrShoot.Enabled = false;
                            tmrEnShoot.Enabled = false;
                            tmrBoomE1.Enabled = false;
                            tmrBoomE2.Enabled = false;
                            tmrBoomE3.Enabled = false;
                            pbEnemy1.Visible = false;
                            pbEnemy2.Visible = false;
                            pbEnemy3.Visible = false;
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
            }
            if (pbEn3Shoot.Bounds.IntersectsWith(pbMe.Bounds) && pbEn3Shoot.Visible)
            {
                points-=3;
                lblScore.Text = Convert.ToString(points);
                pbEn3Shoot.Visible = false;
                NoLife++;
                if (NoLife >= 5)
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
                            tmrMov.Enabled = false;
                            tmrShoot.Enabled = false;
                            tmrEnShoot.Enabled = false;
                            tmrBoomE1.Enabled = false;
                            tmrBoomE2.Enabled = false;
                            tmrBoomE3.Enabled = false;
                            pbEnemy1.Visible = false;
                            pbEnemy2.Visible = false;
                            pbEnemy3.Visible = false;
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
            }

            if (pbEn1Shoot.Location.Y > 720)
            {
                pbEn1Shoot.Visible = false;
            }
            if (pbEn2Shoot.Location.Y > 720)
            {
                pbEn2Shoot.Visible = false;
            }
            if (pbEn3Shoot.Location.Y > 720)
            {
                pbEn3Shoot.Visible = false;
            }
        }

        private void tmrTotal_Tick(object sender, EventArgs e)
        {
            StopSound();
            pbEnemy1.Visible = false;
            pbEnemy2.Visible = false;
            pbEnemy3.Visible = false;
            pbEn1Shoot.Visible = false;
            pbEn2Shoot.Visible = false;
            pbEn3Shoot.Visible = false;
            tmrMov.Enabled = false;
            tmrShoot.Enabled = false;
            tmrEnShoot.Enabled = false;
            tmrBoomE1.Enabled = false;
            tmrBoomE2.Enabled = false;
            tmrBoomE3.Enabled = false;
            if (!lost)
            {
                lblWin.Visible = true;
                frmMain.score += points;
            }
            btnExit.Visible = true;
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
