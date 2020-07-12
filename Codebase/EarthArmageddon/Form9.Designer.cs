﻿namespace EarthArmageddon
{
    partial class frmLevel3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevel3));
            this.pnSX = new System.Windows.Forms.Panel();
            this.pbPause = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.pbLife4 = new System.Windows.Forms.PictureBox();
            this.pbLife1 = new System.Windows.Forms.PictureBox();
            this.pbLife3 = new System.Windows.Forms.PictureBox();
            this.lblLife = new System.Windows.Forms.Label();
            this.pbLife2 = new System.Windows.Forms.PictureBox();
            this.pbMe = new System.Windows.Forms.PictureBox();
            this.pbEnemy1 = new System.Windows.Forms.PictureBox();
            this.pbEnemy2 = new System.Windows.Forms.PictureBox();
            this.pbShoot = new System.Windows.Forms.PictureBox();
            this.pbEn1Shoot = new System.Windows.Forms.PictureBox();
            this.pbEn2Shoot = new System.Windows.Forms.PictureBox();
            this.pbBlast1 = new System.Windows.Forms.PictureBox();
            this.pbBlast2 = new System.Windows.Forms.PictureBox();
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.tmrMov = new System.Windows.Forms.Timer(this.components);
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.tmrTotal = new System.Windows.Forms.Timer(this.components);
            this.tmrEnShoot = new System.Windows.Forms.Timer(this.components);
            this.tmrBoomE1 = new System.Windows.Forms.Timer(this.components);
            this.tmrBoomE2 = new System.Windows.Forms.Timer(this.components);
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tmrBlast = new System.Windows.Forms.Timer(this.components);
            this.pnSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEn1Shoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEn2Shoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlast1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlast2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSX
            // 
            this.pnSX.BackColor = System.Drawing.Color.Transparent;
            this.pnSX.Controls.Add(this.pbPause);
            this.pnSX.Controls.Add(this.lblScore);
            this.pnSX.Controls.Add(this.lblS);
            this.pnSX.Controls.Add(this.pbLife4);
            this.pnSX.Controls.Add(this.pbLife1);
            this.pnSX.Controls.Add(this.pbLife3);
            this.pnSX.Controls.Add(this.lblLife);
            this.pnSX.Controls.Add(this.pbLife2);
            this.pnSX.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSX.Location = new System.Drawing.Point(0, 0);
            this.pnSX.Name = "pnSX";
            this.pnSX.Size = new System.Drawing.Size(1280, 68);
            this.pnSX.TabIndex = 4;
            // 
            // pbPause
            // 
            this.pbPause.BackColor = System.Drawing.Color.Transparent;
            this.pbPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPause.Image = ((System.Drawing.Image)(resources.GetObject("pbPause.Image")));
            this.pbPause.Location = new System.Drawing.Point(1217, 3);
            this.pbPause.Name = "pbPause";
            this.pbPause.Size = new System.Drawing.Size(60, 60);
            this.pbPause.TabIndex = 9;
            this.pbPause.TabStop = false;
            this.pbPause.Click += new System.EventHandler(this.pbPause_Click);
            this.pbPause.MouseLeave += new System.EventHandler(this.pbPause_MouseLeave);
            this.pbPause.MouseHover += new System.EventHandler(this.pbPause_MouseHover);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Modern Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(481, 21);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(26, 27);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("FREEDOM", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.ForeColor = System.Drawing.Color.White;
            this.lblS.Location = new System.Drawing.Point(353, 24);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(122, 19);
            this.lblS.TabIndex = 8;
            this.lblS.Text = "Punti:";
            // 
            // pbLife4
            // 
            this.pbLife4.BackColor = System.Drawing.Color.Transparent;
            this.pbLife4.Image = ((System.Drawing.Image)(resources.GetObject("pbLife4.Image")));
            this.pbLife4.Location = new System.Drawing.Point(223, 20);
            this.pbLife4.Name = "pbLife4";
            this.pbLife4.Size = new System.Drawing.Size(30, 29);
            this.pbLife4.TabIndex = 8;
            this.pbLife4.TabStop = false;
            // 
            // pbLife1
            // 
            this.pbLife1.BackColor = System.Drawing.Color.Transparent;
            this.pbLife1.Image = ((System.Drawing.Image)(resources.GetObject("pbLife1.Image")));
            this.pbLife1.Location = new System.Drawing.Point(115, 20);
            this.pbLife1.Name = "pbLife1";
            this.pbLife1.Size = new System.Drawing.Size(30, 29);
            this.pbLife1.TabIndex = 7;
            this.pbLife1.TabStop = false;
            // 
            // pbLife3
            // 
            this.pbLife3.BackColor = System.Drawing.Color.Transparent;
            this.pbLife3.Image = ((System.Drawing.Image)(resources.GetObject("pbLife3.Image")));
            this.pbLife3.Location = new System.Drawing.Point(187, 20);
            this.pbLife3.Name = "pbLife3";
            this.pbLife3.Size = new System.Drawing.Size(30, 29);
            this.pbLife3.TabIndex = 8;
            this.pbLife3.TabStop = false;
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Font = new System.Drawing.Font("FREEDOM", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife.ForeColor = System.Drawing.Color.White;
            this.lblLife.Location = new System.Drawing.Point(12, 24);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(97, 19);
            this.lblLife.TabIndex = 7;
            this.lblLife.Text = "Vite:";
            // 
            // pbLife2
            // 
            this.pbLife2.BackColor = System.Drawing.Color.Transparent;
            this.pbLife2.Image = ((System.Drawing.Image)(resources.GetObject("pbLife2.Image")));
            this.pbLife2.Location = new System.Drawing.Point(151, 20);
            this.pbLife2.Name = "pbLife2";
            this.pbLife2.Size = new System.Drawing.Size(30, 29);
            this.pbLife2.TabIndex = 8;
            this.pbLife2.TabStop = false;
            // 
            // pbMe
            // 
            this.pbMe.BackColor = System.Drawing.Color.Transparent;
            this.pbMe.Image = ((System.Drawing.Image)(resources.GetObject("pbMe.Image")));
            this.pbMe.Location = new System.Drawing.Point(180, 333);
            this.pbMe.Name = "pbMe";
            this.pbMe.Size = new System.Drawing.Size(73, 55);
            this.pbMe.TabIndex = 5;
            this.pbMe.TabStop = false;
            this.pbMe.Visible = false;
            // 
            // pbEnemy1
            // 
            this.pbEnemy1.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy1.Image = ((System.Drawing.Image)(resources.GetObject("pbEnemy1.Image")));
            this.pbEnemy1.Location = new System.Drawing.Point(960, 144);
            this.pbEnemy1.Name = "pbEnemy1";
            this.pbEnemy1.Size = new System.Drawing.Size(115, 84);
            this.pbEnemy1.TabIndex = 6;
            this.pbEnemy1.TabStop = false;
            this.pbEnemy1.Visible = false;
            this.pbEnemy1.LocationChanged += new System.EventHandler(this.pbEnemy1_LocationChanged);
            // 
            // pbEnemy2
            // 
            this.pbEnemy2.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy2.Image = ((System.Drawing.Image)(resources.GetObject("pbEnemy2.Image")));
            this.pbEnemy2.Location = new System.Drawing.Point(960, 391);
            this.pbEnemy2.Name = "pbEnemy2";
            this.pbEnemy2.Size = new System.Drawing.Size(115, 84);
            this.pbEnemy2.TabIndex = 7;
            this.pbEnemy2.TabStop = false;
            this.pbEnemy2.Visible = false;
            this.pbEnemy2.LocationChanged += new System.EventHandler(this.pbEnemy2_LocationChanged);
            // 
            // pbShoot
            // 
            this.pbShoot.BackColor = System.Drawing.Color.Yellow;
            this.pbShoot.Location = new System.Drawing.Point(259, 358);
            this.pbShoot.Name = "pbShoot";
            this.pbShoot.Size = new System.Drawing.Size(34, 5);
            this.pbShoot.TabIndex = 8;
            this.pbShoot.TabStop = false;
            this.pbShoot.Visible = false;
            // 
            // pbEn1Shoot
            // 
            this.pbEn1Shoot.BackColor = System.Drawing.Color.Blue;
            this.pbEn1Shoot.Location = new System.Drawing.Point(742, 214);
            this.pbEn1Shoot.Name = "pbEn1Shoot";
            this.pbEn1Shoot.Size = new System.Drawing.Size(34, 5);
            this.pbEn1Shoot.TabIndex = 14;
            this.pbEn1Shoot.TabStop = false;
            this.pbEn1Shoot.Visible = false;
            // 
            // pbEn2Shoot
            // 
            this.pbEn2Shoot.BackColor = System.Drawing.Color.Blue;
            this.pbEn2Shoot.Location = new System.Drawing.Point(920, 437);
            this.pbEn2Shoot.Name = "pbEn2Shoot";
            this.pbEn2Shoot.Size = new System.Drawing.Size(34, 5);
            this.pbEn2Shoot.TabIndex = 17;
            this.pbEn2Shoot.TabStop = false;
            this.pbEn2Shoot.Visible = false;
            // 
            // pbBlast1
            // 
            this.pbBlast1.BackColor = System.Drawing.Color.Transparent;
            this.pbBlast1.Image = ((System.Drawing.Image)(resources.GetObject("pbBlast1.Image")));
            this.pbBlast1.Location = new System.Drawing.Point(934, 179);
            this.pbBlast1.Name = "pbBlast1";
            this.pbBlast1.Size = new System.Drawing.Size(20, 20);
            this.pbBlast1.TabIndex = 18;
            this.pbBlast1.TabStop = false;
            this.pbBlast1.Visible = false;
            // 
            // pbBlast2
            // 
            this.pbBlast2.BackColor = System.Drawing.Color.Transparent;
            this.pbBlast2.Image = ((System.Drawing.Image)(resources.GetObject("pbBlast2.Image")));
            this.pbBlast2.Location = new System.Drawing.Point(894, 422);
            this.pbBlast2.Name = "pbBlast2";
            this.pbBlast2.Size = new System.Drawing.Size(20, 20);
            this.pbBlast2.TabIndex = 19;
            this.pbBlast2.TabStop = false;
            this.pbBlast2.Visible = false;
            // 
            // tmrShoot
            // 
            this.tmrShoot.Interval = 10;
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // tmrMov
            // 
            this.tmrMov.Interval = 30;
            this.tmrMov.Tick += new System.EventHandler(this.tmrMov_Tick);
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Enabled = true;
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // tmrTotal
            // 
            this.tmrTotal.Interval = 120000;
            this.tmrTotal.Tick += new System.EventHandler(this.tmrTotal_Tick);
            // 
            // tmrEnShoot
            // 
            this.tmrEnShoot.Interval = 10;
            this.tmrEnShoot.Tick += new System.EventHandler(this.tmrEnShoot_Tick);
            // 
            // tmrBoomE1
            // 
            this.tmrBoomE1.Interval = 500;
            this.tmrBoomE1.Tick += new System.EventHandler(this.tmrBoomE1_Tick);
            // 
            // tmrBoomE2
            // 
            this.tmrBoomE2.Interval = 500;
            this.tmrBoomE2.Tick += new System.EventHandler(this.tmrBoomE2_Tick);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Black;
            this.lblCountdown.Font = new System.Drawing.Font("BankGothic Md BT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.White;
            this.lblCountdown.Location = new System.Drawing.Point(582, 310);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(117, 101);
            this.lblCountdown.TabIndex = 20;
            this.lblCountdown.Text = "5";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("BankGothic Md BT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(293, 310);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(695, 101);
            this.lblGameOver.TabIndex = 21;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("BankGothic Md BT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.White;
            this.lblWin.Location = new System.Drawing.Point(320, 310);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(641, 101);
            this.lblWin.TabIndex = 22;
            this.lblWin.Text = "HAI VINTO!";
            this.lblWin.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("FREEDOM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(577, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 39);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Esci";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmrBlast
            // 
            this.tmrBlast.Interval = 200;
            this.tmrBlast.Tick += new System.EventHandler(this.tmrBlast_Tick);
            // 
            // frmLevel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.pbBlast2);
            this.Controls.Add(this.pbBlast1);
            this.Controls.Add(this.pbEn2Shoot);
            this.Controls.Add(this.pbEn1Shoot);
            this.Controls.Add(this.pbShoot);
            this.Controls.Add(this.pbEnemy2);
            this.Controls.Add(this.pbEnemy1);
            this.Controls.Add(this.pbMe);
            this.Controls.Add(this.pnSX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLevel3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Earth Armageddon - Level 3";
            this.Load += new System.EventHandler(this.frmLevel3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLevel3_KeyDown);
            this.pnSX.ResumeLayout(false);
            this.pnSX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEn1Shoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEn2Shoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlast1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlast2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnSX;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.PictureBox pbLife4;
        private System.Windows.Forms.PictureBox pbLife3;
        private System.Windows.Forms.PictureBox pbLife2;
        private System.Windows.Forms.PictureBox pbLife1;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.PictureBox pbPause;
        private System.Windows.Forms.PictureBox pbMe;
        private System.Windows.Forms.PictureBox pbEnemy1;
        private System.Windows.Forms.PictureBox pbEnemy2;
        private System.Windows.Forms.PictureBox pbShoot;
        private System.Windows.Forms.PictureBox pbEn1Shoot;
        private System.Windows.Forms.PictureBox pbEn2Shoot;
        private System.Windows.Forms.PictureBox pbBlast1;
        private System.Windows.Forms.PictureBox pbBlast2;
        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.Timer tmrMov;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.Timer tmrTotal;
        private System.Windows.Forms.Timer tmrEnShoot;
        private System.Windows.Forms.Timer tmrBoomE1;
        private System.Windows.Forms.Timer tmrBoomE2;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer tmrBlast;
    }
}