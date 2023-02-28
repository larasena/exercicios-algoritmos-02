using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web03_exemplo02_buscaBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elementos = new int[] { 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 14, 15, 16, 18, 19, 20 };
            int inicio = elementos[0];
            int fim = elementos.Length - 1;

            int busca = buscaBinaria(elementos, 10, inicio, fim);
            Console.WriteLine(busca);
            Console.ReadLine();
        }

        public static int buscaBinaria(int[] elementos, int valor, int inicio, int fim)
        {
            int meio = inicio + ((fim - inicio) / 2);

            if (fim < inicio)
                return -1;

            else if (valor == elementos[meio])
                return meio;

            else if (valor < elementos[meio])
                return buscaBinaria(elementos, valor, inicio, meio - 1);

            else
                return buscaBinaria(elementos, valor, meio + 1, fim);
        }
    }
}
