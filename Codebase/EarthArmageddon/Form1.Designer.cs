namespace EarthArmageddon
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbNew = new System.Windows.Forms.PictureBox();
            this.pbLoad = new System.Windows.Forms.PictureBox();
            this.pbLang = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.tmrMenuSound = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbNew
            // 
            this.pbNew.BackColor = System.Drawing.Color.Transparent;
            this.pbNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNew.Image = ((System.Drawing.Image)(resources.GetObject("pbNew.Image")));
            this.pbNew.Location = new System.Drawing.Point(140, 54);
            this.pbNew.Name = "pbNew";
            this.pbNew.Size = new System.Drawing.Size(200, 60);
            this.pbNew.TabIndex = 1;
            this.pbNew.TabStop = false;
            this.pbNew.Click += new System.EventHandler(this.pbNew_Click);
            this.pbNew.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbNew_MouseDown);
            this.pbNew.MouseLeave += new System.EventHandler(this.pbNew_MouseLeave);
            this.pbNew.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbNew_MouseUp);
            // 
            // pbLoad
            // 
            this.pbLoad.BackColor = System.Drawing.Color.Transparent;
            this.pbLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLoad.Image = ((System.Drawing.Image)(resources.GetObject("pbLoad.Image")));
            this.pbLoad.Location = new System.Drawing.Point(140, 147);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(200, 60);
            this.pbLoad.TabIndex = 2;
            this.pbLoad.TabStop = false;
            this.pbLoad.Click += new System.EventHandler(this.pbLoad_Click);
            this.pbLoad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLoad_MouseDown);
            this.pbLoad.MouseLeave += new System.EventHandler(this.pbLoad_MouseLeave);
            this.pbLoad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLoad_MouseUp);
            // 
            // pbLang
            // 
            this.pbLang.BackColor = System.Drawing.Color.Transparent;
            this.pbLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLang.Image = ((System.Drawing.Image)(resources.GetObject("pbLang.Image")));
            this.pbLang.Location = new System.Drawing.Point(140, 240);
            this.pbLang.Name = "pbLang";
            this.pbLang.Size = new System.Drawing.Size(200, 60);
            this.pbLang.TabIndex = 3;
            this.pbLang.TabStop = false;
            this.pbLang.Click += new System.EventHandler(this.pbLang_Click);
            this.pbLang.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLang_MouseDown);
            this.pbLang.MouseLeave += new System.EventHandler(this.pbLang_MouseLeave);
            this.pbLang.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLang_MouseUp);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(140, 333);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(200, 60);
            this.pbExit.TabIndex = 4;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbExit_MouseDown);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            // 
            // tmrMenuSound
            // 
            this.tmrMenuSound.Enabled = true;
            this.tmrMenuSound.Interval = 17000;
            this.tmrMenuSound.Tick += new System.EventHandler(this.tmrMenuSound_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(474, 435);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbLang);
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.pbNew);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Earth Armageddon";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbNew;
        private System.Windows.Forms.PictureBox pbLoad;
        private System.Windows.Forms.PictureBox pbLang;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Timer tmrMenuSound;

    }
}

