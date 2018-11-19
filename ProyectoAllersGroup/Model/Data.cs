using System;
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
        
        private String route;

        public Dictionary<String, Item> items { get; set; }
        public Dictionary<String, Transaction> transactions { get; set; }
        public Dictionary<String, Cliente> clientes { get; set; }
        public Dictionary<String, Item> frequentItems { get; set; }

        private Dictionary<String, String> trClientes { get; set; }

        public Data(Boolean test)
        {
            //minSupport = minS;
            items = new Dictionary<String, Item>();
            transactions = new Dictionary<string, Transaction>();
            clientes = new Dictionary<String, Cliente>();
            frequentItems = new Dictionary<string, Item>();
            route = routeVentas;
            if (test)
            {
                loadDataTest();
            }
            trClientes = new Dictionary<string, string>();
        }

        public void loadDataTest()
        {
            route = "..\\..\\..\\Data\\datosTest.csv";

        }

        public void LoadClientes()
        {
            try
            {
                StreamReader sr = new StreamReader(routeClientes);
                String line = sr.ReadLine();
                line = sr.ReadLine();
                line = sr.ReadLine();
                while (line != null)
                {
                    String[] datosCliente = line.Split(';');
                    if (!clientes.ContainsKey(datosCliente[0]))
                    {
                        Cliente clienteNuevo = new Cliente(datosCliente[0]);
                        clienteNuevo.groupName = datosCliente[1];
                        clienteNuevo.ciudad = datosCliente[2];
                        clienteNuevo.departamento = datosCliente[3];
                        clienteNuevo.pago = datosCliente[4];
                        clientes.Add(clienteNuevo.codigo, clienteNuevo);
                    }
                    line = sr.ReadLine();
                }
                Console.WriteLine("clientes "+clientes.Count);
                sr.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Cargar Clientes: " + e.Message +"\n" + e.StackTrace);
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
                        actualItem.price = Convert.ToDouble(datos[6]);
                        KeyValuePair<String, Item> itemtoIn = new KeyValuePair<string, Item>(actualItem.cod, actualItem);
                        if (!transactions[datos[1]].itemsInTransaction.items.ContainsKey(actualItem.cod))
                        {
                            transactions[datos[1]].itemsInTransaction.items.Add(actualItem.cod, actualItem);
                        }
                        if (!items.ContainsKey(datos[4]))
                        {
                            items.Add(actualItem.cod, actualItem);
                        }
                        //items[datos[4]].IncreaserCount();
                    }
                    else
                    {
                        Transaction actualTransaction = new Transaction(datos[0], datos[1], datos[2]);
                        transactions.Add(datos[1], actualTransaction);
                        Item actualItem = new Item(datos[4]);
                        actualItem.price = Convert.ToDouble(datos[6]);
                        KeyValuePair<String, Item> itemtoIn = new KeyValuePair<string, Item>(actualItem.cod, actualItem);
                        actualTransaction.itemsInTransaction.items.Add(actualItem.cod, actualItem);
                        if (!items.ContainsKey(datos[4]))
                        {
                            items.Add(actualItem.cod, actualItem);
                        }
                        //items[datos[4]].IncreaserCount();
                        if (!trClientes.ContainsKey(datos[0]))
                        {
                            trClientes.Add(datos[0], datos[0]);
                        }
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
            foreach(KeyValuePair<String, Item> pairs in items)
            {
                int c = pairs.Value.support;
                if (c>=(minSupport*transactions.Count))
                {
                    frequentItems.Add(pairs.Key, pairs.Value);
                }
            }
            items = frequentItems;
            Console.WriteLine("Items frecuentes: " + frequentItems.Count);
            return frequentItems;
        }

        public void PodarTransacciones(double minTransactions)
        {
            int numTransactions = transactions.Count;
            Console.WriteLine(trClientes.Count);
            foreach(KeyValuePair<String, String> cli in trClientes)
            {

                List<KeyValuePair<String, Transaction>> tran = transactions.Where(x => x.Value.codCliente.Equals(cli.Value)).ToList();
                if(tran.Count < numTransactions * minTransactions)
                {
                    foreach(KeyValuePair<String, Transaction> t in tran)
                    {
                        transactions.Remove(t.Key);
                    }
                }
            }
        }

        public void PodarClientes()
        {
            Dictionary<String, String> cli = new Dictionary<string, string>();
            foreach(KeyValuePair<String, Transaction> t in transactions)
            {
                String cc = t.Value.codCliente;
                
                if (!cli.ContainsKey(cc))
                {
                    cli.Add(cc,cc);
                }
            }
            List<KeyValuePair<String, Cliente>> cli1 = clientes.Where(x => !cli.ContainsKey(x.Key)).ToList();
            foreach (KeyValuePair<string, Cliente> cliente in cli1)
            {
                if (clientes.ContainsKey(cliente.Key))
                {
                    clientes.Remove(cliente.Key);
                }
            }
        }

        public void PodarArticulos()
        {
            Dictionary<String, Item> itemsIntransaction = new Dictionary<string, Item>();
            foreach(KeyValuePair<String, Transaction> t in transactions)
            {
                foreach(KeyValuePair<String, Item> item in t.Value.itemsInTransaction.items)
                {
                    items[item.Key].IncreaserCount();
                    if (!itemsIntransaction.ContainsKey(item.Key))
                    {
                        itemsIntransaction.Add(item.Key, item.Value);
                    }
                }
            }
            List<KeyValuePair<String, Item>> itemsARemover = items.Where(x => !itemsIntransaction.ContainsKey(x.Key)).ToList();
            foreach(KeyValuePair<String, Item> item in itemsARemover)
            {
                if (items.ContainsKey(item.Key))
                {
                    items.Remove(item.Key);
                }
            }
            Console.WriteLine("mmmmm " + items.Count);
        }
    }
}
