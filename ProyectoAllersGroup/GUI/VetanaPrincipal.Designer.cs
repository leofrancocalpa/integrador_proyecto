namespace GUI
{
    partial class VetanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VetanaPrincipal));
            this.IngresarProductos = new System.Windows.Forms.Button();
            this.IngresarTransacciones = new System.Windows.Forms.Button();
            this.IngresarClientes = new System.Windows.Forms.Button();
            this.clientes = new System.Windows.Forms.PictureBox();
            this.transacciones = new System.Windows.Forms.PictureBox();
            this.productos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IngresarProductos
            // 
            this.IngresarProductos.Location = new System.Drawing.Point(25, 252);
            this.IngresarProductos.Name = "IngresarProductos";
            this.IngresarProductos.Size = new System.Drawing.Size(200, 23);
            this.IngresarProductos.TabIndex = 0;
            this.IngresarProductos.Text = "Ingresar";
            this.IngresarProductos.UseVisualStyleBackColor = true;
            this.IngresarProductos.Click += new System.EventHandler(this.IngresarProductos_Click);
            // 
            // IngresarTransacciones
            // 
            this.IngresarTransacciones.Location = new System.Drawing.Point(250, 252);
            this.IngresarTransacciones.Name = "IngresarTransacciones";
            this.IngresarTransacciones.Size = new System.Drawing.Size(198, 23);
            this.IngresarTransacciones.TabIndex = 4;
            this.IngresarTransacciones.Text = "Ingresar";
            this.IngresarTransacciones.UseVisualStyleBackColor = true;
            this.IngresarTransacciones.Click += new System.EventHandler(this.IngresarTransacciones_Click);
            // 
            // IngresarClientes
            // 
            this.IngresarClientes.Location = new System.Drawing.Point(474, 252);
            this.IngresarClientes.Name = "IngresarClientes";
            this.IngresarClientes.Size = new System.Drawing.Size(201, 23);
            this.IngresarClientes.TabIndex = 5;
            this.IngresarClientes.Text = "Ingresar";
            this.IngresarClientes.UseVisualStyleBackColor = true;
            this.IngresarClientes.Click += new System.EventHandler(this.IngresarClientes_Click);
            // 
            // clientes
            // 
            this.clientes.Image = ((System.Drawing.Image)(resources.GetObject("clientes.Image")));
            this.clientes.Location = new System.Drawing.Point(474, 14);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(198, 233);
            this.clientes.TabIndex = 8;
            this.clientes.TabStop = false;
            // 
            // transacciones
            // 
            this.transacciones.Image = ((System.Drawing.Image)(resources.GetObject("transacciones.Image")));
            this.transacciones.Location = new System.Drawing.Point(250, 14);
            this.transacciones.Name = "transacciones";
            this.transacciones.Size = new System.Drawing.Size(198, 233);
            this.transacciones.TabIndex = 7;
            this.transacciones.TabStop = false;
            // 
            // productos
            // 
            this.productos.Image = ((System.Drawing.Image)(resources.GetObject("productos.Image")));
            this.productos.Location = new System.Drawing.Point(27, 14);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(198, 233);
            this.productos.TabIndex = 6;
            this.productos.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 233);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // VetanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 292);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.transacciones);
            this.Controls.Add(this.productos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IngresarClientes);
            this.Controls.Add(this.IngresarTransacciones);
            this.Controls.Add(this.IngresarProductos);
            this.Name = "VetanaPrincipal";
            this.Text = "VetanaPrincipal";
            this.Load += new System.EventHandler(this.VetanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IngresarProductos;
        private System.Windows.Forms.Button IngresarTransacciones;
        private System.Windows.Forms.Button IngresarClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox productos;
        private System.Windows.Forms.PictureBox transacciones;
        private System.Windows.Forms.PictureBox clientes;
    }
}