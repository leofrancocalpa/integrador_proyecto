namespace GUI
{
    partial class PanelProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Iniciar = new System.Windows.Forms.Button();
            this.numeroProductos = new System.Windows.Forms.TextBox();
            this.Umbral = new System.Windows.Forms.TextBox();
            this.numeroCombinaciones = new System.Windows.Forms.TextBox();
            this.vistaProductos = new System.Windows.Forms.ListView();
            this.Productos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Umbral a filtrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Combinaciones deseadas";
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(33, 214);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(232, 23);
            this.Iniciar.TabIndex = 3;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // numeroProductos
            // 
            this.numeroProductos.Location = new System.Drawing.Point(165, 37);
            this.numeroProductos.Name = "numeroProductos";
            this.numeroProductos.Size = new System.Drawing.Size(100, 20);
            this.numeroProductos.TabIndex = 4;
            // 
            // Umbral
            // 
            this.Umbral.Location = new System.Drawing.Point(165, 98);
            this.Umbral.Name = "Umbral";
            this.Umbral.Size = new System.Drawing.Size(100, 20);
            this.Umbral.TabIndex = 5;
            // 
            // numeroCombinaciones
            // 
            this.numeroCombinaciones.Location = new System.Drawing.Point(165, 160);
            this.numeroCombinaciones.Name = "numeroCombinaciones";
            this.numeroCombinaciones.Size = new System.Drawing.Size(100, 20);
            this.numeroCombinaciones.TabIndex = 6;
            // 
            // vistaProductos
            // 
            this.vistaProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Productos,
            this.Soporte});
            this.vistaProductos.Location = new System.Drawing.Point(288, 30);
            this.vistaProductos.Name = "vistaProductos";
            this.vistaProductos.Size = new System.Drawing.Size(169, 299);
            this.vistaProductos.TabIndex = 7;
            this.vistaProductos.UseCompatibleStateImageBehavior = false;
            this.vistaProductos.View = System.Windows.Forms.View.Details;
            // 
            // Productos
            // 
            this.Productos.Text = "CodigoProductos";
            this.Productos.Width = 100;
            // 
            // Soporte
            // 
            this.Soporte.Text = "Soporte";
            // 
            // PanelProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 341);
            this.Controls.Add(this.vistaProductos);
            this.Controls.Add(this.numeroCombinaciones);
            this.Controls.Add(this.Umbral);
            this.Controls.Add(this.numeroProductos);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PanelProductos";
            this.Text = "PanelProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.TextBox numeroProductos;
        private System.Windows.Forms.TextBox Umbral;
        private System.Windows.Forms.TextBox numeroCombinaciones;
        private System.Windows.Forms.ListView vistaProductos;
        private System.Windows.Forms.ColumnHeader Productos;
        private System.Windows.Forms.ColumnHeader Soporte;
    }
}