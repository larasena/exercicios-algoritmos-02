using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web04_exemplo01_bubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seraOrdenado = { 9, 2, 1, 8, 5, 4 };
            int[] ordenado = ordenar(seraOrdenado);
            Console.WriteLine(String.Join(",", ordenado));
            Console.ReadLine();
        }
        public static int[] ordenar(int[] itens)
        {
            int totalDeItens = itens.Length; ;
            for (int i = 0; i < totalDeItens - 1; i++)
            {
                for (int j = 0; j < totalDeItens - i - 1; j++)
                {
                    if (itens[j] > itens[j + 1])
                    {
                        int temp = itens[j];
                        itens[j] = itens[j + 1];
                        itens[j + 1] = temp;
                    }
                }
            }
            return itens;
        }

    }
}
