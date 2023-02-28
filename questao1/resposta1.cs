using System;

namespace resposta
{
    public class questao1
    {
        static void Main(string[] args)
        {
            int indice = 13;
            int K = 0;
            int soma = 0;
            while(K<indice)
            {
                K = K + 1;
                soma = soma + K;
            }

            Console.WriteLine(soma);
        }
    }
}