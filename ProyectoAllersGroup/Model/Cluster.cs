using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Cluster
    {
        public List<Cliente> elementos { get; set; }
        public ItemSet agrupador;

        public Cluster(ItemSet cen)
        {
            agrupador = cen;
        }
    }
}
