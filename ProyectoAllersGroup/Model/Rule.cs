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
        public ItemSet antecedente { get; set; }
        public ItemSet consecuente { get; set; }

        public ItemSet padre { get; set; }

        public Rule()
        {
            antecedente = new ItemSet();
            consecuente = new ItemSet();
        }
    }
}
