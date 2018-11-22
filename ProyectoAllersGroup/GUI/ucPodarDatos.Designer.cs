namespace GUI
{
    partial class ucPodarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPodarDatos));
            this.lbFrecuenciaClientes = new System.Windows.Forms.Label();
            this.tbPorcentajeFrecuenciaClientes = new System.Windows.Forms.TextBox();
            this.btnPodarDatos = new System.Windows.Forms.Button();
            this.lbNumTransacciones = new System.Windows.Forms.Label();
            this.lbNumClientes = new System.Windows.Forms.Label();
            this.lbNumArticulos = new System.Windows.Forms.Label();
            this.tbNumTransacciones = new System.Windows.Forms.TextBox();
            this.tbNumCLientes = new System.Windows.Forms.TextBox();
            this.tbNumArticulos = new System.Windows.Forms.TextBox();
            this.groupPoda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupPoda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFrecuenciaClientes
            // 
            this.lbFrecuenciaClientes.AutoSize = true;
            this.lbFrecuenciaClientes.Location = new System.Drawing.Point(48, 38);
            this.lbFrecuenciaClientes.Name = "lbFrecuenciaClientes";
            this.lbFrecuenciaClientes.Size = new System.Drawing.Size(165, 19);
            this.lbFrecuenciaClientes.TabIndex = 0;
            this.lbFrecuenciaClientes.Text = "Frecuencia de Clinetes";
            // 
            // tbPorcentajeFrecuenciaClientes
            // 
            this.tbPorcentajeFrecuenciaClientes.Location = new System.Drawing.Point(250, 33);
            this.tbPorcentajeFrecuenciaClientes.Name = "tbPorcentajeFrecuenciaClientes";
            this.tbPorcentajeFrecuenciaClientes.Size = new System.Drawing.Size(56, 27);
            this.tbPorcentajeFrecuenciaClientes.TabIndex = 1;
            // 
            // btnPodarDatos
            // 
            this.btnPodarDatos.BackColor = System.Drawing.Color.DarkRed;
            this.btnPodarDatos.ForeColor = System.Drawing.Color.White;
            this.btnPodarDatos.Location = new System.Drawing.Point(314, 33);
            this.btnPodarDatos.Name = "btnPodarDatos";
            this.btnPodarDatos.Size = new System.Drawing.Size(87, 47);
            this.btnPodarDatos.TabIndex = 2;
            this.btnPodarDatos.Text = "PODAR";
            this.btnPodarDatos.UseVisualStyleBackColor = false;
            this.btnPodarDatos.Click += new System.EventHandler(this.btnPodarDatos_Click);
            // 
            // lbNumTransacciones
            // 
            this.lbNumTransacciones.AutoSize = true;
            this.lbNumTransacciones.Location = new System.Drawing.Point(51, 94);
            this.lbNumTransacciones.Name = "lbNumTransacciones";
            this.lbNumTransacciones.Size = new System.Drawing.Size(192, 19);
            this.lbNumTransacciones.TabIndex = 4;
            this.lbNumTransacciones.Text = "Numero de Transacciones";
            // 
            // lbNumClientes
            // 
            this.lbNumClientes.AutoSize = true;
            this.lbNumClientes.Location = new System.Drawing.Point(51, 125);
            this.lbNumClientes.Name = "lbNumClientes";
            this.lbNumClientes.Size = new System.Drawing.Size(148, 19);
            this.lbNumClientes.TabIndex = 5;
            this.lbNumClientes.Text = "Numero de Clientes";
            // 
            // lbNumArticulos
            // 
            this.lbNumArticulos.AutoSize = true;
            this.lbNumArticulos.Location = new System.Drawing.Point(51, 155);
            this.lbNumArticulos.Name = "lbNumArticulos";
            this.lbNumArticulos.Size = new System.Drawing.Size(155, 19);
            this.lbNumArticulos.TabIndex = 6;
            this.lbNumArticulos.Text = "Numero de Articulos";
            // 
            // tbNumTransacciones
            // 
            this.tbNumTransacciones.Location = new System.Drawing.Point(307, 94);
            this.tbNumTransacciones.Name = "tbNumTransacciones";
            this.tbNumTransacciones.ReadOnly = true;
            this.tbNumTransacciones.Size = new System.Drawing.Size(94, 27);
            this.tbNumTransacciones.TabIndex = 7;
            // 
            // tbNumCLientes
            // 
            this.tbNumCLientes.Location = new System.Drawing.Point(307, 125);
            this.tbNumCLientes.Name = "tbNumCLientes";
            this.tbNumCLientes.ReadOnly = true;
            this.tbNumCLientes.Size = new System.Drawing.Size(94, 27);
            this.tbNumCLientes.TabIndex = 8;
            // 
            // tbNumArticulos
            // 
            this.tbNumArticulos.Location = new System.Drawing.Point(307, 155);
            this.tbNumArticulos.Name = "tbNumArticulos";
            this.tbNumArticulos.ReadOnly = true;
            this.tbNumArticulos.Size = new System.Drawing.Size(94, 27);
            this.tbNumArticulos.TabIndex = 9;
            // 
            // groupPoda
            // 
            this.groupPoda.Controls.Add(this.label1);
            this.groupPoda.Controls.Add(this.tbNumCLientes);
            this.groupPoda.Controls.Add(this.tbNumArticulos);
            this.groupPoda.Controls.Add(this.lbFrecuenciaClientes);
            this.groupPoda.Controls.Add(this.tbPorcentajeFrecuenciaClientes);
            this.groupPoda.Controls.Add(this.tbNumTransacciones);
            this.groupPoda.Controls.Add(this.btnPodarDatos);
            this.groupPoda.Controls.Add(this.lbNumArticulos);
            this.groupPoda.Controls.Add(this.lbNumTransacciones);
            this.groupPoda.Controls.Add(this.lbNumClientes);
            this.groupPoda.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPoda.ForeColor = System.Drawing.Color.Black;
            this.groupPoda.Location = new System.Drawing.Point(69, 105);
            this.groupPoda.Name = "groupPoda";
            this.groupPoda.Size = new System.Drawing.Size(575, 221);
            this.groupPoda.TabIndex = 10;
            this.groupPoda.TabStop = false;
            this.groupPoda.Text = "Podar Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(64, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Podar Datos";
            // 
            // ucPodarDatos
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupPoda);
            this.Name = "ucPodarDatos";
            this.Size = new System.Drawing.Size(787, 513);
            this.groupPoda.ResumeLayout(false);
            this.groupPoda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFrecuenciaClientes;
        private System.Windows.Forms.TextBox tbPorcentajeFrecuenciaClientes;
        private System.Windows.Forms.Button btnPodarDatos;
        private System.Windows.Forms.Label lbNumTransacciones;
        private System.Windows.Forms.Label lbNumClientes;
        private System.Windows.Forms.Label lbNumArticulos;
        private System.Windows.Forms.TextBox tbNumTransacciones;
        private System.Windows.Forms.TextBox tbNumCLientes;
        private System.Windows.Forms.TextBox tbNumArticulos;
        private System.Windows.Forms.GroupBox groupPoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
