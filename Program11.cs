using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número entre 0 e 4 para que ele seja escrito por extenso: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                default:
                    Console.WriteLine("Número Inválido");
                    break;

            }
            Console.ReadLine();
        }
    }
}
