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
        public Analyzer analyzer;
        private ucPodarDatos ucPodarD;
        private ucGenItemsetF ucGenIF;
        private ucGenReglas ucGenR;
        private ucGenClusters ucGenC;
        private ucConsultaItemSets ucCItemSets;
        private ucConsultasClusters ucCCluster;

        //private ucProgressPanel progressPanel;
        public VentanaPrincipal()
        {
            InitializeComponent();
            analyzer = new Analyzer();
            analyzer.LoadData();

            ucPodarD = new ucPodarDatos();
            ucPodarD.principal = this;

            ucGenIF = new ucGenItemsetF();
            ucGenIF.principal = this;

            ucGenR = new ucGenReglas();
            ucGenR.principal = this;

            ucGenC = new ucGenClusters();
            ucGenC.principal = this;

            ucCItemSets = new ucConsultaItemSets();
            ucCItemSets.principal = this;

            ucCCluster = new ucConsultasClusters();
            ucCCluster.principal = this;

            //progressPanel = new ucProgressPanel();
        }

        public void PodarDatos(double minOcurrencias)
        {
            analyzer.PodarDatos(minOcurrencias);
            //analyzer.data.PodarTransacciones(minOcurrencias);
            //analyzer.data.PodarClientes();
            //analyzer.data.PodarArticulos();
            String nT = analyzer.data.transactions.Count + "";
            String nC = analyzer.data.clientes.Count + "";
            String nA = analyzer.data.items.Count + "";
            ucPodarD.LimpiarTextBox();
            ucPodarD.LlenarTextBox(nT, nC, nA);
            
        }

        public void GenerarFrequentItemSets(int j, double minSupport)
        {
            String nT = analyzer.data.transactions.Count + "";
            String nA = analyzer.data.items.Count + "";
            ucGenIF.LlenarInfo("", "");
            ucGenIF.LlenarInfo(nT, nA);
            analyzer.minSupport = minSupport;
            analyzer.GenerarFrequentItemSets(j);
            String numFIS = analyzer.fIGeneration.candidates.Count+"";
            String numMinAparicion = (analyzer.data.transactions.Count * minSupport)+"";
            ucGenIF.LlenarResultados("", "");
            ucGenIF.LlenarResultados(numFIS, numMinAparicion);
            ucCItemSets.itemSets = analyzer.fIGeneration.candidates.Where(x=> x.items.Count>1).ToList();
        }

        public void GenerarReglas(double confidence)
        {
            
        }

        public void GenerarClusters(double pertenencia)
        {
            analyzer.GenerarClusters();
            String nC = analyzer.clustersGenerator.clusters.Count+"";
            ucGenC.LlenarDatos(nC);
            ucCCluster.clusters = analyzer.clustersGenerator.clusters;
        }
        
        //Events Acordion ScrollBar
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
                ucCItemSets.Dock = DockStyle.Fill;
                ucGenIF.BringToFront();
            }
            ucGenIF.BringToFront();
        }

        private void aceGAR_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucGenR))
            {
                container.Controls.Add(ucGenR);
                ucGenR.Dock = DockStyle.Fill;
                ucGenR.BringToFront();
            }
            ucGenR.BringToFront();
        }

        private void aceGC_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucGenC))
            {
                container.Controls.Add(ucGenC);
                ucGenC.Dock = DockStyle.Fill;
                ucGenC.BringToFront();
            }
            ucGenC.BringToFront();
        }

        private void aceArtFrecuentes_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucCItemSets))
            {
                container.Controls.Add(ucCItemSets);
                ucCItemSets.Dock = DockStyle.Fill;
                ucCItemSets.BringToFront();
            }
            ucCItemSets.BringToFront();
        }

        private void aceClusters_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucCCluster))
            {
                container.Controls.Add(ucCCluster);
                ucCCluster.Dock = DockStyle.Fill;
                ucCCluster.BringToFront();
            }
            ucCCluster.BringToFront();
        }
    }
}
