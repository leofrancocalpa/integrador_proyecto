using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rule
    {
        public double confidence { get; set; }
        public String ANTECEDENTE { get; set; }
        public String CONSECUENTE { get; set; }
        public ItemSet antecedente { get; set; }
        public ItemSet consecuente { get; set; }

        public ItemSet padre { get; set; }

        public Rule()
        {
            antecedente = new ItemSet();
            consecuente = new ItemSet();
        }

        public String ToStringAntecedente()
        {
            String salida = "";
            foreach(KeyValuePair<String,Item> item in antecedente.items)
            {
                salida += "("+item.Value.name + ") \n";
            }
            return salida;
        }

        public String ToStringConsecuente()
        {
            String salida = "";
            foreach (KeyValuePair<String, Item> item in consecuente.items)
            {
                salida += "(" + item.Value.name + ") \n";
            }
            return salida;
        }
    }
}
