using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFuncaoParametro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação: a-adição s-subtração m-multiplicação d-divisão ");
            string ope = Console.ReadLine();

            operacao(n1, n2, ope);

            Console.ReadKey();
        }

        static void operacao(double v1, double v2, string ope)
        {
            double resultado;
            switch (ope)
            {
                case "a":
                    resultado = v1 + v2;
                    Console.WriteLine("O resultado é " + resultado);
                    break;

                case "s":
                    resultado = v1 - v2;
                    Console.WriteLine("O resultado é " + resultado);
                    break;

                case "m":
                    resultado = v1 * v2;
                    Console.WriteLine("O resultado é " + resultado);
                    break;

                case "d":
                    resultado = v1/v2;
                    Console.WriteLine("O resultado é " + resultado);
                    break;
            }
            Console.ReadKey();
        }

    }
}
