using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.ULExtractor
{
    class ModuleLanguage : TerminologyItem
    {
        public List<Concept> Concepts { get; set; }

        public ModuleLanguage()
        {
            Concepts = new List<Concept>();
        }
    }
}
