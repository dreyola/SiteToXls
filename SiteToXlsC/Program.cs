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
                new XlsConverter(@"C:\temp\sdamNaLeto\rooms1k.xls")).Convert();

            new SiteParser(
                new LinksCollector(new[] { "http://sdamnaleto.com/2k/" }),
                new PageParser(),
                new XlsConverter(@"C:\temp\sdamNaLeto\rooms2k.xls")).Convert();

            new SiteParser(
                new LinksCollector(new[] { "http://sdamnaleto.com/3k/" }),
                new PageParser(),
                new XlsConverter(@"C:\temp\sdamNaLeto\rooms3k.xls")).Convert();

            new SiteParser(
                new LinksCollector(new[] { "http://sdamnaleto.com/4k/" }),
                new PageParser(),
                new XlsConverter(@"C:\temp\sdamNaLeto\rooms4k.xls")).Convert();

            new SiteParser(
                new LinksCollector(new[] { "http://sdamnaleto.com/chastnyj-sektor/" }),
                new PageParser(),
                new XlsConverter(@"C:\temp\sdamNaLeto\chastnyj-sektor.xls")).Convert();

            Console.WriteLine("Finished. {0} ", DateTime.Now);
            Console.ReadLine();
        }
    }
}
