using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web04_exemplo02_insertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seraOrdenado = { 7, 8, 5, 2, 4, 6, 3 };
            int[] ordenado = ordenar(seraOrdenado);
            Console.WriteLine(String.Join(",", ordenado));
            Console.ReadLine();
        }

        public static int[] ordenar(int[] itens)
        {
            int tamanho = itens.Length;
            for (int i = 1; i < tamanho; i++)
            {
                int item = itens[i];
                int anterior = i - 1;

                while (anterior >= 0 && itens[anterior] > item)
                {
                    itens[anterior + 1] = itens[anterior];
                    anterior = anterior - 1;
                }
                itens[anterior + 1] = item;
            }
            return itens;
        }
    }
}
