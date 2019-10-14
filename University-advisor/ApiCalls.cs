using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using University_advisor.Tools;

namespace University_advisor
{
    class ApiCalls {
        public string GetLocationJson(string url) {
            var request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    var reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch(WebException ex)
            {
                var errorResponse = ex.Response;
                using (var responseStream = errorResponse.GetResponseStream())
                {
                    var reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    string errorText = reader.ReadToEnd();
                    Logger.Log(errorText);
                }
                throw;
            }
        }
    }
}
