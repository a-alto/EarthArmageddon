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
    

    public partial class frmMain : Form
    {

        public static string FileName = "save.dat";
        public static string MusicPath = "menu.wav";
        public static string name;
        public static int level;
        public static int score = 0;
        public static double levelAUS=1.0;
        public static double scoreAUS=0.0;
        public static int lang = 1;
        public static bool uscita = false;
        

        public frmMain()
        {
            InitializeComponent();
        }

        public static void SaveData()
        {
            levelAUS = Convert.ToDouble(level);
            scoreAUS = Convert.ToDouble(score);
            levelAUS = ((((((level / 13.0) * 11.0) / 7.0) / 13.0) * 17.0) / 19.0);
            scoreAUS = ((((((score * 7.0) / 13.0) * 29.0) / 17.0) * 23.0) / 31.0);

            using (StreamWriter save = new StreamWriter(FileName))
            {
                save.WriteLine(name); // save name
                save.WriteLine(Convert.ToString(lang)); // save language
                save.WriteLine(Convert.ToString(levelAUS)); // save level
                save.WriteLine(Convert.ToString(scoreAUS)); // save score
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExit_MouseDown(object sender, MouseEventArgs e)
        {
            pbExit.Image = new Bitmap("buttonExit_pressed_R.png");
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = new Bitmap("buttonExit_R.png");
        }

        private void pbNew_MouseDown(object sender, MouseEventArgs e)
        {
            pbNew.Image = new Bitmap("buttonNewGame_pressed_R.png");
        }

        private void pbNew_MouseLeave(object sender, EventArgs e)
        {
            pbNew.Image = new Bitmap("buttonNewGame_R.png");
        }

        private void pbLoad_MouseDown(object sender, MouseEventArgs e)
        {
            pbLoad.Image = new Bitmap("buttonLoad_pressed_R.png");
        }

        private void pbLoad_MouseLeave(object sender, EventArgs e)
        {
            pbLoad.Image = new Bitmap("buttonLoad_R.png");
        }

        private void pbLang_MouseDown(object sender, MouseEventArgs e)
        {
            pbLang.Image = new Bitmap("buttonLanguages_pressed_R.png");
        }

        private void pbLang_MouseLeave(object sender, EventArgs e)
        {
            pbLang.Image = new Bitmap("buttonLanguages_R.png");
        }

        private void pbNew_MouseUp(object sender, MouseEventArgs e)
        {
            pbNew.Image = new Bitmap("buttonNewGame_R.png");
        }

        private void pbLoad_MouseUp(object sender, MouseEventArgs e)
        {
            pbLoad.Image = new Bitmap("buttonLoad_R.png");
        }

        private void pbLang_MouseUp(object sender, MouseEventArgs e)
        {
            pbLang.Image = new Bitmap("buttonLanguages_R.png");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /*menuWP.URL = MusicPath;
            menuWP.Ctlcontrols.play();*/
        }

        private void pbNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("By starting a new game, saved data will lost. Do you want to continue ?", "New Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                levelAUS = ((((((1.0 / 13.0) * 11.0) / 7.0) / 13.0) * 17.0) / 19.0);
                scoreAUS = 0;

                level = 1;
                score = 0;

                using (StreamWriter save = new StreamWriter(FileName))
                {
                    save.WriteLine(""); // new void name
                    save.WriteLine(Convert.ToString(lang)); // language
                    save.WriteLine(Convert.ToString(levelAUS)); // restart level
                    save.WriteLine(Convert.ToString(scoreAUS)); // new zero score
                }

                //menuWP.Ctlcontrols.stop();
                this.Hide();
                frmIntroduction intro = new frmIntroduction();
                intro.ShowDialog();
                frmName name = new frmName();
                name.ShowDialog();
                frmGame games = new frmGame();
                try
                {
                    games.ShowDialog();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("There was an error. Reopen the game!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                this.Close();
            }
            else
            {

            } 
        }

        private void pbLoad_Click(object sender, EventArgs e)
        {
            using (StreamReader loaderData = new StreamReader(FileName))
            {
                name = loaderData.ReadLine(); // load name
                lang = Convert.ToInt32(loaderData.ReadLine()); // load language
                levelAUS = Convert.ToDouble(loaderData.ReadLine()); // load level
                scoreAUS = Convert.ToDouble(loaderData.ReadLine()); // load score
            }

            level = Convert.ToInt32(((((((levelAUS * 19.0) / 17.0) * 13.0) * 7.0) / 11.0) * 13.0));
            score = Convert.ToInt32(((((((scoreAUS * 31.0) / 23.0) * 17.0) / 29.0) * 13.0) / 7.0));

            //menuWP.Ctlcontrols.stop();
            frmGame games = new frmGame();
            this.Hide();
            try
            {
                games.ShowDialog();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error. Reopen the game!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            this.Close();
        }

        private void pbLang_Click(object sender, EventArgs e)
        {
            frmLanguages langs=new frmLanguages();
            langs.ShowDialog();
        }

        private void tmrMenuSound_Tick(object sender, EventArgs e)
        {
            //menuWP.URL = "menu.wav";
        }




        
    }
}
