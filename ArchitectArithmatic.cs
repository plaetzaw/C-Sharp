using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            double totalArea = ((Rect(2500, 1500)) + (Circle(375)) + (Triangle(750, 500)));
            double cost = 180 * totalArea;
            cost = Math.Round(cost, 2);
            Console.WriteLine($"Teotihucan spans {totalArea} meters and costed {cost} pesos");

            double totalAreaTM = (Rect(90.5, 90.5)) - 2 * Rect(24, 24);
            Console.WriteLine(totalAreaTM);
            double totalCostTM = 180 * totalAreaTM;
            totalCostTM = Math.Round(totalCostTM, 2);
            Console.WriteLine($"Taj Mahal spans {totalAreaTM} meters and costed {totalCostTM} pesos!");

            double totalAreaMM = Triangle(264, 84) + Rect(200, 264) + Rect(106, 180);
            double totalCostMM = 180 * totalAreaMM;
            totalCostMM = Math.Round(totalCostMM, 2);
            Console.WriteLine($"Great Mosque of Mecca spans {totalAreaMM} meters and costed {totalCostMM} pesos!");

        }
        static double Rect(double length, double width)
        {
            return (length) * (width);
        }
        static double Circle(double radius)
        {
            return (Math.PI) * Math.Pow(radius, 2);
        }
        static double Triangle(double bottom, double height)
        {
            return 0.5 * (bottom) * (height);
        }
    }
}
