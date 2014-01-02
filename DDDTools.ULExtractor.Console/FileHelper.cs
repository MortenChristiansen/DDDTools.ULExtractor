using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.ULExtractor.Console
{
    static class FileHelper
    {
        public static void SaveCssFile()
        {
            var assembly = Assembly.GetAssembly(typeof(FileHelper));
            using (Stream input = assembly.GetManifestResourceStream(assembly.GetName().Name + "." + "style.css"))
            using (Stream output = File.Create("style.css"))
            {
                CopyStream(input, output);
            }
        }

        private static void CopyStream(Stream input, Stream output)
        {
            // Insert null checking here for production
            byte[] buffer = new byte[8192];

            int bytesRead;
            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }
    }
}
