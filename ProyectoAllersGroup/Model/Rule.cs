using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Rule
    {
        public double confidence { get; set; }
        public ItemSet antecedente { get; }
        public ItemSet consecuente { get; }

        public Rule()
        {
            antecedente = new ItemSet();
            consecuente = new ItemSet();
        }
    }
}
