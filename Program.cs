using System;

namespace TestConcatArray
{
    class Program
    {
        static void Main(string[] args) // Cílem tohoto programu je aby vypsal oboje pole v abecedním pořadí a to nejdříve velké a pak malé písmena z jednoho dlouhého pole (Za předpokladu že je každé pole již abecedně seřazeno.)
        {
            string[] upper_alpha = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] lower_alpha = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] alpha = new string[lower_alpha.Length + upper_alpha.Length];
            int alpha_len = 0; // Pomocná proměnná pro délku pole alpha
            int arr_len = 0; // "Sloupec" ve kterém se právě pohybujeme (Obě pole budou mít stejný index takže i stejné písmeno lišící se pouze "velikostí")
            do // Uloží všechny hodnoty v pořadí A, a, B, b, C, ...
            {
                alpha[alpha_len] = upper_alpha[arr_len];
                alpha_len++;
                alpha[alpha_len] = lower_alpha[arr_len];
                alpha_len++;
                arr_len++;
            } while (alpha_len < alpha.Length);

            for (int i = 0; i < alpha.Length; i++) // Vypíše celé pole alpha do jednoho dlouhého řetězce na výstup
            {
                Console.Write(alpha[i]);
            }
        }
    }
}
