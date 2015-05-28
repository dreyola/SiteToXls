using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace SiteToXlsC
{
    class WebHelper
    {   public static string GetHtml(string link)
        {
            var result = string.Empty;
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                client.Encoding = Encoding.UTF8;
                result = client.DownloadString(link);
            }

            return result;
        }

    const string HTML_TAG_PATTERN = "<.*?>";

    public static string StripHTML(string inputString)
    {
        return Regex.Replace
          (inputString, HTML_TAG_PATTERN, string.Empty);
    }

    public static string RemoveLineEndings(string value)
    {
        if (String.IsNullOrEmpty(value))
        {
            return value;
        }
        string lineSeparator = ((char)0x2028).ToString();
        string paragraphSeparator = ((char)0x2029).ToString();

        return value.Replace("\r\n", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty).Replace(lineSeparator, string.Empty).Replace(paragraphSeparator, string.Empty);
    }
    }
}
