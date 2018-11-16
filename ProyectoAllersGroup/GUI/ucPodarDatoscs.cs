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
    public partial class ucPodarDatoscs : DevExpress.XtraEditors.XtraUserControl
    {
        public VentanaPrincipal principal { get; set; }

        public ucPodarDatoscs()
        {
            InitializeComponent();
        }

        private void btnPodarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                double minOcurrencia = Convert.ToDouble(tbPorcentajeFrecuenciaClientes.Text)/100;
                principal.PodarDatos(minOcurrencia);
            }
            catch (Exception ex)
            {
                
            }
        }

        public void LlenarTextBox(String numT, String numC, String numA)
        {
            tbNumTransacciones.AppendText(numT);
            tbNumCLientes.AppendText(numC);
            tbNumArticulos.AppendText(numA);
            tbPorcentajeFrecuenciaClientes.ReadOnly=true;
        }
            
        
    }
}
