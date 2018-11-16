using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace GUI
{
    public partial class VentanaPrincipal : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Analyzer analyzer;
        private ucPodarDatoscs ucPodarD;
        private ucGenItemsetF ucGenIF;
        private ucProgressPanel progressPanel;
        public VentanaPrincipal()
        {
            InitializeComponent();
            analyzer = new Analyzer();
            analyzer.LoadData();

            ucPodarD = new ucPodarDatoscs();
            ucPodarD.principal = this;

            ucGenIF = new ucGenItemsetF();
            ucGenIF.principal = this;

            progressPanel = new ucProgressPanel();
        }

        public void PodarDatos(double minOcurrencias)
        {
            if (!container.Controls.Contains(progressPanel))
            {
                container.Controls.Add(progressPanel);
                progressPanel.Dock = DockStyle.Fill;
                progressPanel.BringToFront();
            }
            progressPanel.BringToFront();
            analyzer.data.PodarTransacciones(minOcurrencias);
            analyzer.data.PodarClientes();
            analyzer.data.PodarArticulos();
            String nT = analyzer.data.transactions.Count + "";
            String nC = analyzer.data.clientes.Count + "";
            String nA = analyzer.data.items.Count + "";
            ucPodarD.LlenarTextBox(nT, nC, nA);
            if (!container.Controls.Contains(ucPodarD))
            {
                container.Controls.Add(ucPodarD);
                ucPodarD.Dock = DockStyle.Fill;
                ucPodarD.BringToFront();
            }
            ucPodarD.BringToFront();
        }

        public void GenerarFrequentItemSets(int j, double minSupport)
        {
            String nT = analyzer.data.transactions.Count + "";
            String nA = analyzer.data.items.Count + "";
            ucGenIF.LlenarInfo(nT, nA);
            analyzer.minSupport = minSupport;
            analyzer.data.PodarItemsPorSupport(minSupport);
            analyzer.fIGeneration.AprioriFrequentItemGeneration(j, analyzer.data);
            String numFIS = analyzer.fIGeneration.candidates.Count+"";
            String numMinAparicion = (analyzer.data.transactions.Count * minSupport)+"";
            ucGenIF.LlenarResultados(numFIS, numMinAparicion);
        }
        /*private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }*/

        private void acePodarDatos_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucPodarD))
            {
                container.Controls.Add(ucPodarD);
                ucPodarD.Dock = DockStyle.Fill;
                ucPodarD.BringToFront();
            }
            ucPodarD.BringToFront();
        }

        private void aceGenFIS_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucGenIF))
            {
                container.Controls.Add(ucGenIF);
                ucGenIF.Dock = DockStyle.Fill;
                ucGenIF.BringToFront();
            }
            ucGenIF.BringToFront();
        }
    }
}
