using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cluster
    {
        public String Id { get; set; }
        public List<Elemento> elementos { get; set; }
        public List<Double> pertenencias { get; }
        public ItemSet agrupador;
        

        public Cluster(ItemSet cen)
        {
            agrupador = cen;
            elementos = new List<Elemento>();
            pertenencias = new List<double>();
            Id = cen.ToString();
        }

    }
}
