using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ItemSet 
    {
        public String id { get; set; }
        public int support { get; set; }
        public Dictionary<String, Item> items { get; set; }

        public ItemSet()
        {
            items = new Dictionary<string, Item>();
            support = 0;
        }
       

        public void IncreaseSupport()
        {
            support+=1;
        }

        public Boolean ContainsItems(Dictionary<String, Item> evaluated)
        {
            Boolean salida = false;
            int count = 0;
            foreach(KeyValuePair<String, Item> pairs in evaluated)
            {
                if (items.ContainsKey(pairs.Key))
                {
                    count++;
                }
            }
            if (count == evaluated.Count)
            {
                salida = true;
            }
            return salida;
        }

        public String ToString()
        {
            String salida = "";
            foreach(KeyValuePair<String, Item> i in items)
            {
                salida += i.Key+" ";
            }
            return salida;
        }

        public void generarId()
        {
            id = ToString();
        }

        public bool Equals(ItemSet x, ItemSet y)
        {
            if (x.items.Count == y.items.Count)
            {
                int coincidencias = 0;
                foreach (KeyValuePair<String, Item> item in x.items)
                {
                    if (y.items.ContainsKey(item.Key))
                    {
                        coincidencias++;
                    }
                }
                if (coincidencias == x.items.Count)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

    }
}
