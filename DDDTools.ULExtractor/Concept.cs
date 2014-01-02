using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.ULExtractor
{
    class Concept : TerminologyItem
    {
        public List<ConceptAction> Actions { get; set; }

        public Concept()
        {
            Actions = new List<ConceptAction>();
        }
    }
}
