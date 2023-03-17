using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senac_alg2_web05_exemplo01_classe
{
    class Retangulo
    {
        public int Base;
        public int Altura;

        public void Info()
        {
            Console.WriteLine($"Base {this.Base} - Altura {this.Altura}");
        }

        public int CalcularArea()
        {
            int area = this.Base * this.Altura;
            return area;
        }
    }
}
