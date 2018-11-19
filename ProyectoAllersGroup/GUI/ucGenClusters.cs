using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class ucGenClusters : DevExpress.XtraEditors.XtraUserControl
    {
        public VentanaPrincipal principal { get; set; }
        public ucGenClusters()
        {
            InitializeComponent();
        }

        private void btnGenCLusters_Click(object sender, EventArgs e)
        {
            try
            {
                double minPertenencia = Convert.ToDouble(tbMinPertenencia.Text) / 100;
                btnGenCLusters.Enabled = false;
                principal.GenerarClusters(minPertenencia);
            }
            catch(Exception ex)
            {
                principal.Dispose();
            }
            
        }

        public void LlenarDatos(String nC)
        {
            tbNumClusters.AppendText(nC);
            tbMinPertenencia.ReadOnly = true;
        }
    }
}
