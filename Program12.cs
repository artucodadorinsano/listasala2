using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número que deseja calcular: ");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("1. Converter de centímetros para metros");
            Console.WriteLine("2. Converter de metros para centímetros");
            Console.WriteLine("3. Converter de milímetros para metros");
            Console.WriteLine("4. Converter de metros para milímetros");
            Console.WriteLine("Insira o número equivalente à operação que você quer utilizar: ");
            int calc = int.Parse(Console.ReadLine());

            double result1 = num / 100;
            double result2 = num * 100;
            double result3 = num / 1000;
            double result4 = num * 1000;


            switch (calc) {
                case 1:
                    Console.WriteLine("O resultado é "+result1+" metros.");
                    break;
                case 2:
                    Console.WriteLine("O resultado é " + result2+" centímetros.");
                    break;
                case 3:
                    Console.WriteLine("O resultado é " + result3+" metros.");
                    break;
                case 4: 
                    Console.WriteLine("O resultado é " + result4+" centímetros.");
                    break;
                default:
                    Console.WriteLine("Número de operaçâo inválido");
                    break;
            }
               

            Console.ReadLine();
        }
    }
}
