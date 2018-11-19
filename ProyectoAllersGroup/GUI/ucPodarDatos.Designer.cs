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
            this.groupPoda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFrecuenciaClientes
            // 
            this.lbFrecuenciaClientes.AutoSize = true;
            this.lbFrecuenciaClientes.Location = new System.Drawing.Point(41, 35);
            this.lbFrecuenciaClientes.Name = "lbFrecuenciaClientes";
            this.lbFrecuenciaClientes.Size = new System.Drawing.Size(129, 14);
            this.lbFrecuenciaClientes.TabIndex = 0;
            this.lbFrecuenciaClientes.Text = "Frecuencia de Clinetes";
            // 
            // tbPorcentajeFrecuenciaClientes
            // 
            this.tbPorcentajeFrecuenciaClientes.Location = new System.Drawing.Point(214, 31);
            this.tbPorcentajeFrecuenciaClientes.Name = "tbPorcentajeFrecuenciaClientes";
            this.tbPorcentajeFrecuenciaClientes.Size = new System.Drawing.Size(49, 22);
            this.tbPorcentajeFrecuenciaClientes.TabIndex = 1;
            // 
            // btnPodarDatos
            // 
            this.btnPodarDatos.BackColor = System.Drawing.Color.White;
            this.btnPodarDatos.Location = new System.Drawing.Point(269, 32);
            this.btnPodarDatos.Name = "btnPodarDatos";
            this.btnPodarDatos.Size = new System.Drawing.Size(75, 21);
            this.btnPodarDatos.TabIndex = 2;
            this.btnPodarDatos.Text = "PODAR";
            this.btnPodarDatos.UseVisualStyleBackColor = false;
            this.btnPodarDatos.Click += new System.EventHandler(this.btnPodarDatos_Click);
            // 
            // lbNumTransacciones
            // 
            this.lbNumTransacciones.AutoSize = true;
            this.lbNumTransacciones.Location = new System.Drawing.Point(44, 87);
            this.lbNumTransacciones.Name = "lbNumTransacciones";
            this.lbNumTransacciones.Size = new System.Drawing.Size(148, 14);
            this.lbNumTransacciones.TabIndex = 4;
            this.lbNumTransacciones.Text = "Numero de Transacciones";
            // 
            // lbNumClientes
            // 
            this.lbNumClientes.AutoSize = true;
            this.lbNumClientes.Location = new System.Drawing.Point(44, 116);
            this.lbNumClientes.Name = "lbNumClientes";
            this.lbNumClientes.Size = new System.Drawing.Size(114, 14);
            this.lbNumClientes.TabIndex = 5;
            this.lbNumClientes.Text = "Numero de Clientes";
            // 
            // lbNumArticulos
            // 
            this.lbNumArticulos.AutoSize = true;
            this.lbNumArticulos.Location = new System.Drawing.Point(44, 144);
            this.lbNumArticulos.Name = "lbNumArticulos";
            this.lbNumArticulos.Size = new System.Drawing.Size(118, 14);
            this.lbNumArticulos.TabIndex = 6;
            this.lbNumArticulos.Text = "Numero de Articulos";
            // 
            // tbNumTransacciones
            // 
            this.tbNumTransacciones.Location = new System.Drawing.Point(263, 87);
            this.tbNumTransacciones.Name = "tbNumTransacciones";
            this.tbNumTransacciones.ReadOnly = true;
            this.tbNumTransacciones.Size = new System.Drawing.Size(81, 22);
            this.tbNumTransacciones.TabIndex = 7;
            // 
            // tbNumCLientes
            // 
            this.tbNumCLientes.Location = new System.Drawing.Point(263, 116);
            this.tbNumCLientes.Name = "tbNumCLientes";
            this.tbNumCLientes.ReadOnly = true;
            this.tbNumCLientes.Size = new System.Drawing.Size(81, 22);
            this.tbNumCLientes.TabIndex = 8;
            // 
            // tbNumArticulos
            // 
            this.tbNumArticulos.Location = new System.Drawing.Point(263, 144);
            this.tbNumArticulos.Name = "tbNumArticulos";
            this.tbNumArticulos.ReadOnly = true;
            this.tbNumArticulos.Size = new System.Drawing.Size(81, 22);
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
            this.groupPoda.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPoda.Location = new System.Drawing.Point(55, 52);
            this.groupPoda.Name = "groupPoda";
            this.groupPoda.Size = new System.Drawing.Size(451, 188);
            this.groupPoda.TabIndex = 10;
            this.groupPoda.TabStop = false;
            this.groupPoda.Text = "Podar Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "%";
            // 
            // ucPodarDatoscs
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPoda);
            this.Name = "ucPodarDatoscs";
            this.Size = new System.Drawing.Size(570, 301);
            this.groupPoda.ResumeLayout(false);
            this.groupPoda.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
