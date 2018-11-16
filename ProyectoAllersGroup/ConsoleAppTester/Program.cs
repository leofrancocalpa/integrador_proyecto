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
                clustersGenerator.minPertencia = 0.75;

                data.LoadTransactions();
                data.LoadClientes();
                Console.WriteLine("--> "+data.transactions.Count);
                data.PodarTransacciones(0.01);
                Console.WriteLine("--> "+data.transactions.Count);
                data.PodarClientes();
                Console.WriteLine("Clientes -> "+data.clientes.Count);
                data.PodarArticulos();
                Console.WriteLine("Items Podados.- "+data.items.Count);

                data.PodarItemsPorSupport(minSupport);
                fIGeneration.AprioriFrequentItemGeneration(3,data);

                foreach (ItemSet itemset in fIGeneration.candidates)
                {
                    String cods = "";
                    itemset.items.ToList().ForEach(x => cods += x.Value.cod + " ");
                    Console.WriteLine("Conjunto frecuente -> Support: " + itemset.support + " Conjunto: " + cods);

                }
                List<ItemSet> fi = fIGeneration.candidates.Where(x => x.items.Count > 1).ToList();
                clustersGenerator.GenerarClusters(data.transactions, data.clientes, fi);

                foreach(Cluster c in clustersGenerator.clusters)
                {
                    Console.WriteLine("Cluster: "+c.agrupador.ToString());
                    foreach(Elemento e in c.elementos)
                    {
                        Console.WriteLine("Elemento: "+e.id+" pertenece un "+e.pertenencia+" al cluster");
                    }
                }

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
