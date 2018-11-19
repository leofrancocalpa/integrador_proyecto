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
            this.groupParametros = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMinPertenencia = new System.Windows.Forms.TextBox();
            this.lblPorcentajePertenencia = new System.Windows.Forms.Label();
            this.btnGenCLusters = new System.Windows.Forms.Button();
            this.groupResultados = new System.Windows.Forms.GroupBox();
            this.tbNumClusters = new System.Windows.Forms.TextBox();
            this.lblNumClusters = new System.Windows.Forms.Label();
            this.groupParametros.SuspendLayout();
            this.groupResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupParametros
            // 
            this.groupParametros.Controls.Add(this.btnGenCLusters);
            this.groupParametros.Controls.Add(this.lblPorcentajePertenencia);
            this.groupParametros.Controls.Add(this.tbMinPertenencia);
            this.groupParametros.Controls.Add(this.label1);
            this.groupParametros.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupParametros.Location = new System.Drawing.Point(37, 35);
            this.groupParametros.Name = "groupParametros";
            this.groupParametros.Size = new System.Drawing.Size(340, 118);
            this.groupParametros.TabIndex = 0;
            this.groupParametros.TabStop = false;
            this.groupParametros.Text = "Parametros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pertenencia Minima";
            // 
            // tbMinPertenencia
            // 
            this.tbMinPertenencia.Location = new System.Drawing.Point(244, 39);
            this.tbMinPertenencia.Name = "tbMinPertenencia";
            this.tbMinPertenencia.Size = new System.Drawing.Size(75, 22);
            this.tbMinPertenencia.TabIndex = 1;
            // 
            // lblPorcentajePertenencia
            // 
            this.lblPorcentajePertenencia.AutoSize = true;
            this.lblPorcentajePertenencia.Location = new System.Drawing.Point(219, 42);
            this.lblPorcentajePertenencia.Name = "lblPorcentajePertenencia";
            this.lblPorcentajePertenencia.Size = new System.Drawing.Size(19, 14);
            this.lblPorcentajePertenencia.TabIndex = 2;
            this.lblPorcentajePertenencia.Text = "%";
            // 
            // btnGenCLusters
            // 
            this.btnGenCLusters.Location = new System.Drawing.Point(244, 71);
            this.btnGenCLusters.Name = "btnGenCLusters";
            this.btnGenCLusters.Size = new System.Drawing.Size(75, 23);
            this.btnGenCLusters.TabIndex = 3;
            this.btnGenCLusters.Text = "Generar";
            this.btnGenCLusters.UseVisualStyleBackColor = true;
            this.btnGenCLusters.Click += new System.EventHandler(this.btnGenCLusters_Click);
            // 
            // groupResultados
            // 
            this.groupResultados.Controls.Add(this.lblNumClusters);
            this.groupResultados.Controls.Add(this.tbNumClusters);
            this.groupResultados.Location = new System.Drawing.Point(37, 170);
            this.groupResultados.Name = "groupResultados";
            this.groupResultados.Size = new System.Drawing.Size(340, 98);
            this.groupResultados.TabIndex = 1;
            this.groupResultados.TabStop = false;
            this.groupResultados.Text = "Resultados";
            // 
            // tbNumClusters
            // 
            this.tbNumClusters.Location = new System.Drawing.Point(244, 40);
            this.tbNumClusters.Name = "tbNumClusters";
            this.tbNumClusters.ReadOnly = true;
            this.tbNumClusters.Size = new System.Drawing.Size(75, 21);
            this.tbNumClusters.TabIndex = 0;
            // 
            // lblNumClusters
            // 
            this.lblNumClusters.AutoSize = true;
            this.lblNumClusters.Location = new System.Drawing.Point(43, 40);
            this.lblNumClusters.Name = "lblNumClusters";
            this.lblNumClusters.Size = new System.Drawing.Size(156, 13);
            this.lblNumClusters.TabIndex = 1;
            this.lblNumClusters.Text = "Numero de Clusters Generados";
            // 
            // ucGenClusters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupResultados);
            this.Controls.Add(this.groupParametros);
            this.Name = "ucGenClusters";
            this.Size = new System.Drawing.Size(425, 293);
            this.groupParametros.ResumeLayout(false);
            this.groupParametros.PerformLayout();
            this.groupResultados.ResumeLayout(false);
            this.groupResultados.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
