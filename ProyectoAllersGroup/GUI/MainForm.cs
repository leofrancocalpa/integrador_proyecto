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
    public partial class MainForm : Form
    {
        private VetanaPrincipal ventana;
        private Data inicial;
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void botIngresar_Click(object sender, EventArgs e)
        {
             ventana = new VetanaPrincipal();
             ventana.Show();
        }
    }
}
