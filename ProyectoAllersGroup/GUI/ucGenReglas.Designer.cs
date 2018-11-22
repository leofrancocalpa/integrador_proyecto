namespace GUI
{
    partial class ucGenReglas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGenReglas));
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.tbNumReglas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.tbNumFIS = new System.Windows.Forms.TextBox();
            this.lblMinSupport = new System.Windows.Forms.Label();
            this.lblNumFIS = new System.Windows.Forms.Label();
            this.tbMinSupport = new System.Windows.Forms.TextBox();
            this.Parametros = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblPorcentajeConfidence = new System.Windows.Forms.Label();
            this.tbMinConfidence = new System.Windows.Forms.TextBox();
            this.lblMinConfidence = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupInfo.SuspendLayout();
            this.Parametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.tbNumReglas);
            this.groupInfo.Controls.Add(this.label1);
            this.groupInfo.Controls.Add(this.lblPorcentaje);
            this.groupInfo.Controls.Add(this.tbNumFIS);
            this.groupInfo.Controls.Add(this.lblMinSupport);
            this.groupInfo.Controls.Add(this.lblNumFIS);
            this.groupInfo.Controls.Add(this.tbMinSupport);
            this.groupInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfo.ForeColor = System.Drawing.Color.Black;
            this.groupInfo.Location = new System.Drawing.Point(69, 105);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(560, 161);
            this.groupInfo.TabIndex = 0;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Informacion";
            // 
            // tbNumReglas
            // 
            this.tbNumReglas.Location = new System.Drawing.Point(212, 109);
            this.tbNumReglas.Name = "tbNumReglas";
            this.tbNumReglas.ReadOnly = true;
            this.tbNumReglas.Size = new System.Drawing.Size(61, 27);
            this.tbNumReglas.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Reglas Generadas";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(184, 78);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(25, 19);
            this.lblPorcentaje.TabIndex = 15;
            this.lblPorcentaje.Text = "%";
            // 
            // tbNumFIS
            // 
            this.tbNumFIS.Location = new System.Drawing.Point(367, 32);
            this.tbNumFIS.Name = "tbNumFIS";
            this.tbNumFIS.ReadOnly = true;
            this.tbNumFIS.Size = new System.Drawing.Size(87, 27);
            this.tbNumFIS.TabIndex = 3;
            // 
            // lblMinSupport
            // 
            this.lblMinSupport.AutoSize = true;
            this.lblMinSupport.Location = new System.Drawing.Point(26, 74);
            this.lblMinSupport.Name = "lblMinSupport";
            this.lblMinSupport.Size = new System.Drawing.Size(121, 19);
            this.lblMinSupport.TabIndex = 13;
            this.lblMinSupport.Text = "Soporte Minimo";
            // 
            // lblNumFIS
            // 
            this.lblNumFIS.AutoSize = true;
            this.lblNumFIS.Location = new System.Drawing.Point(26, 32);
            this.lblNumFIS.Name = "lblNumFIS";
            this.lblNumFIS.Size = new System.Drawing.Size(334, 19);
            this.lblNumFIS.TabIndex = 2;
            this.lblNumFIS.Text = "Numero de Conjuntos de Articulos Frecuentes";
            // 
            // tbMinSupport
            // 
            this.tbMinSupport.Location = new System.Drawing.Point(212, 74);
            this.tbMinSupport.Name = "tbMinSupport";
            this.tbMinSupport.ReadOnly = true;
            this.tbMinSupport.Size = new System.Drawing.Size(61, 27);
            this.tbMinSupport.TabIndex = 14;
            // 
            // Parametros
            // 
            this.Parametros.Controls.Add(this.btnGenerar);
            this.Parametros.Controls.Add(this.lblPorcentajeConfidence);
            this.Parametros.Controls.Add(this.tbMinConfidence);
            this.Parametros.Controls.Add(this.lblMinConfidence);
            this.Parametros.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parametros.ForeColor = System.Drawing.Color.Black;
            this.Parametros.Location = new System.Drawing.Point(69, 282);
            this.Parametros.Name = "Parametros";
            this.Parametros.Size = new System.Drawing.Size(560, 132);
            this.Parametros.TabIndex = 1;
            this.Parametros.TabStop = false;
            this.Parametros.Text = "Parametros";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.DarkRed;
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(367, 38);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(87, 47);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblPorcentajeConfidence
            // 
            this.lblPorcentajeConfidence.AutoSize = true;
            this.lblPorcentajeConfidence.Location = new System.Drawing.Point(171, 41);
            this.lblPorcentajeConfidence.Name = "lblPorcentajeConfidence";
            this.lblPorcentajeConfidence.Size = new System.Drawing.Size(25, 19);
            this.lblPorcentajeConfidence.TabIndex = 2;
            this.lblPorcentajeConfidence.Text = "%";
            // 
            // tbMinConfidence
            // 
            this.tbMinConfidence.Location = new System.Drawing.Point(199, 38);
            this.tbMinConfidence.Name = "tbMinConfidence";
            this.tbMinConfidence.Size = new System.Drawing.Size(74, 27);
            this.tbMinConfidence.TabIndex = 1;
            // 
            // lblMinConfidence
            // 
            this.lblMinConfidence.AutoSize = true;
            this.lblMinConfidence.Location = new System.Drawing.Point(29, 38);
            this.lblMinConfidence.Name = "lblMinConfidence";
            this.lblMinConfidence.Size = new System.Drawing.Size(147, 19);
            this.lblMinConfidence.TabIndex = 0;
            this.lblMinConfidence.Text = "Confidencia Minima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(64, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Generar Reglas de Asociacion";
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
            // 
            // ucGenReglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Parametros);
            this.Controls.Add(this.groupInfo);
            this.Name = "ucGenReglas";
            this.Size = new System.Drawing.Size(787, 513);
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.Parametros.ResumeLayout(false);
            this.Parametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.TextBox tbNumFIS;
        private System.Windows.Forms.Label lblNumFIS;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblMinSupport;
        private System.Windows.Forms.TextBox tbMinSupport;
        private System.Windows.Forms.GroupBox Parametros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblPorcentajeConfidence;
        private System.Windows.Forms.TextBox tbMinConfidence;
        private System.Windows.Forms.Label lblMinConfidence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNumReglas;
        private System.Windows.Forms.Label label1;
    }
}
