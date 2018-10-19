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
        public String name { get; }
        public String description { get; }

        public Cliente(String cod, String nam, String desc)
        {
            codigo = cod;
            name = nam;
            description = desc;
        }
    }
}
