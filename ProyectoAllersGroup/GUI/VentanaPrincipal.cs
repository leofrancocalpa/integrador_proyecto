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
using System.Threading;

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
        private ucHome home;
        private Boolean procesing;

        private ucProgressIndicator progressPanel;
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

            progressPanel = new ucProgressIndicator();
            progressPanel.principal = this;

            home = new ucHome();
            home.principal = this;
            ShowHome();
        }

        public void PodarDatos(double minOcurrencias)
        {
            analyzer.minOcurrencias = minOcurrencias;
            procesing = true;
            ShowProgressIndicator();
            ThreadStart delegado = new ThreadStart(PodDatos);
            Thread hilo = new Thread(delegado);
            hilo.Start();
        }

        private void PodDatos()
        {
            analyzer.PodarDatos();
            String nT = analyzer.data.transactions.Count + "";
            String nC = analyzer.data.clientes.Count + "";
            String nA = analyzer.data.items.Count + "";
            ucPodarD.LimpiarTextBox();
            ucPodarD.LlenarTextBox(nT, nC, nA);
            procesing = false;
            ShowPodarDatos();
        }

        public void GenerarFrequentItemSets(int j, double minSupport)
        {
            String nT = analyzer.data.transactions.Count + "";
            String nA = analyzer.data.items.Count + "";
            ucGenIF.LlenarInfo("", "");
            ucGenIF.LlenarInfo(nT, nA);
            analyzer.minSupport = minSupport;
            analyzer.tamanoMaxDeItemSet = j;
            procesing = true;
            ShowProgressIndicator();
            ThreadStart delegado = new ThreadStart(GenFIS);
            Thread hilo = new Thread(delegado);
            hilo.Start();
            
        }

        private void GenFIS()
        {
            analyzer.GenerarFrequentItemSets();
            String numFIS = analyzer.fIGeneration.candidates.Count + "";
            String numMinAparicion = (analyzer.data.transactions.Count * analyzer.minSupport) + "";
            ucGenIF.LlenarResultados("", "");
            ucGenIF.LlenarResultados(numFIS, numMinAparicion);
            ucCItemSets.itemSets = analyzer.fIGeneration.candidates.Where(x => x.items.Count > 1).ToList();
            procesing = false;
            ShowGenFIS();

        }

        public void GenerarReglas(double confidence)
        {
            analyzer.minConfidence = confidence;
            procesing = true;
            ShowProgressIndicator();
            ThreadStart delegado = new ThreadStart(GenRules);
            Thread hilo = new Thread(delegado);
            hilo.Start();
        }

        private void GenRules()
        {
            analyzer.GenerarReglas();
            String p1 = analyzer.fIGeneration.candidates.Where(x => x.items.Count > 1).ToList().Count.ToString();
            String p2 = (analyzer.minSupport*100).ToString();
            String p3 = (analyzer.ruleGenerator.associationRules.Count).ToString();
            ucGenR.LlenarDatos(p1,p2,p3);
            Thread.Sleep(2500);
            procesing = false;
            ShowGenerarReglas();
        }

        public void GenerarClusters(double pertenencia)
        {
            analyzer.minPertenencia = pertenencia;
            procesing = true;
            ShowProgressIndicator();
            ThreadStart delegado = new ThreadStart(GenClusters);
            Thread hilo = new Thread(delegado);
            hilo.Start();
        }

        private void GenClusters()
        {
            analyzer.GenerarClusters();
            String nC = analyzer.clustersGenerator.clusters.Count + "";
            ucGenC.LlenarDatos(nC);
            ucCCluster.clusters = analyzer.clustersGenerator.clusters;
            Thread.Sleep(2500);
            procesing = false;
            ShowGenerarClusters();
        }
        
        //Events Acordion ScrollBar
        private void acePodarDatos_Click(object sender, EventArgs e)
        {
            ShowPodarDatos();
        }

        private void aceGenFIS_Click(object sender, EventArgs e)
        {
            ShowGenFIS();
        }

        private void aceGAR_Click(object sender, EventArgs e)
        {
            ShowGenerarReglas(); 
        }

        private void aceGC_Click(object sender, EventArgs e)
        {
            ShowGenerarClusters();
        }

        private void aceArtFrecuentes_Click(object sender, EventArgs e)
        {
            if (procesing)
            {
                if (!container.Controls.Contains(progressPanel))
                {
                    container.Controls.Add(progressPanel);
                    progressPanel.Dock = DockStyle.Fill;
                    progressPanel.BringToFront();
                }
                progressPanel.BringToFront();
            }
            else
            {
                if (!container.Controls.Contains(ucCItemSets))
                {
                    container.Controls.Add(ucCItemSets);
                    ucCItemSets.Dock = DockStyle.Fill;
                    ucCItemSets.BringToFront();
                }
                ucCItemSets.BringToFront();
            }
            
        }

        private void aceClusters_Click(object sender, EventArgs e)
        {
            if (procesing)
            {
                if (!container.Controls.Contains(progressPanel))
                {
                    container.Controls.Add(progressPanel);
                    progressPanel.Dock = DockStyle.Fill;
                    progressPanel.BringToFront();
                }
                progressPanel.BringToFront();
            }
            else
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

        private delegate void SHome();
        public void ShowHome()
        {
            if (this.InvokeRequired)
            {
                ProgresInd delegado = new ProgresInd(ShowHome);
                this.Invoke(delegado);
            }
            else
            {
                if (!container.Controls.Contains(home))
                {
                    container.Controls.Add(home);
                    home.Dock = DockStyle.Fill;
                    home.BringToFront();
                }
                home.BringToFront();
            }
        }

        //Show prgess panel
        private delegate void ProgresInd();
        private void ShowProgressIndicator()
        {
            if (this.InvokeRequired)
            {
                ProgresInd delegado = new ProgresInd(ShowProgressIndicator);
                this.Invoke(delegado);
            }
            else
            {
                if (!container.Controls.Contains(progressPanel))
                {
                    container.Controls.Add(progressPanel);
                    progressPanel.Dock = DockStyle.Fill;
                    progressPanel.BringToFront();
                }
                progressPanel.BringToFront();
            }
            
        }

        //Show GenerarFIS
        private delegate void ShowGenFISD();
        private void ShowGenFIS()
        {
            if (this.InvokeRequired)
            {
                ShowGenFISD delegado = new ShowGenFISD(ShowGenFIS);
                this.Invoke(delegado);
            }
            else
            {
                if (procesing)
                {
                    if (!container.Controls.Contains(progressPanel))
                    {
                        container.Controls.Add(progressPanel);
                        progressPanel.Dock = DockStyle.Fill;
                        progressPanel.BringToFront();
                    }
                    progressPanel.BringToFront();
                }
                else
                {
                    if (!container.Controls.Contains(ucGenIF))
                    {
                        container.Controls.Add(ucGenIF);
                        ucCItemSets.Dock = DockStyle.Fill;
                        ucGenIF.BringToFront();
                    }
                    ucGenIF.BringToFront();
                }
            }
        }

        //Mostrar Podar Datos
        private delegate void ShowPodar();
        private void ShowPodarDatos()
        {
            if (this.InvokeRequired)
            {
                ShowPodar delegado = new ShowPodar(ShowPodarDatos);
                this.Invoke(delegado);
            }
            else
            {
                if (procesing)
                {
                    if (!container.Controls.Contains(progressPanel))
                    {
                        container.Controls.Add(progressPanel);
                        progressPanel.Dock = DockStyle.Fill;
                        progressPanel.BringToFront();
                    }
                    progressPanel.BringToFront();
                }
                else
                {
                    if (!container.Controls.Contains(ucPodarD))
                    {
                        container.Controls.Add(ucPodarD);
                        ucPodarD.Dock = DockStyle.Fill;
                        ucPodarD.BringToFront();
                    }
                    ucPodarD.BringToFront();
                }
            }
        }

        //Show Panle Gen Rules
        private delegate void ShowGRules();
        private void ShowGenerarReglas()
        {
            if (this.InvokeRequired)
            {
                ShowGRules delegado = new ShowGRules(ShowGenerarReglas);
                this.Invoke(delegado);
            }
            else
            {
                if (procesing)
                {
                    if (!container.Controls.Contains(progressPanel))
                    {
                        container.Controls.Add(progressPanel);
                        progressPanel.Dock = DockStyle.Fill;
                        progressPanel.BringToFront();
                    }
                    progressPanel.BringToFront();
                }
                else
                {
                    if (!container.Controls.Contains(ucGenR))
                    {
                        container.Controls.Add(ucGenR);
                        ucGenR.Dock = DockStyle.Fill;
                        ucGenR.BringToFront();
                    }
                    ucGenR.BringToFront();
                }
            }
        }

        //Show Gen Cluster panel
        private delegate void ShowGCluster();
        private void ShowGenerarClusters()
        {
            if (this.InvokeRequired)
            {
                ShowGCluster delegado = new ShowGCluster(ShowGenerarClusters);
                this.Invoke(delegado);
            }
            else
            {
                if (procesing)
                {
                    if (!container.Controls.Contains(progressPanel))
                    {
                        container.Controls.Add(progressPanel);
                        progressPanel.Dock = DockStyle.Fill;
                        progressPanel.BringToFront();
                    }
                    progressPanel.BringToFront();
                }
                else
                {
                    if (!container.Controls.Contains(ucGenC))
                    {
                        container.Controls.Add(ucGenC);
                        ucGenC.Dock = DockStyle.Fill;
                        ucGenC.BringToFront();
                    }
                    ucGenC.BringToFront();
                }
            }
        }
    }
}
