using System.Security.Cryptography;
using System.Text;

namespace BasicLogin
{
    public static class Hashing
    {
        public static byte[] HashPassword(string password)
        {
             SHA256 sha256 = SHA256.Create();
             UTF8Encoding encoding = new UTF8Encoding();

             var bytePassword = encoding.GetBytes(password);

             return sha256.ComputeHash(bytePassword);

        }
    }
}
