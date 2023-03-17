using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web05_exemplo01_classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();
            r1.Base = 10;
            r1.Altura = 2;

            Retangulo r2 = new Retangulo();
            r2.Base = 20;
            r2.Altura = 4;

            r1.Info();
            r2.Info();

            int a1 = r1.CalcularArea();
            int a2 = r2.CalcularArea();

            Console.WriteLine("A área do retângulo 1 é " + a1);
            Console.WriteLine("A área do retângulo 2 é " + a2);
            Console.ReadLine();
        }

    }
}
