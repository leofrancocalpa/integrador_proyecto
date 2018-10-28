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
        public String groupName { get; set; }
        public String ciudad { get; set; }
        public String departamento { get; set; }
        public String pago { get; set; }

        public Cliente(String cod)
        {
            codigo = cod;
        }
        
    }
}
