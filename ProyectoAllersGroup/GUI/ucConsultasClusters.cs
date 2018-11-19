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
                if (cluster != null)
                {
                    List<Cliente> clientes = new List<Cliente>();
                    foreach (Elemento elemento in cluster.elementos)
                    {
                        clientes.Add(elemento.cliente);
                    }
                    ShowClientes(clientes);
                }
                
            }
        }

        private void gridViewCLusters_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ShowClientes(List<Cliente> clientes)
        {
            dataGridView1.DataSource = clientes;
        }
    }
}
