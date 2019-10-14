using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_advisor.Constants;

namespace University_advisor.Tools
{
    public class Logger
    {
        private static readonly string path = "../../logs.log";

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
                Console.WriteLine(Messages.logCreateFailed);
                return;
            }
            else
            {
                var timestamp = DateTime.Now;
                using(StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("Timestamp: " + timestamp.ToString("yyyy-MM-dd HH:mm:ss") + " Message: " + message);
                    sw.Flush();
                }
            }
        }
    }
}
