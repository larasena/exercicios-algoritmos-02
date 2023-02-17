using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web01_exemplo01_tabuada_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número para calcular a tabuada: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int x = n * i;
                Console.WriteLine("{0} x {1} = {2}", n, i, x);
            }

            Console.ReadLine();
        }
    }
}
