using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Analyzer
    {
        public Data data { get; set; }
        public FIGeneration fIGeneration { get; set; }
        public RuleGenerator ruleGenerator { get; set; }
        public ClustersGenerator clustersGenerator { get; set; }
        public double minSupport { get; set; }
        public double minConfidence { get; set; }
        public double minPertenencia { get; set; }

        public Analyzer()
        {
            data = new Data(false);
            fIGeneration = new FIGeneration();
            clustersGenerator = new ClustersGenerator();
        }

        public bool LoadData()
        {
            try
            {
                data.LoadTransactions();
                data.LoadClientes();
                return true;
            }
            catch(Exception e)//pendiente lanzar excepcion
            {
                return false;
            }
        }

        public void PodarDatos(double minTransactions)
        {
            data.PodarTransacciones(minTransactions);
            data.PodarClientes();
            data.PodarArticulos();
            
        }

        public void GenerarFrequentItemSets(int maxItemSetsLength)
        {
            data.PodarItemsPorSupport(minSupport);
            fIGeneration.minSupport = minSupport;
            fIGeneration.AprioriFrequentItemGeneration(maxItemSetsLength, data);
        }

        public List<ItemSet> GetItemSets()
        {
            return fIGeneration.candidates;
        }

        public void GenerarReglas()
        {

        }

        public void GenerarClusters()
        {
            List<ItemSet> fIS = fIGeneration.candidates.Where(x => (x.items.Count > 1)).ToList();
            clustersGenerator.GenerarClusters(data.transactions, data.clientes, fIS);
        }


    }
}
