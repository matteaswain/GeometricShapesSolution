using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)

        {
            var quadro = new Quadrolateral();
            quadro.SideA = 6;
            quadro.SideB = 5;
            quadro.SideC = 4;
            quadro.SideD = 3;

            Console.WriteLine($"{quadro.Parameter()}");


            var rect = new Rectangle();
            rect.Length = 12;
            rect.Width = 6;

            Console.WriteLine($"{rect.Parameter()}");
            Console.WriteLine($"{rect.Area()}");

            var sqr = new Square();
            sqr.Side = 17;

            Console.WriteLine($"{sqr.Parameter()}");
            Console.WriteLine($"{sqr.Area()}");
        }
    }
}

