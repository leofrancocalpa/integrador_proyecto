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
        private int c;
        public PanelProductos(VetanaPrincipal principal)
        {
            ventana = principal;
            InitializeComponent();
            c = 0;
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {

            ListViewItem lista = new ListViewItem(c+"");
            lista.SubItems.Add("HOLI");
            lista.SubItems.Add("PERRA");
            c++;
            vistaProductos.Items.Add(lista);
        }
    }
}
