 using System;

namespace Bhaskara
{
    using System;

    namespace BhaskaraFormula
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Insira os valores de a, b e c para a equação de segundo grau (ax^2 + bx + c = 0):");
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                double c = double.Parse(Console.ReadLine());

                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("A equação não possui raízes reais.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("A equação possui apenas uma raiz real: x = " + x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("A equação possui duas raízes reais: x1 = " + x1 + ", x2 = " + x2);
                }
            }
        }
    }
}
