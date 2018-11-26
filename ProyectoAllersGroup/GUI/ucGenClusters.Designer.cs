namespace GUI
{
    partial class ucGenClusters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGenClusters));
            this.groupParametros = new System.Windows.Forms.GroupBox();
            this.btnGenCLusters = new System.Windows.Forms.Button();
            this.lblPorcentajePertenencia = new System.Windows.Forms.Label();
            this.tbMinPertenencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupResultados = new System.Windows.Forms.GroupBox();
            this.lblNumClusters = new System.Windows.Forms.Label();
            this.tbNumClusters = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupParametros.SuspendLayout();
            this.groupResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupParametros
            // 
            this.groupParametros.Controls.Add(this.btnGenCLusters);
            this.groupParametros.Controls.Add(this.lblPorcentajePertenencia);
            this.groupParametros.Controls.Add(this.tbMinPertenencia);
            this.groupParametros.Controls.Add(this.label1);
            this.groupParametros.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupParametros.ForeColor = System.Drawing.Color.Black;
            this.groupParametros.Location = new System.Drawing.Point(69, 90);
            this.groupParametros.Name = "groupParametros";
            this.groupParametros.Size = new System.Drawing.Size(509, 139);
            this.groupParametros.TabIndex = 0;
            this.groupParametros.TabStop = false;
            this.groupParametros.Text = "Parametros";
            // 
            // btnGenCLusters
            // 
            this.btnGenCLusters.BackColor = System.Drawing.Color.DarkRed;
            this.btnGenCLusters.ForeColor = System.Drawing.Color.White;
            this.btnGenCLusters.Location = new System.Drawing.Point(285, 76);
            this.btnGenCLusters.Name = "btnGenCLusters";
            this.btnGenCLusters.Size = new System.Drawing.Size(87, 47);
            this.btnGenCLusters.TabIndex = 3;
            this.btnGenCLusters.Text = "Generar";
            this.btnGenCLusters.UseVisualStyleBackColor = false;
            this.btnGenCLusters.Click += new System.EventHandler(this.btnGenCLusters_Click);
            // 
            // lblPorcentajePertenencia
            // 
            this.lblPorcentajePertenencia.AutoSize = true;
            this.lblPorcentajePertenencia.Location = new System.Drawing.Point(255, 45);
            this.lblPorcentajePertenencia.Name = "lblPorcentajePertenencia";
            this.lblPorcentajePertenencia.Size = new System.Drawing.Size(25, 19);
            this.lblPorcentajePertenencia.TabIndex = 2;
            this.lblPorcentajePertenencia.Text = "%";
            // 
            // tbMinPertenencia
            // 
            this.tbMinPertenencia.Location = new System.Drawing.Point(285, 42);
            this.tbMinPertenencia.Name = "tbMinPertenencia";
            this.tbMinPertenencia.Size = new System.Drawing.Size(87, 27);
            this.tbMinPertenencia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pertenencia Minima";
            // 
            // groupResultados
            // 
            this.groupResultados.Controls.Add(this.lblNumClusters);
            this.groupResultados.Controls.Add(this.tbNumClusters);
            this.groupResultados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupResultados.ForeColor = System.Drawing.Color.Black;
            this.groupResultados.Location = new System.Drawing.Point(69, 246);
            this.groupResultados.Name = "groupResultados";
            this.groupResultados.Size = new System.Drawing.Size(509, 120);
            this.groupResultados.TabIndex = 1;
            this.groupResultados.TabStop = false;
            this.groupResultados.Text = "Resultados";
            // 
            // lblNumClusters
            // 
            this.lblNumClusters.AutoSize = true;
            this.lblNumClusters.Location = new System.Drawing.Point(50, 43);
            this.lblNumClusters.Name = "lblNumClusters";
            this.lblNumClusters.Size = new System.Drawing.Size(229, 19);
            this.lblNumClusters.TabIndex = 1;
            this.lblNumClusters.Text = "Numero de Clusters Generados";
            // 
            // tbNumClusters
            // 
            this.tbNumClusters.Location = new System.Drawing.Point(285, 43);
            this.tbNumClusters.Name = "tbNumClusters";
            this.tbNumClusters.ReadOnly = true;
            this.tbNumClusters.Size = new System.Drawing.Size(87, 27);
            this.tbNumClusters.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(64, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Generar Clusters";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ucGenClusters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupResultados);
            this.Controls.Add(this.groupParametros);
            this.Name = "ucGenClusters";
            this.Size = new System.Drawing.Size(787, 513);
            this.groupParametros.ResumeLayout(false);
            this.groupParametros.PerformLayout();
            this.groupResultados.ResumeLayout(false);
            this.groupResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupParametros;
        private System.Windows.Forms.Button btnGenCLusters;
        private System.Windows.Forms.Label lblPorcentajePertenencia;
        private System.Windows.Forms.TextBox tbMinPertenencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupResultados;
        private System.Windows.Forms.Label lblNumClusters;
        private System.Windows.Forms.TextBox tbNumClusters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
