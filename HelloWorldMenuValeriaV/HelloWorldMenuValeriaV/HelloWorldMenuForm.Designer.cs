namespace HelloWorldMenuValeriaV
{
    partial class frmHelloWorldMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorldMenu));
            this.lblSchool = new System.Windows.Forms.Label();
            this.mnuProgram = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSchool = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPeter = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTeresa = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNotre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.BackColor = System.Drawing.Color.Honeydew;
            this.lblSchool.Font = new System.Drawing.Font("Stencil Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSchool.Location = new System.Drawing.Point(12, 24);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(191, 64);
            this.lblSchool.TabIndex = 0;
            this.lblSchool.Text = "Immaculata \r\nHigh School";
            // 
            // mnuProgram
            // 
            this.mnuProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuProgram.Location = new System.Drawing.Point(0, 0);
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(410, 24);
            this.mnuProgram.TabIndex = 1;
            this.mnuProgram.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchool,
            this.mniExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniSchool
            // 
            this.mniSchool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniPeter,
            this.mniTeresa,
            this.mniNotre});
            this.mniSchool.Name = "mniSchool";
            this.mniSchool.Size = new System.Drawing.Size(152, 22);
            this.mniSchool.Text = "Schools";
            this.mniSchool.Click += new System.EventHandler(this.mniSchool_Click);
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(152, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniPeter
            // 
            this.mniPeter.Name = "mniPeter";
            this.mniPeter.Size = new System.Drawing.Size(152, 22);
            this.mniPeter.Text = "St. Peter ";
            this.mniPeter.Click += new System.EventHandler(this.mniPeter_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniTeresa
            // 
            this.mniTeresa.Name = "mniTeresa";
            this.mniTeresa.Size = new System.Drawing.Size(152, 22);
            this.mniTeresa.Text = "Mother Teresa ";
            this.mniTeresa.Click += new System.EventHandler(this.mniTeresa_Click);
            // 
            // mniNotre
            // 
            this.mniNotre.Name = "mniNotre";
            this.mniNotre.Size = new System.Drawing.Size(152, 22);
            this.mniNotre.Text = "Notre Dame";
            this.mniNotre.Click += new System.EventHandler(this.mniNotre_Click);
            // 
            // frmHelloWorldMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(410, 325);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.mnuProgram);
            this.Name = "frmHelloWorldMenu";
            this.Text = "HelloWorldMenu, by ValeriaV";
            this.Load += new System.EventHandler(this.frmHelloWorldMenu_Load);
            this.mnuProgram.ResumeLayout(false);
            this.mnuProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.MenuStrip mnuProgram;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniSchool;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniPeter;
        private System.Windows.Forms.ToolStripMenuItem mniTeresa;
        private System.Windows.Forms.ToolStripMenuItem mniNotre;
    }
}

