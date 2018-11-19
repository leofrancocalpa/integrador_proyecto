using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RuleGenerator
    {
        public double minConfidence { get; set; }
        public List<Rule> associationRules { get; } 

        public RuleGenerator(double minConf)
        {
            associationRules = new List<Rule>();
            minConfidence = minConf;
        }

        public void GenerateRules(List<ItemSet> frequentsItemSets)
        {
            // lista de 3
            //cojo 2 items
            //esos 2 items les busco cuantas veces aparecen
            //busco cuantas veces aparece la lista de 3
            //confianza =#veceslista3/#veceslista2
            // si soporte<confianza 1 y 2 implican 3
            foreach (ItemSet itemSet in frequentsItemSets)
            {
                Item[] actual = new Item[itemSet.items.Count-1];
                int i = 0;
                double suporteA = itemSet.support;
                foreach(KeyValuePair<String, Item> item in itemSet.items)
                {
                    actual[i] = item.Value;
                    i++;
                }
                for (int j = 0; j <actual.Length; j++)
                {
                    double suporteJ = actual[j].support;
                    double respuestaA = itemSet.support / suporteJ;
                    if (respuestaA > itemSet.support)
                    {
                        ItemSet emergencia = new ItemSet();
                        KeyValuePair<String, Item> itemToIn = new KeyValuePair<string, Item>(actual[j].cod, actual[j]);
                        emergencia.items.Add(itemToIn.Key, itemToIn.Value);
                        Rule actu = new Rule();
                        actu.antecedente = emergencia;
                        actu.consecuente = itemSet;
                        actu.confidence = respuestaA;
                    }
                }
               
                
            }
        }

        public void PrunningRules()
        {

        }
    }
}
