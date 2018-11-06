using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Elemento
    {
        public double pertenencia { get; set; }
        public Cliente cliente { get; set; }
        public String id { get; }

        public Elemento(Cliente cli, double pert)
        {
            cliente = cli;
            id = cli.codigo;
            pertenencia = pert;
        }

    }
}
