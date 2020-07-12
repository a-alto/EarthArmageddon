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
    public partial class frmGame : Form
    {
        int xP1; // x position planet 1
        int xP2; // x position planet 2
        int xP3; // x position planet 3
        int xP4; // x position planet 4
        int levelSelected; // selected level
        int auxiliary = frmMain.score;
        bool NotFound = false;

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            try
            {
                pfc.AddFontFile(@"C:\EarthArmageddonFonts\Xolonium-Regular.ttf");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Font not found! The game interface could appear quite different.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NotFound = true;
            }
            if (!NotFound)
            {
                lblN.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                lblS.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            }
            NotFound = false;

            PrivateFontCollection pfc2 = new PrivateFontCollection();
            try
            {
                pfc2.AddFontFile(@"C:\EarthArmageddonFonts\bgothm.ttf");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Font not found! The game interface could appear quite different.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NotFound = true;
            }
            if (!NotFound)
            {
                lblName.Font = new Font(pfc2.Families[0], 21, FontStyle.Regular);
                lblScore.Font = new Font(pfc2.Families[0], 21, FontStyle.Regular);
            }
            NotFound = false;

            PrivateFontCollection pfc3 = new PrivateFontCollection();
            try
            {
                pfc3.AddFontFile(@"C:\EarthArmageddonFonts\ANDROIDROBOT.ttf");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Font not found! The game interface could appear quite different.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NotFound = true;
            }
            if (!NotFound)
            {
                lblUnknown.Font = new Font(pfc3.Families[0], 24, FontStyle.Regular);
            }
            NotFound = false;

            switch (frmMain.lang)
            {
                case 1:
                    lblN.Text = "Nome:";
                    lblS.Text = "Punti:";
                    break;

                case 2:
                    lblN.Text = "Name:";
                    lblS.Text = "Score:";
                    break;

                case 3:
                    lblN.Text = "Nom:";
                    lblS.Text = "Points:";
                    break;

                case 4:
                    lblN.Location = new Point(825, 9);
                    lblS.Location = new Point(825, 39);
                    lblName.Location = new Point(692, 9);
                    lblScore.Location = new Point(726, 39);
                    lblN.Text = "اسم";
                    lblS.Text = "أحرز هدفا";
                    break;
            }


            lblName.Text = frmMain.name;
            lblScore.Text = Convert.ToString(frmMain.score);

            switch (frmMain.level)
            {
                case 1:
                    pbPlanet1.Location = new Point(395, 125);
                    pbPlanet2.Location = new Point(870, 125);
                    pbPlanet3.Location = new Point(1345, 125);
                    pbFinalPlanet.Location = new Point(1540, 89);
                    pbLock4.Location = new Point(1610, 125);
                    xP1 = 395;
                    xP2 = 870;
                    xP3 = 1345;
                    xP4 = 1540;
                    levelSelected = 1;
                    lblPlanet1.Visible = true;
                    break;

                case 2:
                    pbPlanet1.Location = new Point(-80, 125);
                    pbPlanet2.Location = new Point(395, 125);
                    pbPlanet3.Location = new Point(870, 125);
                    pbFinalPlanet.Location = new Point(1135, 89);
                    pbLock4.Location = new Point(1205, 125);
                    pbLock2.Visible = false;
                    xP1 = -80;
                    xP2 = 395;
                    xP3 = 870;
                    xP4 = 1135;
                    levelSelected = 2;
                    lblPlanet2.Visible = true;
                    break;

                case 3:
                    pbPlanet1.Location = new Point(-555, 125);
                    pbPlanet2.Location = new Point(-80, 125);
                    pbPlanet3.Location = new Point(395, 125);
                    pbFinalPlanet.Location = new Point(730, 89);
                    pbLock4.Location = new Point(800, 125);
                    pbLock2.Visible = false;
                    pbLock3.Visible = false;
                    xP1 = -555;
                    xP2 = -80;
                    xP3 = 395;
                    xP4 = 730;
                    levelSelected = 3;
                    lblPlanet3.Visible = true;
                    break;

                /*case 4:
                    pbPlanet1.Location = new Point(-1030, 125);
                    pbPlanet2.Location = new Point(-555, 125);
                    pbPlanet3.Location = new Point(-80, 125);
                    pbFinalPlanet.Location = new Point(325, 89);
                    pbLock4.Location = new Point(395, 125);
                    pbFinalPlanet.Visible = true;
                    pbLock2.Visible = false;
                    pbLock3.Visible = false;
                    pbLock4.Visible = false;
                    xP1 = -1030;
                    xP2 = -555;
                    xP3 = -80;
                    xP4 = 325;
                    levelSelected = 4;
                    break;*/
            }
        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (levelSelected != 3)
                {
                    xP1 -= 475;
                    xP2 -= 475;
                    xP3 -= 475;
                    xP4 -= 405;
                    levelSelected++;
                }
            } // end right case
            else if (e.KeyCode == Keys.Left)
            {
                if (levelSelected != 1)
                {
                    xP1 += 475;
                    xP2 += 475;
                    xP3 += 475;
                    xP4 += 405;
                    levelSelected--;
                }
            } // end left case

            // new position
            pbPlanet1.Location = new Point(xP1, 125);
            pbPlanet2.Location = new Point(xP2, 125);
            pbLock2.Location = new Point(xP2, 125);
            pbPlanet3.Location = new Point(xP3, 125);
            pbLock3.Location = new Point(xP3, 125);
            pbFinalPlanet.Location = new Point(xP4, 89);
            pbLock4.Location = new Point(xP4+70, 125);

            if (levelSelected > frmMain.level)
            {
                lblUnknown.Visible = true;
                lblPlanet1.Visible = false;
                lblPlanet2.Visible = false;
                lblPlanet3.Visible = false;
            }
            else
            {
                lblUnknown.Visible = false;
                switch (levelSelected)
                {
                    case 1:
                        lblPlanet1.Visible = true;
                        lblPlanet2.Visible = false;
                        lblPlanet3.Visible = false;
                        break;

                    case 2:
                        lblPlanet1.Visible = false;
                        lblPlanet2.Visible = true;
                        lblPlanet3.Visible = false;
                        break;

                    case 3:
                        lblPlanet1.Visible = false;
                        lblPlanet2.Visible = false;
                        lblPlanet3.Visible = true;
                        break;
                }
            }


            if (e.KeyCode == Keys.Enter)
            {
                if (levelSelected <= frmMain.level)
                {
                    switch (levelSelected)
                    {
                        case 1:
                            frmLevel1 lvl1 = new frmLevel1();
                            lvl1.ShowDialog();
                            if (!frmMain.uscita)
                            {
                                try
                                {
                                    lblScore.Text = Convert.ToString(frmMain.score);
                                }
                                catch (ArgumentException)
                                {

                                }
                                if (levelSelected == frmMain.level)
                                {
                                    if (frmMain.score > 200)
                                    {
                                        frmMain.level = 2;
                                        pbLock2.Visible = false;
                                    }
                                }
                                frmMain.SaveData();
                            }
                            else
                            {
                                frmMain.score = auxiliary;
                            }
                            break;

                        case 2:
                            frmLevel2 lvl2 = new frmLevel2();
                            lvl2.ShowDialog();
                            if (!frmMain.uscita)
                            {
                                try
                                {
                                    lblScore.Text = Convert.ToString(frmMain.score);
                                }
                                catch (ArgumentException)
                                {

                                }
                                if (levelSelected == frmMain.level)
                                {
                                    if (frmMain.score > 500)
                                    {
                                        frmMain.level = 3;
                                        pbLock3.Visible = false;
                                    }
                                }
                                frmMain.SaveData();
                            }
                            else
                            {
                                frmMain.score = auxiliary;
                            }
                            break;

                        case 3:
                            frmLevel3 lvl3 = new frmLevel3();
                            lvl3.ShowDialog();
                            if (!frmMain.uscita)
                            {
                                try
                                {
                                    lblScore.Text = Convert.ToString(frmMain.score);
                                }
                                catch (ArgumentException)
                                {

                                }
                                if (levelSelected == frmMain.level)
                                {
                                    if (frmMain.score > 800)
                                    {
                                        /*frmMain.level = 4;
                                        pbLock4.Visible = false;
                                        pbFinalPlanet.Visible = true;*/
                                    }
                                }
                                frmMain.SaveData();
                            }
                            else
                            {
                                frmMain.score = auxiliary;
                            }
                            break;

                        case 4:
                            frmLevel4 lvl4 = new frmLevel4();
                            lvl4.ShowDialog();
                            if (!frmMain.uscita)
                            {
                                lblScore.Text = Convert.ToString(frmMain.score);
                                frmMain.SaveData();
                            }
                            else
                            {
                                frmMain.score = auxiliary;
                            }
                            break;
                    }
                }
            }
        }

        private void pbHelp_MouseHover(object sender, EventArgs e)
        {
            pbHelp.Image = new Bitmap(@"HelpButton.png");
        }

        private void pbHelp_MouseLeave(object sender, EventArgs e)
        {
            pbHelp.Image = new Bitmap(@"HelpButton_n2.png");
        }

        private void pbHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        private void pbPlanet1_Click(object sender, EventArgs e)
        {
            if (levelSelected == 1)
            {
                frmLevel1 lvl1 = new frmLevel1();
                lvl1.ShowDialog();
                if (!frmMain.uscita)
                {
                    try
                    {
                        lblScore.Text = Convert.ToString(frmMain.score);
                    }
                    catch (ArgumentException)
                    {

                    }
                    frmMain.SaveData();
                }
                else
                {
                    frmMain.score = auxiliary;
                }
            }
        }

        private void pbPlanet2_Click(object sender, EventArgs e)
        {
            if (levelSelected == 2)
            {
                frmLevel2 lvl2 = new frmLevel2();
                lvl2.ShowDialog();
                if (!frmMain.uscita)
                {
                    lblScore.Text = Convert.ToString(frmMain.score);
                    frmMain.SaveData();
                }
                else
                {
                    frmMain.score = auxiliary;
                }
            }
        }

        private void pbPlanet3_Click(object sender, EventArgs e)
        {
            if (levelSelected == 3)
            {
                frmLevel3 lvl3 = new frmLevel3();
                lvl3.ShowDialog();
                if (!frmMain.uscita)
                {
                    lblScore.Text = Convert.ToString(frmMain.score);
                    frmMain.SaveData();
                }
                else
                {
                    frmMain.score = auxiliary;
                }
            }
        }

        private void pbFinalPlanet_Click(object sender, EventArgs e)
        {
            if (levelSelected == 4)
            {
                frmLevel4 lvl4 = new frmLevel4();
                lvl4.ShowDialog();
                if (!frmMain.uscita)
                {
                    lblScore.Text = Convert.ToString(frmMain.score);
                    frmMain.SaveData();
                }
                else
                {
                    frmMain.score = auxiliary;
                }
            }
        }


    }
}
