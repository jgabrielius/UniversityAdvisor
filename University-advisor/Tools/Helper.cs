using System;
using System.Security.Cryptography;
using System.Text;

namespace University_advisor.Tools
{
    public static class Helper
    {
        public static string CreateMD5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] outputBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < outputBytes.Length; i++)
            {
                sb.Append(outputBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
