using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Item
    {
        public String cod { get; set; }
        public String name { get; set; }
        public double price { get; set; }
        public int support { get; set; }

        public Item(String cod)
        {
            this.cod = cod;
            this.name = "";
            support = 0;
        }

        public void IncreaserCount()
        {
            support++;
        }
    }
}
