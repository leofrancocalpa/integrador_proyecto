﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class ucProgressIndicator : DevExpress.XtraEditors.XtraUserControl
    {
        public VentanaPrincipal principal { get; set; }
        public ucProgressIndicator()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            principal.ShowHome();
        }
    }
}
