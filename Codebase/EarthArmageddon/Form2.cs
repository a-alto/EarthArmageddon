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
    public partial class frmLanguages : Form
    {
        bool NotFound = false;
        SoundPlayer select = new SoundPlayer("select4.wav");

        public frmLanguages()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMain.lang = 1;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMain.lang = 2;
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMain.lang = 3;
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmMain.lang = 4;
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            select.Play();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            select.Play();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            select.Play();
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pbUnderArab.Visible = true;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            select.Play();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pbUnderArab.Visible = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pbUnderIta.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pbUnderIta.Visible = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pbUnderEng.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pbUnderEng.Visible = false;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pbUnderFra.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pbUnderFra.Visible = false;
        }

        private void frmLanguages_Load(object sender, EventArgs e)
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
                lblTitle.Font = new Font(pfc.Families[0], 26, FontStyle.Regular);
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
                lblArabian.Font = new Font(pfc2.Families[0], 12, FontStyle.Regular);
            }
        }
    }
}
