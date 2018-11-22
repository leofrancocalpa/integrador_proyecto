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
        public List<Rule> associationRules { get; set; }

        public RuleGenerator()
        {
            associationRules = new List<Rule>();
        }

        public void GenerarReglas(List<ItemSet> itemSets, FIGeneration fIGeneration)
        {
            foreach(ItemSet itemSet in itemSets)
            {
                int enumerador = itemSet.items.Count-1;
                int indicador = 0;
                
                
                for(int index=0; index <itemSet.items.Count-1;index++)
                {
                    ItemSet[] antecedenteConsecuente = Particionar(itemSet, index);
                    ItemSet antecedente = antecedenteConsecuente[0];
                    ItemSet consecuente = antecedenteConsecuente[1];
                    Rule rulePrincipal = new Rule();
                    rulePrincipal.antecedente = antecedente;
                    rulePrincipal.consecuente = consecuente;
                    rulePrincipal.padre = itemSet;
                    associationRules.Add(rulePrincipal);
                    //swap
                    for(int i=antecedente.items.Count-1; i>-1; i--)
                    {
                        for(int j=0; j<consecuente.items.Count; j++)
                        {
                            ItemSet ant1 = new ItemSet();
                            ItemSet con1 = new ItemSet();
                            KeyValuePair<String, Item> itemAnt = antecedente.items.ElementAt(i);
                            KeyValuePair<String, Item> itemCon = consecuente.items.ElementAt(j);
                            foreach(KeyValuePair<String, Item> itemA in antecedente.items)
                            {
                                if (itemA.Key.Equals(itemAnt.Key))
                                {
                                    ant1.items.Add(itemCon.Key,itemCon.Value);
                                }
                                else
                                {
                                    ant1.items.Add(itemA.Key, itemA.Value);
                                }
                            }
                            foreach(KeyValuePair<String, Item> itemC in consecuente.items)
                            {
                                if (itemC.Key.Equals(itemCon.Key))
                                {
                                    con1.items.Add(itemAnt.Key, itemAnt.Value);
                                }
                                else
                                {
                                    con1.items.Add(itemC.Key, itemC.Value);
                                }
                            }
                            Rule newRule = new Rule();
                            newRule.antecedente = ant1;
                            newRule.consecuente = con1;
                            newRule.padre = itemSet;
                            associationRules.Add(newRule);
                        }
                    }
                }

                CalcularConfianza(fIGeneration);
                Prunning();
            }
        }

        public ItemSet[] Particionar(ItemSet itemSet, int indice)
        {
            int indice2 = indice + 0;
            int numCons = indice + 1;
            ItemSet[] salida = new ItemSet[2];
            ItemSet antecedente = new ItemSet();
            ItemSet consecuente = new ItemSet();
            List<Item> items = new List<Item>();
            for(int i=0; i<numCons; i++)
            {
                int index = (itemSet.items.Count - 1) - indice2;
                Item item = itemSet.items.ElementAt(index).Value;
                items.Add(item);
                indice2--;
            }
            foreach(Item item in items)
            {
                consecuente.items.Add(item.cod, item);
            }
            List<KeyValuePair<String, Item>> itemsAnt = itemSet.items.Where(x => !(consecuente.items.ContainsKey(x.Key))).ToList();
            foreach(KeyValuePair<String, Item> item in itemsAnt)
            {
                antecedente.items.Add(item.Key, item.Value);
            }
            salida[0] = antecedente;
            salida[1] = consecuente;

            return salida;
        }

        private void CalcularConfianza(FIGeneration fIGeneration)
        {
            foreach(Rule rule in associationRules)
            {
                double numerador = rule.padre.support;
                double denominador = fIGeneration.candidates.First(x => x.Equals(x, rule.consecuente)).support;
                double confianza = numerador / denominador;
                rule.confidence = Math.Round(confianza,1);
            }
        }

        public void Prunning()
        {
            for(int i=0; i<associationRules.Count; i++)
            {
                if (associationRules.ElementAt(i).confidence < minConfidence)
                {
                    associationRules.RemoveAt(i);
                }
                
            }
        }
        
    }
}
