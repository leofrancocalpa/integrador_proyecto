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
                    ShowTex(clientes);
                }
                
            }
        }

        private void gridViewCLusters_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ShowClientes(List<Elemento> clientes)
        {
            textBox1.Text = "";
            textBox1.AppendText(clientes.Count.ToString());
            /*dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            DataGridViewColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            
            dataGridView1.Columns.Add(c1);
            foreach (Elemento cliente in clientes)
            {
                dataGridView1.Rows.Add(cliente.per);
            }*/
            dataGridView1.DataSource = clientes;
        }

        private void ShowTex(List<Elemento> elementos)
        {
            tbInfoClientes.Text = "";
            foreach (Elemento e in elementos)
            {
                
                tbInfoClientes.Text += e.id + " %" + e.per+"\n";
            }
        }
    }
}
