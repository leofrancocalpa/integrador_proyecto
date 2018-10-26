using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RuleGenerator
    {
        public double minConfidence { get; set; }
        public List<Rule> associationRUles { get; } 

        public RuleGenerator(double minConf)
        {
            associationRUles = new List<Rule>();
            minConfidence = minConf;
        }

        public void GenerateRules(List<ItemSet> frequentsItemSets)
        {

        }

        public void PrunningRules()
        {

        }
    }
}
