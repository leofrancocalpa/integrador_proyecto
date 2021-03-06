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
using Model;

namespace GUI
{
    public partial class ucConsultaItemSets : DevExpress.XtraEditors.XtraUserControl
    {
        public VentanaPrincipal principal { get; set; }
        public List<ItemSet> itemSets { get; set; }

        public ucConsultaItemSets()
        {
            InitializeComponent();
            gridFrequentItemSets.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
            gridAsociationRules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gridFrequentItemSets.DataSource = itemSets;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = "";
            string mens = "";
            foreach (DataGridViewRow row in this.gridFrequentItemSets.SelectedRows)
            {
                ItemSet itemSet = row.DataBoundItem as ItemSet;
                if (itemSet != null)
                {
                    //mens += "Conjunto de Articulos: " +itemSet.id + "\n con Articulos:  " + itemSet.ToString()
                   //     +"\n con un soporte de: "+itemSet.support+"\n tienen las siguientes reglas de asociación: \n";
                    foreach(KeyValuePair<String, Item> item in itemSet.items)
                    {
                        textBox1.AppendText("Cod Item: " + item.Key + " - Descripcion: " + item.Value.name);

                        textBox1.AppendText("\n");
                    }
                    List<Model.Rule> rules = principal.analyzer.ruleGenerator.associationRules;//.Where(x => (x.padre.Equals(x.padre, itemSet))).ToList();
                    MostrarReglas(rules);
                }
            }
            textBox1.AppendText(mens);

        }
        

        private void MostrarReglas(List<Model.Rule> rules)
        {
            gridAsociationRules.DataSource = rules;
        }

        private void gridAsociationRules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in this.gridAsociationRules.SelectedRows)
            {
                Model.Rule rule = row.DataBoundItem as Model.Rule;
                if (rule != null)
                {
                    String ant = rule.ToStringAntecedente();
                    String con = rule.ToStringConsecuente();
                    MessageBox.Show("Si compran: \n"+ant + " \nPodrían comprar: \n" + con+"\n"+"con una confianza de: "+rule.confidence+"%");
                }
            }
        }

        

        private void ShowReglas(List<Model.Rule> reglas)
        {
            gridAsociationRules.Columns.Clear();
            gridAsociationRules.Rows.Clear();
            DataGridViewColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "ANTECEDENTE";
            DataGridViewColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "CONSECUENTE";
            DataGridViewColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "CONFIANZA";
            gridAsociationRules.Columns.Add(c1);
            gridAsociationRules.Columns.Add(c2);
            gridAsociationRules.Columns.Add(c3);

            foreach (Model.Rule regla in reglas)
            {
                gridAsociationRules.Rows.Add(regla.antecedente.ToStringItems(), regla.consecuente.ToStringItems(), regla.confidence);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            principal.ShowHome();
        }
    }
}
