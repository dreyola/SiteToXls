using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteToXlsC
{
    class SiteParser
    {
        private LinksCollector linkCollector;
        private PageParser pageParser;
        private XlsConverter converter;
        public SiteParser(LinksCollector linkCollector, PageParser pageParser, XlsConverter converter)
        {
            this.linkCollector = linkCollector;
            this.pageParser = pageParser;
            this.converter = converter;
        }

        public void Convert()
        {
            MyLogger.Info("Conversion started: {0}", DateTime.Now);

            var sb = new StringBuilder();

            foreach(var link in linkCollector.GetLinks())
            {
                sb.AppendLine(this.pageParser.Parse(link));
            }

            this.converter.Convert(sb);
        }
    }
}
