namespace EarthArmageddon
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.pbSpaceShip = new System.Windows.Forms.PictureBox();
            this.pbFinalPlanet = new System.Windows.Forms.PictureBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbPlanet2 = new System.Windows.Forms.PictureBox();
            this.pbPlanet1 = new System.Windows.Forms.PictureBox();
            this.pbPlanet3 = new System.Windows.Forms.PictureBox();
            this.pbLock2 = new System.Windows.Forms.PictureBox();
            this.pbLock3 = new System.Windows.Forms.PictureBox();
            this.pbLock4 = new System.Windows.Forms.PictureBox();
            this.lblUnknown = new System.Windows.Forms.Label();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.lblPlanet1 = new System.Windows.Forms.Label();
            this.lblPlanet2 = new System.Windows.Forms.Label();
            this.lblPlanet3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinalPlanet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSpaceShip
            // 
            this.pbSpaceShip.BackColor = System.Drawing.Color.Transparent;
            this.pbSpaceShip.Image = ((System.Drawing.Image)(resources.GetObject("pbSpaceShip.Image")));
            this.pbSpaceShip.Location = new System.Drawing.Point(448, 402);
            this.pbSpaceShip.Name = "pbSpaceShip";
            this.pbSpaceShip.Size = new System.Drawing.Size(55, 73);
            this.pbSpaceShip.TabIndex = 1;
            this.pbSpaceShip.TabStop = false;
            // 
            // pbFinalPlanet
            // 
            this.pbFinalPlanet.BackColor = System.Drawing.Color.Transparent;
            this.pbFinalPlanet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFinalPlanet.Image = ((System.Drawing.Image)(resources.GetObject("pbFinalPlanet.Image")));
            this.pbFinalPlanet.Location = new System.Drawing.Point(1540, 89);
            this.pbFinalPlanet.Name = "pbFinalPlanet";
            this.pbFinalPlanet.Size = new System.Drawing.Size(300, 232);
            this.pbFinalPlanet.TabIndex = 2;
            this.pbFinalPlanet.TabStop = false;
            this.pbFinalPlanet.Visible = false;
            this.pbFinalPlanet.Click += new System.EventHandler(this.pbFinalPlanet_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.BackColor = System.Drawing.Color.Transparent;
            this.lblN.Font = new System.Drawing.Font("Xolonium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.Color.White;
            this.lblN.Location = new System.Drawing.Point(12, 9);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(107, 30);
            this.lblN.TabIndex = 3;
            this.lblN.Text = "Nome:";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.BackColor = System.Drawing.Color.Transparent;
            this.lblS.Font = new System.Drawing.Font("Xolonium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.ForeColor = System.Drawing.Color.White;
            this.lblS.Location = new System.Drawing.Point(12, 39);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(102, 30);
            this.lblS.TabIndex = 4;
            this.lblS.Text = "Punti:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("BankGothic Md BT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(125, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 30);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Andrea";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("BankGothic Md BT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(125, 39);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 30);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            // 
            // pbPlanet2
            // 
            this.pbPlanet2.BackColor = System.Drawing.Color.Transparent;
            this.pbPlanet2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlanet2.Image = ((System.Drawing.Image)(resources.GetObject("pbPlanet2.Image")));
            this.pbPlanet2.Location = new System.Drawing.Point(870, 125);
            this.pbPlanet2.Name = "pbPlanet2";
            this.pbPlanet2.Size = new System.Drawing.Size(160, 160);
            this.pbPlanet2.TabIndex = 7;
            this.pbPlanet2.TabStop = false;
            this.pbPlanet2.Click += new System.EventHandler(this.pbPlanet2_Click);
            // 
            // pbPlanet1
            // 
            this.pbPlanet1.BackColor = System.Drawing.Color.Transparent;
            this.pbPlanet1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlanet1.Image = ((System.Drawing.Image)(resources.GetObject("pbPlanet1.Image")));
            this.pbPlanet1.Location = new System.Drawing.Point(395, 125);
            this.pbPlanet1.Name = "pbPlanet1";
            this.pbPlanet1.Size = new System.Drawing.Size(160, 156);
            this.pbPlanet1.TabIndex = 8;
            this.pbPlanet1.TabStop = false;
            this.pbPlanet1.Click += new System.EventHandler(this.pbPlanet1_Click);
            // 
            // pbPlanet3
            // 
            this.pbPlanet3.BackColor = System.Drawing.Color.Transparent;
            this.pbPlanet3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlanet3.Image = ((System.Drawing.Image)(resources.GetObject("pbPlanet3.Image")));
            this.pbPlanet3.Location = new System.Drawing.Point(1345, 125);
            this.pbPlanet3.Name = "pbPlanet3";
            this.pbPlanet3.Size = new System.Drawing.Size(160, 159);
            this.pbPlanet3.TabIndex = 9;
            this.pbPlanet3.TabStop = false;
            this.pbPlanet3.Click += new System.EventHandler(this.pbPlanet3_Click);
            // 
            // pbLock2
            // 
            this.pbLock2.BackColor = System.Drawing.Color.Transparent;
            this.pbLock2.Cursor = System.Windows.Forms.Cursors.No;
            this.pbLock2.Image = ((System.Drawing.Image)(resources.GetObject("pbLock2.Image")));
            this.pbLock2.Location = new System.Drawing.Point(870, 125);
            this.pbLock2.Name = "pbLock2";
            this.pbLock2.Size = new System.Drawing.Size(160, 160);
            this.pbLock2.TabIndex = 10;
            this.pbLock2.TabStop = false;
            // 
            // pbLock3
            // 
            this.pbLock3.BackColor = System.Drawing.Color.Transparent;
            this.pbLock3.Cursor = System.Windows.Forms.Cursors.No;
            this.pbLock3.Image = ((System.Drawing.Image)(resources.GetObject("pbLock3.Image")));
            this.pbLock3.Location = new System.Drawing.Point(1345, 125);
            this.pbLock3.Name = "pbLock3";
            this.pbLock3.Size = new System.Drawing.Size(160, 160);
            this.pbLock3.TabIndex = 11;
            this.pbLock3.TabStop = false;
            // 
            // pbLock4
            // 
            this.pbLock4.BackColor = System.Drawing.Color.Transparent;
            this.pbLock4.Cursor = System.Windows.Forms.Cursors.No;
            this.pbLock4.Image = ((System.Drawing.Image)(resources.GetObject("pbLock4.Image")));
            this.pbLock4.Location = new System.Drawing.Point(1610, 125);
            this.pbLock4.Name = "pbLock4";
            this.pbLock4.Size = new System.Drawing.Size(160, 160);
            this.pbLock4.TabIndex = 12;
            this.pbLock4.TabStop = false;
            this.pbLock4.Visible = false;
            // 
            // lblUnknown
            // 
            this.lblUnknown.AutoSize = true;
            this.lblUnknown.BackColor = System.Drawing.Color.Transparent;
            this.lblUnknown.Font = new System.Drawing.Font("ANDROID ROBOT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnknown.ForeColor = System.Drawing.Color.White;
            this.lblUnknown.Location = new System.Drawing.Point(433, 293);
            this.lblUnknown.Name = "lblUnknown";
            this.lblUnknown.Size = new System.Drawing.Size(84, 36);
            this.lblUnknown.TabIndex = 13;
            this.lblUnknown.Text = "???";
            this.lblUnknown.Visible = false;
            // 
            // pbHelp
            // 
            this.pbHelp.BackColor = System.Drawing.Color.Transparent;
            this.pbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHelp.Image = ((System.Drawing.Image)(resources.GetObject("pbHelp.Image")));
            this.pbHelp.Location = new System.Drawing.Point(872, 439);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(60, 60);
            this.pbHelp.TabIndex = 14;
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            this.pbHelp.MouseLeave += new System.EventHandler(this.pbHelp_MouseLeave);
            this.pbHelp.MouseHover += new System.EventHandler(this.pbHelp_MouseHover);
            // 
            // lblPlanet1
            // 
            this.lblPlanet1.AutoSize = true;
            this.lblPlanet1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanet1.Font = new System.Drawing.Font("BankGothic Md BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanet1.ForeColor = System.Drawing.Color.White;
            this.lblPlanet1.Location = new System.Drawing.Point(355, 293);
            this.lblPlanet1.Name = "lblPlanet1";
            this.lblPlanet1.Size = new System.Drawing.Size(241, 34);
            this.lblPlanet1.TabIndex = 15;
            this.lblPlanet1.Text = "Ceti Alpha V";
            this.lblPlanet1.Visible = false;
            // 
            // lblPlanet2
            // 
            this.lblPlanet2.AutoSize = true;
            this.lblPlanet2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanet2.Font = new System.Drawing.Font("BankGothic Md BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanet2.ForeColor = System.Drawing.Color.White;
            this.lblPlanet2.Location = new System.Drawing.Point(402, 293);
            this.lblPlanet2.Name = "lblPlanet2";
            this.lblPlanet2.Size = new System.Drawing.Size(146, 34);
            this.lblPlanet2.TabIndex = 16;
            this.lblPlanet2.Text = "Bynaus";
            this.lblPlanet2.Visible = false;
            // 
            // lblPlanet3
            // 
            this.lblPlanet3.AutoSize = true;
            this.lblPlanet3.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanet3.Font = new System.Drawing.Font("BankGothic Md BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanet3.ForeColor = System.Drawing.Color.White;
            this.lblPlanet3.Location = new System.Drawing.Point(403, 293);
            this.lblPlanet3.Name = "lblPlanet3";
            this.lblPlanet3.Size = new System.Drawing.Size(144, 34);
            this.lblPlanet3.TabIndex = 17;
            this.lblPlanet3.Text = "Rigel X";
            this.lblPlanet3.Visible = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(944, 511);
            this.Controls.Add(this.lblPlanet3);
            this.Controls.Add(this.lblPlanet2);
            this.Controls.Add(this.lblPlanet1);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.lblUnknown);
            this.Controls.Add(this.pbLock4);
            this.Controls.Add(this.pbLock3);
            this.Controls.Add(this.pbLock2);
            this.Controls.Add(this.pbPlanet1);
            this.Controls.Add(this.pbPlanet3);
            this.Controls.Add(this.pbPlanet2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.pbFinalPlanet);
            this.Controls.Add(this.pbSpaceShip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Earth Armageddon - Levels";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinalPlanet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSpaceShip;
        private System.Windows.Forms.PictureBox pbFinalPlanet;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbPlanet2;
        private System.Windows.Forms.PictureBox pbPlanet1;
        private System.Windows.Forms.PictureBox pbPlanet3;
        private System.Windows.Forms.PictureBox pbLock2;
        private System.Windows.Forms.PictureBox pbLock3;
        private System.Windows.Forms.PictureBox pbLock4;
        private System.Windows.Forms.Label lblUnknown;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Label lblPlanet1;
        private System.Windows.Forms.Label lblPlanet2;
        private System.Windows.Forms.Label lblPlanet3;

    }
}