namespace GUI
{
    partial class ucConsultaItemSets
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gridFrequentItemSets = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gridAsociationRules = new System.Windows.Forms.DataGridView();
            this.lblItemSetsFrecuentes = new System.Windows.Forms.Label();
            this.lblItemsInItemSets = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridFrequentItemSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsociationRules)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(567, 358);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 39);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gridFrequentItemSets
            // 
            this.gridFrequentItemSets.BackgroundColor = System.Drawing.Color.White;
            this.gridFrequentItemSets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFrequentItemSets.GridColor = System.Drawing.Color.White;
            this.gridFrequentItemSets.Location = new System.Drawing.Point(42, 87);
            this.gridFrequentItemSets.Name = "gridFrequentItemSets";
            this.gridFrequentItemSets.ReadOnly = true;
            this.gridFrequentItemSets.Size = new System.Drawing.Size(298, 310);
            this.gridFrequentItemSets.TabIndex = 2;
            this.gridFrequentItemSets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.gridFrequentItemSets.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(363, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(279, 117);
            this.textBox1.TabIndex = 4;
            // 
            // gridAsociationRules
            // 
            this.gridAsociationRules.AllowUserToDeleteRows = false;
            this.gridAsociationRules.BackgroundColor = System.Drawing.Color.White;
            this.gridAsociationRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsociationRules.Location = new System.Drawing.Point(363, 230);
            this.gridAsociationRules.Name = "gridAsociationRules";
            this.gridAsociationRules.ReadOnly = true;
            this.gridAsociationRules.Size = new System.Drawing.Size(279, 120);
            this.gridAsociationRules.TabIndex = 5;
            this.gridAsociationRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAsociationRules_CellClick);
            this.gridAsociationRules.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridAsociationRules_RowHeaderMouseClick);
            // 
            // lblItemSetsFrecuentes
            // 
            this.lblItemSetsFrecuentes.AutoSize = true;
            this.lblItemSetsFrecuentes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblItemSetsFrecuentes.Location = new System.Drawing.Point(39, 62);
            this.lblItemSetsFrecuentes.Name = "lblItemSetsFrecuentes";
            this.lblItemSetsFrecuentes.Size = new System.Drawing.Size(193, 13);
            this.lblItemSetsFrecuentes.TabIndex = 6;
            this.lblItemSetsFrecuentes.Text = "Conjutos de Articulos Frecuentes";
            // 
            // lblItemsInItemSets
            // 
            this.lblItemsInItemSets.AutoSize = true;
            this.lblItemsInItemSets.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblItemsInItemSets.Location = new System.Drawing.Point(363, 62);
            this.lblItemsInItemSets.Name = "lblItemsInItemSets";
            this.lblItemsInItemSets.Size = new System.Drawing.Size(183, 13);
            this.lblItemsInItemSets.TabIndex = 7;
            this.lblItemsInItemSets.Text = "Articulos en Conjunto Fecuente";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRules.Location = new System.Drawing.Point(363, 214);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(257, 13);
            this.lblRules.TabIndex = 8;
            this.lblRules.Text = "Reglas de Asociacion  de Conjunto frecuente";
            // 
            // ucConsultaItemSets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblItemsInItemSets);
            this.Controls.Add(this.lblItemSetsFrecuentes);
            this.Controls.Add(this.gridAsociationRules);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridFrequentItemSets);
            this.Controls.Add(this.btnMostrar);
            this.Name = "ucConsultaItemSets";
            this.Size = new System.Drawing.Size(674, 429);
            ((System.ComponentModel.ISupportInitialize)(this.gridFrequentItemSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsociationRules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView gridFrequentItemSets;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView gridAsociationRules;
        private System.Windows.Forms.Label lblItemSetsFrecuentes;
        private System.Windows.Forms.Label lblItemsInItemSets;
        private System.Windows.Forms.Label lblRules;
    }
}
