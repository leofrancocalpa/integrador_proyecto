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
    public partial class ucGenItemsetF : DevExpress.XtraEditors.XtraUserControl
    {
        public VentanaPrincipal principal { get; set; }

        public ucGenItemsetF()
        {
            InitializeComponent();
        }

        private void btnGenerarFIS_Click(object sender, EventArgs e)
        {
            try
            {
                int j = Convert.ToInt32(tbNumMaxConjunos.Text);
                double minSupport = Convert.ToDouble(tbMinSupport.Text)/100;
                principal.GenerarFrequentItemSets(3, minSupport);
            }
            catch(Exception ex)
            {
            }
        }

        public void LlenarInfo(String nT, String nA)
        {
            tbNumTransacciones.AppendText(nT);
            tbNumArticulos.AppendText(nA);
        }

        public void LlenarResultados(String nFIS, String minNum)
        {
            tbNumFIS.AppendText(nFIS);
            tbNumMinOcurrencias.AppendText(minNum);
            tbMinSupport.ReadOnly = true;
            tbNumMaxConjunos.ReadOnly = true;
        }
    }
}
