using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrderBentoSystem.method
{
    public class PasswordHelper
    {
        /// <summary>
        /// 將密碼透過SHA256雜湊碼加密
        /// </summary>
        /// <param name="pwd">使用者密碼</param>
        /// <returns></returns>
        public static string Encrypt(string pwd)
        {
            if (pwd == null || pwd == "")
                return "";

            StringBuilder sb = new StringBuilder();

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] data = Encoding.UTF8.GetBytes(pwd);
                data = sha256.ComputeHash(data);

                foreach (var item in data)
                {
                    sb.Append(item.ToString("x2"));
                }
            }
            
            return sb.ToString();
        }
    }
}
