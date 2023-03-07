using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web04_exemplo03_selectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seraOrdenado = { 64, 25, 12, 22, 11 };
            int[] ordenado = ordenar(seraOrdenado);
            Console.WriteLine(String.Join(",", ordenado));
            Console.ReadLine();
        }

        public static int[] ordenar(int[] itens)
        {
            int totalItens = itens.Length;
            for (int i = 0; i < totalItens - 1; i++)
            {
                int posMenorItem = i;
                for (int j = i + 1; j < totalItens; j++)
                {
                    if (itens[j] < itens[posMenorItem])
                        posMenorItem = j;
                }
                int temp = itens[posMenorItem];
                itens[posMenorItem] = itens[i];
                itens[i] = temp;
            }
            return itens;
        }
    }
}
