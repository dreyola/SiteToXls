using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SiteToXlsC
{
    class PageParser
    {
        internal string Parse(string link)
        {
            return ParseDetails(WebHelper.GetHtml(link), link);
        }

        private string ParseDetails(string html, string link)
        {
            var start = html.IndexOf(@"<table width=""100%"" border=""1"" cellspacing=""0"" cellpadding=""2"" align=""center"" bgcolor=""#ffffff"">");
            var end = Math.Abs(start - html.IndexOf("</table>") - 8);
            var table = html.Substring(
                start,
                end);

            MyLogger.Info("Parsing details of {0}", link);
            var sb = new List<string>();

            var doc = new XmlDocument();
            doc.LoadXml(table);

            XmlNodeList nodeList = doc.SelectNodes("//tr");

            for (var i = 1; i < nodeList.Count; i++)
            {
                var trNode = nodeList[i];
                for (int j = 1; j < trNode.ChildNodes.Count - 2; j++)
                {
                    sb.Add(WebHelper.RemoveLineEndings(WebHelper.StripHTML(trNode.ChildNodes[j].InnerText)));
                }
            }
            sb.Add(link);
            return string.Join(",", sb);
        }
    }
}
