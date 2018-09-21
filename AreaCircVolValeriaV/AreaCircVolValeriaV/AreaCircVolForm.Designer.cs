namespace AreaCircVolValeriaV
{
    partial class frmCircleFormulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCircleFormulas));
            this.picCircle = new System.Windows.Forms.PictureBox();
            this.mnuShapes = new System.Windows.Forms.MenuStrip();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSphere = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCircle = new System.Windows.Forms.Label();
            this.lblCircForm = new System.Windows.Forms.Label();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.lblInsert = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).BeginInit();
            this.mnuShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCircle
            // 
            this.picCircle.Image = ((System.Drawing.Image)(resources.GetObject("picCircle.Image")));
            this.picCircle.Location = new System.Drawing.Point(441, 120);
            this.picCircle.Name = "picCircle";
            this.picCircle.Size = new System.Drawing.Size(303, 284);
            this.picCircle.TabIndex = 0;
            this.picCircle.TabStop = false;
            // 
            // mnuShapes
            // 
            this.mnuShapes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapesToolStripMenuItem});
            this.mnuShapes.Location = new System.Drawing.Point(0, 0);
            this.mnuShapes.Name = "mnuShapes";
            this.mnuShapes.Size = new System.Drawing.Size(756, 24);
            this.mnuShapes.TabIndex = 1;
            this.mnuShapes.Text = "menuStrip1";
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCircle,
            this.mniRectangle,
            this.mniSphere});
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.shapesToolStripMenuItem.Text = "Shapes/Figures";
            this.shapesToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // mniCircle
            // 
            this.mniCircle.Name = "mniCircle";
            this.mniCircle.Size = new System.Drawing.Size(126, 22);
            this.mniCircle.Text = "Circle";
            // 
            // mniRectangle
            // 
            this.mniRectangle.Name = "mniRectangle";
            this.mniRectangle.Size = new System.Drawing.Size(126, 22);
            this.mniRectangle.Text = "Rectangle";
            // 
            // mniSphere
            // 
            this.mniSphere.Name = "mniSphere";
            this.mniSphere.Size = new System.Drawing.Size(126, 22);
            this.mniSphere.Text = "Sphere";
            // 
            // lblCircle
            // 
            this.lblCircle.AutoSize = true;
            this.lblCircle.Font = new System.Drawing.Font("Dutch801 XBd BT", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCircle.Location = new System.Drawing.Point(92, 82);
            this.lblCircle.Name = "lblCircle";
            this.lblCircle.Size = new System.Drawing.Size(220, 81);
            this.lblCircle.TabIndex = 2;
            this.lblCircle.Text = "Circle";
            this.lblCircle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCircForm
            // 
            this.lblCircForm.AutoSize = true;
            this.lblCircForm.Font = new System.Drawing.Font("Dutch801 XBd BT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircForm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCircForm.Location = new System.Drawing.Point(120, 177);
            this.lblCircForm.Name = "lblCircForm";
            this.lblCircForm.Size = new System.Drawing.Size(147, 48);
            this.lblCircForm.TabIndex = 3;
            this.lblCircForm.Text = "A=πr2";
            // 
            // tbRadius
            // 
            this.tbRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRadius.Location = new System.Drawing.Point(242, 273);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(159, 38);
            this.tbRadius.TabIndex = 4;
            this.tbRadius.TextChanged += new System.EventHandler(this.tbRadius_TextChanged);
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsert.Location = new System.Drawing.Point(22, 277);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(201, 34);
            this.lblInsert.TabIndex = 5;
            this.lblInsert.Text = "Insert a value";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.Location = new System.Drawing.Point(-5, 422);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(321, 30);
            this.lblResponse.TabIndex = 6;
            this.lblResponse.Text = "The area of the circle is ";
            this.lblResponse.Visible = false;
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnArea.Font = new System.Drawing.Font("Dutch801 XBd BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArea.Location = new System.Drawing.Point(151, 337);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(97, 47);
            this.btnArea.TabIndex = 7;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = false;
            // 
            // frmCircleFormulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 563);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblInsert);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.lblCircForm);
            this.Controls.Add(this.lblCircle);
            this.Controls.Add(this.picCircle);
            this.Controls.Add(this.mnuShapes);
            this.Name = "frmCircleFormulas";
            this.Text = "Circle Formular by ValeriaV";
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).EndInit();
            this.mnuShapes.ResumeLayout(false);
            this.mnuShapes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCircle;
        private System.Windows.Forms.MenuStrip mnuShapes;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniCircle;
        private System.Windows.Forms.ToolStripMenuItem mniRectangle;
        private System.Windows.Forms.ToolStripMenuItem mniSphere;
        private System.Windows.Forms.Label lblCircle;
        private System.Windows.Forms.Label lblCircForm;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Button btnArea;
    }
}

