using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Xend.Utilities
{
    public class XKeyHash
    {

        public string Hash(string d)
        {
            byte[] data = new byte[d.Length];
            byte[] result;

            SHA1 sha = new SHA1CryptoServiceProvider();
            // This is one implementation of the abstract class SHA1.
            result = sha.ComputeHash(data);


            return Convert.ToBase64String(result);
        }
    }
}
