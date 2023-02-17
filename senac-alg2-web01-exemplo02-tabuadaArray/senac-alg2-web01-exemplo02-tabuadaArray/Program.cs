using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web01_exemplo02_tabuadaArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para calcular a tabuada: ");
            int n = int.Parse(Console.ReadLine());

            int[] tabuada = new int[11];

            for (int i = 0; i <= 10; i++)
            {
                int x = i * n;
                tabuada[i] = x;
            }

            for (int i = 0; i < tabuada.Length; i++)
            {
                int t = tabuada[i];
                Console.WriteLine("{0} x {1} = {2}", n, i, t);
            }

            Console.ReadLine();
        }
    }
}
