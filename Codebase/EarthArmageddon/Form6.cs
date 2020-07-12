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
    public partial class frmHelp : Form
    {
        bool NotFound = false;

        public frmHelp()
        {
            InitializeComponent();
        }

        private void pbUpArrow_MouseHover(object sender, EventArgs e)
        {
            lblUpInfo.Visible = true;
        }

        private void pbUpArrow_MouseLeave(object sender, EventArgs e)
        {
            lblUpInfo.Visible = false;
        }

        private void pbDownArrow_MouseHover(object sender, EventArgs e)
        {
            lblDownInfo.Visible = true;
        }

        private void pbDownArrow_MouseLeave(object sender, EventArgs e)
        {
            lblDownInfo.Visible = false;
        }

        private void pbRightArrow_MouseHover(object sender, EventArgs e)
        {
            lblRightInfo.Visible = true;
        }

        private void pbRightArrow_MouseLeave(object sender, EventArgs e)
        {
            lblRightInfo.Visible = false;
        }

        private void pbLeftArrow_MouseHover(object sender, EventArgs e)
        {
            lblLeftInfo.Visible = true;
        }

        private void pbLeftArrow_MouseLeave(object sender, EventArgs e)
        {
            lblLeftInfo.Visible = false;
        }

        private void pbSpacebar_MouseHover(object sender, EventArgs e)
        {
            lblSpacebarInfo.Visible = true;
        }

        private void pbSpacebar_MouseLeave(object sender, EventArgs e)
        {
            lblSpacebarInfo.Visible = false;
        }

        private void pbZButton_MouseHover(object sender, EventArgs e)
        {
            lblZInfo.Visible = true;
        }

        private void pbZButton_MouseLeave(object sender, EventArgs e)
        {
            lblZInfo.Visible = false;
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            try
            {
                pfc.AddFontFile(@"C:\EarthArmageddonFonts\bgothl.ttf");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Font not found! The game interface could appear quite different.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NotFound = true;
            }
            if (!NotFound)
            {
                if (frmMain.lang == 3)
                {
                    lblGeneral.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
                }
                else
                {
                    lblGeneral.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                    lblGeneral.Location = new Point((740 - lblGeneral.Size.Width) / 2, 362);
                }
            }
            NotFound = false;

            PrivateFontCollection pfc2 = new PrivateFontCollection();
            try
            {
                pfc2.AddFontFile(@"C:\EarthArmageddonFonts\tt0586m_.ttf");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Font not found! The game interface could appear quite different.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NotFound = true;
            }
            if (!NotFound)
            {
                lblUpInfo.Font = new Font(pfc2.Families[0], 12, FontStyle.Regular);
                lblDownInfo.Font = new Font(pfc2.Families[0], 12, FontStyle.Regular);
                lblRightInfo.Font = new Font(pfc2.Families[0], 12, FontStyle.Regular);
                lblLeftInfo.Font = new Font(pfc2.Families[0], 12, FontStyle.Regular);
                lblZInfo.Font = new Font(pfc2.Families[0], 12, FontStyle.Regular);
                lblSpacebarInfo.Font = new Font(pfc2.Families[0], 12, FontStyle.Regular);
                lblPInfo.Font = new Font(pfc2.Families[0], 12, FontStyle.Regular);
            }
            NotFound = false;

            switch (frmMain.lang)
            {
                case 1:
                    lblGeneral.Text = "Sposta il cursore su un tasto per ottenere informazioni";
                    lblUpInfo.Text = "Sposta la navicella in avanti";
                    lblDownInfo.Text = "Sposta la navicella indietro";
                    lblRightInfo.Text = "Sposta la navicella a destra";
                    lblLeftInfo.Text = "Sposta la navicella a sinistra";
                    lblSpacebarInfo.Text = "Spara";
                    lblZInfo.Text = "Spara";
                    lblPInfo.Text = "Metti in pausa il gioco";
                    break;

                case 2:
                    lblGeneral.Text = "Move the cursor on a button to get information";
                    lblUpInfo.Text = "Move the spaceship forward";
                    lblDownInfo.Text = "Move the spaceship backward";
                    lblRightInfo.Text = "Move the spaceship on right";
                    lblLeftInfo.Text = "Move the spaceship on left";
                    lblSpacebarInfo.Text = "Shoot";
                    lblZInfo.Text = "Shoot";
                    lblPInfo.Text = "Pause the game";
                    break;

                case 3:
                    lblGeneral.Text = "Déplacez le curseur sur un bouton pour obtenir des informations";
                    lblGeneral.Location = new Point(18, 362);
                    lblUpInfo.Text = "Déplacez le navire à l'avant";
                    lblDownInfo.Text = "Déplacez le navire en arrière";
                    lblRightInfo.Text = "Déplacez le navire à droite";
                    lblLeftInfo.Text = "Déplacez le navire à gauche";
                    lblSpacebarInfo.Text = "Dècocher";
                    lblZInfo.Text = "Dècocher";
                    lblPInfo.Text = "Mettre en pause le jeu";
                    break;

                case 4:
                    lblGeneral.Text = "حرك المؤشر فوق زر للحصول على المعلومات";
                    lblUpInfo.Text = "نقل السفينة إلى الأمام";
                    lblDownInfo.Text = "نقل المركبة الفضائية خلف";
                    lblRightInfo.Text = "نقل المركبة الفضائية إلى اليمين";
                    lblLeftInfo.Text = "نقل المركبة الفضائية إلى اليسار";
                    lblSpacebarInfo.Text = "أطلق النار";
                    lblZInfo.Text = "أطلق النار";
                    lblPInfo.Text = "توقف المباراة";
                    break;
            }
        }

        private void pbPButton_MouseHover(object sender, EventArgs e)
        {
            lblPInfo.Visible = true;
        }

        private void pbPButton_MouseLeave(object sender, EventArgs e)
        {
            lblPInfo.Visible = false;
        }

    }
}
