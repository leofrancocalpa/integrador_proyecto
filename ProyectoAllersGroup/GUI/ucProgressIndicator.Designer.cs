﻿namespace GUI
{
    partial class ucProgressIndicator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProgressIndicator));
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressPanel
            // 
            this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.progressPanel.Appearance.Options.UseBackColor = true;
            this.progressPanel.Appearance.Options.UseFont = true;
            this.progressPanel.BarAnimationElementThickness = 2;
            this.progressPanel.Location = new System.Drawing.Point(68, 166);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(514, 176);
            this.progressPanel.TabIndex = 0;
            this.progressPanel.Text = "progressPanel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ucProgressIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressPanel);
            this.Name = "ucProgressIndicator";
            this.Size = new System.Drawing.Size(787, 513);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
