using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.ULExtractor
{
    static class AssemblyHelper
    {
        public static T GetAssemblyAttribute<T>(this Assembly assembly)
            where T : Attribute
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(T), false);

            T attribute = null;
            if (attributes.Length > 0)
            {
                attribute = attributes[0] as T;
            }
            return attribute;
        }

        public static IEnumerable<BoundedContextLanguage> LoadContextLanguages(this Assembly assembly)
        {
            // Identify contexts by finding all types with a namespace containing "*.Models.<TypeName>"
            // - The namespace one step up either represents a module or a bounded context,
            //   depending on whether the name ends in "Module"

            return null;
        }
    }
}
