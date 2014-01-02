using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.ULExtractor
{
    public static class Log
    {
        public static Action<string> LogAction { get; set; }

        static Log()
        {
            LogAction = m => Debug.WriteLine(m);
        }

        public static void LogMessage(string message)
        {
            LogAction(message);
        }

        public static void LogMessage(string message, params object[] args)
        {
            LogAction(string.Format(message, args));
        }
    }
}
