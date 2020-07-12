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
    public partial class frmIntroduction : Form
    {
        bool NotFound = false;

        public frmIntroduction()
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

        private void frmIntroduction_Load(object sender, EventArgs e)
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
                btnStart.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            }
            NotFound = false;

            switch (frmMain.lang)
            {
                case 1:
                    txtStoryIta.Visible = true;
                    btnStart.Text = "Inizia";
                    break; // ita

                case 2:
                    txtStoryEng.Visible = true;
                    btnStart.Text = "Start";
                    break; // eng

                case 3:
                    txtStoryFra.Visible = true;
                    btnStart.Text = "Commence";
                    break; // fra

                case 4:
                    txtStoryArab.Visible = true;
                    btnStart.Text = "بداية";
                    break; // arab
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
