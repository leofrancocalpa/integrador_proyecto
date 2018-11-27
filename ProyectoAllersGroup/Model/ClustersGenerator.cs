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
        public double minPertencia { get; set; }
        private Dictionary<String, Elemento> elementos;
        private Dictionary<String, List<double>> pertenencias;

        public ClustersGenerator()
        {
            clusters = new List<Cluster>();
            elementos = new Dictionary<string, Elemento>();
            pertenencias = new Dictionary<string, List<double>>();
        }

        

        public void GenerarClusters(Dictionary<String, Transaction> transactions, Dictionary<String, Cliente> clientes, List<ItemSet> fItemSets)
        {
            CrearKCentroides(fItemSets);
            Particionar(transactions, clientes);
            ajustarPertenencias();
            Console.WriteLine("Cluster generados");
        }

        private void CrearKCentroides(List<ItemSet> fis)
        {
            foreach(ItemSet itemSet in fis)
            {
                Cluster cl = new Cluster(itemSet);
                clusters.Add(cl);
            }
            Console.WriteLine("Centroides creados: "+clusters.Count);
        }

        private void Particionar(Dictionary<String, Transaction> transactions, Dictionary<String, Cliente> clientes)
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
                    if ((valor/cluster.agrupador.items.Count) >= minPertencia)
                    {
                        if (elementos.ContainsKey(transaccion.Value.codCliente))
                        {
                            if (cluster.elementos.Contains(elementos[transaccion.Value.codCliente]))
                            {
                                if (pertenencias.ContainsKey(cluster.agrupador.ToStringItems() + transaccion.Value.codCliente))
                                {
                                    pertenencias[cluster.agrupador.ToStringItems() + transaccion.Value.codCliente].Add((valor / cluster.agrupador.items.Count) * 100);
                                }
                                else
                                {
                                    List<double> list = new List<double>();
                                    list.Add(valor / cluster.agrupador.items.Count);
                                    pertenencias.Add(cluster.agrupador.ToStringItems() + transaccion.Value.codCliente, list);
                                }
                            }
                            else
                            {
                                cluster.elementos.Add(elementos[transaccion.Value.codCliente]);
                                if (pertenencias.ContainsKey(cluster.agrupador.ToStringItems() + transaccion.Value.codCliente))
                                {
                                    pertenencias[cluster.agrupador.ToStringItems() + transaccion.Value.codCliente].Add((valor / cluster.agrupador.items.Count) * 100);
                                }
                                else
                                {
                                    List<double> list = new List<double>();
                                    list.Add(valor / cluster.agrupador.items.Count);
                                    pertenencias.Add(cluster.agrupador.ToStringItems() + transaccion.Value.codCliente, list);
                                }
                            }
                        }
                        else
                        {
                            Elemento elemento = new Elemento(clientes[transaccion.Value.codCliente], (valor/ cluster.agrupador.items.Count));
                            elementos.Add(elemento.id, elemento);
                            cluster.elementos.Add(elemento);
                            if (pertenencias.ContainsKey(cluster.agrupador.ToStringItems() + transaccion.Value.codCliente))
                            {
                                pertenencias[cluster.agrupador.ToStringItems() + transaccion.Value.codCliente].Add((valor / cluster.agrupador.items.Count)*100);
                            }
                            else
                            {
                                List<double> list = new List<double>();
                                list.Add(valor / cluster.agrupador.items.Count);
                                pertenencias.Add(cluster.agrupador.ToStringItems() + transaccion.Value.codCliente, list);
                            }
                        }
                    }   
                }
            }
            Console.WriteLine("Particionado de datos");
        }

        private void ajustarPertenencias()
        {
            //Console.WriteLine("clusters ajuste "+clusters.Count);
            foreach (Cluster Ci in clusters)
            {
                foreach(Elemento e in Ci.elementos)
                {
                    //Console.WriteLine("Average ANtes");
                    //Console.WriteLine(Ci.agrupador.ToString() + e.cliente.codigo + "");
                    e.pertenencia = pertenencias[Ci.agrupador.ToStringItems() + e.cliente.codigo].Average();
                    e.pertenencia = Math.Round(e.pertenencia, 1);
                    //Console.WriteLine("Average despues");
                }
            }
            Console.WriteLine("Ajuste de pertenecias");
        }

    }
}
