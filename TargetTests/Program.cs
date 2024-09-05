using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace TargetTests
{
    internal class Program
    {
        public class Faturamento
        {
            public int dia { get; set; }
            public double valor { get; set; }
        }

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
            Console.WriteLine("--------------------");
            Console.WriteLine("2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor" +
                " sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),"+
                " escreva um programa na linguagem que desejar onde, informado um número, ele calcule a "+
                "sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não "+
                "a sequência.\r\n\r\nIMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua"+
                " preferência ou pode ser previamente definido no código;");
            Console.WriteLine("--------------------");

            Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
            int numero = int.Parse(Console.ReadLine());

            
            if (PertenceFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Próximo Exercício");
            Console.WriteLine("--------------------");
            Console.WriteLine("3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, "+
                "faça um programa, na linguagem que desejar, que calcule e retorne:\r\n• "+
                "O menor valor de faturamento ocorrido em um dia do mês;\r\n• "+
                "O maior valor de faturamento ocorrido em um dia do mês;\r\n• "+
                "Número de dias no mês em que o valor de faturamento diário foi superior à média mensal."+
                "\r\n\r\nIMPORTANTE:\r\na) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;\r\nb)"+
                " Podem existir dias sem faturamento, como nos finais de semana e feriados. "+
                "Estes dias devem ser ignorados no cálculo da média;\r\n");

            string faturamento_ = "[\r\n\t{\r\n\t\t\"dia\": 1,\r\n\t\t\"valor\": 22174.1664\r\n\t},\r\n\t{\r\n\t\t\"dia\": 2,\r\n\t\t\"valor\": 24537.6698\r\n\t},\r\n\t{\r\n\t\t\"dia\": 3,\r\n\t\t\"valor\": 26139.6134\r\n\t},\r\n\t{\r\n\t\t\"dia\": 4,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 5,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 6,\r\n\t\t\"valor\": 26742.6612\r\n\t},\r\n\t{\r\n\t\t\"dia\": 7,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 8,\r\n\t\t\"valor\": 42889.2258\r\n\t},\r\n\t{\r\n\t\t\"dia\": 9,\r\n\t\t\"valor\": 46251.174\r\n\t},\r\n\t{\r\n\t\t\"dia\": 10,\r\n\t\t\"valor\": 11191.4722\r\n\t},\r\n\t{\r\n\t\t\"dia\": 11,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 12,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 13,\r\n\t\t\"valor\": 3847.4823\r\n\t},\r\n\t{\r\n\t\t\"dia\": 14,\r\n\t\t\"valor\": 373.7838\r\n\t},\r\n\t{\r\n\t\t\"dia\": 15,\r\n\t\t\"valor\": 2659.7563\r\n\t},\r\n\t{\r\n\t\t\"dia\": 16,\r\n\t\t\"valor\": 48924.2448\r\n\t},\r\n\t{\r\n\t\t\"dia\": 17,\r\n\t\t\"valor\": 18419.2614\r\n\t},\r\n\t{\r\n\t\t\"dia\": 18,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 19,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 20,\r\n\t\t\"valor\": 35240.1826\r\n\t},\r\n\t{\r\n\t\t\"dia\": 21,\r\n\t\t\"valor\": 43829.1667\r\n\t},\r\n\t{\r\n\t\t\"dia\": 22,\r\n\t\t\"valor\": 18235.6852\r\n\t},\r\n\t{\r\n\t\t\"dia\": 23,\r\n\t\t\"valor\": 4355.0662\r\n\t},\r\n\t{\r\n\t\t\"dia\": 24,\r\n\t\t\"valor\": 13327.1025\r\n\t},\r\n\t{\r\n\t\t\"dia\": 25,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 26,\r\n\t\t\"valor\": 0.0\r\n\t},\r\n\t{\r\n\t\t\"dia\": 27,\r\n\t\t\"valor\": 25681.8318\r\n\t},\r\n\t{\r\n\t\t\"dia\": 28,\r\n\t\t\"valor\": 1718.1221\r\n\t},\r\n\t{\r\n\t\t\"dia\": 29,\r\n\t\t\"valor\": 13220.495\r\n\t},\r\n\t{\r\n\t\t\"dia\": 30,\r\n\t\t\"valor\": 8414.61\r\n\t}\r\n]";

            
            List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(faturamento_);

            List<double> valoresValidos = new List<double>();

           
            foreach (var faturamento in faturamentos)
            {
                if (faturamento.valor > 0)
                {
                    valoresValidos.Add(faturamento.valor);
                }
            }

            double menorValor = double.MaxValue;
            double maiorValor = double.MinValue;
            double somaFaturamento = 0;

            foreach (var valor in valoresValidos)
            {
                if (valor < menorValor)
                {
                    menorValor = valor;
                }

                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }

                somaFaturamento += valor;
            }

            double mediaMensal = somaFaturamento / valoresValidos.Count;

            int diasAcimaDaMedia = 0;
            foreach (var valor in valoresValidos)
            {
                if (valor > mediaMensal)
                {
                    diasAcimaDaMedia++;
                }
            }
            Console.WriteLine($"Menor valor de faturamento: {menorValor:F2}");
            Console.WriteLine($"Maior valor de faturamento: {maiorValor:F2}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");

            Console.WriteLine("--------------------");
            Console.WriteLine("Próximo Exercício");
            Console.WriteLine("--------------------");
            Console.WriteLine("4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:"+"" +
                "\r\n• SP – R$67.836,43"+
                "\r\n• RJ – R$36.678,66"+
                "\r\n• MG – R$29.229,88"+
                "\r\n• ES – R$27.165,48+"+
                "\r\n• Outros – R$19.849,53\r\n\r\n"+
                "Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado" +
                "teve dentro do valor total mensal da distribuidora.  ");
            Dictionary<string, double> faturamentoPorEstado = new Dictionary<string, double>
            {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
            };
            
            double faturamentoTotal = 0;
            foreach (var valor in faturamentoPorEstado.Values)
            {
                faturamentoTotal += valor;
            }
   
            Console.WriteLine("Percentual de representação por estado:");
            foreach (var estado in faturamentoPorEstado)
            {
                double percentual = (estado.Value / faturamentoTotal) * 100;
                Console.WriteLine($"{estado.Key}: {percentual:F2}%");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Próximo Exercício");
            Console.WriteLine("--------------------");
            Console.WriteLine("5) Escreva um programa que inverta os caracteres de um string."+
                "\r\n\r\nIMPORTANTE:\r\n"+
                "a) Essa string pode ser informada através de qualquer entrada de sua preferência "+
                "ou pode ser previamente definida no código;\r\n"+
                "b) Evite usar funções prontas, como, por exemplo, reverse;");
            Console.WriteLine("------------------");
            Console.WriteLine("Digite a palavra que quer inverter: ");
            string original = Console.ReadLine();

            
            string invertida = "";

            for (int i = original.Length - 1; i >= 0; i--)
            {
                invertida += original[i];
            }

            
            Console.WriteLine("String invertida: " + invertida);
            Console.ReadKey();


        }
        static bool PertenceFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            while (a <= n)
            {
                if (a == n)
                    return true;

                
                int temp = a;
                a = b;
                b = temp + b;
            }

            return false;
        }
    }
}
