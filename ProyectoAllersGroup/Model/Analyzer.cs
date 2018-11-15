using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Analyzer
    {
        public Data data { get; }
        public FIGeneration fIGeneration { get; }
        public ClustersGenerator clustersGenerator { get; }
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
            data.PodarItemsPorSupport(minSupport);
        }

        public void GenerarFrequentItemSets(int maxItemSetsLength)
        {
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
            clustersGenerator.GenerarClusters(data.transactions, data.clientes, fIGeneration.candidates);
        }

        public List<Cluster> GetClusters()
        {
            return clustersGenerator.clusters;
        }

    }
}
