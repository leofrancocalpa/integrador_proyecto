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
        public VetanaPrincipal()
        {
            InitializeComponent();
            inicial = new Data();
        }

        private void VetanaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
