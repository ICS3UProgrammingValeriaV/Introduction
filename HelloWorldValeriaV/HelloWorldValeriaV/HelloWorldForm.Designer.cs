namespace HelloWorldValeriaV
{
    partial class frmHeloWorld
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnPressMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.BackColor = System.Drawing.Color.Lavender;
            this.lblHelloWorld.Font = new System.Drawing.Font("Swis721 BdCnOul BT", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHelloWorld.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHelloWorld.Location = new System.Drawing.Point(213, 106);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(413, 97);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello World";
            this.lblHelloWorld.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPressMe
            // 
            this.btnPressMe.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPressMe.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPressMe.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPressMe.Location = new System.Drawing.Point(301, 259);
            this.btnPressMe.Name = "btnPressMe";
            this.btnPressMe.Size = new System.Drawing.Size(200, 100);
            this.btnPressMe.TabIndex = 1;
            this.btnPressMe.Text = "PRESS ME";
            this.btnPressMe.UseVisualStyleBackColor = false;
            this.btnPressMe.Click += new System.EventHandler(this.btnPressMe_Click);
            // 
            // frmHeloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(843, 596);
            this.Controls.Add(this.btnPressMe);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "frmHeloWorld";
            this.Text = "Hello World, Valeria!";
            this.Load += new System.EventHandler(this.frmHeloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button btnPressMe;
    }
}

