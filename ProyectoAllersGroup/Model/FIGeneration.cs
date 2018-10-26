﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FIGeneration
    {
        private double minSupport;
        //private Data datos;
        public List<ItemSet> candidates { get; set; }
        public List<ItemSet> fItemSets { get; set; }

        //Constructor
        public FIGeneration(double minSup, Boolean test)
        {
            minSupport = minSup/100;
            //datos = new Data();
            /*if (test)
            {
                datos.loadDataTest();
            }
            datos.LoadTransactions();
            //datos.FiltrarPorSupport();*/
            candidates = new List<ItemSet>();
            fItemSets = new List<ItemSet>();
        }

        //Frequent Intemset Generation Apriori Algorithm 

        public void FrequentItemGeneration(int j, Data datos)
        {
            int k = 1; // size k of itemset (k-itemset)
            Dictionary<String, Item> Fk = datos.items;

            Console.WriteLine("Numero de candidatos T0: " + candidates.Count + " fk " + Fk.Count);
            while (k <= j)
            {
                Console.WriteLine("Iteracion: " + k);
                IEnumerable<ItemSet> Ck = loadItemSet(Fk, k);
                //List<ItemSet> Fks = pruning( Ck.ToList()).ToList();
                Console.WriteLine(">>"+Ck.ToList().Count);
                candidates = candidates.Union(Ck.ToList(), new ItemSetComparator()).ToList();
                Console.WriteLine("candidatos en interacion " + k + " son de tamaño: " + candidates.Count);
                k++;
            }
            SupportCounter(candidates, datos);
            Console.WriteLine("Numero total de candidatos: "+candidates.Count);
            pruning(candidates, datos);
            Console.WriteLine("Numero de conjuntos frcuentes: " + fItemSets.Count);
        }

        public void AprioriFrequentItemGeneration(Data datos)
        {
            int k = 1; // size k of itemset (k-itemset)
            Dictionary<String, Item> Fk = datos.PodarItemsPorSupport(minSupport);

            Console.WriteLine("Numero de candidatos T0: " + candidates.Count+" fk "+Fk.Count);
            while (k <= Fk.Count)
            {
                Console.WriteLine("Iteracion: " + k);
                IEnumerable<ItemSet> Ck = loadItemSet(Fk, k);
                SupportCounter(Ck.ToList(), datos);
                candidates = candidates.Union(Ck.ToList(), new ItemSetComparator()).ToList();
                Console.WriteLine("candidatos en interacion " + k + " son de tamaño: " + candidates.Count);
                pruning(candidates, datos);
                Console.WriteLine("cand despues de Poda: "+candidates.Count);
                Fk = ItemsToComb(candidates);
                Console.WriteLine("# de items a combinar para k"+(k+1)+" "+Fk.Count);
                k++;
            }
            Console.WriteLine("Numero total de candidatos: " + candidates.Count);
            
            Console.WriteLine("Numero de conjuntos frcuentes: " + fItemSets.Count);
        }

        public IEnumerable<ItemSet> loadItemSet(Dictionary<String, Item> fk, int setLenght)
        {
            Combinacion comb = new Combinacion();
            List<IEnumerable<KeyValuePair<String, Item>>> sets = comb.Combinations(fk, setLenght).ToList();
            Console.WriteLine("Tamaño conjuntos combinado k"+setLenght+" : ********************" + sets.Count);
            List<ItemSet> candidates = new List<ItemSet>();
            foreach (IEnumerable<KeyValuePair<String, Item>> conjunto in sets)
            {
                ItemSet newItemSet = new ItemSet();
                List<KeyValuePair<String, Item>> evaluado = conjunto.ToList();
                evaluado.ForEach(x => newItemSet.items.Add(x.Key, x.Value));
                candidates.Add(newItemSet);
            }
            return candidates;
        }

        public Dictionary<String, Item> ItemsToComb(IEnumerable<ItemSet> sets)
        {
            Dictionary<String, Item> salida = new Dictionary<string, Item>();
            foreach (ItemSet conjunto in sets)
            {
                foreach(KeyValuePair<String, Item> item in conjunto.items)
                {
                    //Console.WriteLine(item.Value.cod + " key item comb");
                    if (!salida.ContainsKey(item.Key))
                    {
                        salida.Add(item.Key, item.Value);
                    }
                }
            }
            return salida;
        }

        //FuerzaBurta
        public void SupportCounter(List<ItemSet> candidates, Data datos)
        {
            Dictionary<String, Transaction> transactions = datos.transactions;
            foreach (ItemSet itemset in candidates)
            {
                //Console.WriteLine("Itemset: -------------");
                foreach (KeyValuePair<String, Transaction> transaccion in transactions)
                {
                    //Console.WriteLine("Transaccion:-----------");
                    int valor = 0;
                    foreach (KeyValuePair<String, Item> item in itemset.items)
                    {
                        //Console.WriteLine("item: >" + item.Key);
                        if (transaccion.Value.itemsInTransaction.items.ContainsKey(item.Key))
                        {
                            valor++;
                            //Console.WriteLine("item entra: " + item);
                        }
                    }
                    //Console.WriteLine("valor: " + valor);
                    if (valor == itemset.items.Count)
                    {
                        itemset.IncreaseSupport();
                    }
                }
                String ite = "";
                itemset.items.ToList().ForEach(x => ite += x.Key + " ");
               // Console.WriteLine("Entro: " +  " " + itemset.countSupport + " <" + ite);
            }
        }
        
        public void pruning(List<ItemSet> candidates, Data datos)
        {
            List<ItemSet> toRemove= new List<ItemSet>();
            foreach(ItemSet itemset in candidates)
            {
                if ((itemset.support < minSupport * datos.transactions.Count))
                {
                    Console.WriteLine("Pruning -"+itemset+ "- soporte del candidato: "+itemset.support + " Soporte minimo: " + minSupport*datos.transactions.Count);
                    //fItemSets.Add(itemset);
                    toRemove.Add(itemset);
                }
            }
            foreach(ItemSet IS in toRemove)
            {
                candidates.Remove(IS);
            }
            //Console.WriteLine("--+"+candidates.Count);
        }
    }
}
