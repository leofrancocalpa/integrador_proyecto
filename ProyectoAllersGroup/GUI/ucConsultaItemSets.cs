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
                }
            }
            textBox1.AppendText(mens);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text="";
            string mens = "";
            foreach (DataGridViewRow row in this.gridFrequentItemSets.SelectedRows)
            {
                ItemSet itemSet = row.DataBoundItem as ItemSet;
                if (itemSet != null)
                {
                    //mens += "Conjunto de Articulos: " + itemSet.id + "\n con Articulos:  " + itemSet.ToString()
                      //  + "\n con un soporte de: " + itemSet.support + "\n tienen las siguientes reglas de asociación: \n";
                    foreach (KeyValuePair<String, Item> item in itemSet.items)
                    {
                        textBox1.AppendText("Cod Item: " + item.Key+ " - Descripcion: " + item.Value.name);
                       
                        textBox1.AppendText("\n");
                    }
                    //List<Model.Rule> rules = principal.analyzer.ruleGenerator.associationRules.Where(x => (x.antecedente.ToString() + x.consecuente.ToString()).Equals(itemSet.ToString())).ToList();
                    //MostrarReglas(rules);
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

        }

        private void gridAsociationRules_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach(DataGridViewRow row in this.gridAsociationRules.SelectedRows)
            {
                ShowRulesForm showRules = new ShowRulesForm();
            }
        }
    }
}
