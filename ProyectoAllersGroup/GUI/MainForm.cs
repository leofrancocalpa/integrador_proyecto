﻿using System;
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
        private Data inicial;
        public MainForm()
        {
            InitializeComponent();
            inicial = new Data();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
