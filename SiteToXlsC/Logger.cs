using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace SiteToXlsC
{
    class MyLogger
    {
        public static Logger Instance = LogManager.GetLogger("MyClassName");

        public static void Debug(string message, params object[] args)
        {
            Instance.Debug(message, args);
            Console.WriteLine(message, args);
        }

        public static void Error(Exception exc)
        {
            Instance.Error(exc);
            Console.WriteLine(exc.Message);
        }

        public static void Info(string message, params object[] args)
        {
            Instance.Info(message, args);
            Console.WriteLine(message, args);
        }
    }
}
