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
    public partial class ucGenReglas : DevExpress.XtraEditors.XtraUserControl
    {
        public VentanaPrincipal principal { get; set; }
        public ucGenReglas()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            double confianza = Convert.ToDouble(tbMinConfidence.Text);
            btnGenerar.Enabled = false;
            principal.GenerarReglas(confianza);

        }
    }
}
