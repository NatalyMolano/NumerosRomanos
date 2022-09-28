using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos
{
    internal class numeros : Lista
    {
        static void Main(string [] args) 
        {
            Console.WriteLine("CONVERTIR NUMEROS ENTEROS A NUMEROS ROMANOS\nIngrese numero");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 999)
            {
                Console.WriteLine("Valor " ,n , " No esta permitido");
            }

            string[] U = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            /*10 AL 90*/
            string[] D = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            /*100 A 1000*/
            string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", "M" };

            Lista lista = new Lista();

            int c, d, u, resto;

            resto = n % 1000;
            c = resto / 1000;
            resto = n% 100;
            d = resto / 10;
            resto = resto % 10;
            u = resto;

            Console.WriteLine(C.ElementAtOrDefault(c) +D.ElementAtOrDefault(d) +U.ElementAtOrDefault(u));



        }
    }
}
