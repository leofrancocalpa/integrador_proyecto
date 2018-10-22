using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{   
    public class Cliente
    {
        public String codigo { get; }
        public List<Item> items { get; }

        public Cliente(String cod)
        {
            codigo = cod;
            items = new List<Item>();
        }
        public void agregarItems(Item ti)
        {
            items.Add(ti);
        }
    }
}
