namespace GUI
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.acePodarDatos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acegAlgoritmos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceGenFIS = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceGAR = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceGC = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acegConsultas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceArtFrecuentes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceClusters = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(247, 30);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(647, 448);
            this.container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acePodarDatos,
            this.acegAlgoritmos,
            this.acegConsultas});
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(247, 448);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // acePodarDatos
            // 
            this.acePodarDatos.Name = "acePodarDatos";
            this.acePodarDatos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acePodarDatos.Text = "Podar Datos";
            this.acePodarDatos.Click += new System.EventHandler(this.acePodarDatos_Click);
            // 
            // acegAlgoritmos
            // 
            this.acegAlgoritmos.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceGenFIS,
            this.aceGAR,
            this.aceGC});
            this.acegAlgoritmos.Expanded = true;
            this.acegAlgoritmos.Name = "acegAlgoritmos";
            this.acegAlgoritmos.Text = "Ajustes de Algoritmos";
            // 
            // aceGenFIS
            // 
            this.aceGenFIS.Name = "aceGenFIS";
            this.aceGenFIS.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceGenFIS.Text = "Generar ItemSets Frecuentes";
            this.aceGenFIS.Click += new System.EventHandler(this.aceGenFIS_Click);
            // 
            // aceGAR
            // 
            this.aceGAR.Name = "aceGAR";
            this.aceGAR.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceGAR.Text = "Generar Reglas de Asociacion";
            this.aceGAR.Click += new System.EventHandler(this.aceGAR_Click);
            // 
            // aceGC
            // 
            this.aceGC.Name = "aceGC";
            this.aceGC.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceGC.Text = "Generar Clusters";
            this.aceGC.Click += new System.EventHandler(this.aceGC_Click);
            // 
            // acegConsultas
            // 
            this.acegConsultas.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceArtFrecuentes,
            this.aceClusters});
            this.acegConsultas.Expanded = true;
            this.acegConsultas.Name = "acegConsultas";
            this.acegConsultas.Text = "Consultas";
            // 
            // aceArtFrecuentes
            // 
            this.aceArtFrecuentes.Name = "aceArtFrecuentes";
            this.aceArtFrecuentes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceArtFrecuentes.Text = "Articulos Frecuentes";
            this.aceArtFrecuentes.Click += new System.EventHandler(this.aceArtFrecuentes_Click);
            // 
            // aceClusters
            // 
            this.aceClusters.Name = "aceClusters";
            this.aceClusters.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceClusters.Text = "Clusters";
            this.aceClusters.Click += new System.EventHandler(this.aceClusters_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(894, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 478);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.NavigationControl = this.accordionControl1;
            this.Text = "AllersGroup";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acegAlgoritmos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceGenFIS;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceGAR;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceGC;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acePodarDatos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acegConsultas;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceArtFrecuentes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceClusters;
    }
}