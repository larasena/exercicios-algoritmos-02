using System;

namespace PTI___Algorimtos_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetorCompleto = gerarVetor();
            int maiorValor = encontraMaiorValor(vetorCompleto);
            int menorValor = encontraMenorValor(vetorCompleto);
            int diferencaEntreValores = diferenca(maiorValor, menorValor);
            bool ordemVetor = ordemCrescente(vetorCompleto);

            Console.WriteLine(string.Join(",", vetorCompleto));
            Console.WriteLine("A maior diferença entre os valores é: " + diferencaEntreValores);
            Console.WriteLine("O vetor está em ordem? " + ordemVetor);
            Console.ReadLine();
        }

        public static int[] gerarVetor()
        {
            Console.WriteLine("A partir de 1, quantos valores deseja inserir?");
            int tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine("Quais valores deseja escrever? (Positivos, Negativos ou Zero)");
            int[] valores = new int[tamanho];

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = int.Parse(Console.ReadLine());
            }
            return valores;
        }

        public static int encontraMaiorValor(int[] valores)
        {
            int maior = -2147483648;

            for (int i = 0; i < valores.Length; i++)
            {
                if (maior < valores[i])
                    maior = valores[i];
            }
            return maior;
        }

        public static int encontraMenorValor(int[] valores)
        {
            int menor = 2147483647;

            for (int i = 0; i < valores.Length; i++)
            {
                if (menor > valores[i])
                    menor = valores[i];
            }
            return menor;
        }

        public static int diferenca(int num1, int num2)
        {
            int dif = num1 - num2;
            return dif;
        }

        public static bool ordemCrescente(int[] valores)
        {
            bool estaEmOrdem = false;
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] < valores[i++])
                    estaEmOrdem = true;
                else
                    estaEmOrdem = false;
            }
            return estaEmOrdem;
        }
    }
}

