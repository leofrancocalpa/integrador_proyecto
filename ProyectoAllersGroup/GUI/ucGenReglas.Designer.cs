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
            this.groupInfo = new System.Windows.Forms.GroupBox();
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
            this.groupInfo.SuspendLayout();
            this.Parametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lblPorcentaje);
            this.groupInfo.Controls.Add(this.tbNumFIS);
            this.groupInfo.Controls.Add(this.lblMinSupport);
            this.groupInfo.Controls.Add(this.lblNumFIS);
            this.groupInfo.Controls.Add(this.tbMinSupport);
            this.groupInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfo.Location = new System.Drawing.Point(28, 31);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(480, 113);
            this.groupInfo.TabIndex = 0;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Informacion";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(158, 72);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(19, 14);
            this.lblPorcentaje.TabIndex = 15;
            this.lblPorcentaje.Text = "%";
            // 
            // tbNumFIS
            // 
            this.tbNumFIS.Location = new System.Drawing.Point(315, 30);
            this.tbNumFIS.Name = "tbNumFIS";
            this.tbNumFIS.ReadOnly = true;
            this.tbNumFIS.Size = new System.Drawing.Size(75, 22);
            this.tbNumFIS.TabIndex = 3;
            // 
            // lblMinSupport
            // 
            this.lblMinSupport.AutoSize = true;
            this.lblMinSupport.Location = new System.Drawing.Point(22, 69);
            this.lblMinSupport.Name = "lblMinSupport";
            this.lblMinSupport.Size = new System.Drawing.Size(92, 14);
            this.lblMinSupport.TabIndex = 13;
            this.lblMinSupport.Text = "Soporte Minimo";
            // 
            // lblNumFIS
            // 
            this.lblNumFIS.AutoSize = true;
            this.lblNumFIS.Location = new System.Drawing.Point(22, 30);
            this.lblNumFIS.Name = "lblNumFIS";
            this.lblNumFIS.Size = new System.Drawing.Size(260, 14);
            this.lblNumFIS.TabIndex = 2;
            this.lblNumFIS.Text = "Numero de Conjuntos de Articulos Frecuentes";
            // 
            // tbMinSupport
            // 
            this.tbMinSupport.Location = new System.Drawing.Point(182, 69);
            this.tbMinSupport.Name = "tbMinSupport";
            this.tbMinSupport.ReadOnly = true;
            this.tbMinSupport.Size = new System.Drawing.Size(53, 22);
            this.tbMinSupport.TabIndex = 14;
            // 
            // Parametros
            // 
            this.Parametros.Controls.Add(this.btnGenerar);
            this.Parametros.Controls.Add(this.lblPorcentajeConfidence);
            this.Parametros.Controls.Add(this.tbMinConfidence);
            this.Parametros.Controls.Add(this.lblMinConfidence);
            this.Parametros.Location = new System.Drawing.Point(28, 169);
            this.Parametros.Name = "Parametros";
            this.Parametros.Size = new System.Drawing.Size(480, 123);
            this.Parametros.TabIndex = 1;
            this.Parametros.TabStop = false;
            this.Parametros.Text = "Parametros";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(315, 35);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblPorcentajeConfidence
            // 
            this.lblPorcentajeConfidence.AutoSize = true;
            this.lblPorcentajeConfidence.Location = new System.Drawing.Point(147, 38);
            this.lblPorcentajeConfidence.Name = "lblPorcentajeConfidence";
            this.lblPorcentajeConfidence.Size = new System.Drawing.Size(18, 13);
            this.lblPorcentajeConfidence.TabIndex = 2;
            this.lblPorcentajeConfidence.Text = "%";
            // 
            // tbMinConfidence
            // 
            this.tbMinConfidence.Location = new System.Drawing.Point(171, 35);
            this.tbMinConfidence.Name = "tbMinConfidence";
            this.tbMinConfidence.Size = new System.Drawing.Size(64, 21);
            this.tbMinConfidence.TabIndex = 1;
            // 
            // lblMinConfidence
            // 
            this.lblMinConfidence.AutoSize = true;
            this.lblMinConfidence.Location = new System.Drawing.Point(25, 35);
            this.lblMinConfidence.Name = "lblMinConfidence";
            this.lblMinConfidence.Size = new System.Drawing.Size(98, 13);
            this.lblMinConfidence.TabIndex = 0;
            this.lblMinConfidence.Text = "Confidencia Minima";
            // 
            // ucGenReglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Parametros);
            this.Controls.Add(this.groupInfo);
            this.Name = "ucGenReglas";
            this.Size = new System.Drawing.Size(674, 429);
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.Parametros.ResumeLayout(false);
            this.Parametros.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
