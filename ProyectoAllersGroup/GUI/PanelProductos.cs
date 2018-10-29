using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PanelProductos : Form
    {
        private VetanaPrincipal ventana;
        public PanelProductos(VetanaPrincipal principal)
        {
            ventana = principal;
            InitializeComponent();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(numeroCombinaciones.Text);
            double umbral = Convert.ToDouble(Umbral.Text);
            umbral = umbral / 100;
            List<String> mostrar = ventana.generarItemsFrecuentes(umbral, cantidad);
            for (int i = 0; i < mostrar.Count; i++)
            {
                String[] datos = mostrar[i].Split(';');
                ListViewItem nuevo = new ListViewItem(datos[0]);
                nuevo.SubItems.Add(datos[1]);
                vistaProductos.Items.Add(nuevo);
            }
            
        }
    }
}
