using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SiteToXlsC
{
    class LinksCollector
    {
        List<string> links = new List<string>();
        Regex regEx = new Regex(@"<a\s+href=(?:""([^""]+)""|'([^']+)').*?>(.*?)</a>");

        public LinksCollector(string[] listLinks)
        {
            this.listLinks = listLinks;
        }

        public string[] listLinks;
        public IEnumerable<string> GetLinks()
        {
            if (links.Count == 0)
            {
                MyLogger.Info("Init links");
                this.GenerateLinks2(this.listLinks);
            }

            return links;
        }

        private void GenerateLinks2(IEnumerable<string> listLinks)
        {
            foreach (var link in listLinks)
            {
                var html = WebHelper.GetHtml(link);
                MyLogger.Info("Getting links for list: {0}", link);
                
                foreach(Match match in regEx.Matches(html))
                {
                    if (match.Groups[0].Value.Contains("more-link"))
                    {
                        MyLogger.Info("Found link: {0}", match.Groups[1].Value);
                        links.Add(match.Groups[1].Value);
                        //return;
                    }
                }
            }
        }

        
    }
}
