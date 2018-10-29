using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ClustersGenerator
    {
        public List<Cluster> clusters { get; set; }

        public ClustersGenerator()
        {
            clusters = new List<Cluster>();
        }

        public void GenerarClusters(Dictionary<String, Transaction> transactions, Dictionary<String, Cliente> clientes, List<ItemSet> fItemSets)
        {
            CrearKCentroides(fItemSets);
        }

        public void CrearKCentroides(List<ItemSet> fis)
        {
            foreach(ItemSet itemSet in fis)
            {
                Cluster cl = new Cluster(itemSet);
                clusters.Add(cl);
            }
        }

        public void Particionar(Dictionary<String, Transaction> transactions, Dictionary<String, Cliente> clientes)
        {
            foreach(Cluster cluster in clusters)
            {
                foreach (KeyValuePair<String, Transaction> transaccion in transactions)
                {
                    int valor = 0;
                    foreach (KeyValuePair<String, Item> item in cluster.agrupador.items)
                    {
                        if (transaccion.Value.itemsInTransaction.items.ContainsKey(item.Key))
                        {
                            valor++;
                        }
                    }
                    if (valor == cluster.agrupador.items.Count)
                    {
                        cluster.elementos.Add(clientes[transaccion.Value.codCliente]);
                    }
                }
            }
        }
        


    }
}
