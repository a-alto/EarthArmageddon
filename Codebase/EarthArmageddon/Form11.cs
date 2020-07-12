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
    public partial class frmPause : Form
    {
        bool NotFound = false;
        SoundPlayer sound = new SoundPlayer();

        public frmPause()
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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to leave the game? If you quit now, you'll lose the data of this game!", "QUIT", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmMain.uscita = true;
                sound.Stop();
                this.Close();
            }
            else
            {
                
            }
        }

        private void frmPause_Load(object sender, EventArgs e)
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
                lblPause.Font = new Font(pfc.Families[0], 72, FontStyle.Regular);
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
                btnContinue.Font = new Font(pfc2.Families[0], 16, FontStyle.Regular);
                btnExit.Font = new Font(pfc2.Families[0], 16, FontStyle.Regular);
            }
            NotFound = false;

            switch (frmMain.lang)
            {
                case 1:
                    lblPause.Text = "PAUSA";
                    btnContinue.Text = "Continua";
                    btnExit.Text = "Abbandona";
                    break;

                case 2:
                    lblPause.Text = "PAUSE";
                    btnContinue.Text = "Continue";
                    btnExit.Text = "Quit";
                    break;

                case 3:
                    lblPause.Text = "PAUSE";
                    btnContinue.Text = "Continue";
                    btnExit.Text = "Feuilles";
                    break;

                case 4:
                    lblPause.Text = "وقفة";
                    btnContinue.Text = "تواصل";
                    btnExit.Text = "ترك";
                    lblPause.Location = new Point((713 - lblPause.Size.Width) / 2, lblPause.Location.Y);
                    break;
            } // end switch
        }
    }
}
