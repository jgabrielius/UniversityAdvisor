using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_advisor.Tools
{
    public class Logger
    {
        private static readonly string path = Path.Combine(Directory.GetCurrentDirectory(), "logs.log");

        private static bool VerifyDirectory()
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void Log(string message)
        {
            if (!VerifyDirectory())
            {
                Console.WriteLine("Log file could not be be created");
                return;
            }
            else
            {
                var timestamp = DateTime.Now;
                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Timestamp: " + timestamp.ToString("yyyy-MM-dd HH:mm:ss") + " Message: " + message);
                }
            }
        }
    }
}
