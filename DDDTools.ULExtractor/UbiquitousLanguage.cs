using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.ULExtractor
{
    public class UbiquitousLanguage
    {
        internal List<BoundedContextLanguage> BoundedContextLanguages { get; set; }

        private UbiquitousLanguage()
        {
            BoundedContextLanguages = new List<BoundedContextLanguage>();
        }

        public static UbiquitousLanguage Create(string directoryPath)
        {
            var language = new UbiquitousLanguage();
            language.Load(directoryPath);
            return language;
        }

        private void Load(string directoryPath)
        {
            throw new NotImplementedException();
        }
    }
}
