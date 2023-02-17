using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web02_exemplo01_funcaoDobro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            int n = int.Parse(Console.ReadLine());

            int resposta = dobro(n);

            Console.WriteLine("O dobro é " + resposta);
            Console.ReadLine();
        }

        public static int dobro(int numero)
        {
            int a = numero * 2;
            return a;
        }

        
    }
}
