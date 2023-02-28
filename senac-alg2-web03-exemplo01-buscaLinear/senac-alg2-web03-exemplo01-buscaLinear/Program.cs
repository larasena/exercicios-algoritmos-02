using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web03_exemplo01_buscaLinear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elementos = new int[] { 2, 6, 3, 8, 1, 9, 7 };
            int pos = buscar(elementos, 8);
            Console.WriteLine("Posição: " + pos);
            Console.ReadLine();
        }

        static public int buscar(int[] elementos, int valor)
        {
            for(int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] == valor)
                    return i;
            }
            return -1;
        }
    }
}
