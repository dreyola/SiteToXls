using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace SiteToXlsC
{
    class XlsConverter
    {
        string file;
        public XlsConverter(string fileName)
        {
            file = fileName;
        }
        internal void Convert(StringBuilder result)
        {
            File.WriteAllText(file, result.ToString(), Encoding.UTF8);
        }
    }
}
