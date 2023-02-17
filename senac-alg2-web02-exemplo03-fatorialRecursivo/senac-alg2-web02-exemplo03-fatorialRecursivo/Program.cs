using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web02_exemplo03_fatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            int f = fatorial(n);

            Console.WriteLine("Fatorial é " + f);
            Console.ReadLine();
        }

        public static int fatorial(int numero)
        {
            if (numero == 1)
                return 1;

            return numero * fatorial(numero - 1);
        }
    }
}
