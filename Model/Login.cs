using System;
using System.Security.Cryptography;
using System.Text;

namespace Model
{
    public class Login
    {
        public string Usr { get; set; }
        public string Psw { get; set; }

        public string HashPsw(string psw)
        {
            if (psw.Length < 7)
                psw = "salting-this-pass-is-awesome" + psw;
            else
                psw += "donttrytohackthispsw";

            using (SHA1Managed md5hash = new SHA1Managed())
            {
                byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(psw));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in data)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
