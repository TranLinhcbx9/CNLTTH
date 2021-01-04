using LK_API.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace LK_API.Data.DAO
{
    public class UserDAO
    {
        LKDbContext db = null;
        public UserDAO()
        {
            db = new LKDbContext();
            db.Configuration.ProxyCreationEnabled = false;
        }
        public bool LoginAsync(string username, string password)
        {
            var user = db.Users.Where(x => x.userName.Equals(username)).FirstOrDefault();
            string encrypt = EncryptPassword(password);
            if (user != null)
            {
                if (user.passWord == encrypt)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }


        public static string EncryptPassword(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}