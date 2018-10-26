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

            Console.WriteLine("Ingrese minSupport :");
            double minSupport = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese minConfidence :");
            double minConfidence = Convert.ToDouble(Console.ReadLine());

            Data data = new Data(true);
            FIGeneration fIGeneration = new FIGeneration(minSupport, true);
            RuleGenerator ruleGenerator = new RuleGenerator(minConfidence);
            ClustersGenerator clustersGenerator = new ClustersGenerator();

            data.LoadTransactions();
            data.PodarItemsPorSupport(minSupport);
        }
    }
}
