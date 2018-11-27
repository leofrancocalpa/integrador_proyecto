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
            double confianza = Convert.ToDouble(tbMinConfidence.Text)/100;
            btnGenerar.Enabled = false;
            principal.GenerarReglas(confianza);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            principal.ShowHome();
        }

        public void LlenarDatos(String p1, String p2, String p3)
        {
            tbNumFIS.Text = p1;
            tbMinSupport.Text = p2;
            tbNumReglas.Text = p3;
        }
    }
}
