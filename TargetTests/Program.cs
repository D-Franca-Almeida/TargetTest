using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetTests
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Avaliação Target");

            Console.WriteLine("1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;" +
                "\r\nEnquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }" + 
                "\r\nImprimir(SOMA);\r\nAo final do processamento, qual será o valor da variável SOMA?");

            int INDICE = 13;
            int SOMA = 0;
            for(int K =0; K < INDICE; K++)
            {
                SOMA += K;
            }
            Console.WriteLine($"O valor da SOMA é: {SOMA}");
            Console.WriteLine("--------------------");
            Console.WriteLine("Próximo Exercício");
            Console.ReadKey();


        }
    }
}
