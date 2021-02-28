using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //bir password verecez dışarıya hash ve salt u çıkarıcaz
        public static void CreatePasswordHash(string password,out byte[] passwordHash, out byte[] passwordSalt) //passwrdoun hashi oluşacak
        {
            using (var hmac =new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; //algoritmanın o an oluşturdupu keydir.Her user için ayrı oluşturuluur yuakrıdaki HMAC512 tatrafından
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); //herhangi değerin byte karşılığını verir encoding kısmı passewordunkini aldık burada
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt) //out yok çünkü veri tabanındaki hash ile kullanıcının gönderdiği passworddaki hasi karşılaitıryoyz
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i])
                    {
                        return false;
                    }

                }
                return true;
            }
            
        }
    }
}
