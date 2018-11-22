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
using Model;

namespace GUI
{
    public partial class ucConsultasClusters : DevExpress.XtraEditors.XtraUserControl
    {
        public VentanaPrincipal principal { get; set; }
        public List<Cluster> clusters { get; set; }


        public ucConsultasClusters()
        {
            InitializeComponent();
            gridViewCLusters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Clientes
            
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Reglas
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gridViewCLusters.DataSource = clusters; // principal.analyzer.fIGeneration.candidates;
        }

        private void gridViewCLusters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in this.gridViewCLusters.SelectedRows)
            {   
                Cluster cluster = row.DataBoundItem as Cluster;
                cluster = principal.analyzer.clustersGenerator.clusters.First(x => x.Id.Equals(cluster.Id));
                if (cluster != null)
                {
                    List<Elemento> clientes =  cluster.elementos;
                    /*
                    foreach (Elemento elemento in cluster.elementos)
                    {
                        clientes.Add(elemento);
                    }*/
                    ShowClientes(clientes);
                    ShowReglas(principal.analyzer.ruleGenerator.associationRules);
                }
                
            }
        }

        private void gridViewCLusters_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void ShowClientes(List<Elemento> clientes)
        {
            dataGridView1.DataSource = clientes;
        }

        private void ShowReglas(List<Model.Rule> reglas)
        {
            dataGridView2.Columns.Clear();
            DataGridViewColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "ANTECEDENTE";
            DataGridViewColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "CONSECUENTE";
            DataGridViewColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "CONFIANZA";
            dataGridView2.Columns.Add(c1);
            dataGridView2.Columns.Add(c2);
            dataGridView2.Columns.Add(c3);

            foreach(Model.Rule regla in reglas)
            {
                dataGridView2.Rows.Add(regla.antecedente.ToString(), regla.consecuente.ToString(), regla.confidence);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
