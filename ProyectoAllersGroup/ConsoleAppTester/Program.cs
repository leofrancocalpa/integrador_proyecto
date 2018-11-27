using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConsoleAppTester
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine();
            //Console.ReadLine();
            try
            {
                Console.WriteLine("Ingrese minSupport :");
                double minSupport = 0.005;//Convert.ToDouble(Console.ReadLine()) / 100;
                Console.WriteLine("Ingrese minConfidence :");
                double minConfidence = Convert.ToDouble(Console.ReadLine())/100;

                Data data = new Data(false);
                FIGeneration fIGeneration = new FIGeneration();
                fIGeneration.minSupport = minSupport;
                RuleGenerator ruleGenerator = new RuleGenerator();
                ruleGenerator.minConfidence = minConfidence;

                ClustersGenerator clustersGenerator = new ClustersGenerator();
                clustersGenerator.minPertencia = 0.60;

                data.LoadTransactions();
                data.LoadClientes();
                Console.WriteLine("--> " + data.transactions.Count);
                data.PodarTransacciones(0.003);
                Console.WriteLine("--> " + data.transactions.Count);
                data.PodarClientes();
                Console.WriteLine("Clientes -> " + data.clientes.Count);
                data.PodarArticulos();
                Console.WriteLine("Items Podados.- " + data.items.Count);

                data.PodarItemsPorSupport(minSupport);
                fIGeneration.AprioriFrequentItemGeneration(3, data);
                List<ItemSet> fi = fIGeneration.candidates.Where(x => x.items.Count > 1).ToList();
                List<ItemSet> fiTotales = fIGeneration.candidates.ToList();
                Console.WriteLine("Itemsets totales: " + fi.Count);
                Console.WriteLine("---------------------------------------- \n Frequents ItemSe Generados... \n Creando Reglas de asociacion ...");
                //Generando Reglas 
                ruleGenerator.GenerarReglas(fi, fIGeneration);
                Console.WriteLine(ruleGenerator.associationRules.Count+"++++++++");
                foreach(Rule rule in ruleGenerator.associationRules)
                {
                    Console.WriteLine(rule.antecedente.ToStringItems() + " ->" + rule.consecuente.ToStringItems() + " " + rule.confidence);
                }

                //Generando CLusters
                clustersGenerator.GenerarClusters(data.transactions, data.clientes, fi);

                /*
                Analyzer analyzer = new Analyzer();
                analyzer.minPertenencia = 0.75;
                analyzer.minPertenencia = 0.75;
                analyzer.minSupport = 0.01;
                analyzer.LoadData();
                analyzer.PodarDatos(0.1/100);
                //analyzer.data.PodarItemsPorSupport(0.1);
                
                analyzer.GenerarFrequentItemSets(2);
                Console.WriteLine(analyzer.fIGeneration.candidates.Count);*/
                
                foreach (ItemSet itemset in fIGeneration.candidates)
                {
                    String cods = "";
                    itemset.items.ToList().ForEach(x => cods += x.Value.cod + " ");
                    Console.WriteLine("Conjunto frecuente -> Support: " + itemset.support + " Conjunto: " + cods);

                }
            //    List<ItemSet> fi = fIGeneration.candidates.Where(x => x.items.Count > 1).ToList();
            //    clustersGenerator.GenerarClusters(data.transactions, data.clientes, fi);

                foreach(Cluster c in clustersGenerator.clusters)
                {
                    Console.WriteLine("Cluster: "+c.agrupador.ToStringItems());
                    foreach(Elemento e in c.elementos)
                    {
                        Console.WriteLine("Elemento: "+e.id+" pertenece un "+e.pertenencia+" al cluster");
                    }
                }
                Console.WriteLine(" Clusters final " + clustersGenerator.clusters.Count);
                Console.WriteLine("Terminó!");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error main: " + e.Message + "\n" + e.StackTrace);
                Console.ReadLine();
            }

            
        }
    }
}
