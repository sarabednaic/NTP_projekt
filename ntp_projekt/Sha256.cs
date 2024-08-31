using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ntp_projekt
{
    internal class Sha256
    {
        //generiranje promjenjive soli
        //n je velicina soli u bitovima
        public static string PromjenjivaSol()
        {
            var sol = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                //generira nasumične znakove za kako bi popunio bitove soli
                rng.GetBytes(sol);
            }
            return Convert.ToBase64String(sol);
        }

        //dodaje sol lozinci te ih hashira
        public static string Sazimanje(string lozinka, string sol)
        {
            using (var sha256 = SHA256.Create())
            {
                string lozinkaSol = lozinka + sol;
                var hashiranje = sha256.ComputeHash(Encoding.UTF8.GetBytes(lozinkaSol));
                return Convert.ToBase64String(hashiranje);
            }
        }
    }
}

