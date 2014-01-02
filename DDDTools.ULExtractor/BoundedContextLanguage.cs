using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.ULExtractor
{
    class BoundedContextLanguage : TerminologyItem
    {
        public List<ModuleLanguage> ModuleLanguages { get; set; }
        public List<Concept> Concepts { get; set; }

        public BoundedContextLanguage()
        {
            ModuleLanguages = new List<ModuleLanguage>();
            Concepts = new List<Concept>();
        }
    }
}
