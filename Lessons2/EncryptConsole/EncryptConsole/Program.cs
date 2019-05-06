using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Configuration;
using System.IO;

using static System.Console;


namespace EncryptConsole
{
    class Program
    {
        public static void encrypt()
        {
            WriteLine("Encrypt string:");
            
            string password = ConfigurationManager.AppSettings["Password"];

            byte[] entropy = { 1, 2, 3, 4, 5 };

            byte[] byte_pwd = Encoding.UTF8.GetBytes(password);

            byte[] encrypted_pwd = ProtectedData.Protect(byte_pwd, entropy, DataProtectionScope.CurrentUser);
            
            File.WriteAllBytes(@"encrypted_pwd.txt", encrypted_pwd);
            
            WriteLine("OK");
        }

        public static void decrypt()
        {
            byte[] entropy = { 1, 2, 3, 4, 5 };

            //string encrypted_str_pwd = File.ReadAllText(@"encrypted_pwd.txt");

            byte[] encrypted_pwd = File.ReadAllBytes(@"decrypted_pwd.txt"); 

            //byte[] encrypted_pwd = Encoding.UTF8.GetBytes(encrypted_str_pwd);

            byte[] decrypted_pwd = ProtectedData.Unprotect(encrypted_pwd, entropy, DataProtectionScope.CurrentUser);

            string decrypted_str_pwd = Encoding.UTF8.GetString(decrypted_pwd);

            WriteLine("Decrypted password: {0}", decrypted_str_pwd);
        }

        static void Main(string[] args)
        {
            //encrypt();
            decrypt();

            ReadKey();
        }
    }
}
