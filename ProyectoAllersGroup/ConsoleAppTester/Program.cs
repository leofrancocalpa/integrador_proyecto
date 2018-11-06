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
                FIGeneration fIGeneration = new FIGeneration(minSupport);
                RuleGenerator ruleGenerator = new RuleGenerator(minConfidence);
                ClustersGenerator clustersGenerator = new ClustersGenerator(0.75);

                data.LoadTransactions();
                data.PodarItemsPorSupport(minSupport);
                fIGeneration.AprioriFrequentItemGeneration(4,data);

                foreach (ItemSet itemset in fIGeneration.candidates)
                {
                    String cods = "";
                    itemset.items.ToList().ForEach(x => cods += x.Value.cod + " ");
                    Console.WriteLine("Conjunto frecuente -> Support: " + itemset.support + " Conjunto: " + cods);

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
