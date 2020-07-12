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
    public partial class frmName : Form
    {
        bool NotFound = false;

        public frmName()
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

        private void frmName_Load(object sender, EventArgs e)
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
                lblInsertName.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                btnOKName.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
            }
            NotFound = false;

            PrivateFontCollection pfc2 = new PrivateFontCollection();
            try
            {
                pfc2.AddFontFile(@"C:\EarthArmageddonFonts\CODEb.ttf");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Font not found! The game interface could appear quite different.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NotFound = true;
            }
            if (!NotFound)
            {
                txtName.Font = new Font(pfc2.Families[0], 12, FontStyle.Bold);
            }
            NotFound = false;

            switch (frmMain.lang)
            {
                case 1:
                    lblInsertName.Text = "Immetti il tuo nome";
                    btnOKName.Text = "Conferma";
                    break; // ita

                case 2:
                    lblInsertName.Text = "Enter your name";
                    btnOKName.Text = "Confirm";
                    break; // eng

                case 3:
                    lblInsertName.Text = "Entrez votre nom";
                    btnOKName.Text = "Confirmation";
                    break; // fra

                case 4:
                    lblInsertName.Text = "أدخل أسمك";
                    btnOKName.Text = "التأكيد";
                    break; // arab
            }
        }

        private void btnOKName_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                frmMain.name = txtName.Text;
                using (StreamWriter save = new StreamWriter(frmMain.FileName))
                {
                    save.WriteLine(frmMain.name); // save name
                    save.WriteLine(Convert.ToString(frmMain.lang)); // save language
                    save.WriteLine(Convert.ToString(frmMain.levelAUS)); // save  level
                    save.WriteLine(Convert.ToString(frmMain.scoreAUS)); // save score
                }

                this.Close();
            }
            else
            {
                switch (frmMain.lang)
                {
                    case 1:
                        MessageBox.Show("Inserire un nome!");
                        break;

                    case 2:
                        MessageBox.Show("Enter a name!");
                        break;

                    case 3:
                        MessageBox.Show("Insère un nom!");
                        break;

                    case 4:
                        MessageBox.Show("أدخل اسمك");
                        break;
                }
            }
        }
    }
}
