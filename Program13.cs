using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a letra que você quer verificar se é vogal ou consoante: ");
            char verif = char.Parse(Console.ReadLine());

            switch (verif)
            {
                case 'a':
                {
                        Console.WriteLine("A letra inserida é vogal.");
                        break;
                }
                case 'e':
                    {
                        Console.WriteLine("A letra inserida é vogal.");
                        break;
                    }
                case 'i':
                    {
                        Console.WriteLine("A letra inserida é vogal.");
                        break;
                    }
                case 'o':
                    {
                        Console.WriteLine("A letra inserida é vogal.");
                        break;
                    }
                case 'u':
                    {
                        Console.WriteLine("A letra inserida é vogal.");
                        break;
                    }
                default:
                    Console.WriteLine("A letra inserida é consoante.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
