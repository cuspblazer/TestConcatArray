using System;

namespace SimpleConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] upper_alpha = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] lower_alpha = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] alpha = new string[upper_alpha.Length + lower_alpha.Length]; // Deklarace pole alpha s velikostí 52 (Součet délek polí upper_alpha a lower_alpha)
            upper_alpha.CopyTo(alpha, 0);
            lower_alpha.CopyTo(alpha, upper_alpha.Length); // Přidá pole lower_alpha začínajíci na indexu 26 (Velké "z" je na indexu 25)(Vzdálenost pole upper_alpha)

            for (int i = 0; i < alpha.Length; i++)
            {
                Console.Write(alpha[i]);
            }
        }
    }
}
