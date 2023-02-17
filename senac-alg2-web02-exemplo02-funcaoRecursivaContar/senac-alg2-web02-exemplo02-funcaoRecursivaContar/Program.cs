using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web02_exemplo02_funcaoRecursivaContar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");

            contar(int.Parse(Console.ReadLine()));
            Console.ReadLine();
        }

        public static void contar(int n)
        {
            if (n == 0)
                return;

            Console.WriteLine(n);
            contar(n - 1);
        }
    }
}
