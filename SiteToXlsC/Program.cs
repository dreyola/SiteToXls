using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteToXlsC
{
    class Program
    {
        static void Main(string[] args)
        {
            new SiteParser(
                new LinksCollector(new []{"http://sdamnaleto.com/1k/"}),
                new PageParser(),
                new XlsConverter(string.Format(@"C:\temp\sdamNaLeto\rooms1k{0}.xls", DateTime.Now.ToString(".dd-mm-yy_hh")))).Convert();

            new SiteParser(
                new LinksCollector(new[] { "http://sdamnaleto.com/2k/" }),
                new PageParser(),
                new XlsConverter(string.Format(@"C:\temp\sdamNaLeto\rooms2k{0}.xls", DateTime.Now.ToString(".dd-mm-yy_hh")))).Convert();

            new SiteParser(
                new LinksCollector(new[] { "http://sdamnaleto.com/3k/" }),
                new PageParser(),
                new XlsConverter(string.Format(@"C:\temp\sdamNaLeto\rooms3k{0}.xls", DateTime.Now.ToString(".dd-mm-yy_hh")))).Convert();

            new SiteParser(
                new LinksCollector(new[] { "http://sdamnaleto.com/4k/" }),
                new PageParser(),
                new XlsConverter(string.Format(@"C:\temp\sdamNaLeto\rooms4k{0}.xls", DateTime.Now.ToString(".dd-mm-yy_hh")))).Convert();

            ////new SiteParser(
            ////    new LinksCollector(new[] { "http://sdamnaleto.com/chastnyj-sektor/" }),
            ////    new PageParser(),
            ////    new XlsConverter(@"C:\temp\sdamNaLeto\chastnyj-sektor.xls")).Convert();

            Console.WriteLine("Finished. {0} ", DateTime.Now);
            Console.ReadLine();
        }
    }
}
