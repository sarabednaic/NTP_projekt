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
        // Generira nasumičnu sol
        public static string NasumicnaSol(int n = 16)
        {
            var sol = new byte[n];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(sol);
            }
            return Convert.ToBase64String(sol);
        }

        // Sažima lozinku koristeći SHA-256 i dodaje sol
        public static string Sazimanje(string lozinka, string sol)
        {
            using (var sha256 = SHA256.Create())
            {
                var lozinkaSol = lozinka + sol;
                var hashiranje = sha256.ComputeHash(Encoding.UTF8.GetBytes(lozinkaSol));
                return Convert.ToBase64String(hashiranje);
            }
        }
    }
}

