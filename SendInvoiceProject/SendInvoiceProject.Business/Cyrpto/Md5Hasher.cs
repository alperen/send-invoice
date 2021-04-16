using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business.Cyrpto
{
    public static class Md5Hasher
    {
        public static string toMd5(string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            return Encoding.ASCII.GetBytes(str).ToMD5Hash();
        }

        public static string ToMD5Hash(this byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return null;

            using (var md5 = MD5.Create())
            {
                return string.Join("", md5.ComputeHash(bytes).Select(x => x.ToString("X2")));
            }
        }
    }
}
