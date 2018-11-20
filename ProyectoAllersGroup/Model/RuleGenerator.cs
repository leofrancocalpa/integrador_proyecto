using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RuleGenerator
    {
        public double minConfidence { get; set; }
        public List<Rule> associationRUles { get; set; }

        static Func<int, double> factorial = x => Enumerable.Range(1, x).Aggregate(1.0, (a, b) => a * b);
        static Func<int, int, double> combinatoria = (x, y) => (factorial(x)) / ((factorial(y)) * factorial(x - y));

        public RuleGenerator(double minConf)
        {
            associationRUles = new List<Rule>();
            minConfidence = minConf;
        }
        public List<Rule>generarTodos(List<ItemSet>frecuentes, Data datos)
        {
            List<Rule> devolver = new List<Rule>();
            List<ItemSet> copia = (frecuentes as IEnumerable<ItemSet>).ToList();
            List<Item> objetos = new List<Item>();
            foreach (ItemSet objeto in copia)
            {
                foreach (KeyValuePair<String,Item> item in objeto.items)
                {
                    objetos.Add(item.Value);
                }
            }
            Boolean termino = false;
            int pos = 0;
            int pos2 = 1;
            while (!termino)
            {
                ItemSet antecedente = new ItemSet();
                antecedente.items.Add(objetos[pos].cod,objetos[pos]);
                ItemSet consecuente = new ItemSet();
                consecuente.items.Add(objetos[pos2].cod, objetos[pos]);
                if (pos2 + 1 < objetos.Count)
                {
                consecuente.items.Add(objetos[pos2+1].cod, objetos[pos2]);
                }
                double ante = objetos[pos].support;
                double conse = supportSubitemset(consecuente, datos);
                double respuesta = conse / ante;
                if (respuesta >= minConfidence && respuesta<=1)
                {
                    Rule regla = new Rule();
                    regla.antecedente = antecedente;
                    regla.consecuente = consecuente;
                    regla.confidence = respuesta;
                    associationRUles.Add(regla);
                }
                if (pos2 >= objetos.Count - 1)
                {
                    pos++;
                    pos2 = pos + 1;
                }
                else
                {
                    pos2++;
                }
                if (pos - 1 == objetos.Count - 2)
                {
                    termino = true;
                }

                // demas
                Boolean nuevo = false;
                int avanzar = 1;
                int estatica = 0;
                int iteracion = 2;
                    ItemSet izquierda = new ItemSet();
                Boolean lleno = false;
                double izq = 0;
                double derecha = 0;
                while (!nuevo)
                {
                    if (lleno == false)
                    {
                    for (int i = 0; i < iteracion; i++)
                    {
                        izquierda.items.Add(objetos[i].cod, objetos[i]);
                    }
                        lleno = true;
                    }
                    ItemSet actual = new ItemSet();
                    int estatico = iteracion;
                    int parada = (estatico + 1) + avanzar;
                    for (int i = estatico+1; i < parada; i++)
                    {
                        actual.items.Add(objetos[i].cod, objetos[i]);

                    }
                    izq = supportSubitemset(izquierda, datos);
                    derecha = supportSubitemset(actual, datos);
                    double answert = derecha / izq;
                    if (answert >= minConfidence)
                    {
                        Rule regla = new Rule();
                        regla.antecedente = izquierda;
                        regla.consecuente = actual;
                        regla.confidence = answert;
                        associationRUles.Add(regla);
                    }
                    if (parada < objetos.Count - 1)
                    {
                        avanzar++;
                        actual.items.Clear();
                    }
                    else
                    {
                        lleno = false;
                        izquierda.items.Clear();
                        iteracion++;
                        avanzar = iteracion + 1;
                    }
                    if (iteracion==objetos.Count - 2)
                    {
                        nuevo = true;
                    }
                }
               

            }
            Console.WriteLine(associationRUles.Count + "<--------------------");
            return associationRUles;
        }

        public List<Rule> generar(List<ItemSet> frecuentes, Data data)
        {
            // lista de 3
            //cojo 2 items
            //esos 2 items les busco cuantas veces aparecen
            //busco cuantas veces aparece la lista de 3
            //confianza =#veceslista3/#veceslista2
            // si soporte<confianza 1 y 2 implican 3
           List<ItemSet> mirar = (frecuentes as IEnumerable<ItemSet>).ToList();
            foreach (ItemSet itemSet in mirar)
            {

                //Conjunto de items sacados del itemset frecuente 
                Item[] actual = new Item[itemSet.items.Count];
                double soporteDelItemset = itemSet.support;
                int i = 0;
                //llena el arreglo de items "actual" con items pertenecientes al itemset.
                foreach (KeyValuePair<String, Item> item in itemSet.items)
                {
                    item.Value.visitado = false;
                    actual[i] = item.Value;
                    i++;
                }
                //caso base
                Boolean primero = false;
                int posicion = actual.Length - 1;
                while (!primero)
                {
                    // forma a,b,c->d
                    ItemSet recorrido = new ItemSet();
                    recorrido.items.Add(actual[posicion].cod, actual[posicion]);
                    actual[posicion].visitado = true;
                    ItemSet demas = new ItemSet();
                    // llena el itemset a buscar, osea {a,b,c} a ver si implica ->d
                    for (int j = 0; j < actual.Length; j++)
                    {
                        if (actual[j].visitado == false)
                        {
                            demas.items.Add(actual[j].cod, actual[j]);
                        }
                    }
                    //llenar esto
                    double conjuntoSubitems = supportSubitemset(demas, data);
                    double respuesta = conjuntoSubitems / (double)recorrido.support;
                    Console.WriteLine(respuesta + ">" + minConfidence);
                    if (respuesta >= minConfidence)
                    {
                        Rule regla = new Rule();
                        regla.antecedente = demas;
                        regla.consecuente = recorrido;
                        regla.confidence = respuesta;
                        associationRUles.Add(regla);
                        actual[posicion].generaRegla = true;
                    }
                    posicion--;
                    if (posicion < 0)
                    {
                        primero = true;
                    }
                }
                //combinaciones
            
            }
           
            return associationRUles;
        }
        public int supportSubitemset(ItemSet subconjunto, Data datos)
        {
            subconjunto.support = 0;
            Dictionary<String, Transaction> transactions = datos.transactions;
            foreach (KeyValuePair<String, Transaction> transaccion in transactions)
            {
                int valor = 0;
                foreach (KeyValuePair<String, Item> item in subconjunto.items)
                {
                    if (transaccion.Value.itemsInTransaction.items.ContainsKey(item.Key))
                    {
                        valor++;

                    }
                }

                if (valor == subconjunto.items.Count)
                {
                    subconjunto.IncreaseSupport();
                }

            }
            return subconjunto.support;


        }

        public double cuantasPosiblesReglas(double k)
        {
            double r = Math.Pow(2, k) - 2;
            return r;
        }

        public void PrunningRules()
        {

        }
    }
}
