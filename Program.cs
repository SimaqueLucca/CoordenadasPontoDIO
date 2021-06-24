using System;

namespace CoordenadasPontoDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            string entrada = Console.ReadLine();
            x = double.Parse(entrada.Split(" ")[0]);
            y = double.Parse(entrada.Split(" ")[1]);

            if (x == 0 && y == 0)
            {
                System.Console.WriteLine("Origem");
            }

            else if (x != 0 && y == 0)
            {
                System.Console.WriteLine("Eixo X");
            }

            else if (y != 0 && x == 0)
            {
                System.Console.WriteLine("Eixo Y");
            }

            else
            {
                if (x > 0 && y > 0)
                {
                    System.Console.WriteLine("Q1");
                }

                else if (x > 0 && y < 0)
                {
                    System.Console.WriteLine("Q4");
                }

                else if (x < 0 && y < 0)
                {
                    System.Console.WriteLine("Q3");
                }

                else if (x < 0 && y > 0)
                {
                    System.Console.WriteLine("Q2");
                }
            }
        }
    }
}
