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
        public List<Rule> associationRUles { get; set; }

        static Func<int, double> factorial = x => Enumerable.Range(1, x).Aggregate(1.0, (a, b) => a * b);
        static Func<int, int, double> combinatoria = (x, y) => (factorial(x)) / ((factorial(y)) * factorial(x - y));

        public RuleGenerator(double minConf)
        {
            associationRUles = new List<Rule>();
            minConfidence = minConf;
        }

        public List<Rule> generar(List<ItemSet> frecuentes)
        {
            // lista de 3
            //cojo 2 items
            //esos 2 items les busco cuantas veces aparecen
            //busco cuantas veces aparece la lista de 3
            //confianza =#veceslista3/#veceslista2
            // si soporte<confianza 1 y 2 implican 3
            List<Rule> lista = new List<Rule>();
            List<ItemSet> mirar = (lista as IEnumerable<ItemSet>).ToList();
            foreach (ItemSet itemSet in mirar)
            {
                
                //Conjunto de items sacados del itemset frecuente 
                Item[] actual = new Item[itemSet.items.Count];
                double soporteDelItemset = itemSet.support;
                int i = 0;
                //llena el arreglo de items "actual" con items pertenecientes al itemset.
                foreach (KeyValuePair<String, Item> item in itemSet.items)
                {
                    item.Value.visitado = false;
                   actual[i] = item.Value;
                    i++;
                }
                //caso base
                Boolean primero = false;
                int posicion = actual.Length-1;
                while (!primero)
                {
                    // forma a,b,c->d
                    ItemSet recorrido=new ItemSet();
                    recorrido.items.Add(actual[posicion].cod,actual[posicion]);
                    actual[posicion].visitado = true;
                    ItemSet demas = new ItemSet();
                    // llena el itemset a buscar, osea {a,b,c} a ver si implica ->d
                    for (int j = 0; j < actual.Length; j++)
                    {
                        if (actual[j].visitado == false)
                        {
                            demas.items.Add(actual[j].cod, actual[j]);
                        }
                    }
                    //llenar esto
                    double suporteSubitem = supportSubitemset(demas, );
                    double respuesta = suporteSubitem / (double)recorrido.support;
                    if (respuesta >= minConfidence)
                    {
                        Rule regla = new Rule();
                        regla.antecedente = demas;
                        regla.consecuente = recorrido;
                        regla.confidence = respuesta;
                        lista.Add(regla);
                        actual[posicion].generaRegla = true;
                    }
                    if (posicion < 0)
                    {
                        primero = true;
                    }
                    actual[posicion].visitado = false;
                    posicion--;
                }
                //combinaciones
              
                
                

                double posibles = cuantasPosiblesReglas(itemSet.items.Count);
            }
                return lista;
        }
            public int  supportSubitemset(ItemSet subconjunto, Data datos)
        {
            subconjunto.support = 0;
            Dictionary<String, Transaction> transactions = datos.transactions;
             foreach (KeyValuePair<String, Transaction> transaccion in transactions)
                {
                    int valor = 0;
                    foreach (KeyValuePair<String, Item> item in subconjunto.items)
                    {
                         if (transaccion.Value.itemsInTransaction.items.ContainsKey(item.Key))
                        {
                            valor++;
                            
                        }
                    }
                    
                    if (valor == subconjunto.items.Count)
                    {
                        subconjunto.IncreaseSupport();
                    }

                }
            return subconjunto.support;
         
             
        }


        public double cuantasPosiblesReglas(double k)
        {
            double r = Math.Pow(2, k)-2;
            return r;
        }

        public void PrunningRules()
        {

        }
    }
}
