using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse
{
    public class PasswordEncryptor
    {
        private static readonly int SaltSize = 16;        // размер соли в байтах
        private static readonly int HashSize = 20;        // размер хэша в байтах
        private static readonly int Iterations = 10000;   // число итераций для функции PBKDF2


        public static bool CheckPassword(string password, string hash)
        {
            byte[] hashBytes = Convert.FromBase64String(hash);
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            byte[] hashToCheck = GetHash(password, salt);


            for (int i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hashToCheck[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static string Encrypt(string password)
        {
            byte[] salt = GenerateSalt();
            byte[] hash = GetHash(password, salt);

            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);
            
            return Convert.ToBase64String(hashBytes);
        }

        private static byte[] GetHash(string password, byte[] salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);
            return hash;
        }

        private static byte[] GenerateSalt()
        {
            byte[] salt = new byte[SaltSize];
            RandomNumberGenerator.Fill(salt);
            return salt;
        }
    }
}
