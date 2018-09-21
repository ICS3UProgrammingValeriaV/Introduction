namespace InternatValeriaV
{
    partial class frmHelloWorldInternational
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorldInternational));
            this.picMap = new System.Windows.Forms.PictureBox();
            this.rdoEnglish = new System.Windows.Forms.RadioButton();
            this.rdoFrench = new System.Windows.Forms.RadioButton();
            this.rdoGerman = new System.Windows.Forms.RadioButton();
            this.grpFirst = new System.Windows.Forms.GroupBox();
            this.grpSecond = new System.Windows.Forms.GroupBox();
            this.rdoChinese = new System.Windows.Forms.RadioButton();
            this.rdoKorean = new System.Windows.Forms.RadioButton();
            this.rdoJapanese = new System.Windows.Forms.RadioButton();
            this.lblGreating = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.grpFirst.SuspendLayout();
            this.grpSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMap
            // 
            this.picMap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picMap.Image = ((System.Drawing.Image)(resources.GetObject("picMap.Image")));
            this.picMap.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMap.InitialImage")));
            this.picMap.Location = new System.Drawing.Point(12, 12);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(439, 331);
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            this.picMap.Click += new System.EventHandler(this.picMap_Click);
            // 
            // rdoEnglish
            // 
            this.rdoEnglish.AutoSize = true;
            this.rdoEnglish.Checked = true;
            this.rdoEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEnglish.Location = new System.Drawing.Point(17, 19);
            this.rdoEnglish.Name = "rdoEnglish";
            this.rdoEnglish.Size = new System.Drawing.Size(121, 35);
            this.rdoEnglish.TabIndex = 1;
            this.rdoEnglish.TabStop = true;
            this.rdoEnglish.Text = "English";
            this.rdoEnglish.UseVisualStyleBackColor = true;
            this.rdoEnglish.CheckedChanged += new System.EventHandler(this.rdoEnglish_CheckedChanged);
            // 
            // rdoFrench
            // 
            this.rdoFrench.AutoSize = true;
            this.rdoFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFrench.Location = new System.Drawing.Point(17, 60);
            this.rdoFrench.Name = "rdoFrench";
            this.rdoFrench.Size = new System.Drawing.Size(117, 35);
            this.rdoFrench.TabIndex = 2;
            this.rdoFrench.Text = "French";
            this.rdoFrench.UseVisualStyleBackColor = true;
            this.rdoFrench.CheckedChanged += new System.EventHandler(this.rdoFrench_CheckedChanged);
            // 
            // rdoGerman
            // 
            this.rdoGerman.AutoSize = true;
            this.rdoGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGerman.Location = new System.Drawing.Point(17, 101);
            this.rdoGerman.Name = "rdoGerman";
            this.rdoGerman.Size = new System.Drawing.Size(129, 35);
            this.rdoGerman.TabIndex = 3;
            this.rdoGerman.Text = "German";
            this.rdoGerman.UseVisualStyleBackColor = true;
            this.rdoGerman.CheckedChanged += new System.EventHandler(this.rdoGerman_CheckedChanged);
            // 
            // grpFirst
            // 
            this.grpFirst.BackColor = System.Drawing.Color.Transparent;
            this.grpFirst.Controls.Add(this.rdoEnglish);
            this.grpFirst.Controls.Add(this.rdoGerman);
            this.grpFirst.Controls.Add(this.rdoFrench);
            this.grpFirst.Location = new System.Drawing.Point(39, 162);
            this.grpFirst.Name = "grpFirst";
            this.grpFirst.Size = new System.Drawing.Size(153, 161);
            this.grpFirst.TabIndex = 4;
            this.grpFirst.TabStop = false;
            this.grpFirst.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpSecond
            // 
            this.grpSecond.BackColor = System.Drawing.Color.Transparent;
            this.grpSecond.Controls.Add(this.rdoChinese);
            this.grpSecond.Controls.Add(this.rdoKorean);
            this.grpSecond.Controls.Add(this.rdoJapanese);
            this.grpSecond.Location = new System.Drawing.Point(265, 162);
            this.grpSecond.Name = "grpSecond";
            this.grpSecond.Size = new System.Drawing.Size(162, 161);
            this.grpSecond.TabIndex = 5;
            this.grpSecond.TabStop = false;
            this.grpSecond.Visible = false;
            // 
            // rdoChinese
            // 
            this.rdoChinese.AutoSize = true;
            this.rdoChinese.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChinese.Location = new System.Drawing.Point(17, 19);
            this.rdoChinese.Name = "rdoChinese";
            this.rdoChinese.Size = new System.Drawing.Size(123, 35);
            this.rdoChinese.TabIndex = 1;
            this.rdoChinese.TabStop = true;
            this.rdoChinese.Text = "Chinise";
            this.rdoChinese.UseVisualStyleBackColor = true;
            // 
            // rdoKorean
            // 
            this.rdoKorean.AutoSize = true;
            this.rdoKorean.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKorean.Location = new System.Drawing.Point(17, 101);
            this.rdoKorean.Name = "rdoKorean";
            this.rdoKorean.Size = new System.Drawing.Size(119, 35);
            this.rdoKorean.TabIndex = 3;
            this.rdoKorean.TabStop = true;
            this.rdoKorean.Text = "Korean";
            this.rdoKorean.UseVisualStyleBackColor = true;
            // 
            // rdoJapanese
            // 
            this.rdoJapanese.AutoSize = true;
            this.rdoJapanese.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoJapanese.Location = new System.Drawing.Point(17, 60);
            this.rdoJapanese.Name = "rdoJapanese";
            this.rdoJapanese.Size = new System.Drawing.Size(150, 35);
            this.rdoJapanese.TabIndex = 2;
            this.rdoJapanese.TabStop = true;
            this.rdoJapanese.Text = "Japanese";
            this.rdoJapanese.UseVisualStyleBackColor = true;
            // 
            // lblGreating
            // 
            this.lblGreating.AutoSize = true;
            this.lblGreating.BackColor = System.Drawing.Color.Transparent;
            this.lblGreating.Font = new System.Drawing.Font("Swis721 BdOul BT", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreating.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGreating.Location = new System.Drawing.Point(128, 79);
            this.lblGreating.Name = "lblGreating";
            this.lblGreating.Size = new System.Drawing.Size(207, 39);
            this.lblGreating.TabIndex = 6;
            this.lblGreating.Text = "Hello, World";
            // 
            // frmHelloWorldInternational
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(468, 358);
            this.Controls.Add(this.lblGreating);
            this.Controls.Add(this.grpSecond);
            this.Controls.Add(this.grpFirst);
            this.Controls.Add(this.picMap);
            this.Name = "frmHelloWorldInternational";
            this.Text = "Hello World International by Valeria V";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.grpFirst.ResumeLayout(false);
            this.grpFirst.PerformLayout();
            this.grpSecond.ResumeLayout(false);
            this.grpSecond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.RadioButton rdoEnglish;
        private System.Windows.Forms.RadioButton rdoFrench;
        private System.Windows.Forms.RadioButton rdoGerman;
        private System.Windows.Forms.GroupBox grpFirst;
        private System.Windows.Forms.GroupBox grpSecond;
        private System.Windows.Forms.RadioButton rdoChinese;
        private System.Windows.Forms.RadioButton rdoKorean;
        private System.Windows.Forms.RadioButton rdoJapanese;
        private System.Windows.Forms.Label lblGreating;
    }
}

