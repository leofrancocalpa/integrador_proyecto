using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace GUI
{
    public partial class VetanaPrincipal : Form
    {
        private Data inicial;
        private FIGeneration frecuentes;
        private PanelTransacciones trans;
        private PanelClientes cli;
        private PanelProductos produ;
        public VetanaPrincipal()
        {
            InitializeComponent();
            inicial = new Data(false);
        }

        private void VetanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        // private void butProductos_Click(object sender, EventArgs e)
        //  {
        //
        //}

        //private void butTransacciones_Click(object sender, EventArgs e)
        //{
        //
        //}

        private void IngresarProductos_Click(object sender, EventArgs e)
        {
            produ = new PanelProductos(this);
            produ.Show();
        }

        private void IngresarTransacciones_Click(object sender, EventArgs e)
        {
            trans = new PanelTransacciones();
            trans.Show();
        }

        private void IngresarClientes_Click(object sender, EventArgs e)
        {
            cli = new PanelClientes();
            cli.Show();
        }
        public List<String> generarItemsFrecuentes(double soporte, int numeroCombinaciones)
        {
            List<String> reporte = new List<String>();
            inicial.LoadTransactions();
            inicial.PodarItemsPorSupport(soporte);
            frecuentes = new FIGeneration(soporte);
            frecuentes.AprioriFrequentItemGeneration(numeroCombinaciones, inicial);
            foreach (ItemSet itemset in frecuentes.candidates)
            {
                String cods = "";
                itemset.items.ToList().ForEach(x => cods += x.Value.cod + " ");
                String mensaje = cods + ";" + itemset.support;
                Console.WriteLine("Conjunto frecuente -> Support: " + itemset.support + " Conjunto: " + cods);
                reporte.Add(mensaje);
            }
            return reporte;

        }
        
}
}
