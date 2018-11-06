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
        public double minPertencia { get; }
        private Dictionary<String, Elemento> elementos;
        private Dictionary<String, List<double>> pertenencias;

        public ClustersGenerator(double pert)
        {
            clusters = new List<Cluster>();
            elementos = new Dictionary<string, Elemento>();
            pertenencias = new Dictionary<string, List<double>>();
            minPertencia = pert;
        }

        public void GenerarClusters(Dictionary<String, Transaction> transactions, Dictionary<String, Cliente> clientes, List<ItemSet> fItemSets)
        {
            CrearKCentroides(fItemSets);
            Particionar(transactions, clientes);
            ajustarPertenencias();
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
                    double valor = 0;
                    foreach (KeyValuePair<String, Item> item in cluster.agrupador.items)
                    {
                        if (transaccion.Value.itemsInTransaction.items.ContainsKey(item.Key))
                        {
                            valor++;
                        }
                    }
                    if ((valor/100) >= minPertencia)
                    {
                        if (elementos.ContainsKey(transaccion.Value.codCliente))
                        {
                            if (cluster.elementos.Contains(elementos[transaccion.Value.codCliente]))
                            {
                                if (pertenencias.ContainsKey(cluster.agrupador.ToString() + transaccion.Value.codCliente))
                                {
                                    pertenencias[cluster.agrupador.ToString() + transaccion.Value.codCliente].Add(valor / 100);
                                }
                                else
                                {
                                    List<double> list = new List<double>();
                                    list.Add(valor / 100);
                                    pertenencias.Add(cluster.agrupador.ToString() + transaccion.Value.codCliente, list);
                                }
                            }
                            else
                            {
                                cluster.elementos.Add(elementos[transaccion.Value.codCliente]);
                                if (pertenencias.ContainsKey(cluster.agrupador.ToString() + transaccion.Value.codCliente))
                                {
                                    pertenencias[cluster.agrupador.ToString() + transaccion.Value.codCliente].Add(valor / 100);
                                }
                                else
                                {
                                    List<double> list = new List<double>();
                                    list.Add(valor / 100);
                                    pertenencias.Add(cluster.agrupador.ToString() + transaccion.Value.codCliente, list);
                                }
                            }
                        }
                        else
                        {
                            Elemento elemento = new Elemento(clientes[transaccion.Value.codCliente], (valor/100));
                            elementos.Add(transaccion.Value.codCliente, elemento);
                            cluster.elementos.Add(elemento);
                        }
                    }   
                }
            }
        }

        public void ajustarPertenencias()
        {
            foreach (Cluster Ci in clusters)
            {
                foreach(Elemento e in Ci.elementos)
                {
                    e.pertenencia = pertenencias[Ci.agrupador.ToString() + e.id].Average();
                }
            }
        }

    }
}
