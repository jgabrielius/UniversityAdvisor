using System;
using System.Security.Cryptography;
using System.Text;

namespace University_advisor.Tools
{
    public static class Helper
    {
        public static string CreateMD5(string input)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var outputBytes = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < outputBytes.Length; i++)
            {
                sb.Append(outputBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
