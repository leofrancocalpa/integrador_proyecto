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
                double minSupport = Convert.ToDouble(Console.ReadLine()) / 100;
                Console.WriteLine("Ingrese minConfidence :");
                double minConfidence = Convert.ToDouble(Console.ReadLine());

                Data data = new Data(false);
                FIGeneration fIGeneration = new FIGeneration();
                fIGeneration.minSupport = minSupport;
                RuleGenerator ruleGenerator = new RuleGenerator(minConfidence);

                ClustersGenerator clustersGenerator = new ClustersGenerator();
                clustersGenerator.minPertencia = 0.60;

                data.LoadTransactions();
                data.LoadClientes();
                Console.WriteLine("--> " + data.transactions.Count);
                data.PodarTransacciones(0.01);
                Console.WriteLine("--> " + data.transactions.Count);
                data.PodarClientes();
                Console.WriteLine("Clientes -> " + data.clientes.Count);
                data.PodarArticulos();
                Console.WriteLine("Items Podados.- " + data.items.Count);

                data.PodarItemsPorSupport(minSupport);
                fIGeneration.AprioriFrequentItemGeneration(4, data);
                List<ItemSet> fi = fIGeneration.candidates.Where(x => x.items.Count > 1).ToList();
                List<ItemSet> fiTotales = fIGeneration.candidates.ToList();
                Console.WriteLine("Itemsets totales: " + fi.Count);
                Console.WriteLine("---------------------------------------- \n Frequents ItemSe Generados... \n Creando Reglas de asociacion ...");
                //Generando Reglas 
                ruleGenerator.generarTodos(fiTotales, data);
                Console.WriteLine(ruleGenerator.associationRUles.Count+"++++++++");
                foreach(Rule rule in ruleGenerator.associationRUles)
                {
                    Console.WriteLine(rule.antecedente.ToString() + " ->" + rule.consecuente.ToString() + " " + rule.confidence);
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
                    Console.WriteLine("Cluster: "+c.agrupador.ToString());
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
