namespace GUI
{
    partial class ucGenItemsetF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGenItemsetF));
            this.tbNumTransacciones = new System.Windows.Forms.TextBox();
            this.lbNumTransacciones = new System.Windows.Forms.Label();
            this.tbNumArticulos = new System.Windows.Forms.TextBox();
            this.lbNumArticulos = new System.Windows.Forms.Label();
            this.groupInformacion = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerarFIS = new System.Windows.Forms.Button();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumMaxConjunos = new System.Windows.Forms.TextBox();
            this.lblMinSupport = new System.Windows.Forms.Label();
            this.tbMinSupport = new System.Windows.Forms.TextBox();
            this.groupResultado = new System.Windows.Forms.GroupBox();
            this.tbNumMinOcurrencias = new System.Windows.Forms.TextBox();
            this.lblNumMInOcurrencia = new System.Windows.Forms.Label();
            this.tbNumFIS = new System.Windows.Forms.TextBox();
            this.lblNumFIS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupInformacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNumTransacciones
            // 
            this.tbNumTransacciones.Location = new System.Drawing.Point(249, 39);
            this.tbNumTransacciones.Name = "tbNumTransacciones";
            this.tbNumTransacciones.ReadOnly = true;
            this.tbNumTransacciones.Size = new System.Drawing.Size(94, 27);
            this.tbNumTransacciones.TabIndex = 9;
            // 
            // lbNumTransacciones
            // 
            this.lbNumTransacciones.AutoSize = true;
            this.lbNumTransacciones.Location = new System.Drawing.Point(27, 39);
            this.lbNumTransacciones.Name = "lbNumTransacciones";
            this.lbNumTransacciones.Size = new System.Drawing.Size(192, 19);
            this.lbNumTransacciones.TabIndex = 8;
            this.lbNumTransacciones.Text = "Numero de Transacciones";
            // 
            // tbNumArticulos
            // 
            this.tbNumArticulos.Location = new System.Drawing.Point(249, 68);
            this.tbNumArticulos.Name = "tbNumArticulos";
            this.tbNumArticulos.ReadOnly = true;
            this.tbNumArticulos.Size = new System.Drawing.Size(94, 27);
            this.tbNumArticulos.TabIndex = 11;
            // 
            // lbNumArticulos
            // 
            this.lbNumArticulos.AutoSize = true;
            this.lbNumArticulos.Location = new System.Drawing.Point(27, 68);
            this.lbNumArticulos.Name = "lbNumArticulos";
            this.lbNumArticulos.Size = new System.Drawing.Size(155, 19);
            this.lbNumArticulos.TabIndex = 10;
            this.lbNumArticulos.Text = "Numero de Articulos";
            // 
            // groupInformacion
            // 
            this.groupInformacion.Controls.Add(this.lbNumArticulos);
            this.groupInformacion.Controls.Add(this.tbNumArticulos);
            this.groupInformacion.Controls.Add(this.lbNumTransacciones);
            this.groupInformacion.Controls.Add(this.tbNumTransacciones);
            this.groupInformacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInformacion.ForeColor = System.Drawing.Color.Black;
            this.groupInformacion.Location = new System.Drawing.Point(69, 98);
            this.groupInformacion.Name = "groupInformacion";
            this.groupInformacion.Size = new System.Drawing.Size(543, 116);
            this.groupInformacion.TabIndex = 12;
            this.groupInformacion.TabStop = false;
            this.groupInformacion.Text = "Informacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerarFIS);
            this.groupBox1.Controls.Add(this.lblPorcentaje);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNumMaxConjunos);
            this.groupBox1.Controls.Add(this.lblMinSupport);
            this.groupBox1.Controls.Add(this.tbMinSupport);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(69, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 116);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // btnGenerarFIS
            // 
            this.btnGenerarFIS.BackColor = System.Drawing.Color.DarkRed;
            this.btnGenerarFIS.ForeColor = System.Drawing.Color.White;
            this.btnGenerarFIS.Location = new System.Drawing.Point(406, 36);
            this.btnGenerarFIS.Name = "btnGenerarFIS";
            this.btnGenerarFIS.Size = new System.Drawing.Size(87, 47);
            this.btnGenerarFIS.TabIndex = 13;
            this.btnGenerarFIS.Text = "Generar";
            this.btnGenerarFIS.UseVisualStyleBackColor = false;
            this.btnGenerarFIS.Click += new System.EventHandler(this.btnGenerarFIS_Click);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(222, 39);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(25, 19);
            this.lblPorcentaje.TabIndex = 12;
            this.lblPorcentaje.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero Max. de Conjuntos ";
            // 
            // tbNumMaxConjunos
            // 
            this.tbNumMaxConjunos.Location = new System.Drawing.Point(250, 65);
            this.tbNumMaxConjunos.Name = "tbNumMaxConjunos";
            this.tbNumMaxConjunos.Size = new System.Drawing.Size(94, 27);
            this.tbNumMaxConjunos.TabIndex = 11;
            // 
            // lblMinSupport
            // 
            this.lblMinSupport.AutoSize = true;
            this.lblMinSupport.Location = new System.Drawing.Point(27, 39);
            this.lblMinSupport.Name = "lblMinSupport";
            this.lblMinSupport.Size = new System.Drawing.Size(121, 19);
            this.lblMinSupport.TabIndex = 8;
            this.lblMinSupport.Text = "Soporte Minimo";
            // 
            // tbMinSupport
            // 
            this.tbMinSupport.Location = new System.Drawing.Point(250, 36);
            this.tbMinSupport.Name = "tbMinSupport";
            this.tbMinSupport.Size = new System.Drawing.Size(94, 27);
            this.tbMinSupport.TabIndex = 9;
            // 
            // groupResultado
            // 
            this.groupResultado.Controls.Add(this.tbNumMinOcurrencias);
            this.groupResultado.Controls.Add(this.lblNumMInOcurrencia);
            this.groupResultado.Controls.Add(this.tbNumFIS);
            this.groupResultado.Controls.Add(this.lblNumFIS);
            this.groupResultado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupResultado.ForeColor = System.Drawing.Color.Black;
            this.groupResultado.Location = new System.Drawing.Point(69, 344);
            this.groupResultado.Name = "groupResultado";
            this.groupResultado.Size = new System.Drawing.Size(543, 95);
            this.groupResultado.TabIndex = 14;
            this.groupResultado.TabStop = false;
            this.groupResultado.Text = "Resultado";
            // 
            // tbNumMinOcurrencias
            // 
            this.tbNumMinOcurrencias.Location = new System.Drawing.Point(406, 57);
            this.tbNumMinOcurrencias.Name = "tbNumMinOcurrencias";
            this.tbNumMinOcurrencias.ReadOnly = true;
            this.tbNumMinOcurrencias.Size = new System.Drawing.Size(87, 27);
            this.tbNumMinOcurrencias.TabIndex = 3;
            // 
            // lblNumMInOcurrencia
            // 
            this.lblNumMInOcurrencia.AutoSize = true;
            this.lblNumMInOcurrencia.Location = new System.Drawing.Point(27, 60);
            this.lblNumMInOcurrencia.Name = "lblNumMInOcurrencia";
            this.lblNumMInOcurrencia.Size = new System.Drawing.Size(373, 19);
            this.lblNumMInOcurrencia.TabIndex = 2;
            this.lblNumMInOcurrencia.Text = "Numero Min. de Veces que aparecen Los Conjuntos";
            // 
            // tbNumFIS
            // 
            this.tbNumFIS.Location = new System.Drawing.Point(406, 26);
            this.tbNumFIS.Name = "tbNumFIS";
            this.tbNumFIS.ReadOnly = true;
            this.tbNumFIS.Size = new System.Drawing.Size(87, 27);
            this.tbNumFIS.TabIndex = 1;
            // 
            // lblNumFIS
            // 
            this.lblNumFIS.AutoSize = true;
            this.lblNumFIS.Location = new System.Drawing.Point(27, 29);
            this.lblNumFIS.Name = "lblNumFIS";
            this.lblNumFIS.Size = new System.Drawing.Size(334, 19);
            this.lblNumFIS.TabIndex = 0;
            this.lblNumFIS.Text = "Numero de Conjuntos de Articulos Frecuentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(64, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Generar ItemSets Frecuentes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ucGenItemsetF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupInformacion);
            this.Name = "ucGenItemsetF";
            this.Size = new System.Drawing.Size(787, 511);
            this.groupInformacion.ResumeLayout(false);
            this.groupInformacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupResultado.ResumeLayout(false);
            this.groupResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNumTransacciones;
        private System.Windows.Forms.Label lbNumTransacciones;
        private System.Windows.Forms.TextBox tbNumArticulos;
        private System.Windows.Forms.Label lbNumArticulos;
        private System.Windows.Forms.GroupBox groupInformacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumMaxConjunos;
        private System.Windows.Forms.Label lblMinSupport;
        private System.Windows.Forms.TextBox tbMinSupport;
        private System.Windows.Forms.Button btnGenerarFIS;
        private System.Windows.Forms.GroupBox groupResultado;
        private System.Windows.Forms.TextBox tbNumMinOcurrencias;
        private System.Windows.Forms.Label lblNumMInOcurrencia;
        private System.Windows.Forms.TextBox tbNumFIS;
        private System.Windows.Forms.Label lblNumFIS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
