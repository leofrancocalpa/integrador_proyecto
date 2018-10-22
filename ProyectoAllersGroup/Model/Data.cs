﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Data
    {
        private String routeArticulos = "..\\..\\..\\Data\\Articulos.csv";
        private String routeClientes = "..\\..\\..\\Data\\Clientes.csv";
        private String routeVentas = "..\\..\\..\\Data\\Ventas.csv";
        //private String routeFI = "..\\..\\..\\Data\\FrequentItems.csv";

        //private double minSupport;
        private String route;

        public Dictionary<String, Item> items { get; set; }
        public Dictionary<String, Transaction> transactions { get; set; }
       // public Dictionary<String, Cliente> clientes { get; set; }
        public Dictionary<int,Cliente> clientes { get; set; }
        //public Dictionary<String, Item> frequentItems { get; set; }

        public Data()
        {
            //minSupport = minS;
            items = new Dictionary<String, Item>();
            transactions = new Dictionary<string, Transaction>();
            clientes = new Dictionary<int, Cliente>();
            route = routeVentas;
            LoadClientes();
        }
        public void LoadClientes()
        {
            try
            {
                StreamReader sr = new StreamReader(routeVentas);
                String line = sr.ReadLine();
                line = sr.ReadLine();
                String cliente = "";
                int c = 0;
                while (line != null)
                {
                    String[] datos = line.Split(';');
                    Cliente actual = new Cliente(datos[0]);
                    if (!(actual.codigo.Equals(cliente)))
                    {
                        clientes.Add(c, actual);
                        cliente = actual.codigo;
                        c++;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                     }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void LoadTransactions()
        {
            try
            {
                StreamReader sr = new StreamReader(route);
                String line = sr.ReadLine();
                line = sr.ReadLine();
                while (line != null)
                {

                    String[] datos = line.Split(';');
                    if (transactions.ContainsKey(datos[1]))
                    {
                        Item actualItem = new Item(datos[4]);
                        KeyValuePair<String, Item> itemtoIn = new KeyValuePair<string, Item>(actualItem.cod, actualItem);
                        if (!transactions[datos[1]].itemsInTransaction.items.ContainsKey(actualItem.cod))
                        {
                            transactions[datos[1]].itemsInTransaction.items.Add(actualItem.cod, actualItem);
                        }
                        if (!items.ContainsKey(datos[4]))
                        {
                            items.Add(actualItem.cod, actualItem);
                        }
                        items[datos[4]].IncreaserCount();
                    }
                    else
                    {
                        Transaction actualTransaction = new Transaction(datos[0], datos[1], datos[2]);
                        transactions.Add(datos[1], actualTransaction);
                        Item actualItem = new Item(datos[4]);
                        KeyValuePair<String, Item> itemtoIn = new KeyValuePair<string, Item>(actualItem.cod, actualItem);
                        actualTransaction.itemsInTransaction.items.Add(actualItem.cod, actualItem);
                        if (!items.ContainsKey(datos[4]))
                        {
                            items.Add(actualItem.cod, actualItem);
                        }
                        items[datos[4]].IncreaserCount();
                        //Console.WriteLine(datos[1]);
                    }

                    line = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine("Numero de items: "+items.Count());
                Console.WriteLine("Numero de transacciones: " + transactions.Count);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error LoadTransaction: \n" + e.StackTrace+"\n error: \n" + e.Message);
            }
        }

        public Dictionary<String, Item> PodarItemsPorSupport(double minSupport)
        {
            Dictionary<String, Item> frequentItems = new Dictionary<string, Item>();
            foreach(KeyValuePair<String, Item> pairs in items)
            {
                int c = pairs.Value.support;
                //Console.WriteLine(pairs.Key + " " + c);
                if (c>=(minSupport*transactions.Count))
                {
                    frequentItems.Add(pairs.Key, pairs.Value);
                }
            }
            items = frequentItems;
            Console.WriteLine("Items frecuentes: " + frequentItems.Count);
            return frequentItems;
            
            //frequentItems.ToList().ForEach(x => Console.WriteLine(x.Value.countSupport));
        }
        public void loadDataTest()
        {
            route = "..\\..\\..\\Data\\datosTest.csv";
        }

        public void PodarTransacciones()
        {

        }

        public void PodarClientes()
        {

        }
    }
}
