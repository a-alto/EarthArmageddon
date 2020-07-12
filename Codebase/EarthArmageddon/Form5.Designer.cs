namespace EarthArmageddon
{
    partial class frmName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmName));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblInsertName = new System.Windows.Forms.Label();
            this.btnOKName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Code Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.txtName.Location = new System.Drawing.Point(70, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 24);
            this.txtName.TabIndex = 0;
            // 
            // lblInsertName
            // 
            this.lblInsertName.AutoSize = true;
            this.lblInsertName.BackColor = System.Drawing.Color.Transparent;
            this.lblInsertName.Font = new System.Drawing.Font("Xolonium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertName.ForeColor = System.Drawing.Color.White;
            this.lblInsertName.Location = new System.Drawing.Point(87, 26);
            this.lblInsertName.Name = "lblInsertName";
            this.lblInsertName.Size = new System.Drawing.Size(172, 18);
            this.lblInsertName.TabIndex = 1;
            this.lblInsertName.Text = "Immetti il tuo nome";
            // 
            // btnOKName
            // 
            this.btnOKName.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOKName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOKName.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOKName.FlatAppearance.BorderSize = 2;
            this.btnOKName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOKName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnOKName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKName.Font = new System.Drawing.Font("Xolonium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKName.ForeColor = System.Drawing.Color.White;
            this.btnOKName.Location = new System.Drawing.Point(105, 84);
            this.btnOKName.Name = "btnOKName";
            this.btnOKName.Size = new System.Drawing.Size(127, 25);
            this.btnOKName.TabIndex = 2;
            this.btnOKName.Text = "Conferma";
            this.btnOKName.UseVisualStyleBackColor = false;
            this.btnOKName.Click += new System.EventHandler(this.btnOKName_Click);
            // 
            // frmName
            // 
            this.AcceptButton = this.btnOKName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(346, 131);
            this.Controls.Add(this.btnOKName);
            this.Controls.Add(this.lblInsertName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Earth Armageddon - Name";
            this.Load += new System.EventHandler(this.frmName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblInsertName;
        private System.Windows.Forms.Button btnOKName;
    }
}