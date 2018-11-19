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
            ((System.ComponentModel.ISupportInitialize)(this.gridFrequentItemSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsociationRules)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(567, 358);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
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
            this.gridFrequentItemSets.Location = new System.Drawing.Point(36, 32);
            this.gridFrequentItemSets.Name = "gridFrequentItemSets";
            this.gridFrequentItemSets.ReadOnly = true;
            this.gridFrequentItemSets.Size = new System.Drawing.Size(298, 263);
            this.gridFrequentItemSets.TabIndex = 2;
            this.gridFrequentItemSets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.gridFrequentItemSets.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(363, 32);
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
            this.gridAsociationRules.Location = new System.Drawing.Point(363, 155);
            this.gridAsociationRules.Name = "gridAsociationRules";
            this.gridAsociationRules.ReadOnly = true;
            this.gridAsociationRules.Size = new System.Drawing.Size(279, 140);
            this.gridAsociationRules.TabIndex = 5;
            this.gridAsociationRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAsociationRules_CellClick);
            this.gridAsociationRules.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridAsociationRules_RowHeaderMouseClick);
            // 
            // ucConsultaItemSets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
